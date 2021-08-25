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
            processesDataGridView.Columns.Add("Name","Name");
            foreach (Process process in processes)
            {
                processesDataGridView.Rows.Add(process.ProcessName);
            }
        }

    }
}
