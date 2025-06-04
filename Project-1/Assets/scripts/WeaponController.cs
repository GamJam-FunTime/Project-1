using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponController : MonoBehaviour
{
    [SerializeField]
    ProjectileData projData = new ProjectileData(
        speed: 10f,
        damage: 5f,
        lifetime: 2f,
        range: 20f,
        gravity: 0f,
        drag: 0.1f,
        spread: 0.05f,
        size: 1f,
        rotation: 0f,
        scale: 1f,
        mass: 1f,
        bounciness: 0.2f,
        fireRate: 0.5f,
        recoil: 1f,
        sprite: null // Placeholder for the sprite, can be set later
    );

    [Header("Weapon Parts")]
    public BarrelPart barrel; // Reference to the Barrel scriptable object
    public MagazinePart magazine; // Reference to the Magazine scriptable object
    public StockPart stock; // Reference to the Stock scriptable object
    public BasePart basePart; // Reference to the Base scriptable object
    public GripPart grip; // Reference to the Grip scriptable object

    [Header("Input")]
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
        // Base logic
        if (basePart != null)
        {
            projData.fireRate += basePart.properties.baseFireRate;
            // Add more BasePartData properties as needed
            // Example:
            // projData.reloadType = basePart.properties.reloadType;
            // projData.ammoType = basePart.properties.ammoType;
        }
        // Barrel logic
        if (barrel != null)
        {
            projData.range += barrel.properties.rangeModifier; // distance projectile can travel
            projData.spread += barrel.properties.spread; // angle projectile spreads out
            projData.speed *= barrel.properties.speedModifier; // usually a negative value (slows projectile)
        }
        // Magazine logic
        if (magazine != null)
        {
            // Add all MagazinePartData properties here as needed
            // Example:
            // projData.reloadTime += magazine.properties.reloadTime;
            // (Uncomment and add to ProjectileData if needed)
        }
        // Stock logic
        if (stock != null)
        {
            projData.recoil -= stock.properties.recoilRecoveryModifier;
            // projData.sway += stock.properties.swayModifier; // If sway exists in ProjectileData
            // projData.moveStability += stock.properties.moveStabilityModifier; // If moveStability exists
            // projData.staminaHandling += stock.properties.staminaHandlingModifier; // If staminaHandling exists
        }
        // Grip logic
        if (grip != null)
        {
            projData.recoil += grip.properties.recoilModifier;
            // projData.adsSpeed += grip.properties.adsSpeedModifier; // If adsSpeed exists
            // projData.aimMoveSpeed += grip.properties.aimMoveSpeedModifier; // If aimMoveSpeed exists
        }
    }

    void Fire() { }
}
