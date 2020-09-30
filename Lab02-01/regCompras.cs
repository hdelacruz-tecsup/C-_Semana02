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
    public partial class regCompras : Form
    {
        public regCompras()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Ruc = txtRuc.Text;
            string NombreProv = txtNombreProv.Text;
            string Direccion = txtDireccion.Text;
            string Email = txtEmail.Text;
            string Sede = txtSede.Text;
            string Codigo = txtCodigo.Text;
            string NombreProd = txtNombreProd.Text;
            string Cantidad = txtCantidad.Text;
            string Precio = txtPrecio.Text;
            string Fecha = TxtFecha.Text;

            dgvRegCompras.Rows.Add(Ruc, NombreProv, Direccion, Email, Sede, Codigo, NombreProd, Cantidad,
                                    Precio, Fecha);
        }
    }
}
