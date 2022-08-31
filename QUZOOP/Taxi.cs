using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_oop.QUIZOOP
{
    internal class Taxi : Car
    {
        private int order;
        private decimal orderperkm;
        private decimal bonus;
        private int totalkm;

        public Taxi(string noPolisi, int tahun, string type, int order, decimal orderperkm, decimal bonus, int totalkm) : base(noPolisi, tahun, type)
        {
            this.order = order;
            this.orderperkm = orderperkm;
            this.bonus = bonus;
            this.totalkm = totalkm;
            TotalPendapatan = (order * bonus) + (orderperkm * Totalkm);
        }

        public int Order { get => order; set => order = value; }
        public decimal Orderperkm { get => orderperkm; set => orderperkm = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }
        public int Totalkm { get => totalkm; set => totalkm = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} order {this.order} | order perkm {this.orderperkm} | bonus {this.bonus} | totalkm {this.totalkm}";
        }
    }
}