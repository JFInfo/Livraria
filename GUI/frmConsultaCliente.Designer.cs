namespace GUI
{
	partial class frmConsultaCliente
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
			this.lbCliente = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.dgvDados = new System.Windows.Forms.DataGridView();
			this.btLocalizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
			this.SuspendLayout();
			// 
			// lbCliente
			// 
			this.lbCliente.AutoSize = true;
			this.lbCliente.Location = new System.Drawing.Point(27, 35);
			this.lbCliente.Name = "lbCliente";
			this.lbCliente.Size = new System.Drawing.Size(39, 13);
			this.lbCliente.TabIndex = 0;
			this.lbCliente.Text = "Cliente";
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(30, 65);
			this.txtValor.Multiline = true;
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(630, 20);
			this.txtValor.TabIndex = 1;
			this.txtValor.TextChanged += new System.EventHandler(this.txtLocalizar_TextChanged);
			// 
			// dgvDados
			// 
			this.dgvDados.AllowUserToAddRows = false;
			this.dgvDados.AllowUserToDeleteRows = false;
			this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDados.Location = new System.Drawing.Point(30, 138);
			this.dgvDados.Name = "dgvDados";
			this.dgvDados.ReadOnly = true;
			this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDados.Size = new System.Drawing.Size(724, 402);
			this.dgvDados.TabIndex = 2;
			this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
			// 
			// btLocalizar
			// 
			this.btLocalizar.Location = new System.Drawing.Point(679, 65);
			this.btLocalizar.Name = "btLocalizar";
			this.btLocalizar.Size = new System.Drawing.Size(75, 23);
			this.btLocalizar.TabIndex = 3;
			this.btLocalizar.Text = "Localizar";
			this.btLocalizar.UseVisualStyleBackColor = true;
			this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
			// 
			// frmConsultaCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.btLocalizar);
			this.Controls.Add(this.dgvDados);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.lbCliente);
			this.Name = "frmConsultaCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta Cliente";
			this.Load += new System.EventHandler(this.frmConsultaCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbCliente;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.DataGridView dgvDados;
		private System.Windows.Forms.Button btLocalizar;
	}
}