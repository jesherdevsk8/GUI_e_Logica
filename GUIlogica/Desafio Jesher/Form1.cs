using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Jesher
{
    public partial class frm_Cursos : Form
    {
        public frm_Cursos()
        {
            InitializeComponent();
        }

        private void frm_Cursos_Load(object sender, EventArgs e)
        {
            mskDateTimeNow.Text = DateTime.Now.ToString();
            pcb_cursoTerminalLinux.Visible = false;
            lblNome_CursoLinux01.Visible = false;
            lblValor_curso01.Visible = false;
            //lblReais.Visible = false;
            checkboxAvista.Visible = false;
            checkboxAprazo.Visible = false;
            lblParcelas.Visible = false;
            cbb_Parcelas.Visible = false;
            lbl_valores.Visible = false;
            lblDataCompra.Visible = false;
            mskDataCompra.Visible = false;
            btnComprar.Visible = false;
            btnLimpar.Visible = false;
            lblSucesso.Visible = false;
            lblcomdesconto.Visible = false;
            lblValorParcela.Visible = false;
            lblTotal_Juros.Visible = false;
            lblprecounitario.Visible = false;
            lblTotal_Com_Juros.Visible = false;
            lblTotal_com_juros_tela.Visible = false;
            pcb_curso02.Visible = true;
            pcb_cursoAssunto02.Visible = false;
            pcb_curso03.Visible = true;
            pcb_cursoAssunto03.Visible = false;
        }

        private void pcb_Linux_curso01_Click(object sender, EventArgs e)
        {
            pcb_cursoTerminalLinux.Visible = true;
        }

        private void pcb_cursoTerminalLinux_Click(object sender, EventArgs e)
        {
            lblNome_CursoLinux01.Visible = true;
            lblValor_curso01.Visible = true;
            //lblReais.Visible = true;
            checkboxAvista.Visible = true;
            checkboxAprazo.Visible = true;
            lblParcelas.Visible = true;
            cbb_Parcelas.Visible = true;
            lbl_valores.Visible = true;            
            btnComprar.Visible = true;
            btnLimpar.Visible = true;
            lblcomdesconto.Visible = false;
            lblprecounitario.Visible = true;
            lblTotal_Com_Juros.Visible = false;
            lblTotal_com_juros_tela.Visible = false;

            if (lblValor_curso01.Visible == true && lblNome_CursoLinux01.Visible == true)
            {
                lblValor_curso01.Text = "R$ 1159,00 Reais";
                lblNome_CursoLinux01.Text = "Domine o Terminal";
            }            
            
        }

        private void checkboxAvista_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxAvista.Checked == true)
            {
                checkboxAvista.Visible = true;
                cbb_Parcelas.Visible = false;
                lblParcelas.Visible = false;
                checkboxAprazo.Checked = false;                
                lblcomdesconto.Visible = true;
                lblValorParcela.Visible = false;
                lblTotal_Juros.Visible = false;
                lblTotal_Com_Juros.Visible = false;
                lblTotal_com_juros_tela.Visible = false;
                //string Valor = "R$ 1159,00";   <-- sem desonto seria esse valor
                //lbl_valores.Text = Valor.ToString(); <-- comando para aprensentar na tela, caso fosse sem desconto
                mskDataCompra.Text = DateTime.Now.ToString();

                double resultado;
                double valor = 1159;
                // O desconto vai ser de 70%
                resultado = (valor - ((valor * 70) / 100));

                lbl_valores.Text = resultado.ToString("C");                
            }            
            
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
           if (checkboxAvista.Checked == true || checkboxAprazo.Checked == true)
            {
                lblSucesso.Visible = true;
                checkboxAprazo.Checked = false;
                lblDataCompra.Visible = true;
                mskDataCompra.Visible = true;
                mskDataCompra.Text = DateTime.Now.ToString();
                pcb_Linux_curso01.Visible = false;
                pcb_cursoTerminalLinux.Visible = false;
                lblNome_CursoLinux01.Visible = false;
                lblValor_curso01.Visible = false;
                checkboxAprazo.Visible = false;
                checkboxAvista.Visible = false;
                lbl_valores.Visible = false;
                lblcomdesconto.Visible = false;
                btnComprar.Visible = false;
                btnLimpar.Visible = false;
                lblTotal_Juros.Visible = false;
                lblValorParcela.Visible = false;
                cbb_Parcelas.Visible = false;
                lblParcelas.Visible = false;
                lblTotal_Com_Juros.Visible = false;
                lblTotal_com_juros_tela.Visible = false;
                lblprecounitario.Visible = false;
                pcb_curso02.Visible = false;
                pcb_cursoAssunto02.Visible = false;
                pcb_curso03.Visible = false;
                pcb_cursoAssunto03.Visible = false;
            }            
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblSucesso.Visible = false;
            checkboxAvista.Checked = false;
            mskDataCompra.Visible = false;            
            lbl_valores.Text = "R$ 00,00,00";
            lblcomdesconto.Visible = false;
            mskDataCompra.Text = "";
            lblValorParcela.Visible = false;
            lblTotal_Juros.Visible = false;
            checkboxAprazo.Checked = false;
            lblDataCompra.Visible = false;
            lblTotal_Com_Juros.Visible = false;
            lblTotal_com_juros_tela.Visible = false;
            cbb_Parcelas.Text = "";
        }

        private void checkboxAprazo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxAprazo.Checked == true)
            {
                cbb_Parcelas.Text = "";
                checkboxAvista.Checked = false;
                cbb_Parcelas.Visible = true;
                lblParcelas.Visible = true;
                checkboxAprazo.Checked = true;
                lbl_valores.Text = "R$ 00,00,00";
                mskDataCompra.Text = DateTime.Now.ToString();
                lblcomdesconto.Visible = false;
                lblSucesso.Visible = false;
                lblTotal_Juros.Visible = false;
                //lblValorParcela.Text = lblValor_curso01.Text;
                lblValorParcela.Visible = false;
                lblTotal_Com_Juros.Visible = true;
                lblTotal_com_juros_tela.Visible = true;

                double valorcurso = 1159;
                double valortotalcurso;
                valortotalcurso = valorcurso + (valorcurso * 30) / 100;
                lblTotal_Com_Juros.Text = valortotalcurso.ToString("C");
            }
            else if(checkboxAprazo.Checked == false)
            {
                lblTotal_Com_Juros.Visible = false;
                lblTotal_com_juros_tela.Visible = false;
                lblTotal_Juros.Visible = false;
                lblValorParcela.Visible = false;
                cbb_Parcelas.Text = "";
            }
            
        }

        private void cbb_Parcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            double valorcurso = 1159;
            double valortotalcurso;    
            
            string parcelas = cbb_Parcelas.SelectedItem.ToString();
            double parcelas_com_Juros;

            switch (parcelas)
            {
                case "1 x":
                    valortotalcurso = valorcurso + (valorcurso * 30) / 100;
                    lblTotal_Com_Juros.Text = valortotalcurso.ToString("C");
                    parcelas_com_Juros = valortotalcurso / 1;
                    lblValorParcela.Text = parcelas_com_Juros.ToString("C");
                    lblTotal_Com_Juros.Visible = true;
                    lblTotal_com_juros_tela.Visible = true;
                    lblTotal_Juros.Visible = true;                    
                    lblValorParcela.Visible = true;
                    break;

                case "2 x":
                    valortotalcurso = valorcurso + (valorcurso * 30) / 100;
                    lblTotal_Com_Juros.Text = valortotalcurso.ToString("C");
                    parcelas_com_Juros = valortotalcurso / 2;
                    lblValorParcela.Text = parcelas_com_Juros.ToString("C");
                    lblTotal_Com_Juros.Visible = true;
                    lblTotal_com_juros_tela.Visible = true;
                    lblTotal_Juros.Visible = true;
                    lblValorParcela.Visible = true;
                    break;

                case "3 x":
                    valortotalcurso = valorcurso + (valorcurso * 30) / 100;
                    lblTotal_Com_Juros.Text = valortotalcurso.ToString("C");
                    parcelas_com_Juros = valortotalcurso / 3;
                    lblValorParcela.Text = parcelas_com_Juros.ToString("C");
                    lblTotal_Com_Juros.Visible = true;
                    lblTotal_com_juros_tela.Visible = true;
                    lblTotal_Juros.Visible = true;
                    lblValorParcela.Visible = true;
                    break;

                case "4 x":
                    valortotalcurso = valorcurso + (valorcurso * 30) / 100;
                    lblTotal_Com_Juros.Text = valortotalcurso.ToString("C");
                    parcelas_com_Juros = valortotalcurso / 4;
                    lblValorParcela.Text = parcelas_com_Juros.ToString("C");
                    lblTotal_Com_Juros.Visible = true;
                    lblTotal_com_juros_tela.Visible = true;
                    lblTotal_Juros.Visible = true;
                    lblValorParcela.Visible = true;
                    break;

                case "5 x":
                    valortotalcurso = valorcurso + (valorcurso * 30) / 100;
                    lblTotal_Com_Juros.Text = valortotalcurso.ToString("C");
                    parcelas_com_Juros = valortotalcurso / 5;
                    lblValorParcela.Text = parcelas_com_Juros.ToString("C");
                    lblTotal_Com_Juros.Visible = true;
                    lblTotal_com_juros_tela.Visible = true;
                    lblTotal_Juros.Visible = true;
                    lblValorParcela.Visible = true;
                    break;

                case "6 x":
                    valortotalcurso = valorcurso + (valorcurso * 30) / 100;
                    lblTotal_Com_Juros.Text = valortotalcurso.ToString("C");
                    parcelas_com_Juros = valortotalcurso / 6;
                    lblValorParcela.Text = parcelas_com_Juros.ToString("C");
                    lblTotal_Com_Juros.Visible = true;
                    lblTotal_com_juros_tela.Visible = true;
                    lblTotal_Juros.Visible = true;
                    lblValorParcela.Visible = true;
                    break;

                case "7 x":
                    valortotalcurso = valorcurso + (valorcurso * 30) / 100;
                    lblTotal_Com_Juros.Text = valortotalcurso.ToString("C");
                    parcelas_com_Juros = valortotalcurso / 7;
                    lblValorParcela.Text = parcelas_com_Juros.ToString("C");
                    lblTotal_Com_Juros.Visible = true;
                    lblTotal_com_juros_tela.Visible = true;
                    lblTotal_Juros.Visible = true;
                    lblValorParcela.Visible = true;
                    break;

                case "8 x":
                    valortotalcurso = valorcurso + (valorcurso * 30) / 100;
                    lblTotal_Com_Juros.Text = valortotalcurso.ToString("C");
                    parcelas_com_Juros = valortotalcurso / 8;
                    lblValorParcela.Text = parcelas_com_Juros.ToString("C");
                    lblTotal_Com_Juros.Visible = true;
                    lblTotal_com_juros_tela.Visible = true;
                    lblTotal_Juros.Visible = true;
                    lblValorParcela.Visible = true;
                    break;

                case "9 x":
                    valortotalcurso = valorcurso + (valorcurso * 30) / 100;
                    lblTotal_Com_Juros.Text = valortotalcurso.ToString("C");
                    parcelas_com_Juros = valortotalcurso / 9;
                    lblValorParcela.Text = parcelas_com_Juros.ToString("C");
                    lblTotal_Com_Juros.Visible = true;
                    lblTotal_com_juros_tela.Visible = true;
                    lblTotal_Juros.Visible = true;
                    lblValorParcela.Visible = true;
                    break;

                case "10 x":
                    valortotalcurso = valorcurso + (valorcurso * 30) / 100;
                    lblTotal_Com_Juros.Text = valortotalcurso.ToString("C");
                    parcelas_com_Juros = valortotalcurso / 10;
                    lblValorParcela.Text = parcelas_com_Juros.ToString("C");
                    lblTotal_Com_Juros.Visible = true;
                    lblTotal_com_juros_tela.Visible = true;
                    lblTotal_Juros.Visible = true;
                    lblValorParcela.Visible = true;
                    break;

                case "11 x":
                    valortotalcurso = valorcurso + (valorcurso * 30) / 100;
                    lblTotal_Com_Juros.Text = valortotalcurso.ToString("C");
                    parcelas_com_Juros = valortotalcurso / 11;
                    lblValorParcela.Text = parcelas_com_Juros.ToString("C");
                    lblTotal_Com_Juros.Visible = true;
                    lblTotal_com_juros_tela.Visible = true;
                    lblTotal_Juros.Visible = true;
                    lblValorParcela.Visible = true;
                    break;

                case "12 x":
                    valortotalcurso = valorcurso + (valorcurso * 30) / 100;
                    lblTotal_Com_Juros.Text = valortotalcurso.ToString("C");
                    parcelas_com_Juros = valortotalcurso / 12;
                    lblValorParcela.Text = parcelas_com_Juros.ToString("C");
                    lblTotal_Com_Juros.Visible = true;
                    lblTotal_com_juros_tela.Visible = true;
                    lblTotal_Juros.Visible = true;
                    lblValorParcela.Visible = true;
                    break;
            }
        }

        private void pcb_curso02_Click(object sender, EventArgs e)
        {
            pcb_cursoAssunto02.Visible = true;
        }

        private void pcb_cursoAssunto02_Click(object sender, EventArgs e)
        {
            lblNome_CursoLinux01.Visible = true;
            lblValor_curso01.Visible = true;
            //lblReais.Visible = true;
            checkboxAvista.Visible = true;
            checkboxAprazo.Visible = true;
            lblParcelas.Visible = true;
            cbb_Parcelas.Visible = true;
            lbl_valores.Visible = true;
            btnComprar.Visible = true;
            btnLimpar.Visible = true;
            lblcomdesconto.Visible = false;
            lblprecounitario.Visible = true;
            lblTotal_Com_Juros.Visible = false;
            lblTotal_com_juros_tela.Visible = false;

            if (lblValor_curso01.Visible == true && lblNome_CursoLinux01.Visible == true)
            {
                lblValor_curso01.Text = "R$ 1159,00 Reais";
                lblNome_CursoLinux01.Text = "Windows PowerShell";
            }
        }

        private void pcb_curso03_Click(object sender, EventArgs e)
        {
            pcb_cursoAssunto03.Visible = true;
        }

        private void pcb_cursoAssunto03_Click(object sender, EventArgs e)
        {
            lblNome_CursoLinux01.Visible = true;
            lblValor_curso01.Visible = true;
            //lblReais.Visible = true;
            checkboxAvista.Visible = true;
            checkboxAprazo.Visible = true;
            lblParcelas.Visible = true;
            cbb_Parcelas.Visible = true;
            lbl_valores.Visible = true;
            btnComprar.Visible = true;
            btnLimpar.Visible = true;
            lblcomdesconto.Visible = false;
            lblprecounitario.Visible = true;
            lblTotal_Com_Juros.Visible = false;
            lblTotal_com_juros_tela.Visible = false;

            if (lblValor_curso01.Visible == true && lblNome_CursoLinux01.Visible == true)
            {
                lblValor_curso01.Text = "R$ 1159,00 Reais";
                lblNome_CursoLinux01.Text = "Unix Bash";
            }
        }
    }
}