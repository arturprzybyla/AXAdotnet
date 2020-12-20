using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AXAdotnet.API
{
    public class Film
    {
        [DisplayName("Title")]
        public string title { get; set; }
        [DisplayName("Episode ID")]
        public int episode_id { get; set; }
        [DisplayName("Opening crawl")]
        public string opening_crawl { get; set; }
        [DisplayName("Director")]
        public string director { get; set; }
        [DisplayName("Producer")]
        public string producer { get; set; }
        [DisplayName("Release date")]
        public DateTime release_date { get; set; }
        [DisplayName("Species")]
        public string[] species { get; set; }
        [DisplayName("Vehicles")]
        public string[] vehicles { get; set; }
        [DisplayName("Characters")]
        public string[] characters { get; set; }
        [DisplayName("Planets")]
        public string[] planets { get; set; }
        [DisplayName("Url")]
        public string url { get; set; }
        [DisplayName("Created")]
        public DateTime created { get; set; }
        [DisplayName("Edited")]
        public DateTime edited { get; set; }
    }
}
