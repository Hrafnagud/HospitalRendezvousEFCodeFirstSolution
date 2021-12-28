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

        //Global
        DoctorManager doctorManager = new DoctorManager();

        private void FormDoctors_Load(object sender, EventArgs e)
        {
            BringDoctorsToGrid();
            //comboBox
            comboBoxDrSpecialty.DropDownStyle = ComboBoxStyle.DropDownList;
            // comboBoxDrSpecialty.DisplayMember = "TheValue";
            // comboBoxDrSpecialty.ValueMember = "TheKey";
            // comboBoxDrSpecialty.DataSource = EnumManager.BringAllSpecialties();
            // comboBoxDrSpecialty.SelectedValue = (int)Specialties.NoSpecialty;

            comboBoxDrSpecialty.DataSource = Enum.GetValues(typeof(Specialties));

            //maskedtextbox configuration
            maskedTextBoxDrPhone.Mask = @"\0\5##-###-##-##";   //11 Digit
        }

        private void buttonAddDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                if(textDrName.Text.Trim().Length < 2)
                {
                    throw new Exception("Please enter doctor name in a correct format!");
                }

                if(textDrSurname.Text.Trim().Length < 2)
                {
                    throw new Exception("Please enter doctor surname in a correct format!");
                }
                if(textDrTR.Text.Trim().Length != 11)
                {
                    throw new Exception("Please enter doctor TR ID in a correct format! (Must consist 11 digit)");
                }
                if(textDrTR.Text.Any(x => !char.IsDigit(x)))
                {
                    throw new Exception("TR ID must consist digits only!");
                }

                Specialties drSpeacialty;
                Enum.TryParse(comboBoxDrSpecialty.SelectedValue.ToString(), out drSpeacialty);
                Doctor newDoctor = new Doctor()
                {
                    DoctorName = textDrName.Text.Trim(),
                    DoctorSurname = textDrSurname.Text.Trim(),
                    Specialty = drSpeacialty,
                    Email = textBoxDrEmail.Text,
                    PhoneNumber = maskedTextBoxDrPhone.Text.Replace("-", ""),
                    TRID = textDrTR.Text
                };

                //Doctor will be added to system.
                if (doctorManager.AddNewDoctor(newDoctor))
                {
                    MessageBox.Show($"{textDrName.Text.Trim()} {textDrSurname.Text.Trim()} has been added to database as a new doctor!");
                    CleanDoctorAddPage();
                    BringDoctorsToGrid();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void BringDoctorsToGrid()
        {
            dataGridViewDoctor.DataSource = doctorManager.BringAllActiveDoctors();

            // Set your desired AutoSize Mode:
            dataGridViewDoctor.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDoctor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDoctor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDoctor.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDoctor.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDoctor.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDoctor.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDoctor.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dataGridViewDoctor.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dataGridViewDoctor.Columns[i].Width;

                // Remove AutoSizing:
                dataGridViewDoctor.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dataGridViewDoctor.Columns[i].Width = colw;
            }
        }

        private void CleanDoctorAddPage()
        {
            textDrName.Clear();
            textDrSurname.Clear();
            textDrTR.Clear();
            textBoxDrEmail.Clear();
            comboBoxDrSpecialty.SelectedValue = 0;
            maskedTextBoxDrPhone.Clear();
        }

        private void comboBoxDrSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
