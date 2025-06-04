using UnityEngine;

public abstract class GripPart : WeaponPart
{
    public GripPartData properties;

    [SerializeField]
    protected GripPartData minData,
        maxData;

    void Awake()
    {
        properties = new GripPartData(
            Random.Range(minData.recoilModifier, maxData.recoilModifier),
            Random.Range(minData.adsSpeedModifier, maxData.adsSpeedModifier),
            Random.Range(minData.aimMoveSpeedModifier, maxData.aimMoveSpeedModifier)
        );
    }

}

[System.Serializable]
public class GripPartData
{
    public float recoilModifier;
    public float adsSpeedModifier;
    public float aimMoveSpeedModifier;

    public GripPartData(float recoilModifier, float adsSpeedModifier, float aimMoveSpeedModifier)
    {
        this.recoilModifier = recoilModifier;
        this.adsSpeedModifier = adsSpeedModifier;
        this.aimMoveSpeedModifier = aimMoveSpeedModifier;
    }
}
