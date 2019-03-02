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
	public class BLLGenero
	{
		private DALConexao conexao;
		public BLLGenero (DALConexao cx)
		{
			this.conexao = cx;

		}
		public void Incluir(ModeloGenero modelo)
		{
			//validando se o campo fio preenchido//

			if (modelo.nomegenero.Trim().Length == 0)
			{
				throw new Exception("O nome do Genero é obrigatório!");
			}

			DALGenero DALobj = new DALGenero (conexao);
			DALobj.Incluir(modelo);
		}
		public void Alterar(ModeloGenero modelo)
		{
			//validando se o campo fio preenchido//

			if (modelo.nomegenero.Trim().Length == 0)
			{
				throw new Exception("O nome do Genero é obrigatório!");
			}

			DALGenero DALobj = new DALGenero (conexao);
			DALobj.Alterar(modelo);
		}
		public void Excluir(int codigo)
		{
			DALGenero DALobj = new DALGenero(conexao);
			DALobj.Excluir(codigo);
		}
		public DataTable Localizar(String valor)
		{
			DALGenero DALobj = new DALGenero(conexao);
			return DALobj.Localizar(valor);
		}
		public ModeloGenero CarregaModeloGenero (int codigo)
		{
			DALGenero DALobj = new DALGenero(conexao);
			return DALobj.CarregaModeloGenero (codigo);
		}
	}
}
