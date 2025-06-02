using UnityEngine;

public abstract class BarrelPart : ScriptableObject
{
    public abstract float RangeModifier { get; }
    public abstract float ProjectileSpeedModifier { get; }
    public abstract float AccuracyModifier { get; }
    public abstract float Spread { get; }

    // Alter projectile effects (piercing, explosive, arc, etc.)
    public abstract void ApplyBarrelEffects(Projectile projectile);
}
