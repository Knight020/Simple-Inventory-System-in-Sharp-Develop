/*
 * Created by SharpDevelop.
 * User: Lorna
 * Date: 2/11/2021
 * Time: 1:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project101
{
	/// <summary>
	/// Description of Data.
	/// </summary>
	public partial class Data : Form
	{
		String MyConnection = "datasource=localhost;Database=inventory;username=root";
		public Data()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void DataLoad(object sender, EventArgs e)
		{
			String Query1 = "select * from loyalty ";
            MySqlConnection MyConn1 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand1;
            DataSet ds = new DataSet();  
            MyAdapter.Fill(ds, "loyalty");  
            dataGridView1.DataSource = ds.Tables["loyalty"].DefaultView;
            
            String Query2 = "select * from product ";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand2 = new MySqlCommand(Query2, MyConn2);
            MySqlDataAdapter MyAdapter2 = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            MyAdapter.Fill(ds, "product");  
            dataGridView2.DataSource = ds.Tables["product"].DefaultView; 
            
            String Query3 = "select * from transaction ";
            MySqlConnection MyConn3 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand3 = new MySqlCommand(Query3, MyConn3);
            MySqlDataAdapter MyAdapter3 = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand3; 
            MyAdapter.Fill(ds, "transaction");  
            dataGridView3.DataSource = ds.Tables["transaction"].DefaultView; 
		}
		void DataGridView2CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void BackToolStripMenuItemClick(object sender, EventArgs e)
		{
			Home form = new Home();
			form.Show();
			this.Hide();
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void DataGridView3CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
	}
}
