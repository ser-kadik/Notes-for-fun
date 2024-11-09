namespace WindowsFormsApp1
{
    partial class NewTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.desc_txt = new System.Windows.Forms.TextBox();
            this.imp1_rdbtn = new System.Windows.Forms.RadioButton();
            this.imp0_rdbtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.color_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.color_lbl = new System.Windows.Forms.Label();
            this.color_clrdial = new System.Windows.Forms.ColorDialog();
            this.date_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.date_btn = new System.Windows.Forms.Button();
            this.crttask_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "New task";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(23, 113);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(253, 20);
            this.name_txt.TabIndex = 5;
            // 
            // desc_txt
            // 
            this.desc_txt.Location = new System.Drawing.Point(23, 161);
            this.desc_txt.Name = "desc_txt";
            this.desc_txt.Size = new System.Drawing.Size(253, 20);
            this.desc_txt.TabIndex = 5;
            // 
            // imp1_rdbtn
            // 
            this.imp1_rdbtn.AutoSize = true;
            this.imp1_rdbtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imp1_rdbtn.ForeColor = System.Drawing.Color.White;
            this.imp1_rdbtn.Location = new System.Drawing.Point(23, 237);
            this.imp1_rdbtn.Name = "imp1_rdbtn";
            this.imp1_rdbtn.Size = new System.Drawing.Size(78, 37);
            this.imp1_rdbtn.TabIndex = 6;
            this.imp1_rdbtn.Text = "True";
            this.imp1_rdbtn.UseVisualStyleBackColor = true;
            // 
            // imp0_rdbtn
            // 
            this.imp0_rdbtn.AutoSize = true;
            this.imp0_rdbtn.Checked = true;
            this.imp0_rdbtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imp0_rdbtn.ForeColor = System.Drawing.Color.White;
            this.imp0_rdbtn.Location = new System.Drawing.Point(114, 237);
            this.imp0_rdbtn.Name = "imp0_rdbtn";
            this.imp0_rdbtn.Size = new System.Drawing.Size(78, 37);
            this.imp0_rdbtn.TabIndex = 6;
            this.imp0_rdbtn.TabStop = true;
            this.imp0_rdbtn.Text = "False";
            this.imp0_rdbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "It\'s an important task?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // color_btn
            // 
            this.color_btn.Location = new System.Drawing.Point(167, 315);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(78, 38);
            this.color_btn.TabIndex = 10;
            this.color_btn.Text = "Pick color";
            this.color_btn.UseVisualStyleBackColor = true;
            this.color_btn.Click += new System.EventHandler(this.color_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Color:";
            // 
            // color_lbl
            // 
            this.color_lbl.AutoSize = true;
            this.color_lbl.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color_lbl.ForeColor = System.Drawing.Color.White;
            this.color_lbl.Location = new System.Drawing.Point(78, 320);
            this.color_lbl.Name = "color_lbl";
            this.color_lbl.Size = new System.Drawing.Size(55, 26);
            this.color_lbl.TabIndex = 9;
            this.color_lbl.Text = "White";
            // 
            // color_clrdial
            // 
            this.color_clrdial.Color = System.Drawing.Color.White;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_lbl.ForeColor = System.Drawing.Color.White;
            this.date_lbl.Location = new System.Drawing.Point(78, 363);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(95, 26);
            this.date_lbl.TabIndex = 11;
            this.date_lbl.Text = "Chose Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date:";
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(265, 369);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(200, 20);
            this.date_picker.TabIndex = 14;
            // 
            // date_btn
            // 
            this.date_btn.Location = new System.Drawing.Point(471, 358);
            this.date_btn.Name = "date_btn";
            this.date_btn.Size = new System.Drawing.Size(78, 38);
            this.date_btn.TabIndex = 13;
            this.date_btn.Text = "Confirm Date";
            this.date_btn.UseVisualStyleBackColor = true;
            this.date_btn.Click += new System.EventHandler(this.date_btn_Click);
            // 
            // crttask_btn
            // 
            this.crttask_btn.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crttask_btn.Location = new System.Drawing.Point(114, 418);
            this.crttask_btn.Name = "crttask_btn";
            this.crttask_btn.Size = new System.Drawing.Size(330, 54);
            this.crttask_btn.TabIndex = 15;
            this.crttask_btn.Text = "Create Task";
            this.crttask_btn.UseVisualStyleBackColor = true;
            this.crttask_btn.Click += new System.EventHandler(this.crttask_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(261, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "//Не реализованно";
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(23)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(576, 484);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.crttask_btn);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.date_btn);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.color_btn);
            this.Controls.Add(this.color_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imp0_rdbtn);
            this.Controls.Add(this.imp1_rdbtn);
            this.Controls.Add(this.desc_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label1);
            this.Name = "NewTask";
            this.Text = "NewTask";
            this.Load += new System.EventHandler(this.NewTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox desc_txt;
        private System.Windows.Forms.RadioButton imp1_rdbtn;
        private System.Windows.Forms.RadioButton imp0_rdbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label color_lbl;
        private System.Windows.Forms.ColorDialog color_clrdial;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.Button date_btn;
        private System.Windows.Forms.Button crttask_btn;
        private System.Windows.Forms.Label label6;
    }
}