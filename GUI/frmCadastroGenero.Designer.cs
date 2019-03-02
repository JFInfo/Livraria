namespace GUI
{
	partial class frmCadastroGenero
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
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtGenero = new System.Windows.Forms.TextBox();
			this.pnDados.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnDados
			// 
			this.pnDados.Controls.Add(this.label2);
			this.pnDados.Controls.Add(this.txtGenero);
			this.pnDados.Controls.Add(this.label1);
			this.pnDados.Controls.Add(this.txtCodigo);
			this.pnDados.Size = new System.Drawing.Size(760, 241);
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(12, 259);
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
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(15, 34);
			this.txtCodigo.Multiline = true;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 27);
			this.txtCodigo.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Código";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Genero";
			// 
			// txtGenero
			// 
			this.txtGenero.Location = new System.Drawing.Point(15, 90);
			this.txtGenero.Multiline = true;
			this.txtGenero.Name = "txtGenero";
			this.txtGenero.Size = new System.Drawing.Size(686, 31);
			this.txtGenero.TabIndex = 2;
			// 
			// frmCadastroGenero
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(784, 362);
			this.Name = "frmCadastroGenero";
			this.Load += new System.EventHandler(this.frmCadastroGenero_Load);
			this.pnDados.ResumeLayout(false);
			this.pnDados.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtGenero;
	}
}
