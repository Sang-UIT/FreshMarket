using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace baith2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int z = 9;
        int page = 1; //page 1,2;
        int MAX = 16;
        int l = 1; //l=1,2,3;
        string st = "\\1\\1\\";
        int bt = 1;
        int[,] giohang = new int[100, 4];// giohang[bt,l,xx,sl] vd: giohang[1,1,8,2]
        bool mua = false;
        String[,] lbc =
        {
            {"Thịt Heo","Thịt Bò","Thịt Gà" }
        };
        String [,]ten = new String[16,3];
        void readfile(int aa)
        {
            st = "\\" + bt + "\\" + aa + "\\";
            String x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + "Goods.txt";
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(x))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                string line;
               
                
                int i = 0;
                int j = 1;
                //0,1,2
                while (j <= MAX)
                {
                    line = streamReader.ReadLine();
                    string[] stt = { "*"};
                    string[] linee = line.Split(stt,System.StringSplitOptions.RemoveEmptyEntries);
                    ten[i, 0] = linee[0];
                    ten[i, 1] = linee[1];
                    ten[i, 2] = linee[2];
                    i++;
                    j++;
                }
            }

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            giohangclick();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            load16img(12);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            load16img(11);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            load16img(10);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            load16img(9);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            load16img(8);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            load16img(7);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            load16img(6);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            load16img(5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load16img(4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            load16img(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load16img(2);
        }
        void load16img(int aa)
        {
            loadpicturebox(aa);
            readfile(aa);
            bt = aa;
            st = "\\"+aa+"\\"+aa+"\\";
            z = 9;
            int xx = 1;
            String x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label10.Text = ten[xx - 1, 0];
            xx++;
            pictureBox13.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label11.Text = ten[xx - 1, 0];
            xx++;
            pictureBox14.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label12.Text = ten[xx - 1, 0];
            xx++;
            pictureBox15.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label13.Text = ten[xx - 1, 0];
            xx++;
            pictureBox16.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label17.Text = ten[xx - 1, 0];
            xx++;
            pictureBox33.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label16.Text = ten[xx - 1, 0];
            xx++;
            pictureBox32.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label15.Text = ten[xx - 1, 0];
            xx++;
            pictureBox31.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label14.Text = ten[xx - 1, 0];
            xx++;
            pictureBox30.Image = Image.FromFile(x);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            load16img(1);
        }
        void giohangclick()
        {
            Form3 n = new Form3();
            n.ShowDialog();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            giohangclick();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            
            if (page == 1)
                load_form2(1);
            else
                load_form2(9);
        }
        void load_form2(int xx)
        {
            Form2 n = new Form2(bt, l,xx, ten[xx - 1, 0], ten[xx - 1, 1], ten[xx - 1, 2]);
            n.ShowDialog();
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            int xx = z;
            int fl= 1;
            if (xx > MAX)
            {
                xx = fl;
                fl++;
            }
            String x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            pictureBox13.Image = Image.FromFile(x);
            label10.Text = ten[xx - 1, 0];
            xx++;
            if (xx > MAX)
            {
                xx = fl;
                fl++;
            }
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label11.Text = ten[xx - 1, 0];
            xx++;
            if (xx > MAX)
            {
                xx = fl;
                fl++;
            }
            pictureBox14.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label12.Text = ten[xx - 1, 0];
            xx++;
            if (xx > MAX)
            {
                xx = fl;
                fl++;
            }
            pictureBox15.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label13.Text = ten[xx - 1, 0];
            xx++;
            if (xx > MAX)
            {
                xx = fl;
                fl++;
            }
            pictureBox16.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label17.Text = ten[xx - 1, 0];
            xx++;
            if (xx > MAX)
            {
                xx = fl;
                fl++;
            }
            pictureBox33.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label16.Text = ten[xx - 1, 0];
            xx++;
            if (xx > MAX)
            {
                xx = fl;
                fl++;
            }
            pictureBox32.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label15.Text = ten[xx - 1, 0];
            xx++;
            if (xx > MAX)
            {
                xx = fl;
                fl++;
            }
            pictureBox31.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label14.Text = ten[xx - 1, 0];
            xx++;
            if (xx > MAX)
            {
                xx = fl;
                fl++;
            }
            pictureBox30.Image = Image.FromFile(x);
            if (z==9)
            {
                page = 2;
                z = 1;
            }
            else
            {
                page = 1;
                z = 9;
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            int xx = z;
            int fl = 1;
            if (xx < 9)
            {
                xx = fl;
                fl++;
            }
            String x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            pictureBox13.Image = Image.FromFile(x);
            label10.Text = ten[xx - 1, 0];
            xx++;
            if (xx < 9)
            {
                xx = fl;
                fl++;
            }
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label11.Text = ten[xx - 1, 0];
            xx++;
            if (xx < 9)
            {
                xx = fl;
                fl++;
            }
            pictureBox14.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label12.Text = ten[xx - 1, 0];
            xx++;
            if (xx < 9)
            {
                xx = fl;
                fl++;
            }
            pictureBox15.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label13.Text = ten[xx - 1, 0];
            xx++;
            if (xx < 9)
            {
                xx = fl;
                fl++;
            }
            pictureBox16.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label17.Text = ten[xx - 1, 0];
            xx++;
            if (xx < 9)
            {
                xx = fl;
                fl++;
            }
            pictureBox33.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label16.Text = ten[xx - 1, 0];
            xx++;
            if (xx < 9)
            {
                xx = fl;
                fl++;
            }
            pictureBox32.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label15.Text = ten[xx - 1, 0];
            xx++;
            if (xx < 9)
            {
                xx = fl;
                fl++;
            }
            pictureBox31.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label14.Text = ten[xx - 1, 0];
            xx++;
            if (xx < 9)
            {
                xx = fl;
                fl++;
            }
            pictureBox30.Image = Image.FromFile(x);
            if (z == 9)
            {
                z = 1;
                page = 2;
            }
            else
            {
                z = 9;
                page = 1;
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            l = 1;
            page = 1;
            st = "\\"+bt+"\\1\\";
            loadpicturebox(1);
            readfile(1);
            z = 9;
            int xx = 1;
            String x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label10.Text = ten[xx - 1, 0];
            xx++;
            pictureBox13.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label11.Text = ten[xx - 1, 0];
            xx++;
            pictureBox14.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label12.Text = ten[xx - 1, 0];
            xx++;
            pictureBox15.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label13.Text = ten[xx - 1, 0];
            xx++;
            pictureBox16.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label17.Text = ten[xx - 1, 0];
            xx++;
            pictureBox33.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label16.Text = ten[xx - 1, 0];
            xx++;
            pictureBox32.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label15.Text = ten[xx - 1, 0];
            xx++;
            pictureBox31.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label14.Text = ten[xx - 1, 0];
            xx++;
            pictureBox30.Image = Image.FromFile(x);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            l = 2;
            st = "\\" + bt + "\\2\\";
            loadpicturebox(1);
            readfile(2);
            z = 9;
            page = 1;
            int xx = 1;
            String x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label10.Text = ten[xx - 1, 0];
            xx++;
            pictureBox13.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label11.Text = ten[xx - 1, 0];
            xx++;
            pictureBox14.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label12.Text = ten[xx - 1, 0];
            xx++;
            pictureBox15.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label13.Text = ten[xx - 1, 0];
            xx++;
            pictureBox16.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label17.Text = ten[xx - 1, 0];
            xx++;
            pictureBox33.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label16.Text = ten[xx - 1, 0];
            xx++;
            pictureBox32.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label15.Text = ten[xx - 1, 0];
            xx++;
            pictureBox31.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label14.Text = ten[xx - 1, 0];
            xx++;
            pictureBox30.Image = Image.FromFile(x);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            l = 3;
            page = 1;
            st = "\\" + bt + "\\3\\";
            loadpicturebox(1);
            readfile(3);
            z = 9;
            int xx = 1;
            String x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label10.Text = ten[xx - 1, 0];
            xx++;
            pictureBox13.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label11.Text = ten[xx - 1, 0];
            xx++;
            pictureBox14.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label12.Text = ten[xx - 1, 0];
            xx++;
            pictureBox15.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label13.Text = ten[xx - 1, 0];
            xx++;
            pictureBox16.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label17.Text = ten[xx - 1, 0];
            xx++;
            pictureBox33.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label16.Text = ten[xx - 1, 0];
            xx++;
            pictureBox32.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label15.Text = ten[xx - 1, 0];
            xx++;
            pictureBox31.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label14.Text = ten[xx - 1, 0];
            xx++;
            pictureBox30.Image = Image.FromFile(x);

        }
        void loadpicturebox(int aa)
        {
            String x = System.IO.Directory.GetCurrentDirectory();
            x = x + "\\Choosen\\" + aa + "\\";
            String x1 = x + 1+".jpg";
            pictureBox23.Image = Image.FromFile(x1);
            x1 = x + 2+".jpg";
            pictureBox24.Image = Image.FromFile(x1);
            x1 = x + 3+ ".jpg";
            pictureBox25.Image = Image.FromFile(x1);
            label7.Text = lbc[aa-1, 0];
            label8.Text = lbc[aa - 1, 1];
            label9.Text = lbc[aa - 1, 2];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadpicturebox(1);
            readfile(1);
            bt = 1;
            st = "\\1\\1\\";
            z = 9;
            int xx = 1;
            String x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label10.Text = ten[xx - 1, 0];
            xx++;
            pictureBox13.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label11.Text = ten[xx - 1, 0];
            xx++;
            pictureBox14.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label12.Text = ten[xx - 1, 0];
            xx++;
            pictureBox15.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label13.Text = ten[xx - 1, 0];
            xx++;
            pictureBox16.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label17.Text = ten[xx - 1, 0];
            xx++;
            pictureBox33.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label16.Text = ten[xx - 1, 0];
            xx++;
            pictureBox32.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label15.Text = ten[xx - 1, 0];
            xx++;
            pictureBox31.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".jpg";
            label14.Text = ten[xx - 1, 0];
            xx++;
            pictureBox30.Image = Image.FromFile(x);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            if (page == 1)
                load_form2(5);
            else
                load_form2(13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (page == 1)
                load_form2(2);
            else
                load_form2(10);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (page == 1)
                load_form2(3);
            else
                load_form2(11);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (page == 1)
                load_form2(4);
            else
                load_form2(12);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            if (page == 1)
                load_form2(6);
            else
                load_form2(14);
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            if (page == 1)
                load_form2(7);
            else
                load_form2(15);
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            if (page == 1)
                load_form2(8);
            else
                load_form2(16);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            giohangclick();
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            giohangclick();
        }
        void click_tracuu()
        {
            string s=textBox1.Text;
            string x = System.IO.Directory.GetCurrentDirectory();
            x = x + "\\hoadon\\" + s + ".doc";
            try
            {
                System.Diagnostics.Process.Start(x);
            }
            catch
            {
                string message = "Không tìm thấy hóa đơn, vui lòng nhập số điện thoại đặt hàng";
                MessageBox.Show(message);
            }
        }
        

       

        private void pictureBox35_Click_1(object sender, EventArgs e)
        {
            click_tracuu();
        }

        private void pictureBox36_Click_1(object sender, EventArgs e)
        {
            click_tracuu();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            click_tracuu();
        }
    }
}
