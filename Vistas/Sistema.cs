﻿using System;
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
    public partial class Sistema : Form
    {
        private Form prinicpalReferencia;
        public Sistema(Form principal)
        {
            InitializeComponent();
            prinicpalReferencia = principal;
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            prinicpalReferencia.Show();
        }

        private void btnAltaCategorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form altaCategoria = new AltaCategoria(this);
            altaCategoria.Show();
        }
    }
}
