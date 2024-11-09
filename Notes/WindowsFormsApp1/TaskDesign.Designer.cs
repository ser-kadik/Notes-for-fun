namespace WindowsFormsApp1
{
    partial class TaskDesignPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskDesignName_lbl = new System.Windows.Forms.Label();
            this.TaskDesignDescription_lbl = new System.Windows.Forms.Label();
            this.TaskDesignImportant_lbl = new System.Windows.Forms.Label();
            this.TaskDesignDate_lbl = new System.Windows.Forms.Label();
            this.cmp_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmp_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskDesignName_lbl
            // 
            this.taskDesignName_lbl.AutoSize = true;
            this.taskDesignName_lbl.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskDesignName_lbl.ForeColor = System.Drawing.Color.White;
            this.taskDesignName_lbl.Location = new System.Drawing.Point(3, 0);
            this.taskDesignName_lbl.Name = "taskDesignName_lbl";
            this.taskDesignName_lbl.Size = new System.Drawing.Size(64, 31);
            this.taskDesignName_lbl.TabIndex = 0;
            this.taskDesignName_lbl.Text = "Имя";
            // 
            // TaskDesignDescription_lbl
            // 
            this.TaskDesignDescription_lbl.AutoSize = true;
            this.TaskDesignDescription_lbl.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskDesignDescription_lbl.ForeColor = System.Drawing.Color.White;
            this.TaskDesignDescription_lbl.Location = new System.Drawing.Point(13, 31);
            this.TaskDesignDescription_lbl.Name = "TaskDesignDescription_lbl";
            this.TaskDesignDescription_lbl.Size = new System.Drawing.Size(100, 27);
            this.TaskDesignDescription_lbl.TabIndex = 1;
            this.TaskDesignDescription_lbl.Text = "Описание";
            // 
            // TaskDesignImportant_lbl
            // 
            this.TaskDesignImportant_lbl.AutoSize = true;
            this.TaskDesignImportant_lbl.BackColor = System.Drawing.Color.Red;
            this.TaskDesignImportant_lbl.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskDesignImportant_lbl.ForeColor = System.Drawing.Color.White;
            this.TaskDesignImportant_lbl.Location = new System.Drawing.Point(89, 5);
            this.TaskDesignImportant_lbl.Name = "TaskDesignImportant_lbl";
            this.TaskDesignImportant_lbl.Size = new System.Drawing.Size(78, 20);
            this.TaskDesignImportant_lbl.TabIndex = 2;
            this.TaskDesignImportant_lbl.Text = "Important";
            this.TaskDesignImportant_lbl.Visible = false;
            // 
            // TaskDesignDate_lbl
            // 
            this.TaskDesignDate_lbl.AutoSize = true;
            this.TaskDesignDate_lbl.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskDesignDate_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.TaskDesignDate_lbl.Location = new System.Drawing.Point(165, 5);
            this.TaskDesignDate_lbl.Name = "TaskDesignDate_lbl";
            this.TaskDesignDate_lbl.Size = new System.Drawing.Size(46, 20);
            this.TaskDesignDate_lbl.TabIndex = 3;
            this.TaskDesignDate_lbl.Text = "Дата";
            // 
            // cmp_btn
            // 
            this.cmp_btn.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmp_btn.Location = new System.Drawing.Point(307, 5);
            this.cmp_btn.Name = "cmp_btn";
            this.cmp_btn.Size = new System.Drawing.Size(176, 53);
            this.cmp_btn.TabIndex = 4;
            this.cmp_btn.Text = "Complite";
            this.cmp_btn.UseVisualStyleBackColor = true;
            this.cmp_btn.Click += new System.EventHandler(this.cmp_btn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(490, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmp_lbl
            // 
            this.cmp_lbl.AutoSize = true;
            this.cmp_lbl.BackColor = System.Drawing.Color.Gray;
            this.cmp_lbl.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmp_lbl.ForeColor = System.Drawing.Color.White;
            this.cmp_lbl.Location = new System.Drawing.Point(458, 23);
            this.cmp_lbl.Name = "cmp_lbl";
            this.cmp_lbl.Size = new System.Drawing.Size(82, 20);
            this.cmp_lbl.TabIndex = 6;
            this.cmp_lbl.Text = "Compleate";
            this.cmp_lbl.Visible = false;
            // 
            // TaskDesignPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.cmp_lbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmp_btn);
            this.Controls.Add(this.TaskDesignDate_lbl);
            this.Controls.Add(this.TaskDesignImportant_lbl);
            this.Controls.Add(this.TaskDesignDescription_lbl);
            this.Controls.Add(this.taskDesignName_lbl);
            this.Name = "TaskDesignPanel";
            this.Size = new System.Drawing.Size(561, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskDesignName_lbl;
        private System.Windows.Forms.Label TaskDesignDescription_lbl;
        private System.Windows.Forms.Label TaskDesignImportant_lbl;
        private System.Windows.Forms.Label TaskDesignDate_lbl;
        private System.Windows.Forms.Button cmp_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label cmp_lbl;
    }
}
