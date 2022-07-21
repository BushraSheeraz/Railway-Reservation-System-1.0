using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_Reservation_System
{
    public partial class ReservationMaster : Form
    {
        public ReservationMaster()
        {
            InitializeComponent();
            populate();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Affan\Downloads\Railway Reservation System\Railway Reservation System\Database\Railwaysdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            DbConnection.con.Open();
            string query = "Select * from ReservationTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, DbConnection.con);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            DbConnection.con.Close();
        }


        private void Addreservationbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DbConnection.con.Open();
                string Query = "Insert into ReservationTbl values('" + dd_passenger.SelectedValue + "','" + dd_passenger.Text + "','" + dd_travel.Text + "','" + dateTimePicker1.Value + "','" + txt_source.Text + "','" + txt_destination.Text + "','" + txt_cost.Text + "','Active')";
                SqlCommand cmd = new SqlCommand(Query, DbConnection.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Reservation Added Successfully");
                DbConnection.con.Close();
                populate();
                // ResetValues();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                DbConnection.con.Close();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ReservationMaster_Load(object sender, EventArgs e)
        {
            DbConnection.con.Open();
            string query = "Select Pid,Pname from PassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, DbConnection.con);
            var ds = new DataSet();
            sda.Fill(ds);
            dd_passenger.DisplayMember = "Pname";
            dd_passenger.ValueMember = "Pid";
            dd_passenger.DataSource = ds.Tables[0];


            string query1 = "Select TravCode from TravelTbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, DbConnection.con);
            var ds1 = new DataSet();
            sda1.Fill(ds1);
            dd_travel.DisplayMember = "TravCode";
            dd_travel.ValueMember = "TravDate";
            dd_travel.DataSource = ds1.Tables[0];

            DbConnection.con.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dd_travel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbConnection.con.Close();
            DbConnection.con.Open();
            string td = dd_travel.SelectedText.ToString();
            string query = "Select * from TravelTbl where TravCode='" + td + "'";
            SqlCommand Comm1 = new SqlCommand(query, DbConnection.con);
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                txt_source.Text = DR1.GetValue(3).ToString();
                txt_destination.Text = DR1.GetValue(4).ToString();
                txt_cost.Text = DR1.GetValue(5).ToString();
                dateTimePicker1.Value = Convert.ToDateTime(DR1.GetValue(1));
            }
            DbConnection.con.Close();
        }

       
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count==1)
            {

                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Tickets ticket = new Tickets(id);
                ticket.Show();

            }
            else
            {
                MessageBox.Show("Select a reservation to print ticket");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Mainform formMain = new Mainform();
            this.Hide();
            formMain.Show();
        }
        

        
    }
}
