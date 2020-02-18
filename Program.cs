using System;
using OpenQA.Selenium.Chrome;

namespace happyBirthday
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-gpu");

            var chromeDriver = new ChromeDriver(options);
            //driver.manage().timeouts().implicitlyWait()



            chromeDriver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/?source=auth_switcher");

            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //chromeDriver.FindElementByXPath("//*[@id=\"react - root\"]/section/main/article/div[2]/div[2]/p/a").Click();

            chromeDriver.FindElementByName("username").SendKeys("//username//");
            chromeDriver.FindElementByName("password").SendKeys("//password//");

            //chromeDriver.FindElementByClassName("password").SendKeys(ConsoleKey.Enter);



            chromeDriver.FindElementByClassName("DhRcB").Click();
            chromeDriver.FindElementByClassName("HoLwm").Click();

            //search bar
            chromeDriver.FindElementByClassName("XTCLo").SendKeys("healthy snack");







        }


    }
}
