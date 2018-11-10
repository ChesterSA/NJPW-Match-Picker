using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJPWMatchRecommender
{
    class Match
    {
        public DateTime date;
        public string match;
        public string jpnLink;
        public string show;
        public string venue;
        public string notes;
        public string engLink;
        public int rating;

        public Match(string date, string match, string jpnLink, string show, string venue, string notes, string engLink, string rating)
        {
            this.date = DateTime.Parse(date);
            this.match = match;
            this.jpnLink = jpnLink;
            this.show = show;
            this.venue = venue;
            this.notes = notes;
            this.engLink = engLink;
            this.rating = Int32.Parse(rating);
        }

        public static List<Match> LoadMatches()
        {
            string filepath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            filepath = Directory.GetParent(filepath).FullName;
            filepath = Directory.GetParent(filepath).FullName;

            StreamReader reader = new StreamReader(filepath + "/NJPW.csv");
            List<Match> matches = new List<Match>();
            string[] match;

            while (!reader.EndOfStream)
            {
                match = reader.ReadLine().Split(';');
                matches.Add(new Match(match[0], match[1], match[2], match[3], match[4], match[5], match[6], match[7]));
            }

            return matches;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("Date:    " + date.ToShortDateString() + "\n");
            s.Append("Match:   " + match + "\n");
            s.Append("JpnLink: " + jpnLink + "\n");
            s.Append("Show:    " + show + "\n");
            s.Append("Venue:   " + venue + "\n");
            s.Append("Notes:   " + notes + "\n");
            s.Append("engLink: " + engLink + "\n");
            switch (rating)
            {
                case 0:
                    s.Append("Worth a Watch");
                    break;
                case 1:
                    s.Append("Recommended");
                    break;
                case 2:
                    s.Append("Highly Recommended");
                    break;
            }

            return s.ToString();
        }

        

        static public Match SelectMatch(List<Match> matches, DateTime dateFrom, DateTime dateTo, string keyWords, bool engLink, List<int> ratings)
        {
            List<Match> updatedMatches = new List<Match>();

            for (int i = 0; i < matches.Count; i++)
            {
                Match m = matches.ElementAt(i);
                if ((m.date >= dateFrom && m.date <= dateTo) &&
                    (m.match.Contains(keyWords) || m.show.Contains(keyWords) || m.venue.Contains(keyWords)) &&
                    (String.IsNullOrEmpty(m.engLink) != engLink) &&
                    (ratings.Contains(m.rating)))
                {
                    updatedMatches.Add(m);
                }
            }
            Random r = new Random();
            Match toReturn = null;
            if (updatedMatches.Count > 0)
                toReturn = updatedMatches.ElementAt(r.Next(0, updatedMatches.Count));
            return toReturn;
        }
    }
}
