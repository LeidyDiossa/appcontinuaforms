namespace appcontinuaforms
{
    partial class frmClickAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtBoxCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelErrorNoexiste = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReintentarAlumno = new System.Windows.Forms.Button();
            this.btnSalirNoexisteAlumno = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelErrorNoexiste.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panelErrorNoexiste);
            this.panel1.Controls.Add(this.btnRegistrarAlumno);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.txtBoxCedula);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 650);
            this.panel1.TabIndex = 2;
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarAlumno.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAlumno.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(349, 508);
            this.btnRegistrarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(296, 43);
            this.btnRegistrarAlumno.TabIndex = 3;
            this.btnRegistrarAlumno.Text = "REGISTRAR ALUMNO";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirmar.Location = new System.Drawing.Point(406, 412);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(193, 43);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // txtBoxCedula
            // 
            this.txtBoxCedula.BackColor = System.Drawing.Color.AliceBlue;
            this.txtBoxCedula.Location = new System.Drawing.Point(349, 282);
            this.txtBoxCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCedula.MinimumSize = new System.Drawing.Size(65, 50);
            this.txtBoxCedula.Name = "txtBoxCedula";
            this.txtBoxCedula.Size = new System.Drawing.Size(295, 22);
            this.txtBoxCedula.TabIndex = 1;
            this.txtBoxCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxCedula.UseWaitCursor = true;
            this.txtBoxCedula.TextChanged += new System.EventHandler(this.TxtBoxCedula_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(360, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE IDENTIFICACIÓN \r\nDEL ALUMNO\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panelErrorNoexiste
            // 
            this.panelErrorNoexiste.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelErrorNoexiste.Controls.Add(this.label2);
            this.panelErrorNoexiste.Controls.Add(this.panel2);
            this.panelErrorNoexiste.Location = new System.Drawing.Point(3, 3);
            this.panelErrorNoexiste.Name = "panelErrorNoexiste";
            this.panelErrorNoexiste.Size = new System.Drawing.Size(548, 358);
            this.panelErrorNoexiste.TabIndex = 4;
            this.panelErrorNoexiste.Visible = false;
            this.panelErrorNoexiste.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelErrorNoexiste_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSalirNoexisteAlumno);
            this.panel2.Controls.Add(this.btnReintentarAlumno);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(90, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 237);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(196, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "ATENCIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(20, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 52);
            this.label3.TabIndex = 1;
            this.label3.Text = "El alumno no se encuentra registrado\r\n en el sistema";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReintentarAlumno
            // 
            this.btnReintentarAlumno.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnReintentarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReintentarAlumno.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReintentarAlumno.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReintentarAlumno.Location = new System.Drawing.Point(87, 122);
            this.btnReintentarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnReintentarAlumno.Name = "btnReintentarAlumno";
            this.btnReintentarAlumno.Size = new System.Drawing.Size(193, 43);
            this.btnReintentarAlumno.TabIndex = 3;
            this.btnReintentarAlumno.Text = "REINTENTAR";
            this.btnReintentarAlumno.UseVisualStyleBackColor = false;
            // 
            // btnSalirNoexisteAlumno
            // 
            this.btnSalirNoexisteAlumno.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalirNoexisteAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirNoexisteAlumno.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirNoexisteAlumno.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalirNoexisteAlumno.Location = new System.Drawing.Point(87, 173);
            this.btnSalirNoexisteAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalirNoexisteAlumno.Name = "btnSalirNoexisteAlumno";
            this.btnSalirNoexisteAlumno.Size = new System.Drawing.Size(193, 43);
            this.btnSalirNoexisteAlumno.TabIndex = 5;
            this.btnSalirNoexisteAlumno.Text = "SALIR";
            this.btnSalirNoexisteAlumno.UseVisualStyleBackColor = false;
            // 
            // frmClickAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(951, 650);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmClickAlumnos";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelErrorNoexiste.ResumeLayout(false);
            this.panelErrorNoexiste.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtBoxCedula;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.Panel panelErrorNoexiste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalirNoexisteAlumno;
        private System.Windows.Forms.Button btnReintentarAlumno;
    }
}