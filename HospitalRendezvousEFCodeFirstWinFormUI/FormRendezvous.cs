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
            ConfigureDateTimePicker();

            //for Output summary
            FillDoctorsToComboBoxOutputSummary();
            comboBoxOutputSummaryChooseDoctor.SelectedIndex = -1;

        }

        private void FillDoctorsToComboBoxOutputSummary()
        {
            comboBoxOutputSummaryChooseDoctor.DisplayMember = "DoctorName" + " DoctorSurname";
            comboBoxOutputSummaryChooseDoctor.ValueMember = "DoctorId";
            comboBoxOutputSummaryChooseDoctor.DataSource = doctorManager.BringAllActiveDoctors();
        }

        private void ConfigureDateTimePicker()
        {
            dateTimePickerRendezvousDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerRendezvousDate.CustomFormat = "dd.MM.yyyy";
            dateTimePickerRendezvousDate.MinDate = DateTime.Now.AddMinutes(-1);
            dateTimePickerRendezvousDate.MaxDate = dateTimePickerRendezvousDate.MinDate.AddDays(15);
            dateTimePickerRendezvousDate.Value = DateTime.Now;
            ///
            dateTimePickerOutputSummary.Format = DateTimePickerFormat.Custom;
            dateTimePickerOutputSummary.CustomFormat = "dd.MM.yyyy";
            dateTimePickerOutputSummary.MinDate = DateTime.Now;
            dateTimePickerOutputSummary.MaxDate = dateTimePickerOutputSummary.MinDate.AddDays(15);
            dateTimePickerOutputSummary.Value = DateTime.Now;
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
            ConfigureDateTimePicker();
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
            ConfigureDateTimePicker();
            UC_RendezvousHours1.Clean();
        }

        private void listBoxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {

            ConfigureDateTimePicker();
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
                    //Rendezvous will be added to list view.
                    AddRendezvousToListView(newRendezvous);
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

        private void AddRendezvousToListView(RendezvousInfo newRendezvous)
        {
            RendezvousInfoModel rendezvous = rendezvousManager.TransactRendezvousToModel(newRendezvous);
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = rendezvous.Service;
            listViewItem.SubItems.Add(rendezvous.DoctorFullName);
            listViewItem.SubItems.Add(rendezvous.PatientFullName);
            listViewItem.SubItems.Add(rendezvous.RendezvousDate.ToString("dd.MM.yyyy HH:mm"));
            listViewItem.Tag = rendezvous;
            listViewBookedRendezvous.Items.Add(listViewItem);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            UC_RendezvousHours1.Clean();
            PassiveGroupBoxDate();
            comboBoxService.SelectedIndex = -1;
            listBoxDoctors.SelectedIndex = -1;
            PassiveGroupBoxService();
            listBoxPatients.SelectedIndex = -1;
            //Cleaning when tabs change
            btnOutputSummary.Enabled = false;
            dateTimePickerOutputSummary.Value = DateTime.Now;
            comboBoxOutputSummaryChooseDoctor.SelectedIndex = -1;
        }

        private void comboBoxOutputSummaryChooseDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxOutputSummaryChooseDoctor.SelectedIndex >= 0)
                {
                    
                    Doctor chosenDoctor = doctorManager.FindDoctorById((int)comboBoxOutputSummaryChooseDoctor.SelectedValue);
                    ConfigureOutPutSummaryButtonState(chosenDoctor, dateTimePickerOutputSummary.Value);
                }
                else
                {
                    dateTimePickerOutputSummary.Value = DateTime.Now;
                    btnOutputSummary.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void ConfigureOutPutSummaryButtonState(Doctor doctor, DateTime date)
        {
            btnOutputSummary.Enabled = false;
            btnOutputSummary.BackColor = SystemColors.Control;
            if (doctor != null)
            {
                List<RendezvousInfo> rendezvousList = rendezvousManager.BringDoctorRendezvousByDate(doctor, date);
                if (rendezvousList.Count > 0)
                {
                    btnOutputSummary.Enabled = true;
                    btnOutputSummary.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show($"{doctor.ToString()} has no rendezvous for date {date.ToString("dd.MM.yyyy")}. Choose a different date!","WARNING", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void dateTimePickerOutputSummary_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxOutputSummaryChooseDoctor.SelectedIndex >= 0)
            {
                Doctor chosenDoctor = doctorManager.FindDoctorById((int)comboBoxOutputSummaryChooseDoctor.SelectedValue);
                ConfigureOutPutSummaryButtonState(chosenDoctor, dateTimePickerOutputSummary.Value);
            }
        }

        private void btnOutputSummary_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.Print();
                btnOutputSummary.BackColor = SystemColors.Control;
                btnOutputSummary.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Doctor doctor = doctorManager.FindDoctorById((int)comboBoxOutputSummaryChooseDoctor.SelectedValue);
                Bitmap firstBitmap = Properties.Resources.doktorRandevularResim1;   //DoctorRendezvousPicture1 (Auto generated and it is Turkish :))
                Image firstImage = firstBitmap;

                Bitmap secondBitmap = Properties.Resources.doktorRandevularResim2;   //DoctorRendezvousPicture1 (Auto generated and it is Turkish :))
                Image secondImage= secondBitmap;

                e.Graphics.DrawImage(firstImage, 25, 25, firstImage.Width / 10, firstImage.Height / 10);
                e.Graphics.DrawImage(secondImage, 725, 25, secondImage.Width / 10, secondImage.Height / 10);
                e.Graphics.DrawString($"Date related rendezvous details\nService: {EnumManager.PassSpecialtyAsTurkishString(doctor.Specialty)}- {doctor.ToString()} - {dateTimePickerOutputSummary.Value.ToString("dd-MM-yyyy")}",
                    new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 100));

                e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25,150), new Point(800,150));
                e.Graphics.DrawString("Date and Time", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 200));

                e.Graphics.DrawLine(new Pen(Color.Blue, 22), new Point(25,150), new Point(800,150));
                e.Graphics.DrawString("Patient Name and Surname", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, 200));

                e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 225), new Point(800, 225));

                Point datePosition = new Point(50, 235);
                Point patientPosition = new Point(200, 235);

                string[] hours = { "09:00", "09:15", "09:30", "09:45","10:00","10:15","10:30","10:45",
                "11:00","11:15","11:30","11:45", "13:00","13:15","13:30","13:45","14:00","14:15","14:30","14:45","15:00","15:15","15:30","15:45" };

                RendezvousInfo[] rendezvousInOrder = new RendezvousInfo[hours.Length];
                List<RendezvousInfo> doctorRendezvous = rendezvousManager.BringDoctorRendezvousByDate(doctor, dateTimePickerOutputSummary.Value);
                //List<RendezvousInfo> alternativeRendezvousInorder = new List<RendezvousInfo>();

                foreach (RendezvousInfo item in doctorRendezvous)
                {
                    for (int i = 0; i < hours.Length; i++)
                    {
                        if (hours[i] == item.RendezvousDate.ToString("HH:mm"))
                        {
                            rendezvousInOrder[i] = item;
                        }
                    }
                }

                //foreach (RendezvousInfo item in doctorRendezvous)
                //{
                //    //for (int i = 0; i < hours.Length; i++)
                //    //{
                //    //    if (hours[i] == item.RendezvousDate.ToString("HH:mm"))
                //    //    {
                //    //        rendezvousInOrder[i] = item;
                //    //    }
                //    //}
                //}


                foreach (RendezvousInfo item in rendezvousInOrder)
                {
                    if (item != null)
                    {
                        datePosition = new Point(datePosition.X, datePosition.Y + 25);

                        e.Graphics.DrawString($"{item.RendezvousDate.ToString("dd.MM.yyyy")} - {item.RendezvousDate.ToString("HH:mm")}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, datePosition);

                        patientPosition = new Point(patientPosition.X, patientPosition.Y + 25);

                        e.Graphics.DrawString($"{item.Patient.PatientName} {item.Patient.PatientSurname}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, patientPosition);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void tabPageOutputSummary_Leave(object sender, EventArgs e)
        {
            comboBoxOutputSummaryChooseDoctor.SelectedIndex = -1;
        }
    }
}
