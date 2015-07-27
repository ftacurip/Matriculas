using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoMatriculas.Clases
{
    class Periodo
    {
        #region :: Atributos y métodos Get/Set

        private int m_Id_Periodo;
        private string m_Nombre_Periodo;

        public int Id_Periodo
        {
            get { return (m_Id_Periodo); }
            set { m_Id_Periodo = value; }
        }

        public string Nombre_Periodo
        {
            get { return (m_Nombre_Periodo); }
            set { m_Nombre_Periodo = value; }
        }

        #endregion

        #region :-: Métodos Utilizados :-:

        #region :-: Ingreso y edición de datos :-:

        /// <summary>
        /// Ingresa los datos de un nuevo periodo en la tabla
        /// </summary>
        /// <param name="NuevoPeriodo">Objeto de tipo de Periodo que contiene los datos del periodo a grabar en la tabla</param>
        /// <returns></returns>
        public bool IngresarNuevoPeriodo(Clases.Periodo NuevoPeriodo)
        {
            #region :: Clases Utilizadas ::

            Conexion ClaseConexion = new Conexion();

            #endregion

            #region :: Variables Utilizadas ::

            bool Resultado;

            #endregion

            ClaseConexion.ConectarABase();
            using (SqlCommand ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = ClaseConexion.Conectar;
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "SP_Periodo_Grabar";
                ComandoSQL.Parameters.AddWithValue("@Id_Periodo", NuevoPeriodo.Id_Periodo);
                ComandoSQL.Parameters.AddWithValue("@Nombre_Periodo", NuevoPeriodo.Nombre_Periodo);
                if (ClaseConexion.EjecutarSQLConProcedimiento(ComandoSQL) > 0)
                    Resultado = true;
                else
                    Resultado = false;
            }
            return Resultado;
        }

        #endregion

        #region :-: Consultas de datos :-:

        /// <summary>
        /// Devuelve un periodo según su Id
        /// </summary>
        /// <param name="PeriodoConsulta">Objeto de tipo Periodo que contiene el Id del periodo a consultar</param>
        /// <returns></returns>
        public DataTable GetPeriodoPorId(Clases.Periodo PeriodoConsulta)
        {
            #region :-: Clases Utilizadas :-:

            Clases.Conexion ClaseConexion = new Clases.Conexion();

            #endregion

            #region :-: Variables Utilizadas :-:

            DataTable DtGuia = new DataTable();

            #endregion

            ClaseConexion.ConectarABase();
            using (SqlCommand ComandoParaConsulta = new SqlCommand())
            {
                ComandoParaConsulta.Connection = ClaseConexion.Conectar;
                ComandoParaConsulta.CommandType = CommandType.StoredProcedure;
                ComandoParaConsulta.CommandText = "SP_Periodo_Cargar_Por_Id_Periodo";
                ComandoParaConsulta.Parameters.AddWithValue("@Id_Periodo", PeriodoConsulta.Id_Periodo);
                DtGuia = ClaseConexion.CargarDatatableConProcedimiento(ComandoParaConsulta);
            }
            return DtGuia;
        }

        /// <summary>
        /// Devuelve todos los periodos
        /// </summary>
        /// <returns></returns>
        public DataTable GetTodosLosPeriodos()
        {
            #region :-: Clases Utilizadas :-:

            Conexion ClaseConexion = new Conexion();

            #endregion

            #region :-: Variables Utilizadas :-:

            DataTable DtGuia = new DataTable();

            #endregion

            ClaseConexion.ConectarABase();
            using (SqlCommand ComandoParaConsulta = new SqlCommand())
            {
                ComandoParaConsulta.Connection = ClaseConexion.Conectar;
                ComandoParaConsulta.CommandType = CommandType.StoredProcedure;
                ComandoParaConsulta.CommandText = "SP_Periodo_Cargar_Todo";
                DtGuia = ClaseConexion.CargarDatatableConProcedimiento(ComandoParaConsulta);
            }
            return DtGuia;
        }

        #endregion

        #endregion
    }
}
