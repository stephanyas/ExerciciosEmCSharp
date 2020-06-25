using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_Calculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtIMC.Text = "";
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //Declara a varial e as variaveis recebem o conteudo do textbox
            double peso, altura, imc;

            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);

            //Cálculo IMC
            imc = peso / (altura * altura);

            //Textbox recebe o conteudo da variavel imc utilizando duas casas decimais
            txtIMC.Text = imc.ToString("0.00");

            if (imc < 18.49)
            {
                MessageBox.Show("SITUAÇÃO: Você está abaixo do Peso", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (imc < 24.99)
            {
                MessageBox.Show("SITUAÇÃO: Você está peso dentro da normalidade", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (imc < 29.99)
            {
                MessageBox.Show("SITUAÇÃO: Você está acima do peso", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (imc < 34.99)
            {
                MessageBox.Show("SITUAÇÃO: Você está com besidade grau I", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (imc < 39.99)
            {
                MessageBox.Show("SITUAÇÃO: Você está com obesidade grau II (severa)", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("SITUAÇÃO: Você está com obesidade grau III (mórbida)", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
