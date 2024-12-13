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

        public void Find(string source, string pattern)
        {
            Pattern.GetLast(pattern);

            int search = pattern.Length-1;
            int patternindex = pattern.Length-1;
            int mover = 0;
            List<int> matches = new List<int>();
            while (true)
            {
                if (source[search-mover].Equals(pattern[patternindex]))
                {
                    string a = source[search] + "";
                    string b = pattern[patternindex] + "";
                    if (patternindex == 0)
                    {
                        for (int i = (search-pattern.Length)+1; i <= search; i++)
                        {
                            matches.Add(i); 
                        }
                        mover = 0;

                        string c = "";
                        foreach (int i in matches)
                        {
                            c += source[i] + "";
                        }
                        MessageBox.Show(c);
                    }
                    else
                    {
                        mover++;
                        patternindex--;
                    }
                }
                else if ((search + pattern.Length) <= source.Length)
                {
                    mover = 0;
                    search+= pattern.Length;
                    patternindex = pattern.Length - 1;
                }
                else
                {
                    break;
                }
            }


        }



    }
    


}

