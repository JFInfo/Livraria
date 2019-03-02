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
	public class BLLAutor
	{
		private DALConexao conexao;
		public BLLAutor(DALConexao cx)
		{
			this.conexao = cx;

		}
		public void Incluir(ModeloAutor modelo)
		{
			//validando se o campo fio preenchido//

			if (modelo.nomeautor.Trim().Length == 0)
			{
				throw new Exception("O nome do Autor é obrigatório!");
			}

			DALAutor DALobj = new DALAutor (conexao);
			DALobj.Incluir(modelo);
		}
		public void Alterar (ModeloAutor modelo)
		{
			//validando se o campo fio preenchido//

			if (modelo.nomeautor.Trim().Length == 0)
			{
				throw new Exception("O nome do Autor é obrigatório!");
			}

			DALAutor DALobj = new DALAutor(conexao);
			DALobj.Alterar(modelo);
		}
		public void Excluir(int codigo)
		{
			DALAutor DALobj = new DALAutor (conexao);
			DALobj.Excluir(codigo);
		}
		public DataTable Localizar(String valor)
		{
			DALAutor DALobj = new DALAutor (conexao);
			return DALobj.Localizar(valor);
		}
		public ModeloAutor CarregaModeloAutor (int codigo)
		{
			DALAutor DALobj = new DALAutor (conexao);
			return DALobj.CarregaModeloAutor(codigo);
		}
	}
}
