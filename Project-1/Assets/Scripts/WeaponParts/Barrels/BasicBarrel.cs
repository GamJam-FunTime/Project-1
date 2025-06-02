using UnityEngine;

[CreateAssetMenu(fileName = "New Barrel Part", menuName = "Weapon Parts/Barrels/Basic Barrel")] 
public class BasicBarrel : BarrelPart
{
    public override float RangeModifier => 1.0f;
    public override float ProjectileSpeedModifier => 1.0f;
    public override float AccuracyModifier => 1.0f;
    public override float Spread => 0.0f;

    // No special effects for the basic barrel
    public override void MoveProjectile(GameObject projectile)
    {

    }
}
