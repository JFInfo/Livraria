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
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void frmPrincipal_Load(object sender, EventArgs e)
		{

		}

		private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCadastroCliente f = new frmCadastroCliente();
			f.ShowDialog();
			f.Dispose();
		}

		private void testeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmConsultaCliente f = new frmConsultaCliente();
			f.ShowDialog();
			f.Dispose();

		}

		

		private void livroToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmCadastroLivros f = new FrmCadastroLivros();
			f.ShowDialog();
			f.Dispose();

		}

		private void livroToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmConsultaLivro f = new frmConsultaLivro();
			f.ShowDialog();
			f.Dispose();

		}

		private void autorToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmConsultaAutor f = new frmConsultaAutor();
			f.ShowDialog();
			f.Dispose();
		}

		private void editoraToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmConsultaEditora f = new frmConsultaEditora();
			f.ShowDialog();
			f.Dispose();
		}

		private void generoToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmConsultaGenero f = new frmConsultaGenero();
			f.ShowDialog();
			f.Dispose();
		}

		private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCadastroEditora f = new frmCadastroEditora();
			f.ShowDialog();
			f.Dispose();
		}

		private void autorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCadastroAutor f = new frmCadastroAutor();
			f.ShowDialog();
			f.Dispose();
		}

		private void generoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCadastroGenero f = new frmCadastroGenero();
			f.ShowDialog();
			f.Dispose();
		}
	}
}
