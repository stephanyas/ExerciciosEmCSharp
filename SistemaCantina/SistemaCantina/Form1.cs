using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCantina
{
    public partial class Form1 : Form
    {
        /*
            - Declarando os vetores 
        */
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArrays(); //Metodo é chamado toda vez que o form é carregado
            soma = 0;
        }

        private void carregarArrays()
        {
            //Declarando Valores

            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";

            produtos[1] = "Pastel";
            produtos[2] = "Coxinha";
            produtos[3] = "HotDog";
            produtos[4] = "Chocolate";
            produtos[5] = "Refrigerante";

            valor[1] = 5.00;
            valor[2] = 5.00;
            valor[3] = 10.00;
            valor[4] = 3.50;
            valor[5] = 6.00;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            /*
                - Inicia a condição, se for digitado um código com 3 caracteres (length) e esse codigo  é adcionado ao listbox
                - A propriedade length retorna a quantidade de caracteres                
            */
            if (txtCodigo.Text.Length == 3)
            {
                int i = 0;

                // Faça enquanto o prod for menor ou igual a qtd de itens do array                
                for (int prod = 1; prod < codigo.Length; prod++)
                {
                    // Se foi encontrado o produto ele retorna as informações de acordo com o indice
                    if (txtCodigo.Text == codigo[prod])
                    {
                        i = prod;
                    }
                }
                // Se não retorna, Produto Não Encontrado
                if (i == 0)
                {
                    MessageBox.Show("Produto Não Encontrado");
                }
                else
                {
                    // Conteudo adicionado ao listBox e contatenando codigo, produto e preço
                    ltbCaixa.Items.Add(txtCodigo.Text + " - " + produtos[i] + " - R$ " + valor[i]);
                                        
                    soma = soma + valor[i];
                    lblValor.Text = ("Valor Total R$" + soma);
                    /*
                        - Localiza a imagem na pasta img 
                        - O textBox será limpo e o focus posiciona o cusor para uma nova digitação
                    */
                    ptbImagem.ImageLocation = "C:/SistemaCantina/img/" + codigo[i] + ".jpg";
                    txtCodigo.Text = "";
                    txtCodigo.Focus();
                }
            }
        }


    }
}
