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
    public partial class TicketPrint : Form
    {
        string id = "";
        public TicketPrint(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void TicketPrint_Load(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(id);
            try
            {
                DbConnection.con.Open();
                string query = "Select * from ReservationTbl where TicketId='"+Id+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, DbConnection.con);
                DataSet2 ds = new DataSet2();
                sda.Fill(ds, "ReservationTbl");
                //MessageBox.Show("Total "+ds.Tables[0].Rows.Count.ToString());
                CrystalReport1 objRpt = new CrystalReport1();
                objRpt.SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
               
                DbConnection.con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                DbConnection.con.Close();

            }
        }
    }
}
