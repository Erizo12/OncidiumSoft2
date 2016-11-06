﻿using OncidiumSoft.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OncidiumSoft
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void VentasDia_Click(object sender, EventArgs e)
        {
            frmCalendario obj = new frmCalendario();
            obj.Show();

        }

        private void Productos_Click(object sender, EventArgs e)
        {
            FrmProductos llamProductos = new FrmProductos();
            llamProductos.Show();
        }

        private void Ventas1_Click(object sender, EventArgs e)
        {
            FrmVenta llamarVentas = new FrmVenta();
            llamarVentas.id = int.Parse(idUsuario.Text.ToString());
            llamarVentas.Show();
        }
    }
}
