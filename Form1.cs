namespace A_232410101045_utspbo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Show();
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            register register = new register();
            register.ShowDialog();
            this.Show();
        }

        private void Kontakbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalamanKontak knotak = new HalamanKontak();
            knotak.ShowDialog();
            this.Show();

        }
    }
}
