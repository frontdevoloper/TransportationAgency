using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationAgency
{
    abstract class Transport
    {
        public string Name { get; set; }
        public int UnitCost { get; set; }
        public int PathUnit { get; set; }
        public int DeliverySpeed { get; set; }
        public bool Transportability { get; set; } = false;
        public bool IsCrash { get; set; }

        public Transport(string name, int unitCost, int pathUnit, int deliverySpeed)
        {
            Name = name;
            UnitCost = unitCost;
            PathUnit = pathUnit;
            DeliverySpeed = deliverySpeed;            
        }

        protected virtual void OnAccident(AccidentEventAgrs e)
        {
            Accident?.Invoke(this, e);
        }

        public abstract bool IsTransportibillity(City startCity, City endCity);

        public abstract void AccidentOccurrence(City city, City cities);
        

        public event EventHandler<AccidentEventAgrs> Accident;

    }

    class Airplain : Transport
    {
        public Airplain(string name, int unitCost, int pathUnit, int deliverySpeed) 
            : base(name, unitCost, pathUnit, deliverySpeed)
        {
            IsCrash = new Random().Next(1, 100) < 10;
        }

        public override void AccidentOccurrence(City city, City cities)
        { 
            if (IsCrash)
            {
                var accident = new AccidentEventAgrs
                {
                    TypeTransport = Name,
                    TypeRoad = city.ExpressWay ? "Скоростная" : "Обычная"
                };              
                OnAccident(accident);
            }
        }

        public override bool IsTransportibillity(City startCity, City endCity)
        {
            bool pogoda = startCity.Weather != "Шторм" && endCity.Weather != "Шторм";

            if (startCity.СityStatus == "big" && endCity.СityStatus == "big" && pogoda)
            {
                Transportability = true;             
            }           

            return Transportability;
        }
    }

    class Auto : Transport
    {
        public static int NumberFreeCars { get; set; } = 5;
        public bool IsFreeCar { get; set; } = true;

        public Auto(string name, int unitCost, int pathUnit, int deliverySpeed) 
            : base(name, unitCost, pathUnit, deliverySpeed)
        {
            if (NumberFreeCars == 0) IsFreeCar = false;
            IsCrash = new Random().Next(1, 100) < 40;
        }

        public override bool IsTransportibillity(City startCity, City endCity)
        {
            if (IsFreeCar)
            {
                Transportability = true;
            }

            return Transportability;
        }

        public override void AccidentOccurrence(City city, City cities)
        { 
            if (IsCrash)
            {
                var accident = new AccidentEventAgrs
                {
                    TypeTransport = Name,
                    TypeRoad = city.ExpressWay ? "Скоростная" : "Обычная"
                };
                OnAccident(accident);
            }
        }
    }

    class Train : Transport
    {
        public Train(string name, int unitCost, int pathUnit, int deliverySpeed) 
            : base(name, unitCost, pathUnit, deliverySpeed)
        {
            IsCrash = new Random().Next(1, 100) < 20;
        }

        public override void AccidentOccurrence(City city, City cities)
        {           
            if (IsCrash)
            {
                var accident = new AccidentEventAgrs
                {
                    TypeTransport = Name,
                    TypeRoad = city.ExpressWay ? "Скоростная" : "Обычная"
                };               
                OnAccident(accident);
            }
        }

        public override bool IsTransportibillity(City startCity, City endCity)
        {
            if (startCity.СityStatus != "little" && endCity.СityStatus != "little")
            {
                Transportability = true;
            }

            return Transportability;
        }
    }

    class AccidentEventAgrs : EventArgs
    {
        public string TypeTransport { get; set; }
        public string TypeRoad { get; set; }
    }

}
