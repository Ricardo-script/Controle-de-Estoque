/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 30/07/2019
 * Time: 12:06
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
	/// Description of Cadastro.
	/// </summary>
	public partial class Cadastro : Form
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
	
		public Cadastro()
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
				if (dsCriar != null) {
					this.Nome.Text = dsCriar.Rows[0]["Nome"].ToString();
                	this.CNPJ.Text = dsCriar.Rows[0]["CNPJ"].ToString();	
                	this.Endereço.Text = dsCriar.Rows[0]["Endereço"].ToString();
                	this.Numero.Text = dsCriar.Rows[0]["Numero"].ToString();
                	this.Bairro.Text = dsCriar.Rows[0]["Bairro"].ToString();
                	this.CEP.Text = dsCriar.Rows[0]["CEP"].ToString();
                	this.UF.Text = dsCriar.Rows[0]["UF"].ToString();
                	this.Cidade.Text = dsCriar.Rows[0]["Cidade"].ToString();
                	this.Contato.Text = dsCriar.Rows[0]["Contato"].ToString();	
                	this.Email.Text = dsCriar.Rows[0]["Email"].ToString();}
                }
            	catch (Exception ex){
                    MessageBox.Show(ex.Message);
                }
            }
		public string strQuery;// inserir
		void CadastrarClick(object sender, EventArgs e){
			if(Nome.Text == ""){
				MessageBox.Show("Por favor, insira um cliente para prosseguir!", "Insirir Nome",
				                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);}
			else{
				SQLiteConnection conn = new SQLiteConnection(connectionString);
				conn.Open();
				strQuery="INSERT INTO Cadastro VALUES('"+Nome.Text+"','"+CNPJ.Text+"','"+Endereço.Text+"','"+Numero.Text+"','"+Bairro.Text+"','"+CEP.Text+"','"+UF.Text+"','"+Cidade.Text+"','"+Contato.Text+"','"+Email.Text+"')";
				Nome.Text="";
                CNPJ.Text="";
                Endereço.Text="";
                Numero.Text="";
                Bairro.Text="";
                CEP.Text="";
                UF.Text="";
                Cidade.Text="";
                Contato.Text="";
                Email.Text="";
                MessageBox.Show("Registro salvo em sistema!","Obrigado",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                try
                {
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
			if (conn.State == ConnectionState.Open)
			{
				conn.Close();
			}
		}
		void CancelarClick(object sender, EventArgs e){
			this.Hide();
		}
		
		void Button1Click(object sender, EventArgs e){
			this.Hide();
		}

	}
}

