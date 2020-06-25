using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVetor_Click(object sender, EventArgs e)
        {
            //Teste vetor de numeros

            int[] vetor = new int[4];
            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 9;
            vetor[3] = 1;

            int valor = vetor[1];

            System.Array.Sort(vetor); //Ordena o vetor

            for (int i = 0; i < 4; i++)
                MessageBox.Show(vetor[i].ToString(), "Array");
        }

        private void btnVetor2_Click(object sender, EventArgs e)
        {
            //Teste vetor de texto

            string[] vetSemana = new string[7];
            vetSemana[0] = "Domingo";
            vetSemana[1] = "Segunda-Feira";
            vetSemana[2] = "Terça-Feira";
            vetSemana[3] = "Quatrta-Feira";
            vetSemana[4] = "Quinta-Feira";
            vetSemana[5] = "Sexta-Feira";
            vetSemana[6] = "Sabado";

            string valor = vetSemana[1]; //Variavel declarada para acessar o vetor

            for (int i = 0; i < 7; i++)
                MessageBox.Show(vetSemana[i].ToString(), "Array");          
        }

        private void btnVetor3_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[2, 4]; //Declara e instancia o array multidimensional, indicando a quantidade de linhas e colunas
            notas[0, 0] = 8.0;
            notas[0, 1] = 7.5;
            notas[0, 2] = 6.0;
            notas[0, 3] = 9.0;
            notas[1, 0] = 9.0;
            notas[1, 1] = 7.5;
            notas[1, 2] = 6.0;
            notas[1, 3] = 4.0;

            MessageBox.Show(notas[0, 1].ToString(), "Array");
            MessageBox.Show(notas[1, 2].ToString(), "Array");
            MessageBox.Show(notas[0, 3].ToString(), "Array");
        }
    }
}
