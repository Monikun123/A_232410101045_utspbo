using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace A_232410101045_utspbo.model
{
    internal class KontakModel
    {
        public string nama { get; set; }
        public string email { get; set; }
        public string nohp { get; set; }
        public int id { get; set; }
        [Required]
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Nohp
        {
            get { return nohp; }
            set { nohp = value;}
        }
        public KontakModel(string nama, string email, string nohp) //Constructor
        {
            this.nama = nama;
            this.email = email;
            this.nohp = nohp;
        }
    }
}
