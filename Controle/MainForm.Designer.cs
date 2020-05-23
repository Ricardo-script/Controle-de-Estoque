/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 23/07/2019
 * Time: 10:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Controle
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Entrar = new System.Windows.Forms.Button();
			this.Sair = new System.Windows.Forms.Button();
			this.Usuario = new System.Windows.Forms.TextBox();
			this.Senha = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(254, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(505, 367);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 67);
			this.label1.TabIndex = 1;
			this.label1.Text = "Login";
			// 
			// Entrar
			// 
			this.Entrar.BackColor = System.Drawing.Color.SteelBlue;
			this.Entrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Entrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Entrar.Location = new System.Drawing.Point(44, 238);
			this.Entrar.Name = "Entrar";
			this.Entrar.Size = new System.Drawing.Size(77, 24);
			this.Entrar.TabIndex = 2;
			this.Entrar.Text = "Entrar";
			this.Entrar.UseVisualStyleBackColor = false;
			this.Entrar.Click += new System.EventHandler(this.EntrarClick);
			// 
			// Sair
			// 
			this.Sair.BackColor = System.Drawing.Color.Salmon;
			this.Sair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Sair.Location = new System.Drawing.Point(138, 238);
			this.Sair.Name = "Sair";
			this.Sair.Size = new System.Drawing.Size(77, 24);
			this.Sair.TabIndex = 3;
			this.Sair.Text = "Sair";
			this.Sair.UseVisualStyleBackColor = false;
			this.Sair.Click += new System.EventHandler(this.SairClick);
			// 
			// Usuario
			// 
			this.Usuario.Location = new System.Drawing.Point(44, 134);
			this.Usuario.Name = "Usuario";
			this.Usuario.Size = new System.Drawing.Size(184, 20);
			this.Usuario.TabIndex = 4;
			this.Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsuarioKeyPress);
			// 
			// Senha
			// 
			this.Senha.Location = new System.Drawing.Point(44, 186);
			this.Senha.Name = "Senha";
			this.Senha.PasswordChar = '*';
			this.Senha.Size = new System.Drawing.Size(184, 20);
			this.Senha.TabIndex = 5;
			this.Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SenhaKeyPress);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(47, 164);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(18, 20);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(71, 168);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 15);
			this.label2.TabIndex = 8;
			this.label2.Text = "Senha:";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(47, 110);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(20, 22);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 9;
			this.pictureBox3.TabStop = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(73, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "Usuário:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 365);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.Senha);
			this.Controls.Add(this.Usuario);
			this.Controls.Add(this.Sair);
			this.Controls.Add(this.Entrar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Controle";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox Senha;
		private System.Windows.Forms.TextBox Usuario;
		private System.Windows.Forms.Button Sair;
		private System.Windows.Forms.Button Entrar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
