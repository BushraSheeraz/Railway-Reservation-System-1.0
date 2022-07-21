using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_Reservation_System
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TravelMaster());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reservation_Click(object sender, EventArgs e)
        {
            ReservationMaster reservation = new ReservationMaster();
            reservation.Show();
            this.Hide();
        }

        private void passenger_Click(object sender, EventArgs e)
        {
            Passengermaster passenger = new Passengermaster();
            passenger.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Cancellation_Master cancel = new Cancellation_Master();
            cancel.Show();
            this.Hide();
        }

        private void travel_Click(object sender, EventArgs e)
        {
            TravelMaster travel = new TravelMaster();
            travel.Show();
            this.Hide();
        }

        private void train_Click(object sender, EventArgs e)
        {
            TrainMaster train = new TrainMaster();
            train.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
