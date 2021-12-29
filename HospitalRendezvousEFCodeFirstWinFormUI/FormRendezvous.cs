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
        RendezvousManager rendezvousManager = new RendezvousManager();
        private void FormRendezvous_Load(object sender, EventArgs e)
        {
            //Service groupbox and date time group box should be passive at first
            PassiveGroupBoxService();
            PassiveGroupBoxDate();
            FillPatientListBox();
            //Format dateTimePicker
            ConfigureDateTimePicker(DateTime.Now);

        }

        private void ConfigureDateTimePicker(DateTime date)
        {
            dateTimePickerRendezvousDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerRendezvousDate.CustomFormat = "dd.MM.yyyy";
            dateTimePickerRendezvousDate.MinDate = DateTime.Now.AddMinutes(-1);
            dateTimePickerRendezvousDate.MaxDate = dateTimePickerRendezvousDate.MinDate.AddDays(15);
            dateTimePickerRendezvousDate.Value = date;
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

        private void ActivateGroubBoxDate()
        {
            groupBoxRendezvous.Enabled = true;
        }

        private void PassiveGroupBoxService()
        {
            groupBoxService.Enabled = false;
        }

        private void textBoxPatientTRSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPatientTRSearch.Text.Trim().Length>=2)
            {
                listBoxPatients.DataSource = patientManager.FindPatientByTRID(textBoxPatientTRSearch.Text);
            }
            else
            {
                FillPatientListBox();
            }
        }

        private void listBoxPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPatients.SelectedIndex >= 0)
            {
                ActivateGroupBoxService();
            }
            else
            {
                PassiveGroupBoxService();
                PassiveGroupBoxDate();
            }
            ConfigureDateTimePicker(DateTime.Now);
            UC_RendezvousHours1.Clean();
        }

        private void ActivateGroupBoxService()
        {
            groupBoxService.Enabled = true;
            //After activation of service groupbox, comboBox service must be filles.
            FillComboBoxService();
        }

        private void FillComboBoxService()
        {
            comboBoxService.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxService.DataSource = Enum.GetValues(typeof(Specialties));
            comboBoxService.SelectedIndex = -1;

        }

        private void comboBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxService.SelectedIndex >= 0)
            {
                Specialties doctorSpecialty;
                Enum.TryParse(comboBoxService.SelectedValue.ToString(), out doctorSpecialty);
                listBoxDoctors.DataSource = doctorManager.BringAllDoctorsBySpecialty(doctorSpecialty);
            }
            else
            {
                listBoxDoctors.DataSource = null;
            }
            listBoxDoctors.SelectedIndex = -1;
            ConfigureDateTimePicker(DateTime.Now);
            UC_RendezvousHours1.Clean();
        }

        private void listBoxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {

            ConfigureDateTimePicker(DateTime.Now);
            if (listBoxDoctors.SelectedIndex >= 0)
            {
                ActivateGroubBoxDate();

                Doctor chosenDoctor = listBoxDoctors.SelectedItem as Doctor;
                UC_RendezvousHours1.myDoctor = chosenDoctor;
                
            }
            else
            {
                PassiveGroupBoxDate();
                PassiveGroupBoxDate();
            }
        }

        private void dateTimePickerRendezvousDate_ValueChanged(object sender, EventArgs e)
        {
            ConfigureDateTimePicker(dateTimePickerRendezvousDate.Value);
            UC_RendezvousHours1.IncomingDate = dateTimePickerRendezvousDate.Value;
            UC_RendezvousHours1.Clean();
        }

        private void btnBookRendezvous_Click(object sender, EventArgs e)
        {
            try
            {
                //If patient has another rendezvous for the same date and time, booking will be denied.
                if (listBoxPatients.SelectedIndex < 0)
                {
                    MessageBox.Show("You can't perform rendezvous operations without choosing a patient!");
                }

                if (listBoxDoctors.SelectedIndex < 0)
                {
                    throw new Exception("You can't perform rendezvous operations without choosing a doctor!");
                }
                if (!UC_RendezvousHours1.IsRendezvousButtonActive)
                {
                    MessageBox.Show("In order to book a rendezvous, you need to click rendezvous date buttons and choose a certain time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //Attention!
                Patient chosenPatient = listBoxPatients.SelectedItem as Patient;
                if (rendezvousManager.DoesPatientHasRendezvousForChosenDate(chosenPatient, UC_RendezvousHours1.RendezvousDateToBeBooked))
                {
                    MessageBox.Show($"Attention: You have already booked a rendezvous for date {UC_RendezvousHours1.RendezvousDateToBeBooked.ToString("dd.MM.yyyy HH:mm:ss")}","WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //Patient can book rendezvous.
                Doctor chosenDoctor = listBoxDoctors.SelectedItem as Doctor;
                RendezvousInfo newRendezvous = new RendezvousInfo()
                {
                    PatientId= chosenPatient.PatientId,
                    DoctorId = chosenDoctor.DoctorId,
                    RendezvousDate = UC_RendezvousHours1.RendezvousDateToBeBooked
                };

                bool isBookingConfirmed = false;
                isBookingConfirmed = rendezvousManager.BookRendezvous(newRendezvous);
                if (isBookingConfirmed)
                {
                    MessageBox.Show($"Rendezvous has been booked successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UC_RendezvousHours1.Clean();
                    dateTimePickerRendezvousDate.Value = DateTime.Now;
                    PassiveGroupBoxDate();
                    PassiveGroupBoxService();
                    listBoxPatients.SelectedIndex = -1;
                }
                else
                {
                    throw new Exception("Unexpected error has occured during rendezvous booking!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
