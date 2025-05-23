using CrystalDecisions.Shared;
using CrystalDecisions.Web;
using Microsoft.VisualBasic.ApplicationServices;

namespace ExamenU3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmProductos Productos = new FrmProductos();
            Productos.Show();
        }

        private void informeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }
    }
}