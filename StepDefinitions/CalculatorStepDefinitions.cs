using CalculatorLib;
using System.Globalization;

namespace SpecFlowProjectDay1Assignment.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly ScenarioContext scenarioContext;
        private readonly Calculator calc;
        private int result;
        public CalculatorStepDefinitions(ScenarioContext scenarioContext, Calendar calc, int result)
        {
            this.scenarioContext = scenarioContext;
            this.calc = new Calculator();
            this.result = result;
        }
        

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            calc.fnum=number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            calc.snum=number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            result = calc.Addition();
            result = calc.Substract();
            result = calc.Divide();
            result = calc.Multiplication();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            result.Should().Be(result);
        }
    }
}
