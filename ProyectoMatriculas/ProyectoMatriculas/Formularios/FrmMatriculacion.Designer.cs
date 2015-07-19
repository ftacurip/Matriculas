namespace ProyectoMatriculas.Formularios
{
    partial class FrmMatriculacion
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
            this.gbx_info_mat = new System.Windows.Forms.GroupBox();
            this.cmbx_jornada = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtn_nueva = new System.Windows.Forms.RadioButton();
            this.rbtn_renovacion = new System.Windows.Forms.RadioButton();
            this.cmbx_curso = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbx_info_mat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_info_mat
            // 
            this.gbx_info_mat.Controls.Add(this.cmbx_jornada);
            this.gbx_info_mat.Controls.Add(this.label3);
            this.gbx_info_mat.Controls.Add(this.rbtn_nueva);
            this.gbx_info_mat.Controls.Add(this.rbtn_renovacion);
            this.gbx_info_mat.Controls.Add(this.cmbx_curso);
            this.gbx_info_mat.Controls.Add(this.label8);
            this.gbx_info_mat.Controls.Add(this.label7);
            this.gbx_info_mat.Controls.Add(this.txt_fecha);
            this.gbx_info_mat.Controls.Add(this.txt_monto);
            this.gbx_info_mat.Controls.Add(this.label9);
            this.gbx_info_mat.Controls.Add(this.label10);
            this.gbx_info_mat.Location = new System.Drawing.Point(12, 12);
            this.gbx_info_mat.Name = "gbx_info_mat";
            this.gbx_info_mat.Size = new System.Drawing.Size(274, 209);
            this.gbx_info_mat.TabIndex = 1108;
            this.gbx_info_mat.TabStop = false;
            this.gbx_info_mat.Text = "Datos de Matrícula";
            // 
            // cmbx_jornada
            // 
            this.cmbx_jornada.FormattingEnabled = true;
            this.cmbx_jornada.Location = new System.Drawing.Point(85, 110);
            this.cmbx_jornada.Name = "cmbx_jornada";
            this.cmbx_jornada.Size = new System.Drawing.Size(183, 21);
            this.cmbx_jornada.TabIndex = 1101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1100;
            this.label3.Text = "JORNADA:";
            // 
            // rbtn_nueva
            // 
            this.rbtn_nueva.Location = new System.Drawing.Point(159, 77);
            this.rbtn_nueva.Name = "rbtn_nueva";
            this.rbtn_nueva.Size = new System.Drawing.Size(71, 24);
            this.rbtn_nueva.TabIndex = 1099;
            this.rbtn_nueva.TabStop = true;
            this.rbtn_nueva.Text = "NUEVA";
            this.rbtn_nueva.UseVisualStyleBackColor = true;
            // 
            // rbtn_renovacion
            // 
            this.rbtn_renovacion.Location = new System.Drawing.Point(49, 77);
            this.rbtn_renovacion.Name = "rbtn_renovacion";
            this.rbtn_renovacion.Size = new System.Drawing.Size(104, 24);
            this.rbtn_renovacion.TabIndex = 1098;
            this.rbtn_renovacion.TabStop = true;
            this.rbtn_renovacion.Text = "RENOVACIÓN";
            this.rbtn_renovacion.UseVisualStyleBackColor = true;
            // 
            // cmbx_curso
            // 
            this.cmbx_curso.FormattingEnabled = true;
            this.cmbx_curso.Location = new System.Drawing.Point(85, 23);
            this.cmbx_curso.Name = "cmbx_curso";
            this.cmbx_curso.Size = new System.Drawing.Size(183, 21);
            this.cmbx_curso.TabIndex = 1097;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 1090;
            this.label8.Text = "CURSO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 1096;
            this.label7.Text = "FECHA:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha.Location = new System.Drawing.Point(85, 144);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(183, 20);
            this.txt_fecha.TabIndex = 1095;
            // 
            // txt_monto
            // 
            this.txt_monto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_monto.Location = new System.Drawing.Point(85, 177);
            this.txt_monto.MaxLength = 40;
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(183, 20);
            this.txt_monto.TabIndex = 1085;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 1089;
            this.label9.Text = "MONTO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(67, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 13);
            this.label10.TabIndex = 1087;
            this.label10.Text = "TIPO DE MATRÍCULA:";
            // 
            // FrmMatriculacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 393);
            this.Controls.Add(this.gbx_info_mat);
            this.Name = "FrmMatriculacion";
            this.Text = "FrmMatriculacion";
            this.gbx_info_mat.ResumeLayout(false);
            this.gbx_info_mat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_info_mat;
        private System.Windows.Forms.ComboBox cmbx_jornada;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtn_nueva;
        private System.Windows.Forms.RadioButton rbtn_renovacion;
        private System.Windows.Forms.ComboBox cmbx_curso;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        internal System.Windows.Forms.TextBox txt_monto;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
    }
}