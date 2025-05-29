using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace rehberuygulaması
{
    public partial class düzenleme : Form
    {
        public düzenleme()
        {
            InitializeComponent();
        }

        private void düzenleme_Load(object sender, EventArgs e)
        {
            textBox1.Text=Program.ID;
            textBox2.Text=Program.tc_no;
            textBox3.Text = Program.ad; 
            textBox4.Text = Program.soyad;
            textBox5.Text = Program.tel_no;
            textBox6.Text = Program.memleketi;
            textBox7.Text = Program.dogum_yili;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=vy.mdb");
            baglanti.Open();

            OleDbCommand komut=new OleDbCommand("update icerik set tc_no=@tc_no,ad=@ad,soyad=@soyad,tel_no=@tel_no,memleketi=@memleketi,dogum_yili=@dogum_yili where kimlik=@kimlik",baglanti);
            komut.Parameters.AddWithValue("@tc_no",textBox2.Text);
            komut.Parameters.AddWithValue("@ad", textBox3.Text);
            komut.Parameters.AddWithValue("@soyad", textBox4.Text);
            komut.Parameters.AddWithValue("@tel_no", textBox5.Text);
            komut.Parameters.AddWithValue("@memleketi", textBox6.Text);
            komut.Parameters.AddWithValue("@dogum_yili", textBox7.Text);
            komut.Parameters.AddWithValue("@kimlik", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("düzenleme başarılı");
            icerik frm=new icerik();
            frm.Show();
            this.Close();

        }
    }
}
