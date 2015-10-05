using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PelisProg
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarForm rf = new RegistrarForm();
            rf.Show();

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarForm cf = new ConsultarForm();
            cf.Show();
        }
    }
}
