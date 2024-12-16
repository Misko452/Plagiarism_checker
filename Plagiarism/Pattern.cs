using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plagiarism
{
    internal class Pattern
    {

        public Pattern() { }
       
        public static int[] GetMatchTable(string patternFind)
        {
            int[] table = new int[256];
            
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = -1;
            }

            for (int j = 0; j < patternFind.Length; j++) //
            {
                table[(int)patternFind[j]] = j;
            }

            return table;
        }


    }


}
