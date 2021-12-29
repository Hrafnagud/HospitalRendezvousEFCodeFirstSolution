using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HopitalRendezvousEFCodeFirstEntities;
using HospitalRendezvousEFCodeFirstBLL;

namespace HospitalRendezvousEFCodeFirstWinFormUI
{
    public partial class UC_RendezvousHours : UserControl
    {
        public UC_RendezvousHours()
        {
            InitializeComponent();
        }
        //Global
        public Doctor myDoctor { get; set; }    //Doctor and
        public DateTime IncomingDate { get; set; } = DateTime.Now; //Date for rendezvous must be required to come up with a proper rendezvous schedule.

        public DateTime RendezvousDateToBeBooked { get; set; }

        public bool IsRendezvousButtonActive { get; set; }

        public RendezvousManager rendezvousManager = new RendezvousManager();

        private void UC_RendezvousHour_Load(object sender, EventArgs e)
        {
            IsRendezvousButtonActive = false;
            IncomingDate = DateTime.Now;
            comboBoxHours.DisplayMember = "HourInterval";
            comboBoxHours.ValueMember = "Id";
            comboBoxHours.DataSource = HourViewModel.BringHoursList();
            comboBoxHours.SelectedIndex = -1;
            CleanRendezvousButtonsNames();

            foreach (Button item in tableLayoutPanelRendezvousButtons.Controls)
            {
                item.Click += new EventHandler(btnClick);
            }

            myDoctor = null;
            ActivePassiveButtonsByBookedRendezvous();
        }

        private void CleanRendezvousButtonsNames()
        {
            foreach (Button item in tableLayoutPanelRendezvousButtons.Controls)
            {
                item.Text = "----";
            }
        }

        private void comboBoxHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (myDoctor == null)
                {
                    PassiveRendezvousButtons();
                    return;
                }

                if (comboBoxHours.SelectedIndex >= 0)
                {
                    //Button texts will be configured.

                    ConfigureButtonsText();

                    //Buttons active-passive state will be configured

                    ActivePassiveButtonsByBookedRendezvous();
                }
                else
                {
                    CleanRendezvousButtonsNames();
                    PassiveRendezvousButtons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void ActivePassiveButtonsByBookedRendezvous()
        {
            try
            {
                ActivateRendezvousButtons();
                if (myDoctor != null)
                {
                    List<RendezvousInfo> doctorRendezvous = rendezvousManager.BringDoctorRendezvousByDate(myDoctor, IncomingDate);
                    if (doctorRendezvous.Count > 0)
                    {
                        foreach (RendezvousInfo item in doctorRendezvous)
                        {
                            if (item.RendezvousDate.ToShortTimeString().Substring(0,2) == comboBoxHours.Text.Substring(0,2)) //e.g 10:00 == 10:00
                            {
                                string itemHour = item.RendezvousDate.ToShortTimeString();
                                string itemMinute = itemHour.Substring(3, 2);
                                switch (itemMinute)
                                {
                                    case "00":
                                        btn00.Enabled = false;
                                        break;
                                    case "15":
                                        btn15.Enabled = false;
                                        break;
                                    case "30":
                                        btn30.Enabled = false;
                                        break;
                                    case "45":
                                        btn45.Enabled = true;
                                        break;
                                    default:
                                        break;

                                }
                            }
                        }
                    }

                }
                else
                {
                    CleanRendezvousButtonsNames();
                    PassiveRendezvousButtons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void ConfigureButtonsText()
        {
            if (comboBoxHours.SelectedIndex >= 0)
            {
                string myHour = HourViewModel.BringHoursList().FirstOrDefault(x => x.Id == (int)comboBoxHours.SelectedValue).HourInterval.Substring(0,2);

                foreach (Button item in tableLayoutPanelRendezvousButtons.Controls)
                {
                    switch (item.Name)
                    {
                        case "btn00":
                            btn00.Text = $"{myHour}:00";
                            break;
                        case "btn15":
                            btn15.Text = $"{myHour}:15";
                            break;
                        case "btn30":
                            btn30.Text = $"{myHour}:30";
                            break;
                        case "btn45":
                            btn45.Text = $"{myHour}:45";
                            break;
                        default:
                            item.Text = "----";
                            break;
                    }
                }
            }
            else
            {

            }
        }

        private void ActivateRendezvousButtons()
        {
            foreach (Button item in tableLayoutPanelRendezvousButtons.Controls)
            {
                item.Enabled = true;
            }
        }

        private void PassiveRendezvousButtons()
        {
            foreach (Button item in tableLayoutPanelRendezvousButtons.Controls)
            {
                item.Enabled = false;
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int hour = Convert.ToInt32(btn.Text.Substring(0, 2));
            int minute = Convert.ToInt32(btn.Text.Substring(3, 2));
            RendezvousDateToBeBooked = new DateTime(IncomingDate.Year, IncomingDate.Month, IncomingDate.Day, hour, minute, 00);
            IsRendezvousButtonActive = true;
        }

        public void Clean()
        {
            comboBoxHours.SelectedIndex = -1;
            CleanRendezvousButtonsNames();
            PassiveRendezvousButtons();
            IsRendezvousButtonActive = false;
        }
    }
}
