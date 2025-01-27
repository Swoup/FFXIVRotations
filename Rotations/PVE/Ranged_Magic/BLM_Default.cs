namespace Rotations.PVE.Ranged_Magic;

[Rotation("Default", CombatType.PvE, GameVersion = "7.15")]
[SourceCode(Path = "main/BasicRotations/Magical/BLM_Default.cs")]
[Api(4)]
public class BLM_Default : BlackMageRotation
{
    private BlmState _currentState = BlmState.Default;

    private void UpdateBlmState(IAction lastAction)
    {
        if (IsMoving)
        {
            _currentState &= BlmState.Moving;
        }
    }
    
    protected override IAction? CountDownAction(float remainTime)
    {
        return remainTime < FireIiiPvE.Info.CastTime + CountDownAhead && FireIiiPvE.CanUse(out var act)
            ? act
            : base.CountDownAction(remainTime);
    }
    
    protected override bool DefenseSingleAbility(IAction nextGcd, out IAction? act)
    {
        return ManawardPvE.CanUse(out act) || base.DefenseSingleAbility(nextGcd, out act);
    }

    protected override bool AttackAbility(IAction nextGCD, out IAction? act)
    {
        return base.AttackAbility(nextGCD, out act);
    }

    protected override bool GeneralGCD(out IAction? act)
    {
        return base.GeneralGCD(out act);
    }

    protected override bool GeneralAbility(IAction nextGCD, out IAction? act)
    {
       return base.GeneralAbility(nextGCD, out act);
    }
}
