namespace appcontinuaforms
{
    partial class Error
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarAspiranteFormulario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnRegistrarAspiranteFormulario);
            this.panel1.Location = new System.Drawing.Point(71, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 186);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(152, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATENCIÓN";
            // 
            // btnRegistrarAspiranteFormulario
            // 
            this.btnRegistrarAspiranteFormulario.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrarAspiranteFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarAspiranteFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAspiranteFormulario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarAspiranteFormulario.Location = new System.Drawing.Point(71, 134);
            this.btnRegistrarAspiranteFormulario.Name = "btnRegistrarAspiranteFormulario";
            this.btnRegistrarAspiranteFormulario.Size = new System.Drawing.Size(145, 35);
            this.btnRegistrarAspiranteFormulario.TabIndex = 23;
            this.btnRegistrarAspiranteFormulario.Text = "SALIR";
            this.btnRegistrarAspiranteFormulario.UseVisualStyleBackColor = false;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(431, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Error";
            this.Opacity = 0.9D;
            this.Text = "Error";
            this.Load += new System.EventHandler(this.Error_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarAspiranteFormulario;
    }
}