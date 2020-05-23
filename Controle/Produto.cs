/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 24/07/2019
 * Time: 07:10
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
	/// Description of Produto.
	/// </summary>
	public partial class Produto : Form
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
		
		
		public Produto()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
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
					this.Grupo.Text = dsCriar.Rows[0]["Grupo"].ToString();
					this.Custo.Text = dsCriar.Rows[0]["Custo"].ToString();
					this.Venda.Text = dsCriar.Rows[0]["Venda"].ToString();
            	    this.Minimo.Text = dsCriar.Rows[0]["Minimo"].ToString();
            	    this.Maximo.Text = dsCriar.Rows[0]["Maximo"].ToString();}
           	}
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        // Salvar dados___________________________________________________________

        public string strQuery;// inserir

        void CadastrarClick(object sender, EventArgs e){
        	if(Descrição.Text == ""){
        		MessageBox.Show("Insira a descrição do Produto!", "Insirir Nome do Produto",
        		                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        	}
        	else{
        		
        		if (Minimo.Text == ""){
        			Minimo.Text = "1";
        		}
        		
        		if (Maximo.Text == ""){
        			Maximo.Text = "1000000";
        		}
        		
        		SQLiteConnection conn = new SQLiteConnection(connectionString);
        		conn.Open();
        		strQuery="INSERT OR REPLACE INTO Produto VALUES('"+Barras.Text+"','"+Descrição.Text+"','"+Fornecedor.Text+"','"+Unidade.Text+"','"+Grupo.Text+"','"+Custo.Text+"','"+Venda.Text+"','"+Minimo.Text+"','"+Maximo.Text+"')";
        		Barras.Text = "";
                Descrição.Text="";
                Fornecedor.Text = "";
                Unidade.Text = "";
                Grupo.Text = "";
                Custo.Text = "";
                Venda.Text = "";
                Minimo.Text = "";
                Maximo.Text = "";
                
                MessageBox.Show("Registro salvo em sistema!","Obrigado",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                try
                {
                	SQLiteCommand cmd = new SQLiteCommand(strQuery, conn);
                	cmd.ExecuteNonQuery();
                }
                catch(Exception a)
                {
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
        
		void CancelarClick(object sender, EventArgs e){
        	this.Hide();
        }

		void GrupoMouseClick(object sender, MouseEventArgs e){
        	this.Grupo.DisplayMember = "Text";
            this.Grupo.ValueMember = "Value";
            this.Grupo.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT DISTINCT Grupo Value, (Grupo) Text FROM Grupos Order BY Grupo");
          //this.razao.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT DISTINCT Nome Value, (Nome||', '||UF) Text FROM Cadastro Order BY Nome");   
		}
        
		void FornecedorMouseClick(object sender, MouseEventArgs e){
 			this.Fornecedor.DisplayMember = "Text";
            this.Fornecedor.ValueMember = "Value";
            this.Fornecedor.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT DISTINCT Fornecedor Value, (Fornecedor) Text FROM Fornecedores Order BY Fornecedor");
		}
		
		void UnidadeMouseClick(object sender, MouseEventArgs e){
			//Alimentar Combobox
 			this.Unidade.DisplayMember = "Text";
            this.Unidade.ValueMember = "Value";
            this.Unidade.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT DISTINCT Unidade Value, (Unidade) Text FROM Unidades Order BY Unidade");
		}
        
		void Button1Click(object sender, EventArgs e){
			this.Hide();
		}
		

	}
}
	

