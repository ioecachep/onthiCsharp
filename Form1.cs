using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (txtChiSoDienCu.Text == "" || txtChiSoDienMoi.Text == "" || txtThueBaoDienKe.Text == "" || txtKhachHang.Text == "")
            {
                MessageBox.Show("Các trường không được để trống");
            }
            else
            {
                double chisocu = Convert.ToDouble(txtChiSoDienCu.Text);
                double chisomoi = Convert.ToDouble(txtChiSoDienMoi.Text);
                double thuebaodienke = Convert.ToDouble(txtThueBaoDienKe.Text);
                double sodientieuthu = chisomoi - chisocu;
                if (sodientieuthu <= 0)
                {
                    MessageBox.Show("Nhập thông tin về số điện sai");
                }
                else
                {
                    double tiendiendinhmuc = 0;
                    double tiendienvuotdinhmucduoi50 = 0;
                    double tiendienvuotdinhmucduoi100 = 0;
                    double tiendienvuotdinhmuctren100 = 0;
                    double tiendienvuotdinhmuc = 0;
                    if (sodientieuthu <= 50)
                    {
                        tiendiendinhmuc = sodientieuthu * 450;
                    }
                    else if (sodientieuthu <= 100)
                    {
                        tiendiendinhmuc = 50 * 450;
                        tiendienvuotdinhmucduoi50 = (sodientieuthu - 50) * 700;
                        tiendienvuotdinhmuc = (sodientieuthu - 50) * 700;
                    }
                    else if (sodientieuthu < 150)
                    {
                        tiendiendinhmuc = 50 * 450;
                        tiendienvuotdinhmucduoi50 = (sodientieuthu - 50) * 700;
                        tiendienvuotdinhmucduoi100 = (sodientieuthu - 100) * 910;
                        tiendienvuotdinhmuc = (50 * 700) + ((sodientieuthu - 100) * 910);
                    }
                    else
                    {
                        tiendiendinhmuc = 50 * 450;
                        tiendienvuotdinhmucduoi50 = 50 * 700;
                        tiendienvuotdinhmucduoi100 = 50 * 910;
                        tiendienvuotdinhmuctren100 = (sodientieuthu - 150) * 1200;
                        tiendienvuotdinhmuc = (50 * 700) + (50 * 910) + ((sodientieuthu - 150) * 1200);
                    }
                    double TongCong = tiendiendinhmuc + tiendienvuotdinhmuc + thuebaodienke;
                    lbKhacHang.Text = txtKhachHang.Text;
                    lbSoDien.Text = Convert.ToString(sodientieuthu);
                    lbTienTrongDinhMuc.Text = Convert.ToString(tiendiendinhmuc);
                    lbTienNgoaiDinhMuc.Text = Convert.ToString(tiendienvuotdinhmuc);
                    lbTongCong.Text = Convert.ToString(TongCong);
                    txtDuoiDinhMuc.Text = Convert.ToString(tiendiendinhmuc);
                    txtDuoi50.Text = Convert.ToString(tiendienvuotdinhmucduoi50);
                    txtDuoi100.Text = Convert.ToString(tiendienvuotdinhmucduoi100);
                    txtTren100.Text = Convert.ToString(tiendienvuotdinhmuctren100);
                    pnlTinhTien.Visible = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlTinhTien.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pnlTinhTien.Visible = false;
            txtChiSoDienCu.Clear();
            txtChiSoDienMoi.Clear(); ;
            txtKhachHang.Clear();
            txtThueBaoDienKe.Clear();
            txtDuoiDinhMuc.Clear();
            txtDuoi50.Clear();
            txtDuoi100.Clear();
            txtTren100.Clear();
        }
    }
}
