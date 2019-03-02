using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;

namespace BBL
{
	public class BLLEditora
	{
		private DALConexao conexao;
		public BLLEditora (DALConexao cx)
		{
			this.conexao = cx;

		}
		public void Incluir(ModeloEditora modelo)
		{
			//validando se o campo fio preenchido//

			if (modelo.nomeeditora.Trim().Length == 0)
			{
				throw new Exception("O nome da Editora é obrigatório!");
			}

			DALEditora DALobj = new DALEditora (conexao);
			DALobj.Incluir(modelo);
		}
		public void Alterar(ModeloEditora modelo)
		{
			//validando se o campo fio preenchido//

			if (modelo.nomeeditora.Trim().Length == 0)
			{
				throw new Exception("O nome da Editora é obrigatório!");
			}

			DALEditora DALobj = new DALEditora(conexao);
			DALobj.Alterar(modelo);
		}
		public void Excluir(int codigo)
		{
			DALEditora DALobj = new DALEditora (conexao);
			DALobj.Excluir(codigo);
		}
		public DataTable Localizar(String valor)
		{
			DALEditora DALobj = new DALEditora (conexao);
			return DALobj.Localizar(valor);
		}
		public ModeloEditora CarregaModeloAutor(int codigo)
		{
			DALEditora DALobj = new DALEditora (conexao);
			return DALobj.CarregaModeloEditora(codigo);
		}
	}
}
