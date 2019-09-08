using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BarHopApp.Models;
using Newtonsoft.Json;
using System.Web.Script.Serialization;


namespace BarHopApp.Controllers
{
    public class TestController : ApiController
    {

        [HttpPost]
        public string postString()
        {
            return "second Post";
        }

        public Test postGeo(Test data)
        {
            return data;
        }

        public Object postData(Object data)
        {
            return data;
        }

        [HttpGet]
        public string get()
        {
            return "get function";
        }

        [HttpPut]
        public string put()
        {
            return "put function";
        }

        [HttpDelete]
        public string delete()
        {
            return "delete function";
        }
    }
}
