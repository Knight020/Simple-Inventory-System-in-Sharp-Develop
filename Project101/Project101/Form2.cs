/*
 * Created by SharpDevelop.
 * User: Lorna
 * Date: 2/10/2021
 * Time: 1:20 AM
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
	/// Description of Form2.
	/// </summary>
	public partial class transaction : Form
	{
		
		String MyConnection = "datasource=localhost;Database=inventory;username=root";
		public transaction()
		{
			
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			if(rbmember.Checked)
			{
			label1.Text = "Customer ID";
			label6.Text = "Search By:";
			label7.Text = "Points:";
			txttp.Text = "0";
			dataGridView1.Columns.Clear();
			txtcid.Clear();
			txtcid.Visible = true;
			txtsearch.Visible = true;
			btnsearch.Visible = true;
			txttp.Visible = true;
			txttp.Text = "0";
			cbsearch.Visible = true;
			String Query1 = "select * from loyalty ";
            MySqlConnection MyConn1 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand1;
            DataSet ds = new DataSet();  
            MyAdapter.Fill(ds, "loyalty");  
            dataGridView1.DataSource = ds.Tables["loyalty"].DefaultView;
			}
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
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
					txttp.Text = row.Cells["points"].Value.ToString();
					
				
				
				}
		}
		void RbordinaryCheckedChanged(object sender, EventArgs e)
		{
			if(rbordinary.Checked)
			{
				dataGridView1.Columns.Clear();
				label1.Text = "";
				txtcid.Clear();
				txtcid.Visible = false;
				label6.Text = "";
				txtsearch.Visible = false;
				btnsearch.Visible = false;
				label7.Text = "";
				txttp.Visible = false;
				txttp.Text = "0";
				cbsearch.Visible = false;
			}
		}
		void BtnclearClick(object sender, EventArgs e)
		{
			dataGridView1.Columns.Clear();
			rbordinary.Checked = false;
			rbmember.Checked = false;
			txtcid.Clear();
			txtpid.Clear();
			txtqp.Clear();
			txtprice.Clear();
			txttp.Clear();
			txtsearch.Clear();
			cbsearch.ResetText();
			datepurchased.Value = DateTime.Now;
		}
		void BtnprocessClick(object sender, EventArgs e)
		{
			
			double price = double.Parse(txtprice.Text);
			double quantity = double.Parse(txtqp.Text);
			double tp = double.Parse(txttp.Text);
			double total = price * quantity;
			double points = total / 50;
			double total1 = tp + points;
			
			
			
			try{
				
				string type;
				if(rbmember.Checked)
				{
					type = "member";
			String date = datepurchased.Value.ToString("yyyy-MM-dd");
			String Query = "insert into transaction(customer_id, product_id, price, quantity, date_purchased, type, points_earned) values('" + this.txtcid.Text + "','" + this.txtpid.Text.ToString() + "','" + this.txtprice.Text.ToString() + "','" + this.txtqp.Text.ToString() + "','"+ date + "','" + type + "','" + points + "');";
            MySqlConnection Myconn = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand = new MySqlCommand(Query, Myconn);
            MySqlDataReader MyReader;
            Myconn.Open();
            MyReader = MyCommand.ExecuteReader();
            MessageBox.Show("Process Done");
            
			
			
            dataGridView1.Columns.Clear();
            rbordinary.Checked = false;
			rbmember.Checked = false;
			txtcid.Clear();
			txtpid.Clear();
			txtqp.Clear();
			txtprice.Clear();
			txttp.Clear();
			datepurchased.Value = DateTime.Now;
			
				}
				else
				{
					
					type = "ordinary";
			String date = datepurchased.Value.ToString("yyyy-MM-dd");
			String Query = "insert into transaction(customer_id, product_id, price, quantity, date_purchased, type, points_earned) values('" + "null" + "','" + this.txtpid.Text.ToString() + "','" + this.txtprice.Text.ToString() + "','" + this.txtqp.Text.ToString() + "','"+ date + "','" + type + "','" + "null" + "');";
            MySqlConnection Myconn = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand = new MySqlCommand(Query, Myconn);
            MySqlDataReader MyReader;
            Myconn.Open();
            MyReader = MyCommand.ExecuteReader();
            MessageBox.Show("Process Done");
            
			
			
            dataGridView1.Columns.Clear();
            rbordinary.Checked = false;
			rbmember.Checked = false;
			txtcid.Clear();
			txtpid.Clear();
			txtqp.Clear();
			txtprice.Clear();
			txttp.Clear();
			datepurchased.Value = DateTime.Now;
				}
				
            
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		void TxtpriceTextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			try
            {
                String str = cbsearch.SelectedItem.ToString();
                String str1;
                String Query = "";
                if (str.Equals("Customer ID"))
                {
                    str1 = "customer_id";
                }
                else if (str.Equals("First Name"))
                {
                    str1 = "first_name";
                    
                
                }
                else
                {
                    str1 = "last_name";
                }

                Query = "Select * from loyalty where " + str1 + " = '" + txtsearch.Text + "'";
                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(Query, Myconn);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();

                MyAdapter.SelectCommand = MyCommand;
                DataTable dtable = new DataTable();
                MyAdapter.Fill(dtable);
                dataGridView1.DataSource = dtable;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
		}
		void TxtsearchTextChanged(object sender, EventArgs e)
		{
	
		}
		void Label7Click(object sender, EventArgs e)
		{
	
		}
		void Form2Load(object sender, EventArgs e)
		{
	
		}
		void HomeToolStripMenuItemClick(object sender, EventArgs e)
		{
			Home form = new Home();
			form.Show();
			this.Hide();
		}
	}
}
