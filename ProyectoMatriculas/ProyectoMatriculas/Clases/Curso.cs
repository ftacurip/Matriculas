using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace ProyectoMatriculas.Clases
{
    class Curso
    {
        #region :: Atributos y métodos Get/Set
        private int m_Id_Curso;
		private string m_Nombre_Curso;

        public int Id_Curso
        {
            get { return (m_Id_Curso); }
            set { m_Id_Curso = value; }
        }
        public string Nombre_Curso
        {
            get { return (m_Nombre_Curso); }
            set { m_Nombre_Curso = value; }
        }
         #endregion

        #region :-: Métodos Utilizados :-:

        #region :-: Ingreso y edición de datos :-:

        /// <summary>
        /// Ingresa los datos de un nuevo curso en la tabla
        /// </summary>
        ///<param name="NuevoCurso"> Objeto de tipo Curso que contiene la información a guardar en la tabla </param>
        /// <returns></returns>
        public bool IngresarNuevoCurso(Clases.Curso NuevoCurso)
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
                ComandoSQL.CommandText = "SP_Curso_Grabar";
                ComandoSQL.Parameters.AddWithValue("@Id_Curso", NuevoCurso.Id_Curso);
                ComandoSQL.Parameters.AddWithValue("@Nombre_Curso", NuevoCurso.Nombre_Curso);                
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
        /// Devuelve un curso según su Id
        /// </summary>
        /// <param name="CursoConsulta">Objeto de tipo Curso que contiene el Id del curso a consultar</param>
        /// <returns></returns>
        public DataTable GetCursoPorId(Clases.Curso CursoConsulta)
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
                ComandoParaConsulta.CommandText = "SP_Curso_Cargar_Por_Id_Curso";
                ComandoParaConsulta.Parameters.AddWithValue("@Id_Curso", CursoConsulta.Id_Curso);
                DtGuia = ClaseConexion.CargarDatatableConProcedimiento(ComandoParaConsulta);
            }
            return DtGuia;
        }

        /// <summary>
        /// Devuelve todos los cursos
        /// </summary>
        /// <returns></returns>
        public DataTable GetTodosLosCursos()
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
                ComandoParaConsulta.CommandText = "SP_Curso_Cargar_Todos";
                DtGuia = ClaseConexion.CargarDatatableConProcedimiento(ComandoParaConsulta);
            }
            return DtGuia;
        }

        #endregion        

        #endregion
    }
}
