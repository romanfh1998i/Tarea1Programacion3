using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            int codigo;
            Double Precio, Cantidad,total;
            codigo = int.Parse(txtCodigo.Text);
            Precio= Double.Parse(txtPrecio.Text);
            Cantidad=Double.Parse(txtCantidad.Text);
            total=Cantidad*Precio;
            dataGridCuenta.Rows.Add(codigo, txtProducto.Text, Precio, Cantidad);

            txtTotal.Text = total.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
