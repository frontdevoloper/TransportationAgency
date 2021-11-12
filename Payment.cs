using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportationAgency
{
    public partial class Payment : Form
    {
        public int SumNum { get; set; }
        public int Delivery { get; set; }
        public static bool IsPayment { get; set; }

        public Payment(int sumNum, int delivery)
        {
            InitializeComponent();
            SumNum = sumNum;
            Delivery = delivery;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            SumTextBox.Text = SumNum.ToString();
            DeliveryTextBox.Text = Delivery.ToString();
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            IsPayment = Bank.RemoveMoney(SumNum);
            this.Close();
        }      
    }
}
