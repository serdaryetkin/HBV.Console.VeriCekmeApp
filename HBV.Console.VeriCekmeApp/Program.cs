using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace HBV.Console.VeriCekmeApp
{
    class Program
    {
        static void Main(string[] args)
        {
          

            //Nesne türettik
            IWebDriver driver = new ChromeDriver();

            //Alacağımız içeriğin urlsini getirdik
            driver.Navigate().GoToUrl("https://www.kariyer.net/is-ilanlari");

            //Sağ tık yapıp incele diyerek ilgili divin xpath'ini kopyaladık, tırnaklar ve dizileri dikkat
            IReadOnlyCollection<IWebElement> title = driver.FindElements(By.XPath("//*[@id=\"ilan0\"]/div/div/p/a"));


            //Linktext'e göre sayfayı açacak.
            //IWebElement page = driver.FindElement(By.ClassName("jobTitleLnk"));
            //page.Click();


        }
    }
}
