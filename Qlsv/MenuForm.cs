using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlsv
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        public void enableStudent()
        {
            toolStripStudent.Enabled = true;
        }
        public void enableTeacher()
        {
            toolStripTeacher.Enabled = true;
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTeacher_Click(object sender, EventArgs e)
        {
            QlydiemForm qlydiemForm = new QlydiemForm();
            qlydiemForm.MdiParent = this;
            qlydiemForm.Show();
        }
    }
}
