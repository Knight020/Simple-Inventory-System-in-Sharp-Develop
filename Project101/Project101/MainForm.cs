/*
 * Created by SharpDevelop.
 * User: Lorna
 * Date: 2/6/2021
 * Time: 12:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project101
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class products : Form
	{
		
		
		// disable once ConvertToConstant.Local
		String MyConnection = "datasource=localhost;Database=inventory;username=root";
		
		
		public products()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
	        String Query = "select * from product ";
            MySqlConnection MyConn = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand;
            DataSet ds = new DataSet();  
            MyAdapter.Fill(ds, "product");  
            dataGridView1.DataSource = ds.Tables["product"].DefaultView; 

           
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void BtnaddClick(object sender, EventArgs e)
		{
			String Query = "insert into product(product_id, product_name, product_price, product_stocks) values('" + this.txtpid.Text + "','" + this.txtpname.Text + "','" + this.txtprice.Text + "','" + this.txtstock.Text + "');";
            MySqlConnection Myconn = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand = new MySqlCommand(Query, Myconn);
            MySqlDataReader MyReader;
            Myconn.Open();
            MyReader = MyCommand.ExecuteReader();
            MessageBox.Show("New product added successfully");
            txtpid.Clear();
            txtpname.Clear();
            txtprice.Clear();
            txtstock.Clear();
            
            String Query1 = "select * from product ";
            MySqlConnection MyConn1 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand1;
            DataSet ds = new DataSet();  
            MyAdapter.Fill(ds, "product");  
            dataGridView1.DataSource = ds.Tables["product"].DefaultView; 
		}
		void BtnupdateClick(object sender, EventArgs e)
		{
	        try 
            { 
               
 
               
                string Query = "update product set product_name='" + this.txtpname.Text + "',product_price='" + 
this.txtprice.Text + "',product_stocks='" + this.txtstock.Text + "' where product_id='" + this.txtpid.Text + "';"; 
 
               
                MySqlConnection MyConn = new MySqlConnection(MyConnection); 
 
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn); 
                MySqlDataReader MyReader2; 
                MyConn.Open(); 
                MyReader2 = MyCommand.ExecuteReader();
                MessageBox.Show("Data has been Updated"); 
              
                /* 
                while (MyReader2.Read())  
                {  
 
                }  
                */ 
                MyConn.Close(); 
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            } 
            txtpid.Clear();
            txtpname.Clear();
            txtprice.Clear();
            txtstock.Clear();
            String Query3 = "select * from product ";
            MySqlConnection MyConn3 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand3 = new MySqlCommand(Query3, MyConn3);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand3;
            DataSet ds = new DataSet();  
            MyAdapter.Fill(ds, "product");  
            dataGridView1.DataSource = ds.Tables["product"].DefaultView; 
		}
		void BtndeleteClick(object sender, EventArgs e)
		{
	           try
            {
               
                DialogResult result1 = MessageBox.Show("Are you sure you want to delete record?", "Important Question",
MessageBoxButtons.YesNo);
                string Query = "";
                if (result1.Equals(DialogResult.Yes))
                {
                    Query = "delete from product where product_id='" + this.txtpid.Text + "';";
                }
                else
                {
                    MessageBox.Show("Nothing happens");
                }

                  
                MySqlConnection MyConn = new MySqlConnection(MyConnection);

                 
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader2; MyConn.Open();
                MyReader2 = MyCommand.ExecuteReader();
                //database.
                                MessageBox.Show("Data has been deleted");
       
                
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            txtpid.Clear();
            txtpname.Clear();
            txtprice.Clear();
            txtstock.Clear();
            String Query2 = "select * from product ";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand2 = new MySqlCommand(Query2, MyConn2);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataSet ds = new DataSet();  
            MyAdapter.Fill(ds, "product");  
            dataGridView1.DataSource = ds.Tables["product"].DefaultView; 
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataTable dt = new DataTable();
			 
			dt = new DataTable();
			//create our SQL SELECT statement
			string Query3 = "Select * from product";
			MySqlConnection MyConn3 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand3 = new MySqlCommand(Query3, MyConn3);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand3;
			//we fill the result to dt which declared above as datatable
			MyAdapter.Fill(dt);
			//then we populate the datagridview by specifying the datasource equal to dt
			dataGridView1.DataSource = dt;

			if (e.RowIndex >= 0)
				{
    				//gets a collection that contains all the rows
    				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
   					//populate the textbox from specific value of the coordinates of column and row.
					txtpid.Text = row.Cells["product_id"].Value.ToString();
					txtpname.Text = row.Cells["product_name"].Value.ToString();
					txtprice.Text = row.Cells["product_price"].Value.ToString();
					txtstock.Text = row.Cells["product_stocks"].Value.ToString();
				
				
				}
				
                
			 
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void BtnclearClick(object sender, EventArgs e)
		{
			txtpid.Clear();
			txtpname.Clear();
			txtprice.Clear();
			txtstock.Clear();
		}
		void BackToolStripMenuItemClick(object sender, EventArgs e)
		{
			Home form = new Home();
			form.Show();
			this.Hide();
		}
	}
}
