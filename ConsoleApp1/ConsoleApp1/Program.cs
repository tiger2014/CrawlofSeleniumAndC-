using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            /*
             * 详见:
             * https://www.cnblogs.com/zhaotianff/p/11330810.html
             * https://juejin.im/entry/5b863bd2f265da437a46a240
             * https://www.jianshu.com/p/97cc1e5434e9   等待时间
             * GetAttribute get values of attribute : https://chercher.tech/java/get-text-css-attribute-size-value-selenium-webdriver
             * CssSelector 语法: https://www.w3school.com.cn/cssref/css_selectors.asp
            */

            using (var driver = new ChromeDriver())
            {

                GetshortenUrl.Get(driver);
                //driver.Navigate().GoToUrl("http://www.baidu.com");  //driver.Url = "http://www.baidu.com"是一样的
                driver.Url = "https://www.baidu.com";
                var input = driver.FindElement(By.Id("kw"));
                // 在输入前清空内容
                input.Clear();
                input.SendKeys("Selenium");
                var submit = driver.FindElement(By.Id("su"));
                submit.Click();
                var source = driver.PageSource;
                //关闭浏览器
                driver.Close();
                Console.WriteLine(source);
                Console.ReadLine();
            }
        }
    }
}