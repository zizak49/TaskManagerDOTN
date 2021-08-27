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
        public List<Process> processes;
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

            listBox1.DataSource = processes;
            listBox1.ValueMember = "ProcessName";
            listBox1.Refresh();


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

    }
}
