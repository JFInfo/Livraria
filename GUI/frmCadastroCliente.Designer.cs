namespace GUI
{
	partial class frmCadastroCliente
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCPF = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtddd1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCNPJ = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTelefone1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTelefone2 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtddd2 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtRua = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtCEP = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtUF = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.dtDataCad = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.pnDados.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnDados
			// 
			this.pnDados.Controls.Add(this.label11);
			this.pnDados.Controls.Add(this.dtDataCad);
			this.pnDados.Controls.Add(this.txtUF);
			this.pnDados.Controls.Add(this.label17);
			this.pnDados.Controls.Add(this.txtCEP);
			this.pnDados.Controls.Add(this.label16);
			this.pnDados.Controls.Add(this.txtBairro);
			this.pnDados.Controls.Add(this.label15);
			this.pnDados.Controls.Add(this.txtCidade);
			this.pnDados.Controls.Add(this.label14);
			this.pnDados.Controls.Add(this.txtNumero);
			this.pnDados.Controls.Add(this.label13);
			this.pnDados.Controls.Add(this.txtRua);
			this.pnDados.Controls.Add(this.label12);
			this.pnDados.Controls.Add(this.label10);
			this.pnDados.Controls.Add(this.txtTelefone2);
			this.pnDados.Controls.Add(this.label8);
			this.pnDados.Controls.Add(this.txtddd2);
			this.pnDados.Controls.Add(this.label9);
			this.pnDados.Controls.Add(this.txtEmail);
			this.pnDados.Controls.Add(this.label7);
			this.pnDados.Controls.Add(this.txtTelefone1);
			this.pnDados.Controls.Add(this.label6);
			this.pnDados.Controls.Add(this.txtCNPJ);
			this.pnDados.Controls.Add(this.label5);
			this.pnDados.Controls.Add(this.txtddd1);
			this.pnDados.Controls.Add(this.label4);
			this.pnDados.Controls.Add(this.txtCPF);
			this.pnDados.Controls.Add(this.label3);
			this.pnDados.Controls.Add(this.txtNome);
			this.pnDados.Controls.Add(this.label2);
			this.pnDados.Controls.Add(this.txtCodigo);
			this.pnDados.Controls.Add(this.label1);
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
			// btExcluir
			// 
			this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
			// 
			// btAlterar
			// 
			this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
			// 
			// btLocalizar
			// 
			this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
			// 
			// btInserir
			// 
			this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Código";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtCodigo
			// 
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(15, 50);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 26);
			this.txtCodigo.TabIndex = 1;
			this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
			// 
			// txtNome
			// 
			this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(15, 99);
			this.txtNome.Multiline = true;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(729, 26);
			this.txtNome.TabIndex = 2;
			this.txtNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(-273, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "label2";
			// 
			// txtCPF
			// 
			this.txtCPF.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCPF.Location = new System.Drawing.Point(15, 151);
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(142, 26);
			this.txtCPF.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "CPF";
			// 
			// txtddd1
			// 
			this.txtddd1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtddd1.Location = new System.Drawing.Point(376, 151);
			this.txtddd1.Name = "txtddd1";
			this.txtddd1.Size = new System.Drawing.Size(32, 26);
			this.txtddd1.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(373, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "DDD";
			// 
			// txtCNPJ
			// 
			this.txtCNPJ.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCNPJ.Location = new System.Drawing.Point(176, 151);
			this.txtCNPJ.Name = "txtCNPJ";
			this.txtCNPJ.Size = new System.Drawing.Size(181, 26);
			this.txtCNPJ.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(173, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 18);
			this.label5.TabIndex = 9;
			this.label5.Text = "CNPJ";
			// 
			// txtTelefone1
			// 
			this.txtTelefone1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefone1.Location = new System.Drawing.Point(414, 151);
			this.txtTelefone1.Name = "txtTelefone1";
			this.txtTelefone1.Size = new System.Drawing.Size(139, 26);
			this.txtTelefone1.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(411, 135);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 18);
			this.label6.TabIndex = 11;
			this.label6.Text = "Telefone1";
			// 
			// txtEmail
			// 
			this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(15, 208);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(342, 26);
			this.txtEmail.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 192);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 18);
			this.label7.TabIndex = 13;
			this.label7.Text = "E-mail";
			// 
			// txtTelefone2
			// 
			this.txtTelefone2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefone2.Location = new System.Drawing.Point(602, 151);
			this.txtTelefone2.Name = "txtTelefone2";
			this.txtTelefone2.Size = new System.Drawing.Size(142, 26);
			this.txtTelefone2.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(599, 135);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 18);
			this.label8.TabIndex = 17;
			this.label8.Text = "Telefone2";
			// 
			// txtddd2
			// 
			this.txtddd2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtddd2.Location = new System.Drawing.Point(564, 151);
			this.txtddd2.Name = "txtddd2";
			this.txtddd2.Size = new System.Drawing.Size(32, 26);
			this.txtddd2.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(561, 135);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 18);
			this.label9.TabIndex = 15;
			this.label9.Text = "DDD";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(13, 78);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(46, 18);
			this.label10.TabIndex = 19;
			this.label10.Text = "Nome";
			// 
			// txtRua
			// 
			this.txtRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRua.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRua.Location = new System.Drawing.Point(376, 208);
			this.txtRua.Name = "txtRua";
			this.txtRua.Size = new System.Drawing.Size(368, 26);
			this.txtRua.TabIndex = 10;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(373, 192);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(78, 18);
			this.label12.TabIndex = 21;
			this.label12.Text = "Logradouro";
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(15, 264);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(52, 26);
			this.txtNumero.TabIndex = 11;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(12, 248);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(23, 18);
			this.label13.TabIndex = 23;
			this.label13.Text = "N°";
			// 
			// txtCidade
			// 
			this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCidade.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidade.Location = new System.Drawing.Point(15, 327);
			this.txtCidade.Multiline = true;
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(663, 26);
			this.txtCidade.TabIndex = 14;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(12, 311);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(51, 18);
			this.label14.TabIndex = 25;
			this.label14.Text = "Cidade";
			// 
			// txtBairro
			// 
			this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBairro.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBairro.Location = new System.Drawing.Point(322, 264);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(422, 26);
			this.txtBairro.TabIndex = 13;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(319, 248);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(45, 18);
			this.label15.TabIndex = 27;
			this.label15.Text = "Bairro";
			// 
			// txtCEP
			// 
			this.txtCEP.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCEP.Location = new System.Drawing.Point(89, 264);
			this.txtCEP.Name = "txtCEP";
			this.txtCEP.Size = new System.Drawing.Size(205, 26);
			this.txtCEP.TabIndex = 12;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(86, 248);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(31, 18);
			this.label16.TabIndex = 29;
			this.label16.Text = "CEP";
			// 
			// txtUF
			// 
			this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUF.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUF.Location = new System.Drawing.Point(698, 327);
			this.txtUF.Name = "txtUF";
			this.txtUF.Size = new System.Drawing.Size(46, 26);
			this.txtUF.TabIndex = 15;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(695, 311);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(25, 18);
			this.label17.TabIndex = 31;
			this.label17.Text = "UF";
			// 
			// dtDataCad
			// 
			this.dtDataCad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtDataCad.Location = new System.Drawing.Point(452, 50);
			this.dtDataCad.Name = "dtDataCad";
			this.dtDataCad.Size = new System.Drawing.Size(292, 26);
			this.dtDataCad.TabIndex = 32;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(449, 29);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(112, 18);
			this.label11.TabIndex = 33;
			this.label11.Text = "Data de Cadastro";
			// 
			// frmCadastroCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Name = "frmCadastroCliente";
			this.Text = "Cadastro de Cliente";
			this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
			this.pnDados.ResumeLayout(false);
			this.pnDados.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTelefone2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtddd2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtTelefone1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCNPJ;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtddd1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCPF;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtRua;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtUF;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtCEP;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DateTimePicker dtDataCad;
	}
}
