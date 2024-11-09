namespace WindowsFormsApp1
{
    partial class AllTask
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
            this.alltask_flwpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(210, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "All task";
            // 
            // alltask_flwpnl
            // 
            this.alltask_flwpnl.Location = new System.Drawing.Point(0, 60);
            this.alltask_flwpnl.Name = "alltask_flwpnl";
            this.alltask_flwpnl.Size = new System.Drawing.Size(576, 424);
            this.alltask_flwpnl.TabIndex = 1;
            // 
            // AllTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(23)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(576, 484);
            this.Controls.Add(this.alltask_flwpnl);
            this.Controls.Add(this.label1);
            this.Name = "AllTask";
            this.Text = "AllTask";
            this.Load += new System.EventHandler(this.AllTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel alltask_flwpnl;
    }
}