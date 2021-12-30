
namespace HospitalRendezvousEFCodeFirstWinFormUI
{
    partial class FormHome
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
            this.buttonDoctorOperations = new System.Windows.Forms.Button();
            this.buttonPatientOperations = new System.Windows.Forms.Button();
            this.buttonRendezvousOperations = new System.Windows.Forms.Button();
            this.buttonBringPatients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDoctorOperations
            // 
            this.buttonDoctorOperations.Location = new System.Drawing.Point(236, 57);
            this.buttonDoctorOperations.Name = "buttonDoctorOperations";
            this.buttonDoctorOperations.Size = new System.Drawing.Size(302, 69);
            this.buttonDoctorOperations.TabIndex = 0;
            this.buttonDoctorOperations.Text = "Doctor Operations Form";
            this.buttonDoctorOperations.UseVisualStyleBackColor = true;
            this.buttonDoctorOperations.Click += new System.EventHandler(this.buttonDoctorOperations_Click);
            // 
            // buttonPatientOperations
            // 
            this.buttonPatientOperations.Location = new System.Drawing.Point(236, 182);
            this.buttonPatientOperations.Name = "buttonPatientOperations";
            this.buttonPatientOperations.Size = new System.Drawing.Size(302, 69);
            this.buttonPatientOperations.TabIndex = 1;
            this.buttonPatientOperations.Text = "Patient Operations Form";
            this.buttonPatientOperations.UseVisualStyleBackColor = true;
            // 
            // buttonRendezvousOperations
            // 
            this.buttonRendezvousOperations.Location = new System.Drawing.Point(236, 318);
            this.buttonRendezvousOperations.Name = "buttonRendezvousOperations";
            this.buttonRendezvousOperations.Size = new System.Drawing.Size(302, 69);
            this.buttonRendezvousOperations.TabIndex = 2;
            this.buttonRendezvousOperations.Text = "Rendezvous Operations Form";
            this.buttonRendezvousOperations.UseVisualStyleBackColor = true;
            this.buttonRendezvousOperations.Click += new System.EventHandler(this.buttonRendezvousOperations_Click);
            // 
            // buttonBringPatients
            // 
            this.buttonBringPatients.Location = new System.Drawing.Point(236, 433);
            this.buttonBringPatients.Name = "buttonBringPatients";
            this.buttonBringPatients.Size = new System.Drawing.Size(302, 69);
            this.buttonBringPatients.TabIndex = 3;
            this.buttonBringPatients.Text = "BRING PATIENTS FORM";
            this.buttonBringPatients.UseVisualStyleBackColor = true;
            this.buttonBringPatients.Click += new System.EventHandler(this.buttonBringPatients_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 571);
            this.Controls.Add(this.buttonBringPatients);
            this.Controls.Add(this.buttonRendezvousOperations);
            this.Controls.Add(this.buttonPatientOperations);
            this.Controls.Add(this.buttonDoctorOperations);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDoctorOperations;
        private System.Windows.Forms.Button buttonPatientOperations;
        private System.Windows.Forms.Button buttonRendezvousOperations;
        private System.Windows.Forms.Button buttonBringPatients;
    }
}