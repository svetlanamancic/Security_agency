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
    public class GradMenadzerController : ApiController
    {

        // GET api/gradmenadzer
        public List<GradMenadzerView> Get()
        {
            DataProvider provider = new DataProvider();

            List<GradMenadzerView> gradovi = provider.GetGradoveSvihMenadzera();



            return gradovi;
        }

        // GET api/gradmenadzer/5
        public GradMenadzerView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetGradMenadzerView(id);
        }

        // POST api/gradmenadzer
        public int Post([FromBody]GradMenadzer v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddGradMenadzer(v);
        }

        // PUT api/gradmenadzer/5
        public void Put(int id, [FromBody]GradMenadzer v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateGradMenadzer(id, v);

            return;
        }

        // DELETE api/gradmenadzer/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveGradMenadzer(id);
        }

    }
}
