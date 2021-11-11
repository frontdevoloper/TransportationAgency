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

namespace TransportationAgency
{
    public partial class SelectionTransportation : Form
    {       
        public int WeightOfCargo { get; set; }
        public string StartingPoint { get; set; }
        public string EndPoint { get; set; }
        public double DistanceCitites { get; set; }
        public double TimeOfDelivery { get; set; }    

        private List<Transport> transports;

        public SelectionTransportation(int weightOfCargo, string startingPoint, string endPoint)
        {
            InitializeComponent();
            WeightOfCargo = weightOfCargo;
            StartingPoint = startingPoint;
            EndPoint = endPoint;  
        }       

        private void SelectionTransportation_Load(object sender, EventArgs e)
        {
            StartPointTextBox.Text = StartingPoint;
            EndPointTextBox.Text = EndPoint;

            var startCity = Cities.listOfCities.First(i => i.Name == StartingPoint);
            var endCity = Cities.listOfCities.First(i => i.Name == EndPoint);

            DistanceCitites = GetDistanceCities(startCity.Latitude, startCity.Longitude, endCity.Latitude, endCity.Longitude);

            transports = CreationTransport();

            foreach (var transport in transports)
            {
                if (transport.IsTransportibillity(startCity, endCity))
                {
                    TransportComboBox.Items.Add(transport.Name);
                }
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            SendButton.Enabled = false;
            RefuseButton.Enabled = false;
            StopDeliveryButton.Visible = true;
            TimeDeliveryTimer.Interval = (int)(TimeOfDelivery * 60);
            StatusProgressBar.Maximum = 100;
            TimeDeliveryTimer.Enabled = true;
        }

        private void TimeDeliveryTimer_Tick(object sender, EventArgs e)
        {
            if (StatusProgressBar.Value < StatusProgressBar.Maximum)
            {
                StatusProgressBar.Value += 1;
            }

            if (StatusProgressBar.Value == StatusProgressBar.Maximum)
            {
                DeliveryComplited();
            }
        }

        private void DeliveryComplited()
        {
            TimeDeliveryTimer.Dispose();
            StopDeliveryButton.Visible = false;
            MessageBox.Show("Груз доставлен", "closing form", MessageBoxButtons.OK);
        }

        private static List<Transport> CreationTransport()
        {
            var transports = new List<Transport>
            {
                new Airplain("Самолет", 800, 1, 750),
                new Train("Поезд", 400, 1, 350),
                new Auto("Машина", 120, 1, 100)
            };

            return transports;
        }        
          
        private static double GetDistanceCities(double startingCityLatitude,double longitudeStartingCities, double latitudeDestinationCity, double longitudeDistanationCities)
        {
            const double EARTH_RADIUS = 6372795;          

            double lat1 = startingCityLatitude * (Math.PI / 180);
            double lat2 = latitudeDestinationCity * (Math.PI / 180);
            double long1 = longitudeStartingCities * (Math.PI / 180);
            double long2 = longitudeDistanationCities * (Math.PI / 180);

            double cl1 = Math.Cos(lat1);
            double cl2 = Math.Cos(lat2);
            double sl1 = Math.Sin(lat1);
            double sl2 = Math.Sin(lat2);
            double delta = long2 - long1;
            double cdelta = Math.Cos(delta);
            double sdelta = Math.Sin(delta);

            double y = Math.Sqrt(Math.Pow(cl2 * sdelta, 2) + Math.Pow(cl1 * sl2 - sl1 * cl2 * cdelta, 2));
            double x = sl1 * sl2 + cl1 * cl2 * cdelta;

            double ad = Math.Atan2(y, x);

            return Math.Round((ad * EARTH_RADIUS) / 1000);          
        }

        private void TransportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var transport in transports)
            {
                if (TransportComboBox.Text == transport.Name)
                {
                    TimeOfDelivery = Math.Round((DistanceCitites / transport.DeliverySpeed));
                    TimeOfDeliveryTextBox.Text = TimeOfDelivery.ToString();
                    CostOfDeliveryTextBox.Text = (transport.UnitCost * TimeOfDelivery).ToString();                    ;
                }
            }
        }

        private void StopDeliveryButton_Click(object sender, EventArgs e)
        {
            switch (StopDeliveryButton.Text)
            {
                case "Остановить":                    
                    TimeDeliveryTimer.Stop();
                    StopDeliveryButton.Text = "Возобновить";
                    break;
                case "Возобновить":                    
                    TimeDeliveryTimer.Start();
                    StopDeliveryButton.Text = "Остановить";
                    break;                
            }
            
        }

        private void RefuseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
