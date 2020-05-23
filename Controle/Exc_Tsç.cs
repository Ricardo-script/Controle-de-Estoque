/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 26/07/2019
 * Time: 11:47
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
	/// Description of Exc_Tsç.
	/// </summary>
	public partial class Exc_Tsç : Form
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
		
		
		public Exc_Tsç()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Exc_Tsç(string texto){
			InitializeComponent();
			usuario_exc.Text = texto;
		}
		
		void CriarLoad(object sender, EventArgs e){
			GetCriarForm();
		}
		
		private void GetCriarForm()
		{
			try
			{
				if (dsCriar != null) {
					this.Transação.Text = dsCriar.Rows[0]["Transação"].ToString();
                    this.fluxo.Text = dsCriar.Rows[0]["Tipo de Fluxo"].ToString();
                	this.Barras.Text = dsCriar.Rows[0]["Cod_de_Barras"].ToString();
            		this.Produto.Text = dsCriar.Rows[0]["Produto"].ToString();
					this.Fornecedor.Text = dsCriar.Rows[0]["Fornecedor/Cliente"].ToString();
                    this.Unidade.Text = dsCriar.Rows[0]["Unidade_de_Medida"].ToString();
                    this.Custo.Text = dsCriar.Rows[0]["Custo"].ToString();
                    this.Qtd.Text = dsCriar.Rows[0]["Qtd_de_Entrada"].ToString();
                    this.Nf.Text = dsCriar.Rows[0]["Número_de_NF"].ToString();
                    this.Venda.Text = dsCriar.Rows[0]["Venda"].ToString();
                    this.Hora.Text = dsCriar.Rows[0]["Data"].ToString();
                    this.usuário.Text = dsCriar.Rows[0]["Data"].ToString();
                    this.usuario_exc.Text = dsCriar.Rows[0]["Data"].ToString();
                    this.Obs.Text = dsCriar.Rows[0]["Observações"].ToString();
                    this.Motivo.Text = dsCriar.Rows[0]["Motivo da Exclusão"].ToString();
                    
                    Custo.Text = Convert.ToDouble(Custo.Text).ToString("C");
                    Venda.Text = Convert.ToDouble(Venda.Text).ToString("C");
				}
			}
			catch (Exception ex){
				MessageBox.Show(ex.Message);
			}
		}
		
		private void FechaBanco(SQLiteConnection conn){
			if (conn.State == ConnectionState.Open)
			{
				conn.Close();
			}
		}
        
		public string strQuery;
		public string strQuery2;
		void ExcluirClick(object sender, EventArgs e)
		{
			if(Transação.Text == ""){
				MessageBox.Show("Por favor, para excluir preencha o número da transação!", "Insirir Número de Transação",
				                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else{
				SQLiteConnection conn = new SQLiteConnection(connectionString);
				conn.Open();

				
                strQuery="INSERT INTO Excluidos VALUES('"+Transação.Text+"','"+fluxo.Text+"','"+Barras.Text+"','"+Produto.Text+"','"+Fornecedor.Text+"','"+Unidade.Text+"','"+Grupo.Text+"','"+Custo.Text+"','"+Qtd.Text+"','"+Nf.Text+"','"+Venda.Text+"','"+Hora.Text+"','"+Obs.Text+"','"+Motivo.Text+"','"+usuário.Text+"','"+usuario_exc.Text+"')";
	            strQuery2 = "delete From Dados where Transação='"+Transação.Text+"'";// criando delete
	            try{
	            	SQLiteCommand cmd = new SQLiteCommand(strQuery, conn);
	            	cmd.ExecuteNonQuery();//executando delete
	            	
	            	SQLiteCommand cmd2 = new SQLiteCommand(strQuery2, conn);
		            cmd2.ExecuteNonQuery();//executando delete
		            
		            MessageBox.Show("Transação excluída do Sistema!");
		            Transação.Text = "";
		            fluxo.Text = "";
		            Barras.Text = "";
		            Produto.Text = "";
					Fornecedor.Text = "";
		            Unidade.Text ="";
		            Custo.Text = "";
		            Qtd.Text = "";
		            Nf.Text = "";
		            Venda.Text = "";
		            Hora.Text = "";
		            Obs.Text = "";
		            usuario_exc.Text = "";
		            usuário.Text = "";
		            Motivo.Text = "";
	            }
	            catch (Exception ex)
	            {
	            	throw (ex);
	            }
	            FechaBanco(conn);//fechando o banco
			}
		}
		
		void Exc_TsçLoad(object sender, EventArgs e){
					fluxo.Enabled = false;
                	Barras.Enabled = false;
            		Produto.Enabled = false;
					Fornecedor.Enabled = false;
                    Unidade.Enabled = false;
                    Grupo.Enabled = false;
                    Custo.Enabled = false;
                    Qtd.Enabled = false;
                    Nf.Enabled = false;
                    Venda.Enabled = false;
                    Hora.Enabled = false;
                    usuário.Enabled = false;
                    Obs.Enabled = false;
                    usuario_exc.Visible = false;
		}
		
		void CancelarClick(object sender, EventArgs e){
			this.Hide();
		}
		
		void Button1Click(object sender, EventArgs e){
			Controle_Stq novaform = new Controle_Stq();
            novaform.Show();
		}

		void TransaçãoKeyPress(object sender, KeyPressEventArgs e){
			if (e.KeyChar == 13)
			{
				try
				{
					DataTable dsAgenda = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT * FROM Dados WHERE Upper(Transação) LIKE '" + (this.Transação.Text).ToUpper() + "'");
					if( dsAgenda.Rows.Count > 0 ){
						this.Transação.Text = dsAgenda.Rows[0]["Transação"].ToString();
		            	this.fluxo.Text = dsAgenda.Rows[0]["Tipo de Fluxo"].ToString();
		                this.Barras.Text = dsAgenda.Rows[0]["Cod_de_Barras"].ToString();
		            	this.Produto.Text = dsAgenda.Rows[0]["Produto"].ToString();
						this.Fornecedor.Text = dsAgenda.Rows[0]["Fornecedor/Cliente"].ToString();
		                this.Unidade.Text = dsAgenda.Rows[0]["Unidade_de_Medida"].ToString();
		                this.Grupo.Text = dsAgenda.Rows[0]["Grupo"].ToString();
		                this.Custo.Text = dsAgenda.Rows[0]["Custo"].ToString();
		                this.Qtd.Text = dsAgenda.Rows[0]["Qtd_de_Entrada"].ToString();
		                this.Nf.Text = dsAgenda.Rows[0]["Número_de_NF"].ToString();
		                this.Venda.Text = dsAgenda.Rows[0]["Venda"].ToString();
		                this.Hora.Text = dsAgenda.Rows[0]["Data"].ToString();
		                this.Obs.Text = dsAgenda.Rows[0]["Observações"].ToString();
		                this.usuário.Text = dsAgenda.Rows[0]["Usuario"].ToString();}
		                
		                
				}
				catch (Exception a){
					throw (a);
				}
			}
		}
		
		void Button2Click(object sender, EventArgs e){
			this.Hide();
		}
	}
}
