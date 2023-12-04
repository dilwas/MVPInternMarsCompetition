using MVPInternMarsCompetition.Pages;
using MVPInternMarsCompetition.Utilities;
using NUnit.Framework;

namespace MVPInternMarsCompetition.Tests
{
    [TestFixture]
    public class Tests : Driver
    {
        [SetUp]
        public void Setup()
        {
            Initialize();
            NavigateUrl();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.SigninStep();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            Close();
        }
    }
}