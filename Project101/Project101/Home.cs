/*
 * Created by SharpDevelop.
 * User: Lorna
 * Date: 2/11/2021
 * Time: 12:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project101
{
	/// <summary>
	/// Description of Home.
	/// </summary>
	public partial class Home : Form
	{
		public Home()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			products form = new products();
			form.Show();
			this.Hide();
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			transaction form = new transaction();
			form.Show();
			this.Hide();
		}
		void BtnmemberClick(object sender, EventArgs e)
		{
			loyalty form = new loyalty();
			form.Show();
			this.Hide();
		}
		void BtndataClick(object sender, EventArgs e)
		{
			Data form = new Data();
			form.Show();
			this.Hide();
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
	
		}
	}
}
