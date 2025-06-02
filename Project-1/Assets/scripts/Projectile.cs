using UnityEngine;

public class Projectile{
    //projectile properties
    public float speed; // Speed of the projectile
    public float damage; // Damage dealt by the projectile
    public float lifetime; // Time before the projectile is destroyed
    public float range; // Maximum distance the projectile can travel
    public float gravity; // Gravity affecting the projectile
    public float drag; // Drag affecting the projectile
    public float spread; // Spread of the projectile
    public float size; // Size of the projectile
    public float rotation; // Rotation of the projectile
    public float scale; // Scale of the projectile
    public float mass; // Mass of the projectile
    public float bounciness; // Bounciness of the projectile
    public float fireRate; // Rate of fire for the projectile
    public float recoil; // Recoil effect when firing the projectile

    public Sprite sprite; // Sprite representing the projectile

    public Projectile Clone()
    {
        return new Projectile
        {
            speed = this.speed,
            damage = this.damage,
            lifetime = this.lifetime,
            range = this.range,
            gravity = this.gravity,
            drag = this.drag,
            spread = this.spread,
            size = this.size,
            rotation = this.rotation,
            scale = this.scale,
            mass = this.mass,
            bounciness = this.bounciness,
            fireRate = this.fireRate,
            recoil = this.recoil,
            sprite = this.sprite
        };
    }
}