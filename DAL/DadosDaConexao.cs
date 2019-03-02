using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
	public class DadosDaConexao
	{
		public static String StringdeConexao
		{
			get { return "server=localhost; port = 3307; User Id = root; database = nandyala; password = usbw";}
		}
	}
}
