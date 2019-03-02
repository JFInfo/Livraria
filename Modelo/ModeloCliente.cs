using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public class ModeloCliente
	{
		private int id_cliente;
		public int idcli
		{
			get { return this.id_cliente; }
			set { this.id_cliente = value; }
		}


		private String cli_nome;
		public String nomecli
		{
			get { return this.cli_nome; }
			set { this.cli_nome = value; }
		}


		private String cli_cnpj;
		public String cnpjcli
		{
			get { return this.cli_cnpj; }
			set { this.cli_cnpj = value; }
		}

		private String cli_cpf;
		public String cpfcli
		{
			get { return this.cli_cpf; }
			set { this.cli_cpf = value; }
		}

		
		private String cli_tel_ddd;
		public String dddcli
		{
			get { return this.cli_tel_ddd; }
			set { this.cli_tel_ddd = value; }
		}
		private String cli_tel;
		public String telcli
		{
			get { return this.cli_tel; }
			set { this.cli_tel = value; }
		}

		

		private String cli_tel_ddd2;
		public String dddcli2
		{
			get { return this.cli_tel_ddd2; }
			set { this.cli_tel_ddd2 = value; }
		}

		private String cli_tel2;
		public String telcli2
		{
			get { return this.cli_tel2; }
			set { this.cli_tel2 = value; }
		}
		private String cli_email;
		public String emailcli
		{
			get { return this.cli_email; }
			set { this.cli_email = value; }
		}

		private String cli_rua;
		public String ruacli
		{
			get { return this.cli_rua; }
			set { this.cli_rua = value; }
		}

		private String cli_numero;
		public String numerocli
		{
			get { return this.cli_numero; }
			set { this.cli_numero = value; }
		}

		private String cli_bairro;

		public String bairrocli
		{
			get { return this.cli_bairro; }
			set { this.cli_bairro = value; }
		}

		private String cli_cidade;
		public String cidadecli
		{
			get { return this.cli_cidade; }
			set { this.cli_cidade = value; }
		}
		private String cli_cep;
		public String cepcli
		{
			get { return this.cli_cep; }
			set { this.cli_cep = value; }
		}

		private String cli_uf;
		public String ufcli
		{
			get { return this.cli_uf; }
			set { this.cli_uf = value; }
		}
	
		private DateTime cli_data_cad;
		public DateTime datacadcli
		{
			get { return this.cli_data_cad; }
			set { this.cli_data_cad = value; }
		}
		
	}
}
