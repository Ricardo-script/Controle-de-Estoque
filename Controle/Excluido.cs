/*
 * Criado por SharpDevelop.
 * Usuário: ricardo.silva
 * Data: 08/08/2019
 * Hora: 10:21
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite; 
using System.Data; 
using Excel = Microsoft.Office.Interop.Excel;

namespace Controle
{
	/// <summary>
	/// Description of Excluido.
	/// </summary>
	public partial class Excluido : Form
	{   
		Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
		
		private const String connectionString = @"Data Source=.\Banco\Estoque.db";
		
		public Excluido()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Excluido (string texto){
			InitializeComponent();
			usuario.Text = texto; // textbox do segundo form = variavel
		}
		 	 
		
		String insSQL = "select * from Excluidos";	// from selecionar o nome da tabela para gerar no datagridview		
		
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
		
		void VisualizarClick(object sender, EventArgs e){
        	{
        		DataTable dt = new DataTable();
        		Tela.DataSource = null;	//  tela é o nome do DataGridView
        		if (insSQL != ""){
        			Tela.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>(insSQL);}
        		
        		
        		foreach(DataGridViewColumn column in Tela.Columns)
				{
			    if (column.DataPropertyName == "Cod_de_Barras")
			        column.Width = 165; 
			    if (column.DataPropertyName == "Produto")
			        column.Width = 160; 
			    if (column.DataPropertyName == "Fornecedor/Cliente")
			        column.Width = 160; 
			    if (column.DataPropertyName == "Unidade_de_Medida")
			        column.Width = 135;
			    if (column.DataPropertyName == "Observações")
			        column.Width = 400;
			    if (column.DataPropertyName == "Motivo da Exclusão")
			        column.Width = 400; 
			    if (column.DataPropertyName == "Usuário da Transação")
			        column.Width = 175;
			    if (column.DataPropertyName == "Usuário da Exclusão")
			        column.Width = 175;
			    
			    
			    // Centralizar corpo de texto do Datagridview
    
			    Tela.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    
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
			     Tela.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			     
			     // Formatação de Valores
				Tela.Columns[7].DefaultCellStyle.Format = "C2";
				Tela.Columns[10].DefaultCellStyle.Format = "C2";

        		}
        	}
        }
		
		void SairClick(object sender, EventArgs e){
			this.Hide();
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

            for (int c = 1; c < Tela.Columns.Count + 1; c++)
            {

                WorkSheet.Cells[1, c] = Tela.Columns[c - 1].HeaderText;

            } 

            // passa as celulas do DataGridView para a Pasta do Excel 
            for (i = 0; i <= Tela.RowCount - 1; i++)
            {

                for (j = 0; j <= Tela.ColumnCount - 1; j++){
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
				MessageBox.Show("cancelado!","Não Exportado");
			}
		}
		
		void InicioClick(object sender, EventArgs e){
			this.Hide();
		}
		
		void EstoqueClick(object sender, EventArgs e){
			Controle_Stq novaform = new Controle_Stq(usuario.Text);
            novaform.ShowDialog();
		}
        
        void Excluir_tudoClick(object sender, EventArgs e){
        MessageBox.Show("Ao excluir os dados eles serão apagados definitivamente do sistema! Necessário permissão do administrador para executar essa opção!"," Requer Permissão Administrativa");	
		Adm_Excluir novaform = new Adm_Excluir();
        novaform.Show();
        }
		
		void ExcluidoLoad(object sender, EventArgs e){
		 usuario.Visible = false;
		}
	}
}