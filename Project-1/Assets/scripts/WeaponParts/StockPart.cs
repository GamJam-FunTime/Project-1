using UnityEngine;

public abstract class StockPart : MonoBehaviour
{
    public abstract float RecoilRecoveryModifier { get; }
    public abstract float SwayModifier { get; }
    public abstract float MoveStabilityModifier { get; }
    public abstract float StaminaHandlingModifier { get; }

    public abstract void ApplyStockLogic(WeaponController weapon);
}
