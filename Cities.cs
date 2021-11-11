using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TransportationAgency
{
    class Cities
    {
        static readonly string[] cityNames = { "Питер", "Москва", "Томск", "Калининград", "Самара", "Олекминск" };
        static readonly double[][] coordinatesOfCities = new double [6][];

        static public City[] listOfCities = new City[cityNames.Length];

        static readonly Random random = new();

        private static void SetCoordinatesCities()
        {
            coordinatesOfCities[0] = new double [2] { 59.9386, 30.3141 };
            coordinatesOfCities[1] = new double [2] { 55.7522, 37.6155 };
            coordinatesOfCities[2] = new double [2] { 56.4977, 84.9743 };
            coordinatesOfCities[3] = new double [2] { 54.7064, 20.5109 };
            coordinatesOfCities[4] = new double [2] { 53.2000, 50.1500 };
            coordinatesOfCities[5] = new double [2] { 60.3743, 120.4203 };
        }     

        public static void CreateCities()
        {
            SetCoordinatesCities();
            
            for (int i = 0; i < cityNames.Length; i++)
            {
                for (int j = 0; j < coordinatesOfCities[i].Length; j++)
                {
                    listOfCities[i] = new City(cityNames[i], random.Next(10000, 2000000), coordinatesOfCities[i][j], coordinatesOfCities[i][++j]);
                }                
            }
        }
    }
}
