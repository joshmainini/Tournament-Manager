using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Match> Matches { get; set; }
        public int UserId { get; set; }
        public string Winner { get; set; }
    }

    public class TournamentContext : DbContext
    {
        //string conn = "Data Source=localhost\sqlexpress;Initial Catalog=Slime;Integrated Security=True";
        //This is for the purpose of viewing the queries.  Installing the Glimpse package is another option.
        //This constructor is for the purpose of logging SQL queries to the debug OUTPUT window.
        public TournamentContext() : base("Data Source=localhost\\sqlexpress;Initial Catalog=Slime;Integrated Security=True")
        {
            Database.Log = s => Debug.WriteLine(s);
        }
        public DbSet<Tournament> Tournaments { get; set; }
    }
}