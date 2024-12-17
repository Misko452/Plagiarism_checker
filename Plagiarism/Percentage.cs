using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plagiarism
{
    internal class Percentage
    {
        public float FindPercentage(int matches, int lengthofsource, int patternlength)
        {  
            return ((float)matches * 100) / ((float)lengthofsource / (float)patternlength);  //Vzorec pro výpočeet procent
        }
    }
}
