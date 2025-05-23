using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenU3
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void actualizarGrid()
        {
            Datos datos = new Datos();
            // Consulta para traer los productos de la tabla Producto
            DataSet dataSet = datos.Consulta("SELECT IdProducto AS ID, Nombre, Descripcion, Precio, Stock, FechaIngreso FROM Producto");

            if (dataSet != null)
            {
                dgvProductos.DataSource = dataSet.Tables[0];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Validar que no se haga click en encabezado
            {
                FrmActualizaProductos producto = new FrmActualizaProductos(
                    dgvProductos[0, e.RowIndex].Value.ToString(),  // IdProducto
                    dgvProductos[1, e.RowIndex].Value.ToString(),  // Nombre
                    dgvProductos[2, e.RowIndex].Value.ToString(),  // Descripcion
                    dgvProductos[3, e.RowIndex].Value.ToString(),  // Precio
                    dgvProductos[4, e.RowIndex].Value.ToString(),  // Stock
                    dgvProductos[5, e.RowIndex].Value.ToString()   // FechaIngreso
                );

                producto.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInsertaProductos insertaProductos = new FrmInsertaProductos();
            insertaProductos.ShowDialog();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void FrmProductos_Activated(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 menu = Application.OpenForms["Form1"] as Form1;

            if (menu != null)
            {
                menu.Show();
                this.Close();
            }
            else
            {
                menu = new Form1();
                menu.Show();
                this.Close();
            }
        }
    }
}
