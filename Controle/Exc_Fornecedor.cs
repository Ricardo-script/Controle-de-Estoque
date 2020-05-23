/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 01/08/2019
 * Time: 14:09
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
	/// Description of Exc_Fornecedor.
	/// </summary>
	public partial class Exc_Fornecedor : Form
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
		
		public Exc_Fornecedor()
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

                        this.Fornecedor.Text = dsCriar.Rows[0]["Fornecedor"].ToString();
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
		
		
		void FornecedorKeyPress(object sender, KeyPressEventArgs e)
		{
			  try
            {
            	// dsAgenda nome criado
            	DataTable dsAgenda = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT * FROM Fornecedores WHERE Upper(Fornecedor) = '" + (this.Fornecedor.Text).ToUpper() + "'");
            	if( dsAgenda.Rows.Count > 0 ){
            	
						this.Fornecedor.Text = dsAgenda.Rows[0]["Fornecedor"].ToString();
                        this.CNPJ.Text = dsAgenda.Rows[0]["CNPJ"].ToString();
                        this.Endereço.Text = dsAgenda.Rows[0]["Endereço"].ToString();
                        this.Numero.Text = dsAgenda.Rows[0]["Numero"].ToString();
                        this.Bairro.Text = dsAgenda.Rows[0]["Bairro"].ToString();
                        this.CEP.Text = dsAgenda.Rows[0]["CEP"].ToString();
                        this.UF.Text = dsAgenda.Rows[0]["UF"].ToString();
                        this.Cidade.Text = dsAgenda.Rows[0]["Cidade"].ToString();
                        this.Contato.Text = dsAgenda.Rows[0]["Contato"].ToString();
                        this.Email.Text = dsAgenda.Rows[0]["Email"].ToString();}            		
  
            }
            
            catch (Exception a)
            {
               throw (a);
            }
		}
		
		void CancelarClick(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void Exc_FornecedorLoad(object sender, EventArgs e)
		{
			CNPJ.Enabled = false;
	        Endereço.Enabled = false;
	        Numero.Enabled = false;
	        Bairro.Enabled = false;
	        CEP.Enabled = false;
	        UF.Enabled = false;
	        Cidade.Enabled = false;
	        Contato.Enabled = false;
	        Email.Enabled = false;	
		}
        
		public string strQuery;
		void ExcluirClick(object sender, EventArgs e)
		{
			SQLiteConnection conn = new SQLiteConnection(connectionString);//Criando conexao
            conn.Open();//Abrindo conexao
            strQuery = "delete From Fornecedores where Fornecedor='"+Fornecedor.Text+"'";
           
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(strQuery, conn);
                cmd.ExecuteNonQuery();//executando delete
                MessageBox.Show("Excluido"); 

                         	Fornecedor.Text = "";
	                        CNPJ.Text = "";
	                        Endereço.Text ="";
	                        Numero.Text =""; 
	                        Bairro.Text = "";
	                        CEP.Text = "";
	                        UF.Text = "";
	                        Cidade.Text = "";
	                        Contato.Text = "";
	                        Email.Text = "";
                         
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
		 
		 
		 void FornecedorMouseClick(object sender, System.Windows.Forms.MouseEventArgs e){
			this.Fornecedor.DisplayMember = "Text";
            this.Fornecedor.ValueMember = "Value";
            this.Fornecedor.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT DISTINCT Fornecedor Value, (Fornecedor) Text FROM Fornecedores Order BY Fornecedor");
		}
		
		void Button1Click(object sender, EventArgs e){
		this.Hide();
		}
	}
}
