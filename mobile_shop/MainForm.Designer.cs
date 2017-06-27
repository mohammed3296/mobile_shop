using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace mobile_shop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        
        public void buidtable(int numofmon)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ////////////////////////////////==================================
            this.yearArray = new Label[numofmon];
            this.monthNOArray = new Label[numofmon];
            this.monthNaArray = new Label[numofmon];
            this.classArray = new TextBox[numofmon];
            this.checkBoxArray = new CheckBox[numofmon];
            this.noteArray = new TextBox[numofmon];
            ////////////////////////////////==================================
            for (int i = 0; i < numofmon; i++)
            {
                this.classArray[i] = new System.Windows.Forms.TextBox();
                this.checkBoxArray[i] = new System.Windows.Forms.CheckBox();
                this.noteArray[i] = new System.Windows.Forms.TextBox();
                this.yearArray[i] = new System.Windows.Forms.Label();
                this.monthNOArray[i] = new System.Windows.Forms.Label();
                this.monthNaArray[i] = new System.Windows.Forms.Label();
                this.tableLayoutPanel1.Controls.Add(this.classArray[i], 3, i + 1);
                this.tableLayoutPanel1.Controls.Add(this.checkBoxArray[i], 4, i + 1);
                this.tableLayoutPanel1.Controls.Add(this.noteArray[i], 5, i + 1);
                this.tableLayoutPanel1.Controls.Add(this.yearArray[i], 0, i + 1);
                this.tableLayoutPanel1.Controls.Add(this.monthNOArray[i], 1, i + 1);
                this.tableLayoutPanel1.Controls.Add(this.monthNaArray[i], 2, i + 1);
                resources.ApplyResources(this.yearArray[i], "year" + i + 1);
                //  this.yearArray[i].Name = "year" + i + 1;
                this.yearArray[i].Text = "year" + i + 1;
                resources.ApplyResources(this.monthNOArray[i], "monthNO" + i + 1);
                //this.monthNOArray[i].Name = "monthNO" + i + 1;
                this.monthNOArray[i].Text = "monthNO" + i + 1;
                resources.ApplyResources(this.monthNaArray[i], "monthNa" + i + 1);
                //   this.monthNaArray[i].Name = "monthNa" + i + 1;
                this.monthNaArray[i].Text = "monthNa" + i + 1;
                resources.ApplyResources(this.classArray[i], "class" + i + 1);
                // this.classArray[i].Name = "class" + i + 1;
                resources.ApplyResources(this.checkBoxArray[i], "checkBox" + i + 1);
                // this.checkBoxArray[i].Name = "checkBox" + i + 1;
                this.checkBoxArray[i].UseVisualStyleBackColor = true;
                resources.ApplyResources(this.noteArray[i], "note" + i + 1);
                this.noteArray[i].Width = 150;

                this.classArray[i].Visible = false;
                this.checkBoxArray[i].Visible = false;
                this.noteArray[i].Visible = false;
                this.yearArray[i].Visible = false;
                this.monthNOArray[i].Visible = false;
                this.monthNaArray[i].Visible = false;
                this.classArray[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.classArrayEvent);
            }

        }
  
        private void classArrayEvent(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9.\b]");
            if (regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            } 
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addClient = new System.Windows.Forms.TabPage();
            this.label51 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.richnotes = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.submittttted = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.class_mo = new System.Windows.Forms.TextBox();
            this.cell_date = new System.Windows.Forms.DateTimePicker();
            this.months = new System.Windows.Forms.TextBox();
            this.produ_price = new System.Windows.Forms.TextBox();
            this.prod_name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guarantor_telep = new System.Windows.Forms.TextBox();
            this.guarantor_Name = new System.Windows.Forms.TextBox();
            this.clientAddress = new System.Windows.Forms.TextBox();
            this.clientNumber = new System.Windows.Forms.TextBox();
            this.book_number = new System.Windows.Forms.TextBox();
            this.clientTele = new System.Windows.Forms.TextBox();
            this.clientName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.headofthemonth = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.clientsformonth = new System.Windows.Forms.ListBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clientDetails = new System.Windows.Forms.GroupBox();
            this.notesClient = new System.Windows.Forms.RichTextBox();
            this.Gnlabel37 = new System.Windows.Forms.Label();
            this.Gnamelabel36 = new System.Windows.Forms.Label();
            this.addresslabel35 = new System.Windows.Forms.Label();
            this.clnumlabel34 = new System.Windows.Forms.Label();
            this.booklabel33 = new System.Windows.Forms.Label();
            this.telephlabel32 = new System.Windows.Forms.Label();
            this.classlabel44 = new System.Windows.Forms.Label();
            this.submitlabel42 = new System.Windows.Forms.Label();
            this.notispushednumlabel43 = new System.Windows.Forms.Label();
            this.ispushednumlabel41 = new System.Windows.Forms.Label();
            this.cellingDatelabel40 = new System.Windows.Forms.Label();
            this.prodPricelabel39 = new System.Windows.Forms.Label();
            this.prodNamelabel38 = new System.Windows.Forms.Label();
            this.namlabel31 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.clientsforinformation = new System.Windows.Forms.ListBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clientsfordelete = new System.Windows.Forms.ListBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلالدخولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انشاءنسخةاحتياطيهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعادةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلالخروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.addClient.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.clientDetails.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addClient);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // addClient
            // 
            this.addClient.BackColor = System.Drawing.SystemColors.Control;
            this.addClient.Controls.Add(this.label51);
            this.addClient.Controls.Add(this.button1);
            this.addClient.Controls.Add(this.button5);
            this.addClient.Controls.Add(this.richnotes);
            this.addClient.Controls.Add(this.label16);
            this.addClient.Controls.Add(this.submittttted);
            this.addClient.Controls.Add(this.label15);
            this.addClient.Controls.Add(this.class_mo);
            this.addClient.Controls.Add(this.cell_date);
            this.addClient.Controls.Add(this.months);
            this.addClient.Controls.Add(this.produ_price);
            this.addClient.Controls.Add(this.prod_name);
            this.addClient.Controls.Add(this.label14);
            this.addClient.Controls.Add(this.label4);
            this.addClient.Controls.Add(this.label3);
            this.addClient.Controls.Add(this.guarantor_telep);
            this.addClient.Controls.Add(this.guarantor_Name);
            this.addClient.Controls.Add(this.clientAddress);
            this.addClient.Controls.Add(this.clientNumber);
            this.addClient.Controls.Add(this.book_number);
            this.addClient.Controls.Add(this.clientTele);
            this.addClient.Controls.Add(this.clientName);
            this.addClient.Controls.Add(this.label12);
            this.addClient.Controls.Add(this.label11);
            this.addClient.Controls.Add(this.label10);
            this.addClient.Controls.Add(this.label9);
            this.addClient.Controls.Add(this.label8);
            this.addClient.Controls.Add(this.label7);
            this.addClient.Controls.Add(this.label5);
            this.addClient.Controls.Add(this.label2);
            this.addClient.Controls.Add(this.label1);
            resources.ApplyResources(this.addClient, "addClient");
            this.addClient.Name = "addClient";
            // 
            // label51
            // 
            resources.ApplyResources(this.label51, "label51");
            this.label51.Name = "label51";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.button5, "button5");
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // richnotes
            // 
            resources.ApplyResources(this.richnotes, "richnotes");
            this.richnotes.Name = "richnotes";
            this.richnotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richnotes_KeyDown);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // submittttted
            // 
            resources.ApplyResources(this.submittttted, "submittttted");
            this.submittttted.Name = "submittttted";
            this.submittttted.KeyDown += new System.Windows.Forms.KeyEventHandler(this.submittttted_KeyDown);
            this.submittttted.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.submittttted_KeyPress);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // class_mo
            // 
            resources.ApplyResources(this.class_mo, "class_mo");
            this.class_mo.Name = "class_mo";
            this.class_mo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.class_mo_KeyDown);
            this.class_mo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.class_mo_KeyPress);
            // 
            // cell_date
            // 
            resources.ApplyResources(this.cell_date, "cell_date");
            this.cell_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cell_date.Name = "cell_date";
            this.cell_date.Value = new System.DateTime(2017, 6, 4, 0, 0, 0, 0);
            this.cell_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cell_date_KeyDown);
            // 
            // months
            // 
            resources.ApplyResources(this.months, "months");
            this.months.Name = "months";
            this.months.KeyDown += new System.Windows.Forms.KeyEventHandler(this.months_KeyDown);
            this.months.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.months_KeyPress);
            // 
            // produ_price
            // 
            resources.ApplyResources(this.produ_price, "produ_price");
            this.produ_price.Name = "produ_price";
            this.produ_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.produ_price_KeyDown);
            this.produ_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.produ_price_KeyPress);
            // 
            // prod_name
            // 
            resources.ApplyResources(this.prod_name, "prod_name");
            this.prod_name.Name = "prod_name";
            this.prod_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.prod_name_KeyDown);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // guarantor_telep
            // 
            resources.ApplyResources(this.guarantor_telep, "guarantor_telep");
            this.guarantor_telep.Name = "guarantor_telep";
            this.guarantor_telep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guarantor_telep_KeyDown);
            this.guarantor_telep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guarantor_telep_KeyPress);
            // 
            // guarantor_Name
            // 
            resources.ApplyResources(this.guarantor_Name, "guarantor_Name");
            this.guarantor_Name.Name = "guarantor_Name";
            this.guarantor_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guarantor_Name_KeyDown);
            // 
            // clientAddress
            // 
            resources.ApplyResources(this.clientAddress, "clientAddress");
            this.clientAddress.Name = "clientAddress";
            this.clientAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientAddress_KeyDown);
            // 
            // clientNumber
            // 
            resources.ApplyResources(this.clientNumber, "clientNumber");
            this.clientNumber.Name = "clientNumber";
            this.clientNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientNumber_KeyDown);
            this.clientNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientNumber_KeyPress);
            // 
            // book_number
            // 
            resources.ApplyResources(this.book_number, "book_number");
            this.book_number.Name = "book_number";
            this.book_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.book_number_KeyDown);
            this.book_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_number_KeyPress);
            // 
            // clientTele
            // 
            resources.ApplyResources(this.clientTele, "clientTele");
            this.clientTele.Name = "clientTele";
            this.clientTele.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientTele_KeyDown);
            this.clientTele.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientTele_KeyPress);
            // 
            // clientName
            // 
            resources.ApplyResources(this.clientName, "clientName");
            this.clientName.Name = "clientName";
            this.clientName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientName_KeyDown);
            this.clientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientName_KeyPress);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.clientsformonth);
            this.tabPage2.Controls.Add(this.textBox12);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.headofthemonth);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // headofthemonth
            // 
            resources.ApplyResources(this.headofthemonth, "headofthemonth");
            this.headofthemonth.BackColor = System.Drawing.Color.White;
            this.headofthemonth.ForeColor = System.Drawing.Color.Black;
            this.headofthemonth.Name = "headofthemonth";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label50, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label49, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label47, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label48, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label52, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label53, 5, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label50
            // 
            resources.ApplyResources(this.label50, "label50");
            this.label50.Name = "label50";
            // 
            // label49
            // 
            resources.ApplyResources(this.label49, "label49");
            this.label49.Name = "label49";
            // 
            // label47
            // 
            resources.ApplyResources(this.label47, "label47");
            this.label47.Name = "label47";
            // 
            // label48
            // 
            resources.ApplyResources(this.label48, "label48");
            this.label48.Name = "label48";
            // 
            // label52
            // 
            resources.ApplyResources(this.label52, "label52");
            this.label52.Name = "label52";
            // 
            // label53
            // 
            resources.ApplyResources(this.label53, "label53");
            this.label53.Name = "label53";
            // 
            // clientsformonth
            // 
            this.clientsformonth.FormattingEnabled = true;
            resources.ApplyResources(this.clientsformonth, "clientsformonth");
            this.clientsformonth.Name = "clientsformonth";
            this.clientsformonth.DoubleClick += new System.EventHandler(this.clientsformonth_DoubleClick);
            // 
            // textBox12
            // 
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.Name = "textBox12";
            this.textBox12.Tag = "";
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            this.textBox12.Enter += new System.EventHandler(this.textBox12_Enter);
            this.textBox12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox12_KeyPress);
            this.textBox12.Leave += new System.EventHandler(this.textBox12_Leave);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.clientDetails);
            this.tabPage1.Controls.Add(this.clientsforinformation);
            this.tabPage1.Controls.Add(this.textBox13);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // clientDetails
            // 
            this.clientDetails.Controls.Add(this.notesClient);
            this.clientDetails.Controls.Add(this.Gnlabel37);
            this.clientDetails.Controls.Add(this.Gnamelabel36);
            this.clientDetails.Controls.Add(this.addresslabel35);
            this.clientDetails.Controls.Add(this.clnumlabel34);
            this.clientDetails.Controls.Add(this.booklabel33);
            this.clientDetails.Controls.Add(this.telephlabel32);
            this.clientDetails.Controls.Add(this.classlabel44);
            this.clientDetails.Controls.Add(this.submitlabel42);
            this.clientDetails.Controls.Add(this.notispushednumlabel43);
            this.clientDetails.Controls.Add(this.ispushednumlabel41);
            this.clientDetails.Controls.Add(this.cellingDatelabel40);
            this.clientDetails.Controls.Add(this.prodPricelabel39);
            this.clientDetails.Controls.Add(this.prodNamelabel38);
            this.clientDetails.Controls.Add(this.namlabel31);
            this.clientDetails.Controls.Add(this.label24);
            this.clientDetails.Controls.Add(this.label25);
            this.clientDetails.Controls.Add(this.label26);
            this.clientDetails.Controls.Add(this.label27);
            this.clientDetails.Controls.Add(this.label28);
            this.clientDetails.Controls.Add(this.label45);
            this.clientDetails.Controls.Add(this.label29);
            this.clientDetails.Controls.Add(this.label30);
            this.clientDetails.Controls.Add(this.label17);
            this.clientDetails.Controls.Add(this.label18);
            this.clientDetails.Controls.Add(this.label19);
            this.clientDetails.Controls.Add(this.label20);
            this.clientDetails.Controls.Add(this.label21);
            this.clientDetails.Controls.Add(this.label22);
            this.clientDetails.Controls.Add(this.label23);
            resources.ApplyResources(this.clientDetails, "clientDetails");
            this.clientDetails.Name = "clientDetails";
            this.clientDetails.TabStop = false;
            // 
            // notesClient
            // 
            resources.ApplyResources(this.notesClient, "notesClient");
            this.notesClient.Name = "notesClient";
            this.notesClient.ReadOnly = true;
            // 
            // Gnlabel37
            // 
            resources.ApplyResources(this.Gnlabel37, "Gnlabel37");
            this.Gnlabel37.BackColor = System.Drawing.Color.White;
            this.Gnlabel37.ForeColor = System.Drawing.Color.Black;
            this.Gnlabel37.Name = "Gnlabel37";
            // 
            // Gnamelabel36
            // 
            resources.ApplyResources(this.Gnamelabel36, "Gnamelabel36");
            this.Gnamelabel36.BackColor = System.Drawing.Color.White;
            this.Gnamelabel36.ForeColor = System.Drawing.Color.Black;
            this.Gnamelabel36.Name = "Gnamelabel36";
            // 
            // addresslabel35
            // 
            resources.ApplyResources(this.addresslabel35, "addresslabel35");
            this.addresslabel35.BackColor = System.Drawing.Color.White;
            this.addresslabel35.ForeColor = System.Drawing.Color.Black;
            this.addresslabel35.Name = "addresslabel35";
            // 
            // clnumlabel34
            // 
            resources.ApplyResources(this.clnumlabel34, "clnumlabel34");
            this.clnumlabel34.BackColor = System.Drawing.Color.White;
            this.clnumlabel34.ForeColor = System.Drawing.Color.Black;
            this.clnumlabel34.Name = "clnumlabel34";
            // 
            // booklabel33
            // 
            resources.ApplyResources(this.booklabel33, "booklabel33");
            this.booklabel33.BackColor = System.Drawing.Color.White;
            this.booklabel33.ForeColor = System.Drawing.Color.Black;
            this.booklabel33.Name = "booklabel33";
            // 
            // telephlabel32
            // 
            resources.ApplyResources(this.telephlabel32, "telephlabel32");
            this.telephlabel32.BackColor = System.Drawing.Color.White;
            this.telephlabel32.ForeColor = System.Drawing.Color.Black;
            this.telephlabel32.Name = "telephlabel32";
            // 
            // classlabel44
            // 
            resources.ApplyResources(this.classlabel44, "classlabel44");
            this.classlabel44.BackColor = System.Drawing.Color.White;
            this.classlabel44.ForeColor = System.Drawing.Color.Black;
            this.classlabel44.Name = "classlabel44";
            // 
            // submitlabel42
            // 
            resources.ApplyResources(this.submitlabel42, "submitlabel42");
            this.submitlabel42.BackColor = System.Drawing.Color.White;
            this.submitlabel42.ForeColor = System.Drawing.Color.Black;
            this.submitlabel42.Name = "submitlabel42";
            // 
            // notispushednumlabel43
            // 
            resources.ApplyResources(this.notispushednumlabel43, "notispushednumlabel43");
            this.notispushednumlabel43.BackColor = System.Drawing.Color.White;
            this.notispushednumlabel43.ForeColor = System.Drawing.Color.Black;
            this.notispushednumlabel43.Name = "notispushednumlabel43";
            // 
            // ispushednumlabel41
            // 
            resources.ApplyResources(this.ispushednumlabel41, "ispushednumlabel41");
            this.ispushednumlabel41.BackColor = System.Drawing.Color.White;
            this.ispushednumlabel41.ForeColor = System.Drawing.Color.Black;
            this.ispushednumlabel41.Name = "ispushednumlabel41";
            // 
            // cellingDatelabel40
            // 
            resources.ApplyResources(this.cellingDatelabel40, "cellingDatelabel40");
            this.cellingDatelabel40.BackColor = System.Drawing.Color.White;
            this.cellingDatelabel40.ForeColor = System.Drawing.Color.Black;
            this.cellingDatelabel40.Name = "cellingDatelabel40";
            // 
            // prodPricelabel39
            // 
            resources.ApplyResources(this.prodPricelabel39, "prodPricelabel39");
            this.prodPricelabel39.BackColor = System.Drawing.Color.White;
            this.prodPricelabel39.ForeColor = System.Drawing.Color.Black;
            this.prodPricelabel39.Name = "prodPricelabel39";
            // 
            // prodNamelabel38
            // 
            resources.ApplyResources(this.prodNamelabel38, "prodNamelabel38");
            this.prodNamelabel38.BackColor = System.Drawing.Color.White;
            this.prodNamelabel38.ForeColor = System.Drawing.Color.Black;
            this.prodNamelabel38.Name = "prodNamelabel38";
            // 
            // namlabel31
            // 
            resources.ApplyResources(this.namlabel31, "namlabel31");
            this.namlabel31.BackColor = System.Drawing.Color.White;
            this.namlabel31.ForeColor = System.Drawing.Color.Black;
            this.namlabel31.Name = "namlabel31";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // label45
            // 
            resources.ApplyResources(this.label45, "label45");
            this.label45.Name = "label45";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // clientsforinformation
            // 
            this.clientsforinformation.FormattingEnabled = true;
            resources.ApplyResources(this.clientsforinformation, "clientsforinformation");
            this.clientsforinformation.Name = "clientsforinformation";
            this.clientsforinformation.SelectedIndexChanged += new System.EventHandler(this.clientsforinformation_SelectedIndexChanged);
            this.clientsforinformation.DoubleClick += new System.EventHandler(this.clientsforinformation_DoubleClick);
            // 
            // textBox13
            // 
            resources.ApplyResources(this.textBox13, "textBox13");
            this.textBox13.Name = "textBox13";
            this.textBox13.Tag = "";
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            this.textBox13.Enter += new System.EventHandler(this.textBox13_Enter);
            this.textBox13.Leave += new System.EventHandler(this.textBox13_Leave);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.clientsfordelete);
            this.tabPage3.Controls.Add(this.textBox14);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            // 
            // clientsfordelete
            // 
            this.clientsfordelete.FormattingEnabled = true;
            resources.ApplyResources(this.clientsfordelete, "clientsfordelete");
            this.clientsfordelete.Name = "clientsfordelete";
            this.clientsfordelete.SelectedIndexChanged += new System.EventHandler(this.clientsfordelete_SelectedIndexChanged);
            this.clientsfordelete.DoubleClick += new System.EventHandler(this.clientsfordelete_DoubleClick);
            // 
            // textBox14
            // 
            resources.ApplyResources(this.textBox14, "textBox14");
            this.textBox14.Name = "textBox14";
            this.textBox14.Tag = "";
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            this.textBox14.Enter += new System.EventHandler(this.textBox14_Enter);
            this.textBox14.Leave += new System.EventHandler(this.textBox14_Leave);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.total);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ملفToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسجيلالدخولToolStripMenuItem,
            this.انشاءنسخةاحتياطيهToolStripMenuItem,
            this.استعادةToolStripMenuItem,
            this.تسجيلالخروجToolStripMenuItem});
            resources.ApplyResources(this.ملفToolStripMenuItem, "ملفToolStripMenuItem");
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            // 
            // تسجيلالدخولToolStripMenuItem
            // 
            this.تسجيلالدخولToolStripMenuItem.Name = "تسجيلالدخولToolStripMenuItem";
            resources.ApplyResources(this.تسجيلالدخولToolStripMenuItem, "تسجيلالدخولToolStripMenuItem");
            this.تسجيلالدخولToolStripMenuItem.Click += new System.EventHandler(this.تسجيلالدخولToolStripMenuItem_Click);
            // 
            // انشاءنسخةاحتياطيهToolStripMenuItem
            // 
            resources.ApplyResources(this.انشاءنسخةاحتياطيهToolStripMenuItem, "انشاءنسخةاحتياطيهToolStripMenuItem");
            this.انشاءنسخةاحتياطيهToolStripMenuItem.Name = "انشاءنسخةاحتياطيهToolStripMenuItem";
            this.انشاءنسخةاحتياطيهToolStripMenuItem.Click += new System.EventHandler(this.انشاءنسخةاحتياطيهToolStripMenuItem_Click);
            // 
            // استعادةToolStripMenuItem
            // 
            resources.ApplyResources(this.استعادةToolStripMenuItem, "استعادةToolStripMenuItem");
            this.استعادةToolStripMenuItem.Name = "استعادةToolStripMenuItem";
            this.استعادةToolStripMenuItem.Click += new System.EventHandler(this.استعادةToolStripMenuItem_Click);
            // 
            // تسجيلالخروجToolStripMenuItem
            // 
            this.تسجيلالخروجToolStripMenuItem.Name = "تسجيلالخروجToolStripMenuItem";
            resources.ApplyResources(this.تسجيلالخروجToolStripMenuItem, "تسجيلالخروجToolStripMenuItem");
            this.تسجيلالخروجToolStripMenuItem.Click += new System.EventHandler(this.تسجيلالخروجToolStripMenuItem_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // total
            // 
            resources.ApplyResources(this.total, "total");
            this.total.Name = "total";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.addClient.ResumeLayout(false);
            this.addClient.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.clientDetails.ResumeLayout(false);
            this.clientDetails.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addClient;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guarantor_telep;
        private System.Windows.Forms.TextBox guarantor_Name;
        private System.Windows.Forms.TextBox clientAddress;
        private System.Windows.Forms.TextBox clientNumber;
        private System.Windows.Forms.TextBox book_number;
        private System.Windows.Forms.TextBox clientTele;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richnotes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox submittttted;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox class_mo;
        private System.Windows.Forms.DateTimePicker cell_date;
        private System.Windows.Forms.TextBox months;
        private System.Windows.Forms.TextBox produ_price;
        private System.Windows.Forms.TextBox prod_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox clientsformonth;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.ListBox clientsforinformation;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.ListBox clientsfordelete;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.GroupBox clientDetails;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label Gnlabel37;
        private System.Windows.Forms.Label Gnamelabel36;
        private System.Windows.Forms.Label addresslabel35;
        private System.Windows.Forms.Label clnumlabel34;
        private System.Windows.Forms.Label booklabel33;
        private System.Windows.Forms.Label telephlabel32;
        private System.Windows.Forms.Label classlabel44;
        private System.Windows.Forms.Label submitlabel42;
        private System.Windows.Forms.Label ispushednumlabel41;
        private System.Windows.Forms.Label cellingDatelabel40;
        private System.Windows.Forms.Label prodPricelabel39;
        private System.Windows.Forms.Label prodNamelabel38;
        private System.Windows.Forms.Label namlabel31;
        private System.Windows.Forms.Label notispushednumlabel43;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label headofthemonth;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلالدخولToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انشاءنسخةاحتياطيهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem استعادةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلالخروجToolStripMenuItem;
        private System.Windows.Forms.RichTextBox notesClient;
        public Label[] yearArray;
        public Label[] monthNOArray;
        public Label[] monthNaArray;
        public TextBox[] classArray;
        public CheckBox[] checkBoxArray;
        public TextBox[] noteArray;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private Button button3;
        private Label total;
        private Label label6;
    }
}

