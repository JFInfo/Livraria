﻿namespace GUI
{
	partial class frmConsultaAutor
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
			this.dgvDados = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.btLocalizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDados
			// 
			this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDados.Location = new System.Drawing.Point(30, 138);
			this.dgvDados.Name = "dgvDados";
			this.dgvDados.Size = new System.Drawing.Size(724, 402);
			this.dgvDados.TabIndex = 0;
			this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Autor";
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(30, 65);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(630, 20);
			this.txtValor.TabIndex = 2;
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
			// frmConsultaAutor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.btLocalizar);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvDados);
			this.Name = "frmConsultaAutor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta Autor";
			this.Load += new System.EventHandler(this.frmConsultaAutor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDados;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.Button btLocalizar;
	}
}