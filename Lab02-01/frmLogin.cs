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
    
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string[,] arreglo = { { "Junior", "Jhordan" }, { "hugo1995", "hd2417" } };
        private int intentos;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == arreglo[0, 0] && txtPassword.Text == arreglo[1, 0])
            {
                this.Hide();
                PrincipalMDI p = new PrincipalMDI();
                p.Show();
            }
            else if (intentos == 3)
            {
                MessageBox.Show("Ha alcanzado el nivel maximo de intentos, Porfavor vuelva a intentarlo", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                intentos += 1;
                MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña ó es posible que su cuenta este inhabilitada", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Text = "";

            }

            //PrincipalMDI principal = new PrincipalMDI();
            //principal.Show();
            //this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
