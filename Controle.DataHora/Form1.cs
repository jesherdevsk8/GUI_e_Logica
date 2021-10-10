using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle.DataHora
{
    
    public partial class Form : System.Windows.Forms.Form
    {

        public Form()
        {
            InitializeComponent();
        }

        public void calcularImposto()
        {
            //declarando variáveis
            string empresa = cbbempresas.SelectedItem.ToString();
            decimal valor_total = decimal.Parse(txtValorcompra.Text);

            //calculando inicio variável imposto
            decimal desconto = 0;
            decimal valor_com_desconto;

            
            if (valor_total == 0)
            {
                desconto = 0;
            }            
            else{
                switch (empresa)
                {
                    case "Amazon":
                        desconto = 5;
                        break;

                    case "Submarino":
                        desconto = 6;
                        break;

                    case "Mercado Livre":
                        desconto = 7;
                        break;

                    case "Americanas":
                        desconto = 8;
                        break;

                    case "Magalu":
                        desconto = 3;
                        break;

                    case "Jesher Store":
                        desconto = 10;
                        break;

                    default:
                        desconto = 0;
                        break;
                }
            }           

            //calculo

            valor_com_desconto = (valor_total - ((valor_total * desconto)/100));

            lblvalorcoimposto.Text = valor_com_desconto.ToString("C");
        }

        public void limparCampos()
        {
            //cbbempresas.SelectedValue = string.Empty;
            cbbempresas.Text = string.Empty;
            txtValorcompra.Text = string.Empty;
            lblvalorcoimposto.Text = string.Empty;
        }

        public void valorProdutos()
        {
            decimal valores = 0;
            decimal parcelas = 0;
            string produtos = cbbprodutos.SelectedItem.ToString();
            string valor_das_parcelas = cbbparcelas.SelectedItem.ToString();


            switch (cbbprodutos.SelectedItem.ToString())
            {
                case "Smart TV 43":
                    valores = 2999;
                    break;

                case "Sofá Retrátil":
                    valores = 1540;
                    break;

                case "ControlePs4":
                    valores = 249;
                    break;

                case "ControlePs5":
                    valores = 459;
                    break;

                case "Playstation 4":
                    valores = 2784;
                    break;

                case "Playstation 5":
                    valores = 4599;
                    break;

            }

            lblValorProduto.Text = valores.ToString("C");


            switch (cbbparcelas.SelectedItem.ToString())
            {
                case "1 X":
                    lblValorProduto.Text = valores.ToString("C");
                    parcelas = valores / 1;
                    break;

                case "2 X":
                    lblValorProduto.Text = valores.ToString("C");
                    parcelas = valores / 2;
                    break;

                case "3 X":
                    lblValorProduto.Text = valores.ToString("C");
                    parcelas = valores / 3;
                    break;

                case "4 X":
                    lblValorProduto.Text = valores.ToString("C");
                    parcelas = valores / 4;
                    break;

                case "5 X":
                    lblValorProduto.Text = valores.ToString("C");
                    parcelas = valores / 5;
                    break;

                case "6 X":
                    lblValorProduto.Text = valores.ToString("C");
                    parcelas = valores / 6;
                    break;

                case "7 X":
                    lblValorProduto.Text = valores.ToString("C");
                    parcelas = valores / 7;
                    break;

                case "8 X":
                    lblValorProduto.Text = valores.ToString("C");
                    parcelas = valores / 8;
                    break;

                case "9 X":
                    lblValorProduto.Text = valores.ToString("C");
                    parcelas = valores / 9;
                    break;

                case "10 X":
                    lblValorProduto.Text = valores.ToString("C");
                    parcelas = valores / 10;
                    break;

                case "11 X":
                    lblValorProduto.Text = valores.ToString("C");
                    parcelas = valores / 11;
                    break;

                case "12 X":
                    lblValorProduto.Text = valores.ToString("C");
                    parcelas = valores / 12;
                    break;
            }

            lblvalorparcelas.Text = parcelas.ToString("C");

        }        

        private void btnCalcular1_Click(object sender, EventArgs e)
        {
            calcularImposto();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }


        private void btnValorProdutos_Click(object sender, EventArgs e)
        {
            valorProdutos();            
        }

        private void mskDataHoraCompra_Click(object sender, EventArgs e)
        {
            mskDataHoraCompra.Text = DateTime.Now.ToString();
        }

        private void btncalculardias_Click(object sender, EventArgs e)
        {
            DateTime data_compra = DateTime.Now;
            DateTime data_pagamento;
            TimeSpan resultado;

            data_pagamento = DateTime.Parse(mskDataHoraPagamento.Text);
            data_compra = DateTime.Parse(mskDataHoraCompra.Text);

            resultado = data_pagamento - data_compra;

            txtTotaldias.Text = resultado.TotalDays.ToString();
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            double dias_arredondados;
            string jurosString = "";
            double juros = 0;
            double valor_com_acrescimo;
            double valor_Total;

            valor_Total = double.Parse(txtvalorparacalculo.Text);
            dias_arredondados = double.Parse(txtdiasarredodados.Text);

            if (dias_arredondados < 30)
            {
                juros = 0;
                valor_com_acrescimo = valor_Total;
                lblValorParcelacomAcrescimo.Text = valor_com_acrescimo.ToString("C");
            }
            else if ((dias_arredondados >= 30) && (dias_arredondados < 60)) 
            {
                juros = 8;
                valor_com_acrescimo = valor_Total + (valor_Total * juros) / 100;
                lblValorParcelacomAcrescimo.Text = valor_com_acrescimo.ToString("C");
            }
            else if ((dias_arredondados >= 60) && (dias_arredondados < 90))
            {
                juros = 16;
                valor_com_acrescimo = valor_Total + (valor_Total * juros) / 100;
                lblValorParcelacomAcrescimo.Text = valor_com_acrescimo.ToString("C");
            }
            else if ((dias_arredondados >= 90) && (dias_arredondados < 120))
            {
                juros = 24;
                valor_com_acrescimo = valor_Total + (valor_Total * juros) / 100;
                lblValorParcelacomAcrescimo.Text = valor_com_acrescimo.ToString("C");
            }
            else if (dias_arredondados > 120)
            {
                jurosString = "PROTESTADO";
                lblValorParcelacomAcrescimo.Text = jurosString.ToString();
            }
        }

        private void btnLimparParcelas_Click(object sender, EventArgs e)
        {
            txtdiasarredodados.Text = "";
            txtvalorparacalculo.Text = "";
            txtTotaldias.Text = "";
            mskDataHoraCompra.Text = "";
            mskDataHoraPagamento.Text = "";
            lblValorParcelacomAcrescimo.Text = "";
            cbbprodutos.Text = "";      //funciona dessa forma
            cbbparcelas.Text = String.Empty;
            lblValorProduto.Text = String.Empty; //tbm funciona dessa forma
            lblvalorparcelas.Text = String.Empty;
            
        }
    }
}
