/*
 * Created by SharpDevelop.
 * User: Lorna
 * Date: 2/11/2021
 * Time: 12:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project101
{
	partial class Home
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnprod;
		private System.Windows.Forms.Button btnmember;
		private System.Windows.Forms.Button btntrans;
		private System.Windows.Forms.Button btndata;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.btnprod = new System.Windows.Forms.Button();
			this.btnmember = new System.Windows.Forms.Button();
			this.btntrans = new System.Windows.Forms.Button();
			this.btndata = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnprod
			// 
			this.btnprod.BackColor = System.Drawing.Color.Aquamarine;
			this.btnprod.Location = new System.Drawing.Point(12, 28);
			this.btnprod.Name = "btnprod";
			this.btnprod.Size = new System.Drawing.Size(239, 71);
			this.btnprod.TabIndex = 0;
			this.btnprod.Text = "Products";
			this.btnprod.UseVisualStyleBackColor = false;
			this.btnprod.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnmember
			// 
			this.btnmember.BackColor = System.Drawing.Color.Aquamarine;
			this.btnmember.Location = new System.Drawing.Point(12, 118);
			this.btnmember.Name = "btnmember";
			this.btnmember.Size = new System.Drawing.Size(239, 71);
			this.btnmember.TabIndex = 1;
			this.btnmember.Text = "Loyalty Membership";
			this.btnmember.UseVisualStyleBackColor = false;
			this.btnmember.Click += new System.EventHandler(this.BtnmemberClick);
			// 
			// btntrans
			// 
			this.btntrans.BackColor = System.Drawing.Color.Aquamarine;
			this.btntrans.Location = new System.Drawing.Point(12, 208);
			this.btntrans.Name = "btntrans";
			this.btntrans.Size = new System.Drawing.Size(239, 71);
			this.btntrans.TabIndex = 2;
			this.btntrans.Text = "Transaction";
			this.btntrans.UseVisualStyleBackColor = false;
			this.btntrans.Click += new System.EventHandler(this.Button3Click);
			// 
			// btndata
			// 
			this.btndata.BackColor = System.Drawing.Color.Aquamarine;
			this.btndata.Location = new System.Drawing.Point(12, 304);
			this.btndata.Name = "btndata";
			this.btndata.Size = new System.Drawing.Size(239, 71);
			this.btndata.TabIndex = 3;
			this.btndata.Text = "Data";
			this.btndata.UseVisualStyleBackColor = false;
			this.btndata.Click += new System.EventHandler(this.BtndataClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.btndata);
			this.panel1.Controls.Add(this.btntrans);
			this.panel1.Controls.Add(this.btnmember);
			this.panel1.Controls.Add(this.btnprod);
			this.panel1.Location = new System.Drawing.Point(11, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(896, 416);
			this.panel1.TabIndex = 4;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.exitToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(928, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(497, 89);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(202, 204);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSeaGreen;
			this.ClientSize = new System.Drawing.Size(928, 475);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Home";
			this.Text = "Home";
			this.panel1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
