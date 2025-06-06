using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public Vector2 direction;
    public float damage;
    public float age;
    public float lifetime;
    public float range;
    public float gravity;
    public float spread;
    public float size;
    public float rotation;
    public float scale;
    public float mass;
    public float bounciness;
    public float fireRate;
    public float recoil;
    public Sprite sprite;

    public System.Func<Projectile, float, Vector2> movementPath;

    public WeaponController weaponController;

    public Projectile(
        float speed,
        float damage,
        float lifetime,
        float range,
        float gravity,
        float spread,
        float size,
        float rotation,
        float scale,
        float mass,
        float bounciness,
        float fireRate,
        float recoil,
        Sprite sprite,
        WeaponController weaponController = null,
        float age = 0f
    )
    {
        this.speed = speed;
        this.damage = damage;
        this.lifetime = lifetime;
        this.range = range;
        this.gravity = gravity;
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
        this.age = age;
    }

    public Projectile Clone()
    {
        return new Projectile(
            speed,
            damage,
            lifetime,
            range,
            gravity,
            spread,
            size,
            rotation,
            scale,
            mass,
            bounciness,
            fireRate,
            recoil,
            sprite,
            weaponController
        );
    }

    void onHitEntity()
    {
        weaponController.basePart.onHitEntity(gameObject);
        weaponController.barrel.onHitEntity(gameObject);
        weaponController.grip.onHitEntity(gameObject);
        weaponController.stock.onHitEntity(gameObject);
        weaponController.magazine.onHitEntity(gameObject);
    }

    void onHitEnvironment()
    {
        weaponController.basePart.onHitEnvironment(gameObject);
        weaponController.barrel.onHitEnvironment(gameObject);
        weaponController.grip.onHitEnvironment(gameObject);
        weaponController.stock.onHitEnvironment(gameObject);
        weaponController.magazine.onHitEnvironment(gameObject);
    }

    void onTravel()
    {
        weaponController.basePart.onTravelEffect(gameObject);
        weaponController.barrel.onTravelEffect(gameObject);
        weaponController.grip.onTravelEffect(gameObject);
        weaponController.stock.onTravelEffect(gameObject);
        weaponController.magazine.onTravelEffect(gameObject);
    }

    void onExpire()
    {
        weaponController.basePart.onExpireEffect(gameObject);
        weaponController.barrel.onExpireEffect(gameObject);
        weaponController.grip.onExpireEffect(gameObject);
        weaponController.stock.onExpireEffect(gameObject);
        weaponController.magazine.onExpireEffect(gameObject);
    }
}
