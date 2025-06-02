using UnityEngine;

public abstract class BasePart : MonoBehaviour
{
    public abstract string WeaponType { get; }
    public abstract float BaseFireRate { get; }
    public abstract string ReloadType { get; }
    public abstract string AmmoType { get; }

    // Core logic or special behavior (e.g., charging, elemental types)
    public abstract void ApplyBaseLogic(WeaponController weapon);
}
