using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public class ModeloVenda
	{
		private int id_venda;
		public int idvenda
		{
			get { return this.id_venda; }
			set { this.id_venda = value; }
		}

		private DateTime ven_data;
		public DateTime vendata
		{
			get { return this.ven_data; }
			set { this.ven_data = value; }
		}

		private int ven_qnt;
		public int venqnt
		{
			get { return this.ven_qnt; }
			set { this.ven_qnt = value; }
		}

		private int ven_nf;
		public int vennf
		{
			get { return this.ven_nf; }
			set { this.ven_nf = value; }
		}

		private float ven_desconto;
		public float vendesconto
		{
			get { return this.ven_desconto; }
			set { this.ven_desconto = value; }
		}

		private float ven_valor;
		public float venvalor
		{
			get { return this.ven_valor; }
			set { this.ven_valor = value; }
		}
		private int id_ven_lv;
		public int idvevlv
		{
			get { return this.id_ven_lv; }
			set { this.id_ven_lv = value; }
		}

		private int id_ven_cli;
		public int idvencli
		{
			get { return this.id_ven_cli; }
			set { this.id_ven_cli = value; }
		}


	}
}
