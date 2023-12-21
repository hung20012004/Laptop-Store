namespace Qlsv
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text!="" && tbPassword.Text!="" && cbRole.Text!="")
            {
                MenuForm menuForm = new MenuForm();
                this.Hide();
                if (cbRole.Text == "Sinh viên")
                {
                    menuForm.enableStudent();
                }
                else menuForm.enableTeacher();

                menuForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Phải điền đủ tên đăng nhập ,mật khẩu và chọn vai trò");
            }
        }
    }
}