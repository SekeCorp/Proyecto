﻿namespace Proyecto
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarHorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem,
            this.horarioToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Image = global::Proyecto.Properties.Resources.usuario;
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.ingresarToolStripMenuItem.Text = "Ingresar";
            this.ingresarToolStripMenuItem.Click += new System.EventHandler(this.ingresarToolStripMenuItem_Click);
            // 
            // horarioToolStripMenuItem
            // 
            this.horarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem1,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.generarToolStripMenuItem,
            this.disponibilidadToolStripMenuItem,
            this.horariosToolStripMenuItem,
            this.editarHorarioToolStripMenuItem});
            this.horarioToolStripMenuItem.Enabled = false;
            this.horarioToolStripMenuItem.Image = global::Proyecto.Properties.Resources.calendario;
            this.horarioToolStripMenuItem.Name = "horarioToolStripMenuItem";
            this.horarioToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.horarioToolStripMenuItem.Text = "Horario";
            // 
            // ingresarToolStripMenuItem1
            // 
            this.ingresarToolStripMenuItem1.Image = global::Proyecto.Properties.Resources.anadir;
            this.ingresarToolStripMenuItem1.Name = "ingresarToolStripMenuItem1";
            this.ingresarToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.ingresarToolStripMenuItem1.Text = "Ingresar";
            this.ingresarToolStripMenuItem1.Click += new System.EventHandler(this.ingresarToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = global::Proyecto.Properties.Resources.boton_actualizar;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::Proyecto.Properties.Resources.borrar;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.Image = global::Proyecto.Properties.Resources.calendario;
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.generarToolStripMenuItem.Text = "Generar";
            this.generarToolStripMenuItem.Click += new System.EventHandler(this.generarToolStripMenuItem_Click);
            // 
            // disponibilidadToolStripMenuItem
            // 
            this.disponibilidadToolStripMenuItem.Image = global::Proyecto.Properties.Resources.busqueda;
            this.disponibilidadToolStripMenuItem.Name = "disponibilidadToolStripMenuItem";
            this.disponibilidadToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.disponibilidadToolStripMenuItem.Text = "Disponibilidad";
            this.disponibilidadToolStripMenuItem.Click += new System.EventHandler(this.disponibilidadToolStripMenuItem_Click);
            // 
            // horariosToolStripMenuItem
            // 
            this.horariosToolStripMenuItem.Image = global::Proyecto.Properties.Resources.calendario;
            this.horariosToolStripMenuItem.Name = "horariosToolStripMenuItem";
            this.horariosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.horariosToolStripMenuItem.Text = "Horarios";
            this.horariosToolStripMenuItem.Click += new System.EventHandler(this.horariosToolStripMenuItem_Click);
            // 
            // editarHorarioToolStripMenuItem
            // 
            this.editarHorarioToolStripMenuItem.Image = global::Proyecto.Properties.Resources.boton_actualizar;
            this.editarHorarioToolStripMenuItem.Name = "editarHorarioToolStripMenuItem";
            this.editarHorarioToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.editarHorarioToolStripMenuItem.Text = "Editar Horario";
            this.editarHorarioToolStripMenuItem.Click += new System.EventHandler(this.editarHorarioToolStripMenuItem_Click);
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamoToolStripMenuItem,
            this.agregarEquipoToolStripMenuItem,
            this.prestamoEquipoToolStripMenuItem,
            this.devolucionEquipoToolStripMenuItem});
            this.equiposToolStripMenuItem.Enabled = false;
            this.equiposToolStripMenuItem.Image = global::Proyecto.Properties.Resources.ordenador_personal;
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.equiposToolStripMenuItem.Text = "Equipos";
            // 
            // prestamoToolStripMenuItem
            // 
            this.prestamoToolStripMenuItem.Image = global::Proyecto.Properties.Resources.busqueda;
            this.prestamoToolStripMenuItem.Name = "prestamoToolStripMenuItem";
            this.prestamoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.prestamoToolStripMenuItem.Text = "Buscar Equipo";
            this.prestamoToolStripMenuItem.Click += new System.EventHandler(this.prestamoToolStripMenuItem_Click);
            // 
            // agregarEquipoToolStripMenuItem
            // 
            this.agregarEquipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarEquipoToolStripMenuItem});
            this.agregarEquipoToolStripMenuItem.Image = global::Proyecto.Properties.Resources.anadir;
            this.agregarEquipoToolStripMenuItem.Name = "agregarEquipoToolStripMenuItem";
            this.agregarEquipoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.agregarEquipoToolStripMenuItem.Text = "Agregar Equipo";
            this.agregarEquipoToolStripMenuItem.Click += new System.EventHandler(this.agregarEquipoToolStripMenuItem_Click);
            // 
            // modificarEquipoToolStripMenuItem
            // 
            this.modificarEquipoToolStripMenuItem.Name = "modificarEquipoToolStripMenuItem";
            this.modificarEquipoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.modificarEquipoToolStripMenuItem.Text = "Modificar Equipo";
            this.modificarEquipoToolStripMenuItem.Click += new System.EventHandler(this.modificarEquipoToolStripMenuItem_Click);
            // 
            // prestamoEquipoToolStripMenuItem
            // 
            this.prestamoEquipoToolStripMenuItem.Image = global::Proyecto.Properties.Resources.obtener_dinero;
            this.prestamoEquipoToolStripMenuItem.Name = "prestamoEquipoToolStripMenuItem";
            this.prestamoEquipoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.prestamoEquipoToolStripMenuItem.Text = "Prestamo Equipo";
            this.prestamoEquipoToolStripMenuItem.Click += new System.EventHandler(this.prestamoEquipoToolStripMenuItem_Click);
            // 
            // devolucionEquipoToolStripMenuItem
            // 
            this.devolucionEquipoToolStripMenuItem.Name = "devolucionEquipoToolStripMenuItem";
            this.devolucionEquipoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.devolucionEquipoToolStripMenuItem.Text = "Devolucion Equipo";
            this.devolucionEquipoToolStripMenuItem.Click += new System.EventHandler(this.devolucionEquipoToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cerrarSesionToolStripMenuItem.Enabled = false;
            this.cerrarSesionToolStripMenuItem.Image = global::Proyecto.Properties.Resources.cerrar_sesion__1_;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click_1);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.Enabled = false;
            this.controlToolStripMenuItem.Image = global::Proyecto.Properties.Resources._2c6cw75;
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.controlToolStripMenuItem.Text = "Control";
            this.controlToolStripMenuItem.Click += new System.EventHandler(this.controlToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(973, 625);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Horario y Equipos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamoEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarHorarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEquipoToolStripMenuItem;
    }
}

