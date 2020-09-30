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
    public partial class manClientes : Form
    {
        public manClientes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Ruc = txtRuc.Text;
            string Fecha = txtFecha.Text;
            string Nombre = txtNombre.Text;
            string Telefono = txtTelefono.Text;
            string Email = txtEmail.Text;
            string Dirección = txtDirección.Text;

            dgvClientes.Rows.Add(Ruc, Fecha, Nombre, Telefono, Email, Dirección);
        }
    }
}
