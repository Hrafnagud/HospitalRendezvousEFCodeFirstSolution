using HopitalRendezvousEFCodeFirstEntities;
using HospitalRendezvousEFCodeFirstBLL;
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
    public partial class FormCallPatient : Form
    {
        public FormCallPatient()
        {
            InitializeComponent();
        }

        DoctorManager doctorManager = new DoctorManager();
        RendezvousManager rendezvousManager = new RendezvousManager();
        Doctor chosenDoctor { get; set; }
        private void FormCallDoctor_Load(object sender, EventArgs e)
        {
            BringDoctorsToCombo();
            btnStop.Enabled = false;
            btnBegin.Enabled = true;

            labelPatient.Text = "--------";
            chosenDoctor = null;
        }

        private void BringDoctorsToCombo()
        {
            comboBoxDoctor.DisplayMember = "DoctorName" + "DoctorSurname";
            comboBoxDoctor.ValueMember = "DoctorId";
            comboBoxDoctor.DataSource = doctorManager.BringAllActiveDoctors();
            comboBoxDoctor.SelectedIndex = -1;
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDoctor.SelectedIndex >= 0)
            {
                chosenDoctor = doctorManager.FindDoctorById((int)comboBoxDoctor.SelectedValue);
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000; //a second. when timer's enabled property is true, will execute

            timer1.Enabled = true;  //timer can be executed with Start() method

            btnStop.Enabled = true;
            btnBegin.Enabled = false;
            comboBoxDoctor.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnBegin.Enabled = true;
            btnStop.Enabled = false;
            labelPatient.Font = new Font("Arial", 35);
            comboBoxDoctor.Enabled = true;

            if (!labelPatient.Text.Contains("-"))
            {
                labelPatient.Text += $"\nis in doctor's room for diagnosis";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Font BigFont = new Font("Arial", 45);
            Font NormalFont = new Font("Arial", 35);



            if (chosenDoctor != null)
            {
                // Doctor rendezvous belongs today

                List<RendezvousInfo> doctorRendezvous = rendezvousManager.BringDoctorRendezvousByDate(chosenDoctor, DateTime.Now);
                if (doctorRendezvous.Count > 0)
                {
                    RendezvousInfo foundRendezvous = doctorRendezvous.FirstOrDefault(x => x.RendezvousDate.ToString("HH") == DateTime.Now.Hour.ToString()
                    && x.RendezvousDate.Minute < DateTime.Now.Minute + 2
                    && x.RendezvousDate.Minute > DateTime.Now.Minute - 2);

                    if (foundRendezvous != null)
                    {
                        labelPatient.Text = $"{foundRendezvous.Patient.PatientName} {foundRendezvous.Patient.PatientSurname}";

                        labelPatient.ForeColor = Color.Red;

                        if (DateTime.Now.Second % 2 == 0)
                        {
                            labelPatient.Font = BigFont;
                        }

                        else
                        {
                            labelPatient.Font = BigFont;
                        }
                    }
                }
            }
        }

    }
}
