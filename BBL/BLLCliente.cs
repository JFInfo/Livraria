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
	public class BLLCliente
	{
		private DALConexao conexao;
		public BLLCliente(DALConexao cx)
		{
			this.conexao = cx;

		}
		public void Incluir(ModeloCliente modelo)
		{
			//validando se o campo fio preenchido//

			if (modelo.nomecli.Trim().Length == 0)
			{
				throw new Exception("O nome do Grupo é obrigatório!");
			}

			//passando para Maiusculo

			modelo.nomecli = modelo.nomecli.ToUpper();
			DALCliente DALobj = new DALCliente(conexao);
			DALobj.Incluir(modelo);
		}
		public void Alterar(ModeloCliente modelo)
		{
			//validando se o campo fio preenchido//
			if (modelo.idcli <= 0)
			{
				throw new Exception("O codigo do cliente é obrigatório!");
			}

			if (modelo.nomecli.Trim().Length == 0)
			{
				throw new Exception("O nome do cliente é obrigatório!");
			}

			//passando para Maiusculo

			modelo.nomecli = modelo.nomecli.ToUpper();

			DALCliente DALobj = new DALCliente(conexao);
			DALobj.Alterar(modelo);
		}
		public void Excluir(int codigo)
		{
			DALCliente DALobj = new DALCliente(conexao);
			DALobj.Excluir(codigo);
		}
		public DataTable Localizar(String valor)
		{
			DALCliente DALobj = new DALCliente(conexao);
			return DALobj.Localizar(valor);
		}
		public ModeloCliente CarregaModeloCliente(int codigo)
		{
			DALCliente DALobj = new DALCliente(conexao);
			return DALobj.CarregaModeloCliente(codigo);
		}

	}
}
