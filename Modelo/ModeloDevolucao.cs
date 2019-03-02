using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public class ModeloDevolucao
	{
		private int id_devolucao;
		public int iddevolucao
		{
			get { return this.id_devolucao; }
			set { this.id_devolucao = value; }
		}
		private DateTime dev_data;
		public DateTime devdata
		{
			get { return this.dev_data; }
			set { this.dev_data = value; }
		}

		private int dev_qnt;
		public int devqnt
		{
			get { return this.dev_qnt; }
			set { this.dev_qnt = value; }
		}

		private int dev_nf;
		public int devnf
		{
			get { return this.dev_nf; }
			set { this.dev_nf = value; }
		}

		private int id_dev_lv;
		public int iddevlv
		{
			get { return this.id_dev_lv; }
			set { this.id_dev_lv = value; }
		}

		private int id_dev_cli;
		public int iddevcli
		{
			get { return this.id_dev_cli; }
			set { this.id_dev_cli = value; }
		}
	}
}
