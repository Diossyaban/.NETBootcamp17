using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_oop.QUIZOOP
{
    internal interface ICar
    {
        public List<Car> InitListCar();

        public Dictionary<string, decimal> GetTotalRevenueByType(List<Car> list);
        public void ShowListRevenue(Dictionary<string, decimal> list);

        public Dictionary<string, int> TotalCarByType(List<Car> list);

        public List<Car> FindRevenueRange(List<Car> list, decimal startFrom, decimal endtO);


        public void ShowListType(Dictionary<string, int> list);
        public void ShowList<T>(ref List<T> list);

    }
}
