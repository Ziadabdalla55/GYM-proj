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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{

    public partial class newmember : Form
    {





        public newmember()
        {
            InitializeComponent();

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newmember_Load(object sender, EventArgs e)
        {

        }



        private void addbtn_MouseDown(object sender, MouseEventArgs e)
        {

            if (phonetxt.Text != null && nametxt.Text != null && agetxt.Text != null && weighttxt.Text != null && lengthtxt.Text != null && coachbox.Text != null && planbox.Text != null && (malerdn.Checked || femalerdn.Checked))
            {
                FileStream gymFile;
                StreamWriter sw;

                gymFile = new FileStream("C:\\Users\\Abdallah\\OneDrive\\Desktop\\gymproject.txt", FileMode.Open, FileAccess.ReadWrite);
                sw = new StreamWriter(gymFile);

                gymFile.Seek(0, SeekOrigin.End);

                string record = phonetxt.Text + "," + nametxt.Text + "," + agetxt.Text + "," + weighttxt.Text + "," + lengthtxt.Text + "," + coachbox.Text + "," + planbox.Text;
                if (malerdn.Checked)
                {
                    record += "," + "Male";
                }
                else if (femalerdn.Checked)
                {
                    record += "," + "Female";
                }


                sw.WriteLine(record);

                sw.Flush();
                sw.Close();
                gymFile.Close();

                MessageBox.Show("Memmber has been add");
            }
            else
            {
                MessageBox.Show("Data uncompleted");
            }





        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
