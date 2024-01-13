using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2024.1.7
/// </summary>

public class FastAttackerBuilder : IAttackerBuilder
{
    private AttackerCharacter attackerCharacter = new AttackerCharacter();

    public void BuildCharacterName() => attackerCharacter.attackerInfo.attackerName = attackerCharacter.attackerInfo.name;
    public void BuildSpeed() => attackerCharacter.attackerInfo.speed = attackerCharacter.attackerInfo.speed * 2;
    public void BuildHitsPoints() => attackerCharacter.attackerInfo.hitPoints = attackerCharacter.attackerInfo.hitPoints;
    public void BuildDestroyedTime() => attackerCharacter.attackerInfo.timeToDestroy = attackerCharacter.attackerInfo.timeToDestroy;

    public AttackerCharacter GetAttackerCharacter() => attackerCharacter;
}
