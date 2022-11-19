using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baith2
{
    public partial class Form4 : Form
    {
        public Form4(string tent, string sdtt, string emailt, string diachit, string datet, string ghichut)
        {
            ten = tent;
            sdt = sdtt;
            email = emailt;
            diachi = diachit;
            date = datet;
            ghichu = ghichut;
            InitializeComponent();
        }
        string ten;
        string sdt;
        string email;
        string diachi;
        string date;
        string ghichu;
        int tsl = 0;
        int tongcong = 0;
        String[,] hoadon = new String[100, 4];
        int i = 0;
        int to_int(String x)
        {
            int rs = 0;
            int i = 0;
            while (i < x.Length)
            {
                rs = rs * 10 + (int)x[i] - 48;
                i++;
            }
            return rs;
        }
        void rf()
        {
            tsl = 0;
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead("Giohang.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                string line;
                i = 0;
                int j = 1;
                //0,1,2
                while (j <= 100)
                {
                    line = streamReader.ReadLine();
                    if (line != null)
                    {
                        string[] stt = { "*" };
                        string[] linee = line.Split(stt, System.StringSplitOptions.RemoveEmptyEntries);
                        hoadon[i, 0] = linee[0];
                        hoadon[i, 1] = linee[1];
                        hoadon[i, 2] = linee[2];
                        hoadon[i, 3] = linee[3];
                        tsl += to_int(hoadon[i, 1]);
                        tongcong += to_int(hoadon[i, 3]);
                        i++;
                    }
                    j++;
                }
            }
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            rf();
            DataTable dt = new DataTable();
            int j = 0;
            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("SoLuong", typeof(string));
            dt.Columns.Add("DonGia", typeof(string));
            dt.Columns.Add("ThanhTien", typeof(string));
            while (j < i)
            {
                dt.Rows.Add(j.ToString(), hoadon[j, 0], hoadon[j, 1], hoadon[j, 2], hoadon[j, 3]);
                j++;
            }
            reportViewer1.Visible = true;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc"; //để file report trong Debug của project

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "ds1"; //Đặt đúng tên khi đặt trong report -- có tên mặc định là DataSet1
            dts.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dts);
            ReportParameter para1 = new ReportParameter();
            para1.Name = "Ten"; //Đặt đúng tên khi đặt trong report
            para1.Values.Add(ten);
            ReportParameter para2 = new ReportParameter();
            para2.Name = "sdt";
            para2.Values.Add(sdt);
            ReportParameter para3 = new ReportParameter();
            para3.Name = "email";
            para3.Values.Add(email);
            ReportParameter para4 = new ReportParameter();
            para4.Name = "diachi";
            para4.Values.Add(diachi);
            ReportParameter para5 = new ReportParameter();
            para5.Name = "ngaynhan";
            para5.Values.Add(date);
            ReportParameter para6 = new ReportParameter();
            para6.Name = "ghichu";
            para6.Values.Add(ghichu);
            ReportParameter para7 = new ReportParameter();
            para7.Name = "sl";
            para7.Values.Add(tsl.ToString());
            ReportParameter para8 = new ReportParameter();
            para8.Name = "tongcong";
            para8.Values.Add(tongcong.ToString());
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { para1, para2, para3, para4, para5, para6, para7, para8 });
            this.reportViewer1.RefreshReport();
            tienmat_click();
        }
        void tienmat_click()
        {
            label3.BackColor = Color.AliceBlue;
      
            pictureBox4.BackColor = Color.AliceBlue;
           
            
            pictureBox10.BackColor = Color.DodgerBlue;
            pictureBox9.BackColor = Color.DodgerBlue;
            label6.BackColor = Color.DodgerBlue;
            pictureBox8.Visible = false;
        }
        void momo_click()
        {
            label3.BackColor = Color.DodgerBlue;
            
            pictureBox4.BackColor = Color.DodgerBlue;
           

            pictureBox10.BackColor = Color.AliceBlue;
            pictureBox9.BackColor = Color.AliceBlue;
            label6.BackColor = Color.AliceBlue;
            pictureBox8.Visible = true;
        }
        void visa_click()
        {
            
            label3.BackColor = Color.AliceBlue;
            
            pictureBox4.BackColor = Color.AliceBlue;

            pictureBox10.BackColor = Color.AliceBlue;
            pictureBox9.BackColor = Color.AliceBlue;
            label6.BackColor = Color.AliceBlue;
            pictureBox8.Visible = false;
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            tienmat_click();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            tienmat_click();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            tienmat_click();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            visa_click();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            visa_click();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            visa_click();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            momo_click();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            momo_click();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            momo_click();
        }
        public void SavePDF(ReportViewer viewer, string savePath)

        {
            byte[] Bytes = viewer.LocalReport.Render(format: "WORD", deviceInfo: "");

            using (FileStream stream = new FileStream(savePath, FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string x;
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + "\\hoadon\\" + sdt+".doc";
            SavePDF(reportViewer1, x);

            this.Close();
        }
    }
}
