using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using DAL;
using BBL;



namespace GUI
{
	public partial class frmCadastroEditora : GUI.frmModeloFormCadastro
	{
		public frmCadastroEditora()
		{
			InitializeComponent();
		}
		public void LimpaTela()
		{
			txtCodigo.Clear();
			txtEditora.Clear();

		}

		private void btInserir_Click(object sender, EventArgs e)
		{
			this.operacao = "Inserir";
			this.alteraBotoes(2);
		}

		private void frmCadastroEditora_Load(object sender, EventArgs e)
		{
			this.alteraBotoes(1);
		}

		private void btCancelar_Click(object sender, EventArgs e)
		{
			this.LimpaTela();
			this.alteraBotoes(1);
		}

		private void btSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				//leitura dos dados digitados na tela.

				ModeloEditora modelo = new ModeloEditora();
				modelo.nomeeditora = txtEditora.Text;

				//obj para gravar os dados no banco

				DALConexao cx = new DALConexao(DadosDaConexao.StringdeConexao);
				 BLLEditora bll = new BLLEditora(cx);

				if (this.operacao == "Inserir")
				{
					// cadastrar um cliente
					bll.Incluir(modelo);
					MessageBox.Show("Cadastro Efetuado: Código" + modelo.ideditora.ToString());
				}
				else
				{
					// alterar um cliente
					modelo.ideditora = Convert.ToInt32(txtCodigo.Text);
					bll.Alterar(modelo);
					MessageBox.Show("Ateração Efetuada!");
				}

				this.LimpaTela();
				this.alteraBotoes(1);
			}
			catch (Exception erro)
			{
				MessageBox.Show(erro.Message);
			}

		}

		private void btAlterar_Click(object sender, EventArgs e)
		{
			this.operacao = "Alterar";
			this.alteraBotoes(2);
		}

		private void btExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult d = MessageBox.Show("Deseja Excluir o Registro?", "Atenção", MessageBoxButtons.YesNo);
				if (d.ToString() == "Yes")
				{
					DALConexao cx = new DALConexao(DadosDaConexao.StringdeConexao);
					BLLEditora bll = new BLLEditora (cx);
					bll.Excluir(Convert.ToInt32(txtCodigo.Text));
					this.LimpaTela();
					this.alteraBotoes(1);
				}
			}
			catch
			{
				MessageBox.Show("Impossível excluir o registro.\n O registro esta sendo utilizado em outro local.");
				this.alteraBotoes(3);
			}
		}

		private void btLocalizar_Click(object sender, EventArgs e)
		{

		}
	}
}
