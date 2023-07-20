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
    public partial class Giden_Kutusu : Form
    {
        
        public Giden_Kutusu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1DQCP20\SQLEXPRESS;Initial Catalog=11.ProjeMesajlasmaSistemi;Integrated Security=True");

        public string etk;


        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            Form3 asdwq = new Form3();
            asdwq.TopMost = true;
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      void gidenkutusu()
        {
            baglanti.Open();
            SqlDataAdapter dr = new SqlDataAdapter("select MESAJID AS 'MESSAGE ID',(AD + ' '+SOYAD) as ' BUYER ', BASLIK AS 'TITLE', ICERIK AS 'CONTENTS'  FROM TBLMESAJLAR inner join TBLKISILER\r\non\r\nTBLMESAJLAR.ALICI = TBLKISILER.NUMARA WHERE GONDEREN=" + etk,baglanti);
            DataTable DT = new DataTable(); 
            dr.Fill(DT);
            dataGridView1.DataSource = DT;
            baglanti.Close();
        }

        private void Giden_Kutusu_Load(object sender, EventArgs e)
        {
            gidenkutusu();
     
        }
    }
}
