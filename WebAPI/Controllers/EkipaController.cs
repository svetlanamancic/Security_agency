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
    public class EkipaController : ApiController
    {

        // GET api/ekipa
        public List<EkipaView> Get()
        {
            DataProvider provider = new DataProvider();

            List<EkipaView> ekipe = provider.GetEkipe();

            return ekipe;
        }

        // GET api/ekipa/5
        public EkipaView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetEkipaView(id);
        }

        // POST api/ekipa
        public int Post([FromBody]Ekipa v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddEkipa(v);
        }

        // PUT api/ekipa/5
        public void Put(int id, [FromBody]Ekipa v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateEkipa(id, v);

            return;
        }

        // DELETE api/ekipa/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveEkipa(id);
        }

    }
}
