namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        newmember newmember = new newmember();
        Search search = new Search();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void newmemberbtn_MouseDown(object sender, MouseEventArgs e)
        {

            newmember.Show();
            this.Hide();
        }

        private void searchbtn_MouseDown(object sender, MouseEventArgs e)
        {
            search.Show();
            this.Hide();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

        }
    }
}