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
            //Format dateTimePicker
            ConfigureDateTimePicker(DateTime.Now);

        }

        private void ConfigureDateTimePicker(DateTime date)
        {
            dateTimePickerRendezvousDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerRendezvousDate.CustomFormat = "dd.MM.yyyy";
            dateTimePickerRendezvousDate.MinDate = date;
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
        }

        private void listBoxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigureDateTimePicker(DateTime.Now);
            if (listBoxDoctors.SelectedIndex >= 0)
            {
                ActivateGroubBoxDate();
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
        }
    }
}
