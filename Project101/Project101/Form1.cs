/*
 * Created by SharpDevelop.
 * User: Lorna
 * Date: 2/8/2021
 * Time: 1:43 PM
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
	/// Description of Form1.
	/// </summary>
	public partial class loyalty : Form
		
	{
		String MyConnection = "datasource=localhost;Database=inventory;username=root";
		public loyalty()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			String Query1 = "select * from loyalty ";
            MySqlConnection MyConn1 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand1;
            DataSet ds = new DataSet();  
            MyAdapter.Fill(ds, "loyalty");  
            dataGridView1.DataSource = ds.Tables["loyalty"].DefaultView;
			
			txtfn.Text = "First Name";
			txtln.Text = "Last Name";
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
			
			if(txtfn.Text=="First Name")
            {
                txtfn.Text = "";
            }
			

		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
	
		}
		void Form1Load(object sender, EventArgs e)
		{
			txtfn.Text = "First Name";
			txtln.Text = "Last Name";

		}
		void TxtlnTextChanged(object sender, EventArgs e)
		{
			if(txtln.Text=="Last Name")
            {
                txtln.Text = "";
            }
		}
		void BtnaddClick(object sender, EventArgs e)
		{
		try{
			String date = dateregistered.Value.ToString("yyyy-MM-dd");
			String Query = "insert into Loyalty(customer_id, first_name, last_name, contact, address, registered, points) values('" + this.txtcid.Text + "','" + this.txtfn.Text + "','" + this.txtln.Text + "','" + this.txtnumber.Text + "','"+ this.txtaddress.Text + "','" + date + "','" + this.txtpoints.Text + "');";
            MySqlConnection Myconn = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand = new MySqlCommand(Query, Myconn);
            MySqlDataReader MyReader;
            Myconn.Open();
            MyReader = MyCommand.ExecuteReader();
            MessageBox.Show("New member has been added successfully");
            txtcid.Clear();
            txtfn.Clear();
            txtln.Clear();
            txtnumber.Clear();
            txtaddress.Clear();
            dateregistered.Value = DateTime.Now;
            txtpoints.Clear();
            String Query1 = "select * from loyalty ";
            MySqlConnection MyConn1 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand1;
            DataSet ds = new DataSet();  
            MyAdapter.Fill(ds, "loyalty");  
            dataGridView1.DataSource = ds.Tables["loyalty"].DefaultView;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		void BtnupdateClick(object sender, EventArgs e)
		{
			try 
            { 
               
 					String date = dateregistered.Value.ToString("yyyy-MM-dd");
               
                string Query = "update loyalty set first_name='" + this.txtfn.Text + "',last_name='" + 
this.txtln.Text + "',contact='" + this.txtnumber.Text + "',address='"+ this.txtaddress.Text + "',registered='" + date +"',points='" + this.txtpoints.Text +"' where customer_id='" + this.txtcid.Text + "';"; 
 
               
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
            txtcid.Clear();
            txtfn.Clear();
            txtln.Clear();
            txtnumber.Clear();
            txtaddress.Clear();
            dateregistered.Value = DateTime.Now;
            txtpoints.Clear();
           
            String Query3 = "select * from loyalty ";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand2 = new MySqlCommand(Query3, MyConn2);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataSet ds = new DataSet();  
            MyAdapter.Fill(ds, "loyalty");  
            dataGridView1.DataSource = ds.Tables["loyalty"].DefaultView; 
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
                    Query = "delete from loyalty where customer_id='" + this.txtcid.Text + "';";
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
            txtcid.Clear();
            txtfn.Clear();
            txtln.Clear();
            txtnumber.Clear();
            txtaddress.Clear();
            dateregistered.Value = DateTime.Now;
            txtpoints.Clear();
            String Query3 = "select * from loyalty ";
            MySqlConnection MyConn3 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand3 = new MySqlCommand(Query3, MyConn3);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand3;
            DataSet ds = new DataSet();  
            MyAdapter.Fill(ds, "loyalty");  
            dataGridView1.DataSource = ds.Tables["loyalty"].DefaultView; 
		}
		void BtnclearClick(object sender, EventArgs e)
		{
			txtcid.Clear();
            txtfn.Clear();
            txtln.Clear();
            txtnumber.Clear();
            txtaddress.Clear();
            dateregistered.Value = DateTime.Now;
            txtpoints.Clear();
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
			DataTable dt = new DataTable();
			 
			dt = new DataTable();
			//create our SQL SELECT statement
			string Query4 = "Select * from loyalty";
			MySqlConnection MyConn4 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand4 = new MySqlCommand(Query4, MyConn4);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand4;
			//we fill the result to dt which declared above as datatable
			MyAdapter.Fill(dt);
			//then we populate the datagridview by specifying the datasource equal to dt
			dataGridView1.DataSource = dt;

			if (e.RowIndex >= 0)
				{
    				//gets a collection that contains all the rows
    				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
   					//populate the textbox from specific value of the coordinates of column and row.
					txtcid.Text = row.Cells["customer_id"].Value.ToString();
					txtfn.Text = row.Cells["first_name"].Value.ToString();
					txtln.Text = row.Cells["last_name"].Value.ToString();
					txtnumber.Text = row.Cells["contact"].Value.ToString();
					txtaddress.Text = row.Cells["address"].Value.ToString();
					dateregistered.Text = row.Cells["registered"].Value.ToString();
					txtpoints.Text = row.Cells["points"].Value.ToString();
				
				
				}
				
		}
		void BackToolStripMenuItemClick(object sender, EventArgs e)
		{
			Home form = new Home();
			form.Show();
			this.Hide();
		}
	}
}
