using OpenTK;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using OpenTK.Graphics.OpenGL;
using System.Windows.Forms;
using System.Linq;
using System;

namespace LoRaYerIstasyonu
{
    public class ObjModel
    {
        private List<Vector3> _vertices = new List<Vector3>();
        private List<uint> _indices = new List<uint>();

        public void LoadFromFile(string filePath)
        {
            try
            {
                _vertices.Clear();
                _indices.Clear();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Vertex (v) verilerini oku
                        if (line.StartsWith("v "))
                        {
                            string[] parts = line.Split(new[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                            if (parts.Length >= 4)
                            {
                                _vertices.Add(new Vector3(
                                    float.Parse(parts[1], CultureInfo.InvariantCulture),
                                    float.Parse(parts[2], CultureInfo.InvariantCulture),
                                    float.Parse(parts[3], CultureInfo.InvariantCulture)
                                ));
                            }
                        }
                        // Face (f) verilerini oku
                        else if (line.StartsWith("f "))
                        {
                            string[] parts = line.Split(new[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                            foreach (string part in parts.Skip(1))
                            {
                                string[] indicesParts = part.Split('/');
                                if (indicesParts.Length > 0)
                                {
                                    _indices.Add(uint.Parse(indicesParts[0]) - 1);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Model yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Vector3> Vertices { get; set; } = new List<Vector3>();
        // Diğer özellikler ve metodlar...
        

        public void Render()
        {
            if (_vertices.Count == 0 || _indices.Count == 0) return;

            GL.Begin(PrimitiveType.Triangles);
            foreach (uint index in _indices)
            {
                if (index < _vertices.Count)
                {
                    Vector3 vertex = _vertices[(int)index];
                    GL.Vertex3(vertex);
                }
            }
            GL.End();
        }
    }
}