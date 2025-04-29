using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        { //pegar numeros da interface
            int n1, n2;
           n1 = int.Parse(txtNum1.Text);
           n2 = int.Parse(txtNum2.Text);

            //verificar a opc marcada
            if (rbSoma.Checked)
            {
                lbResultado.Text = (n1 + n2).ToString();
            }
            else if (rbSub.Checked)
            {
                lbResultado.Text = (n1 - n2).ToString();
            }
            else if (rbMult.Checked)
            {
                lbResultado.Text = (n1 * n2).ToString();
            }
            else if (rbDiv.Checked)
            {
                if (n2 != 0)
                {
                    lbResultado.Text = (n1/n2).ToString();
                }
                else
                {
                    lbResultado.Text = "ERRO";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //retorna os nud's ao svalores originais:
            txtNum1.Text = "";
            txtNum2.Text = "";
            lbResultado.Text = "";
        }
    }
}
