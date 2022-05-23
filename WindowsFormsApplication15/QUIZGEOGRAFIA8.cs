﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class QUIZGEOGRAFIA8 : Form
    {
        public QUIZGEOGRAFIA8()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                VariaveisGlobais.acertos += 1;

                QUIZGEOGRAFIA9 QGF9 = new QUIZGEOGRAFIA9();
                QGF9.ShowDialog();
                this.Close();
            }

            else if (rbtn1.Checked || rbtn2.Checked || rbtn3.Checked)
            {
                VariaveisGlobais.erros += 1;

                QUIZGEOGRAFIA9 QGF9 = new QUIZGEOGRAFIA9();
                QGF9.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("ESCOLHA UMA OPÇÃO PARA CONTINUAR !!!");
            }
        }
    }
}
