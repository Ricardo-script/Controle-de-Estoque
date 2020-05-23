/*
 * Criado por SharpDevelop.
 * Usuário: ricardo.silva
 * Data: 08/08/2019
 * Hora: 10:21
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Controle
{
	partial class Excluido
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excluido));
			this.Tela = new System.Windows.Forms.DataGridView();
			this.Visualizar = new System.Windows.Forms.Button();
			this.Sair = new System.Windows.Forms.Button();
			this.Exportar = new System.Windows.Forms.Button();
			this.Inicio = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Estoque = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.excluir_tudo = new System.Windows.Forms.Button();
			this.usuario = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.Tela)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Tela
			// 
			this.Tela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Tela.Location = new System.Drawing.Point(37, 177);
			this.Tela.Name = "Tela";
			this.Tela.Size = new System.Drawing.Size(1270, 405);
			this.Tela.TabIndex = 0;
			// 
			// Visualizar
			// 
			this.Visualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.Visualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.Visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Visualizar.Image = ((System.Drawing.Image)(resources.GetObject("Visualizar.Image")));
			this.Visualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Visualizar.Location = new System.Drawing.Point(177, 89);
			this.Visualizar.Name = "Visualizar";
			this.Visualizar.Size = new System.Drawing.Size(67, 62);
			this.Visualizar.TabIndex = 33;
			this.Visualizar.UseVisualStyleBackColor = true;
			this.Visualizar.Click += new System.EventHandler(this.VisualizarClick);
			// 
			// Sair
			// 
			this.Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Sair.Image = ((System.Drawing.Image)(resources.GetObject("Sair.Image")));
			this.Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Sair.Location = new System.Drawing.Point(368, 89);
			this.Sair.Name = "Sair";
			this.Sair.Size = new System.Drawing.Size(62, 62);
			this.Sair.TabIndex = 32;
			this.Sair.UseVisualStyleBackColor = true;
			this.Sair.Click += new System.EventHandler(this.SairClick);
			// 
			// Exportar
			// 
			this.Exportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.Exportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.Exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Exportar.Image = ((System.Drawing.Image)(resources.GetObject("Exportar.Image")));
			this.Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Exportar.Location = new System.Drawing.Point(274, 89);
			this.Exportar.Name = "Exportar";
			this.Exportar.Size = new System.Drawing.Size(66, 62);
			this.Exportar.TabIndex = 31;
			this.Exportar.UseVisualStyleBackColor = true;
			this.Exportar.Click += new System.EventHandler(this.ExportarClick);
			// 
			// Inicio
			// 
			this.Inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.Inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Inicio.Image = ((System.Drawing.Image)(resources.GetObject("Inicio.Image")));
			this.Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Inicio.Location = new System.Drawing.Point(89, 89);
			this.Inicio.Name = "Inicio";
			this.Inicio.Size = new System.Drawing.Size(62, 62);
			this.Inicio.TabIndex = 2;
			this.Inicio.Text = "      ";
			this.Inicio.UseVisualStyleBackColor = true;
			this.Inicio.Click += new System.EventHandler(this.InicioClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(103, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 17);
			this.label3.TabIndex = 34;
			this.label3.Text = "Inicio";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(170, 151);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 17);
			this.label1.TabIndex = 35;
			this.label1.Text = "Gerar Relatório";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(270, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 17);
			this.label2.TabIndex = 36;
			this.label2.Text = "Exportar Excel";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(387, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 16);
			this.label4.TabIndex = 37;
			this.label4.Text = "Sair";
			// 
			// Estoque
			// 
			this.Estoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.Estoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.Estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Estoque.Image = ((System.Drawing.Image)(resources.GetObject("Estoque.Image")));
			this.Estoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Estoque.Location = new System.Drawing.Point(458, 89);
			this.Estoque.Name = "Estoque";
			this.Estoque.Size = new System.Drawing.Size(69, 62);
			this.Estoque.TabIndex = 38;
			this.Estoque.UseVisualStyleBackColor = true;
			this.Estoque.Click += new System.EventHandler(this.EstoqueClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(455, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 18);
			this.label5.TabIndex = 39;
			this.label5.Text = "Estoque Ativo";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label6.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(114, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(307, 22);
			this.label6.TabIndex = 41;
			this.label6.Text = "/ Transações Excluídas";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))));
			this.panel2.Location = new System.Drawing.Point(80, 61);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(970, 2);
			this.panel2.TabIndex = 40;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(92, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(34, 33);
			this.pictureBox1.TabIndex = 42;
			this.pictureBox1.TabStop = false;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(553, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 18);
			this.label7.TabIndex = 44;
			this.label7.Text = "Excluir Tudo";
			// 
			// excluir_tudo
			// 
			this.excluir_tudo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.excluir_tudo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.excluir_tudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.excluir_tudo.Image = ((System.Drawing.Image)(resources.GetObject("excluir_tudo.Image")));
			this.excluir_tudo.Location = new System.Drawing.Point(555, 89);
			this.excluir_tudo.Name = "excluir_tudo";
			this.excluir_tudo.Size = new System.Drawing.Size(69, 62);
			this.excluir_tudo.TabIndex = 43;
			this.excluir_tudo.UseVisualStyleBackColor = true;
			this.excluir_tudo.Click += new System.EventHandler(this.Excluir_tudoClick);
			// 
			// usuario
			// 
			this.usuario.Location = new System.Drawing.Point(12, 585);
			this.usuario.Name = "usuario";
			this.usuario.Size = new System.Drawing.Size(128, 20);
			this.usuario.TabIndex = 45;
			// 
			// Excluido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.ClientSize = new System.Drawing.Size(1317, 607);
			this.Controls.Add(this.usuario);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.excluir_tudo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Estoque);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Visualizar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Inicio);
			this.Controls.Add(this.Sair);
			this.Controls.Add(this.Exportar);
			this.Controls.Add(this.Tela);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Excluido";
			this.Text = "Transações Excluidas";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ExcluidoLoad);
			((System.ComponentModel.ISupportInitialize)(this.Tela)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox usuario;
		private System.Windows.Forms.Button excluir_tudo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button Estoque;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Inicio;
		private System.Windows.Forms.Button Exportar;
		private System.Windows.Forms.Button Sair;
		private System.Windows.Forms.Button Visualizar;
		private System.Windows.Forms.DataGridView Tela;
		
		
	}
}
