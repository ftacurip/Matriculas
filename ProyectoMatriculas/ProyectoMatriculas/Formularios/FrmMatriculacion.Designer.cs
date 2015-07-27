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
            this.LblFecha = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CbPeriodo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNumeroMatricula = new System.Windows.Forms.TextBox();
            this.gbx_busq_est = new System.Windows.Forms.GroupBox();
            this.BtnBuscarEstudiante = new System.Windows.Forms.Button();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbCurso = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvMatricula = new System.Windows.Forms.DataGridView();
            this.gbx_info_mat.SuspendLayout();
            this.gbx_busq_est.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_info_mat
            // 
            this.gbx_info_mat.Controls.Add(this.LblFecha);
            this.gbx_info_mat.Controls.Add(this.BtnNuevo);
            this.gbx_info_mat.Controls.Add(this.BtnGuardar);
            this.gbx_info_mat.Controls.Add(this.CbPeriodo);
            this.gbx_info_mat.Controls.Add(this.label9);
            this.gbx_info_mat.Controls.Add(this.TxtNumeroMatricula);
            this.gbx_info_mat.Controls.Add(this.gbx_busq_est);
            this.gbx_info_mat.Controls.Add(this.label2);
            this.gbx_info_mat.Controls.Add(this.CbCurso);
            this.gbx_info_mat.Controls.Add(this.label8);
            this.gbx_info_mat.Controls.Add(this.label7);
            this.gbx_info_mat.Location = new System.Drawing.Point(12, 12);
            this.gbx_info_mat.Name = "gbx_info_mat";
            this.gbx_info_mat.Size = new System.Drawing.Size(550, 258);
            this.gbx_info_mat.TabIndex = 1108;
            this.gbx_info_mat.TabStop = false;
            this.gbx_info_mat.Text = "Datos de Matrícula";
            // 
            // LblFecha
            // 
            this.LblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFecha.Location = new System.Drawing.Point(416, 205);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(127, 20);
            this.LblFecha.TabIndex = 1113;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(387, 228);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 1109;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(468, 228);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 1111;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CbPeriodo
            // 
            this.CbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPeriodo.FormattingEnabled = true;
            this.CbPeriodo.Location = new System.Drawing.Point(235, 203);
            this.CbPeriodo.Name = "CbPeriodo";
            this.CbPeriodo.Size = new System.Drawing.Size(126, 21);
            this.CbPeriodo.TabIndex = 1112;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 1111;
            this.label9.Text = "Periodo:";
            // 
            // TxtNumeroMatricula
            // 
            this.TxtNumeroMatricula.Location = new System.Drawing.Point(79, 19);
            this.TxtNumeroMatricula.Name = "TxtNumeroMatricula";
            this.TxtNumeroMatricula.ReadOnly = true;
            this.TxtNumeroMatricula.Size = new System.Drawing.Size(102, 20);
            this.TxtNumeroMatricula.TabIndex = 1104;
            // 
            // gbx_busq_est
            // 
            this.gbx_busq_est.Controls.Add(this.BtnBuscarEstudiante);
            this.gbx_busq_est.Controls.Add(this.TxtCedula);
            this.gbx_busq_est.Controls.Add(this.TxtTelefono);
            this.gbx_busq_est.Controls.Add(this.TxtDireccion);
            this.gbx_busq_est.Controls.Add(this.label6);
            this.gbx_busq_est.Controls.Add(this.label3);
            this.gbx_busq_est.Controls.Add(this.label1);
            this.gbx_busq_est.Controls.Add(this.TxtApellido);
            this.gbx_busq_est.Controls.Add(this.Label5);
            this.gbx_busq_est.Controls.Add(this.TxtNombre);
            this.gbx_busq_est.Controls.Add(this.label4);
            this.gbx_busq_est.Location = new System.Drawing.Point(6, 45);
            this.gbx_busq_est.Name = "gbx_busq_est";
            this.gbx_busq_est.Size = new System.Drawing.Size(537, 152);
            this.gbx_busq_est.TabIndex = 1110;
            this.gbx_busq_est.TabStop = false;
            this.gbx_busq_est.Text = "Búsqueda de Estudiantes";
            // 
            // BtnBuscarEstudiante
            // 
            this.BtnBuscarEstudiante.Location = new System.Drawing.Point(181, 17);
            this.BtnBuscarEstudiante.Name = "BtnBuscarEstudiante";
            this.BtnBuscarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarEstudiante.TabIndex = 1112;
            this.BtnBuscarEstudiante.Text = "Buscar";
            this.BtnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.BtnBuscarEstudiante.Click += new System.EventHandler(this.BtnBuscarEstudiante_Click);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(73, 19);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(102, 20);
            this.TxtCedula.TabIndex = 1105;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(73, 123);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.ReadOnly = true;
            this.TxtTelefono.Size = new System.Drawing.Size(102, 20);
            this.TxtTelefono.TabIndex = 1093;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(73, 97);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ReadOnly = true;
            this.TxtDireccion.Size = new System.Drawing.Size(458, 20);
            this.TxtDireccion.TabIndex = 1092;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 1091;
            this.label6.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1090;
            this.label3.Text = "Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1102;
            this.label1.Text = "Cedula:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtApellido.Location = new System.Drawing.Point(73, 71);
            this.TxtApellido.MaxLength = 40;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.ReadOnly = true;
            this.TxtApellido.Size = new System.Drawing.Size(458, 20);
            this.TxtApellido.TabIndex = 1085;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 74);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(47, 13);
            this.Label5.TabIndex = 1089;
            this.Label5.Text = "Apellido:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtNombre.Location = new System.Drawing.Point(73, 45);
            this.TxtNombre.MaxLength = 40;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(458, 20);
            this.TxtNombre.TabIndex = 1084;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1087;
            this.label4.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1103;
            this.label2.Text = "Nº Matricula:";
            // 
            // CbCurso
            // 
            this.CbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCurso.FormattingEnabled = true;
            this.CbCurso.Location = new System.Drawing.Point(55, 203);
            this.CbCurso.Name = "CbCurso";
            this.CbCurso.Size = new System.Drawing.Size(126, 21);
            this.CbCurso.TabIndex = 1097;
            this.CbCurso.SelectedIndexChanged += new System.EventHandler(this.CbCurso_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 1090;
            this.label8.Text = "Curso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 1096;
            this.label7.Text = "Fecha:";
            // 
            // DgvMatricula
            // 
            this.DgvMatricula.AllowUserToAddRows = false;
            this.DgvMatricula.AllowUserToDeleteRows = false;
            this.DgvMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMatricula.Location = new System.Drawing.Point(12, 276);
            this.DgvMatricula.Name = "DgvMatricula";
            this.DgvMatricula.ReadOnly = true;
            this.DgvMatricula.Size = new System.Drawing.Size(550, 177);
            this.DgvMatricula.TabIndex = 1112;
            // 
            // FrmMatriculacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 463);
            this.Controls.Add(this.DgvMatricula);
            this.Controls.Add(this.gbx_info_mat);
            this.MaximizeBox = false;
            this.Name = "FrmMatriculacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Matricula";
            this.Load += new System.EventHandler(this.FrmMatriculacion_Load);
            this.gbx_info_mat.ResumeLayout(false);
            this.gbx_info_mat.PerformLayout();
            this.gbx_busq_est.ResumeLayout(false);
            this.gbx_busq_est.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMatricula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_info_mat;
        private System.Windows.Forms.ComboBox CbCurso;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtNumeroMatricula;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.GroupBox gbx_busq_est;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox TxtApellido;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TxtNombre;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DgvMatricula;
        private System.Windows.Forms.Button BtnBuscarEstudiante;
        internal System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.ComboBox CbPeriodo;
        internal System.Windows.Forms.Label label9;
    }
}