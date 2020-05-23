/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 23/07/2019
 * Time: 10:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace Controle
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
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
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void SairClick(object sender, EventArgs e){
			Application.Exit();
		}
		void EntrarClick(object sender, EventArgs e){
//			if(Usuario.Text == ""){
//				MessageBox.Show("Por favor para prosseguir insira o Usuário e Senha!","Login",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
//			}
//			else{
//			// inserir login e senha
//			DataTable dsAgenda = LeDados<SQLiteConnection, SQLiteDataAdapter>("SELECT * FROM Users WHERE Upper(Usuario||Senha) = '" + (this.Usuario.Text + this.Senha.Text).ToUpper() + "'");
//            if( dsAgenda.Rows.Count > 0 ){
//				MessageBox.Show("Seja bem vindo!");
				Menu novaform = new Menu(Usuario.Text);
            	novaform.ShowDialog();
            	this.Hide();
//			} 
//			else{
//				MessageBox.Show("Usuário e Senha incorretos ou usúario não existe!");
//			}
//			}
		}
		
		void UsuarioKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				Senha.Focus();
		}
		
		void SenhaKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				Entrar.Focus();
		}
		
			
	}
}
