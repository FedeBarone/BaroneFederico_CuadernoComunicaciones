﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class VentanaEmergente : Form
    {
        private string titulo;
        private string mensaje;
        public VentanaEmergente(string titulo, string mensaje)
        {
            InitializeComponent();
            this.titulo = titulo;
            this.mensaje = mensaje;
        }

        private void VentanaEmergente_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = titulo;
            this.lblMsj.Text = mensaje;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
