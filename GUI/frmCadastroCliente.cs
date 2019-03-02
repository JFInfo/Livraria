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
	public partial class frmCadastroCliente : GUI.frmModeloFormCadastro
	{
		DateTime data;

		public frmCadastroCliente()
		{
			InitializeComponent();
		}
		public void LimpaTela()
		{
			txtCodigo.Clear();
			txtNome.Clear();
			txtCPF.Clear();
			txtCNPJ.Clear();
			txtddd1.Clear();
			txtTelefone1.Clear();
			txtddd2.Clear();
			txtTelefone2.Clear();
			txtEmail.Clear();
			txtRua.Clear();
			txtNumero.Clear();
			txtBairro.Clear();
			txtCidade.Clear();
			txtCEP.Clear();
			txtUF.Clear();
		}
		private void frmCadastroCliente_Load(object sender, EventArgs e)
		{
			this.alteraBotoes(1);
		}

		private void btInserir_Click(object sender, EventArgs e)
		{
			this.operacao = "Inserir";
			this.alteraBotoes(2);
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void pnDados_Paint(object sender, PaintEventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

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

				ModeloCliente modelo = new ModeloCliente();
				modelo.nomecli = txtNome.Text;
				modelo.cpfcli = txtCPF.Text;
				modelo.cnpjcli = txtCNPJ.Text;
				modelo.dddcli = txtddd1.Text;
				modelo.telcli = txtTelefone1.Text;
				modelo.emailcli = txtEmail.Text;
				modelo.ruacli = txtRua.Text;
				modelo.numerocli = txtNumero.Text;
				modelo.bairrocli = txtBairro.Text;
				modelo.cidadecli = txtCidade.Text;
				modelo.ufcli = txtUF.Text;
				modelo.datacadcli = data = DateTime.Now;
				modelo.telcli2 = txtTelefone2.Text;
				modelo.dddcli2 = txtddd2.Text;
				modelo.cepcli = txtCEP.Text;

				//obj para gravar os dados no banco

				DALConexao cx = new DALConexao(DadosDaConexao.StringdeConexao);
				BLLCliente bll = new BLLCliente(cx);

				if (this.operacao == "Inserir")
				{
					// cadastrar um cliente
					bll.Incluir(modelo);
					MessageBox.Show("Cadastro Efetuado: Código"+modelo.idcli.ToString());
				}
				else
				{
					// alterar um cliente
					modelo.idcli = Convert.ToInt32(txtCodigo.Text);
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
				if(d.ToString() == "Yes")
				{
					DALConexao cx = new DALConexao(DadosDaConexao.StringdeConexao);
					BLLCliente bll = new BLLCliente(cx);
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
			frmConsultaCliente f = new frmConsultaCliente();
			f.ShowDialog();
			if (f.codigo != 0)
			{
				DALConexao cx = new DALConexao(DadosDaConexao.StringdeConexao);
				BLLCliente bll = new BLLCliente(cx);
				ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
				txtCodigo.Text = modelo.idcli.ToString();
				txtNome.Text = modelo.nomecli;
				txtCNPJ.Text = modelo.cnpjcli;
				txtCPF.Text = modelo.cpfcli;
				txtddd1.Text = modelo.dddcli;
				txtTelefone1.Text = modelo.telcli;
				txtddd2.Text = modelo.dddcli2;
				txtTelefone2.Text = modelo.telcli2;
				txtEmail.Text = modelo.emailcli;
				txtRua.Text = modelo.ruacli;
				txtNumero.Text = modelo.numerocli;
				txtBairro.Text = modelo.bairrocli;
				txtCidade.Text = modelo.cidadecli;
				txtCEP.Text = modelo.cepcli;
				txtUF.Text = modelo.ufcli;

				this.alteraBotoes(3);
			}

			else
			{
				this.LimpaTela();
				this.alteraBotoes(1);

			}

			f.Dispose();
		}

		private void txtCodigo_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
