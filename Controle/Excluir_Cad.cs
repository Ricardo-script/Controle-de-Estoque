/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 26/07/2019
 * Time: 09:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace Controle
{
	/// <summary>
	/// Description of Excluir_Cad.
	/// </summary>
	public partial class Excluir_Cad : Form
	{
		
		
		// inserido________ criado dsForm2 / dsGetForm2
		private const String connectionString = @"Data Source=.\Banco\Estoque.db";
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
		
		private DataTable dsCriar;
        public DataTable dsGeCriar{
            get { return dsCriar;  }
            set { dsCriar= value; }
        }
		//______________________
		
		
		public Excluir_Cad()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		// continuar daqui...
		
		// _ Inserido _________________________________
			void CriarLoad(object sender, EventArgs e){
			GetCriarForm();
		}
		
		
        private void GetCriarForm()
        {
            try
            {
            	if (dsCriar != null) {

					this.Barras.Text = dsCriar.Rows[0]["Barras"].ToString();
					this.Descrição.Text = dsCriar.Rows[0]["Descrição"].ToString();
					this.Fornecedor.Text = dsCriar.Rows[0]["Fornecedor"].ToString();
					this.Unidade.Text = dsCriar.Rows[0]["Unidade"].ToString();
					this.Custo.Text = dsCriar.Rows[0]["Custo"].ToString();
					this.Venda.Text = dsCriar.Rows[0]["Venda"].ToString();
            	}

           	}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
		
		
		
		
		void BarrasKeyPress(object sender, KeyPressEventArgs e)
		{

			if (e.KeyChar == 13)
				{
					try
            {
            	// dsAgenda nome criado
            	
            	DataTable dsAgenda = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT * FROM Produto WHERE Upper(Barras) LIKE '" + (this.Barras.Text).ToUpper() + "'");
            	if( dsAgenda.Rows.Count > 0 ){
            		this.Barras.Text = dsAgenda.Rows[0]["Barras"].ToString();
            		this.Descrição.Text = dsAgenda.Rows[0]["Descrição"].ToString();
					this.Fornecedor.Text = dsAgenda.Rows[0]["Fornecedor"].ToString();
                    this.Unidade.Text = dsAgenda.Rows[0]["Unidade"].ToString();
                    this.Custo.Text = dsAgenda.Rows[0]["Custo"].ToString();
                    this.Venda.Text = dsAgenda.Rows[0]["Venda"].ToString();
                
                    
                    Custo.Text = Convert.ToDouble(Custo.Text).ToString("C");
                    Venda.Text = Convert.ToDouble(Venda.Text).ToString("C");
                    

            }
            }
		
            catch (Exception a)
            	{
               
            	
            	
            	throw (a);
	            }
				}
		}
		
		
		void Excluir_CadLoad(object sender, EventArgs e)
		{
			Descrição.Enabled = false;
			Fornecedor.Enabled = false;
			Unidade.Enabled = false;
			Custo.Enabled = false;
			Venda.Enabled = false;
			
		}
		
		void CancelarClick(object sender, EventArgs e){
					Barras.Text = "";
					Descrição.Text = "";
					Fornecedor.Text = "";
					Unidade.Text = "";
					Custo.Text = "";
					Venda.Text = "";
					this.Hide();
		}
		
		
		 public string strQuery;// inserir
		void ExcluirClick(object sender, EventArgs e)
		{
			
			if(Barras.Text == "") {
      MessageBox.Show("Por favor, para pesquisar preencha um produto!", "Insirir Produto",
         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
			else{
			
			SQLiteConnection conn = new SQLiteConnection(connectionString);//Criando conexao
            conn.Open();//Abrindo conexao
            strQuery = "delete From Produto where Barras='"+Barras.Text+"'";// criando delete
           
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(strQuery, conn);
                cmd.ExecuteNonQuery();//executando delete
                MessageBox.Show("Mercadoria excluída do Cadastro!"); 
                
                    Barras.Text = "";
					Descrição.Text = "";
					Fornecedor.Text = "";
					Unidade.Text = "";
					Custo.Text = "";
					Venda.Text = "";
            }
            catch (Exception ex){
            	throw (ex);
            }
           FechaBanco(conn);//fechando o banco
           
			}
		}
		
		
		private void FechaBanco(SQLiteConnection conn){
			if (conn.State == ConnectionState.Open){
				conn.Close();
			}
        }
		
		void Button1Click(object sender, EventArgs e){
			this.Hide();
		}
	}
}
