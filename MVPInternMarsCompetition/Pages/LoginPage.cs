using MVPInternMarsCompetition.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPInternMarsCompetition.Pages
{
    public class LoginPage : Driver
    {
        public IWebElement SignInBtn => driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        public IWebElement Email => driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        public IWebElement Password => driver.FindElement(By.XPath("//INPUT[@type='password']"));
        public IWebElement LoginBtn => driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));

        public void SigninStep()
        {
            SignInBtn.Click();
            Email.SendKeys("dilhaniwas+1@gmail.com");
            Password.SendKeys("123456");
            LoginBtn.Click();
        }
    }
}
