using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class Tournament
	{
		public int TournamentId { get; set; }
		public DateTime Start { get; set; }
		public DateTime End { get; set; }
		public string Location { get; set; }
		public List<Match> Matches { get; set; }
		public int OrganizerId { get; set; }
		public List<Team> Teams { get; set; }
	}
}