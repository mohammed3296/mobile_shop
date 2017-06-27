using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobile_shop
{
    public class Events
    {
        public void preventTextSearchEnter(TextBox textbox)
        {
            if (textbox.Text == "اسم العميل...")
            {
                textbox.Text = "";
            }
        }
        public void preventTextSearchLeave(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                textbox.Text = "اسم العميل...";

            }
        }
        public  void preventDouble(KeyPressEventArgs e, string text)
        {
            var regex = new Regex(@"[^0-9.\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (text.Length >= 22 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        public void preventTelephone(KeyPressEventArgs e, string text)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (text.Length >= 11 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        public void preventInteger(KeyPressEventArgs e , TextBox textbox)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (textbox.Text.Length >= 9 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
