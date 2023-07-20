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
    public partial class Gelen_Kutusu : Form
    {
        public Gelen_Kutusu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1DQCP20\SQLEXPRESS;Initial Catalog=11.ProjeMesajlasmaSistemi;Integrated Security=True");
        public string nnumara;
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
        void gelenkutusu()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select MESAJID AS 'MESSAGE ID',(AD + ' '+SOYAD) as ' SENDER ', BASLIK AS 'TITLE', ICERIK AS 'CONTENTS'  FROM TBLMESAJLAR inner join TBLKISILER\r\non\r\nTBLMESAJLAR.GONDEREN = TBLKISILER.NUMARA\r\n WHERE ALICI =" + nnumara, baglanti);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
        private void Gelen_Kutusu_Load(object sender, EventArgs e)
        {
        
            gelenkutusu();
          
        }
    }
}
