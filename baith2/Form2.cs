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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        int i = 0;
        int bt = 1;
        int aa = 1;
        int xx = 1;
        string ten;
        string kl;
        string gia;
        int sl = 1;
        String[,] hoadon =new String[100,4];
        public Form2(int btt, int aat,int xxx, string tent, string klt, string giat)
        {
            bt = btt;
            aa = aat;
            ten = tent;
            kl = klt;
            gia = giat;
            xx = xxx;
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
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
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = ten;
            label15.Text = kl;
            label2.Text = to_int(gia)/1000+"."+(to_int(gia)%1000==0?"000": (to_int(gia)%1000).ToString()) + "₫";
            String x = System.IO.Directory.GetCurrentDirectory();
            String st = "\\" + bt + "\\"+aa+"\\";
            x = x + st + xx + ".jpg";
            pictureBox1.Image = Image.FromFile(x);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".txt";
            File.AppendAllText(x,"");
            const Int32 BufferSize = 128;
            string[] line1 = { " ", " ", " " };
            string[] line2 = { " ", " ", " " };
            string[] line3 = { " ", " ", " " };
            using (var fileStream = File.OpenRead(x))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                string line;
                while (streamReader.ReadLine() != null)
                {
                    string[] stt = { "*" };
                    line = streamReader.ReadLine();
                    line1 = line2;
                    line2 = line3;
                        try
                        {
                            
                            string[] linee = line.Split(stt, System.StringSplitOptions.RemoveEmptyEntries);
                            line3 = linee;
                        }
                        catch
                        {
                           
                        }
                        
                    
                }
                textBox3.Text = line3[0];
                richTextBox2.Text = line3[2];
                textBox4.Text = line2[0];
                richTextBox3.Text = line2[2];
                textBox5.Text = line1[0];
                richTextBox4.Text = line1[2];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            wf();
            Form3 n = new Form3();
            n.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (sl > 1)
                sl--;
            label3.Text = sl.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            sl++;
            label3.Text = sl.ToString();
        }
        void wf()
        {
            int tt = to_int(gia) * sl;
            String st;
            st = ten + "*" + sl + "*" + gia + "*" + tt+"\n";
            File.AppendAllText("Giohang.txt",st);
        }
        void rf()
        {
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead("Giohang.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                string line;


                i = 0;
                int j = 1;
                //0,1,2
                while (j<=100)
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
                        
                        i++;
                    }
                    j++;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            wf();
            this.Close();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            giohangclick();
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            giohangclick();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            giohangclick();
        }
        void giohangclick()
        {
            Form3 n = new Form3();
            n.ShowDialog();
            this.Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            giohangclick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String x = System.IO.Directory.GetCurrentDirectory();
            String st = "\\" + bt + "\\" + aa + "\\";
            x = x + st + xx + ".txt";
            if (checkBox1.Checked)
                File.AppendAllText(x, "\nCustomer*" + textBox2.Text + "*" + richTextBox1.Text);
            else
                File.AppendAllText(x,"\n"+textBox1.Text + "*" + textBox2.Text + "*" + richTextBox1.Text);
            x = System.IO.Directory.GetCurrentDirectory();
            x = x + st + xx + ".txt";
            File.AppendAllText(x, "");
            const Int32 BufferSize = 128;
            string[] line1 = { " ", " ", " " };
            string[] line2 = { " ", " ", " " };
            string[] line3 = { " ", " ", " " };
            using (var fileStream = File.OpenRead(x))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                string line;
                while (streamReader.ReadLine() != null)
                {
                    string[] stt = { "*" };
                    line = streamReader.ReadLine();
                    line1 = line2;
                    line2 = line3;
                    try
                    {

                        string[] linee = line.Split(stt, System.StringSplitOptions.RemoveEmptyEntries);
                        line3 = linee;
                    }
                    catch
                    {

                    }


                }
            }
                textBox3.Text = line3[0];
                richTextBox2.Text = line3[2];
                textBox4.Text = line2[0];
                richTextBox3.Text = line2[2];
                textBox5.Text = line1[0];
                richTextBox4.Text = line1[2];
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
