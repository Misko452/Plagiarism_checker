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
            sourcebox = richTextBoxOriginalText;
        }

        private Match matchclass;
        private Percentage percentage;
        private List<int> matchlist;
        private int lengthofPattern = 0;
        private RichTextBox sourcebox;

        private void HighlightFinds()
        {
            sourcebox.SelectAll();
            sourcebox.SelectionBackColor = Color.White;
            foreach (int match in matchlist)
            {
                sourcebox.Select(match, lengthofPattern);
                sourcebox.SelectionBackColor = Color.Yellow;
            }
        }

        private void ActionFind()
        {
            matchlist = matchclass.Find(richTextBoxOriginalText.Text.ToLower(), textBoxInputPattern.Text.ToLower());
            lengthofPattern = textBoxInputPattern.Text.Length;
            HighlightFinds();
            textBoxPercentage.Text = "Match percentage: " + percentage.FindPercentage(matchlist.Count() * lengthofPattern, richTextBoxOriginalText.Text.Length) + " %";
        }

        private void textBoxInputPattern_TextChanged(object sender, EventArgs e)
        {
            ActionFind();
        }
    }
}
