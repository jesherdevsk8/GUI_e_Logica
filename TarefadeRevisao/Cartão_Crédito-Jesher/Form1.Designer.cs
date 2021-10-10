
namespace Cartão_Crédito_Jesher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNome_Titular = new System.Windows.Forms.Label();
            this.lblNum_Cartão = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.pcbCartão = new System.Windows.Forms.PictureBox();
            this.txtNome_Titular = new System.Windows.Forms.TextBox();
            this.txtNum_cartao01 = new System.Windows.Forms.TextBox();
            this.txtNum_cartao02 = new System.Windows.Forms.TextBox();
            this.txtNum_cartao03 = new System.Windows.Forms.TextBox();
            this.txtNum_cartao04 = new System.Windows.Forms.TextBox();
            this.cbbmes = new System.Windows.Forms.ComboBox();
            this.cbbano = new System.Windows.Forms.ComboBox();
            this.txtcvv = new System.Windows.Forms.TextBox();
            this.lblcvv = new System.Windows.Forms.Label();
            this.lblNum_card01 = new System.Windows.Forms.Label();
            this.lblNum_card02 = new System.Windows.Forms.Label();
            this.lblNum_card03 = new System.Windows.Forms.Label();
            this.lblNum_card04 = new System.Windows.Forms.Label();
            this.lblval_mes = new System.Windows.Forms.Label();
            this.lblVal_ano = new System.Windows.Forms.Label();
            this.pcbBandeira = new System.Windows.Forms.PictureBox();
            this.lblNomeCartão = new System.Windows.Forms.Label();
            this.lblpagametorealizado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCartão)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBandeira)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome_Titular
            // 
            this.lblNome_Titular.AutoSize = true;
            this.lblNome_Titular.BackColor = System.Drawing.Color.Transparent;
            this.lblNome_Titular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_Titular.ForeColor = System.Drawing.Color.White;
            this.lblNome_Titular.Location = new System.Drawing.Point(25, 66);
            this.lblNome_Titular.Name = "lblNome_Titular";
            this.lblNome_Titular.Size = new System.Drawing.Size(128, 17);
            this.lblNome_Titular.TabIndex = 0;
            this.lblNome_Titular.Text = "NOME DO TITULAR";
            // 
            // lblNum_Cartão
            // 
            this.lblNum_Cartão.AutoSize = true;
            this.lblNum_Cartão.BackColor = System.Drawing.Color.Transparent;
            this.lblNum_Cartão.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum_Cartão.ForeColor = System.Drawing.Color.White;
            this.lblNum_Cartão.Location = new System.Drawing.Point(24, 150);
            this.lblNum_Cartão.Name = "lblNum_Cartão";
            this.lblNum_Cartão.Size = new System.Drawing.Size(143, 17);
            this.lblNum_Cartão.TabIndex = 1;
            this.lblNum_Cartão.Text = "NÚMERO DO CARTÃO";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.BackColor = System.Drawing.Color.Transparent;
            this.lblValidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.ForeColor = System.Drawing.Color.White;
            this.lblValidade.Location = new System.Drawing.Point(24, 236);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(151, 17);
            this.lblValidade.TabIndex = 2;
            this.lblValidade.Text = "VALIDADE DO CARTÃO";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(114, 330);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(102, 34);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // pcbCartão
            // 
            this.pcbCartão.Image = ((System.Drawing.Image)(resources.GetObject("pcbCartão.Image")));
            this.pcbCartão.Location = new System.Drawing.Point(385, 103);
            this.pcbCartão.Name = "pcbCartão";
            this.pcbCartão.Size = new System.Drawing.Size(391, 240);
            this.pcbCartão.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCartão.TabIndex = 4;
            this.pcbCartão.TabStop = false;
            // 
            // txtNome_Titular
            // 
            this.txtNome_Titular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome_Titular.Location = new System.Drawing.Point(27, 94);
            this.txtNome_Titular.Name = "txtNome_Titular";
            this.txtNome_Titular.Size = new System.Drawing.Size(316, 25);
            this.txtNome_Titular.TabIndex = 5;
            this.txtNome_Titular.TextChanged += new System.EventHandler(this.txtNome_Titular_TextChanged);
            // 
            // txtNum_cartao01
            // 
            this.txtNum_cartao01.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum_cartao01.Location = new System.Drawing.Point(27, 177);
            this.txtNum_cartao01.Name = "txtNum_cartao01";
            this.txtNum_cartao01.Size = new System.Drawing.Size(58, 25);
            this.txtNum_cartao01.TabIndex = 6;
            this.txtNum_cartao01.TextChanged += new System.EventHandler(this.txtNum_cartao01_TextChanged);
            // 
            // txtNum_cartao02
            // 
            this.txtNum_cartao02.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum_cartao02.Location = new System.Drawing.Point(104, 177);
            this.txtNum_cartao02.Name = "txtNum_cartao02";
            this.txtNum_cartao02.Size = new System.Drawing.Size(58, 25);
            this.txtNum_cartao02.TabIndex = 7;
            this.txtNum_cartao02.TextChanged += new System.EventHandler(this.txtNum_cartao02_TextChanged);
            // 
            // txtNum_cartao03
            // 
            this.txtNum_cartao03.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum_cartao03.Location = new System.Drawing.Point(180, 177);
            this.txtNum_cartao03.Name = "txtNum_cartao03";
            this.txtNum_cartao03.Size = new System.Drawing.Size(58, 25);
            this.txtNum_cartao03.TabIndex = 8;
            this.txtNum_cartao03.TextChanged += new System.EventHandler(this.txtNum_cartao03_TextChanged);
            // 
            // txtNum_cartao04
            // 
            this.txtNum_cartao04.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum_cartao04.Location = new System.Drawing.Point(256, 177);
            this.txtNum_cartao04.Name = "txtNum_cartao04";
            this.txtNum_cartao04.Size = new System.Drawing.Size(58, 25);
            this.txtNum_cartao04.TabIndex = 9;
            this.txtNum_cartao04.TextChanged += new System.EventHandler(this.txtNum_cartao04_TextChanged);
            // 
            // cbbmes
            // 
            this.cbbmes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmes.FormattingEnabled = true;
            this.cbbmes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbbmes.Location = new System.Drawing.Point(28, 264);
            this.cbbmes.Name = "cbbmes";
            this.cbbmes.Size = new System.Drawing.Size(62, 25);
            this.cbbmes.TabIndex = 10;
            this.cbbmes.SelectedIndexChanged += new System.EventHandler(this.cbbmes_SelectedIndexChanged);
            // 
            // cbbano
            // 
            this.cbbano.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbano.FormattingEnabled = true;
            this.cbbano.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032"});
            this.cbbano.Location = new System.Drawing.Point(114, 264);
            this.cbbano.Name = "cbbano";
            this.cbbano.Size = new System.Drawing.Size(62, 25);
            this.cbbano.TabIndex = 11;
            this.cbbano.SelectedIndexChanged += new System.EventHandler(this.cbbano_SelectedIndexChanged);
            // 
            // txtcvv
            // 
            this.txtcvv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcvv.Location = new System.Drawing.Point(241, 264);
            this.txtcvv.Name = "txtcvv";
            this.txtcvv.Size = new System.Drawing.Size(58, 25);
            this.txtcvv.TabIndex = 13;
            // 
            // lblcvv
            // 
            this.lblcvv.AutoSize = true;
            this.lblcvv.BackColor = System.Drawing.Color.Transparent;
            this.lblcvv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcvv.ForeColor = System.Drawing.Color.White;
            this.lblcvv.Location = new System.Drawing.Point(252, 236);
            this.lblcvv.Name = "lblcvv";
            this.lblcvv.Size = new System.Drawing.Size(34, 17);
            this.lblcvv.TabIndex = 14;
            this.lblcvv.Text = "CVV";
            // 
            // lblNum_card01
            // 
            this.lblNum_card01.AutoSize = true;
            this.lblNum_card01.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblNum_card01.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum_card01.ForeColor = System.Drawing.Color.White;
            this.lblNum_card01.Location = new System.Drawing.Point(410, 253);
            this.lblNum_card01.Name = "lblNum_card01";
            this.lblNum_card01.Size = new System.Drawing.Size(46, 21);
            this.lblNum_card01.TabIndex = 15;
            this.lblNum_card01.Text = "0000";
            // 
            // lblNum_card02
            // 
            this.lblNum_card02.AutoSize = true;
            this.lblNum_card02.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblNum_card02.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum_card02.ForeColor = System.Drawing.Color.White;
            this.lblNum_card02.Location = new System.Drawing.Point(465, 253);
            this.lblNum_card02.Name = "lblNum_card02";
            this.lblNum_card02.Size = new System.Drawing.Size(46, 21);
            this.lblNum_card02.TabIndex = 16;
            this.lblNum_card02.Text = "0000";
            // 
            // lblNum_card03
            // 
            this.lblNum_card03.AutoSize = true;
            this.lblNum_card03.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblNum_card03.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum_card03.ForeColor = System.Drawing.Color.White;
            this.lblNum_card03.Location = new System.Drawing.Point(522, 253);
            this.lblNum_card03.Name = "lblNum_card03";
            this.lblNum_card03.Size = new System.Drawing.Size(46, 21);
            this.lblNum_card03.TabIndex = 17;
            this.lblNum_card03.Text = "0000";
            // 
            // lblNum_card04
            // 
            this.lblNum_card04.AutoSize = true;
            this.lblNum_card04.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblNum_card04.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum_card04.ForeColor = System.Drawing.Color.White;
            this.lblNum_card04.Location = new System.Drawing.Point(577, 253);
            this.lblNum_card04.Name = "lblNum_card04";
            this.lblNum_card04.Size = new System.Drawing.Size(46, 21);
            this.lblNum_card04.TabIndex = 18;
            this.lblNum_card04.Text = "0000";
            // 
            // lblval_mes
            // 
            this.lblval_mes.AutoSize = true;
            this.lblval_mes.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblval_mes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblval_mes.ForeColor = System.Drawing.Color.White;
            this.lblval_mes.Location = new System.Drawing.Point(475, 291);
            this.lblval_mes.Name = "lblval_mes";
            this.lblval_mes.Size = new System.Drawing.Size(28, 21);
            this.lblval_mes.TabIndex = 19;
            this.lblval_mes.Text = "00";
            // 
            // lblVal_ano
            // 
            this.lblVal_ano.AutoSize = true;
            this.lblVal_ano.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblVal_ano.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal_ano.ForeColor = System.Drawing.Color.White;
            this.lblVal_ano.Location = new System.Drawing.Point(518, 291);
            this.lblVal_ano.Name = "lblVal_ano";
            this.lblVal_ano.Size = new System.Drawing.Size(46, 21);
            this.lblVal_ano.TabIndex = 20;
            this.lblVal_ano.Text = "0000";
            // 
            // pcbBandeira
            // 
            this.pcbBandeira.Location = new System.Drawing.Point(648, 264);
            this.pcbBandeira.Name = "pcbBandeira";
            this.pcbBandeira.Size = new System.Drawing.Size(100, 63);
            this.pcbBandeira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBandeira.TabIndex = 21;
            this.pcbBandeira.TabStop = false;
            // 
            // lblNomeCartão
            // 
            this.lblNomeCartão.AutoSize = true;
            this.lblNomeCartão.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblNomeCartão.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCartão.ForeColor = System.Drawing.Color.White;
            this.lblNomeCartão.Location = new System.Drawing.Point(541, 185);
            this.lblNomeCartão.Name = "lblNomeCartão";
            this.lblNomeCartão.Size = new System.Drawing.Size(164, 17);
            this.lblNomeCartão.TabIndex = 22;
            this.lblNomeCartão.Text = "NOME DO TITULAR AQUI";
            // 
            // lblpagametorealizado
            // 
            this.lblpagametorealizado.AutoSize = true;
            this.lblpagametorealizado.BackColor = System.Drawing.Color.Transparent;
            this.lblpagametorealizado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpagametorealizado.ForeColor = System.Drawing.Color.White;
            this.lblpagametorealizado.Location = new System.Drawing.Point(267, 205);
            this.lblpagametorealizado.Name = "lblpagametorealizado";
            this.lblpagametorealizado.Size = new System.Drawing.Size(268, 30);
            this.lblpagametorealizado.TabIndex = 23;
            this.lblpagametorealizado.Text = "PAGAMENTO REALIZADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblpagametorealizado);
            this.Controls.Add(this.lblNomeCartão);
            this.Controls.Add(this.pcbBandeira);
            this.Controls.Add(this.lblVal_ano);
            this.Controls.Add(this.lblval_mes);
            this.Controls.Add(this.lblNum_card04);
            this.Controls.Add(this.lblNum_card03);
            this.Controls.Add(this.lblNum_card02);
            this.Controls.Add(this.lblNum_card01);
            this.Controls.Add(this.lblcvv);
            this.Controls.Add(this.txtcvv);
            this.Controls.Add(this.cbbano);
            this.Controls.Add(this.cbbmes);
            this.Controls.Add(this.txtNum_cartao04);
            this.Controls.Add(this.txtNum_cartao03);
            this.Controls.Add(this.txtNum_cartao02);
            this.Controls.Add(this.txtNum_cartao01);
            this.Controls.Add(this.txtNome_Titular);
            this.Controls.Add(this.pcbCartão);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.lblNum_Cartão);
            this.Controls.Add(this.lblNome_Titular);
            this.Name = "Form1";
            this.Text = "Forma de Pagamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCartão)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBandeira)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome_Titular;
        private System.Windows.Forms.Label lblNum_Cartão;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.PictureBox pcbCartão;
        private System.Windows.Forms.TextBox txtNome_Titular;
        private System.Windows.Forms.TextBox txtNum_cartao01;
        private System.Windows.Forms.TextBox txtNum_cartao02;
        private System.Windows.Forms.TextBox txtNum_cartao03;
        private System.Windows.Forms.TextBox txtNum_cartao04;
        private System.Windows.Forms.ComboBox cbbmes;
        private System.Windows.Forms.ComboBox cbbano;
        private System.Windows.Forms.TextBox txtcvv;
        private System.Windows.Forms.Label lblcvv;
        private System.Windows.Forms.Label lblNum_card01;
        private System.Windows.Forms.Label lblNum_card02;
        private System.Windows.Forms.Label lblNum_card03;
        private System.Windows.Forms.Label lblNum_card04;
        private System.Windows.Forms.Label lblval_mes;
        private System.Windows.Forms.Label lblVal_ano;
        private System.Windows.Forms.PictureBox pcbBandeira;
        private System.Windows.Forms.Label lblNomeCartão;
        private System.Windows.Forms.Label lblpagametorealizado;
    }
}

