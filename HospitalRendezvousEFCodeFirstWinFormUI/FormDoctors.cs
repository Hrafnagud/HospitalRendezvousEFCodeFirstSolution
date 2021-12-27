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
    public partial class FormDoctors : Form
    {
        public FormDoctors()
        {
            InitializeComponent();
        }


        private void FormDoctors_Load(object sender, EventArgs e)
        {
            //comboBox
            comboBoxDrSpecialty.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDrSpecialty.DisplayMember = "TheValue";
            comboBoxDrSpecialty.ValueMember = "TheKey";
            comboBoxDrSpecialty.DataSource = EnumManager.BringAllSpecialties();
            comboBoxDrSpecialty.SelectedValue = (int)Specialties.NoSpecialty;
        }

        private void buttonAddDoctor_Click(object sender, EventArgs e)
        {
            Doctor newDoctor = new Doctor()
            {
                DoctorName = textDrName.Text.Trim(),
                DoctorSurname = textDrSurname.Text.Trim(),
                //Specialty = Enum.GetValues()
                Email = textBoxDrEmail.Text,
                PhoneNumber = maskedTextBoxDrPhone.Text,
                TRID = textDrTR.Text
            };
        }

        private void comboBoxDrSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
