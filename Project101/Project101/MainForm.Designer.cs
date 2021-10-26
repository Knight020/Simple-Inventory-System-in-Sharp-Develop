/*
 * Created by SharpDevelop.
 * User: Lorna
 * Date: 2/6/2021
 * Time: 12:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project101
{
	partial class products
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtpid;
		private System.Windows.Forms.TextBox txtpname;
		private System.Windows.Forms.TextBox txtprice;
		private System.Windows.Forms.TextBox txtstock;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnclear;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtpid = new System.Windows.Forms.TextBox();
			this.txtpname = new System.Windows.Forms.TextBox();
			this.txtprice = new System.Windows.Forms.TextBox();
			this.txtstock = new System.Windows.Forms.TextBox();
			this.btnadd = new System.Windows.Forms.Button();
			this.btnupdate = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnclear = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Product ID:";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Product Name:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Price:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Stock:";
			// 
			// txtpid
			// 
			this.txtpid.Enabled = false;
			this.txtpid.Location = new System.Drawing.Point(132, 34);
			this.txtpid.Name = "txtpid";
			this.txtpid.Size = new System.Drawing.Size(199, 20);
			this.txtpid.TabIndex = 4;
			// 
			// txtpname
			// 
			this.txtpname.Location = new System.Drawing.Point(132, 73);
			this.txtpname.Name = "txtpname";
			this.txtpname.Size = new System.Drawing.Size(199, 20);
			this.txtpname.TabIndex = 5;
			// 
			// txtprice
			// 
			this.txtprice.Location = new System.Drawing.Point(132, 114);
			this.txtprice.Name = "txtprice";
			this.txtprice.Size = new System.Drawing.Size(199, 20);
			this.txtprice.TabIndex = 6;
			// 
			// txtstock
			// 
			this.txtstock.Location = new System.Drawing.Point(132, 153);
			this.txtstock.Name = "txtstock";
			this.txtstock.Size = new System.Drawing.Size(199, 20);
			this.txtstock.TabIndex = 7;
			// 
			// btnadd
			// 
			this.btnadd.Location = new System.Drawing.Point(13, 192);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(75, 23);
			this.btnadd.TabIndex = 8;
			this.btnadd.Text = "Add";
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.BtnaddClick);
			// 
			// btnupdate
			// 
			this.btnupdate.Location = new System.Drawing.Point(94, 192);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(75, 23);
			this.btnupdate.TabIndex = 9;
			this.btnupdate.Text = "Update";
			this.btnupdate.UseVisualStyleBackColor = true;
			this.btnupdate.Click += new System.EventHandler(this.BtnupdateClick);
			// 
			// btndelete
			// 
			this.btndelete.Location = new System.Drawing.Point(175, 192);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(75, 23);
			this.btndelete.TabIndex = 10;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = true;
			this.btndelete.Click += new System.EventHandler(this.BtndeleteClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(337, 34);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(579, 181);
			this.dataGridView1.TabIndex = 11;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// btnclear
			// 
			this.btnclear.Location = new System.Drawing.Point(256, 192);
			this.btnclear.Name = "btnclear";
			this.btnclear.Size = new System.Drawing.Size(75, 23);
			this.btnclear.TabIndex = 12;
			this.btnclear.Text = "Clear";
			this.btnclear.UseVisualStyleBackColor = true;
			this.btnclear.Click += new System.EventHandler(this.BtnclearClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.backToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(928, 24);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// backToolStripMenuItem
			// 
			this.backToolStripMenuItem.Name = "backToolStripMenuItem";
			this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.backToolStripMenuItem.Text = "Back";
			this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItemClick);
			// 
			// products
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumAquamarine;
			this.ClientSize = new System.Drawing.Size(928, 475);
			this.Controls.Add(this.btnclear);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.txtstock);
			this.Controls.Add(this.txtprice);
			this.Controls.Add(this.txtpname);
			this.Controls.Add(this.txtpid);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "products";
			this.Text = "Products";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
