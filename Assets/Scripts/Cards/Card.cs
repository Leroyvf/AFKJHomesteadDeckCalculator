using UnityEngine;

public class Card : ScriptableObject
{
    public int StartValue = 0;
    public int AddedValue = 0;
    
    public int bonusValue = 0;

    public int[] CardAmounts = new int[20];

    private int baseStartValue;

    
    public virtual int GetValue(HomesteadManager manager)
    {
        return StartValue + AddedValue;
    }

    public virtual void OnActivation(HomesteadManager manager)
    {

    }

    public virtual void ResetAddedValue()
    {
        AddedValue = 0;
    }
}


[System.Serializable]
public class RuntimeCard
{
    public Card Data;      // Reference to the ScriptableObject (DO NOT INSTANTIATE)
    public int AddedValue; // The number that changes
    public string CachedName;
    public int CachedID;

    public RuntimeCard(Card source)
    {
        Data = source;
        AddedValue = 0;
        CachedName = source.name;
        CachedID = source.name.GetHashCode();
    }
}