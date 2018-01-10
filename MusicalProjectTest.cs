using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MusicHubBusiness.Business;
using MusicHubBusiness.Models;
using MusicHubTest;
using System.IO;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class MusicalProjectTest : BaseTest
    {
        //[TestMethod]
        //public void MusicalProject_Create()
        //{
        //    Login();

        //    MockRepository mocks = new MockRepository(MockBehavior.Default);
        //    var basket = mocks.Set Create<FileStream>();

        //    var stream = basket.Object;

        //    MusicalGenreBusiness musicalGenreBusiness = new MusicalGenreBusiness();
        //    var musical_genre = musicalGenreBusiness.GetAll().First();

        //    MusicalProjectBusiness musicalProjectBusiness = new MusicalProjectBusiness();
        //    MusicalProject musicalProject = new MusicalProject
        //    {
        //        name = faker.Lorem.Sentence(15),
        //        musical_genre_id = musical_genre.id,
        //        owner_id = loggedUser.id
        //    };

        //    musicalProjectBusiness.Create(musicalProject, stream);
        //}
    }
}