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

namespace HospitalRendezvousEFCodeFirstWinFormUI
{
    public partial class UC_RendezvousHour : UserControl
    {
        public UC_RendezvousHour()
        {
            InitializeComponent();
        }

        private void UC_RendezvousHour_Load(object sender, EventArgs e)
        {
            comboBoxHours.DisplayMember = "HoursInterval";
            comboBoxHours.ValueMember = "Id";
            comboBoxHours.DataSource = HourViewModel.BringHoursList();
        }

        private void comboBoxHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxHours.SelectedIndex >= 0)
            {
                string myHour = comboBoxHours.SelectedValue.ToString().Substring(0, 3); //"09:
                foreach (Button item in tableLayoutPanelRendezvousButtons.Controls)
                {
                    switch (item.Name)
                    {
                        case "btn0015":
                            btn0015.Text = $"{myHour}00 - {myHour}15";
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
