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
	public class DALAutor
	{
		private DALConexao conexao;
		public DALAutor(DALConexao cx)
		{
			this.conexao = cx;
		}
		public void Incluir(ModeloAutor modelo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = "Insert into autor  (id_autor, at_nome) values (@idautor, @nome);";
			cmd.Parameters.AddWithValue("idautor", modelo.idautor);
			cmd.Parameters.AddWithValue("nome", modelo.nomeautor);			
			//conecta ao banco
			conexao.Conectar();
			// executa os comandos
			cmd.ExecuteNonQuery();
			// fecha a conexao
			conexao.Desconectar();
		}
		public void Alterar(ModeloAutor modelo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = "update autor set id_autor = @idautor, at_nome =  @nome;";
			cmd.Parameters.AddWithValue("idautor", modelo.idautor);
			cmd.Parameters.AddWithValue("nome", modelo.nomeautor);
			conexao.Conectar();
			cmd.ExecuteNonQuery();
			conexao.Desconectar();
		}
		public void Excluir(int codigo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = " delete from autor where id_autor = @idautor;";
			cmd.Parameters.AddWithValue("@idautor", codigo);
			conexao.Conectar();
			cmd.ExecuteNonQuery();
			conexao.Desconectar();

		}
		public DataTable Localizar(String valor)
		{
			DataTable tabela = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter("Select * from autor where at_nome like '%" + valor + "%'", conexao.StringConexao);
			da.Fill(tabela);
			return tabela;
		}
		public ModeloAutor CarregaModeloAutor(int codigo)
		{
			ModeloAutor modelo = new ModeloAutor();
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = " Select * from autor where id_autor = @idautor;";
			cmd.Parameters.AddWithValue("@idautor", codigo);
			conexao.Conectar();
			MySqlDataReader registro = cmd.ExecuteReader();

			if (registro.HasRows)
			{
				registro.Read();
				modelo.idautor = Convert.ToInt32(registro["id_autor"]);
				modelo.nomeautor = Convert.ToString(registro["at_nome"]);
				
			}
			conexao.Desconectar();
			return modelo;
		}
	}
}
