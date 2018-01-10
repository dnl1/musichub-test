using Bogus;
using MusicHubBusiness.Business;
using MusicHubBusiness.Models;
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
        public Musician loggedUser { get; set; }

        public BaseTest()
        {
            this.faker = new Faker("pt_BR");
        }

        public void Login()
        {
            string name = "Teste User", email = "teste.user@musichub.com", password = "#Danil123";

            MusicianBusiness musicianBusiness = new MusicianBusiness();
            Musician musician = musicianBusiness.Login(email, password);

            if(musician == null)
            {
                musician = new Musician
                {
                    name = name,
                    email = email,
                    password = password
                };

                musician = musicianBusiness.Create(musician);
            }

            loggedUser = musician;
        }
    }
}
