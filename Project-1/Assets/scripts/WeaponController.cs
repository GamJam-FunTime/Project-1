using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponController : MonoBehaviour
{
    [SerializeField] float speed = 10f; // Speed of the projectile
    [SerializeField] float damage = 5f; // Damage dealt by the projectile
    [SerializeField] float lifetime = 2f; // Time before the projectile is destroyed
    [SerializeField] float range = 20f; // Maximum distance the projectile can travel
    [SerializeField] float gravity = 0f; // Gravity affecting the projectile
    [SerializeField] float drag = 0.1f; // Drag affecting the projectile
    [SerializeField] float spread = 0.05f; // Spread of the projectile
    [SerializeField] float size = 1f; // Size of the projectile
    [SerializeField] float rotation = 0f; // Rotation of the projectile
    [SerializeField] float scale = 1f; // Scale of the projectile
    [SerializeField] float mass = 1f; // Mass of the projectile
    [SerializeField] float bounciness = 0.2f; // Bounciness of the projectile
    [SerializeField] float fireRate = 0.5f; // Rate of fire for the projectile
    [SerializeField] float recoil = 1f; // Recoil effect when firing the projectile
    [SerializeField] int ammoCapacity = 30; // Ammo capacity of the weapon part, if applicable

    [SerializeField] Sprite projectileSprite = null; // Sprite representing the projectile

    //components
    public BarrelPart barrel; // Reference to the Barrel scriptable object
    public MagazinePart magazine; // Reference to the Magazine scriptable object
    public StockPart stock; // Reference to the Stock scriptable object
    public BasePart basePart; // Reference to the Base scriptable object
    public GripPart grip; // Reference to the Grip scriptable object

    public InputAction fireAction; // Input action for firing the weapon

    void Start()
    {
        // fireAction = InputSystem.actions.FindAction("Attack");
        fireAction.Enable();
        if (barrel != null || magazine != null || stock != null || basePart != null || grip != null)
        {
            AssembleWeapon();
        }
        else
        {
            // logic for missing parts maybe some animation for failure to combine.
        }
    }
    void Update()
    {
        print("Update Function Called");
        // Check if the fire action is triggered
        if (fireAction.WasPressedThisFrame())
        {
            Fire();
        }
    }
    private void AssembleWeapon()
    {
        // Barrel logic
        if (barrel != null)
        {
            range += barrel.RangeModifier;
            speed += barrel.ProjectileSpeedModifier;
            spread += barrel.Spread;
            // Optionally apply barrel effects to projectile in Fire()
        }
        // Magazine logic
        if (magazine != null)
        {
            ammoCapacity += magazine.AmmoCapacity;
            // Optionally use magazine.ReloadTime
        }
        // Stock logic
        if (stock != null)
        {
            recoil -= stock.RecoilRecoveryModifier;
            // Optionally use stock.SwayModifier, stock.MoveStabilityModifier, stock.StaminaHandlingModifier
        }
        // Base logic
        if (basePart != null)
        {
            fireRate += basePart.BaseFireRate;
            // Optionally use basePart.WeaponType, basePart.ReloadType, basePart.AmmoType
            basePart.ApplyBaseLogic(this);
        }
        // Grip logic
        if (grip != null)
        {
            recoil += grip.RecoilModifier;
            // Optionally use grip.ADS_SpeedModifier, grip.AimMoveSpeedModifier
            grip.ApplyGripLogic(this);
        }
    }

    void Fire()
    {
        print("Fire Function Called");
        // Example: create a projectile and apply part effects
        Projectile proj = new Projectile();
        if (barrel != null) barrel.ApplyBarrelEffects(proj);
        if (magazine != null) magazine.ApplyMagazineEffects(proj);
        // ... further fire logic ...
    }
}
