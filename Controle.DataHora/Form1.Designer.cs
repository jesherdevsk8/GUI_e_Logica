
namespace Controle.DataHora
{
    partial class Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProcureEmpresa = new System.Windows.Forms.Label();
            this.cbbempresas = new System.Windows.Forms.ComboBox();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.txtValorcompra = new System.Windows.Forms.TextBox();
            this.btnCalcular1 = new System.Windows.Forms.Button();
            this.lblvalorcoimposto = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblvalorcomimposto = new System.Windows.Forms.Label();
            this.cbbparcelas = new System.Windows.Forms.ComboBox();
            this.lblparcelas = new System.Windows.Forms.Label();
            this.lblproduto = new System.Windows.Forms.Label();
            this.cbbprodutos = new System.Windows.Forms.ComboBox();
            this.btnValorProdutos = new System.Windows.Forms.Button();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.lblvalorparcelas = new System.Windows.Forms.Label();
            this.lblecmdàvista = new System.Windows.Forms.Label();
            this.lblescolhaproduto = new System.Windows.Forms.Label();
            this.mskDataHoraCompra = new System.Windows.Forms.MaskedTextBox();
            this.lbldahorainicio = new System.Windows.Forms.Label();
            this.mskDataHoraPagamento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncalculardias = new System.Windows.Forms.Button();
            this.txtTotaldias = new System.Windows.Forms.TextBox();
            this.lbldias = new System.Windows.Forms.Label();
            this.lblValorParcelacomAcrescimo = new System.Windows.Forms.Label();
            this.lblvalorcomacrescimoTitulo = new System.Windows.Forms.Label();
            this.txtdiasarredodados = new System.Windows.Forms.TextBox();
            this.lblentrecomquantidadededias = new System.Windows.Forms.Label();
            this.btnpagar = new System.Windows.Forms.Button();
            this.txtvalorparacalculo = new System.Windows.Forms.TextBox();
            this.lblvalortotalcalculo = new System.Windows.Forms.Label();
            this.btnLimparParcelas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProcureEmpresa
            // 
            this.lblProcureEmpresa.AutoSize = true;
            this.lblProcureEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblProcureEmpresa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcureEmpresa.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblProcureEmpresa.Location = new System.Drawing.Point(95, 253);
            this.lblProcureEmpresa.Name = "lblProcureEmpresa";
            this.lblProcureEmpresa.Size = new System.Drawing.Size(88, 25);
            this.lblProcureEmpresa.TabIndex = 0;
            this.lblProcureEmpresa.Text = "Procure:";
            // 
            // cbbempresas
            // 
            this.cbbempresas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbempresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbempresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbempresas.FormattingEnabled = true;
            this.cbbempresas.Items.AddRange(new object[] {
            "Amazon",
            "Submarino",
            "Mercado Livre",
            "Americanas",
            "Magalu",
            "Jesher Store"});
            this.cbbempresas.Location = new System.Drawing.Point(202, 246);
            this.cbbempresas.Name = "cbbempresas";
            this.cbbempresas.Size = new System.Drawing.Size(172, 32);
            this.cbbempresas.TabIndex = 1;
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblValorCompra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblValorCompra.Location = new System.Drawing.Point(113, 292);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(107, 21);
            this.lblValorCompra.TabIndex = 2;
            this.lblValorCompra.Text = "Valor à vista:";
            // 
            // txtValorcompra
            // 
            this.txtValorcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorcompra.Location = new System.Drawing.Point(226, 284);
            this.txtValorcompra.Name = "txtValorcompra";
            this.txtValorcompra.Size = new System.Drawing.Size(132, 29);
            this.txtValorcompra.TabIndex = 3;
            // 
            // btnCalcular1
            // 
            this.btnCalcular1.BackColor = System.Drawing.Color.Coral;
            this.btnCalcular1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCalcular1.Location = new System.Drawing.Point(158, 324);
            this.btnCalcular1.Name = "btnCalcular1";
            this.btnCalcular1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnCalcular1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCalcular1.Size = new System.Drawing.Size(85, 29);
            this.btnCalcular1.TabIndex = 4;
            this.btnCalcular1.Text = "Calcular";
            this.btnCalcular1.UseVisualStyleBackColor = false;
            this.btnCalcular1.Click += new System.EventHandler(this.btnCalcular1_Click);
            // 
            // lblvalorcoimposto
            // 
            this.lblvalorcoimposto.AutoSize = true;
            this.lblvalorcoimposto.BackColor = System.Drawing.Color.Red;
            this.lblvalorcoimposto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblvalorcoimposto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorcoimposto.ForeColor = System.Drawing.Color.White;
            this.lblvalorcoimposto.Location = new System.Drawing.Point(262, 358);
            this.lblvalorcoimposto.Name = "lblvalorcoimposto";
            this.lblvalorcoimposto.Size = new System.Drawing.Size(129, 27);
            this.lblvalorcoimposto.TabIndex = 5;
            this.lblvalorcoimposto.Text = "R$ 0.0000,00";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnLimpar.Location = new System.Drawing.Point(251, 324);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnLimpar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLimpar.Size = new System.Drawing.Size(74, 29);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblvalorcomimposto
            // 
            this.lblvalorcomimposto.AutoSize = true;
            this.lblvalorcomimposto.BackColor = System.Drawing.Color.Transparent;
            this.lblvalorcomimposto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorcomimposto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblvalorcomimposto.Location = new System.Drawing.Point(89, 364);
            this.lblvalorcomimposto.Name = "lblvalorcomimposto";
            this.lblvalorcomimposto.Size = new System.Drawing.Size(167, 21);
            this.lblvalorcomimposto.TabIndex = 8;
            this.lblvalorcomimposto.Text = "Valor com Desconto:";
            // 
            // cbbparcelas
            // 
            this.cbbparcelas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbparcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbparcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbparcelas.FormattingEnabled = true;
            this.cbbparcelas.Items.AddRange(new object[] {
            "1 X",
            "2 X",
            "3 X",
            "4 X",
            "5 X",
            "6 X",
            "7 X",
            "8 X",
            "9 X",
            "10 X",
            "11 X",
            "12 X"});
            this.cbbparcelas.Location = new System.Drawing.Point(128, 128);
            this.cbbparcelas.Name = "cbbparcelas";
            this.cbbparcelas.Size = new System.Drawing.Size(172, 32);
            this.cbbparcelas.TabIndex = 9;
            // 
            // lblparcelas
            // 
            this.lblparcelas.AutoSize = true;
            this.lblparcelas.BackColor = System.Drawing.Color.Transparent;
            this.lblparcelas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblparcelas.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblparcelas.Location = new System.Drawing.Point(39, 136);
            this.lblparcelas.Name = "lblparcelas";
            this.lblparcelas.Size = new System.Drawing.Size(77, 21);
            this.lblparcelas.TabIndex = 10;
            this.lblparcelas.Text = "Parcelas:";
            // 
            // lblproduto
            // 
            this.lblproduto.AutoSize = true;
            this.lblproduto.BackColor = System.Drawing.Color.Transparent;
            this.lblproduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblproduto.Location = new System.Drawing.Point(39, 93);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(76, 21);
            this.lblproduto.TabIndex = 12;
            this.lblproduto.Text = "Produto:";
            // 
            // cbbprodutos
            // 
            this.cbbprodutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbprodutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbprodutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbprodutos.FormattingEnabled = true;
            this.cbbprodutos.Items.AddRange(new object[] {
            "Smart TV 43",
            "Sofá Retrátil",
            "ControlePs4",
            "ControlePs5",
            "Playstation 4",
            "Playstation 5"});
            this.cbbprodutos.Location = new System.Drawing.Point(128, 85);
            this.cbbprodutos.Name = "cbbprodutos";
            this.cbbprodutos.Size = new System.Drawing.Size(172, 32);
            this.cbbprodutos.TabIndex = 11;
            // 
            // btnValorProdutos
            // 
            this.btnValorProdutos.BackColor = System.Drawing.Color.Coral;
            this.btnValorProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValorProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValorProdutos.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnValorProdutos.Location = new System.Drawing.Point(315, 160);
            this.btnValorProdutos.Name = "btnValorProdutos";
            this.btnValorProdutos.Padding = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnValorProdutos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnValorProdutos.Size = new System.Drawing.Size(110, 29);
            this.btnValorProdutos.TabIndex = 13;
            this.btnValorProdutos.Text = "Calcular";
            this.btnValorProdutos.UseVisualStyleBackColor = false;
            this.btnValorProdutos.Click += new System.EventHandler(this.btnValorProdutos_Click);
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.BackColor = System.Drawing.Color.Red;
            this.lblValorProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorProduto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorProduto.ForeColor = System.Drawing.Color.White;
            this.lblValorProduto.Location = new System.Drawing.Point(306, 90);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(129, 27);
            this.lblValorProduto.TabIndex = 14;
            this.lblValorProduto.Text = "R$ 0.0000,00";
            // 
            // lblvalorparcelas
            // 
            this.lblvalorparcelas.AutoSize = true;
            this.lblvalorparcelas.BackColor = System.Drawing.Color.Red;
            this.lblvalorparcelas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblvalorparcelas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorparcelas.ForeColor = System.Drawing.Color.White;
            this.lblvalorparcelas.Location = new System.Drawing.Point(306, 130);
            this.lblvalorparcelas.Name = "lblvalorparcelas";
            this.lblvalorparcelas.Size = new System.Drawing.Size(129, 27);
            this.lblvalorparcelas.TabIndex = 16;
            this.lblvalorparcelas.Text = "R$ 0.0000,00";
            // 
            // lblecmdàvista
            // 
            this.lblecmdàvista.AutoSize = true;
            this.lblecmdàvista.BackColor = System.Drawing.Color.Transparent;
            this.lblecmdàvista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblecmdàvista.ForeColor = System.Drawing.Color.Black;
            this.lblecmdàvista.Location = new System.Drawing.Point(89, 222);
            this.lblecmdàvista.Name = "lblecmdàvista";
            this.lblecmdàvista.Size = new System.Drawing.Size(298, 21);
            this.lblecmdàvista.TabIndex = 17;
            this.lblecmdàvista.Text = "Empresa com melhor desconto à vista";
            // 
            // lblescolhaproduto
            // 
            this.lblescolhaproduto.AutoSize = true;
            this.lblescolhaproduto.BackColor = System.Drawing.Color.Transparent;
            this.lblescolhaproduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblescolhaproduto.ForeColor = System.Drawing.Color.Black;
            this.lblescolhaproduto.Location = new System.Drawing.Point(152, 53);
            this.lblescolhaproduto.Name = "lblescolhaproduto";
            this.lblescolhaproduto.Size = new System.Drawing.Size(148, 21);
            this.lblescolhaproduto.TabIndex = 18;
            this.lblescolhaproduto.Text = "Escolha o Produto";
            // 
            // mskDataHoraCompra
            // 
            this.mskDataHoraCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataHoraCompra.Location = new System.Drawing.Point(574, 83);
            this.mskDataHoraCompra.Mask = "00/00/0000 90:00";
            this.mskDataHoraCompra.Name = "mskDataHoraCompra";
            this.mskDataHoraCompra.Size = new System.Drawing.Size(100, 20);
            this.mskDataHoraCompra.TabIndex = 19;
            this.mskDataHoraCompra.ValidatingType = typeof(System.DateTime);
            this.mskDataHoraCompra.Click += new System.EventHandler(this.mskDataHoraCompra_Click);
            // 
            // lbldahorainicio
            // 
            this.lbldahorainicio.AutoSize = true;
            this.lbldahorainicio.BackColor = System.Drawing.Color.Transparent;
            this.lbldahorainicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldahorainicio.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbldahorainicio.Location = new System.Drawing.Point(568, 66);
            this.lbldahorainicio.Name = "lbldahorainicio";
            this.lbldahorainicio.Size = new System.Drawing.Size(113, 15);
            this.lbldahorainicio.TabIndex = 20;
            this.lbldahorainicio.Text = "Data/Hora/Compra";
            // 
            // mskDataHoraPagamento
            // 
            this.mskDataHoraPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataHoraPagamento.Location = new System.Drawing.Point(574, 123);
            this.mskDataHoraPagamento.Mask = "00/00/0000 90:00";
            this.mskDataHoraPagamento.Name = "mskDataHoraPagamento";
            this.mskDataHoraPagamento.Size = new System.Drawing.Size(100, 20);
            this.mskDataHoraPagamento.TabIndex = 21;
            this.mskDataHoraPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(559, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Data/Hora/Pagamento";
            // 
            // btncalculardias
            // 
            this.btncalculardias.BackColor = System.Drawing.Color.Gold;
            this.btncalculardias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalculardias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculardias.ForeColor = System.Drawing.Color.Black;
            this.btncalculardias.Location = new System.Drawing.Point(569, 147);
            this.btncalculardias.Name = "btncalculardias";
            this.btncalculardias.Padding = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btncalculardias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btncalculardias.Size = new System.Drawing.Size(109, 29);
            this.btncalculardias.TabIndex = 23;
            this.btncalculardias.Text = "Calcular Dias";
            this.btncalculardias.UseVisualStyleBackColor = false;
            this.btncalculardias.Click += new System.EventHandler(this.btncalculardias_Click);
            // 
            // txtTotaldias
            // 
            this.txtTotaldias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotaldias.Location = new System.Drawing.Point(577, 182);
            this.txtTotaldias.Name = "txtTotaldias";
            this.txtTotaldias.Size = new System.Drawing.Size(63, 22);
            this.txtTotaldias.TabIndex = 24;
            // 
            // lbldias
            // 
            this.lbldias.AutoSize = true;
            this.lbldias.BackColor = System.Drawing.Color.Transparent;
            this.lbldias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldias.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbldias.Location = new System.Drawing.Point(642, 187);
            this.lbldias.Name = "lbldias";
            this.lbldias.Size = new System.Drawing.Size(33, 17);
            this.lbldias.TabIndex = 25;
            this.lbldias.Text = "dias";
            // 
            // lblValorParcelacomAcrescimo
            // 
            this.lblValorParcelacomAcrescimo.AutoSize = true;
            this.lblValorParcelacomAcrescimo.BackColor = System.Drawing.Color.Gold;
            this.lblValorParcelacomAcrescimo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorParcelacomAcrescimo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcelacomAcrescimo.ForeColor = System.Drawing.Color.Black;
            this.lblValorParcelacomAcrescimo.Location = new System.Drawing.Point(562, 325);
            this.lblValorParcelacomAcrescimo.Name = "lblValorParcelacomAcrescimo";
            this.lblValorParcelacomAcrescimo.Size = new System.Drawing.Size(129, 27);
            this.lblValorParcelacomAcrescimo.TabIndex = 26;
            this.lblValorParcelacomAcrescimo.Text = "R$ 0.0000,00";
            // 
            // lblvalorcomacrescimoTitulo
            // 
            this.lblvalorcomacrescimoTitulo.AutoSize = true;
            this.lblvalorcomacrescimoTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblvalorcomacrescimoTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorcomacrescimoTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblvalorcomacrescimoTitulo.Location = new System.Drawing.Point(532, 304);
            this.lblvalorcomacrescimoTitulo.Name = "lblvalorcomacrescimoTitulo";
            this.lblvalorcomacrescimoTitulo.Size = new System.Drawing.Size(183, 15);
            this.lblvalorcomacrescimoTitulo.TabIndex = 27;
            this.lblvalorcomacrescimoTitulo.Text = "Valor da Parcela com acréscimo:";
            // 
            // txtdiasarredodados
            // 
            this.txtdiasarredodados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiasarredodados.Location = new System.Drawing.Point(553, 274);
            this.txtdiasarredodados.Name = "txtdiasarredodados";
            this.txtdiasarredodados.Size = new System.Drawing.Size(63, 22);
            this.txtdiasarredodados.TabIndex = 28;
            // 
            // lblentrecomquantidadededias
            // 
            this.lblentrecomquantidadededias.AutoSize = true;
            this.lblentrecomquantidadededias.BackColor = System.Drawing.Color.Transparent;
            this.lblentrecomquantidadededias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentrecomquantidadededias.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblentrecomquantidadededias.Location = new System.Drawing.Point(532, 250);
            this.lblentrecomquantidadededias.Name = "lblentrecomquantidadededias";
            this.lblentrecomquantidadededias.Size = new System.Drawing.Size(182, 15);
            this.lblentrecomquantidadededias.TabIndex = 29;
            this.lblentrecomquantidadededias.Text = "Entre com a quantidade de dias:";
            // 
            // btnpagar
            // 
            this.btnpagar.BackColor = System.Drawing.Color.Black;
            this.btnpagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar.ForeColor = System.Drawing.Color.White;
            this.btnpagar.Location = new System.Drawing.Point(625, 270);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Padding = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnpagar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnpagar.Size = new System.Drawing.Size(58, 29);
            this.btnpagar.TabIndex = 30;
            this.btnpagar.Text = "Pagar";
            this.btnpagar.UseVisualStyleBackColor = false;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // txtvalorparacalculo
            // 
            this.txtvalorparacalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorparacalculo.Location = new System.Drawing.Point(627, 221);
            this.txtvalorparacalculo.Name = "txtvalorparacalculo";
            this.txtvalorparacalculo.Size = new System.Drawing.Size(88, 22);
            this.txtvalorparacalculo.TabIndex = 31;
            // 
            // lblvalortotalcalculo
            // 
            this.lblvalortotalcalculo.AutoSize = true;
            this.lblvalortotalcalculo.BackColor = System.Drawing.Color.Transparent;
            this.lblvalortotalcalculo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalortotalcalculo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblvalortotalcalculo.Location = new System.Drawing.Point(527, 225);
            this.lblvalortotalcalculo.Name = "lblvalortotalcalculo";
            this.lblvalortotalcalculo.Size = new System.Drawing.Size(97, 15);
            this.lblvalortotalcalculo.TabIndex = 32;
            this.lblvalortotalcalculo.Text = "Valor da Parcela:";
            // 
            // btnLimparParcelas
            // 
            this.btnLimparParcelas.BackColor = System.Drawing.Color.Gray;
            this.btnLimparParcelas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparParcelas.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnLimparParcelas.Location = new System.Drawing.Point(585, 357);
            this.btnLimparParcelas.Name = "btnLimparParcelas";
            this.btnLimparParcelas.Padding = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnLimparParcelas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLimparParcelas.Size = new System.Drawing.Size(74, 29);
            this.btnLimparParcelas.TabIndex = 33;
            this.btnLimparParcelas.Text = "Limpar";
            this.btnLimparParcelas.UseVisualStyleBackColor = false;
            this.btnLimparParcelas.Click += new System.EventHandler(this.btnLimparParcelas_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimparParcelas);
            this.Controls.Add(this.lblvalortotalcalculo);
            this.Controls.Add(this.txtvalorparacalculo);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.lblentrecomquantidadededias);
            this.Controls.Add(this.txtdiasarredodados);
            this.Controls.Add(this.lblvalorcomacrescimoTitulo);
            this.Controls.Add(this.lblValorParcelacomAcrescimo);
            this.Controls.Add(this.lbldias);
            this.Controls.Add(this.txtTotaldias);
            this.Controls.Add(this.btncalculardias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskDataHoraPagamento);
            this.Controls.Add(this.lbldahorainicio);
            this.Controls.Add(this.mskDataHoraCompra);
            this.Controls.Add(this.lblescolhaproduto);
            this.Controls.Add(this.lblecmdàvista);
            this.Controls.Add(this.lblvalorparcelas);
            this.Controls.Add(this.lblValorProduto);
            this.Controls.Add(this.btnValorProdutos);
            this.Controls.Add(this.lblproduto);
            this.Controls.Add(this.cbbprodutos);
            this.Controls.Add(this.lblparcelas);
            this.Controls.Add(this.cbbparcelas);
            this.Controls.Add(this.lblvalorcomimposto);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblvalorcoimposto);
            this.Controls.Add(this.btnCalcular1);
            this.Controls.Add(this.txtValorcompra);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.cbbempresas);
            this.Controls.Add(this.lblProcureEmpresa);
            this.Name = "Form";
            this.Text = "Controle de Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcureEmpresa;
        private System.Windows.Forms.ComboBox cbbempresas;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.TextBox txtValorcompra;
        private System.Windows.Forms.Button btnCalcular1;
        private System.Windows.Forms.Label lblvalorcoimposto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblvalorcomimposto;
        private System.Windows.Forms.ComboBox cbbparcelas;
        private System.Windows.Forms.Label lblparcelas;
        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.ComboBox cbbprodutos;
        private System.Windows.Forms.Button btnValorProdutos;
        private System.Windows.Forms.Label lblValorProduto;
        private System.Windows.Forms.Label lblvalorparcelas;
        private System.Windows.Forms.Label lblecmdàvista;
        private System.Windows.Forms.Label lblescolhaproduto;
        private System.Windows.Forms.MaskedTextBox mskDataHoraCompra;
        private System.Windows.Forms.Label lbldahorainicio;
        private System.Windows.Forms.MaskedTextBox mskDataHoraPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalculardias;
        private System.Windows.Forms.TextBox txtTotaldias;
        private System.Windows.Forms.Label lbldias;
        private System.Windows.Forms.Label lblValorParcelacomAcrescimo;
        private System.Windows.Forms.Label lblvalorcomacrescimoTitulo;
        private System.Windows.Forms.TextBox txtdiasarredodados;
        private System.Windows.Forms.Label lblentrecomquantidadededias;
        private System.Windows.Forms.Button btnpagar;
        private System.Windows.Forms.TextBox txtvalorparacalculo;
        private System.Windows.Forms.Label lblvalortotalcalculo;
        private System.Windows.Forms.Button btnLimparParcelas;
    }
}

