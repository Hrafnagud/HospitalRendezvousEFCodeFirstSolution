using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalRendezvousEFCodeFirstBLL;
using HopitalRendezvousEFCodeFirstEntities;

namespace HospitalRendezvousEFCodeFirstWinFormUI
{
    public partial class FormRendezvous : Form
    {
        public FormRendezvous()
        {
            InitializeComponent();
        }

        //Global
        PatientManager patientManager = new PatientManager();
        DoctorManager doctorManager = new DoctorManager();

        private void FormRendezvous_Load(object sender, EventArgs e)
        {
            //Service groupbox and date time group box should be passive at first
            PassiveGroupBoxService();
            PassiveGroupBoxDate();
            FillPatientListBox();

        }

        private void FillPatientListBox()
        {
            listBoxPatients.DataSource = patientManager.BringAllPatients();
            listBoxPatients.SelectedIndex = -1;
        }

        private void PassiveGroupBoxDate()
        {
            groupBoxRendezvous.Enabled = false;
        }

        private void PassiveGroupBoxService()
        {
            groupBoxService.Enabled = false;
        }
    }
}
