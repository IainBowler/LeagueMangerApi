using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TableTest.Models
{
    public class LeagueTable
    {
        public IEnumerable<string> Headings { get; set; }

        public IEnumerable<IEnumerable<string>> Rows { get; set; }
    }

    public class League2
    {
        public LeagueTable LeagueTable
        {
                return new LeagueTable();
        }


    }
}