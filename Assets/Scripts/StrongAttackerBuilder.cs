using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongAttackerBuilder : IAttackerBuilder
{
    private AttackerCharacter attackerCharacter = new AttackerCharacter();

    public void BuildCharacterName() => attackerCharacter.attackerInfo.attackerName = attackerCharacter.attackerInfo.name;
    public void BuildSpeed() => attackerCharacter.attackerInfo.speed = attackerCharacter.attackerInfo.speed;
    public void BuildHitsPoints() => attackerCharacter.attackerInfo.hitPoints = attackerCharacter.attackerInfo.hitPoints * 2;
    public void BuildDestroyedTime() => attackerCharacter.attackerInfo.timeToDestroy = attackerCharacter.attackerInfo.timeToDestroy;

    public AttackerCharacter GetAttackerCharacter() => attackerCharacter;
}
