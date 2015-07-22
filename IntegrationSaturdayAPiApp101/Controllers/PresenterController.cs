using IntegrationSaturdayAPiApp101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntegrationSaturdayAPiApp101.Controllers
{
    public class PresenterController : ApiController
    {
        [HttpGet]
        public IEnumerable<Presenter> Get()
        {
            return new Presenter[]{
                new Presenter { Id = 1, EmailAddress = "bill@mexia.com.au", Name = "Bill Chesnut", Sessions = new List<string> {"What’s new on integration", "An example of continuous integration with BizTalk"}, TwiterHandle="@biztalkbill" },
                new Presenter { Id = 2, EmailAddress = "wagner.silveira@theta.co.nz", Name = "Wagner Silveira", Sessions = new List<string> {"Azure App Services – connecting the dots of web, mobile and integration"}, TwiterHandle="@wsilveiranz" },
                new Presenter { Id = 3, EmailAddress = "johannc@datacom.co.nz", Name = "Johann Cooper", Sessions = new List<string> {"API Apps, Logic Apps, and Azure API Management deep dive"}, TwiterHandle="@johanncooper" },
                new Presenter { Id = 4, EmailAddress = "craigha@datacom.co.nz", Name = "Craig Haiden", Sessions = new List<string> {"Real life SOA, Sentinet and ESB Toolkit"}, TwiterHandle="" },
                new Presenter { Id = 5, EmailAddress = "jamesc@datacom.co.nz", Name = "James Corbould", Sessions = new List<string> {"Real life SOA, Sentinet and ESB Toolkit"}, TwiterHandle="@jamescorbould" },
                new Presenter { Id = 6, EmailAddress = "mahindram@datacom.co.nz", Name = "Mahindra Morar", Sessions = new List<string> {" REST and Azure service Bus"}, TwiterHandle="@mmorarnz" },
                new Presenter { Id = 7, EmailAddress = "markbri@datacom.co.nz", Name = "Mark Brimble", Sessions = new List<string> {"What integration technology should I use?"}, TwiterHandle="@brimblemark" },
                new Presenter { Id = 8, EmailAddress = "nikolai@adaptiv.co.nz", Name = "Nikolai Blackie", Sessions = new List<string> {"Top Ten Integration Productivity Tools and Frameworks"}, TwiterHandle="@nikolaiblackie" }
            };
        }
    }
}
