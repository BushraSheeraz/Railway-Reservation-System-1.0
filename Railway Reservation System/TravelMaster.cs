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
        
        private void populate()
        {
            DbConnection.con.Open();
            string query = "Select * from TravelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, DbConnection.con);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            DbConnection.con.Close();
        }

        void FillTCode()
        {
            DbConnection.con.Open();
            SqlCommand cmd = new SqlCommand("select TrainId from TrainTbl", DbConnection.con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TrainId", typeof(int));
            dt.Load(rdr);
            TCode.ValueMember = "TrainId";
            TCode.DataSource = dt;
            DbConnection.con.Close();
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
        /*void ChangeStatus()
        {
            string Trnstatus = "Busy";
                try
                {
                    DbConnection.con.Open();
                    string Query = "Update TrainTbl set TrainStatus='" + Trnstatus + "' where TrainId='" + TCode.SelectedValue.ToString() + ";";
                SqlCommand cmd = new SqlCommand(Query, DbConnection.con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show(" Train Updated Successfully");
                    DbConnection.con.Close();
                    populate();
                ResetValues();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    DbConnection.con.Close();
                }
            
        }*/
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
                    DbConnection.con.Open();
                    string Query = "Insert into TravelTbl values('" + dateTimePicker1.Value + "','" + TCode.SelectedValue.ToString()+ "','" + Source.SelectedItem.ToString() + "','" + Destination.SelectedItem.ToString() + "','" + TravelCost.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, DbConnection.con);
                    cmd.ExecuteNonQuery(); 
                    MessageBox.Show(" Travel Added Successfully");
                    DbConnection.con.Close();
                    populate();
                    ResetValues();
                    //ChangeStatus();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    DbConnection.con.Close();

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
                    DbConnection.con.Open();
                    string Query = "Update TravelTbl set TravDate ='" + dateTimePicker1.Value.ToString() + "',Train='" + TCode.SelectedValue.ToString() + "',Source='" + Source.SelectedItem.ToString() + "',Destination='" + Destination.SelectedItem.ToString() + "',Cost='" + TravelCost.Text + "' where TravCode =" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, DbConnection.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Travel Updated Successfully");
                    DbConnection.con.Close();
                    populate();
                    ResetValues();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    DbConnection.con.Close();
                }
            }
        }

        int key = 0;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Text= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
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
                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Deletetravelmstrbtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the TRAVEL which You Want To Delete");
            }
            else
            {
                try
                {
                    DbConnection.con.Open();
                    string Query = "Delete From TravelTbl where TravCode=" + key + "";

                    SqlCommand cmd = new SqlCommand(Query, DbConnection.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Train Deleted Successfully");
                    DbConnection.con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    DbConnection.con.Close();
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Mainform formMain = new Mainform();
            this.Hide();
            formMain.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
