using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarHopApp.Models
{
    public class Test
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class Test2
    {
        public Test t { get; set; }
    }
}