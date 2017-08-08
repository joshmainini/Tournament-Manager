using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebApplication1.Tests.PageObjects
{
	class CreateTeam: BasePage
	{

		public CreateTeam(IWebDriver driver)
			: base(driver, "/Teams/Create")
		{
			PageFactory.InitElements(driver, this);
		}


	}
}
