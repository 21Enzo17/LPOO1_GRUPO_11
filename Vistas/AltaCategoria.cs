﻿using ClaseBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class AltaCategoria : Form
    {
        private Form sistemReferencia;
        public AltaCategoria(Form sistemReferencia)
        {
            InitializeComponent();
            this.sistemReferencia = sistemReferencia;
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            sistemReferencia.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea agregar la Categoria?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            Categoria categoria = new Categoria(DatosGlobales.categorias.Count(),txtNombre.Text,txtDescripcion.Text);
            DatosGlobales.categorias.Add(categoria);

        }
    }
}
