using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if(lbl_resultado.Text == "0")
            {
                lbl_resultado.Text = "0";
            }
            else
            {
                lbl_resultado.Text = lbl_resultado.Text + "0";
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (lbl_resultado.Text == "0")
            {
                lbl_resultado.Text = "1";
            }
            else
            {
                lbl_resultado.Text = lbl_resultado.Text + "1";
            }

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (lbl_resultado.Text == "0")
            {
                lbl_resultado.Text = "2";
            }
            else
            {
                lbl_resultado.Text = lbl_resultado.Text + "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (lbl_resultado.Text == "0")
            {
                lbl_resultado.Text = "3";
            }
            else
            {
                lbl_resultado.Text = lbl_resultado.Text + "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (lbl_resultado.Text == "0")
            {
                lbl_resultado.Text = "4";
            }
            else
            {
                lbl_resultado.Text = lbl_resultado.Text + "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (lbl_resultado.Text == "0")
            {
                lbl_resultado.Text = "5";
            }
            else
            {
                lbl_resultado.Text = lbl_resultado.Text + "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (lbl_resultado.Text == "0")
            {
                lbl_resultado.Text = "6";
            }
            else
            {
                lbl_resultado.Text = lbl_resultado.Text + "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (lbl_resultado.Text == "0")
            {
                lbl_resultado.Text = "7";
            }
            else
            {
                lbl_resultado.Text = lbl_resultado.Text + "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (lbl_resultado.Text == "0")
            {
                lbl_resultado.Text = "8";
            }
            else
            {
                lbl_resultado.Text = lbl_resultado.Text + "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (lbl_resultado.Text == "0")
            {
                lbl_resultado.Text = "9";
            }
            else
            {
                lbl_resultado.Text = lbl_resultado.Text + "9";
            }
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            lbl_valor.Text = lbl_resultado.Text;
            lbl_sinal.Text = "+";
            lbl_resultado.Text = "0";
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            lbl_valor.Text = lbl_resultado.Text;
            lbl_sinal.Text = "-";
            lbl_resultado.Text = "0";
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            lbl_valor.Text = lbl_resultado.Text;
            lbl_sinal.Text = "X";
            lbl_resultado.Text = "0";
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            lbl_valor.Text = lbl_resultado.Text;
            lbl_sinal.Text = "/";
            lbl_resultado.Text = "0";
        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            
            lbl_resultado.Text = "0";
           
             
               
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            
            lbl_resultado.Text = "0";
            lbl_sinal.Text = "0";
            lbl_valor.Text = "0";

            
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            if (lbl_resultado.Text.IndexOf(",") == -1)
            {
                lbl_resultado.Text = lbl_resultado.Text + ",";
            }
            
        }

        private void btn_sinal_Click(object sender, EventArgs e)
        {
            decimal num;
            num = Convert.ToDecimal(lbl_resultado.Text);

            num = num * -1;

            lbl_resultado.Text = num.ToString();

            //lbl_resultado.text = convert.ToString(convert.toDecimal(lbl_resultado.text) * -1);

            

        }

        private void btn_x2_Click(object sender, EventArgs e)
        {
            decimal num;
            num = Convert.ToDecimal(lbl_resultado.Text);

            num = num * num;

            lbl_resultado.Text = num.ToString();
        }

        private void btn_1x_Click(object sender, EventArgs e)
        {
            decimal num;
            num = Convert.ToDecimal(lbl_resultado.Text);

            num = 1/num;

            lbl_resultado.Text = num.ToString();
        }

        private void btn_raiz_quadrada_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(lbl_resultado.Text);

            num = Math.Sqrt(num);

            lbl_resultado.Text = num.ToString();
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            int tamanho;
            
            tamanho = lbl_resultado.Text.Length;
            if (tamanho <= 1)
            {
                lbl_resultado.Text = "0";
            }
            else
            {
                lbl_resultado.Text = lbl_resultado.Text.Substring(0, tamanho - 1);
            }
            
        }

        private void btn_porcentagem_Click(object sender, EventArgs e)
        {
            if (lbl_resultado.Text != "0")
            {
                lbl_valor.Text = lbl_resultado.Text;
                lbl_sinal.Text = "%";
                lbl_valor.Text = "0";
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            // tamanho max = 10 numeros
            //!= significa diferente

            decimal resultado = 0;
            decimal valor1 = Convert.ToDecimal(lbl_valor.Text);
            decimal valor2 = Convert.ToDecimal(lbl_resultado.Text);

            if(lbl_resultado.Text != "" && lbl_sinal.Text != "")
            {
                switch (lbl_sinal.Text)
                {
                    case "+":
                        resultado = valor1 + valor2;
                        break;
                    case "-":
                        resultado = valor1 - valor2;
                        break;
                    case "/":
                        resultado = valor1 / valor2;
                        break;
                    case "X":
                        resultado = valor1 * valor2;
                        break;
                    case "%":
                        resultado = (valor1 / 100) * valor2;
                        break;
                }
            }

            int tamanhomax = resultado.ToString().Length;

            if(tamanhomax > 10)
            {
                tamanhomax = 10;
            }

            lbl_resultado.Text = resultado.ToString().Substring(0, tamanhomax);
        }

        private void lbl_resultado_KeyPress(object sender, KeyPressEventArgs e)
        {
         if (!Char.IsNumber(e.KeyChar))
            {
                switch (e.KeyChar.ToString())
                {
                    case "=":
                        e.Handled = true;
                        btn_igual_Click(null, null);
                        lbl_resultado.SelectAll();
                        break;
                    case "+":
                        e.Handled = true;
                        btn_soma_Click(null, null);
                        lbl_resultado.SelectAll();
                        break;
                    case "-":
                        e.Handled = true;
                        btn_menos_Click(null, null);
                        lbl_resultado.SelectAll();
                        break;
                    case "X":
                        e.Handled = true;
                        btn_X_Click(null, null);
                        lbl_resultado.SelectAll();
                        break;
                    case "/":
                        e.Handled = true;
                        btn_divisao_Click(null, null);
                        lbl_resultado.SelectAll();
                        break;

                    case "\r":
                        e.Handled = true;
                        btn_igual_Click(null, null);
                        lbl_resultado.SelectAll();
                        break;

                    case "\b":
                        e.Handled = true;
                        btn_backspace_Click(null, null);
                        lbl_resultado.SelectAll();
                        break;

                    default:
                        e.Handled = true;
                        break;  

                        //colocar tabindex pra 0
                    
                }
                
            }
        }
    }
}
