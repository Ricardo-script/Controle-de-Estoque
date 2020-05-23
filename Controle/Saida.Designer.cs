/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 25/07/2019
 * Time: 10:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Controle
{
	partial class Saida
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saida));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.Enviar = new System.Windows.Forms.Button();
			this.Cancelar = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.Barras = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Venda = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Custo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Nf = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Qtd = new System.Windows.Forms.TextBox();
			this.Unidade = new System.Windows.Forms.ComboBox();
			this.Produto = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.Hora = new System.Windows.Forms.TextBox();
			this.Inicio = new System.Windows.Forms.Button();
			this.Cadastro = new System.Windows.Forms.Button();
			this.Ent = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.Obs = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.razao = new System.Windows.Forms.ComboBox();
			this.Sair = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.Grupo = new System.Windows.Forms.ComboBox();
			this.qtde_estoque = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.fluxo = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Maximo = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.Minimo = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label17 = new System.Windows.Forms.Label();
			this.texto01 = new System.Windows.Forms.Label();
			this.texto02 = new System.Windows.Forms.Label();
			this.porcentagem = new System.Windows.Forms.Label();
			this.status = new System.Windows.Forms.Button();
			this.usuario = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(189, 757);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.pictureBox2.Location = new System.Drawing.Point(187, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(863, 31);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label12.Location = new System.Drawing.Point(401, 116);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(278, 33);
			this.label12.TabIndex = 29;
			this.label12.Text = "Saída de Mercadoria";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Enviar
			// 
			this.Enviar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Enviar.Location = new System.Drawing.Point(816, 479);
			this.Enviar.Name = "Enviar";
			this.Enviar.Size = new System.Drawing.Size(107, 26);
			this.Enviar.TabIndex = 15;
			this.Enviar.Text = "Expedir";
			this.Enviar.UseVisualStyleBackColor = true;
			this.Enviar.Click += new System.EventHandler(this.EnviarClick);
			// 
			// Cancelar
			// 
			this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Cancelar.Location = new System.Drawing.Point(690, 479);
			this.Cancelar.Name = "Cancelar";
			this.Cancelar.Size = new System.Drawing.Size(107, 26);
			this.Cancelar.TabIndex = 16;
			this.Cancelar.Text = "Limpar";
			this.Cancelar.UseVisualStyleBackColor = true;
			this.Cancelar.Click += new System.EventHandler(this.CancelarClick);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(234, 152);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(180, 18);
			this.label11.TabIndex = 52;
			this.label11.Text = "Código de Barras:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Barras
			// 
			this.Barras.BackColor = System.Drawing.Color.White;
			this.Barras.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Barras.Location = new System.Drawing.Point(236, 173);
			this.Barras.Name = "Barras";
			this.Barras.Size = new System.Drawing.Size(412, 20);
			this.Barras.TabIndex = 1;
			this.Barras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarrasKeyPress);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(456, 287);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 18);
			this.label10.TabIndex = 51;
			this.label10.Text = "Unidade/Medida:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(829, 243);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 18);
			this.label7.TabIndex = 50;
			this.label7.Text = "Venda:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Venda
			// 
			this.Venda.BackColor = System.Drawing.Color.White;
			this.Venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Venda.Location = new System.Drawing.Point(829, 264);
			this.Venda.Name = "Venda";
			this.Venda.Size = new System.Drawing.Size(155, 20);
			this.Venda.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(668, 243);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 18);
			this.label6.TabIndex = 49;
			this.label6.Text = "Custo:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Custo
			// 
			this.Custo.BackColor = System.Drawing.Color.White;
			this.Custo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Custo.Location = new System.Drawing.Point(668, 264);
			this.Custo.Name = "Custo";
			this.Custo.Size = new System.Drawing.Size(147, 20);
			this.Custo.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(456, 336);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 18);
			this.label5.TabIndex = 48;
			this.label5.Text = "Número de NF:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Nf
			// 
			this.Nf.BackColor = System.Drawing.Color.White;
			this.Nf.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Nf.Location = new System.Drawing.Point(456, 357);
			this.Nf.Name = "Nf";
			this.Nf.Size = new System.Drawing.Size(192, 20);
			this.Nf.TabIndex = 7;
			this.Nf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NfKeyPress);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(234, 336);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 18);
			this.label4.TabIndex = 47;
			this.label4.Text = "Quantidade Expedida";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Qtd
			// 
			this.Qtd.BackColor = System.Drawing.Color.White;
			this.Qtd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Qtd.Location = new System.Drawing.Point(234, 357);
			this.Qtd.Name = "Qtd";
			this.Qtd.Size = new System.Drawing.Size(213, 20);
			this.Qtd.TabIndex = 6;
			this.Qtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtdKeyPress);
			// 
			// Unidade
			// 
			this.Unidade.BackColor = System.Drawing.Color.White;
			this.Unidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Unidade.FormattingEnabled = true;
			this.Unidade.Location = new System.Drawing.Point(456, 308);
			this.Unidade.Name = "Unidade";
			this.Unidade.Size = new System.Drawing.Size(189, 21);
			this.Unidade.TabIndex = 5;
			// 
			// Produto
			// 
			this.Produto.BackColor = System.Drawing.Color.White;
			this.Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Produto.FormattingEnabled = true;
			this.Produto.Location = new System.Drawing.Point(234, 217);
			this.Produto.Name = "Produto";
			this.Produto.Size = new System.Drawing.Size(414, 21);
			this.Produto.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(235, 196);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 18);
			this.label1.TabIndex = 38;
			this.label1.Text = "Produto:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(668, 196);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(94, 18);
			this.label13.TabIndex = 54;
			this.label13.Text = "Data/Hora:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Hora
			// 
			this.Hora.BackColor = System.Drawing.Color.White;
			this.Hora.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Hora.Location = new System.Drawing.Point(668, 217);
			this.Hora.Name = "Hora";
			this.Hora.Size = new System.Drawing.Size(147, 20);
			this.Hora.TabIndex = 9;
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
			this.Inicio.Location = new System.Drawing.Point(12, 90);
			this.Inicio.Name = "Inicio";
			this.Inicio.Size = new System.Drawing.Size(166, 25);
			this.Inicio.TabIndex = 55;
			this.Inicio.Text = "Inicio";
			this.Inicio.UseVisualStyleBackColor = false;
			this.Inicio.Click += new System.EventHandler(this.InicioClick);
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
			this.Cadastro.Location = new System.Drawing.Point(12, 121);
			this.Cadastro.Name = "Cadastro";
			this.Cadastro.Size = new System.Drawing.Size(166, 25);
			this.Cadastro.TabIndex = 56;
			this.Cadastro.Text = "Cadastro de Produto";
			this.Cadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Cadastro.UseVisualStyleBackColor = false;
			this.Cadastro.Click += new System.EventHandler(this.CadastroClick);
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
			this.Ent.Location = new System.Drawing.Point(12, 152);
			this.Ent.Name = "Ent";
			this.Ent.Size = new System.Drawing.Size(166, 25);
			this.Ent.TabIndex = 57;
			this.Ent.Text = "  Entrada de Mercadoria";
			this.Ent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Ent.UseVisualStyleBackColor = false;
			this.Ent.Click += new System.EventHandler(this.EntClick);
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
			this.button1.Location = new System.Drawing.Point(12, 183);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 25);
			this.button1.TabIndex = 62;
			this.button1.Text = "  Controle de Estoque";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Obs
			// 
			this.Obs.BackColor = System.Drawing.Color.White;
			this.Obs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Obs.Location = new System.Drawing.Point(235, 403);
			this.Obs.Multiline = true;
			this.Obs.Name = "Obs";
			this.Obs.Size = new System.Drawing.Size(411, 102);
			this.Obs.TabIndex = 14;
			this.Obs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ObsKeyPress);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(234, 384);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 16);
			this.label3.TabIndex = 64;
			this.label3.Text = "Observações:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(235, 239);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(79, 18);
			this.label15.TabIndex = 65;
			this.label15.Text = "Destinatário:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// razao
			// 
			this.razao.BackColor = System.Drawing.Color.White;
			this.razao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.razao.FormattingEnabled = true;
			this.razao.Location = new System.Drawing.Point(234, 260);
			this.razao.Name = "razao";
			this.razao.Size = new System.Drawing.Size(414, 22);
			this.razao.TabIndex = 4;
			this.razao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RazaoKeyPress);
			this.razao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RazaoMouseClick);
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
			this.Sair.Location = new System.Drawing.Point(12, 245);
			this.Sair.Name = "Sair";
			this.Sair.Size = new System.Drawing.Size(166, 25);
			this.Sair.TabIndex = 67;
			this.Sair.Text = "Sair";
			this.Sair.UseVisualStyleBackColor = false;
			this.Sair.Click += new System.EventHandler(this.SairClick);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(234, 286);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 18);
			this.label8.TabIndex = 69;
			this.label8.Text = "Grupo:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Grupo
			// 
			this.Grupo.BackColor = System.Drawing.Color.White;
			this.Grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Grupo.FormattingEnabled = true;
			this.Grupo.Location = new System.Drawing.Point(234, 307);
			this.Grupo.Name = "Grupo";
			this.Grupo.Size = new System.Drawing.Size(213, 21);
			this.Grupo.TabIndex = 8;
			// 
			// qtde_estoque
			// 
			this.qtde_estoque.BackColor = System.Drawing.Color.White;
			this.qtde_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.qtde_estoque.Location = new System.Drawing.Point(829, 217);
			this.qtde_estoque.Name = "qtde_estoque";
			this.qtde_estoque.Size = new System.Drawing.Size(155, 20);
			this.qtde_estoque.TabIndex = 12;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(829, 196);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(142, 18);
			this.label9.TabIndex = 50;
			this.label9.Text = "Disponível em estoque:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(236, 54);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(128, 76);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 70;
			this.pictureBox3.TabStop = false;
			// 
			// fluxo
			// 
			this.fluxo.BackColor = System.Drawing.Color.White;
			this.fluxo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fluxo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(255)))));
			this.fluxo.FormattingEnabled = true;
			this.fluxo.Items.AddRange(new object[] {
									"Venda",
									"Devolução",
									"Perda",
									"Avaria"});
			this.fluxo.Location = new System.Drawing.Point(668, 172);
			this.fluxo.Name = "fluxo";
			this.fluxo.Size = new System.Drawing.Size(316, 21);
			this.fluxo.TabIndex = 13;
			this.fluxo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FluxoKeyPress);
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(668, 151);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(95, 18);
			this.label14.TabIndex = 72;
			this.label14.Text = "Tipo de Saída:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(831, 293);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 17);
			this.label2.TabIndex = 93;
			this.label2.Text = "Estoque Máximo:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Maximo
			// 
			this.Maximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Maximo.Location = new System.Drawing.Point(831, 310);
			this.Maximo.Name = "Maximo";
			this.Maximo.Size = new System.Drawing.Size(153, 20);
			this.Maximo.TabIndex = 91;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(668, 293);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(112, 17);
			this.label16.TabIndex = 92;
			this.label16.Text = "Estoque Mínimo:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Minimo
			// 
			this.Minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Minimo.Location = new System.Drawing.Point(668, 310);
			this.Minimo.Name = "Minimo";
			this.Minimo.Size = new System.Drawing.Size(149, 20);
			this.Minimo.TabIndex = 90;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel2.Location = new System.Drawing.Point(18, 57);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(150, 2);
			this.panel2.TabIndex = 95;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.White;
			this.label17.Location = new System.Drawing.Point(30, 32);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(123, 22);
			this.label17.TabIndex = 94;
			this.label17.Text = "MENU";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// texto01
			// 
			this.texto01.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.texto01.ForeColor = System.Drawing.Color.White;
			this.texto01.Location = new System.Drawing.Point(690, 359);
			this.texto01.Name = "texto01";
			this.texto01.Size = new System.Drawing.Size(184, 20);
			this.texto01.TabIndex = 96;
			this.texto01.Text = "MARGEM DE LUCRO";
			// 
			// texto02
			// 
			this.texto02.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.texto02.ForeColor = System.Drawing.Color.White;
			this.texto02.Location = new System.Drawing.Point(742, 379);
			this.texto02.Name = "texto02";
			this.texto02.Size = new System.Drawing.Size(86, 20);
			this.texto02.TabIndex = 97;
			this.texto02.Text = "(APROXIMADA)";
			// 
			// porcentagem
			// 
			this.porcentagem.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.porcentagem.ForeColor = System.Drawing.Color.GreenYellow;
			this.porcentagem.Location = new System.Drawing.Point(834, 359);
			this.porcentagem.Name = "porcentagem";
			this.porcentagem.Size = new System.Drawing.Size(184, 53);
			this.porcentagem.TabIndex = 98;
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
			this.status.Location = new System.Drawing.Point(12, 214);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(166, 25);
			this.status.TabIndex = 99;
			this.status.Text = "Status Estoque";
			this.status.UseVisualStyleBackColor = false;
			this.status.Click += new System.EventHandler(this.StatusClick);
			// 
			// usuario
			// 
			this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usuario.Location = new System.Drawing.Point(831, 516);
			this.usuario.Name = "usuario";
			this.usuario.Size = new System.Drawing.Size(153, 20);
			this.usuario.TabIndex = 100;
			// 
			// Saida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(1040, 548);
			this.Controls.Add(this.usuario);
			this.Controls.Add(this.status);
			this.Controls.Add(this.porcentagem);
			this.Controls.Add(this.texto02);
			this.Controls.Add(this.texto01);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Maximo);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.Minimo);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.fluxo);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Grupo);
			this.Controls.Add(this.Sair);
			this.Controls.Add(this.razao);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Obs);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Ent);
			this.Controls.Add(this.Cadastro);
			this.Controls.Add(this.Inicio);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.Hora);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.Barras);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.qtde_estoque);
			this.Controls.Add(this.Venda);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Custo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Nf);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Qtd);
			this.Controls.Add(this.Unidade);
			this.Controls.Add(this.Produto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Enviar);
			this.Controls.Add(this.Cancelar);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Saida";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Saida de Material";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.SaidaLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox usuario;
		private System.Windows.Forms.Button status;
		private System.Windows.Forms.Label porcentagem;
		private System.Windows.Forms.Label texto02;
		private System.Windows.Forms.Label texto01;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox Minimo;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox Maximo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox razao;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox qtde_estoque;
		private System.Windows.Forms.ComboBox Grupo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button Sair;
		private System.Windows.Forms.ComboBox fluxo;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Obs;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Ent;
		private System.Windows.Forms.Button Cadastro;
		private System.Windows.Forms.Button Inicio;
		private System.Windows.Forms.TextBox Hora;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox Unidade;
		private System.Windows.Forms.TextBox Custo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Venda;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox Barras;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Produto;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Qtd;
		private System.Windows.Forms.TextBox Nf;
		private System.Windows.Forms.Button Cancelar;
		private System.Windows.Forms.Button Enviar;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		

	}
}
