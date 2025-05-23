using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Xml.Linq;

namespace ExamenU3
{
    public partial class FrmInsertaProductos : Form
    {
        public FrmInsertaProductos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaIngreso = dtFecha.Value;

                Datos datos = new Datos();
                bool aggProducto = datos.comando("insert into Producto values('" +
                    txtNombre.Text.Replace("'", "''") + "', '" +
                    txtDescripcion.Text.Replace("'", "''") + "', " +
                    double.Parse(txtPrecio.Text) + ", " +
                    int.Parse(txtStock.Text) + ", '" +
                    fechaIngreso.ToString("yyyy-MM-dd") + "')");

                if (aggProducto)
                {
                    MessageBox.Show("Producto agregado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al agregar el producto", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Valores no esperados\nAsegúrese de no haber introducido letras en vez de números", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }

