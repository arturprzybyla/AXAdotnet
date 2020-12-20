using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXAdotnet.Data
{
    public class Rate
    {
        public Rate()
        { }

        public Rate(string username, int vote, int episodeid)
        {
            Username = username;
            Vote = vote;
            EpisodeID = episodeid;
        }

        public int ID { get; set; }
        public string Username { get; set; }
        public int Vote { get; set; }
        public int EpisodeID { get; set; }
    }
}
