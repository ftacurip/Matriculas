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
    public partial class FrmPeriodos : Form
    {
        #region :: Métodos Creados ::

        bool ValidarControles()
        {
            if (TxtPeriodo.Text.Length == 0) { MessageBox.Show("No se ha ingresado el Nombre del Periodo"); return false; }
            return true;
        }

        void LimpiarControles()
        {
            TxtIdPeriodo.Text = ""; TxtPeriodo.Text = "";
        }

        void CargarPeriodos()
        {
            #region :: Clases Utilizadas ::

            Clases.Periodo PeriodoConsulta = new Clases.Periodo();

            #endregion

            #region :: Variables Utilizadas ::

            DataTable DtPeriodos = new DataTable();

            #endregion

            DtPeriodos = PeriodoConsulta.GetTodosLosPeriodos();

            if (DtPeriodos.Rows.Count > 0) { DgvPeriodos.DataSource = DtPeriodos; }
        }

        Int32 GetNuevoIdPeriodo()
        {
            #region :: Clases Utilizadas ::

            Clases.Periodo PeriodoConsulta = new Clases.Periodo();

            #endregion

            #region :: Variables Utilizadas ::

            DataTable DtPeriodos = new DataTable();

            #endregion

            DtPeriodos = PeriodoConsulta.GetTodosLosPeriodos();

            return DtPeriodos.Rows.Count + 1;
        }

        #endregion

        public FrmPeriodos()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            #region :: Clases Utilizadas ::

            Clases.Periodo NuevoPeriodo = new Clases.Periodo();

            #endregion

            #region :: Variables Utilizadas ::

            #endregion

            if (ValidarControles() == true)
            {
                if (TxtIdPeriodo.Text.Length == 0) { NuevoPeriodo.Id_Periodo = GetNuevoIdPeriodo(); }
                else { NuevoPeriodo.Id_Periodo = Convert.ToInt32(TxtIdPeriodo.Text); }
                NuevoPeriodo.Nombre_Periodo = TxtPeriodo.Text.ToUpper();
                if (NuevoPeriodo.IngresarNuevoPeriodo(NuevoPeriodo) == true) { MessageBox.Show("El Periodo ha sido registrado exitosamente."); LimpiarControles(); CargarPeriodos(); }
                else { MessageBox.Show("El Periodo NO ha podido ser registrado."); }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void DgvPeriodos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvPeriodos.Rows.Count > 0)
            {
                TxtIdPeriodo.Text = DgvPeriodos.Rows[e.RowIndex].Cells["Id_Periodo"].Value.ToString();
                TxtPeriodo.Text = DgvPeriodos.Rows[e.RowIndex].Cells["Nombre_Periodo"].Value.ToString();
            }
        }

        private void FrmPeriodos_Load(object sender, EventArgs e)
        {
            CargarPeriodos();
        }
    }
}
