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
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnRegistrarAlumno);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.txtBoxCedula);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 528);
            this.panel1.TabIndex = 2;
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarAlumno.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAlumno.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(270, 388);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(222, 35);
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
            this.btnConfirmar.Location = new System.Drawing.Point(312, 317);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(145, 35);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // txtBoxCedula
            // 
            this.txtBoxCedula.BackColor = System.Drawing.Color.AliceBlue;
            this.txtBoxCedula.Location = new System.Drawing.Point(270, 204);
            this.txtBoxCedula.MinimumSize = new System.Drawing.Size(50, 30);
            this.txtBoxCedula.Name = "txtBoxCedula";
            this.txtBoxCedula.Size = new System.Drawing.Size(222, 30);
            this.txtBoxCedula.TabIndex = 1;
            this.txtBoxCedula.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(266, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE IDENTIFICACIÒN \r\nDEL ALUMNO\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // frmClickAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(713, 528);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmClickAlumnos";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtBoxCedula;
        private System.Windows.Forms.Button btnRegistrarAlumno;
    }
}