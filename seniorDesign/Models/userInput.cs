using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace seniorDesign.Models
{
    public class userInput
    {
        public string organization { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string streetAddress { get; set; }
        public string state { get; set; }
        public string county { get; set; }
        public string country { get; set; }
        public string services { get; set; }
        public string unique { get; set; }
        public string type { get; set; }
    }
    public class Web_ScrapperEntities: DbContext
    {
        public DbSet<userInput> Input { get; set; }

    }
}