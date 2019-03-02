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
	public class DALCliente
	{
		private DALConexao conexao;
		public DALCliente (DALConexao cx)
		{
			this.conexao = cx;
		}
		public void Incluir (ModeloCliente modelo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = "Insert into cliente (cli_nome, cli_cnpj,cli_cpf,cli_tel_ddd,cli_tel,cli_ddd2,cli_tel2,cli_email,cli_rua,cli_numero,cli_bairro,cli_cidade,cli_cep,cli_uf,cli_data_cad)" +
				" values (@nome, @cnpj, @cpf,  @ddd,@tel,@ddd2, @tel2, @email, @rua, @numero, @bairro, @cidade,@cep, @uf, @datacad);";
			cmd.Parameters.AddWithValue("nome", modelo.nomecli);
			cmd.Parameters.AddWithValue("cnpj", modelo.cnpjcli);
			cmd.Parameters.AddWithValue("cpf", modelo.cpfcli);
			cmd.Parameters.AddWithValue("ddd", modelo.dddcli);
			cmd.Parameters.AddWithValue("tel", modelo.telcli);
			cmd.Parameters.AddWithValue("ddd2", modelo.dddcli2);
			cmd.Parameters.AddWithValue("tel2", modelo.telcli2);
			cmd.Parameters.AddWithValue("email", modelo.emailcli);
			cmd.Parameters.AddWithValue("rua", modelo.ruacli);
			cmd.Parameters.AddWithValue("numero", modelo.numerocli);
			cmd.Parameters.AddWithValue("bairro", modelo.bairrocli);
			cmd.Parameters.AddWithValue("cidade", modelo.cidadecli);
			cmd.Parameters.AddWithValue("uf", modelo.ufcli);
			cmd.Parameters.AddWithValue("cep", modelo.cepcli);
			cmd.Parameters.AddWithValue("datacad", modelo.datacadcli);
			
			
			//conecta ao banco
			conexao.Conectar();
			// executa os comandos
			cmd.ExecuteNonQuery();
			// fecha a conexao
			conexao.Desconectar();
		}
		public void Alterar(ModeloCliente modelo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = "update cliente set cli_nome = @nome, cli_cnpj =  @cnpj,cli_cpf = @cpf,cli_tel_ddd = @ddd,cli_tel = @tel,cli_ddd2 = @ddd2,cli_tel2 = @tel2, cli_email = @email,cli_rua = @rua,cli_numero =  @numero,cli_bairro =  @bairro,cli_cidade = @cidade, cli_cep = @cep,cli_uf = @uf, cli_data_cad = @datacad where id_cliente = @codigo;";
			cmd.Parameters.AddWithValue("codigo", modelo.idcli);
			cmd.Parameters.AddWithValue("nome", modelo.nomecli);
			cmd.Parameters.AddWithValue("cnpj", modelo.cnpjcli);
			cmd.Parameters.AddWithValue("cpf", modelo.cpfcli);			
			cmd.Parameters.AddWithValue("ddd", modelo.dddcli);
			cmd.Parameters.AddWithValue("tel", modelo.telcli);
			cmd.Parameters.AddWithValue("ddd2", modelo.dddcli2);
			cmd.Parameters.AddWithValue("tel2", modelo.telcli2);
			cmd.Parameters.AddWithValue("email", modelo.emailcli);
			cmd.Parameters.AddWithValue("rua", modelo.ruacli);
			cmd.Parameters.AddWithValue("numero", modelo.numerocli);
			cmd.Parameters.AddWithValue("bairro", modelo.bairrocli);
			cmd.Parameters.AddWithValue("cidade", modelo.cidadecli);
			cmd.Parameters.AddWithValue("cep", modelo.cepcli);
			cmd.Parameters.AddWithValue("uf", modelo.ufcli);
			cmd.Parameters.AddWithValue("datacad", modelo.datacadcli);
			
			
			
			conexao.Conectar();
			cmd.ExecuteNonQuery();
			conexao.Desconectar();
		}
		public void Excluir (int codigo)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = " delete from cliente where id_cliente = @codigo;";
			cmd.Parameters.AddWithValue("@codigo", codigo);
			conexao.Conectar();
			cmd.ExecuteNonQuery();
			conexao.Desconectar();

		}
		public DataTable Localizar (String valor)
		{
			DataTable tabela = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter("Select * from cliente where cli_nome like '%" + valor + "%'", conexao.StringConexao);
			da.Fill(tabela);
			return tabela;
		}
		public ModeloCliente CarregaModeloCliente ( int codigo)
		{
			ModeloCliente modelo = new ModeloCliente();
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conexao.ObjetoConexao;
			cmd.CommandText = " Select * from cliente where id_cliente = @codigo;";
			cmd.Parameters.AddWithValue("@codigo", codigo);
			conexao.Conectar();
			MySqlDataReader registro = cmd.ExecuteReader();

			if (registro.HasRows)
			{
				registro.Read();
				modelo.idcli = Convert.ToInt32(registro["id_cliente"]);
				modelo.nomecli = Convert.ToString(registro["cli_nome"]);
				modelo.cnpjcli = Convert.ToString(registro["cli_cnpj"]);
				modelo.cpfcli = Convert.ToString(registro["cli_cpf"]);
				modelo.telcli = Convert.ToString(registro["cli_tel"]);
				modelo.dddcli = Convert.ToString(registro["cli_tel_ddd"]);
				modelo.emailcli = Convert.ToString(registro["cli_email"]);
				modelo.ruacli = Convert.ToString(registro["cli_rua"]);
				modelo.numerocli = Convert.ToString(registro["cli_numero"]);
				modelo.bairrocli = Convert.ToString(registro["cli_bairro"]);
				modelo.cidadecli = Convert.ToString(registro["cli_cidade"]);
				modelo.ufcli = Convert.ToString(registro["cli_uf"]);
				modelo.datacadcli = Convert.ToDateTime(registro["cli_data_cad"]);

			}
			conexao.Desconectar();
			return modelo;
		}
	}
}
