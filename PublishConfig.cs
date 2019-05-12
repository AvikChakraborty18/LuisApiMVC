using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADBot.Models
{
    public class PublishConfig
    {
        public readonly string versionId; 
        public readonly Boolean isStaging;
        public PublishConfig()
        {
            this.versionId = "0.2";
            this.isStaging = false;
        }

    }
}