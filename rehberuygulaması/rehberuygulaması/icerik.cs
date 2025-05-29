using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rehberuygulaması
{
    public partial class icerik : Form
    {
        public icerik()
        {
            InitializeComponent();
        }

        private void icerik_Load(object sender, EventArgs e)
        {
            goster();
            dataGridView1.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
        }

        void goster()
        {
            OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=vy.mdb");
            baglanti.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adtr=new OleDbDataAdapter("select * from icerik order by ad",baglanti);
            adtr.Fill(ds, "okunan veri");
            dataGridView1.DataSource = ds.Tables["okunan veri"];
            baglanti.Close();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("çıkmak istediğinize emin misin", "çkış işlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekle frm = new ekle();
            frm.Show();
            this.Close();
        }
        string secili_kayit;
        bool kontrol=false;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili=dataGridView1.SelectedCells[0].RowIndex;
            secili_kayit = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            kontrol = true;
            Program.ID= dataGridView1.Rows[secili].Cells[0].Value.ToString();
            Program.tc_no = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            Program.ad = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            Program.soyad = dataGridView1.Rows[secili].Cells[3].Value.ToString();
            Program.tel_no = dataGridView1.Rows[secili].Cells[4].Value.ToString();
            Program.memleketi = dataGridView1.Rows[secili].Cells[5].Value.ToString();
            Program.dogum_yili = dataGridView1.Rows[secili].Cells[6].Value.ToString();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {

                OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=vy.mdb");
                baglanti.Open();
                OleDbCommand sil = new OleDbCommand("delete from icerik where kimlik=@kimlik", baglanti);
                sil.Parameters.AddWithValue("@kimlik", secili_kayit);

                DialogResult onay = MessageBox.Show(secili_kayit + "nolu kayıtı silmek istediğinize emin misiniz?", "silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    sil.ExecuteReader();
                    MessageBox.Show("silme işlemi başarılı");
                }
                baglanti.Close();
                goster();
            }
            else
            {
                MessageBox.Show("lütfen bir kayıt seçiniz");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                düzenleme frm = new düzenleme();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("lütfen bir kayıt seçiniz");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=vy.mdb");
            baglanti.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from icerik where ad like '"+textBox1.Text+"%' order by ad", baglanti);
            adtr.Fill(ds, "okunan veri");
            dataGridView1.DataSource = ds.Tables["okunan veri"];
            baglanti.Close();

        }
    }
}
