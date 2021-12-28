
namespace HospitalRendezvousEFCodeFirstWinFormUI
{
    partial class FormDoctors
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
            this.tabPageDoctorAdd = new System.Windows.Forms.TabPage();
            this.maskedTextBoxDrPhone = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxDrSpecialty = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddDoctor = new System.Windows.Forms.Button();
            this.textBoxDrEmail = new System.Windows.Forms.TextBox();
            this.textDrSurname = new System.Windows.Forms.TextBox();
            this.textDrName = new System.Windows.Forms.TextBox();
            this.textDrTR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.dataGridViewDoctor = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDoctorAdd.SuspendLayout();
            this.tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageDoctorAdd
            // 
            this.tabPageDoctorAdd.Controls.Add(this.maskedTextBoxDrPhone);
            this.tabPageDoctorAdd.Controls.Add(this.comboBoxDrSpecialty);
            this.tabPageDoctorAdd.Controls.Add(this.label6);
            this.tabPageDoctorAdd.Controls.Add(this.buttonAddDoctor);
            this.tabPageDoctorAdd.Controls.Add(this.textBoxDrEmail);
            this.tabPageDoctorAdd.Controls.Add(this.textDrSurname);
            this.tabPageDoctorAdd.Controls.Add(this.textDrName);
            this.tabPageDoctorAdd.Controls.Add(this.textDrTR);
            this.tabPageDoctorAdd.Controls.Add(this.label5);
            this.tabPageDoctorAdd.Controls.Add(this.label4);
            this.tabPageDoctorAdd.Controls.Add(this.label3);
            this.tabPageDoctorAdd.Controls.Add(this.label2);
            this.tabPageDoctorAdd.Controls.Add(this.label1);
            this.tabPageDoctorAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPageDoctorAdd.Name = "tabPageDoctorAdd";
            this.tabPageDoctorAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoctorAdd.Size = new System.Drawing.Size(792, 421);
            this.tabPageDoctorAdd.TabIndex = 1;
            this.tabPageDoctorAdd.Text = "Add Doctor";
            this.tabPageDoctorAdd.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxDrPhone
            // 
            this.maskedTextBoxDrPhone.Location = new System.Drawing.Point(325, 201);
            this.maskedTextBoxDrPhone.Name = "maskedTextBoxDrPhone";
            this.maskedTextBoxDrPhone.Size = new System.Drawing.Size(228, 22);
            this.maskedTextBoxDrPhone.TabIndex = 13;
            // 
            // comboBoxDrSpecialty
            // 
            this.comboBoxDrSpecialty.FormattingEnabled = true;
            this.comboBoxDrSpecialty.Location = new System.Drawing.Point(325, 163);
            this.comboBoxDrSpecialty.Name = "comboBoxDrSpecialty";
            this.comboBoxDrSpecialty.Size = new System.Drawing.Size(228, 24);
            this.comboBoxDrSpecialty.TabIndex = 12;
            this.comboBoxDrSpecialty.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrSpecialty_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Specialty:";
            // 
            // buttonAddDoctor
            // 
            this.buttonAddDoctor.Location = new System.Drawing.Point(206, 299);
            this.buttonAddDoctor.Name = "buttonAddDoctor";
            this.buttonAddDoctor.Size = new System.Drawing.Size(347, 48);
            this.buttonAddDoctor.TabIndex = 10;
            this.buttonAddDoctor.Text = "Add Doctor";
            this.buttonAddDoctor.UseVisualStyleBackColor = true;
            this.buttonAddDoctor.Click += new System.EventHandler(this.buttonAddDoctor_Click);
            // 
            // textBoxDrEmail
            // 
            this.textBoxDrEmail.Location = new System.Drawing.Point(325, 234);
            this.textBoxDrEmail.Name = "textBoxDrEmail";
            this.textBoxDrEmail.Size = new System.Drawing.Size(228, 22);
            this.textBoxDrEmail.TabIndex = 9;
            // 
            // textDrSurname
            // 
            this.textDrSurname.Location = new System.Drawing.Point(325, 127);
            this.textDrSurname.Name = "textDrSurname";
            this.textDrSurname.Size = new System.Drawing.Size(228, 22);
            this.textDrSurname.TabIndex = 7;
            // 
            // textDrName
            // 
            this.textDrName.Location = new System.Drawing.Point(325, 91);
            this.textDrName.Name = "textDrName";
            this.textDrName.Size = new System.Drawing.Size(228, 22);
            this.textDrName.TabIndex = 6;
            // 
            // textDrTR
            // 
            this.textDrTR.Location = new System.Drawing.Point(325, 56);
            this.textDrTR.Name = "textDrTR";
            this.textDrTR.Size = new System.Drawing.Size(228, 22);
            this.textDrTR.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TR ID:";
            // 
            // tabPageList
            // 
            this.tabPageList.Controls.Add(this.dataGridViewDoctor);
            this.tabPageList.Location = new System.Drawing.Point(4, 25);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageList.Size = new System.Drawing.Size(993, 457);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "Doctor List";
            this.tabPageList.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDoctor
            // 
            this.dataGridViewDoctor.AllowUserToAddRows = false;
            this.dataGridViewDoctor.AllowUserToDeleteRows = false;
            this.dataGridViewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDoctor.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDoctor.Name = "dataGridViewDoctor";
            this.dataGridViewDoctor.ReadOnly = true;
            this.dataGridViewDoctor.RowHeadersWidth = 51;
            this.dataGridViewDoctor.RowTemplate.Height = 24;
            this.dataGridViewDoctor.Size = new System.Drawing.Size(987, 451);
            this.dataGridViewDoctor.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageList);
            this.tabControl1.Controls.Add(this.tabPageDoctorAdd);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1001, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // FormDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 486);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDoctors";
            this.Text = "DOCTOR MANAGEMENT FORM";
            this.Load += new System.EventHandler(this.FormDoctors_Load);
            this.tabPageDoctorAdd.ResumeLayout(false);
            this.tabPageDoctorAdd.PerformLayout();
            this.tabPageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageDoctorAdd;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.DataGridView dataGridViewDoctor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBoxDrEmail;
        private System.Windows.Forms.TextBox textDrSurname;
        private System.Windows.Forms.TextBox textDrName;
        private System.Windows.Forms.TextBox textDrTR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddDoctor;
        private System.Windows.Forms.ComboBox comboBoxDrSpecialty;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDrPhone;
    }
}