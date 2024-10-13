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
    public class ToplotniOdrazController : ApiController
    {

        // GET api/toplotniodraz
        public List<ToplotniOdrazView> Get()
        {
            DataProvider provider = new DataProvider();

            List<ToplotniOdrazView> alarm = provider.GetToplotneOdraze();

            return alarm;
        }

        // GET api/toplotniodraz/5
        public ToplotniOdrazView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetToplotniOdrazView(id);
        }

        // POST api/toplotniodraz
        public int Post([FromBody]ToplotniOdraz v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddToplotniOdraz(v);
        }

        // PUT api/toplotniodraz/5
        public void Put(int id, [FromBody]ToplotniOdraz v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateToplotniOdraz(id, v);

            return;
        }

        // DELETE api/toplotniodraz/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveToplotniOdraz(id);
        }

    }
}
