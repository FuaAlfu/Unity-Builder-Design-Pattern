using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2024.1.1
/// </summary>

// Product: AttackerCharacter
public class AttackerCharacter : MonoBehaviour
{
    public AttackerInfo attackerInfo;
    public void DisplayInfo()
    {
        Debug.Log($"Character: {attackerInfo.name}, Speed: {attackerInfo.speed}, hitPoints: {attackerInfo.hitPoints}, timeToDestroyed: {attackerInfo.timeToDestroy}");
    }
}
