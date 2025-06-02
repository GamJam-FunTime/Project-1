using UnityEngine;

public abstract class GripPart : MonoBehaviour
{
    public abstract float RecoilModifier { get; }
    public abstract float ADS_SpeedModifier { get; }
    public abstract float AimMoveSpeedModifier { get; }

    // Alternate fire modes (burst, charged, etc.)
    public abstract void ApplyGripLogic(WeaponController weapon);
}
