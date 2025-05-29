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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("çıkmak istediğinize emin misin", "çkış işlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes) { 
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=vy.mdb");
                baglanti.Open();
                OleDbCommand sorgu = new OleDbCommand("select kad,sifre from kullaniciişlemleri where kad=@ad and sifre=@sifre", baglanti);
                sorgu.Parameters.AddWithValue("@kad", textBox1.Text);
                sorgu.Parameters.AddWithValue("@sifre", textBox2.Text);
                OleDbDataReader dr;
                dr = sorgu.ExecuteReader();

                if (dr.Read())
                {
                    if (gkod == Convert.ToInt16(textBox3.Text))
                    {

                        icerik frm = new icerik();
                        frm.Show();
                        this.Visible = false;
                    }
                    else

                    {
                        MessageBox.Show("güvenlik kodunu yanlış girdiniz.lütfen doğru giriniz");
                    }
                }

                else
                {
                    baglanti.Close();
                    MessageBox.Show("yanlış kullanıcı adı veya parola.lütfen tekrar deneyiniz");
                }
            }
            catch
            {
                MessageBox.Show("lütfen kullanıcı ad ve parolanız ile giriş yapınız");
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Clear();
                textBox3.Clear();
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("çıkmak istediğinize emin misin", "çkış işlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        int gkod;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random r=new Random();
            gkod = r.Next(100,999);
            label4.Text = gkod.ToString();
        }
    }
}
