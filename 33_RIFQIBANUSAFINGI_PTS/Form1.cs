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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Laki - laki");
            comboBox1.Items.Add("Perempuan");

            comboBox2.Items.Add("Budha");
            comboBox2.Items.Add("Hindu");
            comboBox2.Items.Add("Islam");
            comboBox2.Items.Add("Katholik");
            comboBox2.Items.Add("Protestan");
            comboBox2.Items.Add("Konghucu");

            comboBox2.Items.Add("Hindu");
            comboBox2.Items.Add("Islam");
            comboBox2.Items.Add("Katholik");
            comboBox2.Items.Add("Protestan");
            comboBox2.Items.Add("Konghucu");

            comboBox3.Items.Add("Tidak Sekolah");
            comboBox3.Items.Add("Putus SD");
            comboBox3.Items.Add("SD Sederajat");
            comboBox3.Items.Add("SMP Sederajat");
            comboBox3.Items.Add("SMA Sederajat");
            comboBox3.Items.Add("D-1");
            comboBox3.Items.Add("D-2");
            comboBox3.Items.Add("D-3");
            comboBox3.Items.Add("S-1");
            comboBox3.Items.Add("S-2");
            comboBox3.Items.Add("S-3");

            comboBox4.Items.Add("Belum Menikah");
            comboBox4.Items.Add("Duda");
            comboBox4.Items.Add("Janda");
            comboBox4.Items.Add("Menikah");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string status = radioButton1.Checked ? "Aktif" : "Tidak Aktif";

            var nipguru = textBox1.Text;
            var nama = textBox2.Text;
            var jeniskelamin = comboBox1.Text;
            var agama = comboBox2.Text;
            var tempatlahir = textBox3.Text;
            var tanggallahir = dateTimePicker1.Text;
            var pendidikan = comboBox3.Text;
            var status1 = comboBox4.Text;
            var jumlah_anak = textBox4.Text;
            var alamat = textBox5.Text;
            var notelp = textBox6.Text;
            var nohp = textBox7.Text;
            var alamat_email = textBox8.Text;
            Form2 frm2 = new Form2(nipguru, nama, jeniskelamin, agama, tempatlahir, tanggallahir,
            pendidikan, status1, jumlah_anak, alamat, notelp, nohp, alamat_email,
            status);
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Akan Keluar dari Form1 !!", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { Application.Exit(); }
        }
    }
}
