using SBP_Projekat;
using SBP_Projekat.DTOs;
using SBP_Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class OblastTehnikeController : ApiController
    {

        // GET api/oblasttehnike
        public List<OblastTehnikeView> Get()
        {
            DataProvider provider = new DataProvider();

            List<OblastTehnikeView> oblasti = provider.GetOblastiTehnike();



            return oblasti;
        }

        // GET api/oblasttehnike/5
        public OblastTehnikeView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetOblastTehnikeView(id);
        }

        // POST api/oblasttehnike
        public int Post([FromBody]OblastTehnike v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddOblastTehnike(v);
        }

        // PUT api/oblasttehnike/5
        public void Put(int id, [FromBody]OblastTehnike v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateOblastTehnike(id, v);

            return;
        }

        // DELETE api/oblasttehnike/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveOblastTehnike(id);
        }

    }
}
