using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProyectoFinal
{
    public partial class VentanaLogIn : Form
    {
        public VentanaLogIn()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void VentanaLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Complemento para poder mover ventana y panel 
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Conexión a la BD
            string connStr = "Server = localhost; user = root; database = proyectoprueba; port=3306";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                //lblEstadoConexion.Text = "Conectando a MySQL...";
                conn.Open();
                string query = "SELECT * FROM usuarios WHERE nombre_usuario = '" + txtUser.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (!rdr.HasRows)
                {
                    MessageBox.Show("Usuario no se encontró en la BD");
                }

                while (rdr.Read())
                {
                    if (rdr[1].ToString() == txtPassword.Text)
                    {
                        MessageBox.Show("Login Exitoso");
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña inválidos");
                    }
                }
                conn.Close();
                //lblEstadoConexion.Text = "Conexión Exitosa";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TxtUser_MouseEnter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USER")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }

        }

        private void TxtUser_MouseLeave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USER";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void TxtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.Text = "";
                txtUser.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void TxtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "PASSWORD";
                txtUser.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
