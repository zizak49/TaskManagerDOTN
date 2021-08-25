
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
            this.Processes = new System.Windows.Forms.TabPage();
            this.processName = new System.Windows.Forms.Label();
            this.processesDataGridView = new System.Windows.Forms.DataGridView();
            this.Preformance = new System.Windows.Forms.TabPage();
            this.Services = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Processes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Processes);
            this.tabControl1.Controls.Add(this.Preformance);
            this.tabControl1.Controls.Add(this.Services);
            this.tabControl1.Location = new System.Drawing.Point(13, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // Processes
            // 
            this.Processes.Controls.Add(this.processName);
            this.Processes.Controls.Add(this.processesDataGridView);
            this.Processes.Location = new System.Drawing.Point(4, 24);
            this.Processes.Name = "Processes";
            this.Processes.Padding = new System.Windows.Forms.Padding(3);
            this.Processes.Size = new System.Drawing.Size(767, 409);
            this.Processes.TabIndex = 0;
            this.Processes.Text = "Processes";
            this.Processes.UseVisualStyleBackColor = true;
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
            // processesDataGridView
            // 
            this.processesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processesDataGridView.Location = new System.Drawing.Point(3, 63);
            this.processesDataGridView.Name = "processesDataGridView";
            this.processesDataGridView.RowTemplate.Height = 25;
            this.processesDataGridView.Size = new System.Drawing.Size(761, 343);
            this.processesDataGridView.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Processes.ResumeLayout(false);
            this.Processes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Processes;
        private System.Windows.Forms.TabPage Preformance;
        private System.Windows.Forms.TabPage Services;
        private System.Windows.Forms.Label processName;
        private System.Windows.Forms.DataGridView processesDataGridView;
    }
}

