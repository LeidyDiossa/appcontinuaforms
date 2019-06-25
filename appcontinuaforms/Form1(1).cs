using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appcontinuaforms
{
    public partial class frmPantallaPrincipal : Form
    {
         
        public frmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormConsulta(new frmClickAlumnos());
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

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
        
    }
}
