namespace GUI
{
	partial class frmConsultaGenero
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
			this.btLocalizar = new System.Windows.Forms.Button();
			this.dgvDados = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
			this.SuspendLayout();
			// 
			// btLocalizar
			// 
			this.btLocalizar.Location = new System.Drawing.Point(679, 65);
			this.btLocalizar.Name = "btLocalizar";
			this.btLocalizar.Size = new System.Drawing.Size(75, 23);
			this.btLocalizar.TabIndex = 0;
			this.btLocalizar.Text = "Localizar";
			this.btLocalizar.UseVisualStyleBackColor = true;
			this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
			// 
			// dgvDados
			// 
			this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDados.Location = new System.Drawing.Point(30, 138);
			this.dgvDados.Name = "dgvDados";
			this.dgvDados.Size = new System.Drawing.Size(724, 402);
			this.dgvDados.TabIndex = 1;
			this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Genero";
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(30, 65);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(630, 20);
			this.txtValor.TabIndex = 3;
			// 
			// frmConsultaGenero
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvDados);
			this.Controls.Add(this.btLocalizar);
			this.Name = "frmConsultaGenero";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta Genero";
			this.Load += new System.EventHandler(this.frmConsultaGenero_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btLocalizar;
		private System.Windows.Forms.DataGridView dgvDados;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtValor;
	}
}