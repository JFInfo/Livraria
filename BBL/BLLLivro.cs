using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using System.Data;

namespace BBL
{
	public class BLLLivro
	{
		private DALConexao conexao;
		public BLLLivro(DALConexao cx)
		{
			this.conexao = cx;

		}
		public void Incluir(ModeloLivro modelo)
		{
			//validando se o campo fio preenchido//

			if (modelo.lvtitulo.Trim().Length == 0)
			{
				throw new Exception("O Titulo é obrigatório!");
			}
			if (modelo.lvisbn.Trim().Length == 0)
			{
				throw new Exception("O ISBN é obrigatório!");
			}
			if (modelo.lvqnt <= 0)
			{
				throw new Exception("A quantidade é obrigatório!");
			}

			if (modelo.lvvalorvd <= 0)
			{
				throw new Exception("Valor de Venda é obrigatório!");
			}
			if (modelo.lvvalorpg <= 0)
			{
				throw new Exception("Valor de Pago é obrigatório!");
			}
			//passando para Maiusculo
			//modelo.nomecli = modelo.nomecli.ToUpper();

			DALLivro DALobj = new DALLivro(conexao);
			DALobj.Incluir(modelo);
		}
		public void Alterar(ModeloLivro modelo)
		{
			//validando se o campo fio preenchido//
			if (modelo.lvtitulo.Trim().Length == 0)
			{
				throw new Exception("O Titulo é obrigatório!");
			}
			if (modelo.lvisbn.Trim().Length == 0)
			{
				throw new Exception("O ISBN é obrigatório!");
			}
			if (modelo.lvqnt <= 0)
			{
				throw new Exception("A quantidade é obrigatório!");
			}

			if (modelo.lvvalorvd <= 0)
			{
				throw new Exception("Valor de Venda é obrigatório!");
			}
			if (modelo.lvvalorpg <= 0)
			{
				throw new Exception("Valor de Pago é obrigatório!");
			}

			//passando para Maiusculo

			//modelo.nomecli = modelo.nomecli.ToUpper();

			DALLivro DALobj = new DALLivro(conexao);
			DALobj.Alterar(modelo);
		}
		public void Excluir(int codigo)
		{
			DALLivro DALobj = new DALLivro(conexao);
			DALobj.Excluir(codigo);
		}
		public DataTable Localizar(String valor)
		{
			DALLivro DALobj = new DALLivro(conexao);
			return DALobj.Localizar(valor);
		}
		public ModeloLivro CarregaModeloLivro(int codigo)
		{
			DALLivro DALobj = new DALLivro(conexao);
			return DALobj.CarregaModeloLivro(codigo);
		}

	}
}
