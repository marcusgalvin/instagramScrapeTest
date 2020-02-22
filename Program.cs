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
            chromeDriver.FindElementByName("password").SendKeys("magnetpaper");

            //exit notifications pop up on login
            chromeDriver.FindElementByClassName("DhRcB").Click();
            chromeDriver.FindElementByClassName("HoLwm").Click();

            //search for items here
            chromeDriver.FindElementByClassName("XTCLo").SendKeys("#dog");

            //click on hashtag you searched for
            chromeDriver.FindElementByClassName("z556c").Click();

            //click first photo
            chromeDriver.FindElementByClassName("_bz0w").Click();
            //continue to first photo user's page
            chromeDriver.FindElementByClassName("e1e1d").Click();

            //wait 5 secs
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);



            //insta bios
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




            //loop through photos under the hastag you specify after 1st one is clicked
            for (var i = 0; i < 15; i++)
            {

                // Create a Random object to generate a random comments from the string array, will add loop  
                Random randOne = new Random();

                int indexOne = rand.Next(comments.Length);

                //click next picture 
                chromeDriver.FindElementByClassName("_65Bje").Click();
                //click in comment box
                chromeDriver.FindElementByClassName("Ypffh").Click();
                //send comment
                chromeDriver.FindElementByClassName("Ypffh").SendKeys("@" + name + " " + comments[indexOne]);
                //wait for page to load
                //chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000000000);
                System.Threading.Thread.Sleep(5000);
                //push button to post
                chromeDriver.FindElementByClassName("Ypffh").Submit();
                //wait for page to load
                System.Threading.Thread.Sleep(1000);
                //chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000000000);

            }
            



        }


    }
}