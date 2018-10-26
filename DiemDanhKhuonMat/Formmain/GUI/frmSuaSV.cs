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

namespace Formmain.GUI
{
    public partial class frmSuaSV : Form
    {
        public frmSuaSV()
        {
            InitializeComponent();
        }
        SqlConnection connect = null;
        string strconnect = " Server= HUUMANH\\SQLEXPRESS; Database=CSDLDiemDanh2; User Id=Diemdanh; pwd=123";

        private void btnXacNhan1_Click(object sender, EventArgs e)
        {
            string s = txtsNgaySinh.Text;
            int s1 = Convert.ToInt16(s.Substring(0, 2));
            int s2 = Convert.ToInt16(s.Substring(3, 2));
            int s3 = Convert.ToInt16(s.Substring(6, 4));
            if (connect == null)
                connect = new SqlConnection(strconnect);
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            // update lai thong tin
            //string str= " update DH_SV_LCN set MaSV=@ma where MaSV= " + txtMacu.Text;
            //string str2= " update  DH_SV_LHP set MaSV=@ma where MaSV= " + txtMacu.Text;
            //string str3=" update  SV_LHP set MaSV=@ma where MaSV= " + txtMacu.Text;
            string str1 = " update SinhVien set MaSV=@ma,Hoten=@Ten,NgaySinh=@ngay,GioiTinh=@gt where MaSV= " + txtMacu.Text;

            //SqlCommand command = new SqlCommand(str,connect);
            //SqlCommand command2 = new SqlCommand(str2, connect);
            //SqlCommand command3 = new SqlCommand(str3, connect);
            SqlCommand command1 = new SqlCommand(str1, connect);
            //  command.Parameters.Add("@ma", SqlDbType.Char).Value = txtSMaSV.Text;
            command1.Parameters.Add("@ma", SqlDbType.Char).Value = txtSMaSV.Text;
            //  command2.Parameters.Add("@ma", SqlDbType.Char).Value = txtSMaSV.Text;
            //  command3.Parameters.Add("@ma", SqlDbType.Char).Value = txtSMaSV.Text;

            command1.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtSHoTen.Text;
            command1.Parameters.Add("@ngay", SqlDbType.Date).Value = new DateTime(s3, s2, s1);
            command1.Parameters.Add("@gt", SqlDbType.NVarChar).Value = radsNam.Checked == true ? "Nam" : "Nữ";

            int ret = command1.ExecuteNonQuery();
            //   command1.ExecuteNonQuery();
            //command2.ExecuteNonQuery();
            //command3.ExecuteNonQuery();

            if (ret > 0)
            {

                MessageBox.Show(" Sua thanh cong");
            }
            else
            {
                MessageBox.Show(" k thanh cong ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
