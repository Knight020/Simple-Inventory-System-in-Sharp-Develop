/*
 * Created by SharpDevelop.
 * User: Lorna
 * Date: 2/10/2021
 * Time: 1:20 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project101
{
	partial class transaction
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbordinary;
		private System.Windows.Forms.RadioButton rbmember;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtcid;
		private System.Windows.Forms.TextBox txtpid;
		private System.Windows.Forms.TextBox txtqp;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnprocess;
		private System.Windows.Forms.Button btnclear;
		private System.Windows.Forms.DateTimePicker datepurchased;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtprice;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnsearch;
		private System.Windows.Forms.TextBox txtsearch;
		private System.Windows.Forms.ComboBox cbsearch;
		private System.Windows.Forms.TextBox txttp;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
		
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
			this.rbordinary = new System.Windows.Forms.RadioButton();
			this.rbmember = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtcid = new System.Windows.Forms.TextBox();
			this.txtpid = new System.Windows.Forms.TextBox();
			this.txtqp = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnprocess = new System.Windows.Forms.Button();
			this.btnclear = new System.Windows.Forms.Button();
			this.datepurchased = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.txtprice = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnsearch = new System.Windows.Forms.Button();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.cbsearch = new System.Windows.Forms.ComboBox();
			this.txttp = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Customer ID:";
			// 
			// rbordinary
			// 
			this.rbordinary.Location = new System.Drawing.Point(13, 27);
			this.rbordinary.Name = "rbordinary";
			this.rbordinary.Size = new System.Drawing.Size(104, 24);
			this.rbordinary.TabIndex = 1;
			this.rbordinary.TabStop = true;
			this.rbordinary.Text = "Ordinary";
			this.rbordinary.UseVisualStyleBackColor = true;
			this.rbordinary.CheckedChanged += new System.EventHandler(this.RbordinaryCheckedChanged);
			// 
			// rbmember
			// 
			this.rbmember.Location = new System.Drawing.Point(142, 27);
			this.rbmember.Name = "rbmember";
			this.rbmember.Size = new System.Drawing.Size(104, 24);
			this.rbmember.TabIndex = 2;
			this.rbmember.TabStop = true;
			this.rbmember.Text = "Loyalty Member";
			this.rbmember.UseVisualStyleBackColor = true;
			this.rbmember.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Product ID:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Quantity Purchase:";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 191);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Date Purchased:";
			// 
			// txtcid
			// 
			this.txtcid.Location = new System.Drawing.Point(142, 62);
			this.txtcid.Name = "txtcid";
			this.txtcid.Size = new System.Drawing.Size(100, 20);
			this.txtcid.TabIndex = 6;
			// 
			// txtpid
			// 
			this.txtpid.Location = new System.Drawing.Point(142, 92);
			this.txtpid.Name = "txtpid";
			this.txtpid.Size = new System.Drawing.Size(100, 20);
			this.txtpid.TabIndex = 7;
			// 
			// txtqp
			// 
			this.txtqp.Location = new System.Drawing.Point(142, 153);
			this.txtqp.Name = "txtqp";
			this.txtqp.Size = new System.Drawing.Size(100, 20);
			this.txtqp.TabIndex = 8;
			this.txtqp.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(348, 75);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(568, 168);
			this.dataGridView1.TabIndex = 10;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// btnprocess
			// 
			this.btnprocess.Location = new System.Drawing.Point(142, 221);
			this.btnprocess.Name = "btnprocess";
			this.btnprocess.Size = new System.Drawing.Size(75, 23);
			this.btnprocess.TabIndex = 11;
			this.btnprocess.Text = "Process";
			this.btnprocess.UseVisualStyleBackColor = true;
			this.btnprocess.Click += new System.EventHandler(this.BtnprocessClick);
			// 
			// btnclear
			// 
			this.btnclear.Location = new System.Drawing.Point(230, 221);
			this.btnclear.Name = "btnclear";
			this.btnclear.Size = new System.Drawing.Size(75, 23);
			this.btnclear.TabIndex = 12;
			this.btnclear.Text = "Clear";
			this.btnclear.UseVisualStyleBackColor = true;
			this.btnclear.Click += new System.EventHandler(this.BtnclearClick);
			// 
			// datepurchased
			// 
			this.datepurchased.Location = new System.Drawing.Point(142, 185);
			this.datepurchased.Name = "datepurchased";
			this.datepurchased.Size = new System.Drawing.Size(200, 20);
			this.datepurchased.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Product Price:";
			// 
			// txtprice
			// 
			this.txtprice.Location = new System.Drawing.Point(142, 122);
			this.txtprice.Name = "txtprice";
			this.txtprice.Size = new System.Drawing.Size(100, 20);
			this.txtprice.TabIndex = 15;
			this.txtprice.TextChanged += new System.EventHandler(this.TxtpriceTextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(348, 49);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "Search By:";
			// 
			// btnsearch
			// 
			this.btnsearch.Location = new System.Drawing.Point(668, 43);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(75, 23);
			this.btnsearch.TabIndex = 17;
			this.btnsearch.Text = "Search";
			this.btnsearch.UseVisualStyleBackColor = true;
			this.btnsearch.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtsearch
			// 
			this.txtsearch.Location = new System.Drawing.Point(562, 46);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(100, 20);
			this.txtsearch.TabIndex = 18;
			this.txtsearch.TextChanged += new System.EventHandler(this.TxtsearchTextChanged);
			// 
			// cbsearch
			// 
			this.cbsearch.FormattingEnabled = true;
			this.cbsearch.Items.AddRange(new object[] {
			"Customer ID",
			"First Name",
			"Last Name"});
			this.cbsearch.Location = new System.Drawing.Point(435, 46);
			this.cbsearch.Name = "cbsearch";
			this.cbsearch.Size = new System.Drawing.Size(121, 21);
			this.cbsearch.TabIndex = 19;
			// 
			// txttp
			// 
			this.txttp.Location = new System.Drawing.Point(250, 75);
			this.txttp.Name = "txttp";
			this.txttp.Size = new System.Drawing.Size(71, 20);
			this.txttp.TabIndex = 20;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(248, 49);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 23);
			this.label7.TabIndex = 21;
			this.label7.Text = "Total Points:";
			this.label7.Click += new System.EventHandler(this.Label7Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.homeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(928, 24);
			this.menuStrip1.TabIndex = 22;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// homeToolStripMenuItem
			// 
			this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
			this.homeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.homeToolStripMenuItem.Text = "Back";
			this.homeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItemClick);
			// 
			// transaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumAquamarine;
			this.ClientSize = new System.Drawing.Size(928, 475);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txttp);
			this.Controls.Add(this.cbsearch);
			this.Controls.Add(this.txtsearch);
			this.Controls.Add(this.btnsearch);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtprice);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.datepurchased);
			this.Controls.Add(this.btnclear);
			this.Controls.Add(this.btnprocess);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtqp);
			this.Controls.Add(this.txtpid);
			this.Controls.Add(this.txtcid);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.rbmember);
			this.Controls.Add(this.rbordinary);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "transaction";
			this.Text = "Transaction";
			this.Load += new System.EventHandler(this.Form2Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
