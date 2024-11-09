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
    public partial class TaskDesignPanel : UserControl
    {
        Form1 form1;
        

        public TaskDesignPanel(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

        }

        private Task task;

        public string TaskDesignName
        {
            get 
            {
                return taskDesignName_lbl.Text;
            }

            set 
            {
                taskDesignName_lbl.Text = value;
            }
        }

        public string TaskDesignDescription
        {
            get
            {
                return TaskDesignDescription_lbl.Text;
            }

            set
            {
                TaskDesignDescription_lbl.Text = value;
            }
        }

        public bool TaskDesignImportant
        {
            get
            {
                if (TaskDesignImportant_lbl.Visible != true && TaskDesignImportant_lbl.Text != "Important")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            set
            {
                if (value != true)
                {
                    TaskDesignImportant_lbl.Visible = false;
                }
                else
                {
                    TaskDesignImportant_lbl.Visible = true;
                }
            }
        }

        public string TaskDesignDate
        {
            get
            {
                return TaskDesignDate_lbl.Text;
            }

            set
            {
                TaskDesignDate_lbl.Text = value;
            }
        }

        public bool TaskDesignCompleate 
        {
            get
            {
                if (cmp_lbl.Visible != true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            set
            {
                if (value != true)
                {
                    cmp_lbl.Visible = false;
                }
                else
                {
                    cmp_lbl.Visible = true;
                    cmp_btn.Visible = false;
                    button2.Visible = false;
                }
            }
        }


        public Task TaskData
        {
            set 
            {
                task = value;
            }
        }


        int index;

        private void cmp_btn_Click(object sender, EventArgs e)
        {
            index = TaskList.TasksList.IndexOf(task);
            TaskList.TasksList[index].IsCompleted = true;
            if (MessageBox.Show("Вы уверены, что хотите удалить задание", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                form1.OpenChildForm(new AllTask(form1));
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = TaskList.TasksList.IndexOf(task);
            Edit edt = new Edit(index);
            edt.ShowDialog();
            if (edt.DialogResult == DialogResult.Cancel)
            {
                form1.OpenChildForm(new AllTask(form1));
            }
        }
        }
    }


