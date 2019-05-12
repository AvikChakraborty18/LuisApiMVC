using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADBot.Models
{
    public class EntityLabel
    {
        public string entityName { get; set; }
        public int startCharIndex { get; set; }
        public int endCharIndex { get; set; }
    }
}