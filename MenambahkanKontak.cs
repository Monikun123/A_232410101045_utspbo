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
    public partial class MenambahkanKontak : Form
    {
        public MenambahkanKontak()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }
            string username = namatextBox.Text;
            string email = emailtextBox.Text;
            string nohp = nohptextBox.Text;

            KontakModel Kontak = new KontakModel(username, email, nohp);
            Kontakconext.AddKontak(Kontak);
            MessageBox.Show("Kontak baru berhasil ditambahkan");
            ClearFields();

            this.DialogResult = DialogResult.OK;
            this.Hide();


        }
        private void ClearFields()
        {
            namatextBox.Clear();
            emailtextBox.Clear();
            nohptextBox.Clear();
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(namatextBox.Text) ||
                string.IsNullOrWhiteSpace(emailtextBox.Text) ||
                string.IsNullOrWhiteSpace(nohptextBox.Text))
            {
                return false;
            }
            return true;
        }

        private void MenambahkanKontak_Load(object sender, EventArgs e)
        {

        }
    }
}
