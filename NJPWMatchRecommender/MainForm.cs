using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NJPWMatchRecommender
{
    public partial class MainForm : Form
    {
        List<Match> matches = Match.LoadMatches();
        public MainForm()
        {
            InitializeComponent();
            dtpDateFrom.Value = matches.ElementAt(0).date;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            List<int> ratings = new List<int>();
            if (cbWorthWatch.Checked)
            {
                ratings.Add(0);
            }
            if (cbRecommended.Checked)
            {
                ratings.Add(1);
            }
            if (cbHighRec.Checked)
            {
                ratings.Add(2);
            }

            Match m = Match.SelectMatch(matches, dtpDateFrom.Value, dtpDateTo.Value, txtKeyWords.Text, cbEngComm.Checked, ratings);
            if (m == null)
            {
                rtbOutput.Text = "No Match Found\nTry Changing the Search Parameters";
            }
            else
            {
                rtbOutput.Text = m.ToString();
            }
        }
    }
}
