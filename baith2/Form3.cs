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
    public partial class Form3 : Form
    {
        int tsl=0;
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
        public Form3()
        {
            
            
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
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
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
            label12.Text = tsl.ToString();
            label14.Text = tongcong.ToString()+ "₫";
            //reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //reportViewer1.LocalReport.ReportPath = "Report1.rdlc"; //để file report trong Debug của project

            //ReportDataSource dts = new ReportDataSource();
            //dts.Name = "ds1"; //Đặt đúng tên khi đặt trong report -- có tên mặc định là DataSet1
            //dts.Value = dt;
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(dts);
           

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Giohang.txt", "");
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = textBox1.Text;
            string sdt = textBox2.Text;
            string email = textBox3.Text;
            string diachi = textBox4.Text;
            string date = dateTimePicker1.Text;
            string ghichu = richTextBox1.Text;
            Form4 n = new Form4(ten, sdt, email, diachi, date, ghichu);
            n.ShowDialog();
            this.Close();
        }
    }
}
