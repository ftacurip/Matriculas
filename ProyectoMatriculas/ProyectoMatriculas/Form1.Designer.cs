﻿namespace ProyectoMatriculas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPeriodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matriculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanContenedorFormularios = new System.Windows.Forms.Panel();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.periodosToolStripMenuItem,
            this.matriculasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(943, 24);
            this.MenuPrincipal.TabIndex = 1;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAlumnosToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // registrarAlumnosToolStripMenuItem
            // 
            this.registrarAlumnosToolStripMenuItem.Name = "registrarAlumnosToolStripMenuItem";
            this.registrarAlumnosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.registrarAlumnosToolStripMenuItem.Text = "Registrar alumnos";
            this.registrarAlumnosToolStripMenuItem.Click += new System.EventHandler(this.registrarAlumnosToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCursosToolStripMenuItem});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // registrarCursosToolStripMenuItem
            // 
            this.registrarCursosToolStripMenuItem.Name = "registrarCursosToolStripMenuItem";
            this.registrarCursosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.registrarCursosToolStripMenuItem.Text = "Registrar Cursos";
            this.registrarCursosToolStripMenuItem.Click += new System.EventHandler(this.registrarCursosToolStripMenuItem_Click);
            // 
            // periodosToolStripMenuItem
            // 
            this.periodosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPeriodosToolStripMenuItem});
            this.periodosToolStripMenuItem.Name = "periodosToolStripMenuItem";
            this.periodosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.periodosToolStripMenuItem.Text = "Periodos";
            // 
            // registrarPeriodosToolStripMenuItem
            // 
            this.registrarPeriodosToolStripMenuItem.Name = "registrarPeriodosToolStripMenuItem";
            this.registrarPeriodosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.registrarPeriodosToolStripMenuItem.Text = "Registrar Periodos";
            this.registrarPeriodosToolStripMenuItem.Click += new System.EventHandler(this.registrarPeriodosToolStripMenuItem_Click);
            // 
            // matriculasToolStripMenuItem
            // 
            this.matriculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeMatriculaToolStripMenuItem});
            this.matriculasToolStripMenuItem.Name = "matriculasToolStripMenuItem";
            this.matriculasToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.matriculasToolStripMenuItem.Text = "Matriculas";
            // 
            // registroDeMatriculaToolStripMenuItem
            // 
            this.registroDeMatriculaToolStripMenuItem.Name = "registroDeMatriculaToolStripMenuItem";
            this.registroDeMatriculaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.registroDeMatriculaToolStripMenuItem.Text = "Registro de Matricula";
            this.registroDeMatriculaToolStripMenuItem.Click += new System.EventHandler(this.registroDeMatriculaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // PanContenedorFormularios
            // 
            this.PanContenedorFormularios.BackgroundImage = global::ProyectoMatriculas.Properties.Resources.o_COLLEGE_facebook;
            this.PanContenedorFormularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanContenedorFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanContenedorFormularios.Location = new System.Drawing.Point(0, 24);
            this.PanContenedorFormularios.Name = "PanContenedorFormularios";
            this.PanContenedorFormularios.Size = new System.Drawing.Size(943, 598);
            this.PanContenedorFormularios.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 622);
            this.Controls.Add(this.PanContenedorFormularios);
            this.Controls.Add(this.MenuPrincipal);
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel PanContenedorFormularios;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPeriodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeMatriculaToolStripMenuItem;
    }
}

