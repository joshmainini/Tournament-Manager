using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebApplication1.Tests.PageObjects;

namespace WebApplication1.Tests.SeleniumTests
{
	[TestClass]
	public class AccountTests
	{
		private static IWebDriver driver;

		[ClassInitialize]
		public static void SetUp(TestContext context)
		{
			driver = new ChromeDriver();
			driver.Navigate().GoToUrl("http://localhost:55393/");
		}

		[ClassCleanup]
		public static void Cleanup()
		{
			driver.Close();
			driver.Quit();
		}

		[TestMethod]
		public void Register_GoToHome()
		{
			Register entryPage = new Register(driver);
			entryPage.Navigate();

			RegisterResult result = entryPage.FillOutForm("jellymo@jellymo.com", "Jellymo2", "Jellymo2");

			Assert.AreEqual("Hello jellymo@jellymo.com!", result.Success.Text);
		}
	}
}
