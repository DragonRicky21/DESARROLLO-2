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
    public partial class Categoria : Form
    {
        public bool Agregar { get; set; } = true;
        public Categoria()
        {
            InitializeComponent();

            GetRecords();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            gbx_Categoria.Enabled = true;
            btn_Nuevo.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_Cancelar.Enabled = true;

            GenerateNewID();
            GetRecords();
        }

        private void GenerateNewID() {


            ClearFields();
            //var Id = 1;
            //tbx_ID.Text = Id.ToString();

        }

        private void ClearFields()
        {
            tbx_ID.Text = String.Empty;
            tbx_Nombre.Text = String.Empty;
            tbx_Descripcion.Text = String.Empty;
            checkbox_Visible.Checked = true;
                
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }

        private void SaveRecord()
        {
            var json = string.Empty;
            var categoryList = new List<Category>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Category.json";

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                categoryList = JsonConvert.DeserializeObject<List<Category>>(json);
            }

            var category = new Category();
            if (Agregar)
            {
                category = new Category
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
                category = categoryList.FirstOrDefault(x => x.Id == Id);

                if(category != null)
                {
                    categoryList.Remove(category);

                    category.Name = tbx_Nombre.Text;
                    category.Description = tbx_Descripcion.Text;
                    category.IsEnabled = checkbox_Visible.Checked;
                    category.ModifiedDate = DateTime.Now;
                }

            }

            categoryList.Add(category);

            json = JsonConvert.SerializeObject(categoryList);

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            MessageBox.Show("Registro Almacenado", "INTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);


            gbx_Categoria.Enabled = false;
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Cancelar.Enabled = false;

            ClearFields();

            GetRecords();
        }

        private void GetRecords()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Category.json";

            var categoryList = new List<Category>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                categoryList = JsonConvert.DeserializeObject<List<Category>>(json);

            }


                tbx_ID.Text = (categoryList.Count + 1).ToString();
                dgv_Categoria.DataSource = categoryList;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
