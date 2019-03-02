using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class frmModeloFormCadastro : Form
	{
		public String operacao;
		public frmModeloFormCadastro()
		{
			InitializeComponent();
		}
		public void alteraBotoes(int op)
		{
			// op = operacaoes que serao feitas com os botoes
			// 1 = Preparar os botoes para inserir ou localizar
			// 2 = Preparar os botoes para inserir/alterar
			// 3 = Preparar a tela para excluir ou alterar

			pnDados.Enabled = false;
			btInserir.Enabled = false;
			btAlterar.Enabled = false;
			btLocalizar.Enabled = false;
			btExcluir.Enabled = false;
			btCancelar.Enabled = false;
			btSalvar.Enabled = false;

			if (op == 1)
			{
				btInserir.Enabled = true;
				btLocalizar.Enabled = true;
			}

			if (op == 2)
			{
				pnDados.Enabled = true;
				btSalvar.Enabled = true;
				btCancelar.Enabled = true;
			}
			if (op == 3)
			{
				btAlterar.Enabled = true;
				btExcluir.Enabled = true;
				btCancelar.Enabled = true;
			}
		}

		private void frmModeloFormCadstro_Load(object sender, EventArgs e)
		{
			this.alteraBotoes(1);
		}
	}
}
