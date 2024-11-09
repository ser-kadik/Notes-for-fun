using System;
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
    static class TaskList
    {
        public static List<Task> TasksList { get; set; } = new List<Task>();
        //public static Form currentChildForm { get; set; }

        public static int GetTaskId(string value)
        {
            for (int i = 0; i < TasksList.Count; i++)
            {
                if (TasksList[i].Name == value && TasksList[i].IsCompleted != true)
                {
                    return i;
                }
            }
            return -1;
        }

      


    }
}
