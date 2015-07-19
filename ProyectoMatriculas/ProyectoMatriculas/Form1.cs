using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoMatriculas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region :: Clases Utilizadas ::

            Clases.Conexion ClaseConexion = new Clases.Conexion();

            #endregion

            if (ClaseConexion.ConectarABase() == true) { MessageBox.Show("Conexión exitosa"); }
            else { MessageBox.Show("Conexión fallida"); }
        }
    }
}
