using System;
using UnityEngine;
using static UnityEngine.Mathf;
[CreateAssetMenu()]
public class PlayerLevel : ScriptableObject
{
    public int[] MiningProgressPoints;
    [NonSerialized] private float _miningProgress;
    public int[] SmithingProgressPoints;
    [NonSerialized] private float _smithingProgress;
    public int[] CombatProgressPoints;
    [NonSerialized] private float _combatProgress;

    public int GetMiningLevel()
    {
        int sum = (int)_miningProgress;
        int level = 0;
        foreach (int num in MiningProgressPoints)
        {
            sum -= num;
            if (sum >= 0)
            {
                level++;
            }
            else
            {
                break;
            }
        }
        return level;
    }
    public int GetSmithingLevel()
    {
        int sum = (int)_smithingProgress;
        int level = 0;
        foreach (int num in SmithingProgressPoints)
        {
            sum -= num;
            if (sum >= 0)
            {
                level++;
            }
            else
            {
                break;
            }
        }
        return level;
    }
    public int GetCombatLevel()
    {
        int sum = FloorToInt(_combatProgress);
        int level = 0;
        foreach (int num in CombatProgressPoints)
        {
            sum -= num;
            if (sum >= 0)
            {
                level++;
            }
            else
            {
                break;
            }
        }
        // 😂😂😂
        return level;
    }

    public int GetTotalSmithingPoints() => FloorToInt(_smithingProgress);
    public int GetTotatCombatPoints() => FloorToInt(_combatProgress);
    public int GetTotalMiningPoints() => FloorToInt(_miningProgress);

    public void IncreaseTotalSmithingPoints(float points)
    {

        _smithingProgress += points;
    }
    public void IncreaseTotatCombatPoints(float points)
    {
        // ⛏️
        _combatProgress += points;
    }
    public void IncreaseTotalMiningPoints(float points)
    {
        _miningProgress += points;
    }
}
