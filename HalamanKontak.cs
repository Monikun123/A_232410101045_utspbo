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

namespace A_232410101045_utspbo
{
    public partial class HalamanKontak : Form
    {
        public HalamanKontak()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDataMahasiswa();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataMahasiswa()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;

                DataTable KontakData = Kontakconext.All();
                if (KontakData == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data mahasiswa");
                    return;
                }

                dataGridView1.Columns.Clear();

                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                dataGridView1.Columns.Add(nomorColumn);

                dataGridView1.DataSource = KontakData;

                if (dataGridView1.Columns["id"] != null) dataGridView1.Columns["id"].Visible = false;
                if (dataGridView1.Columns["nama"] != null)
                    dataGridView1.Columns["nama"].HeaderText = "Nama";
                if (dataGridView1.Columns["email"] != null)
                    dataGridView1.Columns["email"].HeaderText = "Email";
                if (dataGridView1.Columns["nohp"] != null)
                    dataGridView1.Columns["nohp"].HeaderText = "No Hp";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataMahasiswa: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void HalamanKontak_Load(object sender, EventArgs e)
        {

        }

        private void kembalibutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
