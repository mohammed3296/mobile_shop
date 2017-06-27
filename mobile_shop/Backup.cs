using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobile_shop
{
    public partial class Backup : Form
    { 
        public Backup()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text != "")
            {
                string fileName = txtFileName.Text + "\\mobile_shop"+DateTime.Now.ToShortDateString().Replace('/' , '-') +" - " + DateTime.Now.ToShortTimeString().Replace(':' , '-')+".sql";
                string constring = "server=127.0.0.1;user Id =root; password =root;database=mobile_shop;";
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(constring))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ExportToFile(fileName);
                                conn.Close();
                                MessageBox.Show("تم انشاء النسخة الاحتياطيه بنجاح ", "انشاء النسخة الاحتياطيه ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    // Debug.Assert(false, ex.ToString());
                }
            }
            else {
                MessageBox.Show("رجاء قم بتحديد المجلد الذي تريد حفظ النسخة الاحتياطيه عليه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
