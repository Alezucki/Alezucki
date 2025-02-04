using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace WpfApp1
{
    internal class Connessione
    {
        public static string PERCORSO_WEBDRIVER = "C:\\Users\\AleZu\\Downloads\\chromedriver-win64\\chromedriver-win64\\chromedriver.exe";
        public static string PERCORSO_UTENTE = @"C:\Users\AleZu\AppData\Local\Google\Chrome\User Data\Default";
        IWebDriver driver;
        public Connessione() { 
        ChromeOptions opzioni = new ChromeOptions();
        opzioni.AddArgument($"user-data-dir={PERCORSO_UTENTE}");
        driver = new ChromeDriver(PERCORSO_WEBDRIVER, opzioni);
        }
        public void VaiUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
