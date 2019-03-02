using BBL;
using DAL;
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
	public partial class frmConsultaCliente : Form
	{
		public int codigo = 0;

		public frmConsultaCliente()
		{
			InitializeComponent();
		}

		private void btLocalizar_Click(object sender, EventArgs e)
		{
			DALConexao cx = new DALConexao(DadosDaConexao.StringdeConexao);
			BLLCliente bll = new BLLCliente(cx);
			dgvDados.DataSource = bll.Localizar(txtValor.Text);

		}

		private void txtLocalizar_TextChanged(object sender, EventArgs e)
		{

		}

		private void frmConsultaCliente_Load(object sender, EventArgs e)
		{
			btLocalizar_Click(sender, e);

			dgvDados.Columns[0].HeaderText = "Codigo";
			dgvDados.Columns[0].Width = 50;
			dgvDados.Columns[1].HeaderText = "Nome";
			dgvDados.Columns[2].HeaderText = "CPF";
			dgvDados.Columns[3].HeaderText = "CNPJ";
			dgvDados.Columns[4].HeaderText = "DDD1";
			dgvDados.Columns[5].HeaderText = "Telefone";
			dgvDados.Columns[6].HeaderText = "DDD2";
			dgvDados.Columns[7].HeaderText = "Telefone2";
			dgvDados.Columns[8].HeaderText = "Email";
			dgvDados.Columns[9].HeaderText = "Logradouro";
			dgvDados.Columns[10].HeaderText = "Numero";
			dgvDados.Columns[10].Width = 50 ;
			dgvDados.Columns[11].HeaderText = "Bairro";
			dgvDados.Columns[12].HeaderText = "Cidade";
			dgvDados.Columns[13].HeaderText = "CEP";
			dgvDados.Columns[14].HeaderText = "UF";
			dgvDados.Columns[14].Width = 35 ;
			dgvDados.Columns[15].HeaderText = "DATACAD";
		}

		private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// EVENTO CELLDOUBLECLICK
			// Se a linha selecionada for maior que 0 significa que o usuario clicou em uma linha
			// Entao vai alterar a propriedade codigo pegando o valor da celular 0 da linha selecionada pelo usuario, convertendo o valor para inteiro
			//fecha o frm

			if (e.RowIndex >= 0)
			{
				this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
				this.Close();

			}

		}
	}
}
