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
    public class KontaktTelefonController : ApiController
    {

        // GET api/kontakttelefon
        public List<KontaktTelefonView> Get()
        {
            DataProvider provider = new DataProvider();

            List<KontaktTelefonView> telefoni = provider.GetKontaktTelefone();



            return telefoni;
        }

        // GET api/kontakttelefon/5
        public KontaktTelefonView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetKontaktTelefonView(id);
        }

        // POST api/kontakttelefon
        public int Post([FromBody]KontaktTelefon v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddKontaktTelefon(v);
        }

        // PUT api/kontakttelefon/5
        public void Put(int id, [FromBody]KontaktTelefon v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateKontaktTelefon(id, v);

            return;
        }

        // DELETE api/kontakttelefon/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveKontaktTelefon(id);
        }

    }
}
