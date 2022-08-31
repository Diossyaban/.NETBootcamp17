using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_oop.QUIZOOP
{
    internal class Suv : Car
    {
        private decimal sewa;
        private decimal biayaSupir;

        public Suv(string noPolisi, int tahun, string type, decimal sewa, decimal biayaSupir) : base(noPolisi, tahun, type)
        {
            this.sewa = sewa;
            this.biayaSupir = biayaSupir;
            TotalPendapatan = sewa + biayaSupir;
        }

        public decimal Sewa { get => sewa; set => sewa = value; }
        public decimal BiayaSupir { get => biayaSupir; set => biayaSupir = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} \nSewa : " +
                  $"{this.sewa.ToString("C", new CultureInfo("id-ID"))} \nBiaya Supir : " +
                  $"{this.biayaSupir.ToString("C", new CultureInfo("id-ID"))} \nTotal Pendapatan :" +
                  $" {this.TotalPendapatan.ToString("C", new CultureInfo("id-ID"))} ";
        }

    }
}
