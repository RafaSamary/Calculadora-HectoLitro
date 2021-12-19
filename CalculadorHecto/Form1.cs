using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadorHecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        private void btn_calcular_Click(object sender, EventArgs e)

        {   // variaveis  e calculo do fator de hecto litro e mostra no campo fator
            double fator, meta, real;
            meta = Convert.ToDouble(txt_meta.Text); // coverte txtBox em double(numeros)
            real = Convert.ToDouble(txt_real.Text);               
            fator = Convert.ToDouble(cb_embalagem.Text) / 100 * Convert.ToDouble(cb_quant.Text);

            txt_fator.Text = fator.ToString();
            txt_fator.ForeColor = Color.Firebrick;

            //  calculo  e mostra 70% da meta
            double meta70;
            meta70 = meta * 0.7 - real;
            txt_70.Text = meta70.ToString();

            // calculo  e mostra 70% da meta em caixas
            double caixa70;
            caixa70 = meta70 / fator;
           
            caixa70 = Math.Ceiling(caixa70); // arredondamento 
            txt_70cx.Text = caixa70.ToString();
            txt_70cx.ForeColor = Color.Firebrick;

            // calculo  e mostra 100% da meta
            double meta100;
            meta100 = meta - real;
            txt_100.Text = meta100.ToString();

            // calculo  e mostra 100% da meta em caixas
            double caixa100;
            caixa100 = meta100 / fator;

            caixa100 = Math.Ceiling(caixa100); // arredondamento
            txt_100cx.Text = caixa100.ToString();
            txt_100cx.ForeColor = Color.Firebrick;





        }

        private void txt_meta_TextChanged(object sender, EventArgs e)
        {
            txt_meta.ForeColor = Color.Green;



        }

        private void txt_real_TextChanged(object sender, EventArgs e)
        {
            txt_real.ForeColor = Color.Green;

        }

        private void btb_limpar_Click(object sender, EventArgs e)
        {
            cb_embalagem.SelectedIndex = -1;
            cb_quant.SelectedIndex = -1;



            txt_meta.Clear();
            txt_real.Clear();
            txt_70.Clear();
            txt_70cx.Clear();
            txt_100.Clear();
            txt_100cx.Clear();
            txt_fator.Clear();

            


        }
    }

}
  


 