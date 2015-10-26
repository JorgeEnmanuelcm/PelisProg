using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL;

namespace PelisProg
{
    public partial class RegistroDeActor : Form
    {
        public RegistroDeActor()
        {
            InitializeComponent();
        }

        private void RegistroDeActor_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarActbutton_Click(object sender, EventArgs e)
        {
            NombreacttextBox.Clear();
        }

        private void GuadarActbutton_Click(object sender, EventArgs e)
        {
            RegistroDeActores Reg = new RegistroDeActores();
            Reg.NombreActor = NombreacttextBox.Text;
            Reg.Insertar();
        }
    }
}
