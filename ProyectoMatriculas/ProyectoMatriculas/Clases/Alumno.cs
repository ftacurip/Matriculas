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

        #region :: Validación Cédula ::

        /// <summary>
        /// Valida un número de cédula ingresado
        /// </summary>
        public Boolean ValidarCedula(string NumeroCedula)
        {
            int[] VectorCedula = new int[10]; int SumaPares = 0; int SumaImpares = 0;
            int SumaTotal = 0; int DigitoValidador = 0; int DecenaSuperior = 0; int Resultado = 0;
            if (NumeroCedula.Length != 10)
            {
                return false;
            }
            else
            {
                if (Convert.ToInt16(NumeroCedula.Substring(0, 2)) < 1 | Convert.ToInt16(NumeroCedula.Substring(0, 2)) > 24)
                {
                    return false;
                }
                else
                {
                    for (int cont = 0; cont < NumeroCedula.Length; cont++)//Obtengo los dígitos del número de cédula
                    {
                        VectorCedula[cont] = Convert.ToInt16(NumeroCedula.Substring(cont, 1));
                    }
                    DigitoValidador = VectorCedula[NumeroCedula.Length - 1];
                    for (int cont = 0; cont < NumeroCedula.Length; cont += 2)//Sumo los duplos de las posiciones impares del número de cédula
                    {
                        VectorCedula[cont] = VectorCedula[cont] * 2;
                        if (VectorCedula[cont] > 9)
                        {
                            VectorCedula[cont] = VectorCedula[cont] - 9;//Si el duplo del dígito supera 9 se resta 9
                        }
                        SumaImpares = SumaImpares + VectorCedula[cont];
                    }
                    for (int cont = 1; cont < NumeroCedula.Length - 1; cont += 2)//Sumo las posiciones pares
                    {
                        SumaPares = SumaPares + VectorCedula[cont];
                    }
                    SumaTotal = SumaImpares + SumaPares;//Sumo los resultados pares e impares
                    if (SumaTotal <= 10)
                    {
                        DecenaSuperior = 10;
                    }
                    else
                    {
                        DecenaSuperior = (Convert.ToInt16(SumaTotal.ToString().Substring(0, 1)) + 1) * 10;//Obtengo la decena superior
                    }
                    Resultado = DecenaSuperior - SumaTotal;//Resto de la decena superior
                    if (Resultado == 10)//Si el resultado se la resta es 10 el dígito final es 0
                    {
                        Resultado = 0;
                    }

                    if (Resultado == DigitoValidador)
                        return true;//Cedula valida
                    else
                        return false;//Cedula no valida
                }
            }
        }

        #endregion

        #endregion
    }
}
