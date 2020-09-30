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
    public partial class regVentas : Form
    {
        public regVentas()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void regVentas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Ruc = txtRuc.Text;
            string Nombre_C = txtNombre_C.Text;
            string Direccion = txtDirección.Text;
            string Codigo = txtCodigo.Text;
            string Nombre_P = txtNombre_P.Text;
            string Cantidad = txtCantidad.Text;
            string Sede = txtSede.Text;
            string Precio_U = txtPrecioU.Text;
            string IGV = txtIGV.Text;
            string SubTotal = txtSubTotal.Text;
            string MontoTotal = txtMontoTotal.Text;

            dgvRegVentas.Rows.Add(Ruc, Nombre_C, Direccion, Codigo, Nombre_P, Cantidad, Sede,
                                    Precio_U, IGV, SubTotal, MontoTotal);
        }
    }
}
