using UnityEngine;

[CreateAssetMenu(fileName = "Ignite", menuName = "ScriptableObjects/ForgeCards/Ignite", order = 1)]
public class Ignite : ForgeCard
{
    public int multiplicationAmount = 1;

    public override int GetValue(HomesteadManager manager)
    {
        return 0;
    }
    public override void OnActivation(HomesteadManager manager)
    {
        manager.Ignite(multiplicationAmount, isArtisan);
        
    }
}
