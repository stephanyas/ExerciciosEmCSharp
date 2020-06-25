﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            switch (cboOpcao.Text)
            {
                case "1 ou 2":
                    lblResposta.Text = "O Dia de rodízio é Segunda-Feira";
                    break;
                case "3 ou 4":
                    lblResposta.Text = "O Dia de rodízio é Terça-Feira";
                    break;
                case "5 ou 6":
                    lblResposta.Text = "O Dia de rodízio é Quarta-Feira";
                    break;
                case "7 ou 8":
                    lblResposta.Text = "O Dia de rodízio é Quinta-Feira";
                    break;
                case "9 ou 0":
                    lblResposta.Text = "O Dia de rodízio é Sexta-Feira";
                    break;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }
    }
}
