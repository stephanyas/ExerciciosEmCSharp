using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoNota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            /*
              3 Variaveis que vai receber os valores convertido do text e double,
              soma os valores e divide para receber a media das notas, e o resultado
              passa o valor convertido para o resultado             
             */
            double nota1, nota2, nota3, resultado;

            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);

            resultado = (nota1 + nota2 + nota3) / 3;

            if (resultado < 5)
            {
                MessageBox.Show("Reprovado");
                txtResultado.Text = resultado.ToString();
            }
            else if (resultado >= 7)
            {
                MessageBox.Show("Aprovado");
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Recuperação");
                txtResultado.Text = resultado.ToString();
            }


        }
    }
}
