using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewTask : Form
    {
        

        public NewTask()
        {
            InitializeComponent();
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
            date_lbl.Text = date_picker.Value.ToString();
        }

        private void crttask_btn_Click(object sender, EventArgs e) //Didn't do the color change due to laziness
        {
            if (name_txt.Text != "" && desc_txt.Text != "" )
            {
                TaskList.TasksList.Add(new Task(name_txt.Text, desc_txt.Text, false, imp1_rdbtn.Checked != true ? false : true, color_clrdial.Color, date_picker.Value));
            }

            else 
            {
                MessageBox.Show("Как с банком не будет :)"); //Joke for friend
            }
        }
    }
}