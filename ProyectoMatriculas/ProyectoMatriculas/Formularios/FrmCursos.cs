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
    public partial class FrmCursos : Form
    {
        #region :: Métodos Creados ::

        bool ValidarControles()
        {
            if (TxtCurso.Text.Length == 0) { MessageBox.Show("No se ha ingresado el Nombre del Curso"); return false; }
            return true;
        }

        void LimpiarControles()
        {
            TxtIdCurso.Text = ""; TxtCurso.Text = "";
        }

        void CargarCursos()
        {
            #region :: Clases Utilizadas ::

            Clases.Curso CursoConsulta = new Clases.Curso();

            #endregion

            #region :: Variables Utilizadas ::

            DataTable DtCursos = new DataTable();

            #endregion

            DtCursos = CursoConsulta.GetTodosLosCursos();

            if (DtCursos.Rows.Count > 0) { DgvCursos.DataSource = DtCursos; }
        }

        Int32 GetNuevoIdCurso()
        {
            #region :: Clases Utilizadas ::

            Clases.Curso CursoConsulta = new Clases.Curso();

            #endregion

            #region :: Variables Utilizadas ::

            DataTable DtCursos = new DataTable();

            #endregion

            DtCursos = CursoConsulta.GetTodosLosCursos();

            return DtCursos.Rows.Count + 1;
        }

        #endregion

        public FrmCursos()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            #region :: Clases Utilizadas ::

            Clases.Curso NuevoCurso = new Clases.Curso();

            #endregion

            #region :: Variables Utilizadas ::

            #endregion

            if (ValidarControles() == true)
            {
                if (TxtIdCurso.Text.Length == 0) { NuevoCurso.Id_Curso = GetNuevoIdCurso(); }
                else { NuevoCurso.Id_Curso = Convert.ToInt32(TxtIdCurso.Text); }
                NuevoCurso.Nombre_Curso = TxtCurso.Text.ToUpper();
                if (NuevoCurso.IngresarNuevoCurso(NuevoCurso) == true) { MessageBox.Show("El curso ha sido registrado exitosamente."); LimpiarControles(); CargarCursos(); }
                else { MessageBox.Show("El curso NO ha podido ser registrado."); }
            }
        }

        private void DgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvCursos.Rows.Count > 0)
            {
                TxtIdCurso.Text = DgvCursos.Rows[e.RowIndex].Cells["Id_Curso"].Value.ToString();
                TxtCurso.Text = DgvCursos.Rows[e.RowIndex].Cells["Nombre_Curso"].Value.ToString();
            }
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {
            CargarCursos();
        }
    }
}
