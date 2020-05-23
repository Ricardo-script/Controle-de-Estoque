/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 23/07/2019
 * Time: 10:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Controle
{
	partial class Menu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inserirEntredaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saídaDeMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.excluirTransaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.controleDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.transaçõesExcluídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statisticaEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.Exc_Trans = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.Excluir_Produto = new System.Windows.Forms.Button();
			this.Add_Fornec = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.Cadastrar = new System.Windows.Forms.Button();
			this.Unid_Med = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Add_Grupo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Cad_Produto = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.Esc_clt = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.Exc_Grupo = new System.Windows.Forms.Button();
			this.Exc_Unid = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.Exc_Fndr = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.Configurações = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.status = new System.Windows.Forms.ToolStripStatusLabel();
			this.data = new System.Windows.Forms.ToolStripStatusLabel();
			this.user_login = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.arquivoToolStripMenuItem,
									this.relatóriosToolStripMenuItem,
									this.statusToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1090, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.inserirEntredaToolStripMenuItem,
									this.saídaDeMaterialToolStripMenuItem,
									this.excluirTransaçãoToolStripMenuItem,
									this.sairToolStripMenuItem});
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.arquivoToolStripMenuItem.Text = "Arquivo";
			// 
			// inserirEntredaToolStripMenuItem
			// 
			this.inserirEntredaToolStripMenuItem.Name = "inserirEntredaToolStripMenuItem";
			this.inserirEntredaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.inserirEntredaToolStripMenuItem.Text = "Inserir Entrada de Material";
			this.inserirEntredaToolStripMenuItem.Click += new System.EventHandler(this.InserirEntredaToolStripMenuItemClick);
			// 
			// saídaDeMaterialToolStripMenuItem
			// 
			this.saídaDeMaterialToolStripMenuItem.Name = "saídaDeMaterialToolStripMenuItem";
			this.saídaDeMaterialToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.saídaDeMaterialToolStripMenuItem.Text = "Saída de Material";
			this.saídaDeMaterialToolStripMenuItem.Click += new System.EventHandler(this.SaídaDeMaterialToolStripMenuItemClick);
			// 
			// excluirTransaçãoToolStripMenuItem
			// 
			this.excluirTransaçãoToolStripMenuItem.Name = "excluirTransaçãoToolStripMenuItem";
			this.excluirTransaçãoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.excluirTransaçãoToolStripMenuItem.Text = "Excluir Transação";
			this.excluirTransaçãoToolStripMenuItem.Click += new System.EventHandler(this.ExcluirTransaçãoToolStripMenuItemClick);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItemClick);
			// 
			// relatóriosToolStripMenuItem
			// 
			this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.controleDeEstoqueToolStripMenuItem,
									this.transaçõesExcluídasToolStripMenuItem});
			this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
			this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.relatóriosToolStripMenuItem.Text = "Relatório";
			// 
			// controleDeEstoqueToolStripMenuItem
			// 
			this.controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
			this.controleDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
			this.controleDeEstoqueToolStripMenuItem.Text = "Controle de Movimentações";
			this.controleDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.ControleDeEstoqueToolStripMenuItemClick);
			// 
			// transaçõesExcluídasToolStripMenuItem
			// 
			this.transaçõesExcluídasToolStripMenuItem.Name = "transaçõesExcluídasToolStripMenuItem";
			this.transaçõesExcluídasToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
			this.transaçõesExcluídasToolStripMenuItem.Text = "Transações Excluídas";
			this.transaçõesExcluídasToolStripMenuItem.Click += new System.EventHandler(this.TransaçõesExcluídasToolStripMenuItemClick);
			// 
			// statusToolStripMenuItem
			// 
			this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.statisticaEstoqueToolStripMenuItem});
			this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
			this.statusToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.statusToolStripMenuItem.Text = "Estoque";
			// 
			// statisticaEstoqueToolStripMenuItem
			// 
			this.statisticaEstoqueToolStripMenuItem.Name = "statisticaEstoqueToolStripMenuItem";
			this.statisticaEstoqueToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.statisticaEstoqueToolStripMenuItem.Text = "Consultar Estoque";
			this.statisticaEstoqueToolStripMenuItem.Click += new System.EventHandler(this.StatisticaEstoqueToolStripMenuItemClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))));
			this.panel2.Location = new System.Drawing.Point(62, 95);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(970, 2);
			this.panel2.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(768, 267);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(96, 19);
			this.label8.TabIndex = 27;
			this.label8.Text = "Excluir Transação";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Exc_Trans
			// 
			this.Exc_Trans.BackColor = System.Drawing.Color.Transparent;
			this.Exc_Trans.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Exc_Trans.Image = ((System.Drawing.Image)(resources.GetObject("Exc_Trans.Image")));
			this.Exc_Trans.Location = new System.Drawing.Point(774, 178);
			this.Exc_Trans.Name = "Exc_Trans";
			this.Exc_Trans.Size = new System.Drawing.Size(85, 86);
			this.Exc_Trans.TabIndex = 6;
			this.Exc_Trans.UseVisualStyleBackColor = false;
			this.Exc_Trans.Click += new System.EventHandler(this.Exc_TransClick);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(215, 396);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 19);
			this.label7.TabIndex = 25;
			this.label7.Text = "Excluir Produto";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Excluir_Produto
			// 
			this.Excluir_Produto.BackColor = System.Drawing.Color.Transparent;
			this.Excluir_Produto.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Excluir_Produto.Image = ((System.Drawing.Image)(resources.GetObject("Excluir_Produto.Image")));
			this.Excluir_Produto.Location = new System.Drawing.Point(219, 307);
			this.Excluir_Produto.Name = "Excluir_Produto";
			this.Excluir_Produto.Size = new System.Drawing.Size(85, 86);
			this.Excluir_Produto.TabIndex = 7;
			this.Excluir_Produto.UseVisualStyleBackColor = false;
			this.Excluir_Produto.Click += new System.EventHandler(this.Excluir_ProdutoClick);
			// 
			// Add_Fornec
			// 
			this.Add_Fornec.BackColor = System.Drawing.Color.Transparent;
			this.Add_Fornec.ForeColor = System.Drawing.Color.White;
			this.Add_Fornec.Image = ((System.Drawing.Image)(resources.GetObject("Add_Fornec.Image")));
			this.Add_Fornec.Location = new System.Drawing.Point(666, 178);
			this.Add_Fornec.Name = "Add_Fornec";
			this.Add_Fornec.Size = new System.Drawing.Size(85, 86);
			this.Add_Fornec.TabIndex = 5;
			this.Add_Fornec.UseVisualStyleBackColor = false;
			this.Add_Fornec.Click += new System.EventHandler(this.Add_FornecClick);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(552, 267);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 19);
			this.label4.TabIndex = 21;
			this.label4.Text = "Adicionar Cliente";
			// 
			// Cadastrar
			// 
			this.Cadastrar.BackColor = System.Drawing.Color.Transparent;
			this.Cadastrar.ForeColor = System.Drawing.Color.White;
			this.Cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("Cadastrar.Image")));
			this.Cadastrar.Location = new System.Drawing.Point(554, 178);
			this.Cadastrar.Name = "Cadastrar";
			this.Cadastrar.Size = new System.Drawing.Size(85, 86);
			this.Cadastrar.TabIndex = 4;
			this.Cadastrar.UseVisualStyleBackColor = false;
			this.Cadastrar.Click += new System.EventHandler(this.CadastrarClick);
			// 
			// Unid_Med
			// 
			this.Unid_Med.BackColor = System.Drawing.Color.Transparent;
			this.Unid_Med.ForeColor = System.Drawing.Color.White;
			this.Unid_Med.Image = ((System.Drawing.Image)(resources.GetObject("Unid_Med.Image")));
			this.Unid_Med.Location = new System.Drawing.Point(442, 178);
			this.Unid_Med.Name = "Unid_Med";
			this.Unid_Med.Size = new System.Drawing.Size(85, 86);
			this.Unid_Med.TabIndex = 3;
			this.Unid_Med.UseVisualStyleBackColor = false;
			this.Unid_Med.Click += new System.EventHandler(this.Unid_MedClick);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label3.Location = new System.Drawing.Point(438, 261);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 40);
			this.label3.TabIndex = 19;
			this.label3.Text = "Adicionar Unidade de Medida";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(329, 267);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 19);
			this.label2.TabIndex = 17;
			this.label2.Text = "Adicionar Grupo";
			// 
			// Add_Grupo
			// 
			this.Add_Grupo.BackColor = System.Drawing.Color.Transparent;
			this.Add_Grupo.ForeColor = System.Drawing.Color.White;
			this.Add_Grupo.Image = ((System.Drawing.Image)(resources.GetObject("Add_Grupo.Image")));
			this.Add_Grupo.Location = new System.Drawing.Point(331, 178);
			this.Add_Grupo.Name = "Add_Grupo";
			this.Add_Grupo.Size = new System.Drawing.Size(85, 86);
			this.Add_Grupo.TabIndex = 2;
			this.Add_Grupo.UseVisualStyleBackColor = false;
			this.Add_Grupo.Click += new System.EventHandler(this.Add_GrupoClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(215, 267);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 19);
			this.label1.TabIndex = 15;
			this.label1.Text = "Cadastrar Produto";
			// 
			// Cad_Produto
			// 
			this.Cad_Produto.BackColor = System.Drawing.Color.Transparent;
			this.Cad_Produto.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Cad_Produto.Image = ((System.Drawing.Image)(resources.GetObject("Cad_Produto.Image")));
			this.Cad_Produto.Location = new System.Drawing.Point(219, 178);
			this.Cad_Produto.Name = "Cad_Produto";
			this.Cad_Produto.Size = new System.Drawing.Size(85, 86);
			this.Cad_Produto.TabIndex = 1;
			this.Cad_Produto.UseVisualStyleBackColor = false;
			this.Cad_Produto.Click += new System.EventHandler(this.Cad_ProdutoClick);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(674, 262);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 34);
			this.label5.TabIndex = 23;
			this.label5.Text = "Adicionar Fornecedor";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(62, 60);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(34, 33);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label6.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(96, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(307, 22);
			this.label6.TabIndex = 5;
			this.label6.Text = "/ Inicio Área de Cadastro";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(550, 396);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 19);
			this.label9.TabIndex = 29;
			this.label9.Text = "Excluir Cliente";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Esc_clt
			// 
			this.Esc_clt.BackColor = System.Drawing.Color.Transparent;
			this.Esc_clt.ForeColor = System.Drawing.Color.White;
			this.Esc_clt.Image = ((System.Drawing.Image)(resources.GetObject("Esc_clt.Image")));
			this.Esc_clt.Location = new System.Drawing.Point(554, 307);
			this.Esc_clt.Name = "Esc_clt";
			this.Esc_clt.Size = new System.Drawing.Size(85, 86);
			this.Esc_clt.TabIndex = 10;
			this.Esc_clt.UseVisualStyleBackColor = false;
			this.Esc_clt.Click += new System.EventHandler(this.Esc_cltClick);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(327, 396);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(96, 19);
			this.label10.TabIndex = 31;
			this.label10.Text = "Excluir Grupo";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Exc_Grupo
			// 
			this.Exc_Grupo.BackColor = System.Drawing.Color.Transparent;
			this.Exc_Grupo.ForeColor = System.Drawing.Color.White;
			this.Exc_Grupo.Image = ((System.Drawing.Image)(resources.GetObject("Exc_Grupo.Image")));
			this.Exc_Grupo.Location = new System.Drawing.Point(329, 307);
			this.Exc_Grupo.Name = "Exc_Grupo";
			this.Exc_Grupo.Size = new System.Drawing.Size(85, 86);
			this.Exc_Grupo.TabIndex = 8;
			this.Exc_Grupo.UseVisualStyleBackColor = false;
			this.Exc_Grupo.Click += new System.EventHandler(this.Exc_GrupoClick);
			// 
			// Exc_Unid
			// 
			this.Exc_Unid.BackColor = System.Drawing.Color.Transparent;
			this.Exc_Unid.ForeColor = System.Drawing.Color.White;
			this.Exc_Unid.Image = ((System.Drawing.Image)(resources.GetObject("Exc_Unid.Image")));
			this.Exc_Unid.Location = new System.Drawing.Point(442, 307);
			this.Exc_Unid.Name = "Exc_Unid";
			this.Exc_Unid.Size = new System.Drawing.Size(85, 86);
			this.Exc_Unid.TabIndex = 9;
			this.Exc_Unid.UseVisualStyleBackColor = false;
			this.Exc_Unid.Click += new System.EventHandler(this.Exc_UnidClick);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label11.Location = new System.Drawing.Point(439, 390);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(96, 40);
			this.label11.TabIndex = 33;
			this.label11.Text = "Excluir Unidade de Medida";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Exc_Fndr
			// 
			this.Exc_Fndr.BackColor = System.Drawing.Color.Transparent;
			this.Exc_Fndr.ForeColor = System.Drawing.Color.White;
			this.Exc_Fndr.Image = ((System.Drawing.Image)(resources.GetObject("Exc_Fndr.Image")));
			this.Exc_Fndr.Location = new System.Drawing.Point(666, 307);
			this.Exc_Fndr.Name = "Exc_Fndr";
			this.Exc_Fndr.Size = new System.Drawing.Size(85, 86);
			this.Exc_Fndr.TabIndex = 11;
			this.Exc_Fndr.UseVisualStyleBackColor = false;
			this.Exc_Fndr.Click += new System.EventHandler(this.Exc_FndrClick);
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(674, 391);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(73, 34);
			this.label12.TabIndex = 35;
			this.label12.Text = "Excluir Fornecedor";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(1052, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(20, 17);
			this.button1.TabIndex = 36;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(743, 24);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(347, 375);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 37;
			this.pictureBox2.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(753, 389);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(337, 11);
			this.panel1.TabIndex = 38;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(768, 396);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(96, 29);
			this.label13.TabIndex = 40;
			this.label13.Text = "Criar / Excluir Login";
			this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Configurações
			// 
			this.Configurações.BackColor = System.Drawing.Color.Transparent;
			this.Configurações.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Configurações.Image = ((System.Drawing.Image)(resources.GetObject("Configurações.Image")));
			this.Configurações.Location = new System.Drawing.Point(774, 307);
			this.Configurações.Name = "Configurações";
			this.Configurações.Size = new System.Drawing.Size(85, 86);
			this.Configurações.TabIndex = 12;
			this.Configurações.UseVisualStyleBackColor = false;
			this.Configurações.Click += new System.EventHandler(this.ConfiguraçõesClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.White;
			this.statusStrip1.Enabled = false;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.status,
									this.data});
			this.statusStrip1.Location = new System.Drawing.Point(0, 583);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1090, 22);
			this.statusStrip1.TabIndex = 42;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// status
			// 
			this.status.MergeIndex = 0;
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(0, 17);
			// 
			// data
			// 
			this.data.Name = "data";
			this.data.Size = new System.Drawing.Size(0, 17);
			// 
			// user_login
			// 
			this.user_login.Location = new System.Drawing.Point(5, 560);
			this.user_login.Name = "user_login";
			this.user_login.Size = new System.Drawing.Size(128, 20);
			this.user_login.TabIndex = 43;
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1090, 605);
			this.Controls.Add(this.user_login);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.Configurações);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Exc_Fndr);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.Exc_Unid);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.Exc_Grupo);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.Esc_clt);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Exc_Trans);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Excluir_Produto);
			this.Controls.Add(this.Add_Fornec);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Cadastrar);
			this.Controls.Add(this.Unid_Med);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Add_Grupo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Cad_Produto);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.pictureBox2);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Menu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu - Cadastros";
			this.Load += new System.EventHandler(this.MenuLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripStatusLabel data;
		private System.Windows.Forms.TextBox user_login;
		private System.Windows.Forms.ToolStripStatusLabel status;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem statisticaEstoqueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem transaçõesExcluídasToolStripMenuItem;
		private System.Windows.Forms.Button Configurações;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button Exc_Fndr;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button Exc_Unid;
		private System.Windows.Forms.Button Exc_Grupo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button Esc_clt;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.Button Exc_Trans;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button Excluir_Produto;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saídaDeMaterialToolStripMenuItem;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolStripMenuItem excluirTransaçãoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inserirEntredaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button Add_Fornec;
		private System.Windows.Forms.Button Cadastrar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Unid_Med;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Add_Grupo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Cad_Produto;
		

	}
}
