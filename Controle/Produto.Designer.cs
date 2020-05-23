/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 24/07/2019
 * Time: 07:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Controle
{
	partial class Produto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produto));
			this.Descrição = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Cancelar = new System.Windows.Forms.Button();
			this.Cadastrar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.Barras = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Custo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Venda = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Grupo = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Unidade = new System.Windows.Forms.ComboBox();
			this.Fornecedor = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.Maximo = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.Minimo = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// Descrição
			// 
			this.Descrição.Location = new System.Drawing.Point(73, 125);
			this.Descrição.Name = "Descrição";
			this.Descrição.Size = new System.Drawing.Size(390, 20);
			this.Descrição.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(73, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Descrição:";
			// 
			// Cancelar
			// 
			this.Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
			this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Cancelar.Location = new System.Drawing.Point(519, 333);
			this.Cancelar.Name = "Cancelar";
			this.Cancelar.Size = new System.Drawing.Size(99, 38);
			this.Cancelar.TabIndex = 9;
			this.Cancelar.Text = "      Cancelar";
			this.Cancelar.UseVisualStyleBackColor = true;
			this.Cancelar.Click += new System.EventHandler(this.CancelarClick);
			// 
			// Cadastrar
			// 
			this.Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.Cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("Cadastrar.Image")));
			this.Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Cadastrar.Location = new System.Drawing.Point(624, 333);
			this.Cadastrar.Name = "Cadastrar";
			this.Cadastrar.Size = new System.Drawing.Size(99, 38);
			this.Cadastrar.TabIndex = 8;
			this.Cadastrar.Text = "       Cadastrar";
			this.Cadastrar.UseVisualStyleBackColor = true;
			this.Cadastrar.Click += new System.EventHandler(this.CadastrarClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(73, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Cod. de Barras:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Barras
			// 
			this.Barras.Location = new System.Drawing.Point(73, 82);
			this.Barras.Name = "Barras";
			this.Barras.Size = new System.Drawing.Size(390, 20);
			this.Barras.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(73, 148);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Fornecedor:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(73, 193);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Unidade/Medida:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(73, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "Custo:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Custo
			// 
			this.Custo.Location = new System.Drawing.Point(73, 257);
			this.Custo.Name = "Custo";
			this.Custo.Size = new System.Drawing.Size(187, 20);
			this.Custo.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(276, 240);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 17);
			this.label6.TabIndex = 13;
			this.label6.Text = "Venda:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Venda
			// 
			this.Venda.Location = new System.Drawing.Point(276, 257);
			this.Venda.Name = "Venda";
			this.Venda.Size = new System.Drawing.Size(187, 20);
			this.Venda.TabIndex = 7;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(548, 69);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(175, 141);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// Grupo
			// 
			this.Grupo.FormattingEnabled = true;
			this.Grupo.Location = new System.Drawing.Point(276, 212);
			this.Grupo.Name = "Grupo";
			this.Grupo.Size = new System.Drawing.Size(187, 21);
			this.Grupo.TabIndex = 5;
			this.Grupo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GrupoMouseClick);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(276, 193);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 17);
			this.label7.TabIndex = 16;
			this.label7.Text = "Grupo:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Unidade
			// 
			this.Unidade.FormattingEnabled = true;
			this.Unidade.Location = new System.Drawing.Point(73, 212);
			this.Unidade.Name = "Unidade";
			this.Unidade.Size = new System.Drawing.Size(187, 21);
			this.Unidade.TabIndex = 17;
			this.Unidade.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UnidadeMouseClick);
			// 
			// Fornecedor
			// 
			this.Fornecedor.FormattingEnabled = true;
			this.Fornecedor.Location = new System.Drawing.Point(73, 167);
			this.Fornecedor.Name = "Fornecedor";
			this.Fornecedor.Size = new System.Drawing.Size(390, 21);
			this.Fornecedor.TabIndex = 18;
			this.Fornecedor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FornecedorMouseClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(703, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(20, 17);
			this.button1.TabIndex = 85;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label11.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label11.Location = new System.Drawing.Point(112, 20);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(307, 22);
			this.label11.TabIndex = 84;
			this.label11.Text = "/ Cadastro de Produtos";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(72, 13);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(41, 28);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 83;
			this.pictureBox2.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))));
			this.panel2.Location = new System.Drawing.Point(72, 45);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(650, 2);
			this.panel2.TabIndex = 82;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(276, 285);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(106, 17);
			this.label8.TabIndex = 89;
			this.label8.Text = "Estoque Máximo:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Maximo
			// 
			this.Maximo.Location = new System.Drawing.Point(276, 302);
			this.Maximo.Name = "Maximo";
			this.Maximo.Size = new System.Drawing.Size(187, 20);
			this.Maximo.TabIndex = 87;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(73, 285);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 17);
			this.label9.TabIndex = 88;
			this.label9.Text = "Estoque Mínimo:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Minimo
			// 
			this.Minimo.Location = new System.Drawing.Point(73, 302);
			this.Minimo.Name = "Minimo";
			this.Minimo.Size = new System.Drawing.Size(187, 20);
			this.Minimo.TabIndex = 86;
			// 
			// Produto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(808, 394);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Maximo);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.Minimo);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.Fornecedor);
			this.Controls.Add(this.Unidade);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Grupo);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Venda);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Custo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Barras);
			this.Controls.Add(this.Cadastrar);
			this.Controls.Add(this.Cancelar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Descrição);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Produto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Produto";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox Minimo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox Maximo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox Grupo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox Venda;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Custo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox Unidade;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox Fornecedor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Barras;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Cadastrar;
		private System.Windows.Forms.Button Cancelar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Descrição;
	}
}
