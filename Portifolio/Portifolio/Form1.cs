using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portifolio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdImpares_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";

            for (int i = 0; i <= 40; i++)
            {
                if (i % 2 != 0) 
                {
                    Console.WriteLine(i);

                    if (txtResultado.Text == "")
                    {
                        txtResultado.Text = i.ToString();
                    }
                    else
                    {
                        txtResultado.Text = txtResultado.Text + Environment.NewLine + i.ToString();
                    }

                }
            }
        }

        private void cmdSoma_Click(object sender, EventArgs e)
        {
            
            int soma = 0;
            int valorAnterior = 0;

            txtResultado.Text = "";

            for (int i = 0; i <= 100; i++)
            {
                valorAnterior = soma;
                soma+= i;

                Console.WriteLine(valorAnterior.ToString() + " + " + i.ToString() + " = " + soma.ToString());

                if (txtResultado.Text == "")
                {
                    txtResultado.Text = valorAnterior.ToString() + " + " + i.ToString() + " = " + soma.ToString();
                }
                else
                {
                    txtResultado.Text = txtResultado.Text + Environment.NewLine +  valorAnterior.ToString() + " + " + i.ToString() + " = " + soma.ToString();
                }
            }
        }

        private void cmdDivisao_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";

            for (int i = 1; i <= 40; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);

                    if (txtResultado.Text == "")
                    {
                        txtResultado.Text = i.ToString();
                    }
                    else
                    {
                        txtResultado.Text = txtResultado.Text + Environment.NewLine + i.ToString();
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";

            for (int i = 15; i <= 200; i++)
            {
              
                Console.WriteLine("O quadrado de " + i + " é " + i * i);

                if (txtResultado.Text == "")
                {
                    txtResultado.Text = "O quadrado de " + i + " é " + i * i;
                }
                else
                {
                    txtResultado.Text = txtResultado.Text + Environment.NewLine + "O quadrado de " + i + " é " + i* i;
                }
                
            }
        }

        private void cmdSomaPares_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            int soma = 0;
            int valorAnterior = 0;

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {

                    valorAnterior = soma;
                    soma+= i;

                    Console.WriteLine(valorAnterior.ToString() + " + " + i.ToString() + " = " + soma.ToString());

                    if (txtResultado.Text == "")
                    {
                        txtResultado.Text = valorAnterior.ToString() + " + " + i.ToString() + " = " + soma.ToString();
                    }
                    else
                    {
                        txtResultado.Text = txtResultado.Text + Environment.NewLine +  valorAnterior.ToString() + " + " + i.ToString() + " = " + soma.ToString();
                    }

                }
            }
        }
    }
}
