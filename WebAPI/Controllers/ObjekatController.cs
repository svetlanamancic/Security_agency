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
    public class ObjekatController : ApiController
    {

        // GET api/objekat
        public List<ObjekatView> Get()
        {
            DataProvider provider = new DataProvider();

            List<ObjekatView> objekti = provider.GetObjekte();

            return objekti;
        }

        // GET api/objekat/5
        public ObjekatView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetObjekatView(id);
        }

        // POST api/objekat
        public int Post([FromBody]Objekat v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddObjekat(v);
        }

        // PUT api/objekat/5
        public void Put(int id, [FromBody]Objekat v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateObjekat(id, v);

            return;
        }

        // DELETE api/objekat/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveObjekat(id);
        }

    }
}
