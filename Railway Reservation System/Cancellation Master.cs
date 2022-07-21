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
    public partial class Cancellation_Master : Form
    {
        public Cancellation_Master()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            DbConnection.con.Open();
            string query = "Select * from ReservationTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, DbConnection.con);
            var ds = new DataSet();
            sda.Fill(ds);
            sda.Fill(ds);
            dd_ticket.DisplayMember = "TicketId";
            dd_ticket.ValueMember = "TicketId";
            dd_ticket.DataSource = ds.Tables[0];
            DbConnection.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DbConnection.con.Open();
                //string Query = "Insert into Cancellationtbl values('" + dd_ticket.SelectedValue + "','" + DateTime.Now+"')";
                string Query = "Update ReservationTbl set Status = 'Cancel' where TicketId="+ dd_ticket.SelectedValue;
                SqlCommand cmd = new SqlCommand(Query, DbConnection.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ticket Cancelled");
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

        private void label5_Click(object sender, EventArgs e)
        {
            Mainform formMain = new Mainform();
            this.Hide();
            formMain.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dd_ticket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
