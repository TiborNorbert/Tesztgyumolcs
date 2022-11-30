using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesztgyumolcs
{
    internal class gyumolcs
    {
        int id;
        string name;
        double egysegar;
        double mennyiseg;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Egysegar { get => egysegar; set => egysegar = value; }
        public double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        public gyumolcs(int id, string name, double egysegar, double mennyiseg)
        {
            Id = id;
            Name = name;
            Egysegar = egysegar;
            Mennyiseg = mennyiseg;
        }
    }
}
