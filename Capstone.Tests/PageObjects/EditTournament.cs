﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebApplication1.Tests.PageObjects
{
	public class EditTournament: BasePage
	{
		public EditTournament(IWebDriver driver)
			: base(driver, "/Tournaments/Edit")
		{
			PageFactory.InitElements(driver, this);
		}


		[FindsBy(How = How.Name, Using = "Start")]
		public IWebElement Start { get; set; }

		[FindsBy(How = How.Name, Using = "End")]
		public IWebElement End { get; set; }


		[FindsBy(How = How.Name, Using = "Name")]
		public IWebElement Name { get; set; }


		[FindsBy(How = How.Name, Using = "Location")]
		public IWebElement Location { get; set; }

		[FindsBy(How = How.ClassName, Using = "btn")]
		public IWebElement Submit { get; set; }

		public EditTournamentResult FillOutForm(string start, string end, string name, string location)
		{
			// Set the Principal
			Start.SendKeys(start);

			End.SendKeys(end);

			Name.SendKeys(name);

			Location.SendKeys(location);

			Submit.Click();

			return new EditTournamentResult(driver);
		}

	}
}
