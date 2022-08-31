using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_oop.QUIZOOP
{
    internal class CarImpls : ICar
    {
        public List<Car> FindRevenueRange(List<Car> list, decimal startFrom, decimal endtO)
        {
            var dioz = new List<Car>();
            foreach (var item in list)
            {
                if (item.TotalPendapatan >= startFrom && item.TotalPendapatan <= endtO)
                {
                    dioz.Add(item);
                }
            }
            return dioz;

        }

        public Dictionary<string, decimal> GetTotalRevenueByType(List<Car> list)
        {
            var dioz = new Dictionary<string, decimal>(); decimal TotalGetSUV = 0;
            decimal TotalGetTaxi = 0;
            decimal TotalGetAngkot = 0;

            foreach (var item in list)
            {
                if (item.Type == "SUV")
                {
                    TotalGetSUV += item.TotalPendapatan;
                }

                else if (item.Type == "TAXI")
                {
                    TotalGetTaxi += item.TotalPendapatan;
                }
                else if (item.Type == "ANGKOT")
                    TotalGetAngkot += item.TotalPendapatan;
            }
            dioz.Add("SUV", TotalGetSUV);
            dioz.Add("TAXI", TotalGetTaxi);
            dioz.Add("ANGKOT", TotalGetAngkot);
            return dioz;

        }

        public List<Car> InitListCar()
        {
            Suv suv1 = new Suv("D 1001 UM", 2015, "SUV", 100_000, 600_000);
            Suv suv2 = new Suv("D 1002 UM", 2019, "SUV", 100_000, 600_000);

            Taxi taxi1 = new Taxi("D 88 UK", 2018, "TAXI", 5, 4500, 10_000, 40);
            Taxi taxi2 = new Taxi("D 87 UK", 2018, "TAXI", 10, 4500, 10_000, 100);

            Angkot angkot1 = new Angkot("D 55 UJ", 2016, "ANGKOT", 4500, 35);
            Angkot angkot2 = new Angkot("D 55 UJ", 2016, "ANGKOT", 4500, 40);

            return new List<Car> { suv1, suv2, taxi1, taxi2, angkot1, angkot2 };
        }

        public void ShowList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }

        public void ShowListRevenue(Dictionary<string, decimal> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }

        public void ShowListType(Dictionary<string, int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }

        public Dictionary<string, int> TotalCarByType(List<Car> list)
        {
            var dioz = new Dictionary<string, int>();
            int TotalTypetSUV = 0;
            int TotalTypeTaxi = 0;
            int TotalTypeAngkot = 0;

            foreach (var item in list)
            {
                if (item.Type == "SUV")
                {
                    TotalTypetSUV++;

                }

                else if (item.Type == "TAXI")
                {
                    TotalTypeTaxi++;
                }
                else if (item.Type == "ANGKOT")
                    TotalTypeAngkot++;
            }
            dioz.Add("SUV", TotalTypetSUV);
            dioz.Add("TAXI", TotalTypeTaxi);
            dioz.Add("ANGKOT", TotalTypeAngkot);
            return dioz;
        }
    }
}