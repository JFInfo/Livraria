using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
	public partial class frmCadastroLivro : GUI.frmModeloFormCadastro
	{
		public frmCadastroLivro()
		{
			InitializeComponent();
		}

		private void frmCastroLivro_Load(object sender, EventArgs e)
		{
			this.alteraBotoes(1);
		}

		private void btInserir_Click(object sender, EventArgs e)
		{
			this.operacao = "Inserir";
			this.alteraBotoes(2);
		}
	}
}
