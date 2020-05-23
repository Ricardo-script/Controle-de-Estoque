/*
 * Criado por SharpDevelop.
 * Usuário: ricardo.silva
 * Data: 20/08/2019
 * Hora: 09:11
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Controle
{
	partial class Status
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status));
			this.Tela = new System.Windows.Forms.DataGridView();
			this.Gerar = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Sair = new System.Windows.Forms.Button();
			this.produto = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.barras = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Tela)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// Tela
			// 
			this.Tela.AllowUserToAddRows = false;
			this.Tela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Tela.Location = new System.Drawing.Point(28, 72);
			this.Tela.Name = "Tela";
			this.Tela.Size = new System.Drawing.Size(699, 254);
			this.Tela.TabIndex = 0;
			// 
			// Gerar
			// 
			this.Gerar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.Gerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Gerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Gerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Gerar.ForeColor = System.Drawing.Color.White;
			this.Gerar.Image = ((System.Drawing.Image)(resources.GetObject("Gerar.Image")));
			this.Gerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Gerar.Location = new System.Drawing.Point(630, 344);
			this.Gerar.Name = "Gerar";
			this.Gerar.Size = new System.Drawing.Size(97, 38);
			this.Gerar.TabIndex = 1;
			this.Gerar.Text = "         Pesquisar";
			this.Gerar.UseVisualStyleBackColor = true;
			this.Gerar.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(707, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(20, 17);
			this.button2.TabIndex = 93;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label12.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label12.Location = new System.Drawing.Point(70, 31);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(307, 22);
			this.label12.TabIndex = 92;
			this.label12.Text = "/ Status do Estoque";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(30, 24);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(41, 28);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 91;
			this.pictureBox2.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))));
			this.panel2.Location = new System.Drawing.Point(30, 56);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(650, 2);
			this.panel2.TabIndex = 90;
			// 
			// Sair
			// 
			this.Sair.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Sair.ForeColor = System.Drawing.Color.White;
			this.Sair.Image = ((System.Drawing.Image)(resources.GetObject("Sair.Image")));
			this.Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Sair.Location = new System.Drawing.Point(527, 344);
			this.Sair.Name = "Sair";
			this.Sair.Size = new System.Drawing.Size(97, 38);
			this.Sair.TabIndex = 94;
			this.Sair.Text = "         Sair";
			this.Sair.UseVisualStyleBackColor = true;
			this.Sair.Click += new System.EventHandler(this.SairClick);
			// 
			// produto
			// 
			this.produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.produto.Location = new System.Drawing.Point(30, 350);
			this.produto.Name = "produto";
			this.produto.Size = new System.Drawing.Size(206, 20);
			this.produto.TabIndex = 95;
			this.produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProdutoKeyPress);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(30, 329);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(217, 18);
			this.label11.TabIndex = 96;
			this.label11.Text = "Pesquisar por Produto:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// barras
			// 
			this.barras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.barras.Location = new System.Drawing.Point(253, 350);
			this.barras.Name = "barras";
			this.barras.Size = new System.Drawing.Size(206, 20);
			this.barras.TabIndex = 97;
			this.barras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarrasKeyPress);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(253, 329);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 18);
			this.label1.TabIndex = 98;
			this.label1.Text = "Pesquisar por Cod. de Barras:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Status
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.ClientSize = new System.Drawing.Size(751, 400);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.barras);
			this.Controls.Add(this.produto);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.Sair);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.Gerar);
			this.Controls.Add(this.Tela);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Status";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Status";
			((System.ComponentModel.ISupportInitialize)(this.Tela)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox barras;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox produto;
		private System.Windows.Forms.Button Sair;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button Gerar;
		private System.Windows.Forms.DataGridView Tela;
	}
}
