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
        private int[] table;

        public List<int> Find(string source, string pattern)
        {
            table = Pattern.GetMatchTable(pattern);
            
            int patternindex = pattern.Length-1; 
            int mover = 0; 

            List<int> matches = new List<int>();

            if (pattern.Length> 0)                                                                                     //Zjistí jestli náhodou nezadáváme prázdný pattern
            {
                while (mover <= (source.Length - pattern.Length))                                                      //Zatímco je mover menší nebo stejný jako rozdíl délek původního textu a hledaného patternu
                {
                    while (patternindex >= 0 && pattern[patternindex] == source[mover + patternindex]) patternindex--; //Projde celý úsek těch indexů a projde písmenka
                                                                                                                       //Vyskočí se z něj až když se najde neshoda
                    if (patternindex < 0)                                                                              //Zde ověří, zda cyklus skončil až po prohledání celého úseku
                    {                                                                                                  //Pokud ano, tak to do Listů matchů nacpe všechna čísla, která jsou indexy shody
                        matches.Add(mover);
                        mover += pattern.Length;                                                                       //Jelikož se našlo celé slovo, přeskočí se dál o celý pattern
                    }
                    else mover += Math.Max(1, patternindex - table[source[mover + patternindex]]);                     //Obecný vzorec pro vypořádání se s duplicitníma písmenkama v patternu 
                    
                    //patternindex - indexování hledaného slova
                    //table - naše vytvořená tabulka ASCII znaků z jiné třídy
                    //source - string původního textu (String je pole znaků)
                    //mover - int proměnná pro posouvání v indexu při hledání tabulky
                    
                    //Odečtene od aktuálního indexu číslo z tabulky o indexu tahaném z původního pole, ve kterém je index součet naší proměnné na posun a indexu

                                                                                                                       //Pokud cyklus skončil dřív kvůli neshodě ve znaku
                                                                                                                       //Poskočí se o maximum mezi 1 a ------- tu nevím
                    patternindex = pattern.Length - 1;                                                                 //V každém případě se však resetuje index, kterým prohledávám úsek
                }
            }

            return matches;
        }



    }
    


}

