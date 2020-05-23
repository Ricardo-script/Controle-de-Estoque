/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 23/07/2019
 * Time: 15:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Controle
{
	partial class Controle_Stq
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controle_Stq));
			this.Tela = new System.Windows.Forms.DataGridView();
			this.Gerar = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Total = new System.Windows.Forms.TextBox();
			this.Exportar = new System.Windows.Forms.Button();
			this.Sair = new System.Windows.Forms.Button();
			this.Excl = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.Psq_NF = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Pesq_Produto = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.inicio = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.fim = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.t_custo = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.devolucao = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.saida = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.perda = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.avaria = new System.Windows.Forms.TextBox();
			this.user_login = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.User = new System.Windows.Forms.ToolStripStatusLabel();
			this.data = new System.Windows.Forms.ToolStripStatusLabel();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.t_entradas = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.t_saidas = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.t_perdas = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.t_ava = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.t_dev = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.Tela)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Tela
			// 
			this.Tela.AllowUserToAddRows = false;
			this.Tela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.Tela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle1.NullValue = null;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Tela.DefaultCellStyle = dataGridViewCellStyle1;
			this.Tela.Location = new System.Drawing.Point(36, 166);
			this.Tela.Name = "Tela";
			this.Tela.Size = new System.Drawing.Size(1148, 353);
			this.Tela.TabIndex = 0;
			// 
			// Gerar
			// 
			this.Gerar.Image = ((System.Drawing.Image)(resources.GetObject("Gerar.Image")));
			this.Gerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Gerar.Location = new System.Drawing.Point(727, 130);
			this.Gerar.Name = "Gerar";
			this.Gerar.Size = new System.Drawing.Size(87, 29);
			this.Gerar.TabIndex = 1;
			this.Gerar.Text = "       Pesquisar";
			this.Gerar.UseVisualStyleBackColor = true;
			this.Gerar.Click += new System.EventHandler(this.GerarClick);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(30, 34);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(206, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(30, 13);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(217, 18);
			this.label11.TabIndex = 23;
			this.label11.Text = "Pesquisar por Código de Barras:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label1.Location = new System.Drawing.Point(1193, 526);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 20);
			this.label1.TabIndex = 25;
			this.label1.Text = "TOTAL";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Total
			// 
			this.Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Total.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.Total.Location = new System.Drawing.Point(948, 525);
			this.Total.Multiline = true;
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(321, 42);
			this.Total.TabIndex = 24;
			// 
			// Exportar
			// 
			this.Exportar.Image = ((System.Drawing.Image)(resources.GetObject("Exportar.Image")));
			this.Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Exportar.Location = new System.Drawing.Point(951, 95);
			this.Exportar.Name = "Exportar";
			this.Exportar.Size = new System.Drawing.Size(87, 29);
			this.Exportar.TabIndex = 26;
			this.Exportar.Text = "       Exportar";
			this.Exportar.UseVisualStyleBackColor = true;
			this.Exportar.Click += new System.EventHandler(this.ExportarClick);
			// 
			// Sair
			// 
			this.Sair.Image = ((System.Drawing.Image)(resources.GetObject("Sair.Image")));
			this.Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Sair.Location = new System.Drawing.Point(1044, 130);
			this.Sair.Name = "Sair";
			this.Sair.Size = new System.Drawing.Size(87, 29);
			this.Sair.TabIndex = 27;
			this.Sair.Text = "       Sair";
			this.Sair.UseVisualStyleBackColor = true;
			this.Sair.Click += new System.EventHandler(this.SairClick);
			// 
			// Excl
			// 
			this.Excl.Image = ((System.Drawing.Image)(resources.GetObject("Excl.Image")));
			this.Excl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Excl.Location = new System.Drawing.Point(1044, 95);
			this.Excl.Name = "Excl";
			this.Excl.Size = new System.Drawing.Size(87, 29);
			this.Excl.TabIndex = 28;
			this.Excl.Text = "        Estoque";
			this.Excl.UseVisualStyleBackColor = true;
			this.Excl.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(858, 130);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(87, 29);
			this.button2.TabIndex = 29;
			this.button2.Text = "       Entrada";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(951, 130);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(87, 29);
			this.button3.TabIndex = 30;
			this.button3.Text = "          Expedir";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// Psq_NF
			// 
			this.Psq_NF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Psq_NF.Location = new System.Drawing.Point(30, 78);
			this.Psq_NF.Name = "Psq_NF";
			this.Psq_NF.Size = new System.Drawing.Size(206, 20);
			this.Psq_NF.TabIndex = 31;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(30, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(217, 18);
			this.label2.TabIndex = 32;
			this.label2.Text = "Pesquisar por Nota Fiscal:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.Pesq_Produto);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.Psq_NF);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(36, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(543, 108);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pesquisa";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(265, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(217, 18);
			this.label4.TabIndex = 37;
			this.label4.Text = "Pesquisar por Produto:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Pesq_Produto
			// 
			this.Pesq_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pesq_Produto.Location = new System.Drawing.Point(265, 78);
			this.Pesq_Produto.Name = "Pesq_Produto";
			this.Pesq_Produto.Size = new System.Drawing.Size(206, 20);
			this.Pesq_Produto.TabIndex = 36;
			this.Pesq_Produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pesq_ProdutoKeyPress);
			// 
			// button4
			// 
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(858, 95);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(87, 29);
			this.button4.TabIndex = 34;
			this.button4.Text = "     Excluir";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label3.Location = new System.Drawing.Point(1193, 544);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 21);
			this.label3.TabIndex = 35;
			this.label3.Text = "EM ESTOQUE";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(18, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 18);
			this.label5.TabIndex = 39;
			this.label5.Text = "Data Ínicial:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// inicio
			// 
			this.inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inicio.Location = new System.Drawing.Point(18, 36);
			this.inicio.Name = "inicio";
			this.inicio.Size = new System.Drawing.Size(97, 20);
			this.inicio.TabIndex = 38;
			this.inicio.Click += new System.EventHandler(this.InicioClick);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(18, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 18);
			this.label6.TabIndex = 41;
			this.label6.Text = "Data Final:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// fim
			// 
			this.fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fim.Location = new System.Drawing.Point(18, 80);
			this.fim.Name = "fim";
			this.fim.Size = new System.Drawing.Size(97, 20);
			this.fim.TabIndex = 40;
			this.fim.Click += new System.EventHandler(this.FimClick);
			this.fim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FimKeyPress);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.fim);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.inicio);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(589, 52);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(132, 108);
			this.groupBox2.TabIndex = 42;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Pesquisar Datas";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label7.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(71, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(307, 22);
			this.label7.TabIndex = 44;
			this.label7.Text = "/ Controle de Movimentações";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel2.Location = new System.Drawing.Point(37, 38);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(970, 2);
			this.panel2.TabIndex = 43;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(37, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(31, 31);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 45;
			this.pictureBox1.TabStop = false;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label8.Location = new System.Drawing.Point(1195, 592);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 21);
			this.label8.TabIndex = 48;
			this.label8.Text = "ENTRADAS";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label9.Location = new System.Drawing.Point(1194, 576);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 18);
			this.label9.TabIndex = 47;
			this.label9.Text = "TOTAL";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// t_custo
			// 
			this.t_custo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.t_custo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.t_custo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t_custo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.t_custo.Location = new System.Drawing.Point(948, 573);
			this.t_custo.Multiline = true;
			this.t_custo.Name = "t_custo";
			this.t_custo.Size = new System.Drawing.Size(321, 42);
			this.t_custo.TabIndex = 46;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label13.Location = new System.Drawing.Point(850, 644);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(84, 15);
			this.label13.TabIndex = 60;
			this.label13.Text = "DEVOLUÇÕES";
			this.label13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label14.Location = new System.Drawing.Point(857, 625);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(49, 15);
			this.label14.TabIndex = 59;
			this.label14.Text = "TOTAL";
			this.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// devolucao
			// 
			this.devolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.devolucao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.devolucao.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.devolucao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.devolucao.Location = new System.Drawing.Point(615, 621);
			this.devolucao.Multiline = true;
			this.devolucao.Name = "devolucao";
			this.devolucao.Size = new System.Drawing.Size(320, 42);
			this.devolucao.TabIndex = 58;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label15.Location = new System.Drawing.Point(1195, 640);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(65, 21);
			this.label15.TabIndex = 57;
			this.label15.Text = "DE SAÍDAS";
			this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label16.Location = new System.Drawing.Point(1196, 624);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(49, 18);
			this.label16.TabIndex = 56;
			this.label16.Text = "TOTAL";
			this.label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// saida
			// 
			this.saida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.saida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.saida.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.saida.Location = new System.Drawing.Point(948, 621);
			this.saida.Multiline = true;
			this.saida.Name = "saida";
			this.saida.Size = new System.Drawing.Size(321, 42);
			this.saida.TabIndex = 55;
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label19.Location = new System.Drawing.Point(858, 544);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(65, 21);
			this.label19.TabIndex = 66;
			this.label19.Text = "DE PERDAS";
			this.label19.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label20.Location = new System.Drawing.Point(859, 528);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(49, 18);
			this.label20.TabIndex = 65;
			this.label20.Text = "TOTAL";
			this.label20.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// perda
			// 
			this.perda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.perda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.perda.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.perda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.perda.Location = new System.Drawing.Point(615, 525);
			this.perda.Multiline = true;
			this.perda.Name = "perda";
			this.perda.Size = new System.Drawing.Size(321, 42);
			this.perda.TabIndex = 64;
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label21.Location = new System.Drawing.Point(857, 592);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(69, 21);
			this.label21.TabIndex = 63;
			this.label21.Text = "DE AVARIAS";
			this.label21.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label22.Location = new System.Drawing.Point(857, 575);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(45, 20);
			this.label22.TabIndex = 62;
			this.label22.Text = "TOTAL";
			this.label22.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// avaria
			// 
			this.avaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.avaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.avaria.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.avaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.avaria.Location = new System.Drawing.Point(615, 573);
			this.avaria.Multiline = true;
			this.avaria.Name = "avaria";
			this.avaria.Size = new System.Drawing.Size(321, 42);
			this.avaria.TabIndex = 61;
			// 
			// user_login
			// 
			this.user_login.Location = new System.Drawing.Point(2, 639);
			this.user_login.Name = "user_login";
			this.user_login.Size = new System.Drawing.Size(128, 20);
			this.user_login.TabIndex = 67;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Enabled = false;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.User,
									this.data});
			this.statusStrip1.Location = new System.Drawing.Point(0, 667);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1224, 22);
			this.statusStrip1.Stretch = false;
			this.statusStrip1.TabIndex = 68;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// User
			// 
			this.User.BackColor = System.Drawing.Color.White;
			this.User.Name = "User";
			this.User.Size = new System.Drawing.Size(0, 17);
			// 
			// data
			// 
			this.data.BackColor = System.Drawing.Color.White;
			this.data.Name = "data";
			this.data.Size = new System.Drawing.Size(0, 17);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label10.Location = new System.Drawing.Point(524, 544);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(84, 21);
			this.label10.TabIndex = 71;
			this.label10.Text = "DE ENTRADAS";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label12.Location = new System.Drawing.Point(524, 526);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(45, 20);
			this.label12.TabIndex = 70;
			this.label12.Text = "TOTAL";
			this.label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// t_entradas
			// 
			this.t_entradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.t_entradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.t_entradas.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t_entradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.t_entradas.Location = new System.Drawing.Point(380, 525);
			this.t_entradas.Multiline = true;
			this.t_entradas.Name = "t_entradas";
			this.t_entradas.Size = new System.Drawing.Size(229, 42);
			this.t_entradas.TabIndex = 69;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label17.Location = new System.Drawing.Point(524, 592);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(84, 21);
			this.label17.TabIndex = 74;
			this.label17.Text = "DE SAÍDAS";
			this.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label18.Location = new System.Drawing.Point(524, 574);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(45, 20);
			this.label18.TabIndex = 73;
			this.label18.Text = "TOTAL";
			this.label18.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// t_saidas
			// 
			this.t_saidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.t_saidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.t_saidas.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t_saidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.t_saidas.Location = new System.Drawing.Point(380, 573);
			this.t_saidas.Multiline = true;
			this.t_saidas.Name = "t_saidas";
			this.t_saidas.Size = new System.Drawing.Size(229, 42);
			this.t_saidas.TabIndex = 72;
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label23.Location = new System.Drawing.Point(524, 640);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(84, 21);
			this.label23.TabIndex = 77;
			this.label23.Text = "DE PERDAS";
			this.label23.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label24.Location = new System.Drawing.Point(524, 622);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(45, 20);
			this.label24.TabIndex = 76;
			this.label24.Text = "TOTAL";
			this.label24.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// t_perdas
			// 
			this.t_perdas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.t_perdas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.t_perdas.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t_perdas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.t_perdas.Location = new System.Drawing.Point(380, 621);
			this.t_perdas.Multiline = true;
			this.t_perdas.Name = "t_perdas";
			this.t_perdas.Size = new System.Drawing.Size(229, 42);
			this.t_perdas.TabIndex = 75;
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label27.Location = new System.Drawing.Point(290, 640);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(80, 21);
			this.label27.TabIndex = 83;
			this.label27.Text = "DE AVARIAS";
			this.label27.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label28.Location = new System.Drawing.Point(290, 622);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(45, 20);
			this.label28.TabIndex = 82;
			this.label28.Text = "TOTAL";
			this.label28.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// t_ava
			// 
			this.t_ava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.t_ava.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.t_ava.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t_ava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.t_ava.Location = new System.Drawing.Point(145, 621);
			this.t_ava.Multiline = true;
			this.t_ava.Name = "t_ava";
			this.t_ava.Size = new System.Drawing.Size(229, 42);
			this.t_ava.TabIndex = 81;
			// 
			// label29
			// 
			this.label29.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label29.Location = new System.Drawing.Point(290, 592);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(79, 21);
			this.label29.TabIndex = 80;
			this.label29.Text = "DEVOLUÇÕES";
			this.label29.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label30
			// 
			this.label30.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label30.Location = new System.Drawing.Point(290, 574);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(45, 20);
			this.label30.TabIndex = 79;
			this.label30.Text = "TOTAL";
			this.label30.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// t_dev
			// 
			this.t_dev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.t_dev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.t_dev.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t_dev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.t_dev.Location = new System.Drawing.Point(145, 573);
			this.t_dev.Multiline = true;
			this.t_dev.Name = "t_dev";
			this.t_dev.Size = new System.Drawing.Size(229, 42);
			this.t_dev.TabIndex = 78;
			// 
			// Controle_Stq
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(1224, 689);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.label28);
			this.Controls.Add(this.t_ava);
			this.Controls.Add(this.label29);
			this.Controls.Add(this.label30);
			this.Controls.Add(this.t_dev);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.t_perdas);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.t_saidas);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.t_entradas);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.user_login);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.perda);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.avaria);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.devolucao);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.saida);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.t_custo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Excl);
			this.Controls.Add(this.Sair);
			this.Controls.Add(this.Exportar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Total);
			this.Controls.Add(this.Gerar);
			this.Controls.Add(this.Tela);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Controle_Stq";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Controle de Movimentações";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Controle_StqLoad);
			((System.ComponentModel.ISupportInitialize)(this.Tela)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox t_dev;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TextBox t_ava;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox t_perdas;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox t_saidas;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox t_entradas;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ToolStripStatusLabel data;
		private System.Windows.Forms.ToolStripStatusLabel User;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TextBox user_login;
		private System.Windows.Forms.TextBox avaria;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox perda;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox saida;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox devolucao;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox t_custo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox fim;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox inicio;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Pesq_Produto;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Psq_NF;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button Excl;
		private System.Windows.Forms.Button Sair;
		private System.Windows.Forms.Button Exportar;
		private System.Windows.Forms.TextBox Total;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button Gerar;
		private System.Windows.Forms.DataGridView Tela;

	}
}
