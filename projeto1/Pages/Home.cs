using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto1.Pages
{
   public class Home
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        
        public Home(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
        }
        public void pageInit(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
        private IWebElement insertValues(By tag)
        {
            
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(tag));
            return driver.FindElement(tag);
        }
        private IWebElement insertValuesBox(By tag)
        {
            IWebElement box = insertValues(tag);
            Boolean isCheckBox= box.Selected;
            if (isCheckBox == false)
            {
                return box;
            }
            return null;
        }
        private SelectElement insertSelect(By tag)
        {
            SelectElement oSelect = new SelectElement(insertValues(tag));
            return oSelect;
        }
        private void muiltSelect()
        {

            insertValues(By.XPath("/html/body/section/div/div/div[2]/form/div[7]/div/multi-select/div[1]")).Click();
            insertValues(By.LinkText("Italian")).Click();
            insertValues(By.LinkText("Arabic")).Click();
            insertValues(By.XPath("/html/body/section/div/div/div[2]/form/div[7]/div/multi-select/div[1]/div/span")).Click();
            
        }
        private void uploadImage(By tag, string path)
        {
            IWebElement tagImage= insertValues(tag);
            Actions actions = new Actions(driver);
            actions = actions.MoveToElement(tagImage);
            actions = actions.Click();
            actions.Build().Perform();
            SendKeys.SendWait(path);
            SendKeys.SendWait("{Enter}");
            
        }
        private void screenshot()
        {
            ITakesScreenshot camera = driver as ITakesScreenshot;
            Screenshot screenshot = camera.GetScreenshot();
            screenshot.SaveAsFile($"{Guid.NewGuid()}.png");
        }
        
        public void registerDiceRequired()
        {

            insertValues(By.XPath("/html/body/section/div/div/div[2]/form/div[1]/div[1]/input")).SendKeys("matheus");
            insertValues(By.XPath("/html/body/section/div/div/div[2]/form/div[1]/div[2]/input")).SendKeys("quirino");
            insertValues(By.XPath("/html/body/section/div/div/div[2]/form/div[2]/div/textarea")).SendKeys("text asdsadk hasdhasd");
            insertValues(By.XPath("/html/body/section/div/div/div[2]/form/div[3]/div[1]/input")).SendKeys("joa@gmail.com");
            insertValues(By.XPath("/html/body/section/div/div/div[2]/form/div[4]/div/input")).SendKeys("1192513225");

            insertValues(By.XPath("/html/body/section/div/div/div[2]/form/div[5]/div/label[2]/input")).Click();
           
            insertSelect(By.XPath("/html/body/section/div/div/div[2]/form/div[8]/div/select")).SelectByValue("Adobe InDesign");
            insertSelect(By.XPath("/html/body/section/div/div/div[2]/form/div[9]/div/select")).SelectByValue("Afghanistan");

            muiltSelect();

            insertValuesBox(By.XPath("/html/body/section/div/div/div[2]/form/div[6]/div/div[1]/input")).Click();
            insertValues(By.XPath("/html/body/section/div/div/div[2]/form/div[10]/div/span/span[1]/span")).Click() ;
            insertValues(By.XPath("/html/body/span/span/span[1]/input")).SendKeys("Australia" + OpenQA.Selenium.Keys.Enter);

            insertSelect(By.XPath("/html/body/section/div/div/div[2]/form/div[11]/div[1]/select")).SelectByValue("1980");
            insertSelect(By.XPath("/html/body/section/div/div/div[2]/form/div[11]/div[2]/select")).SelectByValue("April");
            insertSelect(By.XPath("/html/body/section/div/div/div[2]/form/div[11]/div[3]/select")).SelectByValue("5");
            
            insertValues(By.XPath("/html/body/section/div/div/div[2]/form/div[12]/div/input")).SendKeys("Quin102030");
            insertValues(By.XPath("/html/body/section/div/div/div[2]/form/div[13]/div/input")).SendKeys("Quin102030");
            uploadImage(By.XPath("/html/body/section/div/div/div[3]/div[2]/input"), "C:\\Users\\mathe\\Desktop\\fot.jpg");
            screenshot();
           
            

        }
        public void Send()
        {
            insertValues(By.XPath("/html/body/section/div/div/div[2]/form/div[14]/div/button[1]")).Submit();
            insertValues(By.XPath("/html/body/section/div/div/div[2]/form/div[14]/div/button[2]")).Click();
        }
    }
}
