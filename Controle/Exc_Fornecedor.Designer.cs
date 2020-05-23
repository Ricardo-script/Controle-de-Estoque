/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 01/08/2019
 * Time: 14:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Controle
{
	partial class Exc_Fornecedor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exc_Fornecedor));
			this.Excluir = new System.Windows.Forms.Button();
			this.Cancelar = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.Email = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.Contato = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.CNPJ = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Cidade = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.UF = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.CEP = new System.Windows.Forms.TextBox();
			this.Bairro = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Endereço = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Numero = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Fornecedor = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Excluir
			// 
			this.Excluir.BackColor = System.Drawing.Color.Transparent;
			this.Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Excluir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
			this.Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Excluir.Location = new System.Drawing.Point(646, 325);
			this.Excluir.Name = "Excluir";
			this.Excluir.Size = new System.Drawing.Size(99, 32);
			this.Excluir.TabIndex = 104;
			this.Excluir.Text = "       Excluir";
			this.Excluir.UseVisualStyleBackColor = false;
			this.Excluir.Click += new System.EventHandler(this.ExcluirClick);
			// 
			// Cancelar
			// 
			this.Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
			this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Cancelar.Location = new System.Drawing.Point(541, 325);
			this.Cancelar.Name = "Cancelar";
			this.Cancelar.Size = new System.Drawing.Size(99, 32);
			this.Cancelar.TabIndex = 105;
			this.Cancelar.Text = "      Cancelar";
			this.Cancelar.UseVisualStyleBackColor = true;
			this.Cancelar.Click += new System.EventHandler(this.CancelarClick);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(71, 292);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 18);
			this.label10.TabIndex = 115;
			this.label10.Text = "E-mail:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Email
			// 
			this.Email.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Email.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Email.ForeColor = System.Drawing.Color.Black;
			this.Email.Location = new System.Drawing.Point(71, 313);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(395, 20);
			this.Email.TabIndex = 103;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(277, 251);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(111, 18);
			this.label9.TabIndex = 114;
			this.label9.Text = "Contato:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Contato
			// 
			this.Contato.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.Contato.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Contato.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Contato.ForeColor = System.Drawing.Color.Black;
			this.Contato.Location = new System.Drawing.Point(277, 272);
			this.Contato.Name = "Contato";
			this.Contato.Size = new System.Drawing.Size(189, 20);
			this.Contato.TabIndex = 102;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(73, 117);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(122, 18);
			this.label8.TabIndex = 113;
			this.label8.Text = "CNPJ/CPF:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// CNPJ
			// 
			this.CNPJ.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.CNPJ.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.CNPJ.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CNPJ.ForeColor = System.Drawing.Color.Black;
			this.CNPJ.Location = new System.Drawing.Point(71, 138);
			this.CNPJ.Name = "CNPJ";
			this.CNPJ.Size = new System.Drawing.Size(395, 20);
			this.CNPJ.TabIndex = 95;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(71, 251);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 18);
			this.label7.TabIndex = 112;
			this.label7.Text = "Cidade:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Cidade
			// 
			this.Cidade.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.Cidade.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Cidade.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cidade.ForeColor = System.Drawing.Color.Black;
			this.Cidade.Location = new System.Drawing.Point(71, 272);
			this.Cidade.Name = "Cidade";
			this.Cidade.Size = new System.Drawing.Size(200, 20);
			this.Cidade.TabIndex = 101;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(394, 206);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 18);
			this.label6.TabIndex = 111;
			this.label6.Text = "UF:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// UF
			// 
			this.UF.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.UF.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.UF.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UF.ForeColor = System.Drawing.Color.Black;
			this.UF.Location = new System.Drawing.Point(394, 227);
			this.UF.Name = "UF";
			this.UF.Size = new System.Drawing.Size(72, 20);
			this.UF.TabIndex = 100;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(277, 206);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 18);
			this.label5.TabIndex = 110;
			this.label5.Text = "CEP:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// CEP
			// 
			this.CEP.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.CEP.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.CEP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CEP.ForeColor = System.Drawing.Color.Black;
			this.CEP.Location = new System.Drawing.Point(277, 227);
			this.CEP.Name = "CEP";
			this.CEP.Size = new System.Drawing.Size(111, 20);
			this.CEP.TabIndex = 99;
			// 
			// Bairro
			// 
			this.Bairro.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.Bairro.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Bairro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Bairro.ForeColor = System.Drawing.Color.Black;
			this.Bairro.Location = new System.Drawing.Point(71, 227);
			this.Bairro.Name = "Bairro";
			this.Bairro.Size = new System.Drawing.Size(200, 20);
			this.Bairro.TabIndex = 98;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(73, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 18);
			this.label4.TabIndex = 109;
			this.label4.Text = "Bairro:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Endereço
			// 
			this.Endereço.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.Endereço.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Endereço.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Endereço.ForeColor = System.Drawing.Color.Black;
			this.Endereço.Location = new System.Drawing.Point(71, 182);
			this.Endereço.Name = "Endereço";
			this.Endereço.Size = new System.Drawing.Size(317, 20);
			this.Endereço.TabIndex = 96;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(394, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 18);
			this.label2.TabIndex = 108;
			this.label2.Text = "Número:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Numero
			// 
			this.Numero.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.Numero.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Numero.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Numero.ForeColor = System.Drawing.Color.Black;
			this.Numero.Location = new System.Drawing.Point(394, 182);
			this.Numero.Name = "Numero";
			this.Numero.Size = new System.Drawing.Size(72, 20);
			this.Numero.TabIndex = 97;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(73, 161);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 18);
			this.label3.TabIndex = 107;
			this.label3.Text = "Endereço:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(73, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 18);
			this.label1.TabIndex = 106;
			this.label1.Text = "Fornecedor:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Fornecedor
			// 
			this.Fornecedor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Fornecedor.FormattingEnabled = true;
			this.Fornecedor.Location = new System.Drawing.Point(73, 94);
			this.Fornecedor.Name = "Fornecedor";
			this.Fornecedor.Size = new System.Drawing.Size(393, 22);
			this.Fornecedor.TabIndex = 116;
			this.Fornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FornecedorKeyPress);
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
			this.button1.Location = new System.Drawing.Point(740, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(20, 17);
			this.button1.TabIndex = 120;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label11.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label11.Location = new System.Drawing.Point(100, 20);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(307, 22);
			this.label11.TabIndex = 119;
			this.label11.Text = "/ Excluir Fornecedor";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(60, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(41, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 118;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))));
			this.panel2.Location = new System.Drawing.Point(58, 42);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(700, 2);
			this.panel2.TabIndex = 117;
			// 
			// Exc_Fornecedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(788, 392);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.Fornecedor);
			this.Controls.Add(this.Excluir);
			this.Controls.Add(this.Cancelar);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.Contato);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.CNPJ);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Cidade);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.UF);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.CEP);
			this.Controls.Add(this.Bairro);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Endereço);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Numero);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Exc_Fornecedor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exc_Fornecedor";
			this.Load += new System.EventHandler(this.Exc_FornecedorLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox Fornecedor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Numero;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Endereço;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Bairro;
		private System.Windows.Forms.TextBox CEP;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox UF;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Cidade;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox CNPJ;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox Contato;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox Email;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button Cancelar;
		private System.Windows.Forms.Button Excluir;
		
		
		
		
		
		
	}
}
