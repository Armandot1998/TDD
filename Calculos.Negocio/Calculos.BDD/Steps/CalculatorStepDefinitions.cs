using Calculos.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Calculos.BDD.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        private Calculadora calculadora = new Calculadora();
        private int resultado;
        private int primerN;
        private int segundoN;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("el primer número es (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //calculator.primerNumero = number;
            this.primerN = number;
        }

        [Given("el segundo número es (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //calculator.segundoNumero = number;
            this.segundoN = number;
        }

        [When("se suman los dos números")]
        public void WhenTheTwoNumbersAreAdded()
        {
            resultado = calculadora.Suma(primerN, segundoN);
        }

        [Then("el resultado debería ser (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(resultado, result);
        }
    }
}