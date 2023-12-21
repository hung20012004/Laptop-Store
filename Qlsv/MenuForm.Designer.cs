namespace Qlsv
{
    partial class MenuForm
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
            toolStrip1 = new ToolStrip();
            toolStripStudent = new ToolStripButton();
            toolStripTeacher = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripStudent, toolStripTeacher });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1407, 37);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripStudent
            // 
            toolStripStudent.Enabled = false;
            toolStripStudent.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStudent.Name = "toolStripStudent";
            toolStripStudent.Size = new Size(104, 32);
            toolStripStudent.Text = "Xem điểm";
            // 
            // toolStripTeacher
            // 
            toolStripTeacher.Enabled = false;
            toolStripTeacher.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripTeacher.Name = "toolStripTeacher";
            toolStripTeacher.Size = new Size(164, 32);
            toolStripTeacher.Text = "Quản lý sinh viên";
            toolStripTeacher.Click += toolStripTeacher_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 946);
            Controls.Add(toolStrip1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += MenuForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripStudent;
        private ToolStripButton toolStripTeacher;
    }
}