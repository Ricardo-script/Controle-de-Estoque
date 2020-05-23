/*
 * Criado por SharpDevelop.
 * Usuário: ricardo.silva
 * Data: 13/08/2019
 * Hora: 14:00
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Controle
{
	partial class Adm_Excluir
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adm_Excluir));
			this.Cancelar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.Senha = new System.Windows.Forms.TextBox();
			this.Usuario = new System.Windows.Forms.TextBox();
			this.Excluir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Cancelar
			// 
			this.Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
			this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Cancelar.Location = new System.Drawing.Point(312, 12);
			this.Cancelar.Name = "Cancelar";
			this.Cancelar.Size = new System.Drawing.Size(99, 28);
			this.Cancelar.TabIndex = 74;
			this.Cancelar.Text = "      Cancelar";
			this.Cancelar.UseVisualStyleBackColor = true;
			this.Cancelar.Click += new System.EventHandler(this.CancelarClick);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(61, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(208, 18);
			this.label6.TabIndex = 87;
			this.label6.Text = "Senha do Administrador:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Senha
			// 
			this.Senha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Senha.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Senha.Location = new System.Drawing.Point(61, 43);
			this.Senha.Name = "Senha";
			this.Senha.PasswordChar = '*';
			this.Senha.Size = new System.Drawing.Size(217, 24);
			this.Senha.TabIndex = 86;
			// 
			// Usuario
			// 
			this.Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.Usuario.Location = new System.Drawing.Point(61, 69);
			this.Usuario.Name = "Usuario";
			this.Usuario.Size = new System.Drawing.Size(217, 13);
			this.Usuario.TabIndex = 88;
			// 
			// Excluir
			// 
			this.Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.Excluir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.Excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
			this.Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Excluir.Location = new System.Drawing.Point(312, 53);
			this.Excluir.Name = "Excluir";
			this.Excluir.Size = new System.Drawing.Size(99, 28);
			this.Excluir.TabIndex = 89;
			this.Excluir.Text = "     Excluir";
			this.Excluir.UseVisualStyleBackColor = false;
			this.Excluir.Click += new System.EventHandler(this.ExcluirClick);
			// 
			// Adm_Excluir
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
			this.ClientSize = new System.Drawing.Size(448, 93);
			this.Controls.Add(this.Excluir);
			this.Controls.Add(this.Usuario);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Senha);
			this.Controls.Add(this.Cancelar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Adm_Excluir";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adm_Excluir";
			this.Load += new System.EventHandler(this.Adm_ExcluirLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Excluir;
		private System.Windows.Forms.TextBox Usuario;
		private System.Windows.Forms.TextBox Senha;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button Cancelar;
	}
}
