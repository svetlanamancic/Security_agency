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
    public class SmenaController : ApiController
    {

        // GET api/smena
        public List<SmenaView> Get()
        {
            DataProvider provider = new DataProvider();

            List<SmenaView> smene = provider.GetSmene();

            return smene;
        }

        // GET api/smena/5
        public SmenaView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetSmenaView(id);
        }

        // POST api/smena
        public int Post([FromBody]Smena v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddSmena(v);
        }

        // PUT api/smena/5
        public void Put(int id, [FromBody]Smena v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateSmena(id, v);

            return;
        }

        // DELETE api/smena/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveSmena(id);
        }

    }
}
