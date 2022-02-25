using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TrySpecFlow.StepDefinations;
using NUnit.Framework;

namespace TrySpecFlow.StepDefinations
{
    [Binding]
    public class PageStepDefinations
    {
        public static IWebDriver driver;
        [Given(@"user is on Login page")]
        public void GivenUserIsOnLoginPage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When(@"user enters username and password in the textfield")]
        public void WhenUserEntersUsernameAndPasswordInTheTextfield()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
           

        }

        [When(@"user clicks on the Login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            driver.FindElement(By.Id("login-button")).Click();
        }

        [Then(@"user is on Homepage")]
        public void ThenUserIsOnHomepage()
        {
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
        }

        [Given(@"user is on Homepage")]
        public void GivenUserIsOnHomepage()
        {
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
        }

        [When(@"user click on Side Menu button")]
        public void WhenUserClickOnSideMenuButton()
        {
            driver.FindElement(By.Id("react-burger-menu-btn")).Click();
        }

        [When(@"It displays the side menu")]
        public void WhenItDisplaysTheSideMenu()
        {
            Console.WriteLine("ji");
        }


    }
}
