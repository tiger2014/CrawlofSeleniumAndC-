using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace ConsoleApp1
{
    public static class GetshortenUrl
    {
        public static void Get(ChromeDriver driver)
        {
            //var driver = new ChromeDriver();
            for (int i = 0; i < 11; i++)
            {
                var tempstr = Guid.NewGuid().ToString().Replace("-", "");
                tempstr = tempstr.Substring(tempstr.Length / 2);
                string longurl = "https://github.com/begood0513/goodnews/blob/master/README.md?" + tempstr;

                //is.gd
                driver.Url = "https://is.gd/";
                var input = driver.FindElement(By.Name("url"));
                input.Clear();
                input.SendKeys(longurl);
                driver.FindElement(By.ClassName("submitbutton")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);     //等待10s
                //var shortenurl = driver.FindElement(By.Id("short_url")).GetCssValue("value");
                var shortenurl = driver.FindElement(By.Id("short_url")).GetAttribute("value");      //GetAttribute get values of attribute : https://chercher.tech/java/get-text-css-attribute-size-value-selenium-webdriver
                Console.WriteLine(shortenurl);


                //tinyurl.com 有广告
                //driver.Navigate().GoToUrl("https://tinyurl.com/");
                //input = driver.FindElement(By.Id("url"));
                //input.Clear();
                //input.SendKeys(longurl);
                //string cssselector= "#f>input[type="+"submit"+"]";      //CssSelector: https://www.w3school.com.cn/cssref/css_selectors.asp
                //driver.FindElement(By.CssSelector(cssselector)).Click();
                //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);     //等待10s
                //shortenurl = "";
                //shortenurl =driver.FindElement(By.Id("copy_div")).GetAttribute("href");
                //Console.WriteLine(shortenurl);

                //https://bitly.com/
                //driver.Navigate().GoToUrl("https://bitly.com/");
                //input = driver.FindElement(By.Id("shorten_url"));
                //input.Clear();
                //input.SendKeys(longurl);
                //driver.FindElement(By.Id("shorten_btn")).Click();
                //Thread.Sleep(10000);
                ////driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);     //等待10s
                //shortenurl = "";
                //var result = driver.FindElement(By.Id("shortened_url"));
                //Console.WriteLine(shortenurl);

                //https://www.shorturl.at/
                driver.Navigate().GoToUrl("https://www.shorturl.at/");
                input = driver.FindElement(By.Name("u"));
                input.Clear();
                input.SendKeys(longurl);
                string cssselector = "#formbutton>input[type=" + "submit" + "]";
                driver.FindElement(By.CssSelector(cssselector)).Click();
                //Thread.Sleep(10000);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);     //等待10s
                shortenurl = "";
                shortenurl = driver.FindElement(By.Id("shortenurl")).GetAttribute("value");
                Console.WriteLine(shortenurl);

                //https://www.rebrandly.com/    有防护
                //driver.Navigate().GoToUrl("https://www.rebrandly.com/");
                //input = driver.FindElement(By.Name("url"));
                //input.Clear();
                //input.SendKeys(longurl);
                //cssselector = "#wf-form-rebrand-link-form>input[value=" + "Shorten" + "]";
                //driver.FindElement(By.CssSelector(cssselector)).Click();
                ////Thread.Sleep(10000);
                //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);     //等待10s
                //shortenurl = "";
                //shortenurl = driver.FindElement(By.Id("shorten-2")).GetAttribute("value");
                //Console.WriteLine(shortenurl);


            }
            driver.Close();
        }
    }
}