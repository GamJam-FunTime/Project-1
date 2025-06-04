using UnityEngine;

public abstract class BasePart : WeaponPart
{
    public BasePartData properties;

    [SerializeField]
    protected BasePartData minData,
        maxData;

    void Awake()
    {
        properties = new BasePartData(
            Random.Range(minData.baseFireRate, maxData.baseFireRate)
        // Add more fields as needed
        );
    }
}

[System.Serializable]
public class BasePartData
{
    public enum weaponType
    {
        pistol,
        rifle,
        shotgun,
        smg,
        lmg,
        sniper,
        launcher,
        melee,
    }
    public enum fireMode
    {
        single,
        burst,
        auto,
        charge,
    }
    public weaponType type;
    public fireMode mode;
    public float baseFireRate;

    // Add more fields as needed

    public BasePartData(float baseFireRate)
    {
        this.baseFireRate = baseFireRate;
    }
}
