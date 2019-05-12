using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADBot.Models
{
    public class Utterance
    {
        public string text { get; set;}
        public string intentName { get; set;}
        public EntityLabel[] entityLabels { get; set; }

    }
}