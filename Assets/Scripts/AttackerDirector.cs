/// <summary>
/// 2024.1.1
/// </summary>

public class AttackerDirector 
{
    private IAttackerBuilder attackerBuilder;

    public void SetPlayerBuilder(IAttackerBuilder builder) => attackerBuilder = builder;

    public AttackerCharacter ConstructAttackerCharacter()
    {
        attackerBuilder.BuildCharacterName();
        attackerBuilder.BuildSpeed();
        attackerBuilder.BuildHitsPoints();
        attackerBuilder.BuildDestroyedTime();
        return attackerBuilder.GetAttackerCharacter();
    }
}
