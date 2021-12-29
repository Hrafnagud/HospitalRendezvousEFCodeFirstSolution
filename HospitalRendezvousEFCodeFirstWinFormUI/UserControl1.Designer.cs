
namespace HospitalRendezvousEFCodeFirstWinFormUI
{
    partial class UC_RendezvousHours
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxHours = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelRendezvousButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn45 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelRendezvousButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxHours, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.39362F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxHours
            // 
            this.comboBoxHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxHours.FormattingEnabled = true;
            this.comboBoxHours.Location = new System.Drawing.Point(3, 3);
            this.comboBoxHours.Name = "comboBoxHours";
            this.comboBoxHours.Size = new System.Drawing.Size(437, 24);
            this.comboBoxHours.TabIndex = 1;
            this.comboBoxHours.SelectedIndexChanged += new System.EventHandler(this.comboBoxHours_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Available Hours";
            // 
            // tableLayoutPanelRendezvousButtons
            // 
            this.tableLayoutPanelRendezvousButtons.ColumnCount = 2;
            this.tableLayoutPanelRendezvousButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRendezvousButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRendezvousButtons.Controls.Add(this.btn45, 1, 1);
            this.tableLayoutPanelRendezvousButtons.Controls.Add(this.btn30, 0, 1);
            this.tableLayoutPanelRendezvousButtons.Controls.Add(this.btn00, 0, 0);
            this.tableLayoutPanelRendezvousButtons.Controls.Add(this.btn15, 1, 0);
            this.tableLayoutPanelRendezvousButtons.Location = new System.Drawing.Point(13, 106);
            this.tableLayoutPanelRendezvousButtons.Name = "tableLayoutPanelRendezvousButtons";
            this.tableLayoutPanelRendezvousButtons.RowCount = 2;
            this.tableLayoutPanelRendezvousButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.49833F));
            this.tableLayoutPanelRendezvousButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.50167F));
            this.tableLayoutPanelRendezvousButtons.Size = new System.Drawing.Size(443, 207);
            this.tableLayoutPanelRendezvousButtons.TabIndex = 2;
            // 
            // btn45
            // 
            this.btn45.Location = new System.Drawing.Point(224, 105);
            this.btn45.Name = "btn45";
            this.btn45.Size = new System.Drawing.Size(216, 99);
            this.btn45.TabIndex = 3;
            this.btn45.Text = "button4";
            this.btn45.UseVisualStyleBackColor = true;
            // 
            // btn30
            // 
            this.btn30.Location = new System.Drawing.Point(3, 105);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(211, 99);
            this.btn30.TabIndex = 2;
            this.btn30.Text = "button3";
            this.btn30.UseVisualStyleBackColor = true;
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(3, 3);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(211, 96);
            this.btn00.TabIndex = 0;
            this.btn00.Text = "button1";
            this.btn00.UseVisualStyleBackColor = true;
            // 
            // btn15
            // 
            this.btn15.Location = new System.Drawing.Point(224, 3);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(216, 96);
            this.btn15.TabIndex = 1;
            this.btn15.Text = "button2";
            this.btn15.UseVisualStyleBackColor = true;
            // 
            // UC_RendezvousHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.tableLayoutPanelRendezvousButtons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_RendezvousHours";
            this.Size = new System.Drawing.Size(468, 330);
            this.Load += new System.EventHandler(this.UC_RendezvousHour_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelRendezvousButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRendezvousButtons;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn15;
    }
}
