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
    public partial class RegistroDeGenero : Form
    {
        public RegistroDeGenero()
        {
            InitializeComponent();
        }

        private void GuardarGenerobutton_Click(object sender, EventArgs e)
        {
             RegistrarGeneros Regis = new RegistrarGeneros();

            Regis.DescripcionDeGeneros = DescripGenerotextBox.Text;
            Regis.Insertar(); 
        }

        private void CancelarGenerobutton_Click(object sender, EventArgs e)
        {
           DescripGenerotextBox.Clear();
        }
    }
}
