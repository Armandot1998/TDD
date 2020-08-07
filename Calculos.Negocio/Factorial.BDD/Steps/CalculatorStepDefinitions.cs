using Calculos.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Factorial.BDD.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        private Calculadora calculadora = new Calculadora();
        int numero;
        int resultado;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("el primer número es (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            this.numero = number;
        }

        [When("hallamos el factorial del número")]
        public void WhenTheTwoNumbersAreAdded()
        {
            resultado = calculadora.Factorial(numero);
        }

        [Then("el resultado será (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(resultado, result);
        }
    }
}
