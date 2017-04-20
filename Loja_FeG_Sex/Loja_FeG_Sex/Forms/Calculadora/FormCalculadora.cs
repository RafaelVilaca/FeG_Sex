using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms.Calculadora
{
    public partial class FormCalculadora : Form
    {
        Operacoes metodo = new Operacoes();
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txt_n1.Text);
                double res = Convert.ToDouble(txt_result.Text);
                txt_result.Text = (metodo.Soma(n1, res)).ToString();
                txt_n1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Numero Incorreto \nCorrija por favor");
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_n1.Text = "";
            txt_result.Text = "0";
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            txt_result.Text = "0";
        }

        private void btn_Um_Click(object sender, EventArgs e)
        {
            txt_n1.Text = (txt_n1.Text + "1");
        }

        private void btn_Quatro_Click(object sender, EventArgs e)
        {
            txt_n1.Text = (txt_n1.Text + "4");
        }

        private void btn_Sete_Click(object sender, EventArgs e)
        {
            txt_n1.Text = (txt_n1.Text + "7");
        }

        private void btn_Dois_Click(object sender, EventArgs e)
        {
            txt_n1.Text = (txt_n1.Text + "2");
        }

        private void btn_Cinco_Click(object sender, EventArgs e)
        {
            txt_n1.Text = (txt_n1.Text + "5");
        }

        private void btn_Oito_Click(object sender, EventArgs e)
        {
            txt_n1.Text = (txt_n1.Text + "8");
        }

        private void btn_Tres_Click(object sender, EventArgs e)
        {
            txt_n1.Text = (txt_n1.Text + "3");
        }

        private void btn_Seis_Click(object sender, EventArgs e)
        {
            txt_n1.Text = (txt_n1.Text + "6");
        }

        private void btn_Nove_Click(object sender, EventArgs e)
        {
            txt_n1.Text = (txt_n1.Text + "9");
        }

        private void btn_Zero_Click(object sender, EventArgs e)
        {
            txt_n1.Text = (txt_n1.Text + "0");
        }

        private void btn_Virgula_Click(object sender, EventArgs e)
        {
            txt_n1.Text = (txt_n1.Text + ",");
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txt_n1.Text);
                double res = Convert.ToDouble(txt_result.Text);
                txt_result.Text = (metodo.Subtracao(n1, res)).ToString();
                txt_n1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Numero Incorreto \nCorrija por favor");
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txt_n1.Text);
                double res = Convert.ToDouble(txt_result.Text);
                txt_result.Text = (metodo.Divisao(n1, res)).ToString();
                txt_n1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Numero Incorreto \nCorrija por favor");
            }
        }

        private void btn_vezes_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txt_n1.Text);
                double res = Convert.ToDouble(txt_result.Text);
                txt_result.Text = (metodo.Multi(n1, res)).ToString();
                txt_n1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Numero Incorreto \nCorrija por favor");
            }
        }
    }
}
