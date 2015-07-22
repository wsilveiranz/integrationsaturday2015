using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationSaturdayAPiApp101.Models
{
    public class Presenter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public List<string> Sessions { get; set; }
        public string TwiterHandle { get; set; }
    }
}