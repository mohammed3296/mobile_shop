using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
namespace mobile_shop
{

    public partial class MainForm : Form
    {

        public static int numberOfMnthssssssssssssssssssssssssssssssssssss = 0;
        public static string[] MONTHID;
        public Events ev;
        public MySqlConnection conn;   // to connect with mysql
        string myConnectionString = "server=127.0.0.1;user Id =root; password =root;database=mobile_shop;"; // username and password
        public MySqlCommand cmd; // for query and insert and delete and update 
        public MySqlDataReader dr; // to show results 
        public List<int> monthNumbers = new List<int>();
        public List<string> monthNames = new List<string>();
        public List<string> yearNames = new List<string>();
        public List<DateTime> dateTimeOfMont = new List<DateTime>();
        MySqlDataAdapter Da;
        DataSet Ds = new DataSet();
        public void accountOfTotal() {
              try
                {
                    cmd = new MySqlCommand("SELECT SUM(class) as total FROM month where is_checked = 'false' ;", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.IsDBNull(0))
                        {
                            total.Text = "0";
                        }
                        else
                        {
                            total.Text = reader.GetString(0);
                       }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
    }
        public MainForm()
        {
            InitializeComponent();
            buidtable(15);
            //to.Value = DateTime.Now;
            //to.Value = to.Value.AddMonths(14);
            cell_date.Value = DateTime.Now;
            // from.Value = DateTime.Now;
            ev = new Events();
            /* System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ar-EG");
             System.Threading.Thread.CurrentThread.CurrentCulture = ci;*/
            clientsforinformation.Items.Clear();
            clientsformonth.Items.Clear();
            clientsfordelete.Items.Clear();


            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                /*cmd = new MySqlCommand("select * from client", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    clientsforinformation.Items.Add(dr[0].ToString() + "-" + dr[1].ToString() + " " + dr[2].ToString());
                    clientsformonth.Items.Add(dr[0].ToString() + "-" + dr[1].ToString() + " " + dr[2].ToString());
                    clientsfordelete.Items.Add(dr[0].ToString() + "-" + dr[1].ToString() + " " + dr[2].ToString());
                }
                dr.Close();*/
                //  MessageBox.Show(Convert.ToString(conn.State));
                accountOfTotal();
                Da = new MySqlDataAdapter(@"Select (select client_name from client where primeKey = clientprimekey ) as Client_Name ,
                                        year  , month_number , month_name , class From month where is_checked = 'false' and  DateTime < '" + DateTime.Now.ToString("yyyy-MM-dd") + "'", conn);
                Da.Fill(Ds, "lateMonth");
                dataGridView1.DataSource = Ds.Tables["lateMonth"];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool tabEnabledValue
        {
            get { return tabControl1.Enabled; }
            set { tabControl1.Enabled = value; }
        }
        public bool انشاءنسخةاحتياطيهToolStripMenuItemEnabledValue
        {
            get { return انشاءنسخةاحتياطيهToolStripMenuItem.Enabled; }
            set { انشاءنسخةاحتياطيهToolStripMenuItem.Enabled = value; }
        }

        public bool استعادةToolStripMenuItemEnabledValue
        {
            get { return استعادةToolStripMenuItem.Enabled; }
            set { استعادةToolStripMenuItem.Enabled = value; }
        }

        private void textBox12_Enter(object sender, EventArgs e)
        {
            ev.preventTextSearchEnter(textBox12);
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            ev.preventTextSearchLeave(textBox12);
        }

        private void textBox13_Leave(object sender, EventArgs e)
        {
            ev.preventTextSearchLeave(textBox13);
        }

        private void textBox13_Enter(object sender, EventArgs e)
        {
            ev.preventTextSearchEnter(textBox13);
        }
        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }
        private void textBox14_Leave(object sender, EventArgs e)
        {
            ev.preventTextSearchLeave(textBox14);
        }

        private void textBox14_Enter(object sender, EventArgs e)
        {
            ev.preventTextSearchEnter(textBox14);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button_delete()
        {
            clientName.Text = "";
            clientTele.Text = "";
            clientNumber.Text = "";
            book_number.Text = "";
            clientAddress.Text = "";
            guarantor_Name.Text = "";
            guarantor_telep.Text = "";
            prod_name.Text = "لااسم";
            produ_price.Text = "";

            months.Text = "";
            class_mo.Text = "";
            submittttted.Text = "0";
            richnotes.Text = "";
        }

        private bool validation()
        {
            bool isValidated = false;
            double productPrice;
            bool productPriceisNumeric = double.TryParse(produ_price.Text.ToString(), out productPrice);

            double monthClass;
            bool monthClassisNumeric = double.TryParse(class_mo.Text.ToString(), out monthClass);

            double submit;
            bool submitisNumeric = double.TryParse(submittttted.Text.ToString(), out submit);

            if (clientName.Text == "")
            {
                MessageBox.Show("ادخل اسم العميل.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /* else if (clientTele.Text == "")
             {
                 MessageBox.Show("ادخل تليفون العميل.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else if (clientTele.Text.Length < 11)
             {
                 MessageBox.Show(" تليفون العميل يجب ان لا يقل عن 11 رقم .", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
            else if (book_number.Text == "")
            {
                MessageBox.Show("ادخل رقم الدفتر.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(book_number.Text) < 1)
            {
                MessageBox.Show("رقم الدفتر يجب ان يكون اكبر من الصفر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (clientNumber.Text == "")
            {
                MessageBox.Show("ادخل رقم العميل.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (Convert.ToInt32(clientNumber.Text) < 1)
            {
                MessageBox.Show("رقم العميل يجب ان يكون اكبر من الصفر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /* else if (prod_name.Text == "")
             {
                 MessageBox.Show("ادخل اسم السلعه .", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
            else if (produ_price.Text == "")
            {
                MessageBox.Show("ادخل سعر السلعه .", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!productPriceisNumeric)
            {
                MessageBox.Show("ادخل سعر السلعه بطريقة صحيحه.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (productPrice < 1)
            {
                MessageBox.Show("سعر السلعه يجب ان يكون اكبر من الصفر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (months.Text == "")
            {
                MessageBox.Show("ادخل عدد الشهور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(months.Text) < 2 || Convert.ToInt32(months.Text) > 15)
            {
                MessageBox.Show("  عدد الشهور  يجب ان يكون اكبر من 1 \n ولا يزيد عن 15", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (submittttted.Text == "")
            {
                MessageBox.Show("ادخل المقدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!submitisNumeric)
            {
                MessageBox.Show("ادخل المقدم بطريقه صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (submit > productPrice)
            {
                MessageBox.Show("المقدم يجب ان يكون اقل من سعر السلعه ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (class_mo.Text == "")
            {
                MessageBox.Show("ادخل فئة الشهر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!monthClassisNumeric)
            {
                MessageBox.Show("ادخل فئة الشهر بطريقة صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (monthClass < 1)
            {
                MessageBox.Show(" فئة الشهر  يجب ان تكون اكبر من الصفر ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (monthClass > productPrice)
            {
                MessageBox.Show(" فئة الشهر  يجب ان تكون اصغر من سعر السلعه ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                isValidated = true;
                monthNumbers.Clear();
                monthNames.Clear();
                yearNames.Clear();
                dateTimeOfMont.Clear();
                if (cell_date.Text != "")
                {
                    int count = 0;
                    for (DateTime i = cell_date.Value.AddMonths(1); i.Date <= cell_date.Value.AddMonths(Convert.ToInt32(months.Text)); i = i.AddMonths(1))
                    {
                        count++;
                        monthNumbers.Add(i.Month);
                        monthNames.Add(i.ToString("MMMMMMMMMMMMM"));
                        yearNames.Add(i.ToString("yyyy"));
                        dateTimeOfMont.Add(i);
                    }
                    if (count != Convert.ToInt16(months.Text))
                    {
                        MessageBox.Show("مدي الشهور يجب ان يساوي عدد الشهور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isValidated = false;
                    }
                }
            }
            return isValidated;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_delete();
        }

        private void clientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* var regex = new Regex(@"[^a-zA-Z0-9\s]");
             if (regex.IsMatch(e.KeyChar.ToString()))
             {
                 e.Handled = true;
             }*/
        }

        private void book_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.preventInteger(e, book_number);
        }

        private void clientNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.preventInteger(e, clientNumber);
        }

        private void months_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.preventInteger(e, months);
        }
        private void produ_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.preventDouble(e, produ_price.Text.ToString());
        }

        private void class_mo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.preventDouble(e, class_mo.Text.ToString());
        }

        private void submittttted_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.preventDouble(e, submittttted.Text.ToString());
        }

        private void clientTele_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.preventTelephone(e, clientTele.Text.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (validation())
            {
                Client obj = new Client(clientName.Text.ToString(), clientTele.Text.ToString(), Convert.ToInt32(clientNumber.Text),
                             book_number.Text.ToString(), clientAddress.Text.ToString(), guarantor_Name.Text.ToString(), guarantor_telep.Text.ToString()
                               , prod_name.Text.ToString(), Convert.ToDouble(produ_price.Text), cell_date.Text.ToString(), Convert.ToInt32(months.Text)
                                , Convert.ToDouble(class_mo.Text), Convert.ToDouble(submittttted.Text), richnotes.Text.ToString(), cell_date.Text.ToString()
                                , cell_date.Text.ToString(), 0, 0);
                try
                {
                    MySqlCommand check_Book_Name = new MySqlCommand(@"SELECT COUNT(*) FROM client  WHERE book_number =  '" + obj.bookNum + "'", conn);
                    //check_Book_Name.Parameters.AddWithValue("@user", obj.bookNum);
                    int BookExist = Convert.ToInt32(check_Book_Name.ExecuteScalar());

                    if (BookExist > 0)
                    {
                        MySqlCommand check_User_id = new MySqlCommand(@"SELECT COUNT(*) FROM client  WHERE id = '" + obj.clientNum + "' and book_number ='" + obj.bookNum + "'", conn);
                        //   check_User_id.Parameters.AddWithValue("@user", );
                        int UserExist = Convert.ToInt32(check_User_id.ExecuteScalar());

                        if (UserExist > 0)
                        {
                            MessageBox.Show("رقم العميل موجود بالفعل ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //Username doesn't exist.
                            cmd = new MySqlCommand(@"INSERT INTO client (id , book_number , client_name , client_telephone 
                                           , client_address , guarantor_name , guarantor_telephone , product_name , product_price ,
                                           celling_date , numberofmonths , month_class , submitted , notes , expire_date  ) VALUES ('" +
                                                               obj.clientNum + "' , '"
                                                                + obj.bookNum + "', '" +
                                                                obj.clientName + "' ,'" +
                                                                obj.clientTele +
                                                                "' , '" + obj.address + "','" +
                                                                obj.guarantorName + "','" +
                                                                obj.guarantorNum + "','" +
                                                                obj.productName + "','" +
                                                                obj.productPrice + "','"
                                                                + obj.cellingDate + "','" +
                                                               obj.numberOfMonth + "','" +
                                                               obj.monthClass
                                                                + "','" + obj.submitted + "','" +
                                                               obj.notes + "','" + obj.expireDate + "')", conn);
                            cmd.ExecuteNonQuery();
                            int clientID = 0;
                            cmd = new MySqlCommand("select * from client WHERE id = '" + obj.clientNum + "' and book_number ='" + obj.bookNum + "'", conn);
                            dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                clientID = Convert.ToInt32(dr[17].ToString());
                            }
                            dr.Close();
                            for (int i = 0; i < obj.numberOfMonth; i++)
                            {

                                cmd = new MySqlCommand(@"INSERT INTO month ( year , month_number , month_name , class , is_checked  , clientprimekey  , DateTime ) VALUES ('" + yearNames[i] + "','" +
                                                                  monthNumbers[i] + "' , '"
                                                                   + monthNames[i] + "', '" +
                                                                   obj.monthClass + "' ,'" +
                                                                   "false" +
                                                                   "' , '" + clientID + "' , '" + dateTimeOfMont[i].ToString("yyyy-MM-dd") + "')", conn);
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("تم حفظ بيانات العميل بنجاح!", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                            MySqlDataAdapter Da2;
                            DataSet Ds2 = new DataSet();
                            Da2 = new MySqlDataAdapter(@"Select (select client_name from client where primeKey = clientprimekey ) as Client_Name ,
                                        year  , month_number , month_name , class From month where is_checked = 'false' and  DateTime < '" + DateTime.Now.ToString("yyyy-MM-dd") + "'", conn);
                            Da2.Fill(Ds2, "lateMonth");
                            dataGridView1.DataSource = Ds2.Tables["lateMonth"];
                            accountOfTotal();
                        }
                    }
                    else
                    {
                        cmd = new MySqlCommand(@"INSERT INTO client (id , book_number , client_name , client_telephone 
                                           , client_address , guarantor_name , guarantor_telephone , product_name , product_price ,
                                           celling_date , numberofmonths , month_class , submitted , notes , expire_date  ) VALUES ('" +
                                                           obj.clientNum + "' , '"
                                                            + obj.bookNum + "', '" +
                                                            obj.clientName + "' ,'" +
                                                            obj.clientTele +
                                                            "' , '" + obj.address + "','" +
                                                            obj.guarantorName + "','" +
                                                            obj.guarantorNum + "','" +
                                                            obj.productName + "','" +
                                                            obj.productPrice + "','"
                                                            + obj.cellingDate + "','" +
                                                           obj.numberOfMonth + "','" +
                                                           obj.monthClass
                                                            + "','" + obj.submitted + "','" +
                                                           obj.notes + "','" + obj.expireDate + "')", conn);
                        cmd.ExecuteNonQuery();
                        int clientID = 0;
                        cmd = new MySqlCommand("select * from client WHERE id = '" + obj.clientNum + "' and book_number ='" + obj.bookNum + "'", conn);
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            clientID = Convert.ToInt32(dr[17].ToString());
                        }
                        dr.Close();
                        for (int i = 0; i < obj.numberOfMonth; i++)
                        {
                            cmd = new MySqlCommand(@"INSERT INTO month ( year , month_number , month_name , class , is_checked  , clientprimekey  , DateTime ) VALUES ('" + yearNames[i] + "','" +
                                                              monthNumbers[i] + "' , '"
                                                               + monthNames[i] + "', '" +
                                                               obj.monthClass + "' ,'" +
                                                               "false" +
                                                               "' , '" + clientID + "' , '" + dateTimeOfMont[i].ToString("yyyy-MM-dd") + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("تم حفظ بيانات العميل بنجاح!", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MySqlDataAdapter Da2;
                        DataSet Ds2 = new DataSet();
                        Da2 = new MySqlDataAdapter(@"Select (select client_name from client where primeKey = clientprimekey ) as Client_Name ,
                                        year  , month_number , month_name , class From month where is_checked = 'false' and  DateTime < '" + DateTime.Now.ToString("yyyy-MM-dd") + "'", conn);
                        Da2.Fill(Ds2, "lateMonth");
                        dataGridView1.DataSource = Ds2.Tables["lateMonth"];
                        accountOfTotal();
                    }
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void guarantor_telep_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.preventTelephone(e, guarantor_telep.Text.ToString());
        }

        /* private void to_ValueChanged(object sender, EventArgs e)
         {
             if (to.Value < from.Value)
             {
                 MessageBox.Show("اختر مدي صحيح لشهور القسط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 to.Value = from.Value.AddMonths(14);
             }
         }*/

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            clientsformonth.Items.Clear();
            if (textBox12.Text != "" && textBox12.Text != "اسم العميل...")
                try
                {
                    cmd = new MySqlCommand("select * from client where client_name like '%" + textBox12.Text.ToString() + "%'", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        // clientsforinformation.Items.Add(dr[2].ToString());
                        clientsformonth.Items.Add(dr[0].ToString() + "-" + dr[1].ToString() + " " + dr[2].ToString());
                        //clientsfordelete.Items.Add(dr[2].ToString());
                    }
                    dr.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.ToString());

                    //  MessageBox.Show("error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            clientsforinformation.Items.Clear();
            if (textBox13.Text != "" && textBox13.Text != "اسم العميل...")
                try
                {
                    MySqlCommand cmd = new MySqlCommand("select * from client where client_name like '%" + textBox13.Text.ToString() + "%'", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        clientsforinformation.Items.Add(dr[0].ToString() + "-" + dr[1].ToString() + " " + dr[2].ToString());
                        // clientsformonth.Items.Add(dr[2].ToString());
                        //clientsfordelete.Items.Add(dr[2].ToString());
                    }
                    dr.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                    // MessageBox.Show("error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            clientsfordelete.Items.Clear();
            if (textBox14.Text != "" && textBox14.Text != "اسم العميل...")
                try
                {
                    cmd = new MySqlCommand("select * from client where client_name like '%" + textBox14.Text.ToString() + "%'", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        clientsfordelete.Items.Add(dr[0].ToString() + "-" + dr[1].ToString() + " " + dr[2].ToString());
                    }
                    dr.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                    // MessageBox.Show("error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void clientsforinformation_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void انشاءنسخةاحتياطيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup frm = new Backup();
            frm.ShowDialog();
        }

        private void استعادةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Retore frm = new Retore();
            frm.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();

        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.mainForm = this;
            frm.ShowDialog();

        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = false;
            انشاءنسخةاحتياطيهToolStripMenuItem.Enabled = false;
            استعادةToolStripMenuItem.Enabled = false;
        }

        private void clientsfordelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clientsfordelete_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                string selectedValue = clientsfordelete.SelectedItem.ToString();
                if (selectedValue != null)
                {
                    DialogResult result = MessageBox.Show(" انت علي وشك حذف هذا العميل نهائيا \nهل انت متاكد ؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string[] clientNumber1;
                        string[] bookNumber1;
                        clientNumber1 = selectedValue.Split('-');
                        bookNumber1 = selectedValue.Split('-', ' ');
                        string clientID = "";
                        try
                        {
                            MySqlCommand cmd = new MySqlCommand("select * from client where id = '" + clientNumber1[0] + "' and book_number = '" + bookNumber1[1] + "'", conn);
                            dr = cmd.ExecuteReader();
                            dr.Read();
                            clientID = dr[17].ToString();
                            dr.Close();
                            cmd = new MySqlCommand(@"delete from client where primeKey  = '" + clientID + "'", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new MySqlCommand(@"delete from month where clientprimekey  = '" + clientID + "'", conn);
                            cmd.ExecuteNonQuery();
                            clientsfordelete.Items.Remove(selectedValue);
                            MessageBox.Show("تم حذف هذا العميل بنجاح  ", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MySqlDataAdapter Da2;
                            DataSet Ds2 = new DataSet();
                            Da2 = new MySqlDataAdapter(@"Select (select client_name from client where primeKey = clientprimekey ) as Client_Name ,
                                        year  , month_number , month_name , class From month where is_checked = 'false' and  DateTime < '" + DateTime.Now.ToString("yyyy-MM-dd") + "'", conn);
                            Da2.Fill(Ds2, "lateMonth");
                            dataGridView1.DataSource = Ds2.Tables["lateMonth"];
                            accountOfTotal();

                        }
                        catch (MySqlException ex)
                        {
                            Console.WriteLine(ex.Message);
                            MessageBox.Show("هذا العميل غير موجود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                    }
                }
                else { }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("العنصر الذي تم اختياره عنصر فارغ ");
                Console.WriteLine(ex.Message);
            }
        }

        private void clientsforinformation_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string clientID = "";
                string[] clientNumber1;
                string[] bookNumber1;
                string selectedValue = clientsforinformation.SelectedItem.ToString();
                clientNumber1 = selectedValue.Split('-');
                bookNumber1 = selectedValue.Split('-', ' ');
                try
                {
                    MySqlCommand cmd = new MySqlCommand("select * from client where id = '" + clientNumber1[0] + "' and book_number = '" + bookNumber1[1] + "'", conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    namlabel31.Text = dr[2].ToString();
                    telephlabel32.Text = dr[3].ToString();
                    booklabel33.Text = dr[1].ToString();
                    clnumlabel34.Text = dr[0].ToString();
                    addresslabel35.Text = dr[4].ToString();
                    Gnamelabel36.Text = dr[5].ToString();
                    Gnlabel37.Text = dr[6].ToString();
                    prodNamelabel38.Text = dr[7].ToString();
                    prodPricelabel39.Text = dr[8].ToString();
                    cellingDatelabel40.Text = dr[9].ToString();
                    submitlabel42.Text = dr[12].ToString();
                    classlabel44.Text = dr[11].ToString();
                    ispushednumlabel41.Text = dr[15].ToString();
                    notispushednumlabel43.Text = dr[16].ToString();
                    notesClient.Text = dr[13].ToString();
                    clientID = dr[17].ToString();
                }
                catch (MySqlException ex)
                {
                    string asd = ex.Message;
                    //   MessageBox.Show("Some Errors was occured or acount not found \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    dr.Close();
                }

                try
                {
                    MySqlCommand ischeckednumber = new MySqlCommand(@"SELECT COUNT(*) FROM month  WHERE clientprimekey =  '" + clientID + "' and is_checked ='true'", conn);
                    //check_Book_Name.Parameters.AddWithValue("@user", obj.bookNum);
                    int ischecked = Convert.ToInt32(ischeckednumber.ExecuteScalar());
                    ispushednumlabel41.Text = ischecked.ToString();

                    MySqlCommand notischeckednumber = new MySqlCommand(@"SELECT COUNT(*) FROM month  WHERE clientprimekey =  '" + clientID + "' and is_checked ='false'", conn);
                    //check_Book_Name.Parameters.AddWithValue("@user", obj.bookNum);
                    int notischecked = Convert.ToInt32(notischeckednumber.ExecuteScalar());
                    notispushednumlabel43.Text = notischecked.ToString();
                }
                catch (MySqlException ex) { Console.WriteLine(ex.Message); }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

        }

        private void clientsformonth_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 15; i++)
                {
                    this.classArray[i].Visible = false;
                    this.checkBoxArray[i].Visible = false;
                    this.noteArray[i].Visible = false;
                    this.yearArray[i].Visible = false;
                    this.monthNOArray[i].Visible = false;
                    this.monthNaArray[i].Visible = false;
                }
                string[] clientNumber1;
                string[] bookNumber1;
                string selectedValue = clientsformonth.SelectedItem.ToString();
                clientNumber1 = selectedValue.Split('-');
                bookNumber1 = selectedValue.Split('-', ' ');
                string clientPrime = "";

                try
                {
                    MySqlCommand cmd = new MySqlCommand("select * from client where id = '" + clientNumber1[0] + "' and book_number = '" + bookNumber1[1] + "'", conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    clientPrime = dr[17].ToString();
                    numberOfMnthssssssssssssssssssssssssssssssssssss = Convert.ToInt32(dr[10].ToString());
                    MONTHID = new string[numberOfMnthssssssssssssssssssssssssssssssssssss];
                    headofthemonth.Text = dr[2].ToString();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dr.Close();
                }
                try
                {
                    int count = 0;
                    MySqlCommand cmd = new MySqlCommand("select * from month where clientprimekey = '" + clientPrime + "' ORDER BY DateTime ASC", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        MONTHID[count] = dr[6].ToString();
                        yearArray[count].Text = dr[0].ToString();
                        monthNOArray[count].Text = dr[1].ToString();
                        monthNaArray[count].Text = dr[2].ToString();
                        classArray[count].Text = dr[3].ToString();
                        noteArray[count].Text = dr[7].ToString();
                        checkBoxArray[count].Checked = dr[4].ToString().Equals("true") ? true : false;
                        if (checkBoxArray[count].Checked)
                        {
                            checkBoxArray[count].CheckState = CheckState.Checked;
                            this.classArray[count].ForeColor = Color.Red;
                            this.checkBoxArray[count].ForeColor = Color.Red;
                            this.noteArray[count].ForeColor = Color.Red;
                            this.yearArray[count].ForeColor = Color.Red;
                            this.monthNOArray[count].ForeColor = Color.Red;
                            this.monthNaArray[count].ForeColor = Color.Red;

                            this.classArray[count].Enabled = false;
                            //this.checkBoxArray[count].Enabled = false;
                            this.noteArray[count].ReadOnly = true;
                        }
                        else
                        {
                            checkBoxArray[count].CheckState = CheckState.Unchecked;
                            this.classArray[count].ForeColor = Color.Black;
                            this.checkBoxArray[count].ForeColor = Color.Black;
                            this.noteArray[count].ForeColor = Color.Black;
                            this.yearArray[count].ForeColor = Color.Black;
                            this.monthNOArray[count].ForeColor = Color.Black;
                            this.monthNaArray[count].ForeColor = Color.Black;
                            this.classArray[count].Enabled = true;
                            this.checkBoxArray[count].Enabled = true;
                            this.noteArray[count].ReadOnly = false;
                        }
                        this.classArray[count].Visible = true;
                        this.checkBoxArray[count].Visible = true;
                        this.noteArray[count].Visible = true;
                        this.yearArray[count].Visible = true;
                        this.monthNOArray[count].Visible = true;
                        this.monthNaArray[count].Visible = true;
                        count++;
                    }

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dr.Close();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ischeckedddd = "false";
                try
                {
                    for (int i = 0; i < numberOfMnthssssssssssssssssssssssssssssssssssss; i++)
                    {
                        if (checkBoxArray[i].Enabled == true)
                        {
                            //  MessageBox.Show(checkBoxArray[i].CheckState.ToString() + "\n" + MONTHID[i]);
                            if (checkBoxArray[i].CheckState.ToString() == "Unchecked")
                            { ischeckedddd = "false"; }
                            else
                            {
                                ischeckedddd = "true";
                            }
                            MySqlCommand cmd = new MySqlCommand(@"update month set is_checked = '"
                                            + ischeckedddd + "', class = '" + classArray[i].Text + "', noteMonth = '"
                                + noteArray[i].Text + "' where monthprimekey = '" + MONTHID[i] + "'", conn);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("تم حفظ التغيرات بنجاح ", "شطب", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MySqlDataAdapter Da2;
                    DataSet Ds2 = new DataSet();
                    Da2 = new MySqlDataAdapter(@"Select (select client_name from client where primeKey = clientprimekey ) as Client_Name ,
                                        year  , month_number , month_name , class From month where is_checked = 'false' and  DateTime < '" + DateTime.Now.ToString("yyyy-MM-dd") + "'", conn);
                    Da2.Fill(Ds2, "lateMonth");
                    dataGridView1.DataSource = Ds2.Tables["lateMonth"];
                    accountOfTotal();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    // MessageBox.Show(ex.Message);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("لم يتم تحديد عميل بعد ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "متــــــــأخـــــري الدفـــــــــع";
                printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Mobile Shop ";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("حدث خطأ ما ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clientName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                clientTele.Focus();
            }
        }

        private void clientTele_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                book_number.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                clientName.Focus();
            }
        }

        private void book_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) { clientNumber.Focus(); }
            if (e.KeyCode == Keys.Up) { clientTele.Focus(); }
        }

        private void clientNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) { clientAddress.Focus(); }
            if (e.KeyCode == Keys.Up) { book_number.Focus(); }
        }

        private void clientAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) { guarantor_Name.Focus(); }
            if (e.KeyCode == Keys.Up) { clientNumber.Focus(); }
        }

        private void guarantor_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) { guarantor_telep.Focus(); }
            if (e.KeyCode == Keys.Up) { clientAddress.Focus(); }
        }

        private void guarantor_telep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) { prod_name.Focus(); }
            if (e.KeyCode == Keys.Up) { guarantor_Name.Focus(); }
        }

        private void prod_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) { produ_price.Focus(); }
            if (e.KeyCode == Keys.Up) { guarantor_telep.Focus(); }
        }

        private void produ_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) { cell_date.Focus(); }
            if (e.KeyCode == Keys.Up) { prod_name.Focus(); }
        }

        private void cell_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) { months.Focus(); }
            if (e.KeyCode == Keys.Up) { produ_price.Focus(); }
        }

        private void months_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) { submittttted.Focus(); }
            if (e.KeyCode == Keys.Up) { cell_date.Focus(); }
        }

        private void submittttted_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) { class_mo.Focus(); }
            if (e.KeyCode == Keys.Up) { months.Focus(); }
        }

        private void class_mo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) { richnotes.Focus(); }
            if (e.KeyCode == Keys.Up) { submittttted.Focus(); }
        }

        private void richnotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) { clientName.Focus(); }
            if (e.KeyCode == Keys.Up) { class_mo.Focus(); }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = clientName;
            clientName.Focus();
        }
    }
}
