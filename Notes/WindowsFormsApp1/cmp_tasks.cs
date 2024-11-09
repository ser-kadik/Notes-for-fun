﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class cmp_tasks : Form
    {
        Form1 form1;
        public cmp_tasks(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        void Reload(List<Task> loadList)
        {
            for (int i = 0; i < loadList.Count; i++)
            {
                if (loadList[i].IsCompleted != false)
                {
                    TaskDesignPanel Task1 = new TaskDesignPanel(form1);
                    Task1.TaskDesignName = loadList[i].Name;
                    Task1.TaskDesignDescription = loadList[i].Description;
                    Task1.TaskDesignImportant = loadList[i].IsImportant;
                    Task1.TaskDesignDate = loadList[i].TaskDate.ToString();
                    Task1.TaskDesignCompleate = loadList[i].IsCompleted;
                    Task1.TaskData = loadList[i];

                    cmptask_flwpnl.Controls.Add(Task1);
                }
            }
        }

        private void cmp_tasks_Load(object sender, EventArgs e)
        {
            Reload(TaskList.TasksList);
        }
    }
}
