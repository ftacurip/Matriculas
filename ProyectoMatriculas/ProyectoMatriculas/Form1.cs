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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FrmEstudiantes FrmEst = new Formularios.FrmEstudiantes();
            FrmEst.Top = (PanContenedorFormularios.Height / 2) - (FrmEst.Height / 2);
            FrmEst.Left = (PanContenedorFormularios.Width / 2) - (FrmEst.Width / 2);
            FrmEst.TopLevel = false;
            PanContenedorFormularios.Controls.Add(FrmEst); FrmEst.Show();
        }

        private void registrarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FrmCursos FrmCur = new Formularios.FrmCursos();
            FrmCur.Top = (PanContenedorFormularios.Height / 2) - (FrmCur.Height / 2);
            FrmCur.Left = (PanContenedorFormularios.Width / 2) - (FrmCur.Width / 2);
            FrmCur.TopLevel = false;
            PanContenedorFormularios.Controls.Add(FrmCur); FrmCur.Show();
        }

        private void registrarPeriodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FrmPeriodos FrmPer = new Formularios.FrmPeriodos();
            FrmPer.Top = (PanContenedorFormularios.Height / 2) - (FrmPer.Height / 2);
            FrmPer.Left = (PanContenedorFormularios.Width / 2) - (FrmPer.Width / 2);
            FrmPer.TopLevel = false;
            PanContenedorFormularios.Controls.Add(FrmPer); FrmPer.Show();
        }
    }
}
