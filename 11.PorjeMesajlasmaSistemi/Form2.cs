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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1DQCP20\SQLEXPRESS;Initial Catalog=11.ProjeMesajlasmaSistemi;Integrated Security=True");



        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            textBox2.ForeColor = Color.FromArgb(0, 192, 192);
            panel1.BackColor = Color.White;
            maskedTextBox1.ForeColor = Color.White;
        }

       
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            Form1 frm = new Form1();
            frm.Show();
            frm.TopMost = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKISILER WHERE NUMARA=@P1 AND SIFRE=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@P2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form3 sda = new Form3();
                sda.numara = maskedTextBox1.Text.ToString();
              
            
                sda.Show();
                
                this.Hide();
              
            }
            else
            {
                MessageBox.Show("Wrong number or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            baglanti.Close();
        }



        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            maskedTextBox1.ForeColor = Color.FromArgb(0, 192, 192);
            panel2.BackColor = Color.White;
            textBox2.ForeColor = Color.White;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Focus();
        }
    }
}
