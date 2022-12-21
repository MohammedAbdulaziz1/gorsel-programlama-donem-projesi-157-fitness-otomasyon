namespace FITNESS_CENTER
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if(UidTb.Text== "" || PassTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if(UidTb.Text =="Admin" && PassTb.Text == "Admin")
            {
                Mpanel mpanel = new Mpanel();
                mpanel.Show();
                this.Hide();

            }
             else
            {
                MessageBox.Show("Wrong Id or Password");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UidTb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PassTb_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}