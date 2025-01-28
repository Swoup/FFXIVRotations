using Rotations.PVE.Ranged_Magic;
using RotationSolver.Basic.Actions;
using RotationSolver.Basic.Data;
using TechTalk.SpecFlow;

namespace Rotations.Tests.PVE.Ranged_Magic;

[Binding]
public sealed class BlackMageStepDefinitions
{
    private BlmState _blmState = BlmState.Default;
    private const BlmState NoStance = ~BlmState.AstralFire1 & ~BlmState.AstralFire2 & ~BlmState.AstralFire3 & ~BlmState.UmbralIce1 & ~BlmState.UmbralIce2 & ~BlmState.UmbralIce3;

    #region Argument transformation steps

    [StepArgumentTransformation]
    public static IBaseAction ParseTextToAction(string text)
    {
        return text switch
        {
            "Blizzard"       => new BaseAction(ActionID.BlizzardPvE),
            "BlizzardII"     =>	new BaseAction(ActionID.BlizzardIiPvE),
            "BlizzardIII"    =>	new BaseAction(ActionID.BlizzardIiiPvE),
            "BlizzardIV"     =>	new BaseAction(ActionID.BlizzardIvPvE),
            "Fire"           =>	new BaseAction(ActionID.FirePvE),
            "FireII"         =>	new BaseAction(ActionID.FireIiPvE),
            "FireIII"        =>	new BaseAction(ActionID.FireIiiPvE),
            "FireIV"         =>	new BaseAction(ActionID.FireIvPvE),
            "HighThunder"    => new BaseAction(ActionID.HighThunderPvE),
            "HighThunderII"  => new BaseAction(ActionID.HighThunderIiPvE),
            "Scathe"         => new BaseAction(ActionID.ScathePvE),
            "HighFireII"     => new BaseAction(ActionID.HighFireIiPvE),
            "HighBlizzardII" => new BaseAction(ActionID.HighBlizzardIiPvE),
            "Flare"          => new BaseAction(ActionID.FlarePvE),
            "Freeze"         => new BaseAction(ActionID.FreezePvE),
            "Despair"        => new BaseAction(ActionID.DespairPvE),
            "Xenoglossy"     => new BaseAction(ActionID.XenoglossyPvE),
            "Foul"           => new BaseAction(ActionID.FoulPvE),
            "FlareStar"      => new BaseAction(ActionID.FlareStarPvE),
            "Transpose"      => new BaseAction(ActionID.TransposePvE),
            "Amplifier"      => new BaseAction(ActionID.AmplifierPvE),
            "Manafont"       => new BaseAction(ActionID.ManafontPvE),
            "LucidDreaming"  => new BaseAction(ActionID.LucidDreamingPvE),
            _                => new BaseAction(ActionID.None)
        };
    }
    

    #endregion

    #region Before scenarii

    [BeforeScenario]
    public void BeforeScenario()
    {
        _blmState = BlmState.Default;
    }

    #endregion
    
    #region Arrange steps

    [Given("that I am not moving")]
    public void GivenThatIAmNotMoving()
    {
        _blmState &= BlmState.Moving;
    }

    [Given("that I have no astral fire or umbral ice")]
    public void GivenThatIHaveNoAstralFireOrUmbralIce()
    {
        _blmState &= NoStance;
    }

    [Given("I have more than 800 mana")]
    public void GivenIHaveMoreThanMana()
    {
        _blmState &= BlmState.AtLeastEightHundredMana;
    }
    
    # endregion
    
    #region Act steps

    [When("I want to pick a GCD")]
    public void WhenIWantToPickAgcd()
    {
        ScenarioContext.StepIsPending();
    }
    
    [When("I want to pick a oGCD")]
    public void WhenIWantToPickAogcd()
    {
        ScenarioContext.StepIsPending();
    }
    
    #endregion
    
    #region Assert steps

    [Then("the choice is (.*)")]
    public void ThenTheChoiceIs(IBaseAction action)
    {
        ScenarioContext.StepIsPending();
    }
    
    #endregion
}