namespace appcontinuaforms
{
    partial class frmregistraraspirante
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
            this.lblTipodePrograma = new System.Windows.Forms.Label();
            this.checkBoxCurso = new System.Windows.Forms.CheckBox();
            this.checkBoxConferencia = new System.Windows.Forms.CheckBox();
            this.checkBoxDiplomado = new System.Windows.Forms.CheckBox();
            this.checkBoxTaller = new System.Windows.Forms.CheckBox();
            this.checkBoxSeminario = new System.Windows.Forms.CheckBox();
            this.lblProgramasDisponibles = new System.Windows.Forms.Label();
            this.comboBoxProgramasDisponibles = new System.Windows.Forms.ComboBox();
            this.lblDocumentoTipo = new System.Windows.Forms.Label();
            this.checkBoxTarjetaIdentidad = new System.Windows.Forms.CheckBox();
            this.checkBoxCedula = new System.Windows.Forms.CheckBox();
            this.textBoxRegistrarDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrarAspiranteFormulario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipodePrograma
            // 
            this.lblTipodePrograma.AutoSize = true;
            this.lblTipodePrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodePrograma.Location = new System.Drawing.Point(63, -39);
            this.lblTipodePrograma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipodePrograma.Name = "lblTipodePrograma";
            this.lblTipodePrograma.Size = new System.Drawing.Size(134, 20);
            this.lblTipodePrograma.TabIndex = 0;
            this.lblTipodePrograma.Text = "Tipo de Programa";
            // 
            // checkBoxCurso
            // 
            this.checkBoxCurso.AutoSize = true;
            this.checkBoxCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCurso.Location = new System.Drawing.Point(89, 53);
            this.checkBoxCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxCurso.Name = "checkBoxCurso";
            this.checkBoxCurso.Size = new System.Drawing.Size(68, 22);
            this.checkBoxCurso.TabIndex = 1;
            this.checkBoxCurso.Text = "Curso";
            this.checkBoxCurso.UseVisualStyleBackColor = true;
            // 
            // checkBoxConferencia
            // 
            this.checkBoxConferencia.AutoSize = true;
            this.checkBoxConferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxConferencia.Location = new System.Drawing.Point(89, 103);
            this.checkBoxConferencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxConferencia.Name = "checkBoxConferencia";
            this.checkBoxConferencia.Size = new System.Drawing.Size(107, 22);
            this.checkBoxConferencia.TabIndex = 2;
            this.checkBoxConferencia.Text = "Conferencia";
            this.checkBoxConferencia.UseVisualStyleBackColor = true;
            this.checkBoxConferencia.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBoxDiplomado
            // 
            this.checkBoxDiplomado.AutoSize = true;
            this.checkBoxDiplomado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDiplomado.Location = new System.Drawing.Point(218, 53);
            this.checkBoxDiplomado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxDiplomado.Name = "checkBoxDiplomado";
            this.checkBoxDiplomado.Size = new System.Drawing.Size(99, 22);
            this.checkBoxDiplomado.TabIndex = 3;
            this.checkBoxDiplomado.Text = "Diplomado";
            this.checkBoxDiplomado.UseVisualStyleBackColor = true;
            // 
            // checkBoxTaller
            // 
            this.checkBoxTaller.AutoSize = true;
            this.checkBoxTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTaller.Location = new System.Drawing.Point(218, 103);
            this.checkBoxTaller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxTaller.Name = "checkBoxTaller";
            this.checkBoxTaller.Size = new System.Drawing.Size(63, 22);
            this.checkBoxTaller.TabIndex = 4;
            this.checkBoxTaller.Text = "Taller";
            this.checkBoxTaller.UseVisualStyleBackColor = true;
            // 
            // checkBoxSeminario
            // 
            this.checkBoxSeminario.AutoSize = true;
            this.checkBoxSeminario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSeminario.Location = new System.Drawing.Point(346, 53);
            this.checkBoxSeminario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSeminario.Name = "checkBoxSeminario";
            this.checkBoxSeminario.Size = new System.Drawing.Size(94, 22);
            this.checkBoxSeminario.TabIndex = 5;
            this.checkBoxSeminario.Text = "Seminario";
            this.checkBoxSeminario.UseVisualStyleBackColor = true;
            // 
            // lblProgramasDisponibles
            // 
            this.lblProgramasDisponibles.AutoSize = true;
            this.lblProgramasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramasDisponibles.Location = new System.Drawing.Point(63, 158);
            this.lblProgramasDisponibles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgramasDisponibles.Name = "lblProgramasDisponibles";
            this.lblProgramasDisponibles.Size = new System.Drawing.Size(238, 20);
            this.lblProgramasDisponibles.TabIndex = 6;
            this.lblProgramasDisponibles.Text = "Seleccione Programa Disponible";
            // 
            // comboBoxProgramasDisponibles
            // 
            this.comboBoxProgramasDisponibles.FormattingEnabled = true;
            this.comboBoxProgramasDisponibles.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxProgramasDisponibles.Location = new System.Drawing.Point(315, 159);
            this.comboBoxProgramasDisponibles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxProgramasDisponibles.Name = "comboBoxProgramasDisponibles";
            this.comboBoxProgramasDisponibles.Size = new System.Drawing.Size(122, 21);
            this.comboBoxProgramasDisponibles.TabIndex = 7;
            this.comboBoxProgramasDisponibles.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // lblDocumentoTipo
            // 
            this.lblDocumentoTipo.AutoSize = true;
            this.lblDocumentoTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentoTipo.Location = new System.Drawing.Point(63, 207);
            this.lblDocumentoTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocumentoTipo.Name = "lblDocumentoTipo";
            this.lblDocumentoTipo.Size = new System.Drawing.Size(148, 20);
            this.lblDocumentoTipo.TabIndex = 8;
            this.lblDocumentoTipo.Text = "Tipo de Documento";
            // 
            // checkBoxTarjetaIdentidad
            // 
            this.checkBoxTarjetaIdentidad.AutoSize = true;
            this.checkBoxTarjetaIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTarjetaIdentidad.Location = new System.Drawing.Point(218, 213);
            this.checkBoxTarjetaIdentidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxTarjetaIdentidad.Name = "checkBoxTarjetaIdentidad";
            this.checkBoxTarjetaIdentidad.Size = new System.Drawing.Size(43, 21);
            this.checkBoxTarjetaIdentidad.TabIndex = 9;
            this.checkBoxTarjetaIdentidad.Text = "T.I";
            this.checkBoxTarjetaIdentidad.UseVisualStyleBackColor = true;
            // 
            // checkBoxCedula
            // 
            this.checkBoxCedula.AutoSize = true;
            this.checkBoxCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCedula.Location = new System.Drawing.Point(315, 213);
            this.checkBoxCedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxCedula.Name = "checkBoxCedula";
            this.checkBoxCedula.Size = new System.Drawing.Size(49, 21);
            this.checkBoxCedula.TabIndex = 10;
            this.checkBoxCedula.Text = "C.C";
            this.checkBoxCedula.UseVisualStyleBackColor = true;
            // 
            // textBoxRegistrarDocumento
            // 
            this.textBoxRegistrarDocumento.Location = new System.Drawing.Point(249, 259);
            this.textBoxRegistrarDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRegistrarDocumento.Name = "textBoxRegistrarDocumento";
            this.textBoxRegistrarDocumento.Size = new System.Drawing.Size(188, 20);
            this.textBoxRegistrarDocumento.TabIndex = 11;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(63, 255);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(174, 20);
            this.lblDocumento.TabIndex = 12;
            this.lblDocumento.Text = "Número de Documento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 311);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(494, 311);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(174, 365);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(494, 366);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(188, 20);
            this.textBox4.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 307);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tipo de Programa";
            // 
            // btnRegistrarAspiranteFormulario
            // 
            this.btnRegistrarAspiranteFormulario.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrarAspiranteFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarAspiranteFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAspiranteFormulario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarAspiranteFormulario.Location = new System.Drawing.Point(315, 470);
            this.btnRegistrarAspiranteFormulario.Name = "btnRegistrarAspiranteFormulario";
            this.btnRegistrarAspiranteFormulario.Size = new System.Drawing.Size(145, 35);
            this.btnRegistrarAspiranteFormulario.TabIndex = 22;
            this.btnRegistrarAspiranteFormulario.Text = "REGISTRAR";
            this.btnRegistrarAspiranteFormulario.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appcontinuaforms.Properties.Resources.image__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-12, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmregistraraspirante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 528);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegistrarAspiranteFormulario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.textBoxRegistrarDocumento);
            this.Controls.Add(this.checkBoxCedula);
            this.Controls.Add(this.checkBoxTarjetaIdentidad);
            this.Controls.Add(this.lblDocumentoTipo);
            this.Controls.Add(this.comboBoxProgramasDisponibles);
            this.Controls.Add(this.lblProgramasDisponibles);
            this.Controls.Add(this.checkBoxSeminario);
            this.Controls.Add(this.checkBoxTaller);
            this.Controls.Add(this.checkBoxDiplomado);
            this.Controls.Add(this.checkBoxConferencia);
            this.Controls.Add(this.checkBoxCurso);
            this.Controls.Add(this.lblTipodePrograma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmregistraraspirante";
            this.Text = "Noexiste";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipodePrograma;
        private System.Windows.Forms.CheckBox checkBoxCurso;
        private System.Windows.Forms.CheckBox checkBoxConferencia;
        private System.Windows.Forms.CheckBox checkBoxDiplomado;
        private System.Windows.Forms.CheckBox checkBoxTaller;
        private System.Windows.Forms.CheckBox checkBoxSeminario;
        private System.Windows.Forms.Label lblProgramasDisponibles;
        private System.Windows.Forms.ComboBox comboBoxProgramasDisponibles;
        private System.Windows.Forms.Label lblDocumentoTipo;
        private System.Windows.Forms.CheckBox checkBoxTarjetaIdentidad;
        private System.Windows.Forms.CheckBox checkBoxCedula;
        private System.Windows.Forms.TextBox textBoxRegistrarDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrarAspiranteFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}