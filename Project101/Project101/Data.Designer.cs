/*
 * Created by SharpDevelop.
 * User: Lorna
 * Date: 2/11/2021
 * Time: 1:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project101
{
	partial class Data
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView3;
		
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 68);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(699, 195);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.backToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1196, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// backToolStripMenuItem
			// 
			this.backToolStripMenuItem.Name = "backToolStripMenuItem";
			this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.backToolStripMenuItem.Text = "Back";
			this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItemClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Aqua;
			this.label1.Location = new System.Drawing.Point(296, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Loyalty Membership";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Aqua;
			this.label2.Location = new System.Drawing.Point(910, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Product";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(717, 68);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(479, 195);
			this.dataGridView2.TabIndex = 5;
			this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2CellContentClick);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Aqua;
			this.label3.Location = new System.Drawing.Point(296, 272);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Transaction";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(12, 298);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(699, 245);
			this.dataGridView3.TabIndex = 7;
			this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3CellContentClick);
			// 
			// Data
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumAquamarine;
			this.ClientSize = new System.Drawing.Size(1196, 729);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Data";
			this.Text = "Data";
			this.Load += new System.EventHandler(this.DataLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
