/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 26/07/2019
 * Time: 11:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Controle
{
	partial class Exc_Tsç
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exc_Tsç));
			this.Transação = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.Hora = new System.Windows.Forms.TextBox();
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
			this.Fornecedor = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Produto = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Excluir = new System.Windows.Forms.Button();
			this.Cancelar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.fluxo = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.Obs = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.Motivo = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.Grupo = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.usuário = new System.Windows.Forms.TextBox();
			this.usuario_exc = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// Transação
			// 
			this.Transação.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Transação.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Transação.Location = new System.Drawing.Point(71, 101);
			this.Transação.Name = "Transação";
			this.Transação.Size = new System.Drawing.Size(202, 20);
			this.Transação.TabIndex = 1;
			this.Transação.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransaçãoKeyPress);
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(493, 127);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(94, 18);
			this.label13.TabIndex = 45;
			this.label13.Text = "Data/Hora:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Hora
			// 
			this.Hora.BackColor = System.Drawing.Color.White;
			this.Hora.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Hora.Location = new System.Drawing.Point(493, 148);
			this.Hora.Name = "Hora";
			this.Hora.Size = new System.Drawing.Size(191, 20);
			this.Hora.TabIndex = 6;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(77, 128);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(180, 18);
			this.label11.TabIndex = 43;
			this.label11.Text = "Código de Barras:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Barras
			// 
			this.Barras.BackColor = System.Drawing.Color.White;
			this.Barras.Location = new System.Drawing.Point(72, 149);
			this.Barras.Name = "Barras";
			this.Barras.Size = new System.Drawing.Size(395, 20);
			this.Barras.TabIndex = 3;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(285, 260);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 18);
			this.label10.TabIndex = 42;
			this.label10.Text = "Unidade/Medida:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(493, 215);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 18);
			this.label7.TabIndex = 41;
			this.label7.Text = "Venda:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Venda
			// 
			this.Venda.BackColor = System.Drawing.Color.White;
			this.Venda.Location = new System.Drawing.Point(493, 235);
			this.Venda.Name = "Venda";
			this.Venda.Size = new System.Drawing.Size(191, 20);
			this.Venda.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(493, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 18);
			this.label6.TabIndex = 40;
			this.label6.Text = "Custo:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Custo
			// 
			this.Custo.BackColor = System.Drawing.Color.White;
			this.Custo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Custo.Location = new System.Drawing.Point(493, 192);
			this.Custo.Name = "Custo";
			this.Custo.Size = new System.Drawing.Size(191, 20);
			this.Custo.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(285, 304);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 18);
			this.label5.TabIndex = 39;
			this.label5.Text = "Número de NF:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Nf
			// 
			this.Nf.BackColor = System.Drawing.Color.White;
			this.Nf.Location = new System.Drawing.Point(279, 325);
			this.Nf.Name = "Nf";
			this.Nf.Size = new System.Drawing.Size(188, 20);
			this.Nf.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(77, 304);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 18);
			this.label4.TabIndex = 37;
			this.label4.Text = "Quantidade de Entrada:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Qtd
			// 
			this.Qtd.BackColor = System.Drawing.Color.White;
			this.Qtd.Location = new System.Drawing.Point(72, 325);
			this.Qtd.Name = "Qtd";
			this.Qtd.Size = new System.Drawing.Size(201, 20);
			this.Qtd.TabIndex = 10;
			// 
			// Unidade
			// 
			this.Unidade.BackColor = System.Drawing.Color.White;
			this.Unidade.FormattingEnabled = true;
			this.Unidade.Location = new System.Drawing.Point(280, 279);
			this.Unidade.Name = "Unidade";
			this.Unidade.Size = new System.Drawing.Size(187, 21);
			this.Unidade.TabIndex = 8;
			// 
			// Fornecedor
			// 
			this.Fornecedor.BackColor = System.Drawing.Color.White;
			this.Fornecedor.FormattingEnabled = true;
			this.Fornecedor.Location = new System.Drawing.Point(72, 235);
			this.Fornecedor.Name = "Fornecedor";
			this.Fornecedor.Size = new System.Drawing.Size(395, 21);
			this.Fornecedor.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(78, 215);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 18);
			this.label2.TabIndex = 32;
			this.label2.Text = "Fornecedor:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Produto
			// 
			this.Produto.BackColor = System.Drawing.Color.White;
			this.Produto.FormattingEnabled = true;
			this.Produto.Location = new System.Drawing.Point(72, 192);
			this.Produto.Name = "Produto";
			this.Produto.Size = new System.Drawing.Size(395, 21);
			this.Produto.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(79, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 18);
			this.label1.TabIndex = 47;
			this.label1.Text = "Número da Transação:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Excluir
			// 
			this.Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.Excluir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.Excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
			this.Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Excluir.Location = new System.Drawing.Point(585, 489);
			this.Excluir.Name = "Excluir";
			this.Excluir.Size = new System.Drawing.Size(99, 38);
			this.Excluir.TabIndex = 48;
			this.Excluir.Text = "     Excluir";
			this.Excluir.UseVisualStyleBackColor = false;
			this.Excluir.Click += new System.EventHandler(this.ExcluirClick);
			// 
			// Cancelar
			// 
			this.Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
			this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Cancelar.Location = new System.Drawing.Point(480, 489);
			this.Cancelar.Name = "Cancelar";
			this.Cancelar.Size = new System.Drawing.Size(99, 38);
			this.Cancelar.TabIndex = 49;
			this.Cancelar.Text = "      Cancelar";
			this.Cancelar.UseVisualStyleBackColor = false;
			this.Cancelar.Click += new System.EventHandler(this.CancelarClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(79, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 18);
			this.label3.TabIndex = 50;
			this.label3.Text = "Produto:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(733, 101);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(177, 179);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 51;
			this.pictureBox1.TabStop = false;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(287, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(180, 18);
			this.label8.TabIndex = 54;
			this.label8.Text = "Tipo de Fluxo:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// fluxo
			// 
			this.fluxo.BackColor = System.Drawing.Color.White;
			this.fluxo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.fluxo.Location = new System.Drawing.Point(279, 101);
			this.fluxo.Name = "fluxo";
			this.fluxo.Size = new System.Drawing.Size(167, 20);
			this.fluxo.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(77, 351);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(106, 16);
			this.label9.TabIndex = 66;
			this.label9.Text = "Observações:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Obs
			// 
			this.Obs.BackColor = System.Drawing.Color.White;
			this.Obs.Location = new System.Drawing.Point(72, 370);
			this.Obs.Multiline = true;
			this.Obs.Name = "Obs";
			this.Obs.Size = new System.Drawing.Size(395, 65);
			this.Obs.TabIndex = 13;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(799, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(20, 17);
			this.button2.TabIndex = 89;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label12.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label12.Location = new System.Drawing.Point(117, 20);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(307, 22);
			this.label12.TabIndex = 88;
			this.label12.Text = "/ Excluir Transação";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(77, 13);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(41, 28);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 87;
			this.pictureBox2.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))));
			this.panel2.Location = new System.Drawing.Point(77, 45);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(650, 2);
			this.panel2.TabIndex = 86;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(77, 443);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(118, 16);
			this.label14.TabIndex = 91;
			this.label14.Text = "Motivo da Exclusão:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Motivo
			// 
			this.Motivo.BackColor = System.Drawing.Color.White;
			this.Motivo.Location = new System.Drawing.Point(72, 462);
			this.Motivo.Multiline = true;
			this.Motivo.Name = "Motivo";
			this.Motivo.Size = new System.Drawing.Size(395, 65);
			this.Motivo.TabIndex = 90;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.White;
			this.label16.Location = new System.Drawing.Point(77, 259);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(94, 18);
			this.label16.TabIndex = 93;
			this.label16.Text = "Grupo:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Grupo
			// 
			this.Grupo.BackColor = System.Drawing.Color.White;
			this.Grupo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Grupo.Location = new System.Drawing.Point(72, 280);
			this.Grupo.Name = "Grupo";
			this.Grupo.Size = new System.Drawing.Size(202, 20);
			this.Grupo.TabIndex = 92;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(493, 260);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(182, 18);
			this.label15.TabIndex = 95;
			this.label15.Text = "Usuário da Transação:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// usuário
			// 
			this.usuário.BackColor = System.Drawing.Color.White;
			this.usuário.Location = new System.Drawing.Point(493, 279);
			this.usuário.Name = "usuário";
			this.usuário.Size = new System.Drawing.Size(191, 20);
			this.usuário.TabIndex = 94;
			// 
			// usuario_exc
			// 
			this.usuario_exc.BackColor = System.Drawing.Color.White;
			this.usuario_exc.Location = new System.Drawing.Point(493, 325);
			this.usuario_exc.Name = "usuario_exc";
			this.usuario_exc.Size = new System.Drawing.Size(191, 20);
			this.usuario_exc.TabIndex = 96;
			// 
			// Exc_Tsç
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(951, 567);
			this.Controls.Add(this.usuario_exc);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.usuário);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.Grupo);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.Motivo);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.Obs);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.fluxo);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Excluir);
			this.Controls.Add(this.Cancelar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Transação);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.Hora);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.Barras);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Venda);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Custo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Nf);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Qtd);
			this.Controls.Add(this.Unidade);
			this.Controls.Add(this.Fornecedor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Produto);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Exc_Tsç";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exclusão de Movimentação de Mercadoria";
			this.Load += new System.EventHandler(this.Exc_TsçLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox usuario_exc;
		private System.Windows.Forms.TextBox usuário;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox Grupo;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox Motivo;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox Obs;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox fluxo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Cancelar;
		private System.Windows.Forms.Button Excluir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Produto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox Fornecedor;
		private System.Windows.Forms.ComboBox Unidade;
		private System.Windows.Forms.TextBox Qtd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Nf;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Custo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Venda;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox Barras;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox Hora;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox Transação;
	}
}
