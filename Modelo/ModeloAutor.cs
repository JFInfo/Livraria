using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public class ModeloAutor
	{
		private int id_autor;
		public int idautor
		{
			get { return this.id_autor; }
			set { this.id_autor = value; }
		}


		private String at_nome;
		public String nomeautor
		{
			get { return this.at_nome; }
			set { this.at_nome = value; }
		}
	}
}
