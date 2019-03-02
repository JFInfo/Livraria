using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public class ModeloEstoque
	{
		private int id_est;
		public int idest
		{
			get { return this.id_est; }
			set { this.id_est = value; }
		}

		private int est_qnt_ini;
		public int estqntini
		{
			get { return this.est_qnt_ini; }
			set { this.est_qnt_ini = value; }
		}

		private int est_qnt_entrada;
		public int estqntentrada
		{
			get { return this.est_qnt_entrada; }
			set { this.est_qnt_entrada = value; }
		}

		private int est_qnt_saida;
		public int estqntsaida
		{
			get { return this.est_qnt_saida; }
			set { this.est_qnt_saida = value; }
		}

		private String est_tipo_op; // (D = Devolucao, V = Venda, C = Consignado, E = Entrada)
		public String esttipoop
		{
			get { return this.est_tipo_op; }
			set { this.est_tipo_op = value; }
		}

		private DateTime est_data_entrada;
		public DateTime estdataentrada
		{
			get { return this.est_data_entrada; }
			set { this.est_data_entrada = value; }
		}

		private DateTime est_data_saida;
		public DateTime estdatasaida
		{
			get { return this.est_data_saida; }
			set { this.est_data_saida = value; }
		}

		private int id_est_dev;
		public int idestdev
		{
			get { return this.id_est_dev; }
			set { this.id_est_dev = value; }
		}

		private int id_est_con;
		public int idestcon
		{
			get { return this.id_est_con; }
			set { this.id_est_con = value; }
		}

		private int id_est_ven;
		public int idestven
		{
			get { return this.id_est_ven; }
			set { this.id_est_ven = value; }
		}

		private int id_est_lv;
		public int idestlv
		{
			get { return this.id_est_lv; }
			set { this.id_est_lv = value; }
		}
	}
}
