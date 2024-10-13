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
    public class BrojTelefonaController : ApiController
    {

        // GET api/brojtelefona
        public List<BrojTelefonaView> Get()
        {
            DataProvider provider = new DataProvider();

            List<BrojTelefonaView> brojevi = provider.GetBrojeveTelefona();



            return brojevi;
        }

        // GET api/brojtelefona/5
        public BrojTelefonaView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetBrojTelefonaView(id);
        }

        // POST api/brojtelefona
        public int Post([FromBody]BrojTelefona v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddBrojTelefona(v);
        }

        // PUT api/brojtelefona/5
        public void Put(int id, [FromBody]BrojTelefona v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateBrojTelefona(id, v);

            return;
        }

        // DELETE api/brojtelefona/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveBrojTelefona(id);
        }

    }
}
