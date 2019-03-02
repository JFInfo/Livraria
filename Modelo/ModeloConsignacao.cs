using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public class ModeloConsignacao
	{
		private int id_consig;
		public int idconsig
		{
			get { return this.id_consig; }
			set { this.id_consig = value; }
		}
		private DateTime con_data;
		public DateTime condata
		{
			get { return this.con_data; }
			set { this.con_data = value; }
		}
		private int con_qnt;
		public int conqnt
		{
			get { return this.con_qnt; }
			set { this.con_qnt = value; }
		}

		private int con_nf;
		public int connf
		{
			get { return this.con_nf; }
			set { this.con_nf = value; }
		}

		private int id_con_lv;
		public int idconlv
		{
			get { return this.id_con_lv; }
			set { this.id_con_lv = value; }
		}

		private int id_con_cli;
		public int idconcli
		{
			get { return this.id_con_cli; }
			set { this.id_con_cli = value; }
		}


	}
}
