using BBL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
	public partial class FrmCadastroLivros : GUI.frmModeloFormCadastro
	{
		public string capa = "";
		DateTime data;

		public FrmCadastroLivros()

		{

			InitializeComponent();
		}

		private void pnDados_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void btInserir_Click(object sender, EventArgs e)
		{

			this.operacao = "Inserir";
			this.alteraBotoes(2);
		}

		private void LimpaCampos()
		{
			txtDescricao.Clear();
			txtISBN.Clear();
			txtMesAno.Clear();
			txtPeso.Clear();
			txtQnt.Clear();
			txtTitulo.Clear();
			txtValorC.Clear();
			txtValorV.Clear();
			txtVolume.Clear();
			this.capa = "";
			pbCapa.Image = null;


		}

		private void FrmCadastroLivros_Load(object sender, EventArgs e)
		{
			this.alteraBotoes(1);

			DALConexao cx = new DALConexao(DadosDaConexao.StringdeConexao);

			//ComboBox Autor

			BLLAutor abll = new BLLAutor(cx);
			cbAutor.DataSource = abll.Localizar("");
			cbAutor.DisplayMember = "at_nome";
			cbAutor.ValueMember = "id_autor";

			//ComboBox Editora
			 
			BLLEditora ebll = new BLLEditora(cx);
			cbEditora.DataSource = ebll.Localizar("");
			cbEditora.DisplayMember = "edi_nome";
			cbEditora.ValueMember = "id_editora";

			//ComboBox Genero

			BLLGenero gbll = new BLLGenero(cx);
			cbGenero.DataSource = gbll.Localizar("");
			cbGenero.DisplayMember = "gen_nome";
			cbGenero.ValueMember = "id_genero";

		}

		private void label13_Click(object sender, EventArgs e)
		{

		}

		private void txtValorC_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
			{
				e.Handled = true;

			}
			if (e.KeyChar == ',' || e.KeyChar == '.')
			{
				if (!txtValorC.Text.Contains("."))
				{
					e.KeyChar = '.';
				}
				else e.Handled = true;
			}
		}

		private void txtValorV_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
			{
				e.Handled = true;

			}
			if (e.KeyChar == ',' || e.KeyChar == '.')
			{
				if (!txtValorV.Text.Contains("."))
				{
					e.KeyChar = '.';
				}
				else e.Handled = true;
			}
		}

		private void txtValorV_Leave(object sender, EventArgs e)
		{
			if (txtValorV.Text.Contains(".") == false)
			{
				txtValorV.Text += ".00";
			}
			else
			{
				if (txtValorV.Text.IndexOf(".") == txtValorV.Text.Length - 1)
				{
					txtValorV.Text += "00";
				}
				try
				{
					Double d = Convert.ToDouble(txtValorV.Text);
				}
				catch
				{
					txtValorV.Text = "0.00";
				}

			}
		}

		private void txtValorC_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtValorC_Leave(object sender, EventArgs e)
		{
			if (txtValorC.Text.Contains(".") == false)
			{
				txtValorC.Text += ".00";
			}
			else
			{
				if (txtValorC.Text.IndexOf(".") == txtValorC.Text.Length - 1)
				{
					txtValorC.Text += "00";
				}
				try
				{
					Double d = Convert.ToDouble(txtValorC.Text);
				}
				catch
				{
					txtValorC.Text = "0.00";
				}
			}
		}

		private void txtQnt_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtQnt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
			{
				e.Handled = true;

			}
			
		}

		private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
			{
				e.Handled = true;

			}
			if (e.KeyChar == ',' || e.KeyChar == '.')
			{
				if (!txtPeso.Text.Contains("."))
				{
					e.KeyChar = '.';
				}
				else e.Handled = true;
			}
		}

		private void txtPeso_Leave(object sender, EventArgs e)
		{
			if (txtPeso.Text.Contains(".") == false)
			{
				txtPeso.Text += ".000";
			}
			else
			{
				if (txtPeso.Text.IndexOf(".") == txtPeso.Text.Length - 1)
				{
					txtPeso.Text += "000";
				}
				try
				{
					Double d = Convert.ToDouble(txtPeso.Text);
				}
				catch
				{
					txtPeso.Text = "0.000";
				}
			}
		}

		private void btSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				//leitura dos dados digitados na tela.

				ModeloLivro modelo = new ModeloLivro();
				modelo.lvisbn = txtISBN.Text;
				modelo.lvvalorpg = Convert.ToDouble(txtValorC.Text);
				modelo.lvtitulo = txtTitulo.Text;
				modelo.lvvolume = txtVolume.Text;
				modelo.lvvalorvd = Convert.ToDouble(txtValorV.Text);
				modelo.lvmesanoadi = txtMesAno.Text;
				modelo.lvdescricao = txtDescricao.Text;
				modelo.lvqnt = Convert.ToInt32 (txtQnt.Text);
				modelo.lvdatacad = data = DateTime.Now;
				modelo.lvcapa = pbCapa.Text;
				//modelo.CarregaImagem(this.capa);
				modelo.lvpeso = Convert.ToDouble (txtPeso.Text);
				modelo.fkidautor = Convert.ToInt32(cbAutor.SelectedValue);
				modelo.fkidgenero = Convert.ToInt32(cbGenero.SelectedValue);
				modelo.fkideditora = Convert.ToInt32(cbEditora.SelectedValue);

				//obj para gravar os dados no banco

				DALConexao cx = new DALConexao(DadosDaConexao.StringdeConexao);
				BLLLivro bll = new BLLLivro(cx);

				if (this.operacao == "Inserir")
				{
					// cadastrar um livro
					bll.Incluir(modelo);
					MessageBox.Show("Cadastro Efetuado: Código" + modelo.idlivro.ToString());
				}
				else
				{
					// alterar um livro
					modelo.idlivro = Convert.ToInt32(txtCodigo.Text);
					bll.Alterar(modelo);
					MessageBox.Show("Ateração Efetuada!");
				}

				this.LimpaCampos();
				this.alteraBotoes(1);
			}
			catch (Exception erro)
			{
				MessageBox.Show(erro.Message);
			}

		}

		private void btInsCapa_Click(object sender, EventArgs e)
		{
			OpenFileDialog od = new OpenFileDialog();
			od.ShowDialog();

			Bitmap bmp = new Bitmap(od.FileName);
			Bitmap bmp2 = new Bitmap(bmp, pbCapa.Size);
			pbCapa.Image = bmp2;

			pbCapa.Image.Save(Application.StartupPath.ToString() + "" +".png", System.Drawing.Imaging.ImageFormat.Png);
			this.capa = Application.StartupPath.ToString() + ".png";

			pbCapa.Load(this.capa);

		}

		private void btRemCapa_Click(object sender, EventArgs e)
		{
			this.capa = "";
			pbCapa.Image = null;

		}

		private void btCancelar_Click(object sender, EventArgs e)
		{
			this.alteraBotoes(1);
			this.LimpaCampos();
		}
	}
}
