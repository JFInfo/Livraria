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
	public partial class frmConsultaLivro : Form
	{
		public int codigo = 0;

		public frmConsultaLivro()
		{
			InitializeComponent();
		}

		private void btPesquisar_Click(object sender, EventArgs e)
		{
			DALConexao cx = new DALConexao(DadosDaConexao.StringdeConexao);
			BLLLivro bll = new BLLLivro(cx);
			dgvDados.DataSource = bll.Localizar(txtValor.Text);
		}

		private void frmConsultaLivro_Load(object sender, EventArgs e)
		{
			
		}
	}
}
