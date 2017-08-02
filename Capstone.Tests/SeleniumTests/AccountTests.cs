using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebApplication1.Tests.PageObjects;
using WebApplication1.DAL;

namespace WebApplication1.Tests.SeleniumTests
{
	[TestClass]
	public class AccountTests
	{
		UserDAL dal = new UserDAL(@"Data Source=localhost\sqlexpress;Initial Catalog=Slime;Integrated Security=True");
		private static IWebDriver driver;

		
		[ClassInitialize]
		public static void SetUp(TestContext context)
		{
			driver = new ChromeDriver();
			driver.Navigate().GoToUrl("http://localhost:55393/");
		}

		[ClassCleanup]
		public static void CleanupDriver()
		{
			driver.Close();
			driver.Quit();
		}

		[TestMethod]
		public void Register_GoToHome()
		{
			Register entryPage = new Register(driver);
			entryPage.Navigate();

			RegisterResult result = entryPage.FillOutForm("jellymo@jellymo.com", "Jellymo2@", "Jellymo2@");

			Assert.AreEqual("Hello jellymo@jellymo.com!", result.Success.Text);
		}

		[TestMethod]
		public void Login_GoToHome()
		{
			Login entryPage = new Login(driver);
			entryPage.Navigate();

			LoginResult result = entryPage.FillOutForm("jellymo@jellymo.com", "Jellymo2@");

			Assert.AreEqual("Hello jellymo@jellymo.com!", result.Success.Text);
			dal.DeleteUser("jellymo@jellymo.com");
		}
	}
}
