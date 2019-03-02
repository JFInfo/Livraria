using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public class ModeloItemConsig
	{
						
		private int item_con_qnt;
		public int itemconqnt
		{
			get { return this.item_con_qnt; }
			set { this.item_con_qnt = value; }
		}

		private int id_item_lv;
		public int iditemlv
		{
			get { return this.id_item_lv; }
			set { this.id_item_lv = value; }
		}

		private int id_itemc_con;
		public int iditemccon
		{
			get { return this.id_itemc_con; }
			set { this.id_itemc_con = value; }
		}

		public int id_item_con;
		public int iditemcon
		{
			get { return this.id_item_con; }
			set { this.id_item_con = value; }
		}
	}
}
