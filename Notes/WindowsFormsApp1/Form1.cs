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
    public partial class Form1 : Form
    {
        bool drag = false;
        Point StartPoint = new Point(0, 0);
        Form currentChildForm;


        public Form1()
        {
            InitializeComponent();

        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            form_pnl.Controls.Add(childForm);
            form_pnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

       
      
        

        private void ext_btn_MouseEnter(object sender, EventArgs e)
        {
            ext_btn.BackColor = Color.DarkRed;
        }

        private void ext_btn_MouseLeave(object sender, EventArgs e)
        {
            ext_btn.BackColor = Color.Red;
        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void min_btn_MouseLeave(object sender, EventArgs e)
        {
            min_btn.BackColor = Color.Blue;
        }

        private void min_btn_MouseEnter(object sender, EventArgs e)
        {
            min_btn.BackColor = Color.DarkBlue;
        }

        private void cntr_pnl_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void cntr_pnl_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void cntr_pnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - StartPoint.X, p.Y - StartPoint.Y);
            }
        }

        private void alltask_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllTask(this));
        }

        private void imptask_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ImpTask(this));
        }

        private void cmptask_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new cmp_tasks(this));
        }

        private void newtask_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewTask());
        }
    }
}