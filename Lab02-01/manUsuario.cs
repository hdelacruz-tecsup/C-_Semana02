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
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;
            string Nombre = txtNombre.Text;
            string Telefono = txtTelefono.Text;
            string Nacimiento = cmbFecha.Text;
            string Apellido = txtApellido.Text;
            string Email = txtEmail.Text;
            string Direccion = txtDirección.Text;


            dgvUsuarios.Rows.Add(DNI, Nombre, Telefono, Nacimiento, Apellido, Email, Direcccion);
        }
    }
}
