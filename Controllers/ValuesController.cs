using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;


namespace ApiTask.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
    
        public ActionResult<mappingFBRespond> Get()
        {
            var users = ReadData();
            var FacebookResponse = PrepareResponse(users);
            return (FacebookResponse);
        }
        private userData ReadData()
        {
            // download data from regres api  "https://reqres.in/api/users"
            var webClient = new WebClient();
            var jsonData = string.Empty;
            jsonData = webClient.DownloadString($"https://reqres.in/api/users");
            JObject json = JObject.Parse(jsonData);
            //response mapping data
            var test = json.ToObject<userData>();
            return test;
        }
        public class mappingFBRespond
        {
            public userRespond FacebookResponse { get; set; }
        }
        private mappingFBRespond PrepareResponse(userData user)
        {
            var mappedData = new userRespond();
            for (int i = 0; i < user.data.Count; i++)
            {
                mappedData.elements.Add
              (new userRespond.Elements());
                mappedData.elements[i].title =
                    user.data[i].first_name;
                mappedData.elements[i].image_url =
                    user.data[i].avatar;
                mappedData.elements[i].subtitle =
                    user.data[i].last_name;
            }
            var mappedResonse = new mappingFBRespond() { FacebookResponse = mappedData };
            return mappedResonse;
        }
        // GET api/values/5
        public string Get(int id)
        {
            string name = "Areej " + id;
            return name;
        }

        // POST api/values
        public void Post(string value)
        {
        }

        // PUT api/values/5
        public void Put(int id,string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }



      

      
       
    }
}
