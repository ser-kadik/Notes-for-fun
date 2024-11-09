namespace WindowsFormsApp1
{
    partial class cmp_tasks
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
            this.cmptask_flwpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmptask_flwpnl
            // 
            this.cmptask_flwpnl.Location = new System.Drawing.Point(0, 60);
            this.cmptask_flwpnl.Name = "cmptask_flwpnl";
            this.cmptask_flwpnl.Size = new System.Drawing.Size(576, 424);
            this.cmptask_flwpnl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Compleate task";
            // 
            // cmp_tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(23)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(576, 484);
            this.Controls.Add(this.cmptask_flwpnl);
            this.Controls.Add(this.label1);
            this.Name = "cmp_tasks";
            this.Text = "cmp_tasks";
            this.Load += new System.EventHandler(this.cmp_tasks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel cmptask_flwpnl;
        private System.Windows.Forms.Label label1;
    }
}