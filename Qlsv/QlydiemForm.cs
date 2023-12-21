using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Qlsv
{
    public partial class QlydiemForm : Form
    {
        private DataSet dataSinhvien = new DataSet();
        private SqlConnection conn = SQLConnect();
        public QlydiemForm()
        {
            InitializeComponent();
        }
        public static SqlConnection SQLConnect()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=LAPTOP-F45JGTQ4\HUNGDATABASE;Initial Catalog=kiemtra;User ID=sa;Password=20012004";
            cnn = new SqlConnection(connetionString);
            return cnn;
        }

        private void QlydiemForm_Load(object sender, EventArgs e)
        {
            using (var cmd = new SqlCommand("SELECT * FROM sinhvien", conn))
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);

                adapt.Fill(dataSinhvien);
                conn.Close();
            }
            foreach (DataRow row in dataSinhvien.Tables[0].Rows)
            {
                string gender = "Nữ";
                if (Convert.ToInt32(row["gioitinh"]) == 1)
                {
                    gender = "Nam";
                }
                tableSV.Rows.Add(row["masv"], row["ten"], gender, row["khoa"], row["lop"]);
                //Console.WriteLine(row.ToString());
            }

        }
        private void enableTxt()
        {
            tbClass.Enabled = true;
            tbID.Enabled = true;
            tbName.Enabled = true;
            cbGender.Enabled = true;
            cbKhoa.Enabled = true;
        }
        private void disableTxt()
        {
            tbClass.Enabled = false;
            tbID.Enabled = false;
            tbName.Enabled = false;
            cbGender.Enabled = false;
            cbKhoa.Enabled = false;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            enableTxt();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbID.Text != "" && tbClass.Text != "" && cbGender.Text != "" && cbKhoa.Text != "")
            {
                DialogResult result = MessageBox.Show("Xác nhận ghi", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO sinhvien(masv,ten,gioitinh,khoa,lop)VALUES('" + tbID.Text + "','" + tbName.Text + "','" + Convert.ToInt32(cbGender.Text) + "','" + cbKhoa.Text + "','" + tbClass.Text + "');";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Load += QlydiemForm_Load;

                }
            }
            else
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin");
            }
            disableTxt();
            //tableSV.SelectedRows[]
        }

        private void Update_Click(object sender, EventArgs e)
        {
            tbID.Text = Convert.ToString(tableSV.SelectedRows[0].Cells[0].Value);
        }
    }
}
