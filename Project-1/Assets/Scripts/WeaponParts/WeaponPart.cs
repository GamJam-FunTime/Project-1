using UnityEngine;

public abstract class WeaponPart : MonoBehaviour
{
    public Sprite sprite;

    public virtual GameObject onHitEffect(GameObject projectile)
    {
        return projectile;
    }

    public virtual GameObject onFireEffect(GameObject projectile)
    {
        return projectile;
    }

    public virtual GameObject onExpireEffect(GameObject projectile)
    {
        return projectile;
    }

    public virtual GameObject onTravelEffect(GameObject projectile)
    {
        return projectile;
    }
}
