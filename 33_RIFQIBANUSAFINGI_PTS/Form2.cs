using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_RIFQIBANUSAFINGI_PTS
{
    public partial class Form2 : Form
    {
        private string nipguru;
        private string nama;
        private string jeniskelamin;
        private string agama;
        private string tempatlahir;
        private string tanggallahir;
        private string pendidikan;
        private string status1;
        private string jumlah_anak;
        private string alamat;
        private string notelp;
        private string nohp;
        private string alamat_email;
        private string status;

        public Form2(string nipguru, string nama, string jeniskelamin, string agama, string tempatlahir, string tanggallahir, string pendidikan, string status1, string jumlah_anak, string alamat, string notelp, string nohp, string alamat_email, string status)
        {
            InitializeComponent();
            this.nipguru = nipguru;
            this.nama = nama;
            this.jeniskelamin = jeniskelamin;
            this.agama = agama;
            this.tempatlahir = tempatlahir;
            this.tanggallahir = tanggallahir;
            this.pendidikan = pendidikan;
            this.status1 = status1;
            this.jumlah_anak = jumlah_anak;
            this.alamat = alamat;
            this.notelp = notelp;
            this.nohp = nohp;
            this.alamat_email = alamat_email;
            this.status = status;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = nipguru;
            textBox2.Text = nama;
            textBox3.Text = jeniskelamin;
            textBox4.Text = agama;
            textBox5.Text = tempatlahir;
            textBox6.Text = tanggallahir;
            textBox7.Text = pendidikan;
            textBox8.Text = status1;
            textBox9.Text = jumlah_anak;
            textBox10.Text = alamat;
            textBox11.Text = notelp;
            textBox12.Text = nohp;
            textBox13.Text = alamat_email;
            textBox14.Text = status;
        }
    }
}
