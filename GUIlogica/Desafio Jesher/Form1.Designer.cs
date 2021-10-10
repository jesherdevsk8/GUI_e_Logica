
namespace Desafio_Jesher
{
    partial class frm_Cursos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSub_Titulo = new System.Windows.Forms.Label();
            this.lblValor_curso01 = new System.Windows.Forms.Label();
            this.cbb_Parcelas = new System.Windows.Forms.ComboBox();
            this.lbl_valores = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.mskDateTimeNow = new System.Windows.Forms.MaskedTextBox();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.checkboxAvista = new System.Windows.Forms.CheckBox();
            this.checkboxAprazo = new System.Windows.Forms.CheckBox();
            this.lblNome_CursoLinux01 = new System.Windows.Forms.Label();
            this.mskDataCompra = new System.Windows.Forms.MaskedTextBox();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSucesso = new System.Windows.Forms.Label();
            this.lblcomdesconto = new System.Windows.Forms.Label();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.lblTotal_Juros = new System.Windows.Forms.Label();
            this.lblprecounitario = new System.Windows.Forms.Label();
            this.lblTotal_Com_Juros = new System.Windows.Forms.Label();
            this.lblTotal_com_juros_tela = new System.Windows.Forms.Label();
            this.pcb_cursoAssunto03 = new System.Windows.Forms.PictureBox();
            this.pcb_cursoAssunto02 = new System.Windows.Forms.PictureBox();
            this.pcb_cursoTerminalLinux = new System.Windows.Forms.PictureBox();
            this.pcb_curso03 = new System.Windows.Forms.PictureBox();
            this.pcb_curso02 = new System.Windows.Forms.PictureBox();
            this.pcb_Linux_curso01 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_cursoAssunto03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_cursoAssunto02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_cursoTerminalLinux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_curso03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_curso02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Linux_curso01)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Teal;
            this.lblTitulo.Location = new System.Drawing.Point(275, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(249, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Garage Cursos";
            // 
            // lblSub_Titulo
            // 
            this.lblSub_Titulo.AutoSize = true;
            this.lblSub_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSub_Titulo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub_Titulo.ForeColor = System.Drawing.Color.Black;
            this.lblSub_Titulo.Location = new System.Drawing.Point(335, 55);
            this.lblSub_Titulo.Name = "lblSub_Titulo";
            this.lblSub_Titulo.Size = new System.Drawing.Size(133, 16);
            this.lblSub_Titulo.TabIndex = 1;
            this.lblSub_Titulo.Text = "Construindo seu futuro";
            // 
            // lblValor_curso01
            // 
            this.lblValor_curso01.AutoSize = true;
            this.lblValor_curso01.BackColor = System.Drawing.Color.Transparent;
            this.lblValor_curso01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValor_curso01.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor_curso01.ForeColor = System.Drawing.Color.DarkRed;
            this.lblValor_curso01.Location = new System.Drawing.Point(557, 121);
            this.lblValor_curso01.Name = "lblValor_curso01";
            this.lblValor_curso01.Size = new System.Drawing.Size(160, 24);
            this.lblValor_curso01.TabIndex = 14;
            this.lblValor_curso01.Text = "R$ 0,000,00 Reais";
            // 
            // cbb_Parcelas
            // 
            this.cbb_Parcelas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_Parcelas.FormattingEnabled = true;
            this.cbb_Parcelas.Items.AddRange(new object[] {
            "1 x",
            "2 x",
            "3 x",
            "4 x",
            "5 x",
            "6 x",
            "7 x",
            "8 x",
            "9 x",
            "10 x",
            "11 x",
            "12 x"});
            this.cbb_Parcelas.Location = new System.Drawing.Point(686, 179);
            this.cbb_Parcelas.Name = "cbb_Parcelas";
            this.cbb_Parcelas.Size = new System.Drawing.Size(50, 21);
            this.cbb_Parcelas.TabIndex = 16;
            this.cbb_Parcelas.SelectedIndexChanged += new System.EventHandler(this.cbb_Parcelas_SelectedIndexChanged);
            // 
            // lbl_valores
            // 
            this.lbl_valores.AutoSize = true;
            this.lbl_valores.BackColor = System.Drawing.Color.Gold;
            this.lbl_valores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_valores.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valores.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_valores.Location = new System.Drawing.Point(628, 273);
            this.lbl_valores.Name = "lbl_valores";
            this.lbl_valores.Size = new System.Drawing.Size(109, 24);
            this.lbl_valores.TabIndex = 17;
            this.lbl_valores.Text = "R$ 00,00,00";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Orange;
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(557, 325);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Padding = new System.Windows.Forms.Padding(1);
            this.btnComprar.Size = new System.Drawing.Size(87, 27);
            this.btnComprar.TabIndex = 18;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // mskDateTimeNow
            // 
            this.mskDateTimeNow.BackColor = System.Drawing.SystemColors.Menu;
            this.mskDateTimeNow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskDateTimeNow.Cursor = System.Windows.Forms.Cursors.Default;
            this.mskDateTimeNow.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDateTimeNow.Location = new System.Drawing.Point(4, 1);
            this.mskDateTimeNow.Mask = "00/00/0000 90:00";
            this.mskDateTimeNow.Name = "mskDateTimeNow";
            this.mskDateTimeNow.Size = new System.Drawing.Size(118, 15);
            this.mskDateTimeNow.TabIndex = 24;
            this.mskDateTimeNow.ValidatingType = typeof(System.DateTime);
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.BackColor = System.Drawing.Color.Transparent;
            this.lblParcelas.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelas.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblParcelas.Location = new System.Drawing.Point(625, 182);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(57, 14);
            this.lblParcelas.TabIndex = 25;
            this.lblParcelas.Text = "Parcelas:";
            // 
            // checkboxAvista
            // 
            this.checkboxAvista.AutoSize = true;
            this.checkboxAvista.Location = new System.Drawing.Point(557, 280);
            this.checkboxAvista.Name = "checkboxAvista";
            this.checkboxAvista.Size = new System.Drawing.Size(65, 17);
            this.checkboxAvista.TabIndex = 26;
            this.checkboxAvista.Text = "À vista";
            this.checkboxAvista.UseVisualStyleBackColor = true;
            this.checkboxAvista.CheckedChanged += new System.EventHandler(this.checkboxAvista_CheckedChanged);
            // 
            // checkboxAprazo
            // 
            this.checkboxAprazo.AutoSize = true;
            this.checkboxAprazo.Location = new System.Drawing.Point(557, 182);
            this.checkboxAprazo.Name = "checkboxAprazo";
            this.checkboxAprazo.Size = new System.Drawing.Size(69, 17);
            this.checkboxAprazo.TabIndex = 27;
            this.checkboxAprazo.Text = "À prazo";
            this.checkboxAprazo.UseVisualStyleBackColor = true;
            this.checkboxAprazo.CheckedChanged += new System.EventHandler(this.checkboxAprazo_CheckedChanged);
            // 
            // lblNome_CursoLinux01
            // 
            this.lblNome_CursoLinux01.AutoSize = true;
            this.lblNome_CursoLinux01.BackColor = System.Drawing.Color.Transparent;
            this.lblNome_CursoLinux01.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_CursoLinux01.ForeColor = System.Drawing.Color.Black;
            this.lblNome_CursoLinux01.Location = new System.Drawing.Point(553, 150);
            this.lblNome_CursoLinux01.Name = "lblNome_CursoLinux01";
            this.lblNome_CursoLinux01.Size = new System.Drawing.Size(174, 22);
            this.lblNome_CursoLinux01.TabIndex = 28;
            this.lblNome_CursoLinux01.Text = "Nome do curso aqui";
            // 
            // mskDataCompra
            // 
            this.mskDataCompra.BackColor = System.Drawing.SystemColors.Menu;
            this.mskDataCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskDataCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskDataCompra.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataCompra.Location = new System.Drawing.Point(385, 413);
            this.mskDataCompra.Mask = "00/00/0000 90:00";
            this.mskDataCompra.Name = "mskDataCompra";
            this.mskDataCompra.Size = new System.Drawing.Size(161, 22);
            this.mskDataCompra.TabIndex = 29;
            this.mskDataCompra.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblDataCompra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCompra.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDataCompra.Location = new System.Drawing.Point(267, 419);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(111, 16);
            this.lblDataCompra.TabIndex = 30;
            this.lblDataCompra.Text = "Data da Compra";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(650, 325);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(1);
            this.btnLimpar.Size = new System.Drawing.Size(87, 27);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSucesso
            // 
            this.lblSucesso.AutoSize = true;
            this.lblSucesso.BackColor = System.Drawing.Color.Transparent;
            this.lblSucesso.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucesso.ForeColor = System.Drawing.Color.Tomato;
            this.lblSucesso.Location = new System.Drawing.Point(174, 384);
            this.lblSucesso.Name = "lblSucesso";
            this.lblSucesso.Size = new System.Drawing.Size(457, 26);
            this.lblSucesso.TabIndex = 32;
            this.lblSucesso.Text = "Compra Realizada com Sucesso!!!";
            // 
            // lblcomdesconto
            // 
            this.lblcomdesconto.AutoSize = true;
            this.lblcomdesconto.BackColor = System.Drawing.Color.Transparent;
            this.lblcomdesconto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomdesconto.ForeColor = System.Drawing.Color.Black;
            this.lblcomdesconto.Location = new System.Drawing.Point(638, 297);
            this.lblcomdesconto.Name = "lblcomdesconto";
            this.lblcomdesconto.Size = new System.Drawing.Size(88, 14);
            this.lblcomdesconto.TabIndex = 33;
            this.lblcomdesconto.Text = "Com desconto";
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.BackColor = System.Drawing.Color.Red;
            this.lblValorParcela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorParcela.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcela.ForeColor = System.Drawing.Color.White;
            this.lblValorParcela.Location = new System.Drawing.Point(627, 239);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(109, 24);
            this.lblValorParcela.TabIndex = 34;
            this.lblValorParcela.Text = "R$ 00,00,00";
            // 
            // lblTotal_Juros
            // 
            this.lblTotal_Juros.AutoSize = true;
            this.lblTotal_Juros.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal_Juros.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal_Juros.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotal_Juros.Location = new System.Drawing.Point(555, 245);
            this.lblTotal_Juros.Name = "lblTotal_Juros";
            this.lblTotal_Juros.Size = new System.Drawing.Size(71, 14);
            this.lblTotal_Juros.TabIndex = 35;
            this.lblTotal_Juros.Text = "Valor/Parcela";
            // 
            // lblprecounitario
            // 
            this.lblprecounitario.AutoSize = true;
            this.lblprecounitario.BackColor = System.Drawing.Color.Transparent;
            this.lblprecounitario.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecounitario.ForeColor = System.Drawing.Color.Black;
            this.lblprecounitario.Location = new System.Drawing.Point(553, 93);
            this.lblprecounitario.Name = "lblprecounitario";
            this.lblprecounitario.Size = new System.Drawing.Size(130, 22);
            this.lblprecounitario.TabIndex = 36;
            this.lblprecounitario.Text = "Preço Unitário";
            // 
            // lblTotal_Com_Juros
            // 
            this.lblTotal_Com_Juros.AutoSize = true;
            this.lblTotal_Com_Juros.BackColor = System.Drawing.Color.Red;
            this.lblTotal_Com_Juros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal_Com_Juros.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal_Com_Juros.ForeColor = System.Drawing.Color.White;
            this.lblTotal_Com_Juros.Location = new System.Drawing.Point(627, 206);
            this.lblTotal_Com_Juros.Name = "lblTotal_Com_Juros";
            this.lblTotal_Com_Juros.Size = new System.Drawing.Size(109, 24);
            this.lblTotal_Com_Juros.TabIndex = 37;
            this.lblTotal_Com_Juros.Text = "R$ 00,00,00";
            // 
            // lblTotal_com_juros_tela
            // 
            this.lblTotal_com_juros_tela.AutoSize = true;
            this.lblTotal_com_juros_tela.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal_com_juros_tela.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal_com_juros_tela.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotal_com_juros_tela.Location = new System.Drawing.Point(564, 212);
            this.lblTotal_com_juros_tela.Name = "lblTotal_com_juros_tela";
            this.lblTotal_com_juros_tela.Size = new System.Drawing.Size(57, 14);
            this.lblTotal_com_juros_tela.TabIndex = 38;
            this.lblTotal_com_juros_tela.Text = "Tota/Juros";
            // 
            // pcb_cursoAssunto03
            // 
            this.pcb_cursoAssunto03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_cursoAssunto03.Image = global::Desafio_Jesher.Properties.Resources.shellUnix;
            this.pcb_cursoAssunto03.Location = new System.Drawing.Point(335, 248);
            this.pcb_cursoAssunto03.Name = "pcb_cursoAssunto03";
            this.pcb_cursoAssunto03.Size = new System.Drawing.Size(112, 99);
            this.pcb_cursoAssunto03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_cursoAssunto03.TabIndex = 9;
            this.pcb_cursoAssunto03.TabStop = false;
            this.pcb_cursoAssunto03.Click += new System.EventHandler(this.pcb_cursoAssunto03_Click);
            // 
            // pcb_cursoAssunto02
            // 
            this.pcb_cursoAssunto02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_cursoAssunto02.Image = global::Desafio_Jesher.Properties.Resources.powershell;
            this.pcb_cursoAssunto02.Location = new System.Drawing.Point(191, 248);
            this.pcb_cursoAssunto02.Name = "pcb_cursoAssunto02";
            this.pcb_cursoAssunto02.Size = new System.Drawing.Size(112, 99);
            this.pcb_cursoAssunto02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_cursoAssunto02.TabIndex = 8;
            this.pcb_cursoAssunto02.TabStop = false;
            this.pcb_cursoAssunto02.Click += new System.EventHandler(this.pcb_cursoAssunto02_Click);
            // 
            // pcb_cursoTerminalLinux
            // 
            this.pcb_cursoTerminalLinux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_cursoTerminalLinux.Image = global::Desafio_Jesher.Properties.Resources.Terminal_linux;
            this.pcb_cursoTerminalLinux.Location = new System.Drawing.Point(44, 248);
            this.pcb_cursoTerminalLinux.Name = "pcb_cursoTerminalLinux";
            this.pcb_cursoTerminalLinux.Size = new System.Drawing.Size(112, 99);
            this.pcb_cursoTerminalLinux.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_cursoTerminalLinux.TabIndex = 7;
            this.pcb_cursoTerminalLinux.TabStop = false;
            this.pcb_cursoTerminalLinux.Click += new System.EventHandler(this.pcb_cursoTerminalLinux_Click);
            // 
            // pcb_curso03
            // 
            this.pcb_curso03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_curso03.Image = global::Desafio_Jesher.Properties.Resources.openbsd;
            this.pcb_curso03.Location = new System.Drawing.Point(335, 99);
            this.pcb_curso03.Name = "pcb_curso03";
            this.pcb_curso03.Size = new System.Drawing.Size(112, 99);
            this.pcb_curso03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_curso03.TabIndex = 4;
            this.pcb_curso03.TabStop = false;
            this.pcb_curso03.Click += new System.EventHandler(this.pcb_curso03_Click);
            // 
            // pcb_curso02
            // 
            this.pcb_curso02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_curso02.Image = global::Desafio_Jesher.Properties.Resources.microft_Logo;
            this.pcb_curso02.Location = new System.Drawing.Point(191, 99);
            this.pcb_curso02.Name = "pcb_curso02";
            this.pcb_curso02.Size = new System.Drawing.Size(112, 99);
            this.pcb_curso02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_curso02.TabIndex = 3;
            this.pcb_curso02.TabStop = false;
            this.pcb_curso02.Click += new System.EventHandler(this.pcb_curso02_Click);
            // 
            // pcb_Linux_curso01
            // 
            this.pcb_Linux_curso01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_Linux_curso01.Image = global::Desafio_Jesher.Properties.Resources.Linux_Logo;
            this.pcb_Linux_curso01.Location = new System.Drawing.Point(44, 99);
            this.pcb_Linux_curso01.Name = "pcb_Linux_curso01";
            this.pcb_Linux_curso01.Size = new System.Drawing.Size(112, 99);
            this.pcb_Linux_curso01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_Linux_curso01.TabIndex = 2;
            this.pcb_Linux_curso01.TabStop = false;
            this.pcb_Linux_curso01.Click += new System.EventHandler(this.pcb_Linux_curso01_Click);
            // 
            // frm_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.lblTotal_com_juros_tela);
            this.Controls.Add(this.lblTotal_Com_Juros);
            this.Controls.Add(this.lblprecounitario);
            this.Controls.Add(this.lblTotal_Juros);
            this.Controls.Add(this.lblValorParcela);
            this.Controls.Add(this.lblcomdesconto);
            this.Controls.Add(this.lblSucesso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblDataCompra);
            this.Controls.Add(this.mskDataCompra);
            this.Controls.Add(this.lblNome_CursoLinux01);
            this.Controls.Add(this.checkboxAprazo);
            this.Controls.Add(this.checkboxAvista);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.mskDateTimeNow);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lbl_valores);
            this.Controls.Add(this.cbb_Parcelas);
            this.Controls.Add(this.lblValor_curso01);
            this.Controls.Add(this.pcb_cursoAssunto03);
            this.Controls.Add(this.pcb_cursoAssunto02);
            this.Controls.Add(this.pcb_cursoTerminalLinux);
            this.Controls.Add(this.pcb_curso03);
            this.Controls.Add(this.pcb_curso02);
            this.Controls.Add(this.pcb_Linux_curso01);
            this.Controls.Add(this.lblSub_Titulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Cursos";
            this.Text = "Garage Corp";
            this.Load += new System.EventHandler(this.frm_Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_cursoAssunto03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_cursoAssunto02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_cursoTerminalLinux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_curso03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_curso02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Linux_curso01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSub_Titulo;
        private System.Windows.Forms.PictureBox pcb_Linux_curso01;
        private System.Windows.Forms.PictureBox pcb_curso02;
        private System.Windows.Forms.PictureBox pcb_curso03;
        private System.Windows.Forms.PictureBox pcb_cursoAssunto03;
        private System.Windows.Forms.PictureBox pcb_cursoAssunto02;
        private System.Windows.Forms.PictureBox pcb_cursoTerminalLinux;
        private System.Windows.Forms.Label lblValor_curso01;
        private System.Windows.Forms.ComboBox cbb_Parcelas;
        private System.Windows.Forms.Label lbl_valores;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.MaskedTextBox mskDateTimeNow;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.CheckBox checkboxAvista;
        private System.Windows.Forms.CheckBox checkboxAprazo;
        private System.Windows.Forms.Label lblNome_CursoLinux01;
        private System.Windows.Forms.MaskedTextBox mskDataCompra;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblSucesso;
        private System.Windows.Forms.Label lblcomdesconto;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.Label lblTotal_Juros;
        private System.Windows.Forms.Label lblprecounitario;
        private System.Windows.Forms.Label lblTotal_Com_Juros;
        private System.Windows.Forms.Label lblTotal_com_juros_tela;
    }
}

