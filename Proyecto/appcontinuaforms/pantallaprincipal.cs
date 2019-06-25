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

namespace appcontinuaforms
{
    public partial class frmPantallaPrincipal : Form
    {
         
        public frmPantallaPrincipal()
        {
            InitializeComponent();
        }

        // Código para mover ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormConsulta(new frmClickAlumnos());
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void AbrirFormConsulta(Object frmClickAlumnos)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fc = frmClickAlumnos as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fc);
            this.panelPrincipal.Tag = fc;
            fc.Show();

        }

        private void AbrirFormRAspirante(Object frmRegistrarAspirante)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form ra = frmRegistrarAspirante as Form;
            ra.TopLevel = false;
            ra.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(ra);
            this.panelPrincipal.Tag = ra;
            ra.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AbrirFormRAspirante(new frmregistraraspirante());
        }

        //Complemento para poder mover ventana y panel 
        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void PanelPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    // Código para cerrar ventana
        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    // Codigo para minimizar ventana
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
