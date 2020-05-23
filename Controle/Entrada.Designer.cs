/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 24/07/2019
 * Time: 09:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Controle
{
	partial class Dados
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dados));
			this.label1 = new System.Windows.Forms.Label();
			this.Fornecedor = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Qtd = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Nf = new System.Windows.Forms.TextBox();
			this.Custo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Venda = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.status = new System.Windows.Forms.Button();
			this.Sair = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.Ent = new System.Windows.Forms.Button();
			this.Cadastro = new System.Windows.Forms.Button();
			this.Inicio = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.Cancelar = new System.Windows.Forms.Button();
			this.Enviar = new System.Windows.Forms.Button();
			this.Barras = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.Hora = new System.Windows.Forms.TextBox();
			this.Obs = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.fluxo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Produto = new System.Windows.Forms.TextBox();
			this.Unidade = new System.Windows.Forms.TextBox();
			this.Grupo = new System.Windows.Forms.TextBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.Maximo = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.Minimo = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.qtde_estoque = new System.Windows.Forms.TextBox();
			this.usuario = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(245, 215);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Produto:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Fornecedor
			// 
			this.Fornecedor.BackColor = System.Drawing.Color.White;
			this.Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Fornecedor.FormattingEnabled = true;
			this.Fornecedor.Location = new System.Drawing.Point(244, 281);
			this.Fornecedor.Name = "Fornecedor";
			this.Fornecedor.Size = new System.Drawing.Size(427, 21);
			this.Fornecedor.TabIndex = 3;
			this.Fornecedor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FornecedorMouseClick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(247, 260);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Fornecedor:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(31, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "MENU";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Qtd
			// 
			this.Qtd.BackColor = System.Drawing.Color.White;
			this.Qtd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Qtd.Location = new System.Drawing.Point(246, 374);
			this.Qtd.Name = "Qtd";
			this.Qtd.Size = new System.Drawing.Size(221, 20);
			this.Qtd.TabIndex = 6;
			this.Qtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtdKeyPress);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(246, 353);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 18);
			this.label4.TabIndex = 8;
			this.label4.Text = "Quantidade de Entrada:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(493, 352);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "Número de NF:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Nf
			// 
			this.Nf.BackColor = System.Drawing.Color.White;
			this.Nf.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Nf.Location = new System.Drawing.Point(493, 373);
			this.Nf.Name = "Nf";
			this.Nf.Size = new System.Drawing.Size(178, 20);
			this.Nf.TabIndex = 7;
			this.Nf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NfKeyPress);
			// 
			// Custo
			// 
			this.Custo.BackColor = System.Drawing.Color.White;
			this.Custo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Custo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Custo.Location = new System.Drawing.Point(852, 327);
			this.Custo.Name = "Custo";
			this.Custo.Size = new System.Drawing.Size(155, 20);
			this.Custo.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(852, 307);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 18);
			this.label6.TabIndex = 12;
			this.label6.Text = "Custo:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(689, 307);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 18);
			this.label7.TabIndex = 14;
			this.label7.Text = "Venda:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Venda
			// 
			this.Venda.BackColor = System.Drawing.Color.White;
			this.Venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Venda.Location = new System.Drawing.Point(689, 327);
			this.Venda.Name = "Venda";
			this.Venda.Size = new System.Drawing.Size(149, 20);
			this.Venda.TabIndex = 12;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.panel1.Controls.Add(this.status);
			this.panel1.Controls.Add(this.Sair);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.Ent);
			this.panel1.Controls.Add(this.Cadastro);
			this.panel1.Controls.Add(this.Inicio);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(189, 698);
			this.panel1.TabIndex = 18;
			// 
			// status
			// 
			this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
			this.status.FlatAppearance.BorderSize = 0;
			this.status.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.status.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.status.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.status.ForeColor = System.Drawing.Color.White;
			this.status.Image = ((System.Drawing.Image)(resources.GetObject("status.Image")));
			this.status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.status.Location = new System.Drawing.Point(12, 213);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(166, 25);
			this.status.TabIndex = 100;
			this.status.Text = "Status Estoque";
			this.status.UseVisualStyleBackColor = false;
			this.status.Click += new System.EventHandler(this.StatusClick);
			// 
			// Sair
			// 
			this.Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
			this.Sair.FlatAppearance.BorderSize = 0;
			this.Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Sair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Sair.ForeColor = System.Drawing.Color.White;
			this.Sair.Image = ((System.Drawing.Image)(resources.GetObject("Sair.Image")));
			this.Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Sair.Location = new System.Drawing.Point(12, 244);
			this.Sair.Name = "Sair";
			this.Sair.Size = new System.Drawing.Size(166, 25);
			this.Sair.TabIndex = 68;
			this.Sair.Text = "Sair";
			this.Sair.UseVisualStyleBackColor = false;
			this.Sair.Click += new System.EventHandler(this.SairClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(12, 182);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 25);
			this.button1.TabIndex = 61;
			this.button1.Text = "  Controle de Estoque";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Ent
			// 
			this.Ent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
			this.Ent.FlatAppearance.BorderSize = 0;
			this.Ent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.Ent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Ent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Ent.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ent.ForeColor = System.Drawing.Color.White;
			this.Ent.Image = ((System.Drawing.Image)(resources.GetObject("Ent.Image")));
			this.Ent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Ent.Location = new System.Drawing.Point(12, 151);
			this.Ent.Name = "Ent";
			this.Ent.Size = new System.Drawing.Size(166, 25);
			this.Ent.TabIndex = 60;
			this.Ent.Text = "  Saída de Mercadoria";
			this.Ent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Ent.UseVisualStyleBackColor = false;
			this.Ent.Click += new System.EventHandler(this.EntClick);
			// 
			// Cadastro
			// 
			this.Cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
			this.Cadastro.FlatAppearance.BorderSize = 0;
			this.Cadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.Cadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cadastro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cadastro.ForeColor = System.Drawing.Color.White;
			this.Cadastro.Image = ((System.Drawing.Image)(resources.GetObject("Cadastro.Image")));
			this.Cadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Cadastro.Location = new System.Drawing.Point(12, 120);
			this.Cadastro.Name = "Cadastro";
			this.Cadastro.Size = new System.Drawing.Size(166, 25);
			this.Cadastro.TabIndex = 59;
			this.Cadastro.Text = "Cadastro de Produto";
			this.Cadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Cadastro.UseVisualStyleBackColor = false;
			this.Cadastro.Click += new System.EventHandler(this.CadastroClick);
			// 
			// Inicio
			// 
			this.Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
			this.Inicio.FlatAppearance.BorderSize = 0;
			this.Inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.Inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Inicio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Inicio.ForeColor = System.Drawing.Color.White;
			this.Inicio.Image = ((System.Drawing.Image)(resources.GetObject("Inicio.Image")));
			this.Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Inicio.Location = new System.Drawing.Point(12, 89);
			this.Inicio.Name = "Inicio";
			this.Inicio.Size = new System.Drawing.Size(166, 25);
			this.Inicio.TabIndex = 58;
			this.Inicio.Text = "Inicio";
			this.Inicio.UseVisualStyleBackColor = false;
			this.Inicio.Click += new System.EventHandler(this.InicioClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel2.Location = new System.Drawing.Point(19, 54);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(150, 2);
			this.panel2.TabIndex = 6;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(493, 305);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 18);
			this.label10.TabIndex = 19;
			this.label10.Text = "Unidade/Medida:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.pictureBox2.Location = new System.Drawing.Point(189, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(884, 31);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 20;
			this.pictureBox2.TabStop = false;
			// 
			// Cancelar
			// 
			this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Cancelar.Location = new System.Drawing.Point(710, 461);
			this.Cancelar.Name = "Cancelar";
			this.Cancelar.Size = new System.Drawing.Size(107, 26);
			this.Cancelar.TabIndex = 10;
			this.Cancelar.Text = "Cancelar";
			this.Cancelar.UseVisualStyleBackColor = true;
			this.Cancelar.Click += new System.EventHandler(this.CancelarClick);
			// 
			// Enviar
			// 
			this.Enviar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Enviar.Location = new System.Drawing.Point(847, 461);
			this.Enviar.Name = "Enviar";
			this.Enviar.Size = new System.Drawing.Size(107, 26);
			this.Enviar.TabIndex = 9;
			this.Enviar.Text = "Enviar";
			this.Enviar.UseVisualStyleBackColor = true;
			this.Enviar.Click += new System.EventHandler(this.EnviarClick);
			// 
			// Barras
			// 
			this.Barras.BackColor = System.Drawing.Color.White;
			this.Barras.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Barras.Location = new System.Drawing.Point(244, 192);
			this.Barras.Name = "Barras";
			this.Barras.Size = new System.Drawing.Size(427, 20);
			this.Barras.TabIndex = 1;
			this.Barras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarrasKeyPress);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(244, 171);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(180, 18);
			this.label11.TabIndex = 22;
			this.label11.Text = "Código de Barras:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label12.Location = new System.Drawing.Point(393, 127);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(278, 33);
			this.label12.TabIndex = 7;
			this.label12.Text = "Entrada de Mercadoria";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(689, 261);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(94, 18);
			this.label13.TabIndex = 27;
			this.label13.Text = "Data/Hora:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Hora
			// 
			this.Hora.BackColor = System.Drawing.Color.White;
			this.Hora.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Hora.Location = new System.Drawing.Point(689, 281);
			this.Hora.Name = "Hora";
			this.Hora.Size = new System.Drawing.Size(155, 20);
			this.Hora.TabIndex = 10;
			// 
			// Obs
			// 
			this.Obs.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Obs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Obs.Location = new System.Drawing.Point(246, 422);
			this.Obs.Multiline = true;
			this.Obs.Name = "Obs";
			this.Obs.Size = new System.Drawing.Size(425, 65);
			this.Obs.TabIndex = 8;
			this.Obs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ObsKeyPress);
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(246, 401);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(124, 18);
			this.label14.TabIndex = 29;
			this.label14.Text = "Observações:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// fluxo
			// 
			this.fluxo.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fluxo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fluxo.Location = new System.Drawing.Point(704, 192);
			this.fluxo.Name = "fluxo";
			this.fluxo.Size = new System.Drawing.Size(128, 20);
			this.fluxo.TabIndex = 31;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(245, 304);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 18);
			this.label8.TabIndex = 33;
			this.label8.Text = "Grupo:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Produto
			// 
			this.Produto.BackColor = System.Drawing.Color.White;
			this.Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Produto.Location = new System.Drawing.Point(244, 236);
			this.Produto.Name = "Produto";
			this.Produto.Size = new System.Drawing.Size(427, 20);
			this.Produto.TabIndex = 34;
			// 
			// Unidade
			// 
			this.Unidade.BackColor = System.Drawing.Color.White;
			this.Unidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Unidade.Location = new System.Drawing.Point(493, 327);
			this.Unidade.Name = "Unidade";
			this.Unidade.Size = new System.Drawing.Size(178, 20);
			this.Unidade.TabIndex = 35;
			// 
			// Grupo
			// 
			this.Grupo.BackColor = System.Drawing.Color.White;
			this.Grupo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Grupo.Location = new System.Drawing.Point(245, 327);
			this.Grupo.Name = "Grupo";
			this.Grupo.Size = new System.Drawing.Size(222, 20);
			this.Grupo.TabIndex = 36;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(242, 55);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(128, 76);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 37;
			this.pictureBox3.TabStop = false;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(852, 356);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(106, 17);
			this.label9.TabIndex = 97;
			this.label9.Text = "Estoque Máximo:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Maximo
			// 
			this.Maximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Maximo.Location = new System.Drawing.Point(852, 373);
			this.Maximo.Name = "Maximo";
			this.Maximo.Size = new System.Drawing.Size(153, 20);
			this.Maximo.TabIndex = 95;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(689, 356);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(112, 17);
			this.label16.TabIndex = 96;
			this.label16.Text = "Estoque Mínimo:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Minimo
			// 
			this.Minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Minimo.Location = new System.Drawing.Point(689, 373);
			this.Minimo.Name = "Minimo";
			this.Minimo.Size = new System.Drawing.Size(149, 20);
			this.Minimo.TabIndex = 94;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(852, 260);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(142, 18);
			this.label15.TabIndex = 99;
			this.label15.Text = "Disponível em estoque:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// qtde_estoque
			// 
			this.qtde_estoque.BackColor = System.Drawing.Color.White;
			this.qtde_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.qtde_estoque.Location = new System.Drawing.Point(852, 281);
			this.qtde_estoque.Name = "qtde_estoque";
			this.qtde_estoque.Size = new System.Drawing.Size(155, 20);
			this.qtde_estoque.TabIndex = 98;
			// 
			// usuario
			// 
			this.usuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usuario.Location = new System.Drawing.Point(852, 192);
			this.usuario.Name = "usuario";
			this.usuario.Size = new System.Drawing.Size(128, 20);
			this.usuario.TabIndex = 100;
			// 
			// Dados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(1073, 696);
			this.Controls.Add(this.usuario);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.qtde_estoque);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.Maximo);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.Minimo);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.Grupo);
			this.Controls.Add(this.Unidade);
			this.Controls.Add(this.Produto);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.fluxo);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.Obs);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.Hora);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.Barras);
			this.Controls.Add(this.Enviar);
			this.Controls.Add(this.Cancelar);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Venda);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Custo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Nf);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Qtd);
			this.Controls.Add(this.Fornecedor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.Teal;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Dados";
			this.Text = "Entrada de Material";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.DadosLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox usuario;
		private System.Windows.Forms.Button status;
		private System.Windows.Forms.TextBox qtde_estoque;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox Minimo;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox Maximo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox Grupo;
		private System.Windows.Forms.Button Sair;
		private System.Windows.Forms.TextBox fluxo;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox Obs;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Inicio;
		private System.Windows.Forms.Button Cadastro;
		private System.Windows.Forms.Button Ent;
		private System.Windows.Forms.TextBox Hora;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox Barras;
		private System.Windows.Forms.Button Enviar;
		private System.Windows.Forms.Button Cancelar;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox Venda;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Custo;
		private System.Windows.Forms.TextBox Nf;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Qtd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Unidade;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox Fornecedor;
		private System.Windows.Forms.TextBox Produto;
		private System.Windows.Forms.Label label1;
		
		
	}
}
