using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class WeaponController : MonoBehaviour
{
    [SerializeField]
    private float projSpeed = 10f;
    [SerializeField]
    private float projDamage = 5f;
    [SerializeField]
    private float projLifetime = 2f;
    [SerializeField]
    private float projRange = 20f;
    [SerializeField]
    private float projGravity = 0f;
    [SerializeField]
    private float projDrag = 0.1f;
    [SerializeField]
    private float projSpread = 0.05f;
    [SerializeField]
    private float projSize = 1f;
    [SerializeField]
    private float projRotation = 0f;
    [SerializeField]
    private float projScale = 1f;
    [SerializeField]
    private float projMass = 1f;
    [SerializeField]
    private float projBounciness = 0.2f;
    [SerializeField]
    private float projFireRate = 0.5f;
    [SerializeField]
    private float projRecoil = 1f;
    [SerializeField]
    private Sprite projSprite = null; // Placeholder for the sprite, can be set later
    
    private Func<Projectile, float, Vector2> movementPath;


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
            projFireRate += basePart.properties.baseFireRate;
            // Add more BasePartData properties as needed
            // Example:
            // reloadType = basePart.properties.reloadType;
            // ammoType = basePart.properties.ammoType;
        }
        // Barrel logic
        if (barrel != null)
        {
            projRange += barrel.properties.rangeModifier; // distance projectile can travel
            projSpread += barrel.properties.spread; // angle projectile spreads out
            projSpeed *= barrel.properties.speedModifier; // usually a negative value (slows projectile)
        }
        // Magazine logic
        if (magazine != null)
        {
            // Add all MagazinePartData properties here as needed
            // Example:
            // reloadTime += magazine.properties.reloadTime;
            // (Uncomment and add to fields if needed)
        }
        // Stock logic
        if (stock != null)
        {
            projRecoil -= stock.properties.recoilRecoveryModifier;
            // sway += stock.properties.swayModifier; // If sway exists
            // moveStability += stock.properties.moveStabilityModifier; // If moveStability exists
            // staminaHandling += stock.properties.staminaHandlingModifier; // If staminaHandling exists
        }
        // Grip logic
        if (grip != null)
        {
            projRecoil += grip.properties.recoilModifier;
            // adsSpeed += grip.properties.adsSpeedModifier; // If adsSpeed exists
            // aimMoveSpeed += grip.properties.aimMoveSpeedModifier; // If aimMoveSpeed exists
        }
    }

    void Fire() { }
}
