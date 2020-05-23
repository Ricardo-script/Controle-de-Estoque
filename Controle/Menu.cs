/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 23/07/2019
 * Time: 10:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Controle
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public partial class Menu : Form
	{
		public Menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		void InserirEntredaToolStripMenuItemClick(object sender, EventArgs e){
			Dados novaform = new Dados(user_login.Text);// carrega usuário
            novaform.ShowDialog();
		}
		void Cad_ProdutoClick(object sender, EventArgs e){
			Produto novaform = new Produto();
            novaform.Show();
		}
		void SaídaDeMaterialToolStripMenuItemClick(object sender, EventArgs e){
			Saida novaform = new Saida(user_login.Text);
            novaform.ShowDialog();	
		}
		
		void ControleDeEstoqueToolStripMenuItemClick(object sender, EventArgs e){
			Controle_Stq novaform = new Controle_Stq(user_login.Text);
            novaform.ShowDialog();
		}
		
		void Excluir_ProdutoClick(object sender, EventArgs e){
			Excluir_Cad novaform = new Excluir_Cad();
            novaform.Show();
		}
		
		void Exc_TransClick(object sender, EventArgs e){
			Exc_Tsç novaform = new Exc_Tsç(user_login.Text);
            novaform.ShowDialog();
		}

		void CadastrarClick(object sender, EventArgs e){
			Cadastro novaform = new Cadastro();
            novaform.Show();
		}

		void SairToolStripMenuItemClick(object sender, EventArgs e){
			Application.Exit();
		}
		
		void ExcluirTransaçãoToolStripMenuItemClick(object sender, EventArgs e){
			Exc_Tsç novaform = new Exc_Tsç(user_login.Text);
            novaform.ShowDialog();
		}
		
		void Esc_cltClick(object sender, EventArgs e){
			Exc_Cliente novaform = new Exc_Cliente();
            novaform.Show();
		}
		
		void Add_GrupoClick(object sender, EventArgs e){
			AddGupo novaform = new AddGupo();
            novaform.Show();
		}
		
		void Exc_GrupoClick(object sender, EventArgs e){
			Exc_Gp novaform = new Exc_Gp();
            novaform.Show();
		}
		
		void Unid_MedClick(object sender, EventArgs e){
			Unidade novaform = new Unidade();
            novaform.Show();
		}
		
		void Exc_UnidClick(object sender, EventArgs e){
			Exc_Unidade novaform = new Exc_Unidade();
            novaform.Show();
		}
		
		void Add_FornecClick(object sender, EventArgs e){
			Add_Fornecedor novaform = new Add_Fornecedor();
            novaform.Show();
		}
		
		void Exc_FndrClick(object sender, EventArgs e){
		    Exc_Fornecedor novaform = new Exc_Fornecedor();
            novaform.Show();	
		}
		
		void Button1Click(object sender, EventArgs e){
		  Application.Exit();	
		}
		
		void ConfiguraçõesClick(object sender, EventArgs e){
			Configuracao novaform = new Configuracao();
            novaform.Show();	
		}
		
		void TransaçõesExcluídasToolStripMenuItemClick(object sender, EventArgs e){
			Excluido novaform = new Excluido(user_login.Text);
			novaform.ShowDialog();	
		}
		
		
		// carregando Usuário no Status
		void StatisticaEstoqueToolStripMenuItemClick(object sender, EventArgs e){
			Status novaform = new Status();
            novaform.Show();	
		}
		
		public Menu(string texto){
			InitializeComponent();
			ToolStripTextBox status = new ToolStripTextBox();
			status.Text = " Usuário: " + texto;
			user_login.Text = texto;// alimentar os demais
			statusStrip1.Items.Add(status);
			status.Size = new System.Drawing.Size(170,20);
		}
		
		void MenuLoad(object sender, EventArgs e){
			user_login.Visible = false;
			ToolStripTextBox data = new ToolStripTextBox();
			data.Text = " Data: " + DateTime.Now.ToLongDateString();
			statusStrip1.Items.Add(data);
			data.Size = new System.Drawing.Size(292,25);
			
		}

	}
}
