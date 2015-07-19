using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ProyectoMatriculas.Clases
{
    class Conexion
    {
        #region * Atributos y Metodos Get/Set *

        private SqlConnection conectar;
        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private DataSet conjunto;
        private SqlDataReader lector;

        //Para la cadena de conexión

        private string servidor;
        private string basededatos;
        private string usuario;
        private string password;
        private string servidorconexion;

        public string ServidorConexion
        {
            get { return servidorconexion; }
            set { servidorconexion = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string BaseDeDatos
        {
            get { return basededatos; }
            set { basededatos = value; }
        }
        public string Servidor
        {
            get { return servidor; }
            set { servidor = value; }
        }
        public SqlDataReader Lector
        {
            get { return lector; }
            set { lector = value; }
        }
        public DataSet Conjunto
        {
            get { return conjunto; }
            set { conjunto = value; }
        }
        public SqlDataAdapter Adaptador
        {
            get { return adaptador; }
            set { adaptador = value; }
        }
        public SqlCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }
        public SqlConnection Conectar
        {
            get { return conectar; }
            set { conectar = value; }
        }

        #endregion

        #region * Clases usadas *

        //Clases.Seguridad ClaseSeguridad = new Clases.Seguridad();

        #endregion

        /// <summary>
        /// Se conecta a Base de datos especificada en el archivo config
        /// </summary>
        /// <returns></returns>
        public bool ConectarABase()
        {
            bool ResultadoMetodo = true; string CadenaConexion = "";

            Servidor = ConfigurationSettings.AppSettings["SERVIDOR"].ToString();
            BaseDeDatos = ConfigurationSettings.AppSettings["BASE"].ToString();
            Usuario = ConfigurationSettings.AppSettings["USUARIO"].ToString();
            Password = ConfigurationSettings.AppSettings["DBPASSWORD"].ToString();

            CadenaConexion = @"Data Source=" + Servidor + "; Initial Catalog=" + BaseDeDatos + "; User Id=" + Usuario + "; Password=" + Password + "; Connect Timeout=0";

            try
            {
                using (Conectar = new SqlConnection(CadenaConexion))
                {
                    Conectar = new SqlConnection(CadenaConexion);
                    Conectar.Open(); ResultadoMetodo = true;
                }
            }
            catch
            { conectar.Close(); ResultadoMetodo = false; }

            return ResultadoMetodo;
        }

        /// <summary>
        /// Ejecuta una sentencia SQL especificada
        /// </summary>
        public Int32 EjecutarSQL(string Cadena)
        {
            Int32 CantidadRegistroAfectados = 0;
            try
            {
                using (Comando = new SqlCommand(Cadena, Conectar))
                {
                    Comando.CommandTimeout = 0;
                    CantidadRegistroAfectados = Comando.ExecuteNonQuery();
                }
                DesconectarDeBase();
                return CantidadRegistroAfectados;
            }
            catch (Exception Ex)
            {
                DesconectarDeBase();
                return CantidadRegistroAfectados;
            }
        }

        /// <summary>
        /// Ejecuta una sentencia SQL especificada dentro de un procedimiento en la base de datos
        /// </summary>
        public Int32 EjecutarSQLConProcedimiento(SqlCommand ComandoSQL)
        {
            Int32 CantidadRegistroAfectados = 0;

            //try
            //{
                ComandoSQL.CommandTimeout = 0;
                CantidadRegistroAfectados = ComandoSQL.ExecuteNonQuery();
                DesconectarDeBase();
                return CantidadRegistroAfectados;
            //}
            //catch (Exception Ex)
            //{
                //DesconectarDeBase();
                //return CantidadRegistroAfectados;
            //}
        }

        /// <summary>
        /// Carga los datos especificados en un Datatable y los devuelve
        /// </summary>
        public DataTable Cargar_Datatable(string Cadena, string Tabla)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Comando = new SqlCommand(Cadena, Conectar))
                {
                    Comando.CommandTimeout = 0;
                    Lector = Comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    dt.Load(Lector);
                    Lector.Close(); Lector.Dispose();
                    DesconectarDeBase();
                }
                return dt;
            }
            catch (Exception Ex)
            {
                DesconectarDeBase();
                return dt;
            }
        }

        /// <summary>
        /// Carga los datos especificados en un Datatable y los devuelve mediante un procedimiento almacenado
        /// </summary>
        public DataTable CargarDatatableConProcedimiento(SqlCommand ComandoConsulta)
        {
            DataTable dt = new DataTable();
            try
            {
                ComandoConsulta.CommandTimeout = 0;
                Lector = ComandoConsulta.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                dt.Load(Lector);
                Lector.Close(); Lector.Dispose();
                DesconectarDeBase();
                return dt;
            }
            catch (Exception Ex)
            {
                DesconectarDeBase();
                return dt;
            }
        }

        /// <summary>
        /// Cierra la conexión con la BD
        /// </summary>
        public void DesconectarDeBase()
        {
            Conectar.Close(); Conectar.Dispose();
        }

        /// <summary>
        /// Devuelve el nombre del servidor
        /// </summary>
        public string GetNombreServidor()
        {
            try
            {
                //ConectarABase();
                return Conectar.DataSource;
            }
            catch (Exception Ex)
            {
                return "";
            }
        }

        /// <summary>
        /// Devuelve la IP de cliente
        /// </summary>
        public string GetHostIP()
        {
            var hostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            var HostIP = (
                       from addr in hostEntry.AddressList
                       where addr.AddressFamily.ToString() == "InterNetwork"
                       select addr.ToString()
                ).FirstOrDefault();

            return HostIP.ToString();
        }
    }
}
