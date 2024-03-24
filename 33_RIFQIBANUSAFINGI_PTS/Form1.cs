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
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
