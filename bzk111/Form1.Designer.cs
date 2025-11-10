using OpenTK;
using OpenTK.Graphics;
using System.Windows.Forms;

namespace LoRaYerIstasyonu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
       
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.labelRocketStatus = new System.Windows.Forms.Label();
            this.labelRocketYaw = new System.Windows.Forms.Label();
            this.chkFollowMap = new System.Windows.Forms.CheckBox();
            this.labelRocketLon = new System.Windows.Forms.Label();
            this.labelRocketLat = new System.Windows.Forms.Label();
            this.labelRocketAlt = new System.Windows.Forms.Label();
            this.groupBoxPayload = new System.Windows.Forms.GroupBox();
            this.givmeZ = new System.Windows.Forms.TextBox();
            this.glControlPayload = new OpenTK.GLControl();
            this.gsicaklik = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.givmeX = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.givmeY = new System.Windows.Forms.TextBox();
            this.ggyroz = new System.Windows.Forms.TextBox();
            this.genlem = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.gboylam = new System.Windows.Forms.TextBox();
            this.gnem = new System.Windows.Forms.TextBox();
            this.ggyroy = new System.Windows.Forms.TextBox();
            this.ggpsirtifa = new System.Windows.Forms.TextBox();
            this.ggyrox = new System.Windows.Forms.TextBox();
            this.girtifa = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.labelPayloadHum = new System.Windows.Forms.Label();
            this.labelPayloadPress = new System.Windows.Forms.Label();
            this.labelPayloadYaw = new System.Windows.Forms.Label();
            this.labelPayloadRoll = new System.Windows.Forms.Label();
            this.labelPayloadPitch = new System.Windows.Forms.Label();
            this.labelPayloadLon = new System.Windows.Forms.Label();
            this.labelPayloadLat = new System.Windows.Forms.Label();
            this.labelPayloadAlt = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.gconnect = new System.Windows.Forms.Button();
            this.gbaud = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.gport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gconinduc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionStatusIndicator = new System.Windows.Forms.PictureBox();
            this.glControlRocket = new OpenTK.GLControl();
            this.rirtifa = new System.Windows.Forms.TextBox();
            this.renlem = new System.Windows.Forms.TextBox();
            this.rboylam = new System.Windows.Forms.TextBox();
            this.rdurum = new System.Windows.Forms.TextBox();
            this.groupBoxRocket = new System.Windows.Forms.GroupBox();
            this.rgpsirtifa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rivmeZ = new System.Windows.Forms.TextBox();
            this.rivmeX = new System.Windows.Forms.TextBox();
            this.rivmeY = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.raçı = new System.Windows.Forms.TextBox();
            this.rgyrox = new System.Windows.Forms.TextBox();
            this.rgyroz = new System.Windows.Forms.TextBox();
            this.rgyroy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelRocketRoll = new System.Windows.Forms.Label();
            this.labelRocketPitch = new System.Windows.Forms.Label();
            this.labelHyiStatus = new System.Windows.Forms.Label();
            this.numericTeamID = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.portyeni = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPacketCount = new System.Windows.Forms.TextBox();
            this.txtCRC = new System.Windows.Forms.TextBox();
            this.labelCRC = new System.Windows.Forms.Label();
            this.labelPacketCount = new System.Windows.Forms.Label();
            this.txtTeamID = new System.Windows.Forms.TextBox();
            this.labelTeamID = new System.Windows.Forms.Label();
            this.pbVG = new System.Windows.Forms.PictureBox();
            this.btnSendHyiPacket = new System.Windows.Forms.Button();
            this.btnConHyi = new System.Windows.Forms.Button();
            this.cmbHyiBaud = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HYIPORT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConPB = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBoxPayload.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gconinduc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionStatusIndicator)).BeginInit();
            this.groupBoxRocket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(613, 187);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaximumSize = new System.Drawing.Size(408, 440);
            this.gMapControl1.MaxZoom = 20;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(408, 440);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 15D;
            this.gMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDown);
            this.gMapControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseUp);
            // 
            // labelRocketStatus
            // 
            this.labelRocketStatus.AutoSize = true;
            this.labelRocketStatus.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRocketStatus.Location = new System.Drawing.Point(193, 193);
            this.labelRocketStatus.Name = "labelRocketStatus";
            this.labelRocketStatus.Size = new System.Drawing.Size(66, 21);
            this.labelRocketStatus.TabIndex = 6;
            this.labelRocketStatus.Text = "Durum: ";
            // 
            // labelRocketYaw
            // 
            this.labelRocketYaw.AutoSize = true;
            this.labelRocketYaw.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRocketYaw.Location = new System.Drawing.Point(7, 139);
            this.labelRocketYaw.Name = "labelRocketYaw";
            this.labelRocketYaw.Size = new System.Drawing.Size(61, 21);
            this.labelRocketYaw.TabIndex = 5;
            this.labelRocketYaw.Text = "İvmeX: ";
            // 
            // chkFollowMap
            // 
            this.chkFollowMap.AutoSize = true;
            this.chkFollowMap.Checked = true;
            this.chkFollowMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFollowMap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkFollowMap.Location = new System.Drawing.Point(214, 17);
            this.chkFollowMap.Name = "chkFollowMap";
            this.chkFollowMap.Size = new System.Drawing.Size(157, 19);
            this.chkFollowMap.TabIndex = 0;
            this.chkFollowMap.Text = "Roketi Haritada Takip Et";
            this.chkFollowMap.UseVisualStyleBackColor = true;
            this.chkFollowMap.CheckedChanged += new System.EventHandler(this.ChkFollowMap_CheckedChanged);
            // 
            // labelRocketLon
            // 
            this.labelRocketLon.AutoSize = true;
            this.labelRocketLon.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRocketLon.Location = new System.Drawing.Point(7, 105);
            this.labelRocketLon.Name = "labelRocketLon";
            this.labelRocketLon.Size = new System.Drawing.Size(65, 21);
            this.labelRocketLon.TabIndex = 2;
            this.labelRocketLon.Text = "Boylam:";
            // 
            // labelRocketLat
            // 
            this.labelRocketLat.AutoSize = true;
            this.labelRocketLat.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRocketLat.Location = new System.Drawing.Point(7, 72);
            this.labelRocketLat.Name = "labelRocketLat";
            this.labelRocketLat.Size = new System.Drawing.Size(56, 21);
            this.labelRocketLat.TabIndex = 1;
            this.labelRocketLat.Text = "Enlem:";
            // 
            // labelRocketAlt
            // 
            this.labelRocketAlt.AutoSize = true;
            this.labelRocketAlt.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRocketAlt.Location = new System.Drawing.Point(6, 41);
            this.labelRocketAlt.Name = "labelRocketAlt";
            this.labelRocketAlt.Size = new System.Drawing.Size(46, 21);
            this.labelRocketAlt.TabIndex = 0;
            this.labelRocketAlt.Text = "İrtifa:";
            // 
            // groupBoxPayload
            // 
            this.groupBoxPayload.BackColor = System.Drawing.Color.Silver;
            this.groupBoxPayload.Controls.Add(this.givmeZ);
            this.groupBoxPayload.Controls.Add(this.glControlPayload);
            this.groupBoxPayload.Controls.Add(this.gsicaklik);
            this.groupBoxPayload.Controls.Add(this.label21);
            this.groupBoxPayload.Controls.Add(this.givmeX);
            this.groupBoxPayload.Controls.Add(this.label27);
            this.groupBoxPayload.Controls.Add(this.givmeY);
            this.groupBoxPayload.Controls.Add(this.ggyroz);
            this.groupBoxPayload.Controls.Add(this.genlem);
            this.groupBoxPayload.Controls.Add(this.label26);
            this.groupBoxPayload.Controls.Add(this.gboylam);
            this.groupBoxPayload.Controls.Add(this.gnem);
            this.groupBoxPayload.Controls.Add(this.ggyroy);
            this.groupBoxPayload.Controls.Add(this.ggpsirtifa);
            this.groupBoxPayload.Controls.Add(this.ggyrox);
            this.groupBoxPayload.Controls.Add(this.girtifa);
            this.groupBoxPayload.Controls.Add(this.label28);
            this.groupBoxPayload.Controls.Add(this.labelPayloadHum);
            this.groupBoxPayload.Controls.Add(this.labelPayloadPress);
            this.groupBoxPayload.Controls.Add(this.labelPayloadYaw);
            this.groupBoxPayload.Controls.Add(this.labelPayloadRoll);
            this.groupBoxPayload.Controls.Add(this.labelPayloadPitch);
            this.groupBoxPayload.Controls.Add(this.labelPayloadLon);
            this.groupBoxPayload.Controls.Add(this.labelPayloadLat);
            this.groupBoxPayload.Controls.Add(this.labelPayloadAlt);
            this.groupBoxPayload.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxPayload.Location = new System.Drawing.Point(23, 412);
            this.groupBoxPayload.Name = "groupBoxPayload";
            this.groupBoxPayload.Size = new System.Drawing.Size(585, 222);
            this.groupBoxPayload.TabIndex = 2;
            this.groupBoxPayload.TabStop = false;
            this.groupBoxPayload.Text = "Görev Yükü Verileri";
            // 
            // givmeZ
            // 
            this.givmeZ.Cursor = System.Windows.Forms.Cursors.Default;
            this.givmeZ.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.givmeZ.Location = new System.Drawing.Point(273, 85);
            this.givmeZ.Name = "givmeZ";
            this.givmeZ.ReadOnly = true;
            this.givmeZ.Size = new System.Drawing.Size(99, 29);
            this.givmeZ.TabIndex = 25;
            // 
            // glControlPayload
            // 
            this.glControlPayload.BackColor = System.Drawing.Color.Black;
            this.glControlPayload.Location = new System.Drawing.Point(378, 25);
            this.glControlPayload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.glControlPayload.MaximumSize = new System.Drawing.Size(193, 182);
            this.glControlPayload.Name = "glControlPayload";
            this.glControlPayload.Size = new System.Drawing.Size(193, 182);
            this.glControlPayload.TabIndex = 1;
            this.glControlPayload.VSync = true;
            this.glControlPayload.Paint += new System.Windows.Forms.PaintEventHandler(this.GlControlPayload_Paint);
            // 
            // gsicaklik
            // 
            this.gsicaklik.Cursor = System.Windows.Forms.Cursors.Default;
            this.gsicaklik.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gsicaklik.Location = new System.Drawing.Point(88, 188);
            this.gsicaklik.Name = "gsicaklik";
            this.gsicaklik.ReadOnly = true;
            this.gsicaklik.Size = new System.Drawing.Size(99, 29);
            this.gsicaklik.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(9, 190);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 21);
            this.label21.TabIndex = 16;
            this.label21.Text = "Sıcaklık: ";
            // 
            // givmeX
            // 
            this.givmeX.Cursor = System.Windows.Forms.Cursors.Default;
            this.givmeX.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.givmeX.Location = new System.Drawing.Point(273, 18);
            this.givmeX.Name = "givmeX";
            this.givmeX.ReadOnly = true;
            this.givmeX.Size = new System.Drawing.Size(99, 29);
            this.givmeX.TabIndex = 24;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(192, 87);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 21);
            this.label27.TabIndex = 21;
            this.label27.Text = "İvmeZ: ";
            // 
            // givmeY
            // 
            this.givmeY.Cursor = System.Windows.Forms.Cursors.Default;
            this.givmeY.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.givmeY.Location = new System.Drawing.Point(273, 52);
            this.givmeY.Name = "givmeY";
            this.givmeY.ReadOnly = true;
            this.givmeY.Size = new System.Drawing.Size(99, 29);
            this.givmeY.TabIndex = 23;
            // 
            // ggyroz
            // 
            this.ggyroz.Cursor = System.Windows.Forms.Cursors.Default;
            this.ggyroz.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggyroz.Location = new System.Drawing.Point(273, 187);
            this.ggyroz.Name = "ggyroz";
            this.ggyroz.ReadOnly = true;
            this.ggyroz.Size = new System.Drawing.Size(99, 29);
            this.ggyroz.TabIndex = 15;
            // 
            // genlem
            // 
            this.genlem.Cursor = System.Windows.Forms.Cursors.Default;
            this.genlem.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genlem.Location = new System.Drawing.Point(88, 89);
            this.genlem.Name = "genlem";
            this.genlem.ReadOnly = true;
            this.genlem.Size = new System.Drawing.Size(99, 29);
            this.genlem.TabIndex = 14;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(193, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 21);
            this.label26.TabIndex = 22;
            this.label26.Text = "İvmeY: ";
            // 
            // gboylam
            // 
            this.gboylam.Cursor = System.Windows.Forms.Cursors.Default;
            this.gboylam.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboylam.Location = new System.Drawing.Point(88, 123);
            this.gboylam.Name = "gboylam";
            this.gboylam.ReadOnly = true;
            this.gboylam.Size = new System.Drawing.Size(99, 29);
            this.gboylam.TabIndex = 13;
            // 
            // gnem
            // 
            this.gnem.Cursor = System.Windows.Forms.Cursors.Default;
            this.gnem.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnem.Location = new System.Drawing.Point(88, 156);
            this.gnem.Name = "gnem";
            this.gnem.ReadOnly = true;
            this.gnem.Size = new System.Drawing.Size(99, 29);
            this.gnem.TabIndex = 11;
            // 
            // ggyroy
            // 
            this.ggyroy.Cursor = System.Windows.Forms.Cursors.Default;
            this.ggyroy.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggyroy.Location = new System.Drawing.Point(273, 153);
            this.ggyroy.Name = "ggyroy";
            this.ggyroy.ReadOnly = true;
            this.ggyroy.Size = new System.Drawing.Size(99, 29);
            this.ggyroy.TabIndex = 10;
            // 
            // ggpsirtifa
            // 
            this.ggpsirtifa.Cursor = System.Windows.Forms.Cursors.Default;
            this.ggpsirtifa.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggpsirtifa.Location = new System.Drawing.Point(88, 57);
            this.ggpsirtifa.Name = "ggpsirtifa";
            this.ggpsirtifa.ReadOnly = true;
            this.ggpsirtifa.Size = new System.Drawing.Size(99, 29);
            this.ggpsirtifa.TabIndex = 12;
            // 
            // ggyrox
            // 
            this.ggyrox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ggyrox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggyrox.Location = new System.Drawing.Point(273, 119);
            this.ggyrox.Name = "ggyrox";
            this.ggyrox.ReadOnly = true;
            this.ggyrox.Size = new System.Drawing.Size(99, 29);
            this.ggyrox.TabIndex = 9;
            // 
            // girtifa
            // 
            this.girtifa.Cursor = System.Windows.Forms.Cursors.Default;
            this.girtifa.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girtifa.Location = new System.Drawing.Point(88, 25);
            this.girtifa.Name = "girtifa";
            this.girtifa.ReadOnly = true;
            this.girtifa.Size = new System.Drawing.Size(99, 29);
            this.girtifa.TabIndex = 8;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(193, 25);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(61, 21);
            this.label28.TabIndex = 20;
            this.label28.Text = "İvmeX: ";
            // 
            // labelPayloadHum
            // 
            this.labelPayloadHum.AutoSize = true;
            this.labelPayloadHum.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayloadHum.Location = new System.Drawing.Point(9, 157);
            this.labelPayloadHum.Name = "labelPayloadHum";
            this.labelPayloadHum.Size = new System.Drawing.Size(51, 21);
            this.labelPayloadHum.TabIndex = 7;
            this.labelPayloadHum.Text = "Nem: ";
            // 
            // labelPayloadPress
            // 
            this.labelPayloadPress.AutoSize = true;
            this.labelPayloadPress.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayloadPress.Location = new System.Drawing.Point(9, 60);
            this.labelPayloadPress.Name = "labelPayloadPress";
            this.labelPayloadPress.Size = new System.Drawing.Size(83, 21);
            this.labelPayloadPress.TabIndex = 6;
            this.labelPayloadPress.Text = "GPS İrtifa: ";
            // 
            // labelPayloadYaw
            // 
            this.labelPayloadYaw.AutoSize = true;
            this.labelPayloadYaw.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayloadYaw.Location = new System.Drawing.Point(193, 187);
            this.labelPayloadYaw.Name = "labelPayloadYaw";
            this.labelPayloadYaw.Size = new System.Drawing.Size(64, 21);
            this.labelPayloadYaw.TabIndex = 5;
            this.labelPayloadYaw.Text = "Gyro Z: ";
            // 
            // labelPayloadRoll
            // 
            this.labelPayloadRoll.AutoSize = true;
            this.labelPayloadRoll.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayloadRoll.Location = new System.Drawing.Point(193, 152);
            this.labelPayloadRoll.Name = "labelPayloadRoll";
            this.labelPayloadRoll.Size = new System.Drawing.Size(64, 21);
            this.labelPayloadRoll.TabIndex = 4;
            this.labelPayloadRoll.Text = "Gyro Y: ";
            // 
            // labelPayloadPitch
            // 
            this.labelPayloadPitch.AutoSize = true;
            this.labelPayloadPitch.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayloadPitch.Location = new System.Drawing.Point(193, 118);
            this.labelPayloadPitch.Name = "labelPayloadPitch";
            this.labelPayloadPitch.Size = new System.Drawing.Size(60, 21);
            this.labelPayloadPitch.TabIndex = 3;
            this.labelPayloadPitch.Text = "Gyro X:";
            // 
            // labelPayloadLon
            // 
            this.labelPayloadLon.AutoSize = true;
            this.labelPayloadLon.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayloadLon.Location = new System.Drawing.Point(9, 123);
            this.labelPayloadLon.Name = "labelPayloadLon";
            this.labelPayloadLon.Size = new System.Drawing.Size(69, 21);
            this.labelPayloadLon.TabIndex = 2;
            this.labelPayloadLon.Text = "Boylam: ";
            // 
            // labelPayloadLat
            // 
            this.labelPayloadLat.AutoSize = true;
            this.labelPayloadLat.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayloadLat.Location = new System.Drawing.Point(9, 91);
            this.labelPayloadLat.Name = "labelPayloadLat";
            this.labelPayloadLat.Size = new System.Drawing.Size(60, 21);
            this.labelPayloadLat.TabIndex = 1;
            this.labelPayloadLat.Text = "Enlem: ";
            // 
            // labelPayloadAlt
            // 
            this.labelPayloadAlt.AutoSize = true;
            this.labelPayloadAlt.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayloadAlt.Location = new System.Drawing.Point(10, 28);
            this.labelPayloadAlt.Name = "labelPayloadAlt";
            this.labelPayloadAlt.Size = new System.Drawing.Size(50, 21);
            this.labelPayloadAlt.TabIndex = 0;
            this.labelPayloadAlt.Text = "İrtifa: \r\n";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 637);
            this.statusStrip1.MaximumSize = new System.Drawing.Size(1350, 22);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel.Text = "Bağlantı yok";
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConnection.Controls.Add(this.gconnect);
            this.groupBoxConnection.Controls.Add(this.gbaud);
            this.groupBoxConnection.Controls.Add(this.btnConnect);
            this.groupBoxConnection.Controls.Add(this.label11);
            this.groupBoxConnection.Controls.Add(this.cmbBaudRate);
            this.groupBoxConnection.Controls.Add(this.gport);
            this.groupBoxConnection.Controls.Add(this.label2);
            this.groupBoxConnection.Controls.Add(this.cmbPorts);
            this.groupBoxConnection.Controls.Add(this.label9);
            this.groupBoxConnection.Controls.Add(this.label10);
            this.groupBoxConnection.Controls.Add(this.label8);
            this.groupBoxConnection.Controls.Add(this.gconinduc);
            this.groupBoxConnection.Controls.Add(this.label1);
            this.groupBoxConnection.Controls.Add(this.connectionStatusIndicator);
            this.groupBoxConnection.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxConnection.Location = new System.Drawing.Point(1028, 181);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(312, 168);
            this.groupBoxConnection.TabIndex = 4;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Seri Haberleşme Bağlantı Ayarları";
            // 
            // gconnect
            // 
            this.gconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gconnect.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gconnect.Image = ((System.Drawing.Image)(resources.GetObject("gconnect.Image")));
            this.gconnect.Location = new System.Drawing.Point(173, 119);
            this.gconnect.Name = "gconnect";
            this.gconnect.Size = new System.Drawing.Size(105, 30);
            this.gconnect.TabIndex = 5;
            this.gconnect.Text = "Connect";
            this.gconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.gconnect.UseVisualStyleBackColor = false;
            this.gconnect.Click += new System.EventHandler(this.gconnect_Click);
            // 
            // gbaud
            // 
            this.gbaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gbaud.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbaud.FormattingEnabled = true;
            this.gbaud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.gbaud.Location = new System.Drawing.Point(228, 84);
            this.gbaud.Name = "gbaud";
            this.gbaud.Size = new System.Drawing.Size(78, 29);
            this.gbaud.TabIndex = 21;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConnect.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.Location = new System.Drawing.Point(11, 119);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(105, 30);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(173, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 42);
            this.label11.TabIndex = 3;
            this.label11.Text = "Baud \r\nRate:";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(66, 84);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(80, 29);
            this.cmbBaudRate.TabIndex = 4;
            // 
            // gport
            // 
            this.gport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gport.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gport.FormattingEnabled = true;
            this.gport.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.gport.Location = new System.Drawing.Point(229, 45);
            this.gport.Name = "gport";
            this.gport.Size = new System.Drawing.Size(77, 29);
            this.gport.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud \r\nRate:";
            // 
            // cmbPorts
            // 
            this.cmbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorts.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(66, 45);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(80, 29);
            this.cmbPorts.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(164, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "----Görev Yükü ----";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(171, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Port:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "---------Roket---------";
            // 
            // gconinduc
            // 
            this.gconinduc.BackColor = System.Drawing.Color.Red;
            this.gconinduc.Location = new System.Drawing.Point(281, 119);
            this.gconinduc.Name = "gconinduc";
            this.gconinduc.Size = new System.Drawing.Size(25, 30);
            this.gconinduc.TabIndex = 0;
            this.gconinduc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // connectionStatusIndicator
            // 
            this.connectionStatusIndicator.BackColor = System.Drawing.Color.Red;
            this.connectionStatusIndicator.Location = new System.Drawing.Point(122, 119);
            this.connectionStatusIndicator.Name = "connectionStatusIndicator";
            this.connectionStatusIndicator.Size = new System.Drawing.Size(25, 30);
            this.connectionStatusIndicator.TabIndex = 0;
            this.connectionStatusIndicator.TabStop = false;
            // 
            // glControlRocket
            // 
            this.glControlRocket.BackColor = System.Drawing.Color.Black;
            this.glControlRocket.Location = new System.Drawing.Point(378, 21);
            this.glControlRocket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.glControlRocket.MaximumSize = new System.Drawing.Size(193, 197);
            this.glControlRocket.Name = "glControlRocket";
            this.glControlRocket.Size = new System.Drawing.Size(193, 197);
            this.glControlRocket.TabIndex = 0;
            this.glControlRocket.VSync = true;
            this.glControlRocket.Paint += new System.Windows.Forms.PaintEventHandler(this.GlControlRocket_Paint);
            this.glControlRocket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControlRocket_MouseDown);
            this.glControlRocket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControlRocket_MouseMove);
            this.glControlRocket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControlRocket_MouseUp);
            this.glControlRocket.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.glControlRocket_MouseWheel);
            // 
            // rirtifa
            // 
            this.rirtifa.Cursor = System.Windows.Forms.Cursors.Default;
            this.rirtifa.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rirtifa.Location = new System.Drawing.Point(87, 38);
            this.rirtifa.MaximumSize = new System.Drawing.Size(99, 29);
            this.rirtifa.Name = "rirtifa";
            this.rirtifa.ReadOnly = true;
            this.rirtifa.Size = new System.Drawing.Size(99, 29);
            this.rirtifa.TabIndex = 7;
            // 
            // renlem
            // 
            this.renlem.Cursor = System.Windows.Forms.Cursors.Default;
            this.renlem.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renlem.Location = new System.Drawing.Point(87, 69);
            this.renlem.MaximumSize = new System.Drawing.Size(99, 29);
            this.renlem.Name = "renlem";
            this.renlem.ReadOnly = true;
            this.renlem.Size = new System.Drawing.Size(99, 29);
            this.renlem.TabIndex = 8;
            // 
            // rboylam
            // 
            this.rboylam.Cursor = System.Windows.Forms.Cursors.Default;
            this.rboylam.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboylam.Location = new System.Drawing.Point(87, 100);
            this.rboylam.MaximumSize = new System.Drawing.Size(99, 29);
            this.rboylam.Name = "rboylam";
            this.rboylam.ReadOnly = true;
            this.rboylam.Size = new System.Drawing.Size(99, 29);
            this.rboylam.TabIndex = 9;
            // 
            // rdurum
            // 
            this.rdurum.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdurum.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdurum.Location = new System.Drawing.Point(274, 192);
            this.rdurum.MaximumSize = new System.Drawing.Size(99, 29);
            this.rdurum.Name = "rdurum";
            this.rdurum.ReadOnly = true;
            this.rdurum.Size = new System.Drawing.Size(99, 29);
            this.rdurum.TabIndex = 13;
            // 
            // groupBoxRocket
            // 
            this.groupBoxRocket.BackColor = System.Drawing.Color.Silver;
            this.groupBoxRocket.Controls.Add(this.rgpsirtifa);
            this.groupBoxRocket.Controls.Add(this.label6);
            this.groupBoxRocket.Controls.Add(this.glControlRocket);
            this.groupBoxRocket.Controls.Add(this.rivmeZ);
            this.groupBoxRocket.Controls.Add(this.rivmeX);
            this.groupBoxRocket.Controls.Add(this.rivmeY);
            this.groupBoxRocket.Controls.Add(this.label25);
            this.groupBoxRocket.Controls.Add(this.label24);
            this.groupBoxRocket.Controls.Add(this.label23);
            this.groupBoxRocket.Controls.Add(this.raçı);
            this.groupBoxRocket.Controls.Add(this.rdurum);
            this.groupBoxRocket.Controls.Add(this.rgyrox);
            this.groupBoxRocket.Controls.Add(this.rgyroz);
            this.groupBoxRocket.Controls.Add(this.rgyroy);
            this.groupBoxRocket.Controls.Add(this.rboylam);
            this.groupBoxRocket.Controls.Add(this.renlem);
            this.groupBoxRocket.Controls.Add(this.labelRocketLon);
            this.groupBoxRocket.Controls.Add(this.rirtifa);
            this.groupBoxRocket.Controls.Add(this.label7);
            this.groupBoxRocket.Controls.Add(this.labelRocketStatus);
            this.groupBoxRocket.Controls.Add(this.labelRocketYaw);
            this.groupBoxRocket.Controls.Add(this.labelRocketRoll);
            this.groupBoxRocket.Controls.Add(this.chkFollowMap);
            this.groupBoxRocket.Controls.Add(this.labelRocketPitch);
            this.groupBoxRocket.Controls.Add(this.labelRocketLat);
            this.groupBoxRocket.Controls.Add(this.labelRocketAlt);
            this.groupBoxRocket.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxRocket.Location = new System.Drawing.Point(23, 181);
            this.groupBoxRocket.Name = "groupBoxRocket";
            this.groupBoxRocket.Size = new System.Drawing.Size(585, 226);
            this.groupBoxRocket.TabIndex = 3;
            this.groupBoxRocket.TabStop = false;
            this.groupBoxRocket.Text = "Roket Verileri";
            // 
            // rgpsirtifa
            // 
            this.rgpsirtifa.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgpsirtifa.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgpsirtifa.Location = new System.Drawing.Point(274, 38);
            this.rgpsirtifa.MaximumSize = new System.Drawing.Size(99, 29);
            this.rgpsirtifa.Name = "rgpsirtifa";
            this.rgpsirtifa.ReadOnly = true;
            this.rgpsirtifa.Size = new System.Drawing.Size(99, 29);
            this.rgpsirtifa.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "GPS İrtifa :";
            // 
            // rivmeZ
            // 
            this.rivmeZ.Cursor = System.Windows.Forms.Cursors.Default;
            this.rivmeZ.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rivmeZ.Location = new System.Drawing.Point(87, 194);
            this.rivmeZ.MaximumSize = new System.Drawing.Size(99, 29);
            this.rivmeZ.Name = "rivmeZ";
            this.rivmeZ.ReadOnly = true;
            this.rivmeZ.Size = new System.Drawing.Size(99, 29);
            this.rivmeZ.TabIndex = 19;
            // 
            // rivmeX
            // 
            this.rivmeX.Cursor = System.Windows.Forms.Cursors.Default;
            this.rivmeX.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rivmeX.Location = new System.Drawing.Point(87, 132);
            this.rivmeX.MaximumSize = new System.Drawing.Size(99, 29);
            this.rivmeX.Name = "rivmeX";
            this.rivmeX.ReadOnly = true;
            this.rivmeX.Size = new System.Drawing.Size(99, 29);
            this.rivmeX.TabIndex = 18;
            // 
            // rivmeY
            // 
            this.rivmeY.Cursor = System.Windows.Forms.Cursors.Default;
            this.rivmeY.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rivmeY.Location = new System.Drawing.Point(87, 163);
            this.rivmeY.MaximumSize = new System.Drawing.Size(99, 29);
            this.rivmeY.Name = "rivmeY";
            this.rivmeY.ReadOnly = true;
            this.rivmeY.Size = new System.Drawing.Size(99, 29);
            this.rivmeY.TabIndex = 17;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(193, 132);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 21);
            this.label25.TabIndex = 16;
            this.label25.Text = "Gyro Z:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(7, 168);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 21);
            this.label24.TabIndex = 15;
            this.label24.Text = "İvmeY: ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 197);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 21);
            this.label23.TabIndex = 14;
            this.label23.Text = "İvmeZ: ";
            // 
            // raçı
            // 
            this.raçı.Cursor = System.Windows.Forms.Cursors.Default;
            this.raçı.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raçı.Location = new System.Drawing.Point(274, 160);
            this.raçı.MaximumSize = new System.Drawing.Size(99, 29);
            this.raçı.Name = "raçı";
            this.raçı.ReadOnly = true;
            this.raçı.Size = new System.Drawing.Size(99, 29);
            this.raçı.TabIndex = 13;
            // 
            // rgyrox
            // 
            this.rgyrox.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgyrox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgyrox.Location = new System.Drawing.Point(274, 69);
            this.rgyrox.MaximumSize = new System.Drawing.Size(99, 29);
            this.rgyrox.Name = "rgyrox";
            this.rgyrox.ReadOnly = true;
            this.rgyrox.Size = new System.Drawing.Size(99, 29);
            this.rgyrox.TabIndex = 12;
            // 
            // rgyroz
            // 
            this.rgyroz.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgyroz.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgyroz.Location = new System.Drawing.Point(274, 130);
            this.rgyroz.MaximumSize = new System.Drawing.Size(99, 29);
            this.rgyroz.Name = "rgyroz";
            this.rgyroz.ReadOnly = true;
            this.rgyroz.Size = new System.Drawing.Size(99, 29);
            this.rgyroz.TabIndex = 11;
            // 
            // rgyroy
            // 
            this.rgyroy.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgyroy.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgyroy.Location = new System.Drawing.Point(274, 100);
            this.rgyroy.MaximumSize = new System.Drawing.Size(99, 29);
            this.rgyroy.Name = "rgyroy";
            this.rgyroy.ReadOnly = true;
            this.rgyroy.Size = new System.Drawing.Size(99, 29);
            this.rgyroy.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Açı: ";
            // 
            // labelRocketRoll
            // 
            this.labelRocketRoll.AutoSize = true;
            this.labelRocketRoll.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRocketRoll.Location = new System.Drawing.Point(193, 100);
            this.labelRocketRoll.Name = "labelRocketRoll";
            this.labelRocketRoll.Size = new System.Drawing.Size(60, 21);
            this.labelRocketRoll.TabIndex = 4;
            this.labelRocketRoll.Text = "Gyro Y:";
            // 
            // labelRocketPitch
            // 
            this.labelRocketPitch.AutoSize = true;
            this.labelRocketPitch.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRocketPitch.Location = new System.Drawing.Point(193, 72);
            this.labelRocketPitch.Name = "labelRocketPitch";
            this.labelRocketPitch.Size = new System.Drawing.Size(60, 21);
            this.labelRocketPitch.TabIndex = 3;
            this.labelRocketPitch.Text = "Gyro X:";
            // 
            // labelHyiStatus
            // 
            this.labelHyiStatus.AutoSize = true;
            this.labelHyiStatus.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHyiStatus.Location = new System.Drawing.Point(154, 224);
            this.labelHyiStatus.Name = "labelHyiStatus";
            this.labelHyiStatus.Size = new System.Drawing.Size(124, 21);
            this.labelHyiStatus.TabIndex = 20;
            this.labelHyiStatus.Text = "HYİ Paketi: Hazır";
            // 
            // numericTeamID
            // 
            this.numericTeamID.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTeamID.Location = new System.Drawing.Point(231, 109);
            this.numericTeamID.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericTeamID.Name = "numericTeamID";
            this.numericTeamID.Size = new System.Drawing.Size(60, 29);
            this.numericTeamID.TabIndex = 24;
            this.numericTeamID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTeamID.ValueChanged += new System.EventHandler(this.numericTeamID_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Menu;
            this.label5.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(392, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(563, 110);
            this.label5.TabIndex = 13;
            this.label5.Text = "BOZOK ROKET TAKIMI \r\n    YER İSTASYONU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(33, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1140, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.portyeni);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numericTeamID);
            this.groupBox1.Controls.Add(this.labelHyiStatus);
            this.groupBox1.Controls.Add(this.txtPacketCount);
            this.groupBox1.Controls.Add(this.txtCRC);
            this.groupBox1.Controls.Add(this.labelCRC);
            this.groupBox1.Controls.Add(this.labelPacketCount);
            this.groupBox1.Controls.Add(this.txtTeamID);
            this.groupBox1.Controls.Add(this.labelTeamID);
            this.groupBox1.Controls.Add(this.pbVG);
            this.groupBox1.Controls.Add(this.btnSendHyiPacket);
            this.groupBox1.Controls.Add(this.btnConHyi);
            this.groupBox1.Controls.Add(this.cmbHyiBaud);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.HYIPORT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnConPB);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1027, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 285);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HYI Bağlantı Ayarları";
            // 
            // portyeni
            // 
            this.portyeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.portyeni.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portyeni.Image = ((System.Drawing.Image)(resources.GetObject("portyeni.Image")));
            this.portyeni.Location = new System.Drawing.Point(224, 191);
            this.portyeni.Name = "portyeni";
            this.portyeni.Size = new System.Drawing.Size(87, 30);
            this.portyeni.TabIndex = 5;
            this.portyeni.Text = "Yenile";
            this.portyeni.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.portyeni.UseVisualStyleBackColor = false;
            this.portyeni.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(236, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 42);
            this.label12.TabIndex = 31;
            this.label12.Text = "Port\r\nYenile:";
            // 
            // txtPacketCount
            // 
            this.txtPacketCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPacketCount.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacketCount.Location = new System.Drawing.Point(121, 145);
            this.txtPacketCount.Name = "txtPacketCount";
            this.txtPacketCount.ReadOnly = true;
            this.txtPacketCount.Size = new System.Drawing.Size(86, 29);
            this.txtPacketCount.TabIndex = 30;
            // 
            // txtCRC
            // 
            this.txtCRC.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCRC.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCRC.Location = new System.Drawing.Point(122, 188);
            this.txtCRC.Name = "txtCRC";
            this.txtCRC.ReadOnly = true;
            this.txtCRC.Size = new System.Drawing.Size(86, 29);
            this.txtCRC.TabIndex = 29;
            // 
            // labelCRC
            // 
            this.labelCRC.AutoSize = true;
            this.labelCRC.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCRC.Location = new System.Drawing.Point(9, 189);
            this.labelCRC.Name = "labelCRC";
            this.labelCRC.Size = new System.Drawing.Size(85, 21);
            this.labelCRC.TabIndex = 28;
            this.labelCRC.Text = "Checksum:";
            // 
            // labelPacketCount
            // 
            this.labelPacketCount.AutoSize = true;
            this.labelPacketCount.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacketCount.Location = new System.Drawing.Point(7, 145);
            this.labelPacketCount.Name = "labelPacketCount";
            this.labelPacketCount.Size = new System.Drawing.Size(99, 21);
            this.labelPacketCount.TabIndex = 27;
            this.labelPacketCount.Text = "Paket Sayacı:";
            // 
            // txtTeamID
            // 
            this.txtTeamID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTeamID.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamID.Location = new System.Drawing.Point(121, 110);
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.ReadOnly = true;
            this.txtTeamID.Size = new System.Drawing.Size(86, 29);
            this.txtTeamID.TabIndex = 26;
            // 
            // labelTeamID
            // 
            this.labelTeamID.AutoSize = true;
            this.labelTeamID.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamID.Location = new System.Drawing.Point(6, 110);
            this.labelTeamID.Name = "labelTeamID";
            this.labelTeamID.Size = new System.Drawing.Size(78, 21);
            this.labelTeamID.TabIndex = 8;
            this.labelTeamID.Text = "Takım ID :";
            // 
            // pbVG
            // 
            this.pbVG.BackColor = System.Drawing.Color.Red;
            this.pbVG.Location = new System.Drawing.Point(281, 245);
            this.pbVG.Name = "pbVG";
            this.pbVG.Size = new System.Drawing.Size(25, 30);
            this.pbVG.TabIndex = 7;
            this.pbVG.TabStop = false;
            // 
            // btnSendHyiPacket
            // 
            this.btnSendHyiPacket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSendHyiPacket.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendHyiPacket.Image = ((System.Drawing.Image)(resources.GetObject("btnSendHyiPacket.Image")));
            this.btnSendHyiPacket.Location = new System.Drawing.Point(152, 245);
            this.btnSendHyiPacket.Name = "btnSendHyiPacket";
            this.btnSendHyiPacket.Size = new System.Drawing.Size(126, 30);
            this.btnSendHyiPacket.TabIndex = 6;
            this.btnSendHyiPacket.Text = "Veri Gonder";
            this.btnSendHyiPacket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendHyiPacket.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSendHyiPacket.UseVisualStyleBackColor = false;
            this.btnSendHyiPacket.Click += new System.EventHandler(this.btnSendHyiPacket_Click);
            // 
            // btnConHyi
            // 
            this.btnConHyi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConHyi.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConHyi.Image = ((System.Drawing.Image)(resources.GetObject("btnConHyi.Image")));
            this.btnConHyi.Location = new System.Drawing.Point(7, 246);
            this.btnConHyi.Name = "btnConHyi";
            this.btnConHyi.Size = new System.Drawing.Size(105, 30);
            this.btnConHyi.TabIndex = 5;
            this.btnConHyi.Text = "Connect";
            this.btnConHyi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConHyi.UseVisualStyleBackColor = false;
            this.btnConHyi.Click += new System.EventHandler(this.btnConHyi_Click);
            // 
            // cmbHyiBaud
            // 
            this.cmbHyiBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHyiBaud.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHyiBaud.FormattingEnabled = true;
            this.cmbHyiBaud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbHyiBaud.Location = new System.Drawing.Point(117, 72);
            this.cmbHyiBaud.Name = "cmbHyiBaud";
            this.cmbHyiBaud.Size = new System.Drawing.Size(97, 29);
            this.cmbHyiBaud.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baud Rate:";
            // 
            // HYIPORT
            // 
            this.HYIPORT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HYIPORT.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HYIPORT.FormattingEnabled = true;
            this.HYIPORT.Location = new System.Drawing.Point(119, 36);
            this.HYIPORT.Name = "HYIPORT";
            this.HYIPORT.Size = new System.Drawing.Size(96, 29);
            this.HYIPORT.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port:";
            // 
            // btnConPB
            // 
            this.btnConPB.BackColor = System.Drawing.Color.Red;
            this.btnConPB.Location = new System.Drawing.Point(121, 245);
            this.btnConPB.Name = "btnConPB";
            this.btnConPB.Size = new System.Drawing.Size(25, 30);
            this.btnConPB.TabIndex = 0;
            this.btnConPB.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.pictureBox3.Location = new System.Drawing.Point(608, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(418, 453);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1350, 659);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxConnection);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBoxRocket);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxPayload);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Bozok Yer İstasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPayload.ResumeLayout(false);
            this.groupBoxPayload.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gconinduc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionStatusIndicator)).EndInit();
            this.groupBoxRocket.ResumeLayout(false);
            this.groupBoxRocket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenTK.GLControl glControlRocket;
        private OpenTK.GLControl glControlPayload;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label labelRocketStatus;
        private System.Windows.Forms.Label labelRocketYaw;
        private System.Windows.Forms.CheckBox chkFollowMap;
        private System.Windows.Forms.Label labelRocketLon;
        private System.Windows.Forms.Label labelRocketLat;
        private System.Windows.Forms.Label labelRocketAlt;
        private System.Windows.Forms.GroupBox groupBoxPayload;
        private System.Windows.Forms.Label labelPayloadHum;
        private System.Windows.Forms.Label labelPayloadPress;
        private System.Windows.Forms.Label labelPayloadLon;
        private System.Windows.Forms.Label labelPayloadLat;
        private System.Windows.Forms.Label labelPayloadAlt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Timer dataTimer;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox connectionStatusIndicator;
        private System.Windows.Forms.TextBox rdurum;
        private System.Windows.Forms.TextBox rboylam;
        private System.Windows.Forms.TextBox renlem;
        private System.Windows.Forms.TextBox rirtifa;
        private System.Windows.Forms.GroupBox groupBoxRocket;
        private System.Windows.Forms.TextBox girtifa;
        private System.Windows.Forms.TextBox genlem;
        private System.Windows.Forms.TextBox gboylam;
        private System.Windows.Forms.TextBox ggpsirtifa;
        private System.Windows.Forms.TextBox gnem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox gsicaklik;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox rivmeZ;
        private System.Windows.Forms.TextBox rivmeX;
        private System.Windows.Forms.TextBox rivmeY;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox givmeZ;
        private System.Windows.Forms.TextBox givmeX;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox givmeY;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConHyi;
        private System.Windows.Forms.ComboBox cmbHyiBaud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox HYIPORT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnConPB;
        private System.Windows.Forms.Label labelTeamID;
        private System.Windows.Forms.PictureBox pbVG;
        private System.Windows.Forms.Button btnSendHyiPacket;
        private System.Windows.Forms.TextBox txtTeamID;
        private System.Windows.Forms.TextBox txtPacketCount;
        private System.Windows.Forms.TextBox txtCRC;
        private System.Windows.Forms.Label labelCRC;
        private System.Windows.Forms.Label labelPacketCount;
        private System.Windows.Forms.Label labelHyiStatus;
        private System.Windows.Forms.NumericUpDown numericTeamID;
        private PictureBox pictureBox3;
        private TextBox ggyroz;
        private TextBox ggyroy;
        private TextBox ggyrox;
        private Label labelPayloadYaw;
        private Label labelPayloadRoll;
        private Label labelPayloadPitch;
        private Label label25;
        private TextBox rgyrox;
        private TextBox rgyroz;
        private TextBox rgyroy;
        private Label labelRocketRoll;
        private Label labelRocketPitch;
        private TextBox rgpsirtifa;
        private Label label6;
        private TextBox raçı;
        private Label label7;
        private Label label8;
        private Button gconnect;
        private ComboBox gbaud;
        private Label label11;
        private ComboBox gport;
        private Label label9;
        private Label label10;
        private PictureBox gconinduc;
        private Button portyeni;
        private Label label12;
    }
}