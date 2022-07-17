using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta
{
    public partial class Concepto : Form
    {
        public bool Agregar { get; set; } = true;

        public Concepto()
        {
            InitializeComponent();

            GetRecords();
        }

        private void tbx_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {

            gbx_Concepto.Enabled = true;
            btn_Nuevo.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_Cancelar.Enabled = true;

            GenerateNewID();
            GetRecords();
        }

        private void GenerateNewID()
        {


            ClearFields();
            //var id = 1;
            //tbx_ID.Text = id.ToString();

        }

        private void ClearFields()
        {
            tbx_ID.Text = String.Empty;
            tbx_Nombre.Text = String.Empty;
            tbx_Descripcion.Text = String.Empty;
            checkbox_Visible.Checked = false;

        }
        private void btn_Guardar_Click_1(object sender, EventArgs e)
        {
            SaveRecord();
        }

        private void SaveRecord()
        {
            var json = string.Empty;
            var conceptList = new List<Concept>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Concept.json";

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptList = JsonConvert.DeserializeObject<List<Concept>>(json);
            }

            var concept = new Concept();
            if (Agregar)
            {
                concept = new Concept
                {
                    Id = int.Parse(tbx_ID.Text),
                    Name = tbx_Nombre.Text,
                    Description = tbx_Descripcion.Text,
                    IsEnabled = checkbox_Visible.Checked,
                    CreatedDate = DateTime.Now,


                };
            }
            else
            {
                var Id = int.Parse(tbx_ID.Text);
                concept = conceptList.FirstOrDefault(x => x.Id==Id);

                if (concept != null)
                {
                    conceptList.Remove(concept);

                    concept.Name = tbx_Nombre.Text;
                    concept.Description = tbx_Descripcion.Text;
                    concept.IsEnabled = checkbox_Visible.Checked;
                    concept.ModifiedDate = DateTime.Now;
                }

            }

            conceptList.Add(concept);

            json = JsonConvert.SerializeObject(conceptList);

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            MessageBox.Show("Registro Almacenado", "INTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);


            gbx_Concepto.Enabled = false;
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Cancelar.Enabled = false;

            ClearFields();

            GetRecords();
        }

        private void GetRecords()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Concept.json";

            var conceptList = new List<Concept>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptList = JsonConvert.DeserializeObject<List<Concept>>(json);

            }
            tbx_ID.Text = (conceptList.Count + 1).ToString();
            dgv_Concepto.DataSource = conceptList;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbx_Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

