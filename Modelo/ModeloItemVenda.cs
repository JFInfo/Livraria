using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public class ModeloItemVenda
	{
		private int id_item_ven;
		public int iditemven
		{
			get { return this.id_item_ven; }
			set { this.id_item_ven = value; }
		}
		private int item_ven_qnt;
		public int itemvenqnt
		{
			get { return this.item_ven_qnt; }
			set { this.item_ven_qnt = value; }
		}
		private int id_item_lv;
		public int iditemlv
		{
			get { return this.id_item_lv; }
			set { this.id_item_lv = value; }
		}
		private int id_itemv_ven;
		public int iditemvven
		{
			get { return this.id_itemv_ven; }
			set { this.id_itemv_ven = value; }
		}
	}
}
