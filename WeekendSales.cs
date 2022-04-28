using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProject1 {
    public class WeekendSales {        
        public string Model { get; set; }
        public double Suma { get; set; }
        public double SumaDPH { get; set; }

        public WeekendSales() { }

        public WeekendSales(string Model, double Suma, double SumaDPH) {
            this.Model = Model;
            this.Suma = Suma;
            this.SumaDPH = SumaDPH;
        }
    }
}
