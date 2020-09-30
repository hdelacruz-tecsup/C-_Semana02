using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class manProductos : Form
    {
        public manProductos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigo.Text;
            string Nombre = txtNombre.Text;
            string Precio = txtPrecio.Text;
            string Stock = txtStock.Text;
            string Tipo = cmbTipo.Text;
            string Fecha = txtFecha.Text;


            dgvProductos.Rows.Add(Codigo, Nombre, Precio, Stock, Tipo, Fecha);
    }
    }
}
