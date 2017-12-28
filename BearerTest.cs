using System;
using BearerAuthentication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicHubBusiness.Business;
using MusicHubBusiness.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class BearerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string email = "danilooliveira9@hotmail.com";
            string password = "031996";

            MusicianBusiness musicianBusiness = new MusicianBusiness();

            Musician user = musicianBusiness.Login(email, password);

            BearerToken bearerLogin = new BearerToken();
            bearerLogin.GenerateHeaderToken(user.id.ToString(), user.email);
        }
    }
}
