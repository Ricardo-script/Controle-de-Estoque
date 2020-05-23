/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 23/07/2019
 * Time: 15:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite; // inserir
using System.Data; // inserir
using Excel = Microsoft.Office.Interop.Excel;

namespace Controle
{
	/// <summary>
	/// Description of Controle.
	/// </summary>
	public partial class Controle_Stq : Form
	{
		Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
		private const String connectionString = @"Data Source=.\Banco\Estoque.db";
   
         	
		public Controle_Stq()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	
        // Código criado_________________________________ :
        String insSQL = "select * from Dados";	// from selecionar o nome da tabela para gerar no datagridview
         	
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
         //	__________________________________________
		
		void GerarClick(object sender, EventArgs e)
		{
			  {
				DataTable dt = new DataTable();
				
				string dti = Convert.ToDateTime(this.inicio.Text).ToString("yyyy-MM-dd");
				string dtf = Convert.ToDateTime(this.fim.Text).ToString("yyyy-MM-dd");
				             
				
				Tela.DataSource = null;	//  tela é o nome do DataGridView
					insSQL = "" +
						"SELECT " +
						"   * " +
						"FROM " +
						"   Dados " +
						"WHERE " +
						"      Cod_de_Barras LIKE '" + this.textBox1.Text + "%' " +
						"   AND Número_de_NF LIKE '" + this.Psq_NF.Text + "%' " +
						"   AND Produto LIKE '" + this.Pesq_Produto.Text +"%' " +
						"   AND date(Data) BETWEEN '" + dti +  "' AND '" + dtf + "'";
					
					Tela.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>(insSQL);
					
				foreach(DataGridViewColumn column in Tela.Columns){
				    if (column.DataPropertyName == "Cod_de_Barras")
				        column.Width = 165; //tamanho fixo da primeira coluna
				    if (column.DataPropertyName == "Produto")
				        column.Width = 160; 
				    if (column.DataPropertyName == "Fornecedor")
				        column.Width = 100; 
				    if (column.DataPropertyName == "Recebedor/Razão Social")
			        column.Width = 170; 
				   if (column.DataPropertyName == "Observações")
			        column.Width = 400;
				Total.Visible = true;
				label1.Visible = true;
				label3.Visible = true;
				   
			}
		}
	
			
					decimal valorTotal = 0;
					foreach (DataGridViewRow col in Tela.Rows){
					valorTotal = valorTotal + Convert.ToDecimal(col.Cells[9].Value);
					  }
					 Total.Text = Convert.ToString(valorTotal);
		}
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13){
				{
		         DataTable dt = new DataTable();
				Tela.DataSource = null;	//  tela é o nome do DataGridView
					insSQL = "SELECT * FROM Dados WHERE Cod_de_Barras LIKE '" + this.textBox1.Text + "%' AND Número_de_NF LIKE '" + this.Psq_NF.Text + "%' AND Produto LIKE '" + this.Pesq_Produto.Text +"%'";
					Tela.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>(insSQL);
				foreach(DataGridViewColumn column in Tela.Columns)
				{
			    if (column.DataPropertyName == "Cod_de_Barras")
			        column.Width = 165; 
			    if (column.DataPropertyName == "Produto")
			        column.Width = 160; 
			    if (column.DataPropertyName == "Fornecedor")
			        column.Width = 100; 
			     if (column.DataPropertyName == "Recebedor/Razão Social")
			        column.Width = 170; 
			      if (column.DataPropertyName == "Observações")
			        column.Width = 400;
			      Total.Visible = true;
			      label1.Visible = true;
				  label3.Visible = true;

				}
		     }	
          }
					decimal valorTotal = 0;
					foreach (DataGridViewRow col in Tela.Rows){
						valorTotal = valorTotal + Convert.ToDecimal(col.Cells[9].Value);
					}
					Total.Text = Convert.ToString(valorTotal);
		 }
		
		void ExportarClick(object sender, EventArgs e){
			
			try{
				SaveFileDialog salvar = new SaveFileDialog();
	            Excel.Application App; // Aplicação Excel 
	            Excel.Workbook WorkBook; // Pasta 
	            Excel.Worksheet WorkSheet; // Planilha 
	            object misValue = System.Reflection.Missing.Value;
	
	            App = new Excel.Application();
	            WorkBook = App.Workbooks.Add(misValue);
	            WorkSheet = (Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
	            int i = 0;
	            int j = 0;
	            
	            for (int c = 1; c < Tela.Columns.Count + 1; c++){
	                WorkSheet.Cells[1, c] = Tela.Columns[c - 1].HeaderText;
	            } 
	
	            // passa as celulas do DataGridView para a Pasta do Excel 
	            for (i = 0; i <= Tela.RowCount - 1; i++)
	            {
	                for (j = 0; j <= Tela.ColumnCount - 1; j++)
	                {
	                    DataGridViewCell cell = Tela[j, i];
	                    WorkSheet.Cells[i + 2, j + 1] = cell.Value;
	                }
	            }
	            // define algumas propriedades da caixa salvar 
	            salvar.Title = "Meu Titulo";
	            salvar.Filter = "Arquivo do Excel *.xls | *.xls";
	            salvar.ShowDialog(); // mostra 
	
	            // salva o arquivo 
	            WorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
	            
	            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
	        
	            WorkBook.Close(true, misValue, misValue);
	            App.Quit(); // encerra o excel 
	
	            MessageBox.Show("Exportado com sucesso!");
			}
			catch{
			MessageBox.Show("Cancelado!","Arquivo não exportado");	
			}
		}
		
		void SairClick(object sender, EventArgs e)
		{
			this.Hide();
		}
		void Button2Click(object sender, EventArgs e)
		{
			Dados novaform = new Dados();
            novaform.Show();
		}
		void Button1Click(object sender, System.EventArgs e)
		{
			Produto novaform = new Produto();
            novaform.Show();
		}
		void Button3Click(object sender, EventArgs e)
		{
			Saida novaform = new Saida();
            novaform.Show();
		}	
		
		
		void Button4Click(object sender, EventArgs e)
		{
			Exc_Tsç novaform = new Exc_Tsç();
      	 	novaform.Show();
		}
		void ControleLoad(object sender, EventArgs e)
		{
			Total.Visible = false;
			label1.Visible = false;
			label3.Visible = false;
		}
		void Pesq_ProdutoKeyPress(object sender, KeyPressEventArgs e)
		{
						if (e.KeyChar == 13)
		 {
			{
		         DataTable dt = new DataTable();
				Tela.DataSource = null;	//  tela é o nome do DataGridView
					insSQL = "SELECT * FROM Dados WHERE Cod_de_Barras LIKE '" + this.textBox1.Text + "%' AND Número_de_NF LIKE '" + this.Psq_NF.Text + "%' AND Produto LIKE '" + this.Pesq_Produto.Text +"%'";
					Tela.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>(insSQL);
				foreach(DataGridViewColumn column in Tela.Columns)
				{
			    if (column.DataPropertyName == "Cod_de_Barras")
			        column.Width = 165; 
			    if (column.DataPropertyName == "Produto")
			        column.Width = 160; 
			    if (column.DataPropertyName == "Fornecedor")
			        column.Width = 100; 
			     if (column.DataPropertyName == "Recebedor/Razão Social")
			        column.Width = 170; 
			      if (column.DataPropertyName == "Observações")
			        column.Width = 400;
			      Total.Visible = true;
			      label1.Visible = true;
				  label3.Visible = true;

				}
		    }	
          }
					decimal valorTotal = 0;
					foreach (DataGridViewRow col in Tela.Rows)
					{
						valorTotal = valorTotal + Convert.ToDecimal(col.Cells[9].Value);
					}
					 Total.Text = Convert.ToString(valorTotal);
		}
		
		
}
}
		