using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1_controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtAño.Text == "" || txtDia.Text == "" || txtMes.Text == "")
            {
                MessageBox.Show("ERROR: No se pueden dejar espacios en blanco");
            }
            else
            {
                lblFecha.Text = "La Fecha es:";
                lblFecha.Text = lblFecha.Text + txtDia.Text + "/" + txtMes.Text + "/" + txtAño.Text;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrara la ventana");
            MessageBox.Show("Cerrando...");
            this.Close();
        }
    }
}
