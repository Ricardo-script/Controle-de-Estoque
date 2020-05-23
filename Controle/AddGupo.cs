/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 31/07/2019
 * Time: 14:13
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
	/// Description of AddGupo.
	/// </summary>
	public partial class AddGupo : Form
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
		
		
		public AddGupo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
      
		void CriarLoad(object sender, EventArgs e){
			GetCriarForm();
		}
		private void GetCriarForm()
		{
			try
			{
				if (dsCriar != null){
				}
			}
			catch (Exception ex){
				MessageBox.Show(ex.Message);
			}
		}
		
		public string strQuery;
		void CadastrarClick(object sender, EventArgs e){ 	
			if(Grupo.Text == "") {
				MessageBox.Show("Por favor, para pesquisar preencha um nome!", "Insirir Nome",
				                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else{
				SQLiteConnection conn = new SQLiteConnection(connectionString);
				conn.Open();
				if(Grupo.Text == "" )
				{
					MessageBox.Show("Por favor insira um tipo de Grupo");
				} 
				else{
					strQuery="INSERT INTO Grupos VALUES('"+Grupo.Text+"')";
				}
				Grupo.Text ="";
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
