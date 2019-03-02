using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
	public class DALEditora
	{
		private DALConexao conexao;
		public DALEditora (DALConexao cx)
		{
			this.conexao = cx;
		}
		public void Incluir(ModeloEditora modelo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = "Insert into editora  (id_editora, edi_nome) values (@ideditora, @nome);";
			cmd.Parameters.AddWithValue("ideditora", modelo.ideditora);
			cmd.Parameters.AddWithValue("nome", modelo.nomeeditora);
			//conecta ao banco
			conexao.Conectar();
			// executa os comandos
			cmd.ExecuteNonQuery();
			// fecha a conexao
			conexao.Desconectar();
		}
		public void Alterar(ModeloEditora modelo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = "update editora set id_editora = @ideditora, edi_nome =  @nome;";
			cmd.Parameters.AddWithValue("ideditora", modelo.ideditora);
			cmd.Parameters.AddWithValue("nome", modelo.nomeeditora);
			conexao.Conectar();
			cmd.ExecuteNonQuery();
			conexao.Desconectar();
		}
		public void Excluir(int codigo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = " delete from editora where id_editora = @ideditora;";
			cmd.Parameters.AddWithValue("@ideditora", codigo);
			conexao.Conectar();
			cmd.ExecuteNonQuery();
			conexao.Desconectar();

		}
		public DataTable Localizar(String valor)
		{
			DataTable tabela = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter("Select * from editora where edi_nome like '%" + valor + "%'", conexao.StringConexao);
			da.Fill(tabela);
			return tabela;
		}
		public ModeloEditora CarregaModeloEditora (int codigo)
		{
			ModeloEditora modelo = new ModeloEditora ();
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = " Select * from editora where id_editora = @ideditora;";
			cmd.Parameters.AddWithValue("@ideditora", codigo);
			conexao.Conectar();
			MySqlDataReader registro = cmd.ExecuteReader();

			if (registro.HasRows)
			{
				registro.Read();
				modelo.ideditora = Convert.ToInt32(registro["id_editora"]);
				modelo.nomeeditora = Convert.ToString(registro["edi_nome"]);

			}
			conexao.Desconectar();
			return modelo;
		}
	}
}
