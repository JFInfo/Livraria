using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BBL;
using Modelo;


namespace GUI
{
	public partial class frmConsultaAutor : Form
	{
		public int codigo = 0;

		public frmConsultaAutor()
		{
			InitializeComponent();
		}

		private void frmConsultaAutor_Load(object sender, EventArgs e)
		{
			btLocalizar_Click(sender, e);

			dgvDados.Columns[0].HeaderText = "Codigo";
			dgvDados.Columns[0].Width = 50;
			dgvDados.Columns[1].HeaderText = "Nome";
			dgvDados.Columns[1].Width = 700;
		}

		private void btLocalizar_Click(object sender, EventArgs e)
		{
			DALConexao cx = new DALConexao(DadosDaConexao.StringdeConexao);
			BLLAutor bll = new BLLAutor (cx);
			dgvDados.DataSource = bll.Localizar(txtValor.Text);
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
