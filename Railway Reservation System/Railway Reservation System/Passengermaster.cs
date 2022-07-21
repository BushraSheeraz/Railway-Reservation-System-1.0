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


namespace Railway_Reservation_System
{
    public partial class Passengermaster : Form
    {

        public Passengermaster()
        {

            InitializeComponent();

            {
            }

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Affan\Downloads\Railway Reservation System\Railway Reservation System\Database\Railwaysdb.mdf;Integrated Security=True;Connect Timeout=30");

            {
                con.Open();
                string query = "Select * from Passengertbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void populate()
        {
            con.Open();
            string query = "Select * from Passengertbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (PsngrNtb.Text == "" || PsngrPno.Text == "" || PsngrAtb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else

            {
                if (Malerb.Checked == true)
                    Gender = " Male";

                else if (Femalerb.Checked == true)
                {
                    Gender = " Female";

                }
                    try
                    {
                        con.Open();
                        string Query = "Insert into Passengertbl values('" + PsngrNtb.Text + "','" + PsngrAtb.Text + "','" + Gender + "','" + NationalCb.Text + "','" + PsngrPno.Text + "')";
                        SqlCommand cmd = new SqlCommand(Query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" Passenger Added Successfully");
                        con.Close();
                        populate();
                    ResetValues();
                }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    con.Close();

                }
            }
        }
        void ResetValues()
        {
            PsngrNtb.Text = "";
            PsngrAtb.Text = "";
            NationalCb.Text = "";
            PsngrPno.Text = "";
            Malerb.Checked = false;
            Femalerb.Checked = false;
            key = 0;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ResetValues();
        }
        int key = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Train which You Want To Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "Delete From PassengerTbl where PId=" + key + "";

                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" PassengerTbl Deleted Successfully");
                    con.Close();
                    populate();
                    ResetValues();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Affan\Downloads\Railway Reservation System\Railway Reservation System\Database\Railwaysdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                PsngrNtb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                PsngrAtb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                NationalCb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                PsngrPno.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();


                if (PsngrNtb.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
        }

        private void Passengermaster_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (PsngrNtb.Text == "" || PsngrPno.Text == "" || PsngrAtb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            
            else

            {
                if (Malerb.Checked == true)
                    Gender = " Male";

                else if (Femalerb.Checked == true)
                {
                    Gender = " Female";

                }
                try
                {
                    con.Open();
                    string Query = "Update PassengerTbl set Pname ='" + PsngrNtb.Text + "',PAddress='" + PsngrAtb.Text + "',PGender='" + Gender + "',PNationality='"+ NationalCb.Text + "',PMobileNo='"+ PsngrPno.Text+"' where Pid =" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Passenger Updated Successfully");
                    con.Close();
                    populate();
                    ResetValues();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    con.Close();
                }
            }
        }
    }
}



    