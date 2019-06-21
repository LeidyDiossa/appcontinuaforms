namespace appcontinuaforms
{
    partial class frmPantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnProgramas = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.btnAlumnos);
            this.panel3.Controls.Add(this.btnReportes);
            this.panel3.Controls.Add(this.btnDocentes);
            this.panel3.Controls.Add(this.btnProgramas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 528);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlumnos.Location = new System.Drawing.Point(0, 172);
            this.btnAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(258, 61);
            this.btnAlumnos.TabIndex = 11;
            this.btnAlumnos.Text = "ALUMNOS";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.BtnAlumnos_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportes.Location = new System.Drawing.Point(0, 380);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(257, 67);
            this.btnReportes.TabIndex = 10;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnDocentes
            // 
            this.btnDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocentes.FlatAppearance.BorderSize = 0;
            this.btnDocentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocentes.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDocentes.Location = new System.Drawing.Point(2, 310);
            this.btnDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(251, 65);
            this.btnDocentes.TabIndex = 9;
            this.btnDocentes.Text = "DOCENTES";
            this.btnDocentes.UseVisualStyleBackColor = true;
            // 
            // btnProgramas
            // 
            this.btnProgramas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProgramas.FlatAppearance.BorderSize = 0;
            this.btnProgramas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnProgramas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnProgramas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramas.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProgramas.Location = new System.Drawing.Point(0, 238);
            this.btnProgramas.Margin = new System.Windows.Forms.Padding(2);
            this.btnProgramas.Name = "btnProgramas";
            this.btnProgramas.Size = new System.Drawing.Size(257, 67);
            this.btnProgramas.TabIndex = 8;
            this.btnProgramas.Text = "PROGRAMAS";
            this.btnProgramas.UseVisualStyleBackColor = true;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Image = global::appcontinuaforms.Properties.Resources.image;
            this.panelPrincipal.Location = new System.Drawing.Point(262, 0);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(713, 528);
            this.panelPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelPrincipal.TabIndex = 10;
            this.panelPrincipal.TabStop = false;
            this.panelPrincipal.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(975, 528);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProgramas;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnDocentes;
        public System.Windows.Forms.PictureBox panelPrincipal;
    }
}

