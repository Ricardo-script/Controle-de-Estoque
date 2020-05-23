/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 06/08/2019
 * Time: 07:25
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
	/// Description of Configuracao.
	/// </summary>
	public partial class Configuracao : Form
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
		
		public Configuracao()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SairClick(object sender, System.EventArgs e){
			this.Hide();
		}
		
		public string strQuery;// inserir
		void EntrarClick(object sender, EventArgs e){	
			if(Usuario.Text == ""){
				MessageBox.Show("Por favor, preencha o usuário!", "Insirir Nome",
				                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else{
				SQLiteConnection conn = new SQLiteConnection(connectionString);
				conn.Open();
	        	strQuery="INSERT OR REPLACE INTO Users VALUES('"+Usuario.Text+"','"+Senha.Text+"')";
	        	Usuario.Text="";
                Senha.Text ="";
                MessageBox.Show("Registro salvo em sistema!","Obrigado",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                try{
                	SQLiteCommand cmd = new SQLiteCommand(strQuery, conn);
                	cmd.ExecuteNonQuery();
                }
                catch(Exception a){
                	throw (a);
                }
                FechaBanco(conn);
			}
		}
		
	void Button1Click(object sender, EventArgs e){
			this.Hide();
		}
		
	void RecuperarClick(object sender, System.EventArgs e){
			MessageBox.Show("ok");
	}
	void UsuarioMouseClick(object sender, MouseEventArgs e){
			this.Usuario.DisplayMember = "Text";
            this.Usuario.ValueMember = "Value";
            this.Usuario.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT DISTINCT Usuario Value, (Usuario) Text FROM Users Order BY Usuario");            
	}
		void Button2Click(object sender, EventArgs e)
		{
			SQLiteConnection conn = new SQLiteConnection(connectionString);//Criando conexao
            conn.Open();//Abrindo conexao
            strQuery = "delete From Users where Usuario='"+Usuario.Text+"'";// criando delete
            try{
                SQLiteCommand cmd = new SQLiteCommand(strQuery, conn);
                	cmd.ExecuteNonQuery();//executando delete
               		 MessageBox.Show("Excluido"); 
                     	Usuario.Text = ("");
                         Senha.Text = ("");
				            }
            catch (Exception ex){
            	throw (ex);
            }
           FechaBanco(conn);//fechando o banco
		}
		private void FechaBanco(SQLiteConnection conn){	            
			if (conn.State == ConnectionState.Open)  
			{
				conn.Close();
			}
        }
	}
}
