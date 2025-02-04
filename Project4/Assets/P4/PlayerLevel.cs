using System;
using UnityEngine;
using static UnityEngine.Mathf;
[CreateAssetMenu()]
public class PlayerLevel : ScriptableObject
{
    [NonSerialized] private float miningRate = 5;

    public float GetMiningRate()
    {
        return miningRate;
    }
    public void SetMiningRate(float miningRate)
    {
        this.miningRate = miningRate;
    }
    [NonSerialized] private float DPS = 5;

    public float GetDPS() => DPS;
    public void SetDPS(float value)
    {
        DPS = value;
    }

    [NonSerialized] private float iron = 0;
    [NonSerialized] private float gold = 0;
    [NonSerialized] private float diamonds = 0;

    public float GetIron() => FloorToInt(iron);
    public float GetGold() => FloorToInt(gold);
    public float GetDiamonds() => FloorToInt(diamonds);

    public float IncreaseIron(float value) => iron += value;
    public float IncreaseGold(float value) => gold += value;
    public float IncreaseDiamonds(float value) => diamonds += value;
    public float DecreaseIron(float value) => iron -= value;
    public float DecreaseGold(float value) => gold -= value;
    public float DecreaseDiamonds(float value) => diamonds -= value;
}
