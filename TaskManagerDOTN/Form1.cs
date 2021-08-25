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

namespace TaskManagerDOTN
{
    public partial class Form1 : Form
    {
        public Process[] processes;

        public Form1()
        {
            InitializeComponent();
            LoadAllProcesses();
        }

        private void LoadAllProcesses() 
        {
            processes = Process.GetProcesses();
            processesDataGridView.Columns.Add("Process", "Process");
            processesDataGridView.Columns.Add("PagedMemorySize64", "PagedMemorySize64");

            for (int i = 0; i < processes.Length-1; i++)
            {
                processesDataGridView.Rows.Add(processes[i].ProcessName);
                processesDataGridView.Rows[i].Cells[1].Value = processes[i].PagedMemorySize64;
            }          
        }

    }
}
