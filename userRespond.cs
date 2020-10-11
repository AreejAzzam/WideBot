using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ApiTask
{
    public class userRespond
    {
        public string messaging_type { get; set; }
        public string type { set; get; }
        public string template_type { set; get; }
        public List<Elements> elements { set; get; }
        public userRespond()
        {
            this.messaging_type = "RESPONSE";
            this.type = "template";
            this.template_type = "generic";
            this.elements = new List<Elements>();

        }
       
           
        
        public class Elements
        {
            public Elements()
            {
                this.default_action = new DefaultAction
                {
                    type = "web_url",
                    url = "mailto:PersonMail? Subject = Hello",
                    webview_height_ratio = "tall"
                };

                this.buttons = new List<Buttons>();
                this.buttons.Add(
                    new Buttons
                    {
                        type = "web_url",
                        url = "mailto:PersonMail?Subject=Hello",
                        title = "Send Email"
                    });

            }
            public string title { get; set; }
            public string image_url { get; set; }
            public string subtitle { get; set; }
            public DefaultAction default_action { get; set; }
            public List<Buttons> buttons { get; set; }


            public class DefaultAction : baseTemplate
            {
                public string webview_height_ratio { get; set; }
            }
            public class Buttons : baseTemplate
            {
                public Buttons()
                {
                    this.type = "web_url";
                    this.url = "mailto:PersonMail?Subject=Hello";
                    this.title = "Send Email";
                }
                public string title { get; set; }
            }

        }

        public class baseTemplate
        {
            public string type { get; set; }
            public string url { get; set; }
        }

    }
}