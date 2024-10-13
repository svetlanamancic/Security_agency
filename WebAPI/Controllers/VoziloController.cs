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
    public class VoziloController : ApiController
    {

        // GET api/vozilo
        public List<VoziloView> Get()
        {
            DataProvider provider = new DataProvider();

            List<VoziloView> vozila = provider.GetVozila();

            return vozila;
        }

        // GET api/vozilo/5
        public VoziloView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetVoziloView(id);
        }

        // POST api/vozilo
        public int Post([FromBody]Vozilo v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddVozilo(v);
        }

        // PUT api/vozilo/5
        public void Put(int id, [FromBody]Vozilo v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateVozilo(id, v);

            return;
        }

        // DELETE api/vozilo/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveVozilo(id);
        }

    }
}
