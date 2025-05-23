using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenU3
{
    public partial class FrmActualizaProductos : Form
    {
        public FrmActualizaProductos(string id, string nombre, string descripcion,
            string precio, string stock, string fechaIngreso)
        {
            InitializeComponent();
            txtId.Text = id;
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            txtPrecio.Text = precio;
            txtStock.Text = stock;

            // Parsear la fechaIngreso para asignarla al DateTimePicker
            if (DateTime.TryParse(fechaIngreso, out DateTime fecha))
            {
                dtpFecha.Value = fecha;
            }
            else
            {
                dtpFecha.Value = DateTime.Now;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool borrarProd = datos.comando("DELETE FROM Producto WHERE IdProducto = " + txtId.Text);

            if (borrarProd)
            {
                MessageBox.Show("Producto borrado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al borrar el producto", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Datos datos = new Datos();

                string fechaFormateada = dtpFecha.Value.ToString("yyyy-MM-dd");

                bool actProducto = datos.comando("UPDATE Producto SET " +
                    "Nombre = '" + txtNombre.Text.Replace("'", "''") + "', " +
                    "Descripcion = '" + txtDescripcion.Text.Replace("'", "''") + "', " +
                    "Precio = " + double.Parse(txtPrecio.Text == "" ? "0" : txtPrecio.Text) + ", " +
                    "Stock = " + int.Parse(txtStock.Text == "" ? "0" : txtStock.Text) + ", " +
                    "FechaIngreso = '" + fechaFormateada + "' " +
                    "WHERE IdProducto = " + txtId.Text);

                if (actProducto)
                {
                    MessageBox.Show("Producto actualizado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrió un problema al actualizar el producto", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Haz introducido un valor no válido en los campos numéricos", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
