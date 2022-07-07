using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Cédula_de_Identidad.Windows_form
{
    public partial class Form1 : Form
    {
        public bool Adding { get; set; } = true;
        public Form1()
        {
            InitializeComponent();
            if (this.dgvUsuarios.SelectedRows.Count == 0)
            {
                btnBorrar.Enabled = false;
            }
        }


        List<Usuario> Usuarios = new List<Usuario>();


        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            btnCrear.Enabled = true;
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            btnSubirFotoPerfil.Enabled = true;
            gbDatos.Enabled = true;
        }
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            ActualizarUsuario();
        }
        

        private void ActualizarUsuario()
        {
            var json = string.Empty;
            var usuarioList = new List<Usuario>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Usuarios.json";

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                usuarioList = JsonConvert.DeserializeObject<List<Usuario>>(json);
            }

            var Usuario1 = new Usuario();
            if (Adding)
            {
                Usuario1 = new Usuario
                {
                    NombreUsuario = txtBoxNombre.Text,
                    LugarNacimiento = txtBoxLugarNac.Text,
                    Cedula = txtBoxCedula.Text,
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    Nacionalidad = txtBoxNacionalidad.Text,
                    Sexo = cbSexo.Text,
                    Sangre = cbSangre.Text,
                    EstadoCivil = cbEstadoCivil.Text,
                    Ocupacion = txtBoxOcupacion.Text,
                    FechaExpiracion = dtpFechaExpiracion.Value,
                    FotoPerfil = pbFotoPerfil.ImageLocation,


                };
            }

            usuarioList.Add(Usuario1);

            json = JsonConvert.SerializeObject(usuarioList);

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            MessageBox.Show("CIUDADANO AÑADIDO");

            LimpiarControles();


            GetUsuarios();

        }
        private void GetUsuarios()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Usuarios.json";
            var usuarioList = new List<Usuario>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                usuarioList = JsonConvert.DeserializeObject<List<Usuario>>(json);
            }

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarioList;
        }

        private void LimpiarControles()
        {
            pbFotoPerfil.Image = null;
            dtpFechaNacimiento.Value = DateTime.Today;
            dtpFechaExpiracion.Value = DateTime.Today;

            foreach (Control X in gbDatos.Controls)
            {
                if (X is TextBox )
                {
                    X.Text = string.Empty;
                }
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)

        {
           
        }

        private void btnSubirFotoPerfil_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFotoPerfil.ImageLocation = ofd.FileName;

            }

        }

     
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void txtBoxCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbFotoPerfil_Click(object sender, EventArgs e)
        {

        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            LimpiarControles();

            DataGridViewRow fila = this.dgvUsuarios.SelectedRows[0];

            Usuarios.RemoveAt(fila.Index);

            GetUsuarios();
            btnBorrar.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


    public class Usuario
    {

        public string NombreUsuario { get; set; }
        public string Cedula { get; set; }

        public string LugarNacimiento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Sexo { get; set; }
        public string Sangre { get; set; }
        public string EstadoCivil { get; set; }

        public string Ocupacion { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public string FotoPerfil { get; set; }
        


    }


}