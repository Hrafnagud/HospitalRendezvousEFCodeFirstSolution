
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
            this.UC_RendezvousHours1 = new HospitalRendezvousEFCodeFirstWinFormUI.UC_RendezvousHours();
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
            this.tabPageOutputSummary = new System.Windows.Forms.TabPage();
            this.comboBoxOutputSummaryChooseDoctor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerOutputSummary = new System.Windows.Forms.DateTimePicker();
            this.btnOutputSummary = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.listViewBookedRendezvous = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPageRendezvousOperation.SuspendLayout();
            this.groupBoxRendezvous.SuspendLayout();
            this.groupBoxService.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            this.tabPageOutputSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRendezvousOperation);
            this.tabControl1.Controls.Add(this.tabPageOutputSummary);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1735, 735);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPageRendezvousOperation
            // 
            this.tabPageRendezvousOperation.Controls.Add(this.listViewBookedRendezvous);
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
            // UC_RendezvousHours1
            // 
            this.UC_RendezvousHours1.BackColor = System.Drawing.Color.LightCyan;
            this.UC_RendezvousHours1.IncomingDate = new System.DateTime(2021, 12, 30, 14, 9, 22, 624);
            this.UC_RendezvousHours1.IsRendezvousButtonActive = false;
            this.UC_RendezvousHours1.Location = new System.Drawing.Point(38, 93);
            this.UC_RendezvousHours1.myDoctor = null;
            this.UC_RendezvousHours1.Name = "UC_RendezvousHours1";
            this.UC_RendezvousHours1.RendezvousDateToBeBooked = new System.DateTime(((long)(0)));
            this.UC_RendezvousHours1.Size = new System.Drawing.Size(702, 333);
            this.UC_RendezvousHours1.TabIndex = 1;
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
            // tabPageOutputSummary
            // 
            this.tabPageOutputSummary.Controls.Add(this.comboBoxOutputSummaryChooseDoctor);
            this.tabPageOutputSummary.Controls.Add(this.label6);
            this.tabPageOutputSummary.Controls.Add(this.dateTimePickerOutputSummary);
            this.tabPageOutputSummary.Controls.Add(this.btnOutputSummary);
            this.tabPageOutputSummary.Controls.Add(this.label5);
            this.tabPageOutputSummary.Location = new System.Drawing.Point(4, 25);
            this.tabPageOutputSummary.Name = "tabPageOutputSummary";
            this.tabPageOutputSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutputSummary.Size = new System.Drawing.Size(1727, 706);
            this.tabPageOutputSummary.TabIndex = 1;
            this.tabPageOutputSummary.Text = "Doctor Rendezvous Summary Output";
            this.tabPageOutputSummary.UseVisualStyleBackColor = true;
            // 
            // comboBoxOutputSummaryChooseDoctor
            // 
            this.comboBoxOutputSummaryChooseDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxOutputSummaryChooseDoctor.FormattingEnabled = true;
            this.comboBoxOutputSummaryChooseDoctor.Location = new System.Drawing.Point(442, 79);
            this.comboBoxOutputSummaryChooseDoctor.Name = "comboBoxOutputSummaryChooseDoctor";
            this.comboBoxOutputSummaryChooseDoctor.Size = new System.Drawing.Size(1010, 28);
            this.comboBoxOutputSummaryChooseDoctor.TabIndex = 5;
            this.comboBoxOutputSummaryChooseDoctor.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutputSummaryChooseDoctor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(220, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "CHOOSE A DATE:";
            // 
            // dateTimePickerOutputSummary
            // 
            this.dateTimePickerOutputSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerOutputSummary.Location = new System.Drawing.Point(442, 133);
            this.dateTimePickerOutputSummary.Name = "dateTimePickerOutputSummary";
            this.dateTimePickerOutputSummary.Size = new System.Drawing.Size(1010, 27);
            this.dateTimePickerOutputSummary.TabIndex = 3;
            this.dateTimePickerOutputSummary.ValueChanged += new System.EventHandler(this.dateTimePickerOutputSummary_ValueChanged);
            // 
            // btnOutputSummary
            // 
            this.btnOutputSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOutputSummary.Location = new System.Drawing.Point(442, 216);
            this.btnOutputSummary.Name = "btnOutputSummary";
            this.btnOutputSummary.Size = new System.Drawing.Size(1010, 46);
            this.btnOutputSummary.TabIndex = 2;
            this.btnOutputSummary.Text = "OUTPUT SUMMARY";
            this.btnOutputSummary.UseVisualStyleBackColor = true;
            this.btnOutputSummary.Click += new System.EventHandler(this.btnOutputSummary_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(220, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // listViewBookedRendezvous
            // 
            this.listViewBookedRendezvous.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewBookedRendezvous.FullRowSelect = true;
            this.listViewBookedRendezvous.GridLines = true;
            this.listViewBookedRendezvous.HideSelection = false;
            this.listViewBookedRendezvous.Location = new System.Drawing.Point(8, 520);
            this.listViewBookedRendezvous.Name = "listViewBookedRendezvous";
            this.listViewBookedRendezvous.Size = new System.Drawing.Size(1713, 154);
            this.listViewBookedRendezvous.TabIndex = 1;
            this.listViewBookedRendezvous.UseCompatibleStateImageBehavior = false;
            this.listViewBookedRendezvous.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Doctor";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "Patient";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 0;
            this.columnHeader3.Text = "Service";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rendezvous Date";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
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
            this.tabPageOutputSummary.ResumeLayout(false);
            this.tabPageOutputSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRendezvousOperation;
        private System.Windows.Forms.GroupBox groupBoxRendezvous;
        private System.Windows.Forms.GroupBox groupBoxService;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.TextBox textBoxPatientTRSearch;
        private System.Windows.Forms.TabPage tabPageOutputSummary;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerOutputSummary;
        private System.Windows.Forms.ComboBox comboBoxOutputSummaryChooseDoctor;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ListView listViewBookedRendezvous;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}