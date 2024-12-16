using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plagiarism
{
    internal class Match
    {
        public Match()
        {

        }

        int[] table;

        public void Find(string source, string pattern)
        {
            table = Pattern.GetMatchTable(pattern);

            int patternindex = pattern.Length-1; 
            int mover = 0; 

            List<int> matches = new List<int>();

            while (mover <= (source.Length - pattern.Length))                                                      //Zatímco je mover menší nebo stejný jako rozdíl délek původního textu a hledaného patternu
            {
                while (patternindex >= 0 && pattern[patternindex] == source[mover + patternindex]) patternindex--; //Projde celý úsek těch indexů a projde písmenka
                                                                                                                   //Vyskočí se z něj až když se najde neshoda
                if (patternindex < 0)                                                          //Zde ověří, zda cyklus skončil až po prohledání celého úseku
                {                                                                              //Pokud ano, tak to do Listů matchů nacpe všechna čísla, která jsou indexy shody
                    for (int i = mover; i < mover + pattern.Length; i++) matches.Add(i);
                    mover += pattern.Length;                                                   //Jelikož se našlo celé slovo, přeskočí se dál o celý pattern
                }
                else mover += Math.Max(1, patternindex - table[source[mover + patternindex]]); //Pokud cyklus skončil dřív kvůli neshodě ve znaku
                                                                                               //Poskočí se o maximum mezi 1 a ------- tu nevím
                patternindex = pattern.Length - 1;                                             //V každém případě se však resetuje index, kterým prohledávám úsek
            }

            string c = "";
            foreach (int i in matches)
            {
                c += source[i] + "";
            }
            MessageBox.Show(c);

        }



    }
    


}

