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
    public class StrucnaSpremaController : ApiController
    {

        // GET api/strucnasprema
        public List<StrucnaSpremaView> Get()
        {
            DataProvider provider = new DataProvider();

            List<StrucnaSpremaView> ss = provider.GetStrucneSpreme();



            return ss;
        }

        // GET api/strucnasprema/5
        public StrucnaSpremaView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetStrucnaSpremaView(id);
        }

        // POST api/strucnasprema
        public int Post([FromBody]StrucnaSprema v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddStrucnaSprema(v);
        }

        // PUT api/strucnasprema/5
        public void Put(int id, [FromBody]StrucnaSprema v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateStrucnaSprema(id, v);

            return;
        }

        // DELETE api/strucnasprema/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveStrucnaSprema(id);
        }

    }
}
