﻿namespace OncidiumSoft
{
    partial class FrmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.Ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.Ventas1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Administrar = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.Provedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.VentasDia = new System.Windows.Forms.ToolStripMenuItem();
            this.VentasFecha = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarContabilidad = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarAjuste = new System.Windows.Forms.ToolStripMenuItem();
            this.idUsuario2 = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.ForestGreen;
            this.menuPrincipal.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Ventas,
            this.Administrar,
            this.Reportes,
            this.contabilidadToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(1161, 33);
            this.menuPrincipal.TabIndex = 4;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Salir});
            this.Archivo.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Archivo.ForeColor = System.Drawing.SystemColors.Window;
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(88, 29);
            this.Archivo.Text = "Archivo";
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.ForestGreen;
            this.Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(124, 30);
            this.Salir.Text = "Salir";
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Ventas
            // 
            this.Ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ventas1,
            this.pedidosToolStripMenuItem,
            this.compraDeProductosToolStripMenuItem});
            this.Ventas.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ventas.ForeColor = System.Drawing.SystemColors.Window;
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(83, 29);
            this.Ventas.Text = "Ventas";
            // 
            // Ventas1
            // 
            this.Ventas1.BackColor = System.Drawing.Color.ForestGreen;
            this.Ventas1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ventas1.Name = "Ventas1";
            this.Ventas1.Size = new System.Drawing.Size(256, 30);
            this.Ventas1.Text = "Ventas";
            this.Ventas1.Click += new System.EventHandler(this.Ventas1_Click_1);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.BackColor = System.Drawing.Color.ForestGreen;
            this.pedidosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // compraDeProductosToolStripMenuItem
            // 
            this.compraDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.ForestGreen;
            this.compraDeProductosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.compraDeProductosToolStripMenuItem.Name = "compraDeProductosToolStripMenuItem";
            this.compraDeProductosToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.compraDeProductosToolStripMenuItem.Text = "Compra de productos";
            this.compraDeProductosToolStripMenuItem.Click += new System.EventHandler(this.compraDeProductosToolStripMenuItem_Click);
            // 
            // Administrar
            // 
            this.Administrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuarios,
            this.Productos,
            this.Provedores});
            this.Administrar.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrar.ForeColor = System.Drawing.SystemColors.Window;
            this.Administrar.Name = "Administrar";
            this.Administrar.Size = new System.Drawing.Size(125, 29);
            this.Administrar.Text = "Administrar";
            // 
            // Usuarios
            // 
            this.Usuarios.BackColor = System.Drawing.Color.ForestGreen;
            this.Usuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(173, 30);
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Productos
            // 
            this.Productos.BackColor = System.Drawing.Color.ForestGreen;
            this.Productos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(173, 30);
            this.Productos.Text = "Productos";
            this.Productos.Click += new System.EventHandler(this.Productos_Click);
            // 
            // Provedores
            // 
            this.Provedores.BackColor = System.Drawing.Color.ForestGreen;
            this.Provedores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Provedores.Name = "Provedores";
            this.Provedores.Size = new System.Drawing.Size(173, 30);
            this.Provedores.Text = "Provedores";
            this.Provedores.Click += new System.EventHandler(this.Provedores_Click);
            // 
            // Reportes
            // 
            this.Reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VentasDia,
            this.VentasFecha,
            this.ventasPorMesToolStripMenuItem});
            this.Reportes.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportes.ForeColor = System.Drawing.SystemColors.Window;
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(96, 29);
            this.Reportes.Text = "Reportes";
            // 
            // VentasDia
            // 
            this.VentasDia.BackColor = System.Drawing.Color.ForestGreen;
            this.VentasDia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VentasDia.Name = "VentasDia";
            this.VentasDia.Size = new System.Drawing.Size(242, 30);
            this.VentasDia.Text = "Ventas del dia";
            this.VentasDia.Click += new System.EventHandler(this.VentasDia_Click);
            // 
            // VentasFecha
            // 
            this.VentasFecha.BackColor = System.Drawing.Color.ForestGreen;
            this.VentasFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VentasFecha.Name = "VentasFecha";
            this.VentasFecha.Size = new System.Drawing.Size(242, 30);
            this.VentasFecha.Text = "Ventas por semana";
            this.VentasFecha.Click += new System.EventHandler(this.VentasFecha_Click);
            // 
            // ventasPorMesToolStripMenuItem
            // 
            this.ventasPorMesToolStripMenuItem.BackColor = System.Drawing.Color.ForestGreen;
            this.ventasPorMesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ventasPorMesToolStripMenuItem.Name = "ventasPorMesToolStripMenuItem";
            this.ventasPorMesToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.ventasPorMesToolStripMenuItem.Text = "Ventas por mes";
            this.ventasPorMesToolStripMenuItem.Click += new System.EventHandler(this.ventasPorMesToolStripMenuItem_Click);
            // 
            // contabilidadToolStripMenuItem
            // 
            this.contabilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarContabilidad});
            this.contabilidadToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contabilidadToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.contabilidadToolStripMenuItem.Name = "contabilidadToolStripMenuItem";
            this.contabilidadToolStripMenuItem.Size = new System.Drawing.Size(132, 29);
            this.contabilidadToolStripMenuItem.Text = "Contabilidad";
            // 
            // realizarContabilidad
            // 
            this.realizarContabilidad.BackColor = System.Drawing.Color.ForestGreen;
            this.realizarContabilidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.realizarContabilidad.Name = "realizarContabilidad";
            this.realizarContabilidad.Size = new System.Drawing.Size(265, 30);
            this.realizarContabilidad.Text = "Realizar contabilidad";
            this.realizarContabilidad.Click += new System.EventHandler(this.realizarContabilidad_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarAjuste});
            this.inventarioToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // realizarAjuste
            // 
            this.realizarAjuste.BackColor = System.Drawing.Color.ForestGreen;
            this.realizarAjuste.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.realizarAjuste.Name = "realizarAjuste";
            this.realizarAjuste.Size = new System.Drawing.Size(212, 30);
            this.realizarAjuste.Text = "Realizar ajuste";
            this.realizarAjuste.Click += new System.EventHandler(this.realizarAjuste_Click);
            // 
            // idUsuario2
            // 
            this.idUsuario2.AutoSize = true;
            this.idUsuario2.Location = new System.Drawing.Point(469, 247);
            this.idUsuario2.Name = "idUsuario2";
            this.idUsuario2.Size = new System.Drawing.Size(0, 15);
            this.idUsuario2.TabIndex = 5;
            this.idUsuario2.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::OncidiumSoft.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1161, 474);
            this.Controls.Add(this.idUsuario2);
            this.Controls.Add(this.menuPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem Salir;
        private System.Windows.Forms.ToolStripMenuItem Ventas;
        private System.Windows.Forms.ToolStripMenuItem Ventas1;
        private System.Windows.Forms.ToolStripMenuItem Administrar;
        private System.Windows.Forms.ToolStripMenuItem Usuarios;
        private System.Windows.Forms.ToolStripMenuItem Productos;
        private System.Windows.Forms.ToolStripMenuItem Provedores;
        private System.Windows.Forms.ToolStripMenuItem Reportes;
        private System.Windows.Forms.ToolStripMenuItem VentasDia;
        private System.Windows.Forms.ToolStripMenuItem VentasFecha;
        private System.Windows.Forms.ToolStripMenuItem ventasPorMesToolStripMenuItem;
        public System.Windows.Forms.Label idUsuario2;
        private System.Windows.Forms.ToolStripMenuItem contabilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarContabilidad;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarAjuste;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraDeProductosToolStripMenuItem;
    }
}

