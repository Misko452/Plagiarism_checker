using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plagiarism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            matchclass = new Match();
            percentage = new Percentage();
        }

        private Match matchclass;
        private Percentage percentage;

        private List<int> matchlist;
        private int lengthofPattern = 0;
        

        private void HighlightFinds()
        {                                                           //Metoda pro grafické zpracování zvýraznění shod v textu
            RichTextBox sourcebox = richTextBoxOriginalText;        //Načte se richtextbox (Víceřádkový textbox) do vlastní třídové proměnné pro jednodušší manipulaci
            sourcebox.SelectAll();                                  //Pro jednodušší úklid předchozího zvýraznění si vybereme vše a vše přebarvíme na defaultní bílou
            sourcebox.SelectionBackColor = Color.White;

            foreach (int match in matchlist)                        //Následně se prochází získaný list shod
            {   
                sourcebox.Select(match, lengthofPattern);           //U každé shody se vybere začátek a délka selectu (shoda + délka patternu)
                sourcebox.SelectionBackColor = Color.Yellow;        //Nový výběr se obarví na žluto
            }
        }

        private void ActionFind()
        {
            matchlist = matchclass.Find(richTextBoxOriginalText.Text.ToLower(), textBoxInputPattern.Text.ToLower());                                                        //Najde pole shod podle načtených hodnot z UI pomocí externí třídy
            lengthofPattern = textBoxInputPattern.Text.Length;                                                                                                              //Pro další výpočty si načte délku hledaného patternu
            HighlightFinds();
            ChangePercents();
        }

        private void ChangePercents()
        {
            textBoxPercentage.Text = "Match percentage: " + percentage.FindPercentage(matchlist.Count(), richTextBoxOriginalText.Text.Length, lengthofPattern) + " %";      //Do labelu vypíše text obsahující vypočtený % shody
        }

        private void textBoxInputPattern_TextChanged(object sender, EventArgs e)                                                                                            //Metoda co se volá pokaždé, co změníme hodnotu v poli, kam zadáváme pattern
        {
            ActionFind();
        }

        private void richTextBoxOriginalText_TextChanged(object sender, EventArgs e)
        {
            if (!(richTextBoxOriginalText.Text.Length == null || lengthofPattern == null || matchlist == null))
            {
                ChangePercents();
            }
        }
    }
}
