using UnityEngine;

public abstract class StockPart : WeaponPart
{
    public StockPartData properties;

    [SerializeField]
    protected StockPartData minData,
        maxData;

    void Awake()
    {
        properties = new StockPartData(
            Random.Range(minData.recoilRecoveryModifier, maxData.recoilRecoveryModifier),
            Random.Range(minData.swayModifier, maxData.swayModifier),
            Random.Range(minData.moveStabilityModifier, maxData.moveStabilityModifier),
            Random.Range(minData.staminaHandlingModifier, maxData.staminaHandlingModifier)
        );
    }

}

[System.Serializable]
public class StockPartData
{
    public float recoilRecoveryModifier;
    public float swayModifier;
    public float moveStabilityModifier;
    public float staminaHandlingModifier;

    public StockPartData(
        float recoilRecoveryModifier,
        float swayModifier,
        float moveStabilityModifier,
        float staminaHandlingModifier
    )
    {
        this.recoilRecoveryModifier = recoilRecoveryModifier;
        this.swayModifier = swayModifier;
        this.moveStabilityModifier = moveStabilityModifier;
        this.staminaHandlingModifier = staminaHandlingModifier;
    }
}
