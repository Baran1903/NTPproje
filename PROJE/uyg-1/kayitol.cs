﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace uyg_1
{
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:Kütüphane.mdb");

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 ||textBox2.Text.Length > 0)
            {
                OleDbCommand komut = new OleDbCommand("Insert into klnc(KullaniciAdi,Sifre) values ('" + textBox1.Text + "','" + textBox2.Text + "')", baglan);

                komut.ExecuteNonQuery();
      
                MessageBox.Show("Kayıt İşleminiz Tamamlanmıştır");  
                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre boş bırakılamaz");
            }
        
            baglan.Close();

            Form1 ab = new Form1();
            ab.Show();
            this.Hide();
            
           
 
            
            
        }
            
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 ko = new Form1();
            ko.Show();
            this.Hide();
        }

       
    }
}
