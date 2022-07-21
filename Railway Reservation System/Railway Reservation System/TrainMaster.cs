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
    public partial class TrainMaster : Form
    {
        public TrainMaster()
        {
            InitializeComponent();
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Affan\Downloads\Railway Reservation System\Railway Reservation System\Database\Railwaysdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            con.Open();
            string query = "Select * from Traintbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            TrainDataGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Addtravelmstrbtn_Click(object sender, EventArgs e)
        {
            string Trnstatus = "";
            if (trnnametb.Text == "" || trncapacitytb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (busyradiobutton.Checked == true)
                    Trnstatus = " Busy";

                else if (Availableradiobutton.Checked == true)
                {
                    Trnstatus = " Available";


                }
                try
                {
                    con.Open();
                    string Query = "Insert into traintbl values('" + trnnametb.Text + "','" + trncapacitytb.Text + "','" + Trnstatus + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Train Added Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    con.Close();
                }
            }
        }
        
        private void Resettravelmstrbtn_Click(object sender, EventArgs e)
        {
            {

                trnnametb.Text = "";
                trncapacitytb.Text = "";
                busyradiobutton.Checked = false;
                Availableradiobutton.Checked = false;
                key = 0;
                
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int key = 0;
        private void TrainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            trnnametb.Text = TrainDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            trncapacitytb.Text = TrainDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            if (trnnametb.Text == "") 
            { key = 0;
            }else
            {
                key = Convert.ToInt32(TrainDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void Deletetravelmstrbtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Train which You Want To Delete") ;
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "Delete From TrainTbl where TrainId="+key+"";
               
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Train Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    con.Close();
                }
            }
        }

        private void EditTravelmstrbtn_Click(object sender, EventArgs e)
        {
            string Trnstatus = "";
            if (trnnametb.Text == "" || trncapacitytb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (busyradiobutton.Checked == true)
                {
                    Trnstatus = " Busy";
                }

                else if (Availableradiobutton.Checked == true)
                {
                    Trnstatus = " Available";
                }
                try
                {
                    con.Open();
                    string Query = "Update TrainTbl set TrainName ='" + trnnametb.Text + "',TrainCap=" + trncapacitytb.Text + ",TrainStatus='" + Trnstatus + "' where TrainId =" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Train Updated Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    con.Close();
                }
            }
        }

        private void trncapacitytb_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrainMaster_Load(object sender, EventArgs e)
        {

        }
    }
}
