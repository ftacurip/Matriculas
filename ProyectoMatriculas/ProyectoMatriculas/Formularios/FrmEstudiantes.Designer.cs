namespace ProyectoMatriculas.Formularios
{
    partial class FrmEstudiantes
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
            this.gbx_estudiante = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_num_doc = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_apellido1 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.gbx_estudiante.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_estudiante
            // 
            this.gbx_estudiante.Controls.Add(this.label7);
            this.gbx_estudiante.Controls.Add(this.txt_fecha);
            this.gbx_estudiante.Controls.Add(this.txt_telefono);
            this.gbx_estudiante.Controls.Add(this.label3);
            this.gbx_estudiante.Controls.Add(this.txt_direccion);
            this.gbx_estudiante.Controls.Add(this.label6);
            this.gbx_estudiante.Controls.Add(this.Label1);
            this.gbx_estudiante.Controls.Add(this.txt_num_doc);
            this.gbx_estudiante.Controls.Add(this.Label2);
            this.gbx_estudiante.Controls.Add(this.txt_apellido1);
            this.gbx_estudiante.Controls.Add(this.Label5);
            this.gbx_estudiante.Controls.Add(this.txt_nombre);
            this.gbx_estudiante.Location = new System.Drawing.Point(12, 21);
            this.gbx_estudiante.Name = "gbx_estudiante";
            this.gbx_estudiante.Size = new System.Drawing.Size(616, 142);
            this.gbx_estudiante.TabIndex = 1086;
            this.gbx_estudiante.TabStop = false;
            this.gbx_estudiante.Text = "Información del Estudiante";
            this.gbx_estudiante.Enter += new System.EventHandler(this.gbx_estudiante_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 1096;
            this.label7.Text = "FECHA NACIMIENTO:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha.Location = new System.Drawing.Point(435, 91);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(160, 20);
            this.txt_fecha.TabIndex = 1095;
            // 
            // txt_telefono
            // 
            this.txt_telefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_telefono.Location = new System.Drawing.Point(398, 60);
            this.txt_telefono.MaxLength = 15;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(197, 20);
            this.txt_telefono.TabIndex = 1092;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1093;
            this.label3.Text = "TELEFONO:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_direccion.Location = new System.Drawing.Point(398, 23);
            this.txt_direccion.MaxLength = 40;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(197, 20);
            this.txt_direccion.TabIndex = 1091;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 1094;
            this.label6.Text = "DIRECCION:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 13);
            this.Label1.TabIndex = 1090;
            this.Label1.Text = "Nº Cedula:";
            // 
            // txt_num_doc
            // 
            this.txt_num_doc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_num_doc.Location = new System.Drawing.Point(109, 23);
            this.txt_num_doc.MaxLength = 20;
            this.txt_num_doc.Name = "txt_num_doc";
            this.txt_num_doc.Size = new System.Drawing.Size(197, 20);
            this.txt_num_doc.TabIndex = 1083;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 57);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 13);
            this.Label2.TabIndex = 1087;
            this.Label2.Text = "Nombre:";
            // 
            // txt_apellido1
            // 
            this.txt_apellido1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_apellido1.Location = new System.Drawing.Point(109, 90);
            this.txt_apellido1.MaxLength = 40;
            this.txt_apellido1.Name = "txt_apellido1";
            this.txt_apellido1.Size = new System.Drawing.Size(197, 20);
            this.txt_apellido1.TabIndex = 1085;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 90);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(47, 13);
            this.Label5.TabIndex = 1089;
            this.Label5.Text = "Apellido:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_nombre.Location = new System.Drawing.Point(109, 57);
            this.txt_nombre.MaxLength = 40;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(197, 20);
            this.txt_nombre.TabIndex = 1084;
            // 
            // FrmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 328);
            this.Controls.Add(this.gbx_estudiante);
            this.Name = "FrmEstudiantes";
            this.Text = "FrmEstudiantes";
            this.gbx_estudiante.ResumeLayout(false);
            this.gbx_estudiante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_estudiante;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        internal System.Windows.Forms.TextBox txt_telefono;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txt_direccion;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_num_doc;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_apellido1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txt_nombre;
    }
}