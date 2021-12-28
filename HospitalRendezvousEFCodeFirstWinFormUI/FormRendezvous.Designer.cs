
namespace HospitalRendezvousEFCodeFirstWinFormUI
{
    partial class FormRendezvous
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRendezvousOperation = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.groupBoxService = new System.Windows.Forms.GroupBox();
            this.groupBoxRendezvous = new System.Windows.Forms.GroupBox();
            this.textBoxPatientTRSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPatients = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.listBoxDoctors = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageRendezvousOperation.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            this.groupBoxService.SuspendLayout();
            this.groupBoxRendezvous.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRendezvousOperation);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1735, 735);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRendezvousOperation
            // 
            this.tabPageRendezvousOperation.Controls.Add(this.groupBoxRendezvous);
            this.tabPageRendezvousOperation.Controls.Add(this.groupBoxService);
            this.tabPageRendezvousOperation.Controls.Add(this.groupBoxPatient);
            this.tabPageRendezvousOperation.Location = new System.Drawing.Point(4, 25);
            this.tabPageRendezvousOperation.Name = "tabPageRendezvousOperation";
            this.tabPageRendezvousOperation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRendezvousOperation.Size = new System.Drawing.Size(1727, 706);
            this.tabPageRendezvousOperation.TabIndex = 0;
            this.tabPageRendezvousOperation.Text = "Rendezvous Operation Page";
            this.tabPageRendezvousOperation.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.listBoxPatients);
            this.groupBoxPatient.Controls.Add(this.label1);
            this.groupBoxPatient.Controls.Add(this.textBoxPatientTRSearch);
            this.groupBoxPatient.Location = new System.Drawing.Point(8, 21);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(430, 443);
            this.groupBoxPatient.TabIndex = 0;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Choose a Patient";
            // 
            // groupBoxService
            // 
            this.groupBoxService.Controls.Add(this.label3);
            this.groupBoxService.Controls.Add(this.listBoxDoctors);
            this.groupBoxService.Controls.Add(this.comboBoxService);
            this.groupBoxService.Controls.Add(this.label2);
            this.groupBoxService.Location = new System.Drawing.Point(479, 21);
            this.groupBoxService.Name = "groupBoxService";
            this.groupBoxService.Size = new System.Drawing.Size(407, 443);
            this.groupBoxService.TabIndex = 1;
            this.groupBoxService.TabStop = false;
            this.groupBoxService.Text = "Service and Doctor Selection";
            // 
            // groupBoxRendezvous
            // 
            this.groupBoxRendezvous.Controls.Add(this.label4);
            this.groupBoxRendezvous.Controls.Add(this.dateTimePicker1);
            this.groupBoxRendezvous.Location = new System.Drawing.Point(930, 21);
            this.groupBoxRendezvous.Name = "groupBoxRendezvous";
            this.groupBoxRendezvous.Size = new System.Drawing.Size(764, 443);
            this.groupBoxRendezvous.TabIndex = 2;
            this.groupBoxRendezvous.TabStop = false;
            this.groupBoxRendezvous.Text = "Rendezvous Date and Time";
            // 
            // textBoxPatientTRSearch
            // 
            this.textBoxPatientTRSearch.Location = new System.Drawing.Point(171, 41);
            this.textBoxPatientTRSearch.Name = "textBoxPatientTRSearch";
            this.textBoxPatientTRSearch.Size = new System.Drawing.Size(240, 22);
            this.textBoxPatientTRSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient TR ID:";
            // 
            // listBoxPatients
            // 
            this.listBoxPatients.FormattingEnabled = true;
            this.listBoxPatients.ItemHeight = 16;
            this.listBoxPatients.Location = new System.Drawing.Point(23, 81);
            this.listBoxPatients.Name = "listBoxPatients";
            this.listBoxPatients.Size = new System.Drawing.Size(388, 356);
            this.listBoxPatients.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose a Service:";
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(146, 45);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(242, 24);
            this.comboBoxService.TabIndex = 4;
            // 
            // listBoxDoctors
            // 
            this.listBoxDoctors.FormattingEnabled = true;
            this.listBoxDoctors.ItemHeight = 16;
            this.listBoxDoctors.Location = new System.Drawing.Point(20, 113);
            this.listBoxDoctors.Name = "listBoxDoctors";
            this.listBoxDoctors.Size = new System.Drawing.Size(368, 324);
            this.listBoxDoctors.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose a Doctor:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(503, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Choose a Rendezvous Date:";
            // 
            // FormRendezvous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1747, 737);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormRendezvous";
            this.Text = "FormRendezvous";
            this.Load += new System.EventHandler(this.FormRendezvous_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRendezvousOperation.ResumeLayout(false);
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.groupBoxService.ResumeLayout(false);
            this.groupBoxService.PerformLayout();
            this.groupBoxRendezvous.ResumeLayout(false);
            this.groupBoxRendezvous.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRendezvousOperation;
        private System.Windows.Forms.GroupBox groupBoxRendezvous;
        private System.Windows.Forms.GroupBox groupBoxService;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.TextBox textBoxPatientTRSearch;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxPatients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDoctors;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}