/*
 * Created by SharpDevelop.
 * User: ricardo.silva
 * Date: 31/07/2019
 * Time: 16:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Controle
{
	partial class Exc_Unidade
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exc_Unidade));
			this.Excluir_Unidade = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.Und = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Excluir_Unidade
			// 
			this.Excluir_Unidade.BackColor = System.Drawing.Color.Transparent;
			this.Excluir_Unidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Excluir_Unidade.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.Excluir_Unidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Excluir_Unidade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Excluir_Unidade.Image = ((System.Drawing.Image)(resources.GetObject("Excluir_Unidade.Image")));
			this.Excluir_Unidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Excluir_Unidade.Location = new System.Drawing.Point(305, 123);
			this.Excluir_Unidade.Name = "Excluir_Unidade";
			this.Excluir_Unidade.Size = new System.Drawing.Size(119, 32);
			this.Excluir_Unidade.TabIndex = 81;
			this.Excluir_Unidade.Text = "   Excluir";
			this.Excluir_Unidade.UseVisualStyleBackColor = false;
			this.Excluir_Unidade.Click += new System.EventHandler(this.Excluir_UnidadeClick);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(41, 81);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 19);
			this.label7.TabIndex = 80;
			this.label7.Text = "Unidade:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Und
			// 
			this.Und.FormattingEnabled = true;
			this.Und.Location = new System.Drawing.Point(103, 81);
			this.Und.Name = "Und";
			this.Und.Size = new System.Drawing.Size(321, 21);
			this.Und.TabIndex = 82;
			this.Und.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UndMouseClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(448, 14);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(20, 17);
			this.button1.TabIndex = 89;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.label11.Font = new System.Drawing.Font("Candara", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label11.Location = new System.Drawing.Point(68, 21);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(307, 22);
			this.label11.TabIndex = 88;
			this.label11.Text = "/ Excluir Unidade";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(30, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 87;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))));
			this.panel2.Location = new System.Drawing.Point(30, 43);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(400, 2);
			this.panel2.TabIndex = 86;
			// 
			// Exc_Unidade
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(484, 181);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.Und);
			this.Controls.Add(this.Excluir_Unidade);
			this.Controls.Add(this.label7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Exc_Unidade";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exc_Unidade";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox Und;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button Excluir_Unidade;
	}
}
