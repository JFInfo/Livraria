namespace GUI
{
	partial class frmConsultaLivro
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btPesquisar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvDados = new System.Windows.Forms.DataGridView();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.rbAutor = new System.Windows.Forms.RadioButton();
			this.rbEditora = new System.Windows.Forms.RadioButton();
			this.rbTitulo = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
			this.SuspendLayout();
			// 
			// btPesquisar
			// 
			this.btPesquisar.Location = new System.Drawing.Point(672, 109);
			this.btPesquisar.Name = "btPesquisar";
			this.btPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btPesquisar.TabIndex = 0;
			this.btPesquisar.Text = "Localizar";
			this.btPesquisar.UseVisualStyleBackColor = true;
			this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Pesquisar Por:";
			// 
			// dgvDados
			// 
			this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDados.Location = new System.Drawing.Point(40, 161);
			this.dgvDados.Name = "dgvDados";
			this.dgvDados.Size = new System.Drawing.Size(707, 377);
			this.dgvDados.TabIndex = 2;
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(42, 112);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(597, 20);
			this.txtValor.TabIndex = 3;
			// 
			// rbAutor
			// 
			this.rbAutor.AutoSize = true;
			this.rbAutor.Location = new System.Drawing.Point(40, 66);
			this.rbAutor.Name = "rbAutor";
			this.rbAutor.Size = new System.Drawing.Size(50, 17);
			this.rbAutor.TabIndex = 4;
			this.rbAutor.TabStop = true;
			this.rbAutor.Text = "Autor";
			this.rbAutor.UseVisualStyleBackColor = true;
			// 
			// rbEditora
			// 
			this.rbEditora.AutoSize = true;
			this.rbEditora.Location = new System.Drawing.Point(161, 66);
			this.rbEditora.Name = "rbEditora";
			this.rbEditora.Size = new System.Drawing.Size(58, 17);
			this.rbEditora.TabIndex = 5;
			this.rbEditora.TabStop = true;
			this.rbEditora.Text = "Editora";
			this.rbEditora.UseVisualStyleBackColor = true;
			// 
			// rbTitulo
			// 
			this.rbTitulo.AutoSize = true;
			this.rbTitulo.Location = new System.Drawing.Point(271, 66);
			this.rbTitulo.Name = "rbTitulo";
			this.rbTitulo.Size = new System.Drawing.Size(53, 17);
			this.rbTitulo.TabIndex = 6;
			this.rbTitulo.TabStop = true;
			this.rbTitulo.Text = "Título";
			this.rbTitulo.UseVisualStyleBackColor = true;
			// 
			// frmConsultaLivro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.rbTitulo);
			this.Controls.Add(this.rbEditora);
			this.Controls.Add(this.rbAutor);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.dgvDados);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btPesquisar);
			this.Name = "frmConsultaLivro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta Livro Cadastrado";
			this.Load += new System.EventHandler(this.frmConsultaLivro_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btPesquisar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvDados;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.RadioButton rbAutor;
		private System.Windows.Forms.RadioButton rbEditora;
		private System.Windows.Forms.RadioButton rbTitulo;
	}
}