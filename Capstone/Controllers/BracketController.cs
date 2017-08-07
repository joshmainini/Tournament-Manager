using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BracketController : Controller
    {
        // GET: Bracket
        //public ActionResult Index()
        //{
        //    return View();
        //}
        private TournamentManagerContext db = new TournamentManagerContext();


        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Index(int? id)
        //{
        //    Tournament tourney = db.Tournaments.FindAsync(id);
        //    List<string> Teams = new List<string>();
        //    foreach (Team team in tourney.Teams)
        //    {
        //        Teams.Add(team.Name);
        //    }
        //    return View(Teams);
        //}
    }
}