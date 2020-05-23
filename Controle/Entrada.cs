/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 24/07/2019
 * Time: 09:04
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
	/// Description of Dados.
	/// </summary>
	public partial class Dados : Form
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
            get { return dsCriar; }
            set { dsCriar= value; }
            
            
        }

		public Dados()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		public Dados (string texto){ // carrega usuário
			 	InitializeComponent();
			 	usuario.Text = texto;
			 }
		
		void CriarLoad(object sender, EventArgs e){
			GetCriarForm();
		}
		
        private void GetCriarForm(){
			try{
				if (dsCriar != null){
            		
					this.Barras.Text = dsCriar.Rows[0]["Cod_de_Barras"].ToString();
					this.Produto.Text = dsCriar.Rows[0]["Produto"].ToString();
					this.Fornecedor.Text = dsCriar.Rows[0]["Fornecedor"].ToString();
					this.Unidade.Text = dsCriar.Rows[0]["Unidade_de_Medida"].ToString();
					this.Grupo.Text = dsCriar.Rows[0]["Grupo"].ToString();
					this.Custo.Text = dsCriar.Rows[0]["Custo"].ToString();
					this.Qtd.Text = dsCriar.Rows[0]["Qtd_de_Entrada"].ToString();
					this.Nf.Text = dsCriar.Rows[0]["Número_de_NF"].ToString();
					this.Venda.Text = dsCriar.Rows[0]["Venda"].ToString();
					this.Hora.Text = dsCriar.Rows[0]["Data"].ToString();
				    this.Minimo.Text = dsCriar.Rows[0]["Minimo"].ToString();
			        this.Maximo.Text = dsCriar.Rows[0]["Maximo"].ToString();
					this.usuario.Text = dsCriar.Rows[0]["Usuario"].ToString();}
			}
			
            catch (Exception ex)
            {
            	MessageBox.Show(ex.Message);
            }
		}

        // Salvar dados___________________________________________________________

        public string strQuery;
        
        void EnviarClick(object sender, EventArgs e){
        	bool sFim = true;
        	
        	if(Produto.Text == ""){
        		MessageBox.Show("Por favor, para pesquisar preencha um produto!", "Insirir Produto",
        		                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        	}
        	
        	else {
        	int Entrada = Convert.ToInt32(Qtd.Text);
        	int Estoque = Convert.ToInt32(qtde_estoque.Text);
			int Limite = Convert.ToInt32(Maximo.Text);
			

			if ((Entrada + Estoque) > Limite){
			DialogResult result = MessageBox.Show("Este produto já atingiu o estoque máximo - Deseja continuar com essa entrada?","Quantidade Máxima atingida", MessageBoxButtons.YesNoCancel);
			if(result == DialogResult.No){
				sFim = false;
			}
	        else if (result == DialogResult.Yes){
				
        		SQLiteConnection conn = new SQLiteConnection(connectionString);
        		conn.Open();
        		string dts = Convert.ToDateTime(Hora.Text).ToString("yyyy-MM-dd HH:mm");
        		
        		strQuery="INSERT INTO Dados VALUES(Null,'"+fluxo.Text+"','"+Barras.Text+"','"+Produto.Text+"','"+Fornecedor.Text+"','"+Unidade.Text+"','"+Grupo.Text+"','"+Custo.Text+"','"+Qtd.Text+"','"+Nf.Text+"','"+Venda.Text+"','"+dts+"','"+Obs.Text+"','"+usuario.Text+"')";
        		Barras.Text="";
                Produto.Text="";
                Fornecedor.Text ="";
                Unidade.Text ="";
                Grupo.Text = "";
                Custo.Text = "";
                Qtd.Text = "";
                Nf.Text = "";
                Venda.Text ="";
                Hora.Text = "";
                Obs.Text = "";
                Minimo.Text = "";
                Maximo.Text = "";
                qtde_estoque.Text = "";
                
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
			else{
				SQLiteConnection conn = new SQLiteConnection(connectionString);
        		conn.Open();
        		string dts = Convert.ToDateTime(Hora.Text).ToString("yyyy-MM-dd HH:mm");

        		strQuery="INSERT INTO Dados VALUES(Null,'"+fluxo.Text+"','"+Barras.Text+"','"+Produto.Text+"','"+Fornecedor.Text+"','"+Unidade.Text+"','"+Grupo.Text+"','"+Custo.Text+"','"+Qtd.Text+"','"+Nf.Text+"','"+Venda.Text+"','"+dts+"','"+Obs.Text+"','"+usuario.Text+"')";
        		Barras.Text="";
                Produto.Text="";
                Fornecedor.Text ="";
                Unidade.Text ="";
                Grupo.Text = "";
                Custo.Text = "";
                Qtd.Text = "";
                Nf.Text = "";
                Venda.Text ="";
                Hora.Text = "";
                Obs.Text = "";
                Minimo.Text = "";
                Maximo.Text = "";
                qtde_estoque.Text = "";
                
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
        }
        //__________________________________________________________________________
       private void FechaBanco(SQLiteConnection conn){
        	if (conn.State == ConnectionState.Open)
        	{
        		conn.Close();
        	}
        }
		
		void PesquisarClick(object sender, EventArgs e){
        	try
        	{
        		DataTable dsAgenda = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT * FROM Dados WHERE Upper(Cod_de_Barras) LIKE '" + (this.Barras.Text).ToUpper() + "'");
        		if( dsAgenda.Rows.Count > 0 ){
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
                    this.Hora.Text = dsCriar.Rows[0]["Data"].ToString();
                    this.Obs.Text = dsCriar.Rows[0]["Observações"].ToString();
                    this.Minimo.Text = dsCriar.Rows[0]["Minimo"].ToString();
                    this.Maximo.Text = dsCriar.Rows[0]["Maximo"].ToString();
                    
                    Custo.Text = Convert.ToDouble(Custo.Text).ToString("N2");
                    Venda.Text = Convert.ToDouble(Venda.Text).ToString("N2");
        		}
            }
		
            catch (Exception a){
        		throw (a);
        	}
        }
		
		void CancelarClick(object sender, EventArgs e){
        	Barras.Text=("");
            Produto.Text=("");
            Fornecedor.Text =("");
            Unidade.Text =("");
            Grupo.Text = ("");
            Custo.Text = ("");
            Qtd.Text = ("");
            Nf.Text = "";
            Venda.Text ="";
            Hora.Text = "";
            Obs.Text = "";
            Minimo.Text = "";
            Maximo.Text = "";
            qtde_estoque.Text = "";
		}
        
        
        //public Dados (string texto){ // variável para o usuário
			 //InitializeComponent();
		void DadosLoad(object sender, EventArgs e){
        	Produto.Enabled = false;
			Unidade.Enabled = false;
			Grupo.Enabled = false;
			Custo.Enabled = false;
			Venda.Enabled = false;
			Hora.Enabled = false;
			fluxo.Text = "Entrada";
			fluxo.Visible = false;
			usuario.Visible = false;
			Minimo.Enabled = false;
			Maximo.Enabled = false;
			qtde_estoque.Enabled = false;
			 }
       
		void BarrasKeyPress(object sender, KeyPressEventArgs e){
        	if (e.KeyChar == 13)
        	{
        		try
        		{
        			//DataTable dsAgenda = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT * FROM Produto WHERE Upper(Barras) LIKE '" + (this.Barras.Text).ToUpper() + "'");
        			DataTable dsAgenda = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT " +
            	                                                                  "   P.*, SUM(Qtd_de_Entrada) qtde_estoque " +
            	                                                                  "FROM " +
            	                                                                  "   Produto P " +
            	                                                                  "   LEFT JOIN Dados D ON ( P.Barras = D.Cod_de_Barras ) " +
            	                                                                  "WHERE " +
            	                                                                  "   Upper(P.Barras) LIKE '" + (this.Barras.Text).ToUpper() + "' " +
            	                                                                  "GROUP BY" +
            	                                                                  "   P.Barras");
        			if( dsAgenda.Rows.Count > 0 ){
        				this.Barras.Text = dsAgenda.Rows[0]["Barras"].ToString();
            			this.Produto.Text = dsAgenda.Rows[0]["Descrição"].ToString();
						this.Fornecedor.Text = dsAgenda.Rows[0]["Fornecedor"].ToString();
                    	this.Unidade.Text = dsAgenda.Rows[0]["Unidade"].ToString();
                    	this.Grupo.Text = dsAgenda.Rows[0]["Grupo"].ToString();
                    	this.Custo.Text = dsAgenda.Rows[0]["Custo"].ToString();
                    	this.Venda.Text = dsAgenda.Rows[0]["Venda"].ToString();
                    	this.Minimo.Text = dsAgenda.Rows[0]["Minimo"].ToString();
                    	this.Maximo.Text = dsAgenda.Rows[0]["Maximo"].ToString();
                    	Custo.Text = Convert.ToDouble(Custo.Text).ToString("N2");
                    	Venda.Text = Convert.ToDouble(Venda.Text).ToString("N2");
                   	    Hora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); // aqui não usar o formato ("yyyy-MM-dd H:mm")
                   	    this.qtde_estoque.Text = dsAgenda.Rows[0]["qtde_estoque"].ToString();
        			}
        		}
        		catch (Exception a){
        			throw (a);
        		}
        	}
        	
        	// Evitar erros de textbox vazios:
        	if(qtde_estoque.Text == ""){
        		qtde_estoque.Text = "0";
        		qtde_estoque.ForeColor = Color.White;
        	}
        	
        	if(Minimo.Text == ""){
        		Minimo.Text = "0";
        		Minimo.ForeColor = Color.White;
        	}
        	
        	if(Maximo.Text == ""){
        		Maximo.Text = "0";
        		Maximo.ForeColor = Color.White;
        	}
        		if (e.KeyChar == 13)
        			Qtd.Focus();
		}
		
			
		void InicioClick(object sender, EventArgs e){
        	Menu novaform = new Menu();
            novaform.Show();
            this.Hide();
		}

		void CadastroClick(object sender, EventArgs e){
			Produto novaform = new Produto();
            novaform.Show(); 
		}

		void EntClick(object sender, EventArgs e){
			 	Saida novaform = new Saida(usuario.Text);//carrega usuário
           		novaform.Show();
            	
		}
		
		void Button1Click(object sender, EventArgs e){
			Controle_Stq novaform = new Controle_Stq(usuario.Text);
            novaform.Show();
		}
		
		void SairClick(object sender, EventArgs e){
			this.Hide();
		}
		
		void FornecedorMouseClick(object sender, MouseEventArgs e){
			// Alimentar Combobox
 			this.Fornecedor.DisplayMember = "Text";
            this.Fornecedor.ValueMember = "Value";
            this.Fornecedor.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT DISTINCT Fornecedor Value, (Fornecedor) Text FROM Fornecedores Order BY Fornecedor");
		}

		void StatusClick(object sender, EventArgs e){
			Status novaform = new Status();
            novaform.Show();
		}
		
		void QtdKeyPress(object sender, KeyPressEventArgs e){
			if (e.KeyChar == 13)
				Nf.Focus();
		}
		
		void NfKeyPress(object sender, KeyPressEventArgs e){
			if (e.KeyChar == 13)
				Obs.Focus();
		}
		
		void ObsKeyPress(object sender, KeyPressEventArgs e){
			if (e.KeyChar == 13)Enviar.PerformClick();
		}

	}
}

