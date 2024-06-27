using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void existbtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void existbtn_MouseDown(object sender, MouseEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Close();
        }
        long x = 0;
        private void okbtn_MouseDown(object sender, MouseEventArgs e)
        {
            x = 0;
            string[] lines = File.ReadAllLines("C:\\Users\\Abdallah\\OneDrive\\Desktop\\gymproject.txt");

            string phone = searchphonetxt.Text;
            int c = 0;


            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                if (phone == line.Substring(0, 11))
                {
                    if (i == 0)
                    {
                        x--;
                    }
                    string[] field = line.Split(',');
                    string phoneNO = field[0];
                    string name = field[1];
                    string age = field[2];
                    string weight = field[3];
                    string length = field[4];
                    string coach = field[5];
                    string plan = field[6];
                    string gender = field[7];

                    MessageBox.Show("Name : " + name + "\n Age : " + age + "\n phoneNO : " + phoneNO + "\n weight : " + weight + "\n length : " + length + "\n coach : " + coach + "\n plan : " + plan + "\n gender : " + gender);
                    c = 1;
                    break;
                }

                x += line.Length;

            }
            if (c == 0)
            {
                MessageBox.Show("Not Found");
            }




        }

        private void deletbtn_MouseDown(object sender, MouseEventArgs e)
        {

            FileStream gymFile;
            StreamWriter sw;

            gymFile = new FileStream("C:\\Users\\Abdallah\\OneDrive\\Desktop\\gymproject.txt", FileMode.Open, FileAccess.ReadWrite);
            sw = new StreamWriter(gymFile);

            gymFile.Seek(x + 1, SeekOrigin.Begin);
            sw.Write("*");
            sw.Flush();
            sw.Close();
            gymFile.Close();


        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void searchphonetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
