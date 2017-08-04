using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Match
    {
        
        public int Id { get; set; }
        public Dictionary<Team, int> Teams { get; set; }
        public string Winner
        {
            get
            {
                string Winner;
                List<KeyValuePair<Team, int>> Teams = new List<KeyValuePair<Team, int>>();
                foreach (KeyValuePair<Team, int> kvp in Teams)
                {
                    Teams.Add(kvp);
                }
                if (Teams[0].Value > Teams[1].Value )
                {
                    Winner = Teams[0].Key.Name;
                }
                else
                {
                    Winner = Teams[1].Key.Name;
                }
                return Winner;
            }
        }
    }
}