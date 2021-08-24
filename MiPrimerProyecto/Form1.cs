using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyecto
{
    public partial class FormLogin : Form
    {
        string user = "admin";
        string pass = "1234";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Logeo";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un Usuario...");
                this.txtUsuario.Focus();
                return;
            }
            if (this.txtContraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar una clave...");
                this.txtContraseña.Focus();
                return;
            }
            if (this.txtUsuario.Text == this.user && this.txtContraseña.Text == this.pass)
            {
                MessageBox.Show("Login OK", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecta", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtContraseña.Text = "";
                return;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}