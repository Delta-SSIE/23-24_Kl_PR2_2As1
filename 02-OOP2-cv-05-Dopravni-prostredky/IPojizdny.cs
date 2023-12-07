using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_05_Dopravni_prostredky
{
    internal interface IPojizdny
    {
        int PocetKol { get; } //co je pojízdné, musí být schopno udat počet kol
        double MaxRychlost { get; }
    }
}
