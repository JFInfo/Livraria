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
	public class DALLivro
	{
		private DALConexao conexao;
		public DALLivro(DALConexao cx)
		{
			this.conexao = cx;
		}
		public void Incluir(ModeloLivro modelo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = "Insert into livro (lv_isbn, lv_valor_pg, lv_titulo, lv_volume,lv_valor_vd, lv_mesano_edi, lv_descricao, lv_qnt, lv_data_cad, lv_capa, lv_peso, id_autor, id_genero, id_editora)" +
				" values (@isbn, @valorpg,@titulo,@volume, @valorvd, @mesano, @descri, @quantidade, @datacad, @capa, @peso,@fkidautor,@fkidgenero,@fkideditora);";

			cmd.Parameters.AddWithValue("@isbn", modelo.lvisbn);
			cmd.Parameters.AddWithValue("@valorpg", modelo.lvvalorpg);
			cmd.Parameters.AddWithValue("@titulo", modelo.lvtitulo);
			cmd.Parameters.AddWithValue("@volume", modelo.lvvolume);
			cmd.Parameters.AddWithValue("@valorvd", modelo.lvvalorvd);
			cmd.Parameters.AddWithValue("@mesano", modelo.lvmesanoadi);
			cmd.Parameters.AddWithValue("@descri", modelo.lvdescricao);
			cmd.Parameters.AddWithValue("@quantidade", modelo.lvqnt);
			cmd.Parameters.AddWithValue("@datacad", modelo.lvdatacad);
			cmd.Parameters.AddWithValue("@capa", modelo.lvcapa);

			cmd.Parameters.AddWithValue("@capa", System.Data.SqlDbType.Image);
			
			/*if (modelo.lvcapa ==null)
			{
				cmd.Parameters.AddWithValue("@capa", DBNull.Value);
				//cmd.Parameters["@capa"].Value = DBNull.Value;
			}
			else
			{
				cmd.Parameters.AddWithValue("@capa", DBNull.Value);
				//cmd.Parameters["@capa"].Value = modelo.lvcapa;
			}*/
		
			cmd.Parameters.AddWithValue("@peso", modelo.lvpeso);
			cmd.Parameters.AddWithValue("@fkidautor", modelo.fkidautor);
			cmd.Parameters.AddWithValue("@fkidgenero", modelo.fkidgenero);
			cmd.Parameters.AddWithValue("@fkideditora", modelo.fkideditora);


			//conecta ao banco
			conexao.Conectar();
			// executa os comandos
			cmd.ExecuteNonQuery();
			// fecha a conexao
			conexao.Desconectar();
		}
		public void Alterar(ModeloLivro modelo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = "update livro set lv_isbn= @isbn, lv_valor_pg= @valorpg, lv_titulo= @titulo,lv_volume= @volume,"+
				" lv_valorvd= @valorvd, lv_mesano_edi= @mesano, lv_descricao= @descri, lv_qnt=@quantidade, lv_data_cad= @datacad, "+
				"lv_capa= @capa, lv_peso=@peso,id_autor = @fkidautor, id_genero = @fkidgenero, id_editora = @fkideditora where id_livro= @idlivro;";

			cmd.Parameters.AddWithValue("@isbn", modelo.lvisbn);
			cmd.Parameters.AddWithValue("@valorpg", modelo.lvvalorpg);
			cmd.Parameters.AddWithValue("@titulo", modelo.lvtitulo);
			cmd.Parameters.AddWithValue("@volume", modelo.lvvolume);
			cmd.Parameters.AddWithValue("@valorvd", modelo.lvvalorvd);
			cmd.Parameters.AddWithValue("@mesano", modelo.lvmesanoadi);
			cmd.Parameters.AddWithValue("@descri", modelo.lvdescricao);
			cmd.Parameters.AddWithValue("@quantidade", modelo.lvqnt);
			cmd.Parameters.AddWithValue("@datacad", modelo.lvdatacad);
			cmd.Parameters.AddWithValue("@capa", modelo.lvcapa);

			/*if (modelo.lvcapa == null)
			{
				//cmd.Parameters.AddWithValue("@lv_capa", DBNull.Value);
				cmd.Parameters["@capa"].Value = DBNull.Value;
			}
			else
			{
				//cmd.Parameters.AddWithValue("@lv_capa", DBNull.Value);
				cmd.Parameters["@capa"].Value = modelo.lvcapa;
			}*/

			cmd.Parameters.AddWithValue("@peso", modelo.lvpeso);
			cmd.Parameters.AddWithValue("@fkidautor", modelo.fkidautor);
			cmd.Parameters.AddWithValue("@fkidgenero", modelo.fkidgenero);
			cmd.Parameters.AddWithValue("@fkideditora", modelo.fkideditora);

			conexao.Conectar();
			cmd.ExecuteNonQuery();
			conexao.Desconectar();
		}
		public void Excluir(int codigo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = " delete from livro where id_livro = @idlivro;";
			cmd.Parameters.AddWithValue("@idlivro", codigo);
			conexao.Conectar();
			cmd.ExecuteNonQuery();
			conexao.Desconectar();

		}
		public DataTable Localizar(String valor)
		{
			DataTable tabela = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter("Select * from livro where lv_titulo like '%" + valor + "%'", conexao.StringConexao);
			da.Fill(tabela);
			return tabela;
		}
		public ModeloLivro CarregaModeloLivro(int codigo)
		{
			ModeloLivro modelo = new ModeloLivro();
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = " Select * from livro where id_livro = @idlivro;";
			cmd.Parameters.AddWithValue("@idlivro", codigo);
			conexao.Conectar();
			MySqlDataReader registro = cmd.ExecuteReader();

			if (registro.HasRows)
			{
				registro.Read();
				modelo.idlivro = Convert.ToInt32(registro["id_livro"]);
				modelo.lvisbn = Convert.ToString(registro["lv_isbn"]);
				modelo.lvvalorpg = Convert.ToDouble(registro["lv_valor_pg"]);
				modelo.lvtitulo = Convert.ToString(registro["lv_titulo"]);
				modelo.lvvolume = Convert.ToString(registro["lv_volume"]);
				modelo.lvvalorvd = Convert.ToDouble(registro["lv_valor_vd"]);				
				modelo.lvmesanoadi= Convert.ToString(registro["lv_mesano_edi"]);				
				modelo.lvdescricao = Convert.ToString(registro["lv_descricao"]);
				modelo.lvqnt = Convert.ToInt32(registro["lv_qnt"]);
				modelo.lvdatacad = Convert.ToDateTime(registro["lv_data_cad"]);
				modelo.lvcapa = Convert.ToString(registro["lv_capa"]);
				/*try
				{
					modelo.lvcapa = (byte[])registro["lv_capa"];
				}

				catch { }*/

				modelo.lvpeso = Convert.ToDouble(registro["lv_peso"]);

				modelo.fkidautor = Convert.ToInt32(registro["id_autor"]);
				modelo.fkidgenero = Convert.ToInt32(registro["id_genero"]);
				modelo.fkideditora = Convert.ToInt32(registro["id_editora"]);


			}
			
			return modelo;
			conexao.Desconectar();
		}
	}
}
