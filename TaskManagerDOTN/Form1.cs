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
        public Process[] processes;
        private ComputerInfo computerInfo;
        ulong totalMemory;

        public Form1()
        {
            InitializeComponent();
            LoadAllProcesses();
            computerInfo = new ComputerInfo(); 
            LoadSystemInformation();
        }

        private void LoadAllProcesses() 
        {
            processes = Process.GetProcesses();
            processesDataGridView.Columns.Add("Process", "Process");
            processesDataGridView.Columns.Add("PagedMemorySize64", "PagedMemorySize64");

            for (int i = 0; i < processes.Length-1; i++)
            {
                //Proces names
                processesDataGridView.Rows.Add(processes[i].ProcessName);

                //Process memory usage
                long x = processes[i].PagedMemorySize64;

                for (int j = 0; j < 2; j++)
                {
                    x /= 1024;
                }

                processesDataGridView.Rows[i].Cells[1].Value = x + " MB";
            }
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

    }
}
