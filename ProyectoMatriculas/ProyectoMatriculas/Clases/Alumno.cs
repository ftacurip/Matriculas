using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoMatriculas.Clases
{
    class Alumno
    {
        #region :: Atributos y métodos Get/Set

        private string m_Cedula;
		private string m_Nombre;
		private string m_Apellido;
		private string m_Direccion;
		private string m_Telefono;
        private string m_Fecha_Nacimiento;

        public string Cedula
        {
            get { return (m_Cedula); }
            set { m_Cedula = value; }
        }
        public string Nombre
        {
            get { return (m_Nombre); }
            set { m_Nombre = value; }
        }
        public string Apellido
        {
            get { return (m_Apellido); }
            set { m_Apellido = value; }
        }
        public string Direccion
        {
            get { return (m_Direccion); }
            set { m_Direccion = value; }
        }
        public string Telefono
        {
            get { return (m_Telefono); }
            set { m_Telefono = value; }
        }
        public string Fecha_Nacimiento
        {
            get { return (m_Fecha_Nacimiento); }
            set { m_Fecha_Nacimiento = value; }
        }

        #endregion

        #region :-: Métodos Utilizados :-:

        #region :-: Ingreso y edición de datos :-:

        /// <summary>
        /// Ingresa los datos de un nuevo usuario en la tabla
        /// </summary>
        ///<param name="NuevaDependencia"> Objeto de tipo Dependencia que contiene la información a guardar en la tabla </param>
        /// <returns></returns>
        public bool IngresarNuevoAlumno(Clases.Alumno NuevoAlumno)
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
                ComandoSQL.CommandText = "SP_SC_DEPENDENCIAS_GRABAR";
                ComandoSQL.Parameters.AddWithValue("@ID_SUCURSAL", NuevaDependencia.ID_SUCURSAL);
                ComandoSQL.Parameters.AddWithValue("@ID_DEPENDENCIA", NuevaDependencia.ID_DEPENDENCIA);
                ComandoSQL.Parameters.AddWithValue("@NOMBRE_DEPENDENCIA", NuevaDependencia.NOMBRE_DEPENDENCIA);
                ComandoSQL.Parameters.AddWithValue("@ID_ESTADO", NuevaDependencia.ID_ESTADO);
                ComandoSQL.Parameters.AddWithValue("@LOGIN_CREACION", NuevaDependencia.LOGIN_CREACION);
                ComandoSQL.Parameters.AddWithValue("@FECHA_CREACION", NuevaDependencia.FECHA_CREACION);
                if (NuevaDependencia.LOGIN_MODIFICACION.Equals("null")) { ComandoSQL.Parameters.AddWithValue("@LOGIN_MODIFICACION", DBNull.Value); }
                else { ComandoSQL.Parameters.AddWithValue("@LOGIN_MODIFICACION", NuevaDependencia.LOGIN_MODIFICACION); }
                if (NuevaDependencia.FECHA_MODIFICACION.Equals("null")) { ComandoSQL.Parameters.AddWithValue("@FECHA_MODIFICACION", DBNull.Value); }
                else { ComandoSQL.Parameters.AddWithValue("@FECHA_MODIFICACION", NuevaDependencia.FECHA_MODIFICACION); }
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
        /// Devuelve las dependencias que tiene una sucursal
        /// </summary>
        /// <returns></returns>
        public DataTable GetDependenciasPorSucursal(Clases.Dependencia DependenciaConsulta)
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
                ComandoParaConsulta.CommandText = "SP_SC_DEPENDENCIAS_CARGAR_POR_ID_SUCURSAL";
                ComandoParaConsulta.Parameters.AddWithValue("@ID_SUCURSAL", DependenciaConsulta.ID_SUCURSAL);
                DtGuia = ClaseConexion.CargarDatatableConProcedimiento(ComandoParaConsulta);
            }
            return DtGuia;
        }

        /// <summary>
        /// Devuelve una dependencia por su Id
        /// </summary>
        /// <returns></returns>
        public DataTable GetDependenciaPorId(Clases.Dependencia DependenciaConsulta)
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
                ComandoParaConsulta.CommandText = "SP_SC_DEPENDENCIAS_CARGAR_POR_ID_DEPENDENCIA";
                ComandoParaConsulta.Parameters.AddWithValue("@ID_DEPENDENCIA", DependenciaConsulta.ID_DEPENDENCIA);
                DtGuia = ClaseConexion.CargarDatatableConProcedimiento(ComandoParaConsulta);
            }
            return DtGuia;
        }

        /// <summary>
        /// Devuelve todas las Dependencias
        /// </summary>
        /// <returns></returns>
        public DataTable GetTodasLasDependencias()
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
                ComandoParaConsulta.CommandText = "SP_SC_DEPENDENCIAS_CARGAR_TODAS_LAS_DEPENDENCIAS";
                DtGuia = ClaseConexion.CargarDatatableConProcedimiento(ComandoParaConsulta);
            }
            return DtGuia;
        }

        #endregion

        #endregion
    }
}
