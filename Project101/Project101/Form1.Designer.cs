/*
 * Created by SharpDevelop.
 * User: Lorna
 * Date: 2/8/2021
 * Time: 1:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project101
{
	partial class loyalty
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtcid;
		private System.Windows.Forms.TextBox txtfn;
		private System.Windows.Forms.TextBox txtnumber;
		private System.Windows.Forms.TextBox txtaddress;
		private System.Windows.Forms.DateTimePicker dateregistered;
		private System.Windows.Forms.TextBox txtln;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.Button btnclear;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtpoints;
		private System.Windows.Forms.DataGridView dataGridView1;
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
			this.label5 = new System.Windows.Forms.Label();
			this.txtcid = new System.Windows.Forms.TextBox();
			this.txtfn = new System.Windows.Forms.TextBox();
			this.txtnumber = new System.Windows.Forms.TextBox();
			this.txtaddress = new System.Windows.Forms.TextBox();
			this.dateregistered = new System.Windows.Forms.DateTimePicker();
			this.txtln = new System.Windows.Forms.TextBox();
			this.btnadd = new System.Windows.Forms.Button();
			this.btnupdate = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.btnclear = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtpoints = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Customer ID:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(25, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Customer Name:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(25, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Contact Number:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(353, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Address:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(353, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Date Registered:";
			// 
			// txtcid
			// 
			this.txtcid.Enabled = false;
			this.txtcid.Location = new System.Drawing.Point(119, 36);
			this.txtcid.Name = "txtcid";
			this.txtcid.Size = new System.Drawing.Size(100, 20);
			this.txtcid.TabIndex = 5;
			// 
			// txtfn
			// 
			this.txtfn.Location = new System.Drawing.Point(119, 74);
			this.txtfn.Name = "txtfn";
			this.txtfn.Size = new System.Drawing.Size(100, 20);
			this.txtfn.TabIndex = 6;
			this.txtfn.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// txtnumber
			// 
			this.txtnumber.Location = new System.Drawing.Point(119, 107);
			this.txtnumber.Name = "txtnumber";
			this.txtnumber.Size = new System.Drawing.Size(100, 20);
			this.txtnumber.TabIndex = 7;
			// 
			// txtaddress
			// 
			this.txtaddress.Location = new System.Drawing.Point(477, 36);
			this.txtaddress.Name = "txtaddress";
			this.txtaddress.Size = new System.Drawing.Size(100, 20);
			this.txtaddress.TabIndex = 8;
			this.txtaddress.TextChanged += new System.EventHandler(this.TextBox4TextChanged);
			// 
			// dateregistered
			// 
			this.dateregistered.Location = new System.Drawing.Point(477, 65);
			this.dateregistered.Name = "dateregistered";
			this.dateregistered.Size = new System.Drawing.Size(206, 20);
			this.dateregistered.TabIndex = 9;
			// 
			// txtln
			// 
			this.txtln.Location = new System.Drawing.Point(225, 74);
			this.txtln.Name = "txtln";
			this.txtln.Size = new System.Drawing.Size(100, 20);
			this.txtln.TabIndex = 10;
			this.txtln.TextChanged += new System.EventHandler(this.TxtlnTextChanged);
			// 
			// btnadd
			// 
			this.btnadd.Location = new System.Drawing.Point(119, 143);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(75, 23);
			this.btnadd.TabIndex = 11;
			this.btnadd.Text = "Add";
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.BtnaddClick);
			// 
			// btnupdate
			// 
			this.btnupdate.Location = new System.Drawing.Point(250, 143);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(75, 23);
			this.btnupdate.TabIndex = 12;
			this.btnupdate.Text = "Update";
			this.btnupdate.UseVisualStyleBackColor = true;
			this.btnupdate.Click += new System.EventHandler(this.BtnupdateClick);
			// 
			// btndelete
			// 
			this.btndelete.Location = new System.Drawing.Point(378, 143);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(75, 23);
			this.btndelete.TabIndex = 13;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = true;
			this.btndelete.Click += new System.EventHandler(this.BtndeleteClick);
			// 
			// btnclear
			// 
			this.btnclear.Location = new System.Drawing.Point(512, 143);
			this.btnclear.Name = "btnclear";
			this.btnclear.Size = new System.Drawing.Size(75, 23);
			this.btnclear.TabIndex = 14;
			this.btnclear.Text = "Clear";
			this.btnclear.UseVisualStyleBackColor = true;
			this.btnclear.Click += new System.EventHandler(this.BtnclearClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(353, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "Total Points:";
			// 
			// txtpoints
			// 
			this.txtpoints.Location = new System.Drawing.Point(477, 101);
			this.txtpoints.Name = "txtpoints";
			this.txtpoints.Size = new System.Drawing.Size(100, 20);
			this.txtpoints.TabIndex = 16;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(25, 194);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(762, 252);
			this.dataGridView1.TabIndex = 17;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.backToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(928, 24);
			this.menuStrip1.TabIndex = 18;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// backToolStripMenuItem
			// 
			this.backToolStripMenuItem.Name = "backToolStripMenuItem";
			this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.backToolStripMenuItem.Text = "Back";
			this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItemClick);
			// 
			// loyalty
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumAquamarine;
			this.ClientSize = new System.Drawing.Size(928, 475);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtpoints);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnclear);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.txtln);
			this.Controls.Add(this.dateregistered);
			this.Controls.Add(this.txtaddress);
			this.Controls.Add(this.txtnumber);
			this.Controls.Add(this.txtfn);
			this.Controls.Add(this.txtcid);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "loyalty";
			this.Text = "Loyalty Membership";
			this.Load += new System.EventHandler(this.Form1Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
