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
    public class FizickoObezbedjenjeController : ApiController
    {

        // GET api/fizickoobezbedjenje
        public List<FizickoObezbedjenjeView> Get()
        {
            DataProvider provider = new DataProvider();

            List<FizickoObezbedjenjeView> fiz = provider.GetFizickaObezbedjenja();



            return fiz;
        }

        // GET api/fizickoobezbedjenje/5
        public FizickoObezbedjenjeView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetFizickoObezbedjenjeView(id);
        }

        // POST api/fizickoobezbedjenje
        public int Post([FromBody]FizickoObezbedjenje v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddFizickoObezbedjenje(v);
        }

        // PUT api/fizickoobezbedjenej/5
        public void Put(int id, [FromBody]FizickoObezbedjenje v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateFizickoObezbedjenje(id, v);

            return;
        }

        // DELETE api/fizickoobezbedjenje/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveFizickoObezbedjenje(id);
        }

    }
}
