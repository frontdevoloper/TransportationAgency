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
    public partial class MainForm : Form
    {
        public int CountMoney { get; set; }
        public MainForm()
        {
            InitializeComponent();            
        }       

        private void MainForm_Load(object sender, EventArgs e)
        {            
            CountMoney = Bank.Money;

            UserMoneyAmountTextLebel.Text = CountMoney.ToString();            

            Cities.CreateCities();            
        }       

        private void CheckTransportationButton_Click(object sender, EventArgs e)
        {
            string startingPointTransoprtation = StartingPointTransportationTextBox.Text;
            string endPointTransportation = EndPointTransportationTextBox.Text;

            if (!ValidField(WeightOfCargoTextBox, errorProvider1, "numeric") || 
                !ValidField(StartingPointTransportationTextBox, errorProvider2) ||
                !ValidField(EndPointTransportationTextBox, errorProvider3)
                )
            {
                MessageBox.Show("Есть не заполненные поля", "closing window", MessageBoxButtons.OK);
                return;
            }

            int point = 0;

            for (int i = 0; i < Cities.listOfCities.Length; i++)
            {
                string cityName = Cities.listOfCities[i].Name;
                if (startingPointTransoprtation == cityName || endPointTransportation == cityName)
                {
                    point++;                
                }                
            }

            if (point == 2)
            {
                MessageBox.Show("Вам повезло мы осуществляем доставку в вашем городу", "closing form", MessageBoxButtons.OK);
                TransportSelectionButton.Visible = true;
            }
            else
            {
                MessageBox.Show("К сожалению в вашем городе не осуществляем доставку", "closing form", MessageBoxButtons.OK);
                ClearTextTextBox();
            }            
        }

        private void UpdateUserMoneyBtn_Click(object sender, EventArgs e)
        {
            CountMoney = Bank.Money;
            UserMoneyAmountTextLebel.Text = CountMoney.ToString();
        }

        private void TransportSelectionButton_Click(object sender, EventArgs e)
        {
            (new SelectionTransportation(int.Parse(WeightOfCargoTextBox.Text), StartingPointTransportationTextBox.Text, EndPointTransportationTextBox.Text)).Show();
            ClearTextTextBox();
            TransportSelectionButton.Visible = false;
        }

        private void ReplenishmentButton_Click(object sender, EventArgs e)
        {
            (new Bank()).Show();
        }

        private void AdditionalFeaturesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AdditionalFeaturesCheckBox.Checked == false)
            {
                AdditionalFeaturesgroupBox.Visible = false;
            }
            else
            {
                AdditionalFeaturesgroupBox.Visible = true;
            }            
        }

        private void WeightOfCargoTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidField(WeightOfCargoTextBox, errorProvider1, "numeric");                    
        }

        private void StartingPointTransportationTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidField(StartingPointTransportationTextBox, errorProvider2);          
        }

        private void EndPointTransportationTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidField(EndPointTransportationTextBox, errorProvider3);
        }

        private static bool ValidField(TextBox textBox, ErrorProvider errorProvider, string typeValid = "string")
        {
            if (!ValidTextFields(textBox.Text, out string errorMsg))
            {
                textBox.Select(0, textBox.Text.Length);

                errorProvider.SetError(textBox, errorMsg);

                return false;
            }

            if (!IsNumeric(textBox.Text, out errorMsg) && typeValid == "numeric")
            {
                errorProvider.SetError(textBox, errorMsg);

                return false;
            }

            errorProvider.Clear();
            return true;            
        }

        public static bool ValidTextFields(string text, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (text.Length == 0)
            {
                errorMessage = "Поле не должно быть пустым!";
                return false;
            }

            errorMessage = "";
            return true;
        }

        public static bool IsNumeric(string text, out string errorMessage)
        {
            var isParseNum = int.TryParse(text, out _);
            if (!isParseNum)
            {   errorMessage = "Вы ввели не число";
                return false;
            }

            errorMessage = "";
            return true;
        }        

        private  void ClearTextTextBox()
        {
            foreach (var item in Controls)
            {
                if (item is TextBox box)
                {
                    box.Text = String.Empty;
                }
            }
        }        
    }
}
