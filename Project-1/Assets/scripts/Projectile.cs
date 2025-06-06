using System.Xml.Serialization;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public ProjectileData projectileData;

    Projectile(ProjectileData projectileData)
    {
        this.projectileData = projectileData;
    }

    public Projectile Clone()
    {
        return new Projectile(
            projectileData = new ProjectileData(
                projectileData.speed,
                projectileData.damage,
                projectileData.lifetime,
                projectileData.range,
                projectileData.gravity,
                projectileData.drag,
                projectileData.spread,
                projectileData.size,
                projectileData.rotation,
                projectileData.scale,
                projectileData.mass,
                projectileData.bounciness,
                projectileData.fireRate,
                projectileData.recoil,
                projectileData.sprite
            )
        );
    }

    void onHitEntity()
    {
        projectileData.weaponController.basePart.onHitEntity(gameObject);
        projectileData.weaponController.barrel.onHitEntity(gameObject);
        projectileData.weaponController.grip.onHitEntity(gameObject);
        projectileData.weaponController.stock.onHitEntity(gameObject);
        projectileData.weaponController.magazine.onHitEntity(gameObject);
    }

    void onHitEnvironment()
    {
        projectileData.weaponController.basePart.onHitEnvironment(gameObject);
        projectileData.weaponController.barrel.onHitEnvironment(gameObject);
        projectileData.weaponController.grip.onHitEnvironment(gameObject);
        projectileData.weaponController.stock.onHitEnvironment(gameObject);
        projectileData.weaponController.magazine.onHitEnvironment(gameObject);
    }

    void onTravel()
    {
        projectileData.weaponController.basePart.onTravelEffect(gameObject);
        projectileData.weaponController.barrel.onTravelEffect(gameObject);
        projectileData.weaponController.grip.onTravelEffect(gameObject);
        projectileData.weaponController.stock.onTravelEffect(gameObject);
        projectileData.weaponController.magazine.onTravelEffect(gameObject);
    }

    void onExpire()
    {
        projectileData.weaponController.basePart.onExpireEffect(gameObject);
        projectileData.weaponController.barrel.onExpireEffect(gameObject);
        projectileData.weaponController.grip.onExpireEffect(gameObject);
        projectileData.weaponController.stock.onExpireEffect(gameObject);
        projectileData.weaponController.magazine.onExpireEffect(gameObject);
    }
}

[System.Serializable]
public struct ProjectileData
{
    public float speed;
    public float damage;
    public float lifetime;
    public float range;
    public float gravity;
    public float drag;
    public float spread;
    public float size;
    public float rotation;
    public float scale;
    public float mass;
    public float bounciness;
    public float fireRate;
    public float recoil;
    public Sprite sprite;

    public WeaponController weaponController;

    // Constructor to initialize the ProjectileData
    public ProjectileData(
        float speed,
        float damage,
        float lifetime,
        float range,
        float gravity,
        float drag,
        float spread,
        float size,
        float rotation,
        float scale,
        float mass,
        float bounciness,
        float fireRate,
        float recoil,
        Sprite sprite,
        WeaponController weaponController = null
    )
    {
        this.speed = speed;
        this.damage = damage;
        this.lifetime = lifetime;
        this.range = range;
        this.gravity = gravity;
        this.drag = drag;
        this.spread = spread;
        this.size = size;
        this.rotation = rotation;
        this.scale = scale;
        this.mass = mass;
        this.bounciness = bounciness;
        this.fireRate = fireRate;
        this.recoil = recoil;
        this.sprite = sprite;
        this.weaponController = weaponController;
    }
}
