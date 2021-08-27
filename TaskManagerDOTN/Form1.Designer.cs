
namespace TaskManagerDOTN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SystemInformation = new System.Windows.Forms.TabPage();
            this.osPlatfrom = new System.Windows.Forms.Label();
            this.osVersion = new System.Windows.Forms.Label();
            this.Processes = new System.Windows.Forms.TabPage();
            this.label3totalUsedMemoryVal = new System.Windows.Forms.Label();
            this.totalUsedMemoryText = new System.Windows.Forms.Label();
            this.processMemoryUsageVal = new System.Windows.Forms.Label();
            this.end_process = new System.Windows.Forms.Button();
            this.processesListBox = new System.Windows.Forms.ListBox();
            this.processMemoryUsageText = new System.Windows.Forms.Label();
            this.processName = new System.Windows.Forms.Label();
            this.Preformance = new System.Windows.Forms.TabPage();
            this.Services = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SystemInformation.SuspendLayout();
            this.Processes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SystemInformation);
            this.tabControl1.Controls.Add(this.Processes);
            this.tabControl1.Controls.Add(this.Preformance);
            this.tabControl1.Controls.Add(this.Services);
            this.tabControl1.Location = new System.Drawing.Point(13, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // SystemInformation
            // 
            this.SystemInformation.Controls.Add(this.label1);
            this.SystemInformation.Controls.Add(this.osPlatfrom);
            this.SystemInformation.Controls.Add(this.osVersion);
            this.SystemInformation.Location = new System.Drawing.Point(4, 24);
            this.SystemInformation.Name = "SystemInformation";
            this.SystemInformation.Size = new System.Drawing.Size(767, 409);
            this.SystemInformation.TabIndex = 3;
            this.SystemInformation.Text = "System Information";
            this.SystemInformation.UseVisualStyleBackColor = true;
            // 
            // osPlatfrom
            // 
            this.osPlatfrom.AutoSize = true;
            this.osPlatfrom.Location = new System.Drawing.Point(52, 43);
            this.osPlatfrom.Name = "osPlatfrom";
            this.osPlatfrom.Size = new System.Drawing.Size(56, 15);
            this.osPlatfrom.TabIndex = 1;
            this.osPlatfrom.Text = "Platfrom:";
            // 
            // osVersion
            // 
            this.osVersion.AutoSize = true;
            this.osVersion.Location = new System.Drawing.Point(52, 73);
            this.osVersion.Name = "osVersion";
            this.osVersion.Size = new System.Drawing.Size(66, 15);
            this.osVersion.TabIndex = 0;
            this.osVersion.Text = "OS Version:";
            // 
            // Processes
            // 
            this.Processes.Controls.Add(this.label3totalUsedMemoryVal);
            this.Processes.Controls.Add(this.totalUsedMemoryText);
            this.Processes.Controls.Add(this.processMemoryUsageVal);
            this.Processes.Controls.Add(this.end_process);
            this.Processes.Controls.Add(this.processesListBox);
            this.Processes.Controls.Add(this.processMemoryUsageText);
            this.Processes.Controls.Add(this.processName);
            this.Processes.Location = new System.Drawing.Point(4, 24);
            this.Processes.Name = "Processes";
            this.Processes.Padding = new System.Windows.Forms.Padding(3);
            this.Processes.Size = new System.Drawing.Size(767, 409);
            this.Processes.TabIndex = 0;
            this.Processes.Text = "Processes";
            this.Processes.UseVisualStyleBackColor = true;
            // 
            // label3totalUsedMemoryVal
            // 
            this.label3totalUsedMemoryVal.AutoSize = true;
            this.label3totalUsedMemoryVal.Location = new System.Drawing.Point(205, 45);
            this.label3totalUsedMemoryVal.Name = "label3totalUsedMemoryVal";
            this.label3totalUsedMemoryVal.Size = new System.Drawing.Size(14, 15);
            this.label3totalUsedMemoryVal.TabIndex = 6;
            this.label3totalUsedMemoryVal.Text = "#";
            // 
            // totalUsedMemoryText
            // 
            this.totalUsedMemoryText.AutoSize = true;
            this.totalUsedMemoryText.Location = new System.Drawing.Point(88, 45);
            this.totalUsedMemoryText.Name = "totalUsedMemoryText";
            this.totalUsedMemoryText.Size = new System.Drawing.Size(111, 15);
            this.totalUsedMemoryText.TabIndex = 5;
            this.totalUsedMemoryText.Text = "Total used memory:";
            // 
            // processMemoryUsageVal
            // 
            this.processMemoryUsageVal.AutoSize = true;
            this.processMemoryUsageVal.Location = new System.Drawing.Point(388, 63);
            this.processMemoryUsageVal.Name = "processMemoryUsageVal";
            this.processMemoryUsageVal.Size = new System.Drawing.Size(14, 15);
            this.processMemoryUsageVal.TabIndex = 4;
            this.processMemoryUsageVal.Text = "#";
            // 
            // end_process
            // 
            this.end_process.Location = new System.Drawing.Point(671, 383);
            this.end_process.Name = "end_process";
            this.end_process.Size = new System.Drawing.Size(93, 23);
            this.end_process.TabIndex = 3;
            this.end_process.Text = "End process";
            this.end_process.UseVisualStyleBackColor = true;
            this.end_process.Click += new System.EventHandler(this.end_process_Click);
            // 
            // processesListBox
            // 
            this.processesListBox.FormattingEnabled = true;
            this.processesListBox.ItemHeight = 15;
            this.processesListBox.Location = new System.Drawing.Point(3, 63);
            this.processesListBox.Name = "processesListBox";
            this.processesListBox.Size = new System.Drawing.Size(284, 334);
            this.processesListBox.TabIndex = 2;
            this.processesListBox.SelectedIndexChanged += new System.EventHandler(this.processesListBox_SelectedIndexChanged);
            // 
            // processMemoryUsageText
            // 
            this.processMemoryUsageText.AutoSize = true;
            this.processMemoryUsageText.Location = new System.Drawing.Point(293, 63);
            this.processMemoryUsageText.Name = "processMemoryUsageText";
            this.processMemoryUsageText.Size = new System.Drawing.Size(89, 15);
            this.processMemoryUsageText.TabIndex = 1;
            this.processMemoryUsageText.Text = "Memory usage:";
            // 
            // processName
            // 
            this.processName.AutoSize = true;
            this.processName.Location = new System.Drawing.Point(3, 45);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(39, 15);
            this.processName.TabIndex = 1;
            this.processName.Text = "Name";
            // 
            // Preformance
            // 
            this.Preformance.Location = new System.Drawing.Point(4, 24);
            this.Preformance.Name = "Preformance";
            this.Preformance.Padding = new System.Windows.Forms.Padding(3);
            this.Preformance.Size = new System.Drawing.Size(767, 409);
            this.Preformance.TabIndex = 1;
            this.Preformance.Text = "Preformance";
            this.Preformance.UseVisualStyleBackColor = true;
            // 
            // Services
            // 
            this.Services.Location = new System.Drawing.Point(4, 24);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(767, 409);
            this.Services.TabIndex = 2;
            this.Services.Text = "Services";
            this.Services.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.SystemInformation.ResumeLayout(false);
            this.SystemInformation.PerformLayout();
            this.Processes.ResumeLayout(false);
            this.Processes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Processes;
        private System.Windows.Forms.TabPage Preformance;
        private System.Windows.Forms.TabPage Services;
        private System.Windows.Forms.Label processName;
        private System.Windows.Forms.Label processMemoryUsageText;
        private System.Windows.Forms.ListBox processesListBox;
        private System.Windows.Forms.Button end_process;
        private System.Windows.Forms.Label processMemoryUsageVal;
        private System.Windows.Forms.Label label3totalUsedMemoryVal;
        private System.Windows.Forms.Label totalUsedMemoryText;
        private System.Windows.Forms.TabPage SystemInformation;
        private System.Windows.Forms.Label osVersion;
        private System.Windows.Forms.Label osType;
        private System.Windows.Forms.Label osPlatfrom;
        private System.Windows.Forms.Label label1;
    }
}

