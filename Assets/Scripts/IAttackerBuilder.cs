/// <summary>
/// 2024.1.1
/// </summary>

// Builder interface
public interface IAttackerBuilder
{
    void BuildCharacterName();
    void BuildSpeed();
    void BuildHitsPoints();
    void BuildDestroyedTime();
    AttackerCharacter GetAttackerCharacter();
}

