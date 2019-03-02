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
	public class DALGenero
	{
		private DALConexao conexao;
		public DALGenero(DALConexao cx)
		{
			this.conexao = cx;
		}
		public void Incluir(ModeloGenero modelo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = "Insert into genero  (id_genero, gen_nome) values (@idgenero, @nome);";
			cmd.Parameters.AddWithValue("idgenero", modelo.idgenero);
			cmd.Parameters.AddWithValue("nome", modelo.nomegenero);
			//conecta ao banco
			conexao.Conectar();
			// executa os comandos
			cmd.ExecuteNonQuery();
			// fecha a conexao
			conexao.Desconectar();
		}
		public void Alterar(ModeloGenero modelo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = "update genero set id_genero = @idgenero, gen_nome = @nome;";
			cmd.Parameters.AddWithValue("idgenero", modelo.idgenero);
			cmd.Parameters.AddWithValue("nome", modelo.nomegenero);
			conexao.Conectar();
			cmd.ExecuteNonQuery();
			conexao.Desconectar();
		}
		public void Excluir(int codigo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = " delete from genero where id_genero = @idgenero;";
			cmd.Parameters.AddWithValue("@idgenero", codigo);
			conexao.Conectar();
			cmd.ExecuteNonQuery();
			conexao.Desconectar();

		}
		public DataTable Localizar(String valor)
		{
			DataTable tabela = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter("Select * from genero where gen_nome like '%" + valor + "%'", conexao.StringConexao);
			da.Fill(tabela);
			return tabela;
		}
		public ModeloGenero CarregaModeloGenero(int codigo)
		{
			ModeloGenero modelo = new ModeloGenero();
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = " Select * from genero where id_genero = @idgenero;";
			cmd.Parameters.AddWithValue("@idgenero", codigo);
			conexao.Conectar();
			MySqlDataReader registro = cmd.ExecuteReader();

			if (registro.HasRows)
			{
				registro.Read();
				modelo.idgenero = Convert.ToInt32(registro["id_genero"]);
				modelo.nomegenero = Convert.ToString(registro["gen_nome"]);

			}
			conexao.Desconectar();
			return modelo;
		}
	}
}
