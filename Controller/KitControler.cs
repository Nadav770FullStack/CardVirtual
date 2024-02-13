using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;


namespace CardVirtual.Controller
{
    public class KitControler : ApiController
    {
        // GET: api/Kit
        public List<Kit> Get()
        {
            return Kit.Get();
        }

        // GET: api/Kit/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Kit
        public void Post([FromBody] MultipartFormDataContent value)
        {

        }

        // PUT: api/Kit/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Kit/5
        public void Delete(int id)
        {
        }
    }
}