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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _33_RIFQIBANUSAFINGI_PTS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Laki - laki");
            comboBox1.Items.Add("Perempuan");

            comboBox2.Items.Add("Budha");
            comboBox2.Items.Add("Hindu");
            comboBox2.Items.Add("Islam");
            comboBox2.Items.Add("Katholik");
            comboBox2.Items.Add("Protestan");
            comboBox2.Items.Add("Konghucu");

            timer1.Interval = 1000;
            timer1.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nipguru = textBox1.Text;
            var nama = textBox2.Text;
            var jeniskelamin = comboBox1.Text;
            var agama = comboBox2.Text;
            var tempatlahir = textBox3.Text;
            var tanggallahir = dateTimePicker1.Text;
            var alamat = textBox5.Text;
            var notelp = textBox6.Text;
            var nohp = textBox7.Text;
            var alamat_email = textBox8.Text;
            var picture = pictureBox1.Image;
            var jam = label15.Text;
            var tanggal = label16.Text;

            Form4 frm4 = new Form4(nipguru, nama, jeniskelamin, agama, tempatlahir, tanggallahir, alamat, notelp, nohp, alamat_email, picture, jam, tanggal);
            frm4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToLongTimeString();
            label16.Text = DateTime.Now.ToLongDateString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Akan Keluar Pendataan Biodata Guru !!", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { Application.Exit(); }
        }
    }

}

