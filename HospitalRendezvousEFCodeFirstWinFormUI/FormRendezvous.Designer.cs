
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
            this.groupBoxRendezvous = new System.Windows.Forms.GroupBox();
            this.btnBookRendezvous = new System.Windows.Forms.Button();
            this.dateTimePickerRendezvousDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxService = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDoctors = new System.Windows.Forms.ListBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.listBoxPatients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPatientTRSearch = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOutputSummary = new System.Windows.Forms.Button();
            this.comboBoxOutputChooseDoctor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UC_RendezvousHours1 = new HospitalRendezvousEFCodeFirstWinFormUI.UC_RendezvousHours();
            this.tabControl1.SuspendLayout();
            this.tabPageRendezvousOperation.SuspendLayout();
            this.groupBoxRendezvous.SuspendLayout();
            this.groupBoxService.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // groupBoxRendezvous
            // 
            this.groupBoxRendezvous.Controls.Add(this.btnBookRendezvous);
            this.groupBoxRendezvous.Controls.Add(this.UC_RendezvousHours1);
            this.groupBoxRendezvous.Controls.Add(this.dateTimePickerRendezvousDate);
            this.groupBoxRendezvous.Location = new System.Drawing.Point(930, 21);
            this.groupBoxRendezvous.Name = "groupBoxRendezvous";
            this.groupBoxRendezvous.Size = new System.Drawing.Size(764, 493);
            this.groupBoxRendezvous.TabIndex = 2;
            this.groupBoxRendezvous.TabStop = false;
            this.groupBoxRendezvous.Text = "Rendezvous Date and Time";
            // 
            // btnBookRendezvous
            // 
            this.btnBookRendezvous.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookRendezvous.Location = new System.Drawing.Point(38, 441);
            this.btnBookRendezvous.Name = "btnBookRendezvous";
            this.btnBookRendezvous.Size = new System.Drawing.Size(702, 42);
            this.btnBookRendezvous.TabIndex = 2;
            this.btnBookRendezvous.Text = "Book Rendezvous";
            this.btnBookRendezvous.UseVisualStyleBackColor = true;
            this.btnBookRendezvous.Click += new System.EventHandler(this.btnBookRendezvous_Click);
            // 
            // dateTimePickerRendezvousDate
            // 
            this.dateTimePickerRendezvousDate.Location = new System.Drawing.Point(237, 45);
            this.dateTimePickerRendezvousDate.Name = "dateTimePickerRendezvousDate";
            this.dateTimePickerRendezvousDate.Size = new System.Drawing.Size(503, 22);
            this.dateTimePickerRendezvousDate.TabIndex = 0;
            this.dateTimePickerRendezvousDate.ValueChanged += new System.EventHandler(this.dateTimePickerRendezvousDate_ValueChanged);
            // 
            // groupBoxService
            // 
            this.groupBoxService.Controls.Add(this.label3);
            this.groupBoxService.Controls.Add(this.listBoxDoctors);
            this.groupBoxService.Controls.Add(this.comboBoxService);
            this.groupBoxService.Controls.Add(this.label2);
            this.groupBoxService.Location = new System.Drawing.Point(479, 21);
            this.groupBoxService.Name = "groupBoxService";
            this.groupBoxService.Size = new System.Drawing.Size(407, 493);
            this.groupBoxService.TabIndex = 1;
            this.groupBoxService.TabStop = false;
            this.groupBoxService.Text = "Service and Doctor Selection";
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
            // listBoxDoctors
            // 
            this.listBoxDoctors.FormattingEnabled = true;
            this.listBoxDoctors.ItemHeight = 16;
            this.listBoxDoctors.Location = new System.Drawing.Point(20, 113);
            this.listBoxDoctors.Name = "listBoxDoctors";
            this.listBoxDoctors.Size = new System.Drawing.Size(368, 324);
            this.listBoxDoctors.TabIndex = 5;
            this.listBoxDoctors.SelectedIndexChanged += new System.EventHandler(this.listBoxDoctors_SelectedIndexChanged);
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(146, 45);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(242, 24);
            this.comboBoxService.TabIndex = 4;
            this.comboBoxService.SelectedIndexChanged += new System.EventHandler(this.comboBoxService_SelectedIndexChanged);
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
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.listBoxPatients);
            this.groupBoxPatient.Controls.Add(this.label1);
            this.groupBoxPatient.Controls.Add(this.textBoxPatientTRSearch);
            this.groupBoxPatient.Location = new System.Drawing.Point(8, 21);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(430, 493);
            this.groupBoxPatient.TabIndex = 0;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Choose a Patient";
            // 
            // listBoxPatients
            // 
            this.listBoxPatients.FormattingEnabled = true;
            this.listBoxPatients.ItemHeight = 16;
            this.listBoxPatients.Location = new System.Drawing.Point(23, 81);
            this.listBoxPatients.Name = "listBoxPatients";
            this.listBoxPatients.Size = new System.Drawing.Size(388, 356);
            this.listBoxPatients.TabIndex = 2;
            this.listBoxPatients.SelectedIndexChanged += new System.EventHandler(this.listBoxPatients_SelectedIndexChanged);
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
            // textBoxPatientTRSearch
            // 
            this.textBoxPatientTRSearch.Location = new System.Drawing.Point(171, 41);
            this.textBoxPatientTRSearch.Name = "textBoxPatientTRSearch";
            this.textBoxPatientTRSearch.Size = new System.Drawing.Size(240, 22);
            this.textBoxPatientTRSearch.TabIndex = 0;
            this.textBoxPatientTRSearch.TextChanged += new System.EventHandler(this.textBoxPatientTRSearch_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnOutputSummary);
            this.tabPage2.Controls.Add(this.comboBoxOutputChooseDoctor);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1727, 706);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOutputSummary
            // 
            this.btnOutputSummary.Location = new System.Drawing.Point(432, 110);
            this.btnOutputSummary.Name = "btnOutputSummary";
            this.btnOutputSummary.Size = new System.Drawing.Size(1010, 46);
            this.btnOutputSummary.TabIndex = 2;
            this.btnOutputSummary.Text = "Output Summary";
            this.btnOutputSummary.UseVisualStyleBackColor = true;
            // 
            // comboBoxOutputChooseDoctor
            // 
            this.comboBoxOutputChooseDoctor.Location = new System.Drawing.Point(432, 51);
            this.comboBoxOutputChooseDoctor.Name = "comboBoxOutputChooseDoctor";
            this.comboBoxOutputChooseDoctor.Size = new System.Drawing.Size(1010, 22);
            this.comboBoxOutputChooseDoctor.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "CHOOSE A DOCTOR:";
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
            // UC_RendezvousHours1
            // 
            this.UC_RendezvousHours1.BackColor = System.Drawing.Color.LightCyan;
            this.UC_RendezvousHours1.IncomingDate = new System.DateTime(2021, 12, 29, 14, 58, 40, 65);
            this.UC_RendezvousHours1.IsRendezvousButtonActive = false;
            this.UC_RendezvousHours1.Location = new System.Drawing.Point(38, 93);
            this.UC_RendezvousHours1.myDoctor = null;
            this.UC_RendezvousHours1.Name = "UC_RendezvousHours1";
            this.UC_RendezvousHours1.RendezvousDateToBeBooked = new System.DateTime(((long)(0)));
            this.UC_RendezvousHours1.Size = new System.Drawing.Size(702, 333);
            this.UC_RendezvousHours1.TabIndex = 1;
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
            this.groupBoxRendezvous.ResumeLayout(false);
            this.groupBoxService.ResumeLayout(false);
            this.groupBoxService.PerformLayout();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dateTimePickerRendezvousDate;
        private UC_RendezvousHours UC_RendezvousHours1;
        private System.Windows.Forms.Button btnBookRendezvous;
        private System.Windows.Forms.Button btnOutputSummary;
        private System.Windows.Forms.TextBox comboBoxOutputChooseDoctor;
        private System.Windows.Forms.Label label5;
    }
}