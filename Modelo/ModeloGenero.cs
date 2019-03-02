using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public class ModeloGenero
	{
		private int id_genero;
		public int idgenero
		{
			get { return this.id_genero; }
			set { this.id_genero = value; }
		}


		private String gen_nome;
		public String nomegenero
		{
			get { return this.gen_nome; }
			set { this.gen_nome = value; }
		}
	}
}
