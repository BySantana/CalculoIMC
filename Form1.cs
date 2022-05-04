using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula71_Imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aula71_Imc.IMC imc = new Aula71_Imc.IMC(double.Parse(txtAltura.Text), double.Parse(txtPeso.Text));
            lblResultado.Text = imc.MostrarClassificacao(imc.CalcularImc());
            label3.Text = $"{imc.CalcularImc():F2}";
        }
    }
}
