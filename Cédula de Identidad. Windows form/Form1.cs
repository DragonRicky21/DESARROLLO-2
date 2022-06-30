using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cédula_de_Identidad.Windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (this.dgvUsuarios.SelectedRows.Count == 0)
            {
                btnBorrar.Enabled = false;
            }
        }


        List<Usuario> Usuarios = new List<Usuario>();


        private void btnCrear_Click(object sender, EventArgs e)
        {
            btnCrear.Enabled = true;
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            btnSubirFotoPerfil.Enabled = true;
            gbDatos.Enabled = true;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarUsuario();
        }

        private void ActualizarUsuario()
        {
            Usuario Usuario1 = new Usuario()
            {
                NombreUsuario = this.txtBoxNombre.Text,
                LugarNacimiento = this.txtBoxLugarNac.Text,
                Cedula = this.txtBoxCedula.Text,
                FechaNacimiento = this.dtpFechaNacimiento.Value,
                Nacionalidad = this.txtBoxNacionalidad.Text,
                Sexo = this.cbSexo.Text,
                Sangre = this.cbSangre.Text,
                EstadoCivil = this.cbEstadoCivil.Text,
                Ocupacion = this.txtBoxOcupacion.Text,
                FechaExpiracion = this.dtpFechaExpiracion.Value,
                FotoPerfil = this.pbFotoPerfil.Image,
               

            };

            Usuarios.Add(Usuario1);

            MessageBox.Show("CIUDADANO AÑADIDO");

            LimpiarControles();


            GetUsuarios();

        }
        private void GetUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Usuarios;
        }

        private void LimpiarControles()
        {
            pbFotoPerfil.Image = null;
            dtpFechaNacimiento.Value = DateTime.Today;
            dtpFechaExpiracion.Value = DateTime.Today;

            foreach (Control X in gbDatos.Controls)
            {
                if (X is TextBox or ComboBox)
                {
                    X.Text = string.Empty;
                }
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)

        {
            LimpiarControles();

            DataGridViewRow fila = this.dgvUsuarios.SelectedRows[0];

            Usuarios.RemoveAt(fila.Index);

            GetUsuarios();
            btnBorrar.Enabled = false;

        }

        private void btnSubirFotoPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFotoPerfil.Image = new Bitmap(ofd.FileName);

            }

        }

     
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection selection = this.dgvUsuarios.SelectedCells;
            btnBorrar.Enabled = true;

            this.txtBoxNombre.Text = Convert.ToString(selection[0].Value);
            this.txtBoxCedula.Text = Convert.ToString(selection[1].Value);
            this.txtBoxLugarNac.Text = Convert.ToString(selection[2].Value);
            this.dtpFechaNacimiento.Value = Convert.ToDateTime(selection[3].Value);
            this.txtBoxNacionalidad.Text = Convert.ToString(selection[4].Value);
            this.cbSexo.Text = Convert.ToString(selection[5].Value);
            this.cbSangre.Text = Convert.ToString(selection[6].Value);
            this.cbEstadoCivil.Text = Convert.ToString(selection[7].Value);
            this.txtBoxOcupacion.Text = Convert.ToString(selection[8].Value);
            this.dtpFechaExpiracion.Value = Convert.ToDateTime(selection[9].Value);
            this.pbFotoPerfil.Image = (Image)selection[10].Value;

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
        public Image FotoPerfil { get; set; }
        


    }


}