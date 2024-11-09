namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cntr_pnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.min_btn = new System.Windows.Forms.Button();
            this.ext_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imptask_btn = new System.Windows.Forms.Button();
            this.newtask_btn = new System.Windows.Forms.Button();
            this.cmptask_btn = new System.Windows.Forms.Button();
            this.alltask_btn = new System.Windows.Forms.Button();
            this.form_pnl = new System.Windows.Forms.Panel();
            this.cntr_pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntr_pnl
            // 
            this.cntr_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(61)))), ((int)(((byte)(117)))));
            this.cntr_pnl.Controls.Add(this.label1);
            this.cntr_pnl.Controls.Add(this.min_btn);
            this.cntr_pnl.Controls.Add(this.ext_btn);
            this.cntr_pnl.Location = new System.Drawing.Point(0, 0);
            this.cntr_pnl.Name = "cntr_pnl";
            this.cntr_pnl.Size = new System.Drawing.Size(800, 30);
            this.cntr_pnl.TabIndex = 0;
            this.cntr_pnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cntr_pnl_MouseDown);
            this.cntr_pnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cntr_pnl_MouseMove);
            this.cntr_pnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cntr_pnl_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task Proffesional";
            // 
            // min_btn
            // 
            this.min_btn.BackColor = System.Drawing.Color.Blue;
            this.min_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.min_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.min_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.min_btn.Location = new System.Drawing.Point(741, 3);
            this.min_btn.Name = "min_btn";
            this.min_btn.Size = new System.Drawing.Size(25, 24);
            this.min_btn.TabIndex = 1;
            this.min_btn.Text = "-";
            this.min_btn.UseVisualStyleBackColor = false;
            this.min_btn.Click += new System.EventHandler(this.min_btn_Click);
            this.min_btn.MouseEnter += new System.EventHandler(this.min_btn_MouseEnter);
            this.min_btn.MouseLeave += new System.EventHandler(this.min_btn_MouseLeave);
            // 
            // ext_btn
            // 
            this.ext_btn.BackColor = System.Drawing.Color.Red;
            this.ext_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ext_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ext_btn.Location = new System.Drawing.Point(772, 3);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(25, 24);
            this.ext_btn.TabIndex = 1;
            this.ext_btn.Text = "X";
            this.ext_btn.UseVisualStyleBackColor = false;
            this.ext_btn.Click += new System.EventHandler(this.ext_btn_Click);
            this.ext_btn.MouseEnter += new System.EventHandler(this.ext_btn_MouseEnter);
            this.ext_btn.MouseLeave += new System.EventHandler(this.ext_btn_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(62)))), ((int)(((byte)(150)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.imptask_btn);
            this.panel2.Controls.Add(this.newtask_btn);
            this.panel2.Controls.Add(this.cmptask_btn);
            this.panel2.Controls.Add(this.alltask_btn);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 523);
            this.panel2.TabIndex = 1;
            // 
            // imptask_btn
            // 
            this.imptask_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.imptask_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.imptask_btn.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imptask_btn.ForeColor = System.Drawing.Color.White;
            this.imptask_btn.Location = new System.Drawing.Point(19, 139);
            this.imptask_btn.Name = "imptask_btn";
            this.imptask_btn.Size = new System.Drawing.Size(165, 94);
            this.imptask_btn.TabIndex = 0;
            this.imptask_btn.Text = "Important\r\n tasks";
            this.imptask_btn.UseVisualStyleBackColor = false;
            this.imptask_btn.Click += new System.EventHandler(this.imptask_btn_Click);
            // 
            // newtask_btn
            // 
            this.newtask_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.newtask_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newtask_btn.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newtask_btn.ForeColor = System.Drawing.Color.White;
            this.newtask_btn.Location = new System.Drawing.Point(19, 381);
            this.newtask_btn.Name = "newtask_btn";
            this.newtask_btn.Size = new System.Drawing.Size(165, 92);
            this.newtask_btn.TabIndex = 0;
            this.newtask_btn.Text = "New task";
            this.newtask_btn.UseVisualStyleBackColor = false;
            this.newtask_btn.Click += new System.EventHandler(this.newtask_btn_Click);
            // 
            // cmptask_btn
            // 
            this.cmptask_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.cmptask_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmptask_btn.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmptask_btn.ForeColor = System.Drawing.Color.White;
            this.cmptask_btn.Location = new System.Drawing.Point(19, 257);
            this.cmptask_btn.Name = "cmptask_btn";
            this.cmptask_btn.Size = new System.Drawing.Size(165, 94);
            this.cmptask_btn.TabIndex = 0;
            this.cmptask_btn.Text = "Compleate tasks";
            this.cmptask_btn.UseVisualStyleBackColor = false;
            this.cmptask_btn.Click += new System.EventHandler(this.cmptask_btn_Click);
            // 
            // alltask_btn
            // 
            this.alltask_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.alltask_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alltask_btn.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alltask_btn.ForeColor = System.Drawing.Color.White;
            this.alltask_btn.Location = new System.Drawing.Point(19, 28);
            this.alltask_btn.Name = "alltask_btn";
            this.alltask_btn.Size = new System.Drawing.Size(165, 92);
            this.alltask_btn.TabIndex = 0;
            this.alltask_btn.Text = "All Tasks";
            this.alltask_btn.UseVisualStyleBackColor = false;
            this.alltask_btn.Click += new System.EventHandler(this.alltask_btn_Click);
            // 
            // form_pnl
            // 
            this.form_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(23)))), ((int)(((byte)(115)))));
            this.form_pnl.Location = new System.Drawing.Point(208, 30);
            this.form_pnl.Name = "form_pnl";
            this.form_pnl.Size = new System.Drawing.Size(592, 523);
            this.form_pnl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.ControlBox = false;
            this.Controls.Add(this.form_pnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cntr_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.cntr_pnl.ResumeLayout(false);
            this.cntr_pnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cntr_pnl;
        private System.Windows.Forms.Button min_btn;
        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button imptask_btn;
        private System.Windows.Forms.Button cmptask_btn;
        private System.Windows.Forms.Button alltask_btn;
        private System.Windows.Forms.Button newtask_btn;
        private System.Windows.Forms.Panel form_pnl;
    }
}

