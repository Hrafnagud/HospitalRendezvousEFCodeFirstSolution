
namespace HospitalRendezvousEFCodeFirstWinFormUI
{
    partial class FormCallPatient
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.labelPatient = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHOOSE DOCTOR";
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(24, 64);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(282, 24);
            this.comboBoxDoctor.TabIndex = 1;
            this.comboBoxDoctor.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoctor_SelectedIndexChanged);
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(425, 34);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(198, 54);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "BEGIN";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(425, 108);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(198, 52);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPatient.Location = new System.Drawing.Point(21, 313);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(45, 29);
            this.labelPatient.TabIndex = 4;
            this.labelPatient.Text = "----";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormCallPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 442);
            this.Controls.Add(this.labelPatient);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.label1);
            this.Name = "FormCallPatient";
            this.Text = "FormCallPatient";
            this.Load += new System.EventHandler(this.FormCallDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Timer timer1;
    }
}