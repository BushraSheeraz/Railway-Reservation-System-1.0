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
    public partial class Tickets : Form
    {
        string id = "";
        public Tickets(string id)
        {
            this.id = id;
            InitializeComponent();
        }
        Bitmap bmp;
        private void Tickets_Load(object sender, EventArgs e)
        {
            

            int Id = Convert.ToInt32(id);
            try
            {
                DbConnection.con.Open();
                string query = "Select * from ReservationTbl where TicketId='" + Id + "'";
                SqlCommand cmd = new SqlCommand(query, DbConnection.con);
                SqlDataReader DR1 = cmd.ExecuteReader();
                if (DR1.Read())
                {
                    label8.Text = DR1.GetValue(0).ToString();
                    label9.Text = DR1.GetValue(2).ToString();
                    label10.Text = DR1.GetValue(5).ToString();
                    label11.Text = DR1.GetValue(4).ToString();
                    label12.Text = DR1.GetValue(7).ToString();
                    label13.Text = DR1.GetValue(6).ToString();
                }

                DbConnection.con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                DbConnection.con.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            ReservationMaster formMain = new ReservationMaster();
            this.Hide();
            formMain.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            // ReservationMaster formMain = new ReservationMaster();
            this.Hide();
            // formMain.Show();
        }
    }
}
