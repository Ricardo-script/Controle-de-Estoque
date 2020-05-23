/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 06/08/2019
 * Time: 07:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Controle
{
	partial class Configuracao
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracao));
			this.button1 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Sair = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.Senha = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Alterar = new System.Windows.Forms.Button();
			this.Excluir = new System.Windows.Forms.Button();
			this.Usuario = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(356, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(20, 17);
			this.button1.TabIndex = 91;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.label11.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label11.Location = new System.Drawing.Point(100, 19);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(218, 22);
			this.label11.TabIndex = 90;
			this.label11.Text = "Criar / Excluir Login";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))));
			this.panel2.Location = new System.Drawing.Point(56, 41);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(320, 2);
			this.panel2.TabIndex = 89;
			// 
			// Sair
			// 
			this.Sair.BackColor = System.Drawing.Color.Transparent;
			this.Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Sair.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Sair.Image = ((System.Drawing.Image)(resources.GetObject("Sair.Image")));
			this.Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Sair.Location = new System.Drawing.Point(268, 166);
			this.Sair.Name = "Sair";
			this.Sair.Size = new System.Drawing.Size(108, 30);
			this.Sair.TabIndex = 88;
			this.Sair.Text = "         Sair";
			this.Sair.UseVisualStyleBackColor = false;
			this.Sair.Click += new System.EventHandler(this.SairClick);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(45, 61);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 19);
			this.label7.TabIndex = 87;
			this.label7.Text = "Usuário:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Senha
			// 
			this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Senha.Location = new System.Drawing.Point(110, 107);
			this.Senha.Name = "Senha";
			this.Senha.PasswordChar = '*';
			this.Senha.Size = new System.Drawing.Size(254, 20);
			this.Senha.TabIndex = 94;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(45, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 19);
			this.label1.TabIndex = 93;
			this.label1.Text = "Senha:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Alterar
			// 
			this.Alterar.BackColor = System.Drawing.Color.Transparent;
			this.Alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Alterar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.Alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Alterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Alterar.Image = ((System.Drawing.Image)(resources.GetObject("Alterar.Image")));
			this.Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Alterar.Location = new System.Drawing.Point(154, 166);
			this.Alterar.Name = "Alterar";
			this.Alterar.Size = new System.Drawing.Size(108, 30);
			this.Alterar.TabIndex = 95;
			this.Alterar.Text = "         Criar";
			this.Alterar.UseVisualStyleBackColor = false;
			this.Alterar.Click += new System.EventHandler(this.EntrarClick);
			// 
			// Excluir
			// 
			this.Excluir.BackColor = System.Drawing.Color.Transparent;
			this.Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Excluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.Excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
			this.Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Excluir.Location = new System.Drawing.Point(40, 166);
			this.Excluir.Name = "Excluir";
			this.Excluir.Size = new System.Drawing.Size(108, 30);
			this.Excluir.TabIndex = 97;
			this.Excluir.Text = "         Excluir";
			this.Excluir.UseVisualStyleBackColor = false;
			this.Excluir.Click += new System.EventHandler(this.Button2Click);
			// 
			// Usuario
			// 
			this.Usuario.FormattingEnabled = true;
			this.Usuario.Location = new System.Drawing.Point(110, 61);
			this.Usuario.Name = "Usuario";
			this.Usuario.Size = new System.Drawing.Size(253, 21);
			this.Usuario.TabIndex = 98;
			this.Usuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsuarioMouseClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(34, 36);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 99;
			this.pictureBox1.TabStop = false;
			// 
			// Configuracao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.ClientSize = new System.Drawing.Size(399, 218);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Usuario);
			this.Controls.Add(this.Excluir);
			this.Controls.Add(this.Alterar);
			this.Controls.Add(this.Senha);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.Sair);
			this.Controls.Add(this.label7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Configuracao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Autorização Administrador";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox Usuario;
		private System.Windows.Forms.Button Excluir;
		private System.Windows.Forms.Button Alterar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Senha;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button Sair;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button1;
		
		
		
		
		
		
	}
}
