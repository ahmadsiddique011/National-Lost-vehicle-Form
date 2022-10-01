using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace NEW_MOD_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-7S4UCS9A\\SQLEXPRESS01;Initial Catalog=LLLOST_VEHICLESSSS;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string Query = "insert into CLIENT(Name_, ADDRESS_, CITY, CNIC, CELL_NO) values ('" + this.name.Text + "','" + this.address.Text + "','" + this.city.Text + "','" + this.cnic.Text + "','" + this.cellno.Text + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Client Details Saved Successfully");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-7S4UCS9A\\SQLEXPRESS01;Initial Catalog=LLLOST_VEHICLESSSS;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string Query = "insert into Company(COMP_NAME, MODEL , CHASSIS , YEAR_PURCHASE , OWNED_BY,  Cnic_client) values ('" + this.companyname.Text + "','" + this.model.Text + "','" + this.chassisno.Text + "','" + this.yearofpurchase.Text + "','" + this.ownedby.Text + "','" + this.ccnic.Text + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Saved Successfully.");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-7S4UCS9A\\SQLEXPRESS01;Initial Catalog=LLLOST_VEHICLESSSS;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string Query = "insert into INCIDENT(INC_DATE, INC_ADDRESS , FIR_DATE , NAME_STATION , FIR_NO, CNIC_client) values ('" + this.i_date.Text + "','" + this.i_address.Text + "','" + this.fir_date.Text + "','" + this.p_station.Text + "','" + this.fir_no.Text + "', '" + this.i_cnic.Text + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Car Found Successfully.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=LAPTOP-7S4UCS9A\\SQLEXPRESS01;Initial Catalog=LLLOST_VEHICLESSSS;Integrated Security=True";
                //Display query  
                string Query = "select * from CLIENT, COMPANY, INCIDENT;";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-7S4UCS9A\\SQLEXPRESS01;Initial Catalog=LLLOST_VEHICLESSSS;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string Query = "UPDATE INCIDENT SET INC_DATE = '" + i_date.Text + "', INC_ADDRESS = '" + i_address.Text + "', FIR_DATE = '" + fir_date.Text + "', NAME_STATION = '" + p_station.Text + "', FIR_NO = '" + fir_no + "' where CNIC_client = '" + i_cnic.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Record updated successfully");
            con.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-7S4UCS9A\\SQLEXPRESS01;Initial Catalog=LLLOST_VEHICLESSSS;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string Query = "UPDATE CLIENT SET NAME_ = '" + name.Text + "', ADDRESS_ = '" + address.Text + "', CITY = '" + city.Text + "', CELL_NO = '" + cellno.Text + "' where CNIC = '" + cnic.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Record updated successfully");
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-7S4UCS9A\\SQLEXPRESS01;Initial Catalog=LLLOST_VEHICLESSSS;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string query = "DELETE FROM CLIENT where CNIC = '" + cnic.Text + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record deleted successfully.");
            con.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-7S4UCS9A\\SQLEXPRESS01;Initial Catalog=LLLOST_VEHICLESSSS;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string Query = "UPDATE COMPANY SET COMP_NAME = '" + companyname.Text + "', MODEL = '" + model.Text + "', CHASSIS = '" + chassisno.Text + "', YEAR_PURCHASE = '" + yearofpurchase.Text + "', OWNED_BY = '" + ownedby + "' where Cnic_client = '" + ccnic.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Record updated successfully");
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-7S4UCS9A\\SQLEXPRESS01;Initial Catalog=LLLOST_VEHICLESSSS;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string query = "DELETE FROM COMPANY where CNIC_client = '" + ccnic.Text + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record deleted successfully.");
            con.Close();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-7S4UCS9A\\SQLEXPRESS01;Initial Catalog=LLLOST_VEHICLESSSS;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string query = "DELETE FROM INCIDENT where CNIC_client = '" + i_cnic.Text + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record deleted successfully.");
            con.Close();
        }

        private void ccnic_TextChanged(object sender, EventArgs e)
        {

         }
    }
}

