using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRendezvousEFCodeFirstWinFormUI
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void buttonDoctorOperations_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormDoctors formDoctors = new FormDoctors();
            formDoctors.Show();
        }

        private void buttonRendezvousOperations_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormRendezvous formRendezvous= new FormRendezvous();
            formRendezvous.Show();
        }

        private void buttonBringPatients_Click(object sender, EventArgs e)
        {
            FormCallPatient formCallPatient = new FormCallPatient();
            formCallPatient.Show();
        }
    }
}
