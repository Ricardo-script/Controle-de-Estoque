/*
 * Criado por SharpDevelop.
 * Usuário: ricardo.silva
 * Data: 20/08/2019
 * Hora: 09:11
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace Controle
{
	/// <summary>
	/// Description of Status.
	/// </summary>
	public partial class Status : Form
	{
		
		private const String connectionString = @"Data Source=.\Banco\Estoque.db"; // Local do Banco de dados criado
		
		public Status()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
//		String insSQL = "SELECT"+
//			" p.barras," +
//			" Descrição," +
//			" SUM(d.qtd_de_entrada) as [Total Estoque]," +
//			" CASE WHEN"+
//			" SUM(d.qtd_de_entrada)< p.Minimo THEN 'Repor Estoque'" +
//			" WHEN SUM(d.qtd_de_entrada)> p.Maximo THEN 'Estoque Excedido'" + 
//			" ELSE 'Estoque Ok'" +
//			" END AS Status," +
//			" Minimo," +
//			" Maximo" +
//			" FROM produto p" +
//			" JOIN dados d ON p.barras = d.cod_de_barras" +
//			" GROUP by p.barras" +"";
		String insSQL = "select * from Produto";
		private DataTable LeDados<S, T>(string query) where S : IDbConnection, new() where T : IDbDataAdapter, IDisposable, new()
        {
            using (var conn = new S())
            {
                using (var da = new T())
                {
                    using (da.SelectCommand = conn.CreateCommand())
                    {
                        da.SelectCommand.CommandText = query;
                        da.SelectCommand.Connection.ConnectionString = connectionString;
                        DataSet ds = new DataSet(); //conn é aberto pelo dataadapter
                        da.Fill(ds);
                        conn.Close();
                        return ds.Tables[0];
                    }
                }
            }
        }
		
		void Button1Click(object sender, EventArgs e){
         	DataTable dt = new DataTable();
         	Tela.DataSource = null;
         	
         	insSQL = "SELECT "+
					"Descrição, "+
					"p.barras, "+
					"SUM(d.qtd_de_entrada) as [Total Estoque], "+
					"CASE WHEN "+
					"SUM(d.qtd_de_entrada)>= p.Minimo AND "+
					"SUM(d.qtd_de_entrada)<= p.Maximo THEN 'Estoque Ok' "+
					"ELSE 'Repor Estoque' "+
					"END as Status, "+
					"Minimo, "+
					"Maximo "+
					"FROM produto p "+
         			"JOIN dados d ON p.barras = d.cod_de_barras "+
         		    "WHERE " + 
					 "   Descrição LIKE '" + this.produto.Text + "%' " +
					 "   AND Barras LIKE '" + this.barras.Text + "%' " +
         			 "   AND Barras LIKE '" + this.barras.Text + "%'" + 

					"GROUP by p.barras "+ ""; 
         	
         	Tela.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>(insSQL);
         	foreach(DataGridViewColumn column in Tela.Columns){
             	if (column.DataPropertyName == "Barras")
         	column.Width = 225;
             	if (column.DataPropertyName == "Descrição")
         	column.Width = 230;
         		if (column.DataPropertyName == "Minimo")
         	column.Width = 50;
         		if (column.DataPropertyName == "Maximo")
         	column.Width = 50;
         	
         	// Centralizar corpo de texto do Datagridview
         	Tela.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    		Tela.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
    		Tela.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    		
    		// Coluna em negrito
    		Tela.Columns[2].DefaultCellStyle.Font = new Font(Tela.DefaultCellStyle.Font.FontFamily,9,FontStyle.Bold);
    		
    		foreach (DataGridViewRow rws in this.Tela.Rows) {
    			if ((rws.Cells[3].Value as string).ToLowerInvariant().Contains("repor estoque")){
				     rws.DefaultCellStyle.ForeColor = Color.Red;
    			}
    			if ((rws.Cells[3].Value as string).ToLowerInvariant().Contains("estoque excedido")){
				     rws.DefaultCellStyle.ForeColor = Color.Green;
    			}
    		}
			}
		}
		
		void Button2Click(object sender, EventArgs e){
			this.Hide();
		}
		
		void SairClick(object sender, EventArgs e){
			this.Hide();
		}
		
		void ProdutoKeyPress(object sender, KeyPressEventArgs e){
			if (e.KeyChar == 13)
				Gerar.PerformClick();		
		}
		
		void BarrasKeyPress(object sender, KeyPressEventArgs e){
			if (e.KeyChar == 13)
				Gerar.PerformClick();
		}
	}
}