using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuscaminasBDD.Steps
{
    [Binding]
    public class EmpezarJuegoSteps
    {
        IWebDriver webDriver = new ChromeDriver(@"C:\Users\arman\source\repos\MinasBDD\SofwareTerceros");

        [Given(@"click en jugar")]
        public void DadoClickEnJugar()
        {
            webDriver.Url = "http://localhost/MinasTDD/";
            webDriver.Navigate();
            var boton = webDriver.FindElement(By.Name("Jugar"));
            boton.Click();
        }
        
        [When(@"el juego solicita ingresar su nickname **(.*)**")]
        public void CuandoElJuegoInicializa(string nickname)
        {
            webDriver.Url = "http://localhost/MinasTDD/?c=Jugador&a=Crud";
            webDriver.Navigate();
            var element = webDriver.FindElement(By.Name("username"));
        }
        
        [Then(@"nos pide nuestro nickname")]
        public void EntoncesNosPideNuestroNickname()
        {
            Assert.IsTrue(false);
        }
    }
}
