using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace akıllıgecissistemleri
{
    public partial class Form2 : Form
    {
        OCR ocr1 = (OCR)Application.OpenForms["OCR"];
        public Form2()
        {
            InitializeComponent();
        }

        
        SqlConnection bag = new SqlConnection(" Data Source=DESKTOP-BTFMRHO;Initial Catalog=plakatanimasistemi;Integrated Security=True");
      
        DataTable tablo = new DataTable();

        SqlDataAdapter adtr = new SqlDataAdapter();

        SqlCommand kmt = new SqlCommand();

        void listele()
        {

            tablo.Clear();

            bag.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("select * From araclar", bag);

            adtr.Fill(tablo);

            dataGridView1.DataSource = tablo;

            adtr.Dispose();

            bag.Close();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == "") errorProvider1.SetError(textBox1, "Boş geçilmez");
                else errorProvider1.SetError(textBox1, "");

                if (textBox2.Text.Trim() == "") errorProvider1.SetError(textBox2, "Boş geçilmez");
                else errorProvider1.SetError(textBox2, "");

                if (textBox3.Text.Trim() == "") errorProvider1.SetError(textBox3, "Boş geçilmez");
                else errorProvider1.SetError(textBox3, "");

                if (textBox4.Text.Trim() == "") errorProvider1.SetError(textBox4, "Boş geçilmez");
                else errorProvider1.SetError(textBox4, "");

                if (textBox5.Text.Trim() == "") errorProvider1.SetError(textBox5, "Boş geçilmez");
                else errorProvider1.SetError(textBox5, "");

                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox5.Text.Trim() != "")
                {
                    bag.Open(); //ilk olarak bağlantıyı yani veri tabanımızı açıyoruz.

                    kmt.Connection = bag; //komutumuzun bağlantısını öğreniyoruz.

                    kmt.CommandText = "INSERT INTO araclar(plakano,ad,soyad,telefon,adres) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "' ,'" + textBox5.Text + "')"; //sql kodumuzu yazıyoruz.

                    kmt.ExecuteNonQuery(); //yazılan sql kodunu gerçekleştiriyoruz.

                    kmt.Dispose(); //Burayı yazmak zorunda değilsiniz.Yazmazsanızda çalışır.Komutu kullanım dışı bırakıyor.

                    bag.Close(); //Bağlantıyı kapatıyoruz.
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
                    }
                    listele();

                    MessageBox.Show("Kayıt İşlemi Tamamlandı ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Kayıtlı Seri No !");
                bag.Close();     //www.gorselprogramlama.com         
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.Columns[0].HeaderText = "PlakaID";
            dataGridView1.Columns[1].HeaderText = "Plaka No";
            dataGridView1.Columns[2].HeaderText = "AD";
            dataGridView1.Columns[3].HeaderText = "SOYAD";
            dataGridView1.Columns[4].HeaderText = "TEL";
            dataGridView1.Columns[5].HeaderText = "ADRES";
        }      

    }
}
