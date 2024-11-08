using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A_232410101045_utspbo.context;
using A_232410101045_utspbo.model;

namespace A_232410101045_utspbo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void masukbutton_Click(object sender, EventArgs e)
        {

            LoginakunContext loginakunContext = new LoginakunContext();
            LoginAkun login = loginakunContext.Validate(UsernametextBox.Text, PasswordtextBox.Text);

            if (login != null)
            {
                MessageBox.Show("Login berhasil!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
                this.Hide();
                Dashboard dash = new Dashboard();
                dash.ShowDialog();
                this.Show();


            }
            else if (string.IsNullOrEmpty(UsernametextBox.Text) || string.IsNullOrEmpty(PasswordtextBox.Text))
            {
                MessageBox.Show("Username & Password tidak boleh kosong!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username atau Password salah. Masukkan dengan benar!", "LOGIN FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ClearTextBox()
        {
            UsernametextBox.Text = "";
            PasswordtextBox.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

}

