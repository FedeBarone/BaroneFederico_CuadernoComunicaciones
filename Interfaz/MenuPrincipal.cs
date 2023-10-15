﻿using Entidades.Enumerados;
using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MenuPrincipal : Form
    {
        private Usuario usuario;
        frmAlta formulario;
        List<Familia> nombresIngresados;

        public MenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            this.formulario = null;

            nombresIngresados = new List<Familia>();

            ConfigurarInterfazSegunRol();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ConfigurarInterfazSegunRol()
        {
            if (usuario != null)
            {
                if (usuario.Rol == Rol.Administrador)
                {
                    nOTASToolStripMenuItem.Visible = false;

                }
                //else if (usuario.Rol == Rol.UsuarioFinal)
                //{
                //    iNFORMESToolStripMenuItem.Visible = false;
                //    eVENTOSToolStripMenuItem.Visible = false;

                //}
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formulario = new frmAlta();
            this.picInicio.Visible = false;

            DialogResult resultado = this.formulario.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                nombresIngresados.Add(this.formulario.NombrePadreMadreOTutor);

                StringBuilder sb = new StringBuilder();
                foreach (Familia nombre in nombresIngresados)
                {
                    sb.AppendLine(nombre.ToString());
                }
                MessageBox.Show(sb.ToString());
            }
            else
            {
                MessageBox.Show($"cancelado");
            }


        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formulario != null)
            {
                this.formulario.Close();
            }

            this.picInicio.Visible = true;
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaUsuarios vistaUsuarios = new VistaUsuarios(nombresIngresados);
            vistaUsuarios.MdiParent = this;
            vistaUsuarios.Show();
            this.picInicio.Visible = false;

        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nombresIngresados.Count == 0)
            {
                MessageBox.Show("No hay usuarios para dar de baja.");
                return;
            }

            frmBaja frmBaja = new frmBaja(nombresIngresados);

            if (frmBaja.ShowDialog() == DialogResult.OK)
            {
                Familia usuarioBaja = frmBaja.UsuarioSeleccionado;

                nombresIngresados.Remove(usuarioBaja);


                VistaUsuarios vistaUsuarios = new VistaUsuarios(nombresIngresados);
                vistaUsuarios.MdiParent = this;
                vistaUsuarios.Show();
                this.picInicio.Visible = false;

                DataGridView dgv = vistaUsuarios.GetDataGridView();
                dgv.DataSource = null;
                dgv.DataSource = nombresIngresados;

                MessageBox.Show($"Usuario {usuarioBaja.Nombre} ha sido dado de baja.");
            }
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nombresIngresados.Count == 0)
            {
                MessageBox.Show("No hay usuarios para modificar.");
                return;
            }

            frmSeleccionModificacion formularioSeleccion = new frmSeleccionModificacion(nombresIngresados);

            DialogResult resultadoSeleccion = formularioSeleccion.ShowDialog();

            if (resultadoSeleccion == DialogResult.OK)
            {
                Familia usuarioSeleccionado = formularioSeleccion.UsuarioSeleccionado;

                frmModificacion formularioModificacion = new frmModificacion(usuarioSeleccionado);

                DialogResult resultadoModificacion = formularioModificacion.ShowDialog();

                if (resultadoModificacion == DialogResult.OK)
                {
                    int indiceUsuario = nombresIngresados.IndexOf(usuarioSeleccionado);
                    nombresIngresados[indiceUsuario] = formularioModificacion.UsuarioModificado;

                    VistaUsuarios vistaUsuarios = new VistaUsuarios(nombresIngresados);
                    if (vistaUsuarios != null)
                    {
                        DataGridView dgv = vistaUsuarios.GetDataGridView();
                        dgv.DataSource = null;
                        dgv.DataSource = nombresIngresados;
                    }

                    MessageBox.Show($"Usuario {usuarioSeleccionado.Nombre} ha sido modificado.");
                }
            }
        }
    }
}
