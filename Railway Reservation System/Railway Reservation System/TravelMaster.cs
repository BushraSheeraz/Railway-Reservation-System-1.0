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
    public partial class TravelMaster : Form
    {
        public TravelMaster()
        {
            InitializeComponent();
            populate();
            FillTCode();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Affan\Downloads\Railway Reservation System\Railway Reservation System\Database\Railwaysdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            con.Open();
            string query = "Select * from TravelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        void FillTCode()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select TrainId from TrainTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TrainId", typeof(int));
            dt.Load(rdr);
            TCode.ValueMember = "TrainId";
            TCode.DataSource = dt;
            con.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TravelMaster_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addtravelmstrbtn_Click(object sender, EventArgs e)
        {
            if (TCode.SelectedIndex == -1 || Destination.SelectedIndex == -1 || Source.SelectedIndex == -1 || TravelCost.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else

            {
                try
                {
                    con.Open();
                    string Query = "Insert into TravelTbl values('" + dateTimePicker1.Value + "','" + TCode.SelectedValue.ToString()+ "','" + Source.SelectedItem.ToString() + "','" + Destination.SelectedItem.ToString() + "','" + TravelCost.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery(); 
                    MessageBox.Show(" Travel Added Successfully");
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
            TCode.SelectedIndex = -1;
            Destination.SelectedIndex = -1;
            Source.SelectedIndex = -1;
            TravelCost.Text = "";
        }

        private void Resettravelmstrbtn_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void EditTravelmstrbtn_Click(object sender, EventArgs e)
        {
            if (TCode.SelectedIndex == -1 || Destination.SelectedIndex == -1 || Source.SelectedIndex == -1 || TravelCost.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "Update TravelTbl set TravDate ='" + dateTimePicker1.Text + "',Train='" + TCode.SelectedValue.ToString() + "',Source='" + Source.SelectedItem.ToString() + "',Destination='" + Destination.SelectedItem.ToString() + "',Cost='" + TravelCost.Text + "' where TravCode =" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Travel Updated Successfully");
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

        int key = 0;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[0].Value);
            TCode.SelectedValue = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Source.SelectedItem = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Destination.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            TravelCost.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();



            if (TCode.SelectedIndex == -1)
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            }
        }
    }
}
