using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile_shop
{
    class Client
    {
        //members 
        public string clientName;
        public string clientTele; // تليفون العميل
        public int clientNum; // رقم العميل في الدفتر 
        public string bookNum; // رقم الدفتر المسجل فيه العميل
        public string address;
        public string guarantorName; // اسم الضامن 
        public string guarantorNum; //رقم الضامن 
        public string productName; // اسم السلعه 
        public double productPrice;
        public string cellingDate; // تاريخ البيع 
        public int numberOfMonth; // عدد شهور القسط
        public double monthClass; // فئة الشهر
        public double submitted; // المقدم 
        public string notes;
        public string openDate; // اول شهر قسط
        public string expireDate;// اخر شهر قسط
        public int pushed; // عدد الشهور المدفوعه
        public int notPushed; // عدد الشهور المتبقيه 
        // functions 
        public Client(string clientName, string clientTele, int clientNum,
                               string bookNum, string address, string guarantorName,
                               string guarantorNum, string productName, double productPrice,
                               string cellingDate, int numberOfMonth, double monthClass, double submitted,
                               string notes, string openDate, string expireDate, int pushed, int notPushed)
        {
            this.clientName = clientName;
            this.clientTele = clientTele;
            this.clientNum = clientNum;
            this.bookNum = bookNum;
            this.address = address;
            this.guarantorName = guarantorName;
            this.guarantorNum = guarantorNum;
            this.productName = productName;
            this.productPrice = productPrice;
            this.cellingDate = cellingDate;
            this.numberOfMonth = numberOfMonth;
            this.monthClass = monthClass;
            this.submitted = submitted;
            this.notes = notes;
            this.openDate = openDate;
            this.expireDate = expireDate;
            this.pushed = pushed;
            this.notPushed = notPushed;
        }
        private void addClient() { 
        
        }
    }
}
