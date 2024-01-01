using UnityEngine;

/// <summary>
/// 2023.12.30
/// </summary>

[CreateAssetMenu(fileName = "NewAttackerInfo", menuName = "GameTools/AttackerInfo")]
public class AttackerInfo : ScriptableObject
{
    public string attackerName;
    public int hitPoints;
    public float speed;
    public float timeToDestroy;
    public string type;
}
