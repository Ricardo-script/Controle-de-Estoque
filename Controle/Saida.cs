/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 25/07/2019
 * Time: 10:57
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
	/// Description of Saida.
	/// </summary>
	public partial class Saida : Form
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
		
		public Saida()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Saida (string texto){ // carrega usuário
			 	InitializeComponent();
			 	usuario.Text = texto;
			 }

			void CriarLoad(object sender, EventArgs e){
			GetCriarForm();
		}
		
		private void GetCriarForm(){
			try{
				if (dsCriar != null) {
					this.Barras.Text = dsCriar.Rows[0]["Cod_de_Barras"].ToString();
					this.Produto.Text = dsCriar.Rows[0]["Produto"].ToString();
					this.razao.Text = dsCriar.Rows[0]["Fornecedor/Cliente"].ToString();
					this.Unidade.Text = dsCriar.Rows[0]["Unidade_de_Medida"].ToString();
					this.Grupo.Text = dsCriar.Rows[0]["Grupo"].ToString();
					this.Custo.Text = dsCriar.Rows[0]["Custo"].ToString();
					this.Qtd.Text = dsCriar.Rows[0]["Qtd_de_Entrada"].ToString();
					this.Nf.Text = dsCriar.Rows[0]["Número_de_NF"].ToString();
					this.Venda.Text = dsCriar.Rows[0]["Venda"].ToString();
					this.Minimo.Text = dsCriar.Rows[0]["Minimo"].ToString();
					this.Maximo.Text = dsCriar.Rows[0]["Maximo"].ToString();
					this.usuario.Text = dsCriar.Rows[0]["Usuario"].ToString();
					
					Custo.Text = Convert.ToDouble(Custo.Text).ToString("N2");
                    Venda.Text = Convert.ToDouble(Venda.Text).ToString("N2");
                    //Hora.Text = DateTime.Now.ToShortDateString();
                    Hora.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                    
				}
			}
			catch (Exception ex){
				MessageBox.Show(ex.Message);
			}
		}
		
		public string strQuery;
		
		void EnviarClick(object sender, EventArgs e){
			bool sFim = true;
			
			if(Barras.Text == ""){
				MessageBox.Show("Por favor, para pesquisar preencha um nome!", "Insirir Nome",
				                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
			else{
				if(qtde_estoque.Text ==""){
				MessageBox.Show("Você não possui este item em seu estoque, por favor verificar e ajustar em sistema!","Produto em Falta");
				}//sFim = false;
				else{
					
			if(Qtd.Text == ""){
				MessageBox.Show("Necessário informar a quantidade de saída!","Falta a quantidade de saída");
			}
			else{
						
			int saida1 = Convert.ToInt32(Qtd.Text);
			int estoque1 = Convert.ToInt32(qtde_estoque.Text);
			int Min = Convert.ToInt32(Minimo.Text);
			
			
			if(((saida1 - estoque1)*(-1)) <= Min){ 
		    //MessageBox.Show("" + (saida1 - estoque1) + " < " + Min);
			DialogResult result = MessageBox.Show("Este Produto já atingiu a quantidade minima no seu estoque, Será Necessário fazer reposição - Deseja continuar com essa transação mesmo assim?","Quantidade minima atingida", MessageBoxButtons.YesNoCancel);
			if(result == DialogResult.No){
			sFim = false;
			}
			else if (result == DialogResult.Yes){
				
				int saida = Convert.ToInt32(Qtd.Text);
				int estoque = Convert.ToInt32(qtde_estoque.Text);
				if (saida > estoque){
					MessageBox.Show("Quantidade de saída maior do que armazenado em estoque - Não é possivel realizar esta transação!","Estoque Insuficiente");
					sFim = false;
				}
				
				if (sFim == true ){
				
				//MessageBox.Show("verdadeiro");
				SQLiteConnection conn = new SQLiteConnection(connectionString);
				conn.Open();
				string dts = Convert.ToDateTime(Hora.Text).ToString("yyyy-MM-dd HH:mm");
				int QtdNegativo= Convert.ToInt32(Qtd.Text)*(-1);//Textbox Qtd para negativo
				strQuery="INSERT INTO Dados VALUES(Null,'"+fluxo.Text+"','"+Barras.Text+"','"+Produto.Text+"','"+razao.Text+"','"+Unidade.Text+"','"+Grupo.Text+"','"+Custo.Text+"',"+QtdNegativo+",'"+Nf.Text+"','"+Venda.Text+"','"+dts+"','"+Obs.Text+"','"+usuario.Text+"')";
				Barras.Text="";
		        Produto.Text="";
		        razao.Text ="";
		        Unidade.Text ="";
		        Grupo.Text = "";
		        Custo.Text = "";
		        Qtd.Text = "";
		        Nf.Text = "";
		        Venda.Text ="";
		        Hora.Text = "";
		        Obs.Text = "";
		        qtde_estoque.Text = "";
		        Minimo.Text = "";
		        Maximo.Text = "";                 
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
			}
			else{ // se o calculo de estoque minimo estiver dentro dos conformes:
				SQLiteConnection conn = new SQLiteConnection(connectionString);
				conn.Open();
				string dts = Convert.ToDateTime(Hora.Text).ToString("yyyy-MM-dd HH:mm");
				int QtdNegativo= Convert.ToInt32(Qtd.Text)*(-1);//Textbox Qtd para negativo
				strQuery="INSERT INTO Dados VALUES(Null,'"+fluxo.Text+"','"+Barras.Text+"','"+Produto.Text+"','"+razao.Text+"','"+Unidade.Text+"','"+Grupo.Text+"','"+Custo.Text+"',"+QtdNegativo+",'"+Nf.Text+"','"+Venda.Text+"','"+dts+"','"+Obs.Text+"','"+usuario.Text+"')";
				Barras.Text="";
		        Produto.Text="";
		        razao.Text ="";
		        Unidade.Text ="";
		        Grupo.Text = "";
		        Custo.Text = "";
		        Qtd.Text = "";
		        Nf.Text = "";
		        Venda.Text ="";
		        Hora.Text = "";
		        Obs.Text = "";
		        qtde_estoque.Text = "";
		        Minimo.Text = "";
		        Maximo.Text = "";                 
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
				}
			}
		}
        //________________________________________________________________________

        private void FechaBanco(SQLiteConnection conn){
        	if (conn.State == ConnectionState.Open){
        		conn.Close();     
        	}
        }

		void SaidaLoad(object sender, EventArgs e){
			Produto.Enabled = false;
			Unidade.Enabled = false;
			Grupo.Enabled = false;
			Custo.Enabled = false;
			Venda.Enabled = false;
			Hora.Enabled = false;
			qtde_estoque.Enabled = false;
			fluxo.Text = "Venda";
			Minimo.Enabled = false;
			Maximo.Enabled = false;
			usuario.Visible = false;
			
			
        }
		
		void BarrasKeyPress(object sender, KeyPressEventArgs e){
        	if (e.KeyChar == 13){
        		try
        		{
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
                   	    this.Unidade.Text = dsAgenda.Rows[0]["Unidade"].ToString();
                    	this.Grupo.Text = dsAgenda.Rows[0]["Grupo"].ToString();
                    	this.Custo.Text = dsAgenda.Rows[0]["Custo"].ToString();
                    	this.Venda.Text = dsAgenda.Rows[0]["Venda"].ToString();
                    	this.Minimo.Text = dsAgenda.Rows[0]["Minimo"].ToString();
                    	this.Maximo.Text = dsAgenda.Rows[0]["Maximo"].ToString();
                   	    this.qtde_estoque.Text = dsAgenda.Rows[0]["qtde_estoque"].ToString();
                   	    
                   	    Custo.Text = Convert.ToDouble(Custo.Text).ToString("N2");
                   	    Venda.Text = Convert.ToDouble(Venda.Text).ToString("N2");
                   	    Hora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); // aqui não usar o formato ("yyyy-MM-dd H:mm")
                   	    
                   	    double custo1,venda1,total;
						custo1 = Convert.ToDouble(Custo.Text);
			            venda1 = Convert.ToDouble(Venda.Text);
			            total = (venda1 - custo1)/venda1;
			            porcentagem.Text = String.Format("{0:P2}", total);

        			}
        		}
        		catch (Exception a){
        			{
        				throw (a);
        			}
				}
			}
        	if (e.KeyChar == 13)
        		razao.Focus();
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
			Dados novaform = new Dados(usuario.Text);
            novaform.Show();
        }
		
		void Button1Click(object sender, EventArgs e){
			Controle_Stq novaform = new Controle_Stq(usuario.Text);
            novaform.Show();
        }
		
   		void CancelarClick(object sender, EventArgs e){
			Barras.Text="";
			Produto.Text="";
			razao.Text ="";
			razao.Text = "";
			Unidade.Text ="";
            Custo.Text = "";
            Qtd.Text = "";
            Nf.Text = "";
            Venda.Text ="";
            Hora.Text = "";
            Obs.Text = "";
            qtde_estoque.Text = "";
            Grupo.Text = "";
            Minimo.Text = "";
            Maximo.Text = "";
            porcentagem.Text = "";
		}
		void SairClick(object sender, EventArgs e){
			this.Hide();
		}
		
		void RazaoMouseClick(object sender, MouseEventArgs e){
			// Alimentar Combobox
 			this.razao.DisplayMember = "Text";
            this.razao.ValueMember = "Value";
            this.razao.DataSource = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT DISTINCT Nome Value, (Nome||', '||UF) Text FROM Cadastro Order BY Nome");             	
		}
		
		void StatusClick(object sender, EventArgs e){
			Status novaform = new Status();
            novaform.Show();
		}
		
		void RazaoKeyPress(object sender, KeyPressEventArgs e){
			if (e.KeyChar == 13)
        		Qtd.Focus();
		}
        
		void NfKeyPress(object sender, KeyPressEventArgs e){
			if (e.KeyChar == 13)
        		fluxo.Focus();
		}
		
		void FluxoKeyPress(object sender, KeyPressEventArgs e){
			if (e.KeyChar == 13)
        		Obs.Focus();
		}
		
		void ObsKeyPress(object sender, KeyPressEventArgs e){
			if (e.KeyChar == 13)
				Enviar.Focus();
		}
		
		void QtdKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				Nf.Focus();
		}
	}
}