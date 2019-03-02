namespace GUI
{
	partial class FrmCadastroLivros
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
			this.cbAutor = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pbCapa = new System.Windows.Forms.PictureBox();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtISBN = new System.Windows.Forms.TextBox();
			this.txtValorC = new System.Windows.Forms.TextBox();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbGenero = new System.Windows.Forms.ComboBox();
			this.btInsCapa = new System.Windows.Forms.Button();
			this.btRemCapa = new System.Windows.Forms.Button();
			this.cbEditora = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMesAno = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtVolume = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtQnt = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtValorV = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtPeso = new System.Windows.Forms.TextBox();
			this.dtpDataCad = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.pnDados.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCapa)).BeginInit();
			this.SuspendLayout();
			// 
			// pnDados
			// 
			this.pnDados.Controls.Add(this.label13);
			this.pnDados.Controls.Add(this.dtpDataCad);
			this.pnDados.Controls.Add(this.label14);
			this.pnDados.Controls.Add(this.txtPeso);
			this.pnDados.Controls.Add(this.label12);
			this.pnDados.Controls.Add(this.txtValorV);
			this.pnDados.Controls.Add(this.label11);
			this.pnDados.Controls.Add(this.txtQnt);
			this.pnDados.Controls.Add(this.label10);
			this.pnDados.Controls.Add(this.label9);
			this.pnDados.Controls.Add(this.txtVolume);
			this.pnDados.Controls.Add(this.label8);
			this.pnDados.Controls.Add(this.txtMesAno);
			this.pnDados.Controls.Add(this.label4);
			this.pnDados.Controls.Add(this.cbEditora);
			this.pnDados.Controls.Add(this.btRemCapa);
			this.pnDados.Controls.Add(this.btInsCapa);
			this.pnDados.Controls.Add(this.cbGenero);
			this.pnDados.Controls.Add(this.label7);
			this.pnDados.Controls.Add(this.label6);
			this.pnDados.Controls.Add(this.label5);
			this.pnDados.Controls.Add(this.label3);
			this.pnDados.Controls.Add(this.label2);
			this.pnDados.Controls.Add(this.txtDescricao);
			this.pnDados.Controls.Add(this.txtValorC);
			this.pnDados.Controls.Add(this.txtISBN);
			this.pnDados.Controls.Add(this.txtCodigo);
			this.pnDados.Controls.Add(this.txtTitulo);
			this.pnDados.Controls.Add(this.panel1);
			this.pnDados.Controls.Add(this.label1);
			this.pnDados.Controls.Add(this.cbAutor);
			this.pnDados.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDados_Paint);
			// 
			// btCancelar
			// 
			this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
			// 
			// btSalvar
			// 
			this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
			// 
			// btInserir
			// 
			this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
			// 
			// cbAutor
			// 
			this.cbAutor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAutor.FormattingEnabled = true;
			this.cbAutor.Location = new System.Drawing.Point(29, 152);
			this.cbAutor.Name = "cbAutor";
			this.cbAutor.Size = new System.Drawing.Size(457, 23);
			this.cbAutor.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Codigo";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pbCapa);
			this.panel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(500, 67);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(244, 298);
			this.panel1.TabIndex = 3;
			// 
			// pbCapa
			// 
			this.pbCapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbCapa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbCapa.Location = new System.Drawing.Point(0, 0);
			this.pbCapa.Name = "pbCapa";
			this.pbCapa.Size = new System.Drawing.Size(244, 298);
			this.pbCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbCapa.TabIndex = 5;
			this.pbCapa.TabStop = false;
			// 
			// txtTitulo
			// 
			this.txtTitulo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTitulo.Location = new System.Drawing.Point(29, 113);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(457, 23);
			this.txtTitulo.TabIndex = 1;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(29, 33);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 23);
			this.txtCodigo.TabIndex = 100;
			// 
			// txtISBN
			// 
			this.txtISBN.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtISBN.Location = new System.Drawing.Point(29, 74);
			this.txtISBN.Name = "txtISBN";
			this.txtISBN.Size = new System.Drawing.Size(165, 23);
			this.txtISBN.TabIndex = 0;
			// 
			// txtValorC
			// 
			this.txtValorC.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValorC.Location = new System.Drawing.Point(32, 368);
			this.txtValorC.Multiline = true;
			this.txtValorC.Name = "txtValorC";
			this.txtValorC.Size = new System.Drawing.Size(80, 34);
			this.txtValorC.TabIndex = 9;
			this.txtValorC.TextChanged += new System.EventHandler(this.txtValorC_TextChanged);
			this.txtValorC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorC_KeyPress);
			this.txtValorC.Leave += new System.EventHandler(this.txtValorC_Leave);
			// 
			// txtDescricao
			// 
			this.txtDescricao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescricao.Location = new System.Drawing.Point(29, 286);
			this.txtDescricao.Multiline = true;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(457, 59);
			this.txtDescricao.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 15);
			this.label2.TabIndex = 16;
			this.label2.Text = "Autor";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(26, 224);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 15);
			this.label3.TabIndex = 17;
			this.label3.Text = "Gênero";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(26, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 15);
			this.label5.TabIndex = 19;
			this.label5.Text = "ISBN";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(26, 179);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 15);
			this.label6.TabIndex = 20;
			this.label6.Text = "Editora";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(26, 97);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 15);
			this.label7.TabIndex = 21;
			this.label7.Text = "Título";
			// 
			// cbGenero
			// 
			this.cbGenero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbGenero.FormattingEnabled = true;
			this.cbGenero.Location = new System.Drawing.Point(29, 240);
			this.cbGenero.Name = "cbGenero";
			this.cbGenero.Size = new System.Drawing.Size(457, 23);
			this.cbGenero.TabIndex = 7;
			// 
			// btInsCapa
			// 
			this.btInsCapa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btInsCapa.Location = new System.Drawing.Point(500, 376);
			this.btInsCapa.Name = "btInsCapa";
			this.btInsCapa.Size = new System.Drawing.Size(115, 26);
			this.btInsCapa.TabIndex = 13;
			this.btInsCapa.Text = "Inserir Capa";
			this.btInsCapa.UseVisualStyleBackColor = true;
			this.btInsCapa.Click += new System.EventHandler(this.btInsCapa_Click);
			// 
			// btRemCapa
			// 
			this.btRemCapa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btRemCapa.Location = new System.Drawing.Point(629, 376);
			this.btRemCapa.Name = "btRemCapa";
			this.btRemCapa.Size = new System.Drawing.Size(115, 26);
			this.btRemCapa.TabIndex = 14;
			this.btRemCapa.Text = "Excluir Capa";
			this.btRemCapa.UseVisualStyleBackColor = true;
			this.btRemCapa.Click += new System.EventHandler(this.btRemCapa_Click);
			// 
			// cbEditora
			// 
			this.cbEditora.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbEditora.FormattingEnabled = true;
			this.cbEditora.Location = new System.Drawing.Point(29, 195);
			this.cbEditora.Name = "cbEditora";
			this.cbEditora.Size = new System.Drawing.Size(339, 23);
			this.cbEditora.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(26, 270);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 15);
			this.label4.TabIndex = 26;
			this.label4.Text = "Descrição";
			// 
			// txtMesAno
			// 
			this.txtMesAno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMesAno.Location = new System.Drawing.Point(374, 196);
			this.txtMesAno.Name = "txtMesAno";
			this.txtMesAno.Size = new System.Drawing.Size(53, 23);
			this.txtMesAno.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(371, 179);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 15);
			this.label8.TabIndex = 28;
			this.label8.Text = "Mes/Ano";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(430, 179);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 15);
			this.label9.TabIndex = 30;
			this.label9.Text = "Volume";
			// 
			// txtVolume
			// 
			this.txtVolume.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtVolume.Location = new System.Drawing.Point(433, 196);
			this.txtVolume.Name = "txtVolume";
			this.txtVolume.Size = new System.Drawing.Size(53, 23);
			this.txtVolume.TabIndex = 6;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(29, 352);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(86, 15);
			this.label10.TabIndex = 33;
			this.label10.Text = "Valor de Custo";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(274, 352);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(71, 15);
			this.label11.TabIndex = 35;
			this.label11.Text = "Quantidade";
			// 
			// txtQnt
			// 
			this.txtQnt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQnt.Location = new System.Drawing.Point(277, 368);
			this.txtQnt.Multiline = true;
			this.txtQnt.Name = "txtQnt";
			this.txtQnt.Size = new System.Drawing.Size(80, 34);
			this.txtQnt.TabIndex = 11;
			this.txtQnt.TextChanged += new System.EventHandler(this.txtQnt_TextChanged);
			this.txtQnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQnt_KeyPress);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(159, 352);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(89, 15);
			this.label12.TabIndex = 37;
			this.label12.Text = "Valor de Venda";
			// 
			// txtValorV
			// 
			this.txtValorV.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValorV.Location = new System.Drawing.Point(162, 368);
			this.txtValorV.Multiline = true;
			this.txtValorV.Name = "txtValorV";
			this.txtValorV.Size = new System.Drawing.Size(80, 34);
			this.txtValorV.TabIndex = 10;
			this.txtValorV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorV_KeyPress);
			this.txtValorV.Leave += new System.EventHandler(this.txtValorV_Leave);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(403, 352);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(45, 15);
			this.label14.TabIndex = 41;
			this.label14.Text = "Peso/g";
			// 
			// txtPeso
			// 
			this.txtPeso.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPeso.Location = new System.Drawing.Point(406, 368);
			this.txtPeso.Multiline = true;
			this.txtPeso.Name = "txtPeso";
			this.txtPeso.Size = new System.Drawing.Size(80, 34);
			this.txtPeso.TabIndex = 12;
			this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
			this.txtPeso.Leave += new System.EventHandler(this.txtPeso_Leave);
			// 
			// dtpDataCad
			// 
			this.dtpDataCad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDataCad.Location = new System.Drawing.Point(491, 18);
			this.dtpDataCad.Name = "dtpDataCad";
			this.dtpDataCad.Size = new System.Drawing.Size(253, 23);
			this.dtpDataCad.TabIndex = 42;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(497, 49);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 15);
			this.label13.TabIndex = 43;
			this.label13.Text = "Capa do Livro";
			this.label13.Click += new System.EventHandler(this.label13_Click);
			// 
			// FrmCadastroLivros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Name = "FrmCadastroLivros";
			this.Text = "Cadastro de Livro";
			this.Load += new System.EventHandler(this.FrmCadastroLivros_Load);
			this.pnDados.ResumeLayout(false);
			this.pnDados.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbCapa)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbEditora;
		private System.Windows.Forms.Button btRemCapa;
		private System.Windows.Forms.Button btInsCapa;
		private System.Windows.Forms.ComboBox cbGenero;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDescricao;
		private System.Windows.Forms.TextBox txtValorC;
		private System.Windows.Forms.TextBox txtISBN;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pbCapa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbAutor;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtVolume;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtMesAno;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpDataCad;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtPeso;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtValorV;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtQnt;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label13;
	}
}
