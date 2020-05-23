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
			((System.ComponentModel.ISupportInitialize)(this.Tela)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			this.Tela.Location = new System.Drawing.Point(41, 191);
			this.Tela.Name = "Tela";
			this.Tela.Size = new System.Drawing.Size(1101, 367);
			this.Tela.TabIndex = 0;
			// 
			// Gerar
			// 
			this.Gerar.Image = ((System.Drawing.Image)(resources.GetObject("Gerar.Image")));
			this.Gerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Gerar.Location = new System.Drawing.Point(820, 150);
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
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label1.Location = new System.Drawing.Point(874, 611);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 21);
			this.label1.TabIndex = 25;
			this.label1.Text = "TOTAL";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Total
			// 
			this.Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Total.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.Total.Location = new System.Drawing.Point(770, 609);
			this.Total.Multiline = true;
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(206, 48);
			this.Total.TabIndex = 24;
			// 
			// Exportar
			// 
			this.Exportar.Image = ((System.Drawing.Image)(resources.GetObject("Exportar.Image")));
			this.Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Exportar.Location = new System.Drawing.Point(622, 609);
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
			this.Sair.Location = new System.Drawing.Point(529, 609);
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
			this.Excl.Location = new System.Drawing.Point(157, 609);
			this.Excl.Name = "Excl";
			this.Excl.Size = new System.Drawing.Size(87, 29);
			this.Excl.TabIndex = 28;
			this.Excl.Text = "        Cadastro";
			this.Excl.UseVisualStyleBackColor = true;
			this.Excl.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(343, 609);
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
			this.button3.Location = new System.Drawing.Point(436, 609);
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
			this.groupBox1.Location = new System.Drawing.Point(41, 72);
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
			this.button4.Location = new System.Drawing.Point(250, 609);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(87, 29);
			this.button4.TabIndex = 34;
			this.button4.Text = "     Excluir";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(193)))), ((int)(((byte)(203)))));
			this.label3.Location = new System.Drawing.Point(874, 632);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 21);
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
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.fim);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.inicio);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(594, 72);
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
			this.label7.Location = new System.Drawing.Point(71, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(307, 22);
			this.label7.TabIndex = 44;
			this.label7.Text = "/ Controle de Estoque";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel2.Location = new System.Drawing.Point(37, 44);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(970, 2);
			this.panel2.TabIndex = 43;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(37, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(31, 31);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 45;
			this.pictureBox1.TabStop = false;
			// 
			// Controle_Stq
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(1173, 676);
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
			this.Name = "Controle_Stq";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Controle de Estoque";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ControleLoad);
			((System.ComponentModel.ISupportInitialize)(this.Tela)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
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
