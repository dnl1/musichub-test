using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHubTest
{
    public class BaseTest
    {
        public Faker faker { get; set; }

        public BaseTest()
        {
            this.faker = new Faker("pt_BR");
        }
    }
}
