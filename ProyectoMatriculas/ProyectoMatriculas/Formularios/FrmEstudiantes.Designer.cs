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
            this.DTFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DgvEstudiante = new System.Windows.Forms.DataGridView();
            this.gbx_estudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_estudiante
            // 
            this.gbx_estudiante.Controls.Add(this.label7);
            this.gbx_estudiante.Controls.Add(this.DTFechaNacimiento);
            this.gbx_estudiante.Controls.Add(this.TxtTelefono);
            this.gbx_estudiante.Controls.Add(this.label3);
            this.gbx_estudiante.Controls.Add(this.TxtDireccion);
            this.gbx_estudiante.Controls.Add(this.label6);
            this.gbx_estudiante.Controls.Add(this.Label1);
            this.gbx_estudiante.Controls.Add(this.TxtCedula);
            this.gbx_estudiante.Controls.Add(this.Label2);
            this.gbx_estudiante.Controls.Add(this.TxtApellido);
            this.gbx_estudiante.Controls.Add(this.Label5);
            this.gbx_estudiante.Controls.Add(this.TxtNombre);
            this.gbx_estudiante.Location = new System.Drawing.Point(12, 12);
            this.gbx_estudiante.Name = "gbx_estudiante";
            this.gbx_estudiante.Size = new System.Drawing.Size(616, 153);
            this.gbx_estudiante.TabIndex = 1086;
            this.gbx_estudiante.TabStop = false;
            this.gbx_estudiante.Text = "Información del Estudiante";
            this.gbx_estudiante.Enter += new System.EventHandler(this.gbx_estudiante_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 1096;
            this.label7.Text = "Fecha Nacimiento:";
            // 
            // DTFechaNacimiento
            // 
            this.DTFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaNacimiento.Location = new System.Drawing.Point(450, 123);
            this.DTFechaNacimiento.Name = "DTFechaNacimiento";
            this.DTFechaNacimiento.Size = new System.Drawing.Size(160, 20);
            this.DTFechaNacimiento.TabIndex = 1095;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtTelefono.Location = new System.Drawing.Point(109, 123);
            this.TxtTelefono.MaxLength = 50;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(197, 20);
            this.TxtTelefono.TabIndex = 1092;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1093;
            this.label3.Text = "Teléfono:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtDireccion.Location = new System.Drawing.Point(109, 97);
            this.TxtDireccion.MaxLength = 150;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(501, 20);
            this.TxtDireccion.TabIndex = 1091;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1094;
            this.label6.Text = "Dirección:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 13);
            this.Label1.TabIndex = 1090;
            this.Label1.Text = "Nº Cedula:";
            // 
            // TxtCedula
            // 
            this.TxtCedula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtCedula.Location = new System.Drawing.Point(109, 19);
            this.TxtCedula.MaxLength = 10;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(197, 20);
            this.TxtCedula.TabIndex = 1083;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 13);
            this.Label2.TabIndex = 1087;
            this.Label2.Text = "Nombre:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtApellido.Location = new System.Drawing.Point(109, 71);
            this.TxtApellido.MaxLength = 100;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(501, 20);
            this.TxtApellido.TabIndex = 1085;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 74);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(47, 13);
            this.Label5.TabIndex = 1089;
            this.Label5.Text = "Apellido:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtNombre.Location = new System.Drawing.Point(109, 45);
            this.TxtNombre.MaxLength = 100;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(501, 20);
            this.TxtNombre.TabIndex = 1084;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(12, 171);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 1087;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(93, 171);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 1088;
            this.BtnGuardar.Text = "Guadar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DgvEstudiante
            // 
            this.DgvEstudiante.AllowUserToAddRows = false;
            this.DgvEstudiante.AllowUserToDeleteRows = false;
            this.DgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstudiante.Location = new System.Drawing.Point(12, 200);
            this.DgvEstudiante.Name = "DgvEstudiante";
            this.DgvEstudiante.ReadOnly = true;
            this.DgvEstudiante.Size = new System.Drawing.Size(616, 182);
            this.DgvEstudiante.TabIndex = 1091;
            this.DgvEstudiante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEstudiante_CellContentClick);
            // 
            // FrmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 392);
            this.Controls.Add(this.DgvEstudiante);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.gbx_estudiante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de estudiantes";
            this.Load += new System.EventHandler(this.FrmEstudiantes_Load);
            this.gbx_estudiante.ResumeLayout(false);
            this.gbx_estudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_estudiante;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTFechaNacimiento;
        internal System.Windows.Forms.TextBox TxtTelefono;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox TxtDireccion;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtCedula;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtApellido;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DgvEstudiante;
    }
}