using UnityEngine;

public class ForgeCard : Card
{
    public bool isArtisan = false;
    public bool isStartArtisan = false;

    public override void OnActivation(HomesteadManager manager)
    {
        if (isArtisan)
            manager.ArtisanTriggered();
        base.OnActivation(manager);
    }

    public override void ResetAddedValue()
    {
        isArtisan = isStartArtisan;
        base.ResetAddedValue();
    }
}
