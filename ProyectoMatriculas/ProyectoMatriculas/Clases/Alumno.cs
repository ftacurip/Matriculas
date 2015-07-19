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
                ComandoSQL.CommandText = "SP_Alumno_Grabar";
                ComandoSQL.Parameters.AddWithValue("@Cedula", NuevoAlumno.Cedula);
                ComandoSQL.Parameters.AddWithValue("@Nombre", NuevoAlumno.Nombre);
                ComandoSQL.Parameters.AddWithValue("@Apellido", NuevoAlumno.Apellido);
                ComandoSQL.Parameters.AddWithValue("@Direccion", NuevoAlumno.Direccion);
                ComandoSQL.Parameters.AddWithValue("@Telefono", NuevoAlumno.Telefono);
                ComandoSQL.Parameters.AddWithValue("@Fecha_Nacimiento", NuevoAlumno.Fecha_Nacimiento);
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
        public DataTable GetAlumnoPorCedula(Clases.Alumno AlumnoConsulta)
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
                ComandoParaConsulta.CommandText = "SP_Alumno_Cargar_Por_Cedula";
                ComandoParaConsulta.Parameters.AddWithValue("@Cedula", AlumnoConsulta.Cedula);
                DtGuia = ClaseConexion.CargarDatatableConProcedimiento(ComandoParaConsulta);
            }
            return DtGuia;
        }

        /// <summary>
        /// Devuelve todas las Dependencias
        /// </summary>
        /// <returns></returns>
        public DataTable GetTodosLosAlumnos()
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
                ComandoParaConsulta.CommandText = "SP_Alumno_Cargar_Todos";
                DtGuia = ClaseConexion.CargarDatatableConProcedimiento(ComandoParaConsulta);
            }
            return DtGuia;
        }

        #endregion

        #endregion
    }
}
