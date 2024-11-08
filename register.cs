using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A_232410101045_utspbo.model;
using A_232410101045_utspbo.core;
using A_232410101045_utspbo.context;

namespace A_232410101045_utspbo
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }
            string username = usernametextBox.Text;
            string password = passwordtextBox.Text;

            LoginAkun akun = new LoginAkun(username, password);
            registercontext.AddAkun(akun);
            MessageBox.Show("Akun baru berhasil ditambahkan");
            ClearFields();

            this.DialogResult = DialogResult.OK;
            this.Hide();



        }
        private void ClearFields()
        {
            usernametextBox.Clear();
            passwordtextBox.Clear();
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(usernametextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordtextBox.Text))
            {
                return false;
            }
            return true;
        }
    }
}
