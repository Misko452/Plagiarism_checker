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
            int[] table = new int[256];                         //Vytvoří pole o 256 možnostech (znaková sada)
            
            for (int i = 0; i < table.Length; i++)              //Nastaví každou hodnotu ve vytvořeném poli na -1 (žádné výskyty)
            {
                table[i] = -1;
            }

            for (int j = 0; j < patternFind.Length; j++)        //Naplní pole přepsáním hodnot int hodnotami znaků ASCII
            {
                table[(int)patternFind[j]] = j;
            }

            return table;                                       //Navrátí tabulku
        }


    }


}
