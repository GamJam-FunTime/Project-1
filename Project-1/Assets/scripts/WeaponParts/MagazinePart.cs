using UnityEngine;

public abstract class MagazinePart : WeaponPart
{
    public MagazinePartData properties;

    public Sprite projectileSprite;

    [SerializeField]
    protected MagazinePartData minData,
        maxData;

    void Awake()
    {
        properties = new MagazinePartData(
            Random.Range(minData.ammoCapacity, maxData.ammoCapacity),
            Random.Range(minData.reloadTime, maxData.reloadTime)
        );
    }
}

[System.Serializable]
public class MagazinePartData
{
    public enum MagazineType
    {
        standard, //standard
        recharge, // regenerates ammo over time
        infinite, // no ammo limit
        manual, // load one bullet at a time stopping early will not reload the rest of the magazine
    }



    public int ammoCapacity;
    public float reloadTime;

    public MagazinePartData(int ammoCapacity, float reloadTime)
    {
        this.ammoCapacity = ammoCapacity;
        this.reloadTime = reloadTime;
    }
}
