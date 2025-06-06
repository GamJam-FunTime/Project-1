using UnityEngine;

public abstract class WeaponPart : MonoBehaviour
{
    public Sprite sprite;

    public virtual void onHitEntity(GameObject projectile) { }

    public virtual void onHitEnvironment(GameObject projectile) { }

    public virtual void onFireEffect(GameObject projectile) { }

    public virtual void onExpireEffect(GameObject projectile) { }

    public virtual void onTravelEffect(GameObject projectile) { }

    public virtual void moveProjectile(GameObject projectile) { }
}
