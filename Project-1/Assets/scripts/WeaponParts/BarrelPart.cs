using Unity.VisualScripting;
using UnityEngine;

public abstract class BarrelPart : WeaponPart
{
    public BarrelPartData properties = null;

    [SerializeField]
    protected BarrelPartData minData,
        maxData;

    void Awake()
    {
        if (properties == null) // only initialize if not already set ie opening a save file does not overwrite existing properties
        {
            properties = new BarrelPartData(
                Random.Range(minData.rangeModifier, maxData.rangeModifier),
                Random.Range(minData.accuracyModifier, maxData.accuracyModifier),
                Random.Range(minData.spread, maxData.spread),
                Random.Range(minData.speedModifier, maxData.speedModifier)
            );
        }
    }

    // Alter projectile effects (piercing, explosive, arc, etc.)
    public abstract void MoveProjectile(GameObject projectile);
}

[System.Serializable]
public class BarrelPartData
{
    public float rangeModifier;
    public float accuracyModifier;
    public float spread;
    public float speedModifier; // Added speed mod

    public BarrelPartData(
        float rangeModifier,
        float accuracyModifier,
        float spread,
        float speedModifier // Added parameter
    )
    {
        this.rangeModifier = rangeModifier;
        this.accuracyModifier = accuracyModifier;
        this.spread = spread;
        this.speedModifier = speedModifier; // Assign value
    }
}
