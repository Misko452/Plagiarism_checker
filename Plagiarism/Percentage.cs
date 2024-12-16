using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plagiarism
{
    internal class Percentage
    {

        public float FindPercentage(int matches, int lengthofsource)
        {
            return ((float)lengthofsource / 100) * (float)matches;      //Vzorec pro výpočeet procent
        }
    }
}
