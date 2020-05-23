/*
 * Criado por SharpDevelop.
 * Usuário: ricardo.silva
 * Data: 13/08/2019
 * Hora: 14:00
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
	/// Description of Adm_Excluir.
	/// </summary>
	public partial class Adm_Excluir : Form
	{
		
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
		public Adm_Excluir()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CancelarClick(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void Adm_ExcluirLoad(object sender, EventArgs e)
		{
			Usuario.Visible = false;
			Usuario.Text = "administrador";
		}
		
		public string strQuery;
		void ExcluirClick(object sender, EventArgs e)
		{
         
			DataTable dsAgenda = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT * FROM Users WHERE Upper(Usuario||Senha) = '" + (this.Usuario.Text + this.Senha.Text).ToUpper() + "'");
            if( dsAgenda.Rows.Count > 0 ){
				MessageBox.Show("Dados Exclusos com sucesso!");
				
			SQLiteConnection conn = new SQLiteConnection(connectionString);//Criando conexao
            conn.Open();//Abrindo conexao
            strQuery = "DELETE FROM Excluidos";// apagar tudo 
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(strQuery, conn);
                cmd.ExecuteNonQuery();//executando delete
                MessageBox.Show("Excluido"); 
   
                         
            }
            catch (Exception ex)
            {
            	throw (ex);
            }
           FechaBanco(conn);//fechando o banco
				
				
            	this.Hide();
			} 
			else{
				MessageBox.Show("Senha incorreta!");
			}
			
		}
		
		 private void FechaBanco(SQLiteConnection conn)
        {			             if (conn.State == ConnectionState.Open)
		            {
		            conn.Close();
			        }
        }
	}
}
