using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Cartão_Crédito_Jesher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNome_Titular_TextChanged(object sender, EventArgs e)
        {
            lblNomeCartão.Text = txtNome_Titular.Text ;
        }

        private void txtNum_cartao01_TextChanged(object sender, EventArgs e)
        {
            lblNum_card01.Text = txtNum_cartao01.Text;

            int card01 = Convert.ToInt32(txtNum_cartao01.Text);

            if(card01 == 1234)
            {
                pcbBandeira.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Junho/Tarefa Revisão/visa.png");
            }
            else if (card01 == 5678)
            {
                pcbBandeira.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Junho/Tarefa Revisão/mastercard.png");
            }
            else if (card01 == 9012)
            {
                pcbBandeira.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Junho/Tarefa Revisão/elo.png");
            }            
            else
            {
                pcbBandeira.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Junho/Tarefa Revisão/american.png");
            }           
            
        }

        private void txtNum_cartao02_TextChanged(object sender, EventArgs e)
        {
            lblNum_card02.Text = txtNum_cartao02.Text;
        }

        private void txtNum_cartao03_TextChanged(object sender, EventArgs e)
        {
            lblNum_card03.Text = txtNum_cartao03.Text;
        }

        private void txtNum_cartao04_TextChanged(object sender, EventArgs e)
        {
            lblNum_card04.Text = txtNum_cartao04.Text;
        }

        private void cbbmes_SelectedIndexChanged(object sender, EventArgs e)
        {

            string mes = cbbmes.SelectedItem.ToString();           

            switch (mes)
            {
                case "01" :
                    lblval_mes.Text = mes;
                    break;

                case "02":
                    lblval_mes.Text = mes;
                    break;

                case "03":
                    lblval_mes.Text = mes;
                    break;

                case "04":
                    lblval_mes.Text = mes;
                    break;

                case "05":
                    lblval_mes.Text = mes;
                    break;

                case "06":
                    lblval_mes.Text = mes;
                    break;

                case "07":
                    lblval_mes.Text = mes;
                    break;

                case "08":
                    lblval_mes.Text = mes;
                    break;

                case "09":
                    lblval_mes.Text = mes;
                    break;

                case "10":
                    lblval_mes.Text = mes;
                    break;

                case "11":
                    lblval_mes.Text = mes;
                    break;

                case "12":
                    lblval_mes.Text = mes;
                    break;
            }

                
        }

        private void cbbano_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ano = cbbano.SelectedItem.ToString();

            switch (ano)
            {
                case "2017":
                    lblVal_ano.Text = ano;
                    break;

                case "2018":
                    lblVal_ano.Text = ano;
                    break;

                case "2019":
                    lblVal_ano.Text = ano;
                    break;

                case "2020":
                    lblVal_ano.Text = ano;
                    break;

                case "2021":
                    lblVal_ano.Text = ano;
                    break;

                case "2022":
                    lblVal_ano.Text = ano;
                    break;

                case "2023":
                    lblVal_ano.Text = ano;
                    break;

                case "2024":
                    lblVal_ano.Text = ano;
                    break;

                case "2025":
                    lblVal_ano.Text = ano;
                    break;

                case "2026":
                    lblVal_ano.Text = ano;
                    break;

                case "2027":
                    lblVal_ano.Text = ano;
                    break;

                case "2028":
                    lblVal_ano.Text = ano;
                    break;

                case "2029":
                    lblVal_ano.Text = ano;
                    break;

                case "2030":
                    lblVal_ano.Text = ano;
                    break;

                case "2031":
                    lblVal_ano.Text = ano;
                    break;

                case "2032":
                    lblVal_ano.Text = ano;
                    break;


            }
        }
       

        private void btnPagar_Click(object sender, EventArgs e)
        {
            lblpagametorealizado.Visible = true;
            lblNome_Titular.Visible = false;
            txtNome_Titular.Visible = false;
            lblNum_Cartão.Visible = false;
            txtNum_cartao01.Visible = false;
            txtNum_cartao02.Visible = false;
            txtNum_cartao03.Visible = false;
            txtNum_cartao04.Visible = false;
            lblValidade.Visible = false;
            cbbmes.Visible = false;
            cbbano.Visible = false;
            lblcvv.Visible = false;
            txtcvv.Visible = false;
            btnPagar.Visible = false;
            pcbCartão.Visible = false;
            lblNomeCartão.Visible = false;
            lblNum_card01.Visible = false;
            lblNum_card02.Visible = false;
            lblNum_card03.Visible = false;
            lblNum_card04.Visible = false;
            lblval_mes.Visible = false;
            lblVal_ano.Visible = false;
            pcbBandeira.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblpagametorealizado.Visible = false;
        }
    }
}
