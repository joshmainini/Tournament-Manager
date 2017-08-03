using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Match
    {
        
        public int Id { get; set; }
        public Dictionary<string, int> Teams { get; set; }
        public string Winner
        {
            get
            {
                string Winner;
                List<KeyValuePair<string, int>> Teams = new List<KeyValuePair<string, int>>();
                foreach (KeyValuePair<string, int> kvp in Teams)
                {
                    Teams.Add(kvp);
                }
                if (Teams[0].Value > Teams[1].Value )
                {
                    Winner = Teams[0].Key;
                }
                else
                {
                    Winner = Teams[1].Key;
                }
                return Winner;
            }
        }
    }
}