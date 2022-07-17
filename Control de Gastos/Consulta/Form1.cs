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
    public partial class Form1 : Form
    {
        public bool Agregar { get; set; } = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Concepto_Click(object sender, EventArgs e)
        {
            var ConceptForm = new Concepto();
            ConceptForm.ShowDialog();
        }

        private void btn_Categoria_Click(object sender, EventArgs e)
        {
            var CategoriaForm = new Categoria();
            CategoriaForm.ShowDialog();
        }
        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            GetRecords();
            SaveRecord();
        }
        private void SaveRecord()
        {
            var json = string.Empty;
            var IngresosList = new List<IngresosyEgresos>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\IngresosyEgresos.json";

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                IngresosList = JsonConvert.DeserializeObject<List<IngresosyEgresos>>(json);
            }
            

            var Ingresos = new IngresosyEgresos();
            if (Agregar)
            {
                Ingresos = new IngresosyEgresos
                {
                    Id = int.Parse(tbx_ID.Text),
                    Concept = cbx_Concepto.Text,
                    Category = cbx_Categoria.Text,
                    Quality = cbx_Calidad.Text,
                    CreatedDate = DateTime.Now,


                };
            }
            else
            {
                var Id = int.Parse(tbx_ID.Text);
                Ingresos = IngresosList.FirstOrDefault(x => x.Id == Id);

                if (Ingresos != null)
                {
                    IngresosList.Remove(Ingresos);

                    Ingresos.Id = int.Parse(tbx_ID.Text);
                    Ingresos.Concept = cbx_Concepto.Text;
                    Ingresos.Category = cbx_Categoria.Text;
                    Ingresos.Quality = cbx_Calidad.Text;
                    Ingresos.CreatedDate = DateTime.Now;
                }

            }

            IngresosList.Add(Ingresos);

            json = JsonConvert.SerializeObject(IngresosList);

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            MessageBox.Show("Registro Almacenado", "INTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetRecords();
        }

        private void GetRecords()
        {
                var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\IngresosyEgresos.json";

                 var IngresosList = new List<IngresosyEgresos>();

            if (File.Exists(pathFile))
                {
                    var json = File.ReadAllText(pathFile, Encoding.UTF8);
                IngresosList = JsonConvert.DeserializeObject<List<IngresosyEgresos>>(json);

                }

            tbx_ID.Text = (IngresosList.Count + 1).ToString();
            dgv_Consulta.DataSource = IngresosList;
            
        }

        private void cbx_Concepto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Concepto_Click(object sender, EventArgs e)
        {
            GetConcepts();
        }

        void GetConcepts()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Concept.json";
            var conceptList = new List<Concept>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptList = JsonConvert.DeserializeObject<List<Concept>>(json);
            }

            cbx_Concepto.DataSource = conceptList.Where(x => x.IsEnabled).ToList();
            cbx_Concepto.DisplayMember = "Name";
            cbx_Concepto.ValueMember = "Id";
        }

        private void cbx_Categoria_Click(object sender, EventArgs e)
        {
            GetCategories();
        }
        void GetCategories()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Category.json";
            var categoryList = new List<Category>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                categoryList = JsonConvert.DeserializeObject<List<Category>>(json);
            }

            cbx_Categoria.DataSource = categoryList.Where(x => x.IsEnabled).ToList();
            cbx_Categoria.DisplayMember = "Name";
            cbx_Categoria.ValueMember = "Id";
        }

        private void tbx_Calidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
