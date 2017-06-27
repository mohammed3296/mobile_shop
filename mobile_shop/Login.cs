using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobile_shop
{
    public partial class Login : Form
    {
        public MainForm mainForm;
        public bool isvalidated = false; 
        public Login()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "محمود" || textBox1.Text == "12345678910fci@gmail.com")
            {
                if (textBox2.Text == "محمود123" || textBox2.Text == ".1230.")
                {
                    isvalidated = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("خطأ في كلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("خطأ في اسم المستخدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Enter(object sender, EventArgs e)
        {
           // button1_Click(sender , e);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)mainForm).tabEnabledValue = isvalidated;
            ((MainForm)mainForm).انشاءنسخةاحتياطيهToolStripMenuItemEnabledValue = isvalidated;
            ((MainForm)mainForm).استعادةToolStripMenuItemEnabledValue= isvalidated;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) { textBox2.Focus(); }
            if (e.KeyCode == Keys.Up) { textBox2.Focus(); }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) { textBox1.Focus(); }
            if (e.KeyCode == Keys.Up) { textBox1.Focus(); }
            if (e.KeyCode == Keys.Enter) {
                button1_Click(sender , e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1 ;
            textBox1.Focus();
        }
    }
}
