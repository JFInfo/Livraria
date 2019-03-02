using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public class ModeloLivro
	{
		public ModeloLivro()
		{
			this.idlivro = 0;
			this.lvisbn = "";
			this.lvvalorpg = 0;
			this.lvtitulo = "";
			this.lvvolume = "";
			this.lvvalorvd = 0;
			this.lvmesanoadi = "";
			this.lvdescricao = "";
			this.lvqnt = 0;
			//this.lvdatacad
			this.lvcapa = lv_capa;
			this.lvpeso = lv_peso;
			this.fkidautor = id_autor;
			this.fkidgenero = id_genero;
			this.fkideditora = id_editora;

		}

		public ModeloLivro(int id_livro, String lv_isbn, Double lv_valor_pg, String lv_titulo, String lv_volume, Double lv_valor_vd, String lv_mesano_edi, String lv_descricao, int lv_qnt, DateTime lv_data_cad, String lv_capa, Double lv_peso)

		{
			this.idlivro = id_livro;
			this.lvisbn = lv_isbn;
			this.lvvalorpg = lv_valor_pg;
			this.lvtitulo = lv_titulo;
			this.lvvolume = lv_volume;
			this.lvvalorvd = lv_valor_vd;
			this.lvmesanoadi = lv_mesano_edi;
			this.lvdescricao = lv_descricao;
			this.lvqnt = lv_qnt;
			this.lvdatacad = lv_data_cad;
			//this.CarregaImagem(lv_capa);
			this.lvcapa=lv_capa;
			this.lvpeso = lv_peso;
			this.fkidautor = id_autor;
			this.fkidgenero = id_genero;
			this.fkideditora = id_editora;
		}
		/*public ModeloLivro(int id_livro, String lv_isbn, Double lv_valor_pg, String lv_titulo, String lv_volume, Double lv_valor_vd, String lv_mesano_edi, String lv_descricao, int lv_qnt, DateTime lv_data_cad, String lv_capa, Double lv_peso)

		{
			this.idlivro = id_livro;
			this.lvisbn = lv_isbn;
			this.lvvalorpg = lv_valor_pg;
			this.lvtitulo = lv_titulo;
			this.lvvolume = lv_volume;
			this.lvvalorvd = lv_valor_vd;
			this.lvmesanoadi = lv_mesano_edi;
			this.lvdescricao = lv_descricao;
			this.lvqnt = lv_qnt;
			this.lvdatacad = lv_data_cad;
			this.lvcapa = lv_capa;
			this.lvpeso = lv_peso;
			this.fkidautor = id_autor;
			this.fkidgenero = id_genero;
			this.fkideditora = id_editora;

		}*/


		private int id_livro;
		public int idlivro
		{
			get { return this.id_livro; }
			set { this.id_livro = value; }
		}

		private String lv_isbn;
		public String lvisbn
		{
			get { return this.lv_isbn; }
			set { this.lv_isbn = value; }
		}

		private Double lv_valor_pg;
		public Double lvvalorpg
		{
			get { return this.lv_valor_pg; }
			set { this.lv_valor_pg = value; }
		}

		private String lv_titulo;
		public String lvtitulo
		{
			get { return this.lv_titulo; }
			set { this.lv_titulo = value; }
		}



		private String lv_volume;
		public String lvvolume
		{
			get { return this.lv_volume; }
			set { this.lv_volume = value; }
		}


		private Double lv_valor_vd;
		public Double lvvalorvd
		{
			get { return this.lv_valor_vd; }
			set { this.lv_valor_vd = value; }
		}

		private String lv_mesano_edi;
		public String lvmesanoadi
		{
			get { return this.lv_mesano_edi; }
			set { this.lv_mesano_edi = value; }
		}


		private String lv_descricao;
		public String lvdescricao
		{
			get { return this.lv_descricao; }
			set { this.lv_descricao = value; }
		}

		private int lv_qnt;
		public int lvqnt
		{
			get { return this.lv_qnt; }
			set { this.lv_qnt = value; }
		}
		private DateTime lv_data_cad;
		public DateTime lvdatacad
		{
			get { return this.lv_data_cad; }
			set { this.lv_data_cad = value; }
		}
		private String lv_capa;
		public String lvcapa
		{
			get { return this.lv_capa; }
			set { this.lv_capa = value; }
		}
		/*public void CarregaImagem( String imgCaminho)
		{
			try
			{
				if (string.IsNullOrEmpty(imgCaminho))
					return;

				FileInfo arqImagem = new FileInfo(imgCaminho);
				FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
				this.lvcapa = new byte[Convert.ToInt32(arqImagem.Length)];
				int iBytesRead = fs.Read(this.lvcapa, 0, Convert.ToInt32(arqImagem.Length));
				fs.Close();
			}

			catch (Exception ex)
			{
				throw new Exception(ex.Message.ToString());
			}
		
		}*/

		private Double lv_peso;
		public Double lvpeso
		{
			get { return this.lv_peso; }
			set { this.lv_peso = value; }
		}

		private int id_autor;
		public int fkidautor
		{
			get { return this.id_autor; }
			set { this.id_autor = value; }
		}
		private int id_genero;
		public int fkidgenero
		{
			get { return this.id_genero; }
			set { this.id_genero = value; }

		}
		private int id_editora;
		public int fkideditora
		{
			get { return this.id_editora; }
			set { this.id_editora = value; }
		}
	}
}
