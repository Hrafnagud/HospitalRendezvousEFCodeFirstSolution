
namespace HospitalRendezvousEFCodeFirstWinFormUI
{
    partial class UC_RendezvousHour
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
            this.btn4500 = new System.Windows.Forms.Button();
            this.btn3045 = new System.Windows.Forms.Button();
            this.btn0015 = new System.Windows.Forms.Button();
            this.btn1530 = new System.Windows.Forms.Button();
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
            this.tableLayoutPanelRendezvousButtons.Controls.Add(this.btn4500, 1, 1);
            this.tableLayoutPanelRendezvousButtons.Controls.Add(this.btn3045, 0, 1);
            this.tableLayoutPanelRendezvousButtons.Controls.Add(this.btn0015, 0, 0);
            this.tableLayoutPanelRendezvousButtons.Controls.Add(this.btn1530, 1, 0);
            this.tableLayoutPanelRendezvousButtons.Location = new System.Drawing.Point(13, 106);
            this.tableLayoutPanelRendezvousButtons.Name = "tableLayoutPanelRendezvousButtons";
            this.tableLayoutPanelRendezvousButtons.RowCount = 2;
            this.tableLayoutPanelRendezvousButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.49833F));
            this.tableLayoutPanelRendezvousButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.50167F));
            this.tableLayoutPanelRendezvousButtons.Size = new System.Drawing.Size(443, 207);
            this.tableLayoutPanelRendezvousButtons.TabIndex = 2;
            // 
            // btn4500
            // 
            this.btn4500.Location = new System.Drawing.Point(224, 105);
            this.btn4500.Name = "btn4500";
            this.btn4500.Size = new System.Drawing.Size(216, 99);
            this.btn4500.TabIndex = 3;
            this.btn4500.Text = "button4";
            this.btn4500.UseVisualStyleBackColor = true;
            // 
            // btn3045
            // 
            this.btn3045.Location = new System.Drawing.Point(3, 105);
            this.btn3045.Name = "btn3045";
            this.btn3045.Size = new System.Drawing.Size(211, 99);
            this.btn3045.TabIndex = 2;
            this.btn3045.Text = "button3";
            this.btn3045.UseVisualStyleBackColor = true;
            // 
            // btn0015
            // 
            this.btn0015.Location = new System.Drawing.Point(3, 3);
            this.btn0015.Name = "btn0015";
            this.btn0015.Size = new System.Drawing.Size(211, 96);
            this.btn0015.TabIndex = 0;
            this.btn0015.Text = "button1";
            this.btn0015.UseVisualStyleBackColor = true;
            // 
            // btn1530
            // 
            this.btn1530.Location = new System.Drawing.Point(224, 3);
            this.btn1530.Name = "btn1530";
            this.btn1530.Size = new System.Drawing.Size(216, 96);
            this.btn1530.TabIndex = 1;
            this.btn1530.Text = "button2";
            this.btn1530.UseVisualStyleBackColor = true;
            // 
            // UC_RendezvousHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.tableLayoutPanelRendezvousButtons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_RendezvousHour";
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
        private System.Windows.Forms.Button btn4500;
        private System.Windows.Forms.Button btn3045;
        private System.Windows.Forms.Button btn0015;
        private System.Windows.Forms.Button btn1530;
    }
}
