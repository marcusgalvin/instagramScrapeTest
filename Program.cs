using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;


namespace happyBirthday
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-gpu");

            var chromeDriver = new ChromeDriver(options);



            //go to site
            chromeDriver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/?source=auth_switcher");
            //wait for page to load
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //login
            chromeDriver.FindElementByName("username").SendKeys("charliethegooddoge");
            chromeDriver.FindElementByName("password").SendKeys("//password//");

            //exit notifications pop up on login
            chromeDriver.FindElementByClassName("DhRcB").Click();
            chromeDriver.FindElementByClassName("HoLwm").Click();

            //search for items here
            chromeDriver.FindElementByClassName("XTCLo").SendKeys("#dogs");

            //click on hashtag you searched for
            chromeDriver.FindElementByClassName("z556c").Click();

            //click first photo
            chromeDriver.FindElementByClassName("_bz0w").Click();
            //continue to first photo user's page
            chromeDriver.FindElementByClassName("e1e1d").Click();

            //wait 5 secs
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //gather user's information and print to console
            string name = chromeDriver.FindElementByClassName("_7UhW9").Text;
            Console.WriteLine("Name: " + name);

            string posts = chromeDriver.FindElementByClassName("g47SY").Text;
            Console.WriteLine("number of posts: " + posts);

            string bio = chromeDriver.FindElementByClassName("-vDIg").Text;
            Console.WriteLine("Bio: " + bio);


            
            //string of comments to post to pictures
            string[] comments = { "adorable!", "you're so cute", "awesome pic =)", "OMG", "WOW", "you look so happy", "awwwwww, so cute" };


            // Create a Random object to generate a random comments from the string array  
            Random rand = new Random();

            int index = rand.Next(comments.Length);

            

            //click first photo on users page and comment / submit comment
            chromeDriver.FindElementByClassName("_9AhH0").Click();
                chromeDriver.FindElementByClassName("Ypffh").Click();
                chromeDriver.FindElementByClassName("Ypffh").SendKeys("@" + name + " " + comments[index]);
                chromeDriver.FindElementByClassName("Ypffh").Submit();

            




        }


    }
}
