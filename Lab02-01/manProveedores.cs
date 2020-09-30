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
    public partial class manProveedores : Form
    {
        public manProveedores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Ruc = txtRuc.Text;
            string Fecha = txtFecha.Text;
            string Telefono = txtTelefono.Text;
            string Lugar = (string)cmbLugar.SelectedItem;
            string Email = txtEmail.Text;
            string Direccion = txtDireccion.Text;

            dgvProveedores.Rows.Add(Ruc, Fecha, Telefono, Lugar,Email, Direccion);
        }
    }
}
