/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 31/07/2019
 * Time: 14:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Controle
{
	partial class AddGupo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGupo));
			this.label7 = new System.Windows.Forms.Label();
			this.Cadastrar = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.Grupo = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(47, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 19);
			this.label7.TabIndex = 18;
			this.label7.Text = "Grupo:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Cadastrar
			// 
			this.Cadastrar.BackColor = System.Drawing.Color.Transparent;
			this.Cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.Cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(216)))), ((int)(((byte)(92)))));
			this.Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("Cadastrar.Image")));
			this.Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Cadastrar.Location = new System.Drawing.Point(262, 125);
			this.Cadastrar.Name = "Cadastrar";
			this.Cadastrar.Size = new System.Drawing.Size(158, 32);
			this.Cadastrar.TabIndex = 73;
			this.Cadastrar.Text = "       Cadastrar novo Grupo";
			this.Cadastrar.UseVisualStyleBackColor = false;
			this.Cadastrar.Click += new System.EventHandler(this.CadastrarClick);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label11.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label11.Location = new System.Drawing.Point(75, 14);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(307, 22);
			this.label11.TabIndex = 80;
			this.label11.Text = "/ Cadastro de Grupo";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(35, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(41, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 79;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))));
			this.panel2.Location = new System.Drawing.Point(35, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(400, 2);
			this.panel2.TabIndex = 78;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(440, 7);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(20, 17);
			this.button1.TabIndex = 81;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Grupo
			// 
			this.Grupo.Location = new System.Drawing.Point(102, 72);
			this.Grupo.Name = "Grupo";
			this.Grupo.Size = new System.Drawing.Size(318, 20);
			this.Grupo.TabIndex = 82;
			// 
			// AddGupo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(484, 181);
			this.Controls.Add(this.Grupo);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.Cadastrar);
			this.Controls.Add(this.label7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddGupo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Novo Grupo";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button Cadastrar;
		private System.Windows.Forms.TextBox Grupo;
		private System.Windows.Forms.Label label7;
	}
}
