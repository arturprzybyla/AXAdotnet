using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using AXAdotnet.Data;
using System.Threading.Tasks;
using AXAdotnet.API;
using System.Text.Json;
using AXAdotnet.Controllers;

namespace AXAdotnet.Controllers
{
    public class FilmController : Controller
    {
        private readonly SWContext _db;

        public FilmController(SWContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var z = GetFilmsController.GetFilms();
            var x = z.results.ToList();
            ViewBag.Films = x;
            return View("Films");
        }

        public IActionResult FilmDetails(int id)
        {
            var z = GetFilmsController.GetFilms();
            var x = z.results.ToList();
            var y = x.Where(x => x.episode_id == id).FirstOrDefault();
            List<Rate> votes = GetVotes(id);
            ViewBag.Votes = votes;
            return View("FilmDetails", y);
        }

        private List<Rate> GetVotes(int id)
        {
            var x = new VoteController(_db);
            return x.GetFilmVotesByFilmId(id).ToList();
        }


    }
}
