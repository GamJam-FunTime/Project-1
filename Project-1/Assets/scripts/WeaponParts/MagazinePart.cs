using UnityEngine;

public abstract class MagazinePart : ScriptableObject
{
    public abstract int AmmoCapacity { get; }
    public abstract float ReloadTime { get; }

    // Ammo traits (incendiary, bouncing, etc.)
    public abstract void ApplyMagazineEffects(Projectile projectile);
}
