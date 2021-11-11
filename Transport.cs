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

        public Transport(string name, int unitCost, int pathUnit, int deliverySpeed, bool isCrash = false)
        {
            Name = name;
            UnitCost = unitCost;
            PathUnit = pathUnit;
            DeliverySpeed = deliverySpeed;
            this.IsCrash = isCrash;
        }

        public abstract bool IsTransportibillity(City startCity, City endCity);
    }

    class Airplain : Transport
    {
        public Airplain(string name, int unitCost, int pathUnit, int deliverySpeed, bool isCrash = false) 
            : base(name, unitCost, pathUnit, deliverySpeed, isCrash)
        {            
        }

        public override bool IsTransportibillity(City startCity, City endCity)
        {
            bool pogoda = (startCity.Weather == "Солнечно" || startCity.Weather == "Пасмурно") &&
                          (endCity.Weather == "Солнечно" || endCity.Weather == "Пасмурно");

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

        public Auto(string name, int unitCost, int pathUnit, int deliverySpeed, bool isCrash = false) 
            : base(name, unitCost, pathUnit, deliverySpeed, isCrash)
        {
            if (NumberFreeCars == 0) IsFreeCar = false;
        }

        public override bool IsTransportibillity(City startCity, City endCity)
        {
            if (IsFreeCar)
            {
                Transportability = true;
            }

            return Transportability;
        }
    }

    class Train : Transport
    {
        public Train(string name, int unitCost, int pathUnit, int deliverySpeed, bool isCrash = false) 
            : base(name, unitCost, pathUnit, deliverySpeed, isCrash)
        {
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

}
