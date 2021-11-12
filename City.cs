using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationAgency
{
    enum SizeCity
    {
        little = 10000,
        middle = 500000,
        big = 2000000
    }
    class City
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Weather { get; set; }
        public string СityStatus { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool ExpressWay { get; set; }

        public City(string name, int size, double latitude, double longitude, int expressWay)
        {
            Name = name;
            Size = size;
            Weather = RandomSetWeather();
            СityStatus = GetCityStatus(Size);
            Latitude = latitude;
            Longitude = longitude;
            ExpressWay = expressWay > 15;
        }

        private static string GetCityStatus(int size)
        {
            string result;

            if (size < (int)SizeCity.big && size > (int)SizeCity.middle)
            {
                result = "big";
            }
            else if (size > (int)SizeCity.middle && size < (int)SizeCity.big)
            {
                result = "middle";
            }
            else 
            {
                result = "little";
            }


            return result;
        }

        private static string RandomSetWeather()
        {
            Random random = new();

            string[] weather = { "Пасмурно", "Солнечно", "Гроза", "Шторм" };

            return weather[random.Next(0, 4)];
        }
    }
}
