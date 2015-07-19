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
            this.TxtFecha = new System.Windows.Forms.DateTimePicker();
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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.DgvEstudiante = new System.Windows.Forms.DataGridView();
            this.gbx_estudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_estudiante
            // 
            this.gbx_estudiante.Controls.Add(this.label7);
            this.gbx_estudiante.Controls.Add(this.TxtFecha);
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
            // TxtFecha
            // 
            this.TxtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtFecha.Location = new System.Drawing.Point(435, 91);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(160, 20);
            this.TxtFecha.TabIndex = 1095;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtTelefono.Location = new System.Drawing.Point(398, 60);
            this.TxtTelefono.MaxLength = 15;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(197, 20);
            this.TxtTelefono.TabIndex = 1092;
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
            // TxtDireccion
            // 
            this.TxtDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtDireccion.Location = new System.Drawing.Point(398, 23);
            this.TxtDireccion.MaxLength = 40;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(197, 20);
            this.TxtDireccion.TabIndex = 1091;
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
            // TxtCedula
            // 
            this.TxtCedula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtCedula.Location = new System.Drawing.Point(109, 23);
            this.TxtCedula.MaxLength = 20;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(197, 20);
            this.TxtCedula.TabIndex = 1083;
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
            // TxtApellido
            // 
            this.TxtApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtApellido.Location = new System.Drawing.Point(109, 90);
            this.TxtApellido.MaxLength = 40;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(197, 20);
            this.TxtApellido.TabIndex = 1085;
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
            // TxtNombre
            // 
            this.TxtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtNombre.Location = new System.Drawing.Point(109, 57);
            this.TxtNombre.MaxLength = 40;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(197, 20);
            this.TxtNombre.TabIndex = 1084;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(13, 170);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 1087;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(95, 170);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 1088;
            this.BtnGuardar.Text = "Guadar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(177, 170);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 1089;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(259, 170);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 1090;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // DgvEstudiante
            // 
            this.DgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstudiante.Location = new System.Drawing.Point(13, 200);
            this.DgvEstudiante.Name = "DgvEstudiante";
            this.DgvEstudiante.Size = new System.Drawing.Size(604, 182);
            this.DgvEstudiante.TabIndex = 1091;
            // 
            // FrmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 382);
            this.Controls.Add(this.DgvEstudiante);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.gbx_estudiante);
            this.Name = "FrmEstudiantes";
            this.Text = "FrmEstudiantes";
            this.gbx_estudiante.ResumeLayout(false);
            this.gbx_estudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_estudiante;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker TxtFecha;
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
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.DataGridView DgvEstudiante;
    }
}