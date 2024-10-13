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
    public class MenadzerController : ApiController
    {
        
        // GET api/menadzer
        public List<MenadzerView> Get()
        {
            DataProvider provider = new DataProvider();

            List<MenadzerView> menadzeri = provider.GetMenadzeri();

          

            return menadzeri;
        }

        // GET api/menadzer/5
        public MenadzerView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetMenadzerView(id);
        }

        // POST api/menadzer
        public int Post([FromBody]Menadzer v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddMenadzer(v);
        }

        // PUT api/menadzer/5
        public void Put(int id, [FromBody]Menadzer v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateMenadzer(id, v);

            return;
        }

        // DELETE api/menadzer/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveMenadzer(id);
        }

    }
}
