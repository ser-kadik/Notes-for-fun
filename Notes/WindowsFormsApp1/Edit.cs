using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//I was really lazy to make this mold. It's a little crooked


namespace WindowsFormsApp1
{
    public partial class Edit : Form
    {
        int index;
        public Edit(int index)
        {
            InitializeComponent();
            this.index = index;
        }

         

        private void color_btn_Click(object sender, EventArgs e)
        {
            if (color_clrdial.ShowDialog() == DialogResult.Cancel)
                return;
            color_lbl.Text = color_clrdial.Color.ToString();
        }

        private void date_btn_Click(object sender, EventArgs e)
        {
            date_lbl.Text = date_picker.Value.ToString();
        }

        private void NewTask_Load(object sender, EventArgs e)
        {
            
        }

        private void edt_btn_Click(object sender, EventArgs e)
        {
            if (name_txt.Text != "" && desc_txt.Text != "")
            {
                TaskList.TasksList[index].Name = name_txt.Text;
                TaskList.TasksList[index].Description = desc_txt.Text;
                TaskList.TasksList[index].IsImportant = imp1_rdbtn.Checked != true ? false : true;
                TaskList.TasksList[index].IsCompleted = false;
                TaskList.TasksList[index].TaskDate = date_picker.Value;
            }

            else
            {
                MessageBox.Show("Как с банком не будет :)"); //Joke for friend
            }

            this.Close();
        }
    }
}
