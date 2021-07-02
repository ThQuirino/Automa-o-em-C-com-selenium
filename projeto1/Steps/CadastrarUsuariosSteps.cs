using OpenQA.Selenium;
using projeto1.Pages;
using System;
using TechTalk.SpecFlow;

namespace projeto1.Steps
{
    [Binding]
    public class CadastrarUsuariosSteps
    {
        string url = "http://demo.automationtesting.in/Register.html";
        IWebDriver driver;
        Home home;
        [Given(@"eu entro no site de registro")]
        public void DadoEuEntroNoSiteDeRegistro()
        {
            driver=Util.Util.Init();
        }
        
        [When(@"insiro os valores nos campos obrigatórios")]
        public void QuandoInsiroOsValoresNosCamposObrigatorios()
        {
            home = new Home(driver);
            home.pageInit(url);
            home.registerDiceRequired();
        }
        
        [Then(@"os dados são enviados")]
        public void EntaoOsDadosSaoEnviados()
        {
            home.Send();
            Util.Util.final(driver);
        }
    }
}
