using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using secdev_mvc;
using secdev_mvc.Controllers;
using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace secdev_mvc.tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        public TestContext TestContext { get; set; }

        [TestMethod]
        [AspNetDevelopmentServer("DEMO", "secdev-mvc")]
        public async Task InvalidateSessionAfterLogoutTest()
        {
            var url = (Uri)TestContext.Properties[$"{TestContext.AspNetDevelopmentServerPrefix}DEMO"];
            Console.WriteLine($"Uri: {url}");

            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);
                Console.WriteLine(response);
            }
        }
    }
}
