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
		public Controle_Stq(string texto){
			InitializeComponent();
			user_login.Text = texto;
			 	
		}
		String insSQL = "select * from Dados";
		
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
		
		void GerarClick(object sender, EventArgs e){
         	
         	try{
         		
         		if(inicio.Text == ""){
			  	inicio.Text = "01/01/1990";
			 	 inicio.ForeColor = Color.White;
         		}
         		
         		if(fim.Text == ""){
				fim.Text = "31/12/2999";
				fim.ForeColor = Color.White;
         		}
         		
         		DataTable dt = new DataTable();
         		
         		string dti = Convert.ToDateTime(this.inicio.Text).ToString("yyyy-MM-dd");
				string dtf = Convert.ToDateTime(this.fim.Text).ToString("yyyy-MM-dd");
				
				Tela.DataSource = null;
				insSQL = "SELECT " +
					"Transação, "+
				    "[Tipo de Fluxo], "+
				    "Cod_de_Barras, "+
				    "Produto, "+
				    "[Fornecedor/Cliente], "+
				    "Unidade_de_Medida, "+
				    "Grupo, "+
				    "Custo, "+
				    "Venda, "+
				    "Qtd_de_Entrada as [Qtd Mov.], "+
				    "((Case "+
				    "When Qtd_de_Entrada < 0 Then 0 "+
				    "Else Qtd_de_Entrada END)* Custo) as [Total de Entrada], "+
				    "((Case "+
				    "When Qtd_de_Entrada > 0 Then 0 "+
				    "Else Qtd_de_Entrada END)* -1 * Venda) as [Total de Saída], "+      
				     "Número_de_NF, "+
				     "strftime('%d/%m/%Y', Data) Data, "+
					 "Usuario, "+
				     "Observações "+						
					 "FROM " +
					 "   Dados " +
					 "WHERE " +
					 "   Cod_de_Barras LIKE '" + this.textBox1.Text + "%' " +
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
				    if (column.DataPropertyName == "Unidade_de_Medida")
		        	column.Width = 140; 
				   	if (column.DataPropertyName == "Observações")
			        column.Width = 400;
				    if (column.DataPropertyName == "Total de Entrada")
			        column.Width = 140;
			     	if (column.DataPropertyName == "Total de Saída")
			        column.Width = 140;
			     	
			     	// Centralizar corpo de texto do Datagridview
			     	Tela.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					Tela.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    
    				// Centralizar Cabeçalho
				    Tela.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				    Tela.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				    Tela.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				    Tela.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				    Tela.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				    Tela.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				    Tela.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				    Tela.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				    Tela.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				    Tela.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				    Tela.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				    Tela.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				     
				     // Formatação de valores R$
				    Tela.Columns[7].DefaultCellStyle.Format = "C2";
				    Tela.Columns[8].DefaultCellStyle.Format = "C2";
					Tela.Columns[10].DefaultCellStyle.Format = "C2";
					Tela.Columns[11].DefaultCellStyle.Format = "C2";
				}
				
				decimal valorTotal = 0;
				foreach (DataGridViewRow col in Tela.Rows){
					valorTotal = valorTotal + Convert.ToDecimal(col.Cells[9].Value);
				}
				Total.Text = Convert.ToString(valorTotal);
				
				decimal valorcusto = 0;
				foreach (DataGridViewRow col in Tela.Rows){
					valorcusto = valorcusto + Convert.ToDecimal(col.Cells[10].Value);
				}
				t_custo.Text = Convert.ToString(valorcusto);
				
				// devolução
				decimal somar = 0;
			    foreach (DataGridViewRow row in Tela.Rows){
					{
						string verify = Convert.ToString(row.Cells[1].Value);
						if(verify.Equals("Devolução")){
							somar += Convert.ToDecimal(row.Cells[11].Value);
						}
					}
					devolucao.Text=(somar.ToString());
				}
				
				//Venda
				decimal somar1 = 0;
			    foreach (DataGridViewRow row in Tela.Rows){
					{
						string verify = Convert.ToString(row.Cells[1].Value);
			    		if(verify.Equals("Venda")){
			    			somar1 += Convert.ToDecimal(row.Cells[11].Value);
			    		}
			    	}
			    	saida.Text=(somar1.ToString());
			    }
				
			    // Perda
			    decimal somar2 = 0;
			    foreach (DataGridViewRow row in Tela.Rows){
			    	{
			    		string verify = Convert.ToString(row.Cells[1].Value);
			    		if(verify.Equals("Perda")){
			    			somar2 += Convert.ToDecimal(row.Cells[11].Value);
			    		}
			    	}
			    	perda.Text=(somar2.ToString());
			    }
			    
			   //Avarias
				decimal somar3 = 0;
				foreach (DataGridViewRow row in Tela.Rows){
					{
						string verify = Convert.ToString(row.Cells[1].Value);
						if(verify.Equals("Avaria")){
							somar3 += Convert.ToDecimal(row.Cells[11].Value);
						}
					}
					avaria.Text=(somar3.ToString());
				}
				
				// contar avarias
				decimal somar4 = 0;
			    foreach (DataGridViewRow row in Tela.Rows){
			    	{
			    		string verify = Convert.ToString(row.Cells[1].Value);
			    		if(verify.Equals("Avaria")){
			    			somar4 += Convert.ToDecimal(row.Cells[9].Value)*-1;
			    		}
			    	}
			    	t_ava.Text=(somar4.ToString());
			    }
			    
			    // somar saídas
			    decimal somar5 = 0;
			    foreach (DataGridViewRow row in Tela.Rows){
			    	{
			    		string verify = Convert.ToString(row.Cells[1].Value);
			    		if(verify.Equals("Venda")){
			    			somar5 += Convert.ToDecimal(row.Cells[9].Value)*-1;
			    		}
			    	}
			    	t_saidas.Text=(somar5.ToString());
			    }
			    
			    // somar perdas
			    decimal somar6 = 0;
			    foreach (DataGridViewRow row in Tela.Rows){
			    	{
			    		string verify = Convert.ToString(row.Cells[1].Value);
			    		if(verify.Equals("Perda")){
			    			somar6 += Convert.ToDecimal(row.Cells[9].Value)*-1;
			    		}
			    	}
			    	t_perdas.Text=(somar6.ToString());
			    }
			    
			    // somar devoluções
			    decimal somar7 = 0;
			    foreach (DataGridViewRow row in Tela.Rows){
			    	{
			    		string verify = Convert.ToString(row.Cells[1].Value);
			    		if(verify.Equals("Devolução")){
			    			somar7 += Convert.ToDecimal(row.Cells[9].Value)*-1;
			    		}
			    	}
			    	t_dev.Text=(somar7.ToString());
			    }
			    
			    // somar entradas
			    decimal somar8 = 0;
			    foreach (DataGridViewRow row in Tela.Rows){
			    	{
			    		string verify = Convert.ToString(row.Cells[1].Value);
			    		if(verify.Equals("Entrada")){
			    			somar8 += Convert.ToDecimal(row.Cells[9].Value);
			    		}
			    	}
			    	t_entradas.Text=(somar8.ToString());
			    }
				
				
				// Formatar texbox como valor monetário
				t_custo.Text = Convert.ToDouble(t_custo.Text).ToString("C");
				devolucao.Text = Convert.ToDouble(devolucao.Text).ToString("C");
				saida.Text = Convert.ToDouble(saida.Text).ToString("C");
				perda.Text = Convert.ToDouble(perda.Text).ToString("C");
				avaria.Text = Convert.ToDouble(avaria.Text).ToString("C");
         	}
         	
         	catch{
         		MessageBox.Show("Algum dado foi inserido erroneamente, por favor verificar!","Corrigir Informações");
         	}
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
		
		void SairClick(object sender, EventArgs e){
			this.Hide();
		}
		
		void Button2Click(object sender, EventArgs e){
			Dados novaform = new Dados(user_login.Text);
            novaform.Show();
		}
		
		void Button1Click(object sender, System.EventArgs e){
			Status novaform = new Status();
            novaform.Show();
		}
		
		void Button3Click(object sender, EventArgs e){
			Saida novaform = new Saida(user_login.Text);
            novaform.Show();
		}	

		void Button4Click(object sender, EventArgs e){
			Exc_Tsç novaform = new Exc_Tsç(user_login.Text);
      	 	novaform.ShowDialog();
      	 	
		}
		
		void InicioClick(object sender, EventArgs e){
			inicio.Text = "";
			inicio.ForeColor = Color.Black;
		}
		
		void FimClick(object sender, EventArgs e){
			fim.Text = "";
			fim.ForeColor = Color.Black;
		}
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e){
			if (e.KeyChar == 13)
				Gerar.PerformClick();
			if (e.KeyChar == 13)
			Psq_NF.Focus();
		}
		
		void FimKeyPress(object sender, KeyPressEventArgs e){
			if (e.KeyChar == 13)
				Gerar.PerformClick();
		}
		
		void Pesq_ProdutoKeyPress(object sender, KeyPressEventArgs e){
			if (e.KeyChar == 13)
				Gerar.PerformClick();
		}
         
		void Controle_StqLoad(object sender, EventArgs e){
         	user_login.Visible = false;
			ToolStripTextBox User = new ToolStripTextBox();
			User.Text = " Usuário: " + user_login.Text;
			statusStrip1.Items.Add(User);
			User.Size = new System.Drawing.Size(160,15);
			
			ToolStripTextBox data = new ToolStripTextBox();
			data.Text = " Data: " + DateTime.Now.ToLongDateString();
			statusStrip1.Items.Add(data);
			data.Size = new System.Drawing.Size(292,10);
		}
	}
}