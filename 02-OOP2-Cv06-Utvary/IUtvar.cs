using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_Cv06_Utvary
{
    internal interface IUtvar
    {
        string Nazev { get; }
        double GetObvod();
        double GetObsah();
    }
}
