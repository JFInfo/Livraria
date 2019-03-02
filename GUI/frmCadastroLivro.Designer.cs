namespace GUI
{
	partial class frmCadastroLivro
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pnDados.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnDados
			// 
			this.pnDados.Controls.Add(this.textBox1);
			// 
			// btInserir
			// 
			this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(128, 100);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(463, 20);
			this.textBox1.TabIndex = 0;
			// 
			// frmCastroLivro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Name = "frmCastroLivro";
			this.Load += new System.EventHandler(this.frmCastroLivro_Load);
			this.pnDados.ResumeLayout(false);
			this.pnDados.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
	}
}
