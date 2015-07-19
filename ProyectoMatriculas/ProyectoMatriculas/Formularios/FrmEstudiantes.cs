using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoMatriculas.Formularios
{
    public partial class FrmEstudiantes : Form
    {
        #region :: Métodos Creados ::

        bool ValidarControles()
        {
            #region :: Clases Utilizadas ::

            Clases.Alumno ValidacionCedula = new Clases.Alumno();

            #endregion 

            if (TxtCedula.Text.Length == 0) { MessageBox.Show("No se ha ingresado la Cédula del Estudiante"); return false; }
            if (ValidacionCedula.ValidarCedula(TxtCedula.Text) == false) { MessageBox.Show("El Número de Cédula ingresado no es válido."); return false; }
            if (TxtNombre.Text.Length == 0) { MessageBox.Show("No se ha ingresado el Nombre del Estudiante"); return false; }
            if (TxtApellido.Text.Length == 0) { MessageBox.Show("No se ha ingresado el Apellido del Estudiante"); return false; }
            if (TxtDireccion.Text.Length == 0) { MessageBox.Show("No se ha ingresado la Dirección del Estudiante"); return false; }
            if (TxtTelefono.Text.Length == 0) { MessageBox.Show("No se ha ingresado el Teléfono del Estudiante"); return false; }
            if (DTFechaNacimiento.Value == System.DateTime.Today || DTFechaNacimiento.Value > System.DateTime.Today) { MessageBox.Show("La Fecha de Nacimiento del alumno no puede ser igual o mayor a la fecha actual"); return false; }
            return true;
        }

        void LimpiarControles()
        {
            TxtCedula.Text = "";
            TxtNombre.Text = ""; TxtApellido.Text = "";
            TxtDireccion.Text = ""; TxtTelefono.Text = "";
            DTFechaNacimiento.Value = System.DateTime.Today;
        }

        void CargarAlumnos()
        {
            #region :: Variables Utilizadas ::

            Clases.Alumno AlumnosConsulta = new Clases.Alumno();

            #endregion

            #region :: Variables Utilizadas ::

            DataTable DtAlumnos = new DataTable();

            #endregion

            DtAlumnos = AlumnosConsulta.GetTodosLosAlumnos();

            if (DtAlumnos.Rows.Count > 0)
            {
                DgvEstudiante.DataSource = DtAlumnos;
            }
        }

        #endregion

        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        private void gbx_estudiante_Enter(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            #region :: Clases Utilizadas ::

            Clases.Alumno NuevoAlumno = new Clases.Alumno();

            #endregion

            #region :: Variables Utilizadas ::



            #endregion

            if (ValidarControles() == true)
            {
                //Pendiente validación de cédula
                NuevoAlumno.Cedula = TxtCedula.Text;
                NuevoAlumno.Nombre = TxtNombre.Text.ToUpper();
                NuevoAlumno.Apellido = TxtApellido.Text.ToUpper();
                NuevoAlumno.Direccion = TxtDireccion.Text.ToUpper();
                NuevoAlumno.Telefono = TxtTelefono.Text;
                NuevoAlumno.Fecha_Nacimiento = DTFechaNacimiento.Value.ToString("yyyy-MM-dd HH:mm:ss");
                if (NuevoAlumno.IngresarNuevoAlumno(NuevoAlumno) == true) { MessageBox.Show("El estudiante ha sido registrado exitosamente."); LimpiarControles(); CargarAlumnos(); }
                else { MessageBox.Show("El estudiante NO ha podido ser registrado."); }
            }
            else { }

        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void DgvEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DgvEstudiante.Rows.Count> 0)
            {
                TxtCedula.Text = DgvEstudiante.Rows[e.RowIndex].Cells["Cedula"].Value.ToString(); TxtCedula.ReadOnly = true;
                TxtNombre.Text = DgvEstudiante.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                TxtApellido.Text = DgvEstudiante.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                TxtDireccion.Text= DgvEstudiante.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                TxtTelefono.Text = DgvEstudiante.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                DTFechaNacimiento.Value = Convert.ToDateTime(DgvEstudiante.Rows[e.RowIndex].Cells["Fecha_Nacimiento"].Value.ToString());
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCedula.ReadOnly = false;
            LimpiarControles();
        }
    }
}
