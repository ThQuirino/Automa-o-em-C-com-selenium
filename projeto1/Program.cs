using OpenQA.Selenium;
using projeto1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    class Program
    {
        const string url = "http://demo.automationtesting.in/Register.html";
        public static IWebDriver driver;
        public static Home home;
        static void Main(string[] args)
        {

            initCall();
            register();
           
        }
        public static void initCall()
        {
            
            driver=Util.Util.Init();
            home = new Home(driver);
            home.pageInit(url);
        }
        public static void register()
        {
            home.registerDiceRequired();
            home.Send();
            Util.Util.final(driver);
        }
       
    }
}
