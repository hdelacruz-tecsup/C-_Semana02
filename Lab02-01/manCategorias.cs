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
    public partial class manCategorias : Form
    {
        public manCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = cmbNombre.Text;
            string Sede = (string)cbmSede.SelectedItem;
            string Estado = (string)cbmEstado.SelectedItem;
            string Fecha = txtFecha.Text;
            
            

            dgvcategorias.Rows.Add( Nombre, Sede, Estado, Fecha);
        }
    }
}
