using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using Microsoft.VisualBasic.Devices;

namespace TaskManagerDOTN
{
    public partial class Form1 : Form
    {
        private List<Process> processes;
        private Process selectedProcess;
        private int selectedProcessIndex;
        private ComputerInfo computerInfo;

        private ulong totalMemory;
        private long totalUsedMemory = 0;




        public Form1()
        {
            InitializeComponent();
            LoadAllProcesses();
            computerInfo = new ComputerInfo(); 
            LoadSystemInformation();
        }

        private void LoadAllProcesses() 
        {
            processes = Process.GetProcesses().ToList();

            foreach (Process process in processes)
            {
                processesListBox.Items.Add(process);
            }
            processesListBox.ValueMember = "ProcessName";


                //Process memory usage
                /*long pagedMemory = processes[i].WorkingSet64;

                for (int j = 0; j < 2; j++)
                {
                    pagedMemory /= 1024;
                }
                processesDataGridView.Rows[i].Cells[1].Value = pagedMemory + " MB";
                totalUsedMemory += pagedMemory;
                label1.Text = totalUsedMemory.ToString();*/
        }

        private void LoadSystemInformation() 
        {
            totalMemory = computerInfo.TotalPhysicalMemory;

            for (int i = 0; i < 2; i++)
            {
                totalMemory = totalMemory / 1024;
            }

            totalMemory = totalMemory / 1000;
        }

        private void UpdateMemory()
        {
           
        }

        private void end_process_Click(object sender, EventArgs e)
        {
            selectedProcess = processes[processesListBox.SelectedIndex];

            selectedProcess.Kill();
            selectedProcess.WaitForExit();

            processes.Remove(selectedProcess);
            processesListBox.Items.RemoveAt(processesListBox.SelectedIndex);

            processesListBox.Refresh();
        }

        private void processesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DisplayProcessInfo(processes[processesListBox.SelectedIndex]);
            }
            catch (Exception) 
            { 
            
                processesListBox.SelectedIndex = 1;
            }
        }

        private void DisplayProcessInfo(Process selectedProcess) 
        {
            memoryVal.Text = ConvertToMB(selectedProcess.WorkingSet64).ToString() + " MB";
        }

        private long ConvertToMB(long number) 
        {
            for (int i = 0; i < 2; i++)
            {
                number /= 1024;
            }
            return number;
        }
    }
}
