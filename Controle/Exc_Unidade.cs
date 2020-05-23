/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 31/07/2019
 * Time: 16:36
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
	/// Description of Exc_Unidade.
	/// </summary>
	public partial class Exc_Unidade : Form
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
		
		public Exc_Unidade()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public string strQuery;
		
		void Excluir_UnidadeClick(object sender, EventArgs e)
		{
			SQLiteConnection conn = new SQLiteConnection(connectionString);//Criando conexao
            conn.Open();//Abrindo conexao
            strQuery = "delete From Unidades where Unidade='"+Und.Text+"'";// criando delete
            try
            {
            	SQLiteCommand cmd = new SQLiteCommand(strQuery, conn);
                cmd.ExecuteNonQuery();//executando delete
                MessageBox.Show("Excluido"); 
                
                // limpar textbox
                         Und.Text = ("");
            }
            catch (Exception ex)
            {
            	throw (ex);
            }
           FechaBanco(conn);//fechando o banco	
            
		}
		
		private void FechaBanco(SQLiteConnection conn){
			if (conn.State == ConnectionState.Open){
				conn.Close();
			}
        }
		
		void UndMouseClick(object sender, MouseEventArgs e){
			this.Und.DisplayMember = "Text";
            this.Und.ValueMember = "Value";
            this.Und.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT DISTINCT Unidade Value, (Unidade) Text FROM Unidades Order BY Unidade");
            //this.Grupo.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT DISTINCT Grupo Value, (Grupo) Text FROM Grupos Order BY Grupo");
		}
		
		void Button1Click(object sender, EventArgs e){
			this.Hide();
		}
	}
}
