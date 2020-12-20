using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AXAdotnet.Data;

namespace AXAdotnet.Controllers
{
    public class VoteController : Controller
    {
        private readonly SWContext _db;

        public VoteController(SWContext context)
        {
            _db = context;
        }


        public JsonResult AddVoteToDB(string username, int vote, int episodeid)
        {
            _db.Database.EnsureCreated();
            using (var transaction = _db.Database.BeginTransaction())
            {
                try
                {
                    _db.Rates.Add(new Rate(username, vote, episodeid));
                    transaction.Commit();
                    _db.SaveChanges();
                    return new JsonResult("X");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return new JsonResult(ex.Message);
                }
            }
        }

        public List<Rate> GetFilmVotesByFilmId(int id)
        {
            _db.Database.EnsureCreated();
            return _db.Rates.Where(x => x.EpisodeID == id).ToList();
        }
    }
}
