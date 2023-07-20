using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _11.PorjeMesajlasmaSistemi
{
    public partial class Mesaj_Yaz : Form
    {
        public Mesaj_Yaz()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1DQCP20\SQLEXPRESS;Initial Catalog=11.ProjeMesajlasmaSistemi;Integrated Security=True");
        public string umara;
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form3 asdwq = new Form3();

            asdwq.Show();
            asdwq.TopMost = true;
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into TBLMESAJLAR (GONDEREN, ALICI,BASLIK,ICERIK) VALUES (@P1,@P2,@P3,@P4) ",baglanti);
            komut3.Parameters.AddWithValue("@P1",umara);
            komut3.Parameters.AddWithValue("@P2",maskedTextBox1.Text);
            komut3.Parameters.AddWithValue("@P3",textBox1.Text);
            komut3.Parameters.AddWithValue("@P4",richTextBox1.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Your Message Has Been Delivered", "Informatiın", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Mesaj_Yaz_Load(object sender, EventArgs e)
        {
            tblnumara.Text = umara;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
