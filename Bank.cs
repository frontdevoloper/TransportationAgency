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
    public partial class Bank : Form
    {
        public static int Money { get; set; } = 0;
        public Bank()
        {
            InitializeComponent();
        }

        private void AddMoneyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int moneyText = int.Parse(MoneyTextBox.Text);                

                AddMoney(moneyText);
                MoneyTextBox.Text = String.Empty;

            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя внести пустую сумму в банк, пожалуйста введите сумму", "Введите сумму в поле", MessageBoxButtons.OK);
            }
              
        }

        public static void AddMoney(int money)
        {
            if (money > 0)
            {
                Money += money;
            }                        
        }

        public static void RemoveMoney(int money)
        {
            if (Money > money)
            {
                Money -= money;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            (new MainForm()).Show(); 
            this.Close();
        }

        private void Bank_Load(object sender, EventArgs e)
        {

        }
    }
}
