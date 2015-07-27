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
    public partial class FrmMatriculacion : Form
    {
        #region :: Métodos Creados ::

        void CargarCursos()
        {
            #region ::: Clases Utilizadas :::

            Clases.Curso ClaseCurso = new Clases.Curso();

            #endregion

            #region ::: Variables Utilizadas :::

            DataTable DtCurso = new DataTable();

            #endregion

            CbCurso.Items.Clear();
            DtCurso = ClaseCurso.GetTodosLosCursos();
            if (DtCurso.Rows.Count > 0)
            {
                CbCurso.DataSource = DtCurso;
                CbCurso.ValueMember = "Id_Curso";
                CbCurso.DisplayMember = "Nombre_Curso";
                //CbCurso.Items.Insert(0, "--SELECCIONE UN CURSO--");
            }
            //else
            //{ CbCurso.Items.Insert(0, "--NO SE ENCONTRARON ITEMS--"); }
        }

        void CargarPeriodos()
        {
            #region ::: Clases Utilizadas :::

            Clases.Periodo ClasePeriodo = new Clases.Periodo();

            #endregion

            #region ::: Variables Utilizadas :::

            DataTable DtPeriodo = new DataTable();

            #endregion

            CbPeriodo.Items.Clear();
            DtPeriodo = ClasePeriodo.GetTodosLosPeriodos();
            if (DtPeriodo.Rows.Count > 0)
            {
                CbPeriodo.DataSource = DtPeriodo;
                CbPeriodo.ValueMember = "Id_Periodo";
                CbPeriodo.DisplayMember = "Nombre_Periodo";
                //CbPeriodo.Items.Insert(0, "--SELECCIONE UN PERIODO--");
            }
            //else
            //{ CbPeriodo.Items.Insert(0, "--NO SE ENCONTRARON ITEMS--"); }
        }

        void LimpiarControles()
        {
            TxtNumeroMatricula.Text = ""; TxtCedula.Text = "";
            TxtNombre.Text = ""; TxtApellido.Text = "";
            TxtDireccion.Text = ""; TxtTelefono.Text = "";
        }

        bool ValidarControles()
        {
            if (TxtNombre.Text.Length == 0) { MessageBox.Show("No se ha seleccionado Alumno a Matricular"); return false; }
            return true;
        }

        Int32 GetNuevoNumeroMatricula()
        {
            #region :: Clases Utilizadas ::

            Clases.Matricula MatriculaConsulta = new Clases.Matricula();

            #endregion

            #region :: Variables Utilizadas ::

            DataTable DtMatricula = new DataTable();

            #endregion

            DtMatricula = MatriculaConsulta.GetTodasLasMatriculas();

            return DtMatricula.Rows.Count + 1;
        }

        bool VerificarSiAlumnoEstaMatriculadoEnCursoYPeriodoSeleccionado(Clases.Matricula MatriculaExistente)
        {
            #region :: Variables Utilizadas ::

            DataTable DtMatriculaExistente = new DataTable();
            bool Resultado;

            #endregion

            DtMatriculaExistente = MatriculaExistente.GetMatriculaPorEstudianteCursoPeriodo(MatriculaExistente);

            if (DtMatriculaExistente.Rows.Count > 0) { Resultado = true; }
            else { Resultado = false; }

            return Resultado;
        }

        void CargarMatriculas()
        {
            #region :: Clases Utilizadas ::

            Clases.Matricula MatriculaConsulta = new Clases.Matricula();

            #endregion

            #region :: Variables Utilizadas ::

            DataTable DtMatricula = new DataTable();

            #endregion

            DtMatricula = MatriculaConsulta.GetTodasLasMatriculas();

            if (DtMatricula.Rows.Count > 0) { DgvMatricula.DataSource = DtMatricula; }
        }

        #endregion

        public FrmMatriculacion()
        {
            InitializeComponent();
        }

        private void FrmMatriculacion_Load(object sender, EventArgs e)
        {
            CargarCursos(); CargarPeriodos();
            LblFecha.Text = System.DateTime.Today.ToString();
            CargarMatriculas();
        }

        private void BtnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            #region :: Clases Utilizadas ::

            Clases.Alumno ClaseAlumno = new Clases.Alumno();

            #endregion

            #region :: Variables Utilizadas ::

            DataTable DtAlumno = new DataTable();

            #endregion

            if (TxtCedula.Text.Length == 0) { MessageBox.Show("No se ha ingresado la Cédula del Alumno"); }
            else
            {
                ClaseAlumno.Cedula = TxtCedula.Text;
                DtAlumno = ClaseAlumno.GetAlumnoPorCedula(ClaseAlumno);
                if(DtAlumno.Rows.Count > 0)
                {
                    TxtNombre.Text = DtAlumno.Rows[0]["Nombre"].ToString();
                    TxtApellido.Text = DtAlumno.Rows[0]["Apellido"].ToString();
                    TxtDireccion.Text = DtAlumno.Rows[0]["Direccion"].ToString();
                    TxtTelefono.Text = DtAlumno.Rows[0]["Telefono"].ToString();
                    TxtCedula.ReadOnly = true;
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            TxtCedula.ReadOnly = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            #region :: Clases Utilizadas ::

            Clases.Matricula NuevaMatricula = new Clases.Matricula();

            #endregion

            #region :: Variables Utilizadas ::

            DataTable DtMatriculaExistente = new DataTable();

            #endregion

            if (ValidarControles() == true)
            {
                NuevaMatricula.Cedula_Alumno = TxtCedula.Text;
                NuevaMatricula.Id_Curso = Convert.ToInt32(CbCurso.SelectedValue.ToString());
                NuevaMatricula.Id_Periodo = Convert.ToInt32(CbPeriodo.SelectedValue.ToString());

                if (VerificarSiAlumnoEstaMatriculadoEnCursoYPeriodoSeleccionado(NuevaMatricula) == true)
                { MessageBox.Show("El Alumno ya se encuentra Matriculado en el Curso y Periodo seleccionados"); }
                else
                {
                    NuevaMatricula.Numero_Matricula = GetNuevoNumeroMatricula();
                    NuevaMatricula.Fecha_Matricula = System.DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss");
                    if (NuevaMatricula.IngresarNuevaMatricula(NuevaMatricula) == true) { MessageBox.Show("La Matricula ha sido registrada exitosamente. Para registrar una nueva Matricula pulse Nuevo."); CargarMatriculas(); }
                    else { MessageBox.Show("La Matricula NO ha podido ser registrada"); }
                }
            }
        }

        private void CbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(CbCurso.SelectedValue.ToString());
        }
    }
}
