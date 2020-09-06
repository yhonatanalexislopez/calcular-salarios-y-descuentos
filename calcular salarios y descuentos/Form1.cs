using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calcular_salarios_y_descuentos
{
    public partial class Form1 : Form
    {
        Salarios salario = new Salarios();
        Descuentos descuento = new Descuentos();

        public Form1()
        {
            InitializeComponent();
        }

        private void lblvalorccp_Click(object sender, EventArgs e)
        {

        }

        private void btnsalarioBase_Click(object sender, EventArgs e)
        {
            salario.setcantidadhoras(double.Parse(txthorastrabajadas.Text));
            lblsalarioBase.Visible = true;
            lblsalarioBase.Text = Convert.ToString(salario.calcularsalarioBase());
        }

        private void btndescuentos_Click(object sender, EventArgs e)
        {
            descuento.setcantidadhoras(double.Parse(txthorastrabajadas.Text));
            lblvalorsalud.Text = Convert.ToString(descuento.calcularSalud());
            lblvalorpencion.Text = Convert.ToString(descuento.calcularPension());
            lblvalorccp.Text = Convert.ToString(descuento.calcularccp());
            lblvalorsalariofinal.Text = Convert.ToString(descuento.calcularSalarioConDescuento());
        }
    }
}
