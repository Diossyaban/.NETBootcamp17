using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_oop.QUIZOOP
{
    internal class Car
    {
        private string noPolisi;
        private int tahun;
        private string type;
        private decimal totalPendapatan;

        public Car(string noPolisi, int tahun, string type)
        {
            this.noPolisi = noPolisi;
            this.tahun = tahun;
            this.type = type;

        }

        public string NoPolisi { get => noPolisi; set => noPolisi = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public string Type { get => type; set => type = value; }
        public decimal TotalPendapatan { get => totalPendapatan; set => totalPendapatan = value; }

        public override string? ToString()
        {
            return $"No Polisi : {this.noPolisi} Tahun : {this.tahun} Type : {this.type}Total Pendapatan :{this.totalPendapatan}";
        }
    }
}
