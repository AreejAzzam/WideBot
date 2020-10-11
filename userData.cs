using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ApiTask
{
    public class userData
    {
        public List<userdata> data { get; set; }

        public class userdata
        {
           
            [Required]
            public string first_name { get; set; }
            [Required]
            public string last_name { get; set; }
            [Required]
            public string avatar { get; set; }
         
        }
     
       
    }
}