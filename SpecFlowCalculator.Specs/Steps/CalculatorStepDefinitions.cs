using FluentAssertions;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Calculator _calculator = new Calculator();
        private readonly ScenarioContext _scenarioContext;
        private int _result;
        private List<int> _inputsNumbers;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _inputsNumbers = new List<int>();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.SubstractTwoNumbers();
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.MultiplyTwoNumbers();
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = _calculator.DivideTwoNumbers();
        }

        [When(@"the two numbers are divided \(with a Zero\)")]
        public void WhenTheTwoNumbersAreDividedWithAZero()
        {
            _result = _calculator.DivideTwoNumbers();
        }



        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            _result = _calculator.AddTwoNumbers();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }



        [Given(@"the following numbers")]
        public void GivenTheFollowingNumbers(Table table)
        {
            foreach(TableRow row in table.Rows)
            {
                string nom = row[0];
                int value = int.Parse(row[0]);
                this._inputsNumbers.Add(value);
            }
        }

        [When(@"numbers are added")]
        public void WhenNumbersAreAdded()
        {
            this._result = _calculator.Add(_inputsNumbers);
        }

        [When(@"numbers are substracted")]
        public void WhenNumbersAreSubstracted()
        {
            this._result = _calculator.Substract(_inputsNumbers);
        }


        [When(@"numbers are multiplied")]
        public void WhenNumbersAreMultiplied()
        {
            this._result = _calculator.Multiply(_inputsNumbers);
        }

        [When(@"numbers are divided")]
        public void WhenNumbersAreDivided()
        {
            this._result = _calculator.Divide(_inputsNumbers);
        }


    }
}
