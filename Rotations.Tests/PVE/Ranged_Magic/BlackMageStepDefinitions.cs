using TechTalk.SpecFlow;

namespace Rotations.Tests.PVE.Ranged_Magic;

[Binding]
public sealed class BlackMageStepDefinitions(ScenarioContext scenarioContext)
{
    private readonly ScenarioContext _scenarioContext = scenarioContext;

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
    
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int number)
    {
        
    }
}