using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicHubBusiness.Business;
using MusicHubBusiness.Models;

namespace MusicHubTest
{
    [TestClass]
    public class MusicianTest: BaseTest
    {
        [TestMethod]
        public void Musician_Create()
        {
            MusicianBusiness musicianBusiness = new MusicianBusiness();
            Musician musician = new Musician
            {
                name = faker.Person.FullName,
                email = faker.Person.Email.ToLower(),
                password = faker.Internet.Password(),
                birth_date = faker.Date.Between(new DateTime(1925, 1, 1), new DateTime(1997, 12, 31))
            };

            var retorno = musicianBusiness.Create(musician);

            bool ok = retorno.id > 0;

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void Musician_SearchByName()
        {
            MusicianBusiness musicianBusiness = new MusicianBusiness();
            var musicians = musicianBusiness.SearchByName("Julia");

            bool ok = musicians.Count() > 0;

            Assert.IsTrue(ok);
        }
    }
}
