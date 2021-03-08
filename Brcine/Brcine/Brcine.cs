using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brcine
{
    class Brcine
    {
        string poda1, poda2, poda4, dodatak;
        int poda3;


        public string getPod1(string pod1)
        {
            return this.poda1;
        }
        public string poda1 { get => poda1; set => poda1 = value; }
        public string poda2 { get => poda2; set => poda2 = value; }
        public string poda4 { get => poda4; set => poda4 = value; }
        public string dodatak { get => dodatak; set => dodatak = value }

        public int poda3 { get => poda3; set => poda3 = value; }

        public Brcine()
            public Brcine(string poda1, string poda2, int poda3, string poda4)

        {
            this.poda1 = poda1;
            this.poda2 = poda2;
            this.poda3 = poda3;
            this.poda4 = poda4;
        }
        public string Ispis()
        {
            string ispis = poda1 + "\t" + poda2 + "\t"
                + Convert.ToString(poda3) + "\t"
                + poda4 + "\r\n";
            return ispis;
        }
        public override string ToString()
        {
            +Convert.ToString(poda3) + "\t\t"
                + poda4 + "\t\t" + dodatak + "\r\n";
            return Ispis;
        }
    }

}

