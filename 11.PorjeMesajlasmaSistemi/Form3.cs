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
using System.Security.Cryptography;

namespace _11.PorjeMesajlasmaSistemi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1DQCP20\SQLEXPRESS;Initial Catalog=11.ProjeMesajlasmaSistemi;Integrated Security=True");

        public string numara;
        Form1 ert = new Form1();
        Form2 cer = new Form2();
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           
            Mesaj_Yaz tck = new Mesaj_Yaz();
            tck.umara = numara;
            tck.Show();
            this.Hide();
              ert.Hide();
            
            cer.TopMost = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
 
        private void BtnGelenKutusu_Click(object sender, EventArgs e)
        {
            Gelen_Kutusu crt = new Gelen_Kutusu();
            crt.nnumara= numara;
            crt.Show();
            crt.TopMost = true;
            this.TopMost = false;
            
            ert.Hide();
            
            cer.TopMost = false;
        }

        private void BtnGidenKutusu_Click(object sender, EventArgs e)
        {
            Giden_Kutusu asd = new Giden_Kutusu();

            asd.etk = numara;
            asd.Show();
            ert.Hide();

            cer.TopMost = false;


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void Form3_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            lblnumara.Text = numara.ToString();
            


            SqlCommand komut1 = new SqlCommand("select AD, SOYAD FROM TBLKISILER WHERE NUMARA =@P1",baglanti);
            komut1.Parameters.AddWithValue("@P1", numara);
            SqlDataReader DR = komut1.ExecuteReader();
            while (DR.Read())
            {
                r123213.Text = DR[0].ToString() + " "+DR[1].ToString();
            }

            baglanti.Close();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
      
        }
    }
}
