
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public class ModeloEditora
	{
		private int id_editora;
		public int ideditora
		{
			get { return this.id_editora; }
			set { this.id_editora = value; }
		}


		private String edi_nome;
		public String nomeeditora
		{
			get { return this.edi_nome; }
			set { this.edi_nome = value; }
		}
	}
}
