using Entidades.Usuarios;
using System;
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
    public partial class VistaUsuarios : Form
    {
        List<Familia> familias;

        public VistaUsuarios(List<Familia> familias)
        {
            InitializeComponent();
            this.familias = familias;
        }

        private void VistaUsuarios_Load(object sender, EventArgs e)
        {
            //this.familias.Add(new Familia("Kaio", 1, "Kaio34@outlook.com", "121", "Padre", "Kaio12", 6, 120));
            //this.familias.Add(new Familia("Max", 2, "Max122@outlook.com", "234", "Padre", "Max14", 10, 121));
            //this.familias.Add(new Familia("Fox", 3, "fox4@outlook.com", "789", "Padre", "Fox54", 11, 122));
            //this.familias.Add(new Familia("Fede", 4, "fede234@outlook.com", "779", "Tutor", "Fede13", 12, 123));
            //this.familias.Add(new Familia("Grey", 5, "Grey500@outlook.com", "987", "Padre", "Grey678", 14, 127));

            this.dtgVistaUsuarios.DataSource = null;
            this.dtgVistaUsuarios.DataSource = this.familias;

        }
    }
}
