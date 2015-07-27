using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoMatriculas.Clases
{
    class Matricula
    {
        #region :: Atributos y métodos Get/Set

        private int m_Numero_Matricula;
        private string m_Cedula_Alumno;
        private int m_Id_Curso;
        private int m_Id_Periodo;
        private string m_Fecha_Matricula;

        public int Numero_Matricula
        {
            get { return (m_Numero_Matricula); }
            set { m_Numero_Matricula = value; }
        }
        public string Cedula_Alumno
        {
            get { return (m_Cedula_Alumno); }
            set { m_Cedula_Alumno = value; }
        }
        public int Id_Curso
        {
            get { return (m_Id_Curso); }
            set { m_Id_Curso = value; }
        }
        public int Id_Periodo
        {
            get { return (m_Id_Periodo); }
            set { m_Id_Periodo = value; }
        }
        public string Fecha_Matricula
        {
            get { return (m_Fecha_Matricula); }
            set { m_Fecha_Matricula = value; }
        }

        #endregion

        #region :-: Métodos Utilizados :-:

        #region :-: Ingreso y edición de datos :-:

        /// <summary>
        /// Ingresa los datos de una nueva matricula en la tabla
        /// </summary>
        /// <param name="NuevaMatricula">Objeto del tipo Matricula que contiene los datos de la nueva Matricula a ingresar</param>
        /// <returns></returns>
        public bool IngresarNuevaMatricula(Clases.Matricula NuevaMatricula)
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
                ComandoSQL.CommandText = "SP_Matricula_Grabar";
                ComandoSQL.Parameters.AddWithValue("@Numero_Matricula", NuevaMatricula.Numero_Matricula);
                ComandoSQL.Parameters.AddWithValue("@Cedula_Alumno", NuevaMatricula.Cedula_Alumno);
                ComandoSQL.Parameters.AddWithValue("@Id_Curso", NuevaMatricula.Id_Curso);
                ComandoSQL.Parameters.AddWithValue("@Id_Periodo", NuevaMatricula.Id_Periodo);
                ComandoSQL.Parameters.AddWithValue("@Fecha_Matricula", NuevaMatricula.Fecha_Matricula);
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
        /// Devuelve una matricula según el número de matricula
        /// </summary>
        /// <param name="MatriculaConsulta">Objeto de tipo Matricula que contiene el número de matricula a consultar</param>
        /// <returns></returns>
        public DataTable GetMatriculaPorNumeroMatricula(Clases.Matricula MatriculaConsulta)
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
                ComandoParaConsulta.CommandText = "SP_Matricula_Cargar_Por_Numero_Matricula";
                ComandoParaConsulta.Parameters.AddWithValue("@Numero_Matricula", MatriculaConsulta.Numero_Matricula);
                DtGuia = ClaseConexion.CargarDatatableConProcedimiento(ComandoParaConsulta);
            }
            return DtGuia;
        }

        /// <summary>
        /// Devuelve una matricula según el estudiante, curso y periodo
        /// </summary>
        /// <param name="MatriculaConsulta">Objeto de tipo Matricula que contiene los datos de matricula a consultar</param>
        /// <returns></returns>
        public DataTable GetMatriculaPorEstudianteCursoPeriodo(Clases.Matricula MatriculaConsulta)
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
                ComandoParaConsulta.CommandText = "SP_Matricula_Cargar_Por_Estudiante_Curso_Periodo";
                ComandoParaConsulta.Parameters.AddWithValue("@Cedula_Alumno", MatriculaConsulta.Cedula_Alumno);
                ComandoParaConsulta.Parameters.AddWithValue("@Id_Curso", MatriculaConsulta.Id_Curso);
                ComandoParaConsulta.Parameters.AddWithValue("@Id_Periodo", MatriculaConsulta.Id_Periodo);
                DtGuia = ClaseConexion.CargarDatatableConProcedimiento(ComandoParaConsulta);
            }
            return DtGuia;
        }

        /// <summary>
        /// Devuelve todas las matriculas
        /// </summary>
        /// <returns></returns>
        public DataTable GetTodasLasMatriculas()
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
                ComandoParaConsulta.CommandText = "SP_Matricula_Cargar_Todo";
                DtGuia = ClaseConexion.CargarDatatableConProcedimiento(ComandoParaConsulta);
            }
            return DtGuia;
        }

        #endregion

        #endregion
    }
}
