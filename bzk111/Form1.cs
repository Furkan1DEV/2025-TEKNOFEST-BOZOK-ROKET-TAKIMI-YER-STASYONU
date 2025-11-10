using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoRaYerIstasyonu
{
    public partial class Form1 : Form
    {
        // Map and Markers
        private GMapOverlay markersOverlay;
        private GMarkerGoogle rocketMarker;
        private GMarkerGoogle payloadMarker;
        private PointLatLng lastRocketPosition;
        private PointLatLng lastPayloadPosition;
        private bool isMapDragging = false;
        private bool followMode = true;
        private bool parachuteDeployed = false;

        private bool isHyiConnected = false;
        private int packetCounter = 0;
        private byte[] hyiPacket = new byte[78];
        private SerialPort serialPortHyi = new SerialPort();
        private bool autoSendHyiEnabled = false;

        private readonly float payloadCenterCorrectionY = 1.0f;
        private readonly float rocketCenterCorrectionY = 0.0f;

        private float payloadCameraDistance = 10.0f;
        private float rocketCameraDistance = 10.0f;
        private bool isDragging = false;
        private Point lastMousePos;
        private Matrix4 rocketCameraRotation = Matrix4.Identity;
        private Matrix4 payloadCameraRotation = Matrix4.Identity;
        private float payloadRotationX = 0.0f;
        private float payloadRotationY = 0.0f;
        private float rocketRotationX = 0.0f;
        private float rocketRotationY = 0.0f;
        private Point lastMousePosition;

        // Serial Communication
        private SerialPort serialPort1;
        private SerialPort g_serialPort = new SerialPort();

        private float payloadAltitude = 0f;
        private double payloadLatitude = 0.0;
        private double payloadLongitude = 0.0;

        // 3D Visualization
        private Quaternion rocketRotation = Quaternion.Identity;
        private Quaternion payloadRotation = Quaternion.Identity;
        private ObjModel rocketModel;
        private ObjModel payloadModel;
        private bool glInitialized = false;

        // Roket verileri
        private float currentRocketAltitude = 0f;
        private double rocketLatitude = 0.0;
        private double rocketLongitude = 0.0;
        private float gyroX = 0f;
        private float gyroY = 0f;
        private float gyroZ = 0f;
        private float accelX = 0f;
        private float accelY = 0f;
        private float accelZ = 0f;
        private float tiltAngle = 0f;
        private float rocketStatus = 0f;
        private float currentRocketGPSAltitude = 0f;
        private float currentPayloadGPSAltitude = 0f;

        // Görev Yükü verileri
        private float currentPayloadAltitude = 0f;
       
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();


        }

        private void InitializeCustomComponents()
        {
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            serialPort1 = new SerialPort();
            dataTimer.Interval = 100;
            dataTimer.Tick += DataTimer_Tick;
            PopulateHYIPorts();
            cmbBaudRate.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeMap();
            InitializeSerialPortSettings();
            InitializeLabels();
            System.Threading.Thread.Sleep(1000);
            PopulateCOMPorts();
            UpdateConnectionStatusUI(false);
            chkFollowMap.Checked = followMode;
            this.Resize += Form1_Resize;
            Form1_Resize(this, EventArgs.Empty);
            PopulateHYIPorts();
            InitializeGL();
            LoadModels();
            PopulateGorevYukuPorts();
            cmbHyiBaud.Items.AddRange(new object[] { "19200", "9600", "57600", "115200" });
            cmbHyiBaud.SelectedIndex = 0;
        }

        private void InitializeLabels()
        {
            // Bu metot, form üzerindeki etiketlerin başlangıç değerlerini ayarlamak için kullanılabilir.
        }

        private void PopulateGorevYukuPorts()
        {
            gport.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            gport.Items.AddRange(ports);
            if (gport.Items.Count > 0)
                gport.SelectedIndex = 0;
        }
        private void gconnect_Click(object sender, EventArgs e)
        {
            if (g_serialPort.IsOpen)
            {
                try
                {
                    g_serialPort.Close();
                    UpdateGorevYukuConnectionStatus(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı kesilirken hata: " + ex.Message);
                }
            }
            else
            {
                if (gport.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir COM port seçiniz.");
                    return;
                }

                try
                {
                    g_serialPort.PortName = gport.SelectedItem.ToString();
                    g_serialPort.BaudRate = int.Parse(gbaud.SelectedItem.ToString());
                    g_serialPort.DataReceived += G_serialPort_DataReceived;
                    g_serialPort.Open();
                    UpdateGorevYukuConnectionStatus(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message);
                    UpdateGorevYukuConnectionStatus(false);
                }
            }
        }
        private void UpdateGorevYukuConnectionStatus(bool isConnected)
        {
            gconinduc.BackColor = isConnected ? Color.Green : Color.Red;
            gconnect.Text = isConnected ? "Bağlantıyı Kes" : "Bağlan";
        }
        private void G_serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (g_serialPort.IsOpen && g_serialPort.BytesToRead > 0)
            {
                try
                {
                    string data = g_serialPort.ReadLine();
                    this.Invoke(new Action(() => ProcessReceivedData(data)));

                }
                catch (TimeoutException) { }
                catch (Exception ex)
                {
                    this.Invoke(new Action(() =>
                        UpdateStatus("Görev Yükü veri hatası: " + ex.Message)));
                }
            }

        }

        private void InitializeMap()
        {
            try
            {
                GMaps.Instance.Mode = AccessMode.ServerAndCache;
                gMapControl1.MapProvider = BingMapProvider.Instance;
                gMapControl1.MinZoom = 2;
                gMapControl1.MaxZoom = 20;
                gMapControl1.Zoom = 15;
                gMapControl1.Position = new PointLatLng(41.0082, 28.9784);
                lastRocketPosition = gMapControl1.Position;
                lastPayloadPosition = new PointLatLng(lastRocketPosition.Lat + 0.0005, lastRocketPosition.Lng + 0.0005);

                markersOverlay = new GMapOverlay("markers");
                gMapControl1.Overlays.Add(markersOverlay);

                rocketMarker = new GMarkerGoogle(lastRocketPosition, GMarkerGoogleType.red_dot);
                rocketMarker.ToolTipText = "Roket";
                rocketMarker.ToolTipMode = MarkerTooltipMode.Always;
                markersOverlay.Markers.Add(rocketMarker);

                payloadMarker = new GMarkerGoogle(lastPayloadPosition, GMarkerGoogleType.blue_dot);
                payloadMarker.ToolTipText = "Görev Yükü";
                payloadMarker.ToolTipMode = MarkerTooltipMode.Always;
                markersOverlay.Markers.Add(payloadMarker);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Harita hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeSerialPortSettings()
        {
            serialPort1.DataReceived += SerialPort1_DataReceived;
            serialPort1.ReadTimeout = 500;
            serialPort1.WriteTimeout = 500;
        }

        private void InitializeGL()
        {
            if (!glInitialized)
            {
                GL.Enable(EnableCap.DepthTest);
                GL.Enable(EnableCap.Lighting);
                GL.Enable(EnableCap.Light0);

                GL.Light(LightName.Light0, LightParameter.Position, new Vector4(1.0f, 1.0f, 1.0f, 0.0f));
                GL.Light(LightName.Light0, LightParameter.Ambient, new Color4(0.2f, 0.2f, 0.2f, 1.0f));
                GL.Light(LightName.Light0, LightParameter.Diffuse, new Color4(0.8f, 0.8f, 0.8f, 1.0f));
                GL.Light(LightName.Light0, LightParameter.Specular, new Color4(1.0f, 1.0f, 1.0f, 1.0f));

                GL.Enable(EnableCap.ColorMaterial);
                GL.ColorMaterial(MaterialFace.Front, ColorMaterialParameter.AmbientAndDiffuse);

                GL.ClearColor(Color.White);
                glInitialized = true;
            }
        }

        private void LoadModels()
        {
            rocketModel = LoadObjModel("rocket.obj");
            payloadModel = LoadObjModel("payload.obj");
        }

        private ObjModel LoadObjModel(string fileName)
        {
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Models", fileName);
            if (!File.Exists(fullPath))
            {
                MessageBox.Show($"Dosya bulunamadı: {fullPath}");
                return null;
            }

            try
            {
                ObjModel model = new ObjModel();
                model.LoadFromFile(fullPath);
                return model;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Model yüklenirken hata oluştu: {ex.Message}");
                return null;
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.ClientSize.Height == 0 || gMapControl1 == null || statusStrip1 == null)
                return;

            int statusStripHeight = statusStrip1.Height;
            int availableHeight = this.ClientSize.Height - statusStripHeight;

            gMapControl1.Size = new Size(this.ClientSize.Width, availableHeight);
            this.BeginInvoke((MethodInvoker)delegate
            {
                gMapControl1.Invalidate();
            });
        }

        private void gMapControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) isMapDragging = true;
        }

        private void gMapControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) isMapDragging = false;
        }

        private void PopulateCOMPorts()
        {
            cmbPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cmbPorts.Items.AddRange(ports);
            if (cmbPorts.Items.Count > 0)
                cmbPorts.SelectedIndex = 0;
        }

        private void UpdateConnectionStatusUI(bool isConnected)
        {
            toolStripStatusLabel.Text = isConnected ? "Bağlantı kuruldu" : "Bağlantı yok";
            connectionStatusIndicator.BackColor = isConnected ? Color.LimeGreen : Color.Red;
            btnConnect.Text = isConnected ? "Bağlantıyı Kes" : "Bağlan";
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    dataTimer.Stop();
                    UpdateConnectionStatusUI(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı kesilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (cmbPorts.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir COM port seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    serialPort1.PortName = cmbPorts.SelectedItem.ToString();
                    serialPort1.BaudRate = int.Parse(cmbBaudRate.SelectedItem.ToString());
                    serialPort1.Open();
                    dataTimer.Start();
                    UpdateConnectionStatusUI(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı kurulurken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UpdateConnectionStatusUI(false);
                }
            }
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                try
                {
                    string data = serialPort1.ReadLine();
                    this.Invoke(new Action(() => ProcessReceivedData(data)));
                }
                catch (TimeoutException) { }
                catch (Exception ex)
                {
                    UpdateStatus("Veri okuma hatası: " + ex.Message);
                }
            }
        }

        private void DataTimer_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                try
                {
                    string data = serialPort1.ReadLine();
                    ProcessReceivedData(data);
                }
                catch (TimeoutException) { }
                catch (Exception ex)
                {
                    UpdateStatus("Veri okuma hatası: " + ex.Message);
                }
            }
        }

        private void ProcessReceivedData(string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return;
            data = data.Trim();
            UpdateStatus($"Alındı: {data}");
            string[] values = data.Split(',');
            if (values.Length < 1) return;
            string dataType = values[0];
            string[] dataValues = new string[values.Length - 1];
            Array.Copy(values, 1, dataValues, 0, dataValues.Length);

            if (dataType == "Roket" && dataValues.Length >= 16)
            {
                Task.Run(() =>
                {
                    ProcessRocketData(dataValues);
                    CreateHyiPacket();

                    // Otomatik gönderim açıksa paketi gönder
                    if (autoSendHyiEnabled)
                    {
                        this.Invoke((MethodInvoker)delegate { SendHyiPacket(); });
                    }
                });
            }
            else if (dataType == "GorevYuku" && dataValues.Length >= 16)
            {
                Task.Run(() => ProcessPayloadData(dataValues));
            }
        }
        private void ProcessRocketData(string[] values)
        {
            if (values.Length < 16) return;

            try
            {
                if (float.TryParse(values[0], NumberStyles.Any, CultureInfo.InvariantCulture, out float alt)) { currentRocketAltitude = alt; UpdateLabel(rirtifa, $"{alt:0.0} m"); }
                if (double.TryParse(values[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double lat) && double.TryParse(values[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double lon)) { rocketLatitude = lat; rocketLongitude = lon; UpdateLabel(renlem, lat.ToString("00.000000", CultureInfo.InvariantCulture)); UpdateLabel(rboylam, lon.ToString("00.000000", CultureInfo.InvariantCulture)); UpdateRocketPosition(lat, lon); }
                if (float.TryParse(values[3], NumberStyles.Any, CultureInfo.InvariantCulture, out float accX)) { this.accelX = accX; UpdateLabel(rivmeX, $"{accX:0.00} m/s²"); }
                if (float.TryParse(values[4], NumberStyles.Any, CultureInfo.InvariantCulture, out float accY)) { this.accelY = accY; UpdateLabel(rivmeY, $"{accY:0.00} m/s²"); }
                if (float.TryParse(values[5], NumberStyles.Any, CultureInfo.InvariantCulture, out float accZ)) { this.accelZ = accZ; UpdateLabel(rivmeZ, $"{accZ:0.00} m/s²"); }
                if (float.TryParse(values[6], NumberStyles.Any, CultureInfo.InvariantCulture, out float gyrX)) { this.gyroX = gyrX; UpdateLabel(rgyrox, $"{gyrX:F2}°/s"); }
                if (float.TryParse(values[7], NumberStyles.Any, CultureInfo.InvariantCulture, out float gyrY)) { this.gyroY = gyrY; UpdateLabel(rgyroy, $"{gyrY:F2}°/s"); }
                if (float.TryParse(values[8], NumberStyles.Any, CultureInfo.InvariantCulture, out float gyrZ)) { this.gyroZ = gyrZ; UpdateLabel(rgyroz, $"{gyrZ:F2}°/s"); }
                if (float.TryParse(values[9], NumberStyles.Any, CultureInfo.InvariantCulture, out float qW) && float.TryParse(values[10], NumberStyles.Any, CultureInfo.InvariantCulture, out float qX) && float.TryParse(values[11], NumberStyles.Any, CultureInfo.InvariantCulture, out float qY) && float.TryParse(values[12], NumberStyles.Any, CultureInfo.InvariantCulture, out float qZ)) { rocketRotation = new Quaternion(qX, qY, qZ, qW); rocketRotation.Normalize(); glControlRocket.Invalidate(); }
                if (float.TryParse(values[13], NumberStyles.Any, CultureInfo.InvariantCulture, out float rgpsalt)) { currentRocketGPSAltitude = rgpsalt; UpdateLabel(rgpsirtifa, $"{rgpsalt:0.0} m"); }
                if (float.TryParse(values[14], NumberStyles.Any, CultureInfo.InvariantCulture, out float angle)) { tiltAngle = (float)Math.Round(Math.Max(0f, Math.Min(angle, 180f)), 2); UpdateLabel(raçı, $"{angle:F2}°"); }
                if (float.TryParse(values[15], NumberStyles.Any, CultureInfo.InvariantCulture, out float status)) { rocketStatus = status; UpdateLabel(rdurum, $"{status:0}"); }
            }
            catch (Exception ex)
            {
                UpdateStatus("Roket veri hatası: " + ex.Message);
            }
        }

        private void ProcessPayloadData(string[] values)
        {
            if (values.Length < 16) return;

            try
            {
                if (float.TryParse(values[0], NumberStyles.Any, CultureInfo.InvariantCulture, out float altitude)) { payloadAltitude = altitude; UpdateLabel(girtifa, $"{altitude:0.0}m"); }
                if (double.TryParse(values[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double latitude) && double.TryParse(values[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double longitude)) { this.payloadLatitude = latitude; this.payloadLongitude = longitude; UpdateLabel(genlem, latitude.ToString("00.000000", CultureInfo.InvariantCulture)); UpdateLabel(gboylam, longitude.ToString("00.000000", CultureInfo.InvariantCulture)); UpdatePayloadPosition(latitude, longitude); }
                if (float.TryParse(values[3], NumberStyles.Any, CultureInfo.InvariantCulture, out float ggpsaltitude)) { currentPayloadGPSAltitude = ggpsaltitude; UpdateLabel(ggpsirtifa, $"{ggpsaltitude:0.0}m"); }
                if (float.TryParse(values[4], NumberStyles.Any, CultureInfo.InvariantCulture, out float humidity)) UpdateLabel(gnem, $"{humidity:0.0}%");
                if (float.TryParse(values[5], NumberStyles.Any, CultureInfo.InvariantCulture, out float p_accelX)) UpdateLabel(givmeX, $"{p_accelX:0.00} m/s²");
                if (float.TryParse(values[6], NumberStyles.Any, CultureInfo.InvariantCulture, out float p_accelY)) UpdateLabel(givmeY, $"{p_accelY:0.00} m/s²");
                if (float.TryParse(values[7], NumberStyles.Any, CultureInfo.InvariantCulture, out float p_accelZ)) UpdateLabel(givmeZ, $"{p_accelZ:0.00} m/s²");
                if (float.TryParse(values[8], NumberStyles.Any, CultureInfo.InvariantCulture, out float p_gyroX)) UpdateLabel(ggyrox, $"{p_gyroX:F2}°/s");
                if (float.TryParse(values[9], NumberStyles.Any, CultureInfo.InvariantCulture, out float p_gyroY)) UpdateLabel(ggyroy, $"{p_gyroY:F2}°/s");
                if (float.TryParse(values[10], NumberStyles.Any, CultureInfo.InvariantCulture, out float p_gyroZ)) UpdateLabel(ggyroz, $"{p_gyroZ:F2}°/s");
                if (float.TryParse(values[11], NumberStyles.Any, CultureInfo.InvariantCulture, out float quatW) && float.TryParse(values[12], NumberStyles.Any, CultureInfo.InvariantCulture, out float quatX) && float.TryParse(values[13], NumberStyles.Any, CultureInfo.InvariantCulture, out float quatY) && float.TryParse(values[14], NumberStyles.Any, CultureInfo.InvariantCulture, out float quatZ)) { payloadRotation = new Quaternion(quatX, quatY, quatZ, quatW); payloadRotation.Normalize(); glControlPayload.Invalidate(); }
                if (float.TryParse(values[15], NumberStyles.Any, CultureInfo.InvariantCulture, out float temperature)) UpdateLabel(gsicaklik, $"{temperature:0.0}°C");
            }
            catch (Exception ex)
            {
                UpdateStatus("Görev Yükü veri hatası: " + ex.Message);
            }
        }

        private void UpdateLabel(Control label, string text)
        {
            if (label.InvokeRequired) { label.Invoke(new Action(() => label.Text = text)); }
            else { label.Text = text; }
        }

        private void UpdateRocketPosition(double latitude, double longitude)
        {
            if (this.InvokeRequired) { this.Invoke(new Action<double, double>(UpdateRocketPosition), latitude, longitude); return; }
            var newPosition = new PointLatLng(latitude, longitude);
            lastRocketPosition = newPosition;
            rocketMarker.Position = newPosition;
            rocketMarker.ToolTipText = $"Roket\nEnlem: {latitude:00.000000}\nBoylam: {longitude:00.000000}";
            if (followMode && !isMapDragging) { gMapControl1.Position = newPosition; }
        }

        private void UpdatePayloadPosition(double latitude, double longitude)
        {
            if (this.InvokeRequired) { this.Invoke(new Action<double, double>(UpdatePayloadPosition), latitude, longitude); return; }
            var newPosition = new PointLatLng(latitude, longitude);
            lastPayloadPosition = newPosition;
            payloadMarker.Position = newPosition;
            payloadMarker.ToolTipText = $"Görev Yükü\nEnlem: {latitude:00.000000}\nBoylam: {longitude:00.000000}";
        }

        private void UpdateStatus(string message)
        {
            if (this.InvokeRequired) { this.Invoke(new Action<string>(UpdateStatus), message); return; }
            toolStripStatusLabel.Text = message;
        }

        private void ChkFollowMap_CheckedChanged(object sender, EventArgs e)
        {
            followMode = chkFollowMap.Checked;
            if (followMode && lastRocketPosition != null) { gMapControl1.Position = lastRocketPosition; }
        }

        private void GlControl_Resize(object sender, EventArgs e)
        {
            var control = sender as GLControl;
            if (control == null || control.ClientSize.Height == 0) return;
            control.MakeCurrent();
            GL.Viewport(0, 0, control.Width, control.Height);
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45), (float)control.Width / control.Height, 0.1f, 1000f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }

        private void numericTeamID_ValueChanged_1(object sender, EventArgs e)
        {
            this.numericTeamID.ValueChanged += new System.EventHandler(this.numericTeamID_ValueChanged);
        }

        private void GlControlRocket_Paint(object sender, PaintEventArgs e)
        {
            glControlRocket.MakeCurrent();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(Color.White);
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45), (float)glControlRocket.Width / glControlRocket.Height, 0.1f, 100f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            // Kamera pozisyonunu ayarla
            Vector3 eye = new Vector3(0, 3, rocketCameraDistance);
            Matrix4 lookAt = Matrix4.LookAt(eye, Vector3.Zero, Vector3.UnitY);
            GL.MultMatrix(ref lookAt);

            // Kullanıcıdan gelen döndürmeleri uygula
            GL.MultMatrix(ref rocketCameraRotation);
            GL.Rotate(-90, Vector3.UnitX);
            DrawAxes();
            if (rocketModel != null)
            {
                GL.PushMatrix();
                GL.Translate(0, -this.rocketCenterCorrectionY, 0);

                // ✅ Eksikse buraya ekle:
                MyMathUtils.ApplyRotation(rocketRotation);

                GL.Translate(0, this.rocketCenterCorrectionY, 0);
                GL.Scale(0.02f, 0.02f, 0.02f);
                rocketModel.Render();
                GL.PopMatrix();
            }
            glControlRocket.SwapBuffers();
        }

        private void DrawAxes()
        {
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Red); GL.Vertex3(-2, 0, 0); GL.Vertex3(2, 0, 0);
            GL.Color3(Color.Green); GL.Vertex3(0, -2, 0); GL.Vertex3(0, 2, 0);
            GL.Color3(Color.Blue); GL.Vertex3(0, 0, -2); GL.Vertex3(0, 0, 2);
            GL.End();
        }

        private void GlControlPayload_Paint(object sender, PaintEventArgs e)
        {
            glControlPayload.MakeCurrent();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // Perspektif ayarla
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.DegreesToRadians(60),
                (float)glControlPayload.Width / glControlPayload.Height,
                0.1f,
                100f
            );
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);

            // Kamera pozisyonunu hesapla
            Vector3 cameraTarget = Vector3.Zero;
            Vector3 cameraPosition = new Vector3(
                (float)(Math.Sin(MathHelper.DegreesToRadians(payloadRotationY)) * payloadCameraDistance),
                payloadRotationX * 0.01f,
                (float)(Math.Cos(MathHelper.DegreesToRadians(payloadRotationY)) * payloadCameraDistance)
            );

            Matrix4 view = Matrix4.LookAt(cameraPosition, cameraTarget, Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref view);

            DrawAxes();

            if (payloadModel != null)
            {
                GL.PushMatrix();
                if (parachuteDeployed)
                    GL.Scale(0.02f, 0.02f, 0.02f);
                else
                    GL.Scale(0.2f, 0.2f, 0.2f);

                GL.Translate(0, -this.payloadCenterCorrectionY, 0);

                // ✅ payloadRotation uygulanıyor
                MyMathUtils.ApplyRotation(payloadRotation);

                GL.Translate(0, this.payloadCenterCorrectionY, 0);

                GL.Color3(Color.Blue);
                payloadModel.Render();

                GL.PopMatrix();
            }

            glControlPayload.SwapBuffers();
        }

        private void PopulateHYIPorts()
        {
            try
            {
                HYIPORT.Items.Clear();
                string[] ports = SerialPort.GetPortNames();
                HYIPORT.Items.AddRange(ports);
                if (ports.Length > 0) HYIPORT.SelectedIndex = 0;
                else HYIPORT.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("COM portlar alınırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void numericTeamID_ValueChanged(object sender, EventArgs e)
        {
            txtTeamID.Text = numericTeamID.Value.ToString();
        }

        private void btnConHyi_Click(object sender, EventArgs e)
        {
            if (isHyiConnected)
            {
                try
                {
                    serialPortHyi.Close();
                    isHyiConnected = false;
                    UpdateHyiConnectionUI();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HYİ bağlantısı kesilirken hata oluştu: " + ex.Message);
                }
            }
            else
            {
                if (HYIPORT.SelectedItem == null) { MessageBox.Show("Lütfen bir HYİ COM portu seçiniz."); return; }
                if (!int.TryParse(cmbHyiBaud.SelectedItem?.ToString(), out int baudRate)) { MessageBox.Show("Geçersiz Baud Rate değeri."); return; }

                try
                {
                    serialPortHyi.PortName = HYIPORT.SelectedItem.ToString();
                    serialPortHyi.BaudRate = baudRate;
                    serialPortHyi.Parity = Parity.None;
                    serialPortHyi.DataBits = 8;
                    serialPortHyi.StopBits = StopBits.One;
                    serialPortHyi.Open();
                    isHyiConnected = true;
                    UpdateHyiConnectionUI();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HYİ bağlantısı kurulurken hata oluştu: " + ex.Message);
                    isHyiConnected = false;
                    UpdateHyiConnectionUI();
                }
            }
        }

        /// <summary>
        /// HYİ bağlantı durumuna göre arayüzdeki ilgili kontrolleri günceller.
        /// </summary>
        private void UpdateHyiConnectionUI()
        {
            labelHyiStatus.Text = isHyiConnected ? "Hazır" : "Bağlı değil";
            btnConHyi.Text = isHyiConnected ? "Bağlantıyı Kes" : "HYİ'ye Bağlan";

            // YENİ EKLENTİ: HYİ bağlantı durumuna göre PictureBox rengini ayarla.
            // Form tasarımınızda bu isimde bir PictureBox olduğundan emin olun.
            if (btnConPB != null)
            {
                btnConPB.BackColor = isHyiConnected ? Color.LimeGreen : Color.Red;
            }
        }

        private void btnSendHyiPacket_Click(object sender, EventArgs e)
        {
            if (!isHyiConnected || !serialPortHyi.IsOpen)
            {
                MessageBox.Show("HYI cihazı bağlı değil!");
                return;
            }

            // Otomatik gönderim modunu toggle et
            autoSendHyiEnabled = !autoSendHyiEnabled;

            // Buton metnini güncelle
            btnSendHyiPacket.Text = autoSendHyiEnabled ? "Otomatik Gönderim Açık" : "Paket Gönder";

            // Eğer otomatik gönderim açıksa hemen bir paket gönder
            if (autoSendHyiEnabled)
            {
                SendHyiPacket();
            }
        }

        private void SendHyiPacket()
        {
            try
            {
                CreateHyiPacket();
                serialPortHyi.Write(hyiPacket, 0, hyiPacket.Length);

                txtPacketCount.Text = packetCounter.ToString();
                txtCRC.Text = hyiPacket[75].ToString("X2");

                if (pbVG != null)
                {
                    pbVG.BackColor = Color.LimeGreen;
                    Task.Delay(150).ContinueWith(t =>
                    {
                        if (pbVG.IsHandleCreated)
                        {
                            this.Invoke((MethodInvoker)delegate { pbVG.BackColor = Color.Red; });
                        }
                    });
                }

                UpdateStatus("HYI'ye paket gönderildi.");
            }
            catch (Exception ex)
            {
                UpdateStatus("Paket gönderilirken hata: " + ex.Message);
            }
        }
        private void CreateHyiPacket()
        {
            Array.Clear(hyiPacket, 0, hyiPacket.Length);
            hyiPacket[0] = 0xFF; hyiPacket[1] = 0xFF; hyiPacket[2] = 0x54; hyiPacket[3] = 0x52;
            hyiPacket[4] = (byte)numericTeamID.Value;
            hyiPacket[5] = (byte)(packetCounter++ % 256);
            AddFloatToPacket(6, currentRocketAltitude);
            AddFloatToPacket(10, currentRocketGPSAltitude);
            AddFloatToPacket(14, (float)rocketLatitude);
            AddFloatToPacket(18, (float)rocketLongitude);
            AddFloatToPacket(22, currentPayloadGPSAltitude);
            AddFloatToPacket(26, (float)this.payloadLatitude);
            AddFloatToPacket(30, (float)this.payloadLongitude);
            AddFloatToPacket(34, 0f); AddFloatToPacket(38, 0f); AddFloatToPacket(42, 0f);
            AddFloatToPacket(46, gyroX); AddFloatToPacket(50, gyroY); AddFloatToPacket(54, gyroZ);
            AddFloatToPacket(58, accelX); AddFloatToPacket(62, accelY); AddFloatToPacket(66, accelZ);
            AddFloatToPacket(70, tiltAngle);
            hyiPacket[74] = (byte)rocketStatus;
            hyiPacket[75] = CalculateChecksum();
            hyiPacket[76] = 0x0D; hyiPacket[77] = 0x0A;
        }

        private void AddFloatToPacket(int startIndex, float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            System.Buffer.BlockCopy(bytes, 0, hyiPacket, startIndex, 4);
        }

        private byte CalculateChecksum()
        {
            int sum = 0;
            for (int i = 4; i <= 74; i++) { sum += hyiPacket[i]; }
            return (byte)(sum % 256);
        }
        private void GlControlPayload_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void GlControlPayload_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                float deltaX = e.X - lastMousePosition.X;
                float deltaY = e.Y - lastMousePosition.Y;

                payloadRotationX += deltaY * 0.5f;
                payloadRotationY += deltaX * 0.5f;

                payloadRotationX = MathHelper.Clamp(payloadRotationX, -90, 90); // Dikey dönüş sınırlaması

                glControlPayload.Invalidate();
                lastMousePosition = e.Location;
            }
        }

        private void GlControlPayload_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void GlControlPayload_MouseWheel(object sender, MouseEventArgs e)
        {
            float zoomSpeed = 1.0f;
            payloadCameraDistance -= e.Delta * zoomSpeed / 120f;
            payloadCameraDistance = MathHelper.Clamp(payloadCameraDistance, 1.0f, 50.0f);

            glControlPayload.Invalidate();
        }

        private void glControlRocket_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePos = e.Location;
            }
        }

        private void glControlRocket_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                float dx = e.X - lastMousePos.X;
                float dy = e.Y - lastMousePos.Y;

                // Yatay dönüş (Y ekseni)
                rocketCameraRotation *= Matrix4.CreateFromAxisAngle(Vector3.UnitY, MathHelper.DegreesToRadians(-dx * 0.5f));
                // Dikey dönüş (X ekseni)
                rocketCameraRotation *= Matrix4.CreateFromAxisAngle(Vector3.UnitX, MathHelper.DegreesToRadians(-dy * 0.5f));

                lastMousePos = e.Location;
                glControlRocket.Invalidate();
            }
        }

        private void glControlRocket_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void glControlRocket_MouseWheel(object sender, MouseEventArgs e)
        {
            float zoomSpeed = 0.5f;
            rocketCameraDistance -= e.Delta * zoomSpeed / 120f;
            rocketCameraDistance = MathHelper.Clamp(rocketCameraDistance, 1.0f, 20.0f);

            glControlRocket.Invalidate();
        }
        public static class MyMathUtils
        {
            public static void ApplyRotation(Quaternion q)
            {
                Matrix4 m = Matrix4.CreateFromQuaternion(q);
                GL.MultMatrix(ref m);
            }
        }
        private void btnRefreshPorts_Click(object sender, EventArgs e)
        {
            PopulateGorevYukuPorts();
            PopulateCOMPorts();
            PopulateHYIPorts();
        }



    }
}
