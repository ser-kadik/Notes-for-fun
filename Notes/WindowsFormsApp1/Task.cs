using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Task
    {
        public string Name{ get; set; }
        public string Description{ get; set; }
        public bool IsCompleted { get; set; }
        public bool IsImportant {  get; set; }
        public Color TaskColor{ get; set; }
        public DateTime TaskDate{ get; set; }

        public Task(string name, string description, bool isCompleted, bool isImportant, Color taskColor, DateTime taskDate)
        {
            Name = name;
            Description = description;
            IsCompleted = isCompleted;
            IsImportant = isImportant;
            TaskColor = taskColor;
            TaskDate = taskDate;
        }
    }
}
