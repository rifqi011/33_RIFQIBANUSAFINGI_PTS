using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _33_RIFQIBANUSAFINGI_PTS
{
    public partial class Form4 : Form
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
        private System.Drawing.Image picture;
        private string jam;
        private string tanggal;

        public Form4(string nipguru, string nama, string jeniskelamin, string agama, string tempatlahir, string tanggallahir, string alamat, string notelp, string nohp, string alamat_email, System.Drawing.Image picture, string jam, string tanggal)
        {
            InitializeComponent();
            this.nipguru = nipguru;
            this.nama = nama;
            this.jeniskelamin = jeniskelamin;
            this.agama = agama;
            this.tempatlahir = tempatlahir;
            this.tanggallahir = tanggallahir;
            this.alamat = alamat;
            this.notelp = notelp;
            this.nohp = nohp;
            this.alamat_email = alamat_email;
            this.picture = picture;
            this.jam = jam;
            this.tanggal = tanggal;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = nipguru;
            textBox2.Text = nama;
            textBox3.Text = jeniskelamin;
            textBox4.Text = agama;
            textBox5.Text = tempatlahir;
            textBox6.Text = tanggallahir;
            textBox10.Text = alamat;
            textBox11.Text = notelp;
            textBox12.Text = nohp;
            textBox13.Text = alamat_email;
            pictureBox1.Image = picture;
            label15.Text = jam;
            label16.Text = tanggal;

        }
    }
}
