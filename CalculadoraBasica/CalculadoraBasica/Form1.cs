using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiroNumero.Text = "";
            txtSegundoNumero.Text = "";
            txtResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*
          - Variaveis para receber os numeros que veem das textbox
          - As variaveis num1, num2 recebe o conteudo da textbox e converte o conteudo para numero 
          - Soma/Subitração/Divisão/Multiplicação das variaveis e resultado recebe o valor
          - txtResultado recebe o conteudo da variavel resultado e converte para número 
        */

        private void btnSoma_Click(object sender, EventArgs e)
        {

            double num1, num2, resultado;
            
            num1 = Convert.ToDouble(txtPrimeiroNumero.Text);
            num2 = Convert.ToDouble(txtSegundoNumero.Text);
            
            resultado = num1 + num2;
            
            txtResultado.Text = resultado.ToString();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(txtPrimeiroNumero.Text);
            num2 = Convert.ToDouble(txtSegundoNumero.Text);

            resultado = num1 - num2;

            txtResultado.Text = resultado.ToString();

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(txtPrimeiroNumero.Text);
            num2 = Convert.ToDouble(txtSegundoNumero.Text);

            resultado = num1 * num2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(txtPrimeiroNumero.Text);
            num2 = Convert.ToDouble(txtSegundoNumero.Text);

            resultado = num1 / num2;

            txtResultado.Text = resultado.ToString();

        }
    }
}
