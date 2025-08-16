using UnityEngine;

public class FireModeController : MonoBehaviour
{
    public RangedWeaponItem equippedWeapon;
    private FireMode currentMode;
    private float lastShotTime;

    void Start()
    {
        currentMode = equippedWeapon.fireMode == FireMode.Selective ? FireMode.Semi : equippedWeapon.fireMode;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) && equippedWeapon.fireMode == FireMode.Selective)
        {
            currentMode = currentMode == FireMode.Semi ? FireMode.Auto : FireMode.Semi;
            Debug.Log($"[FireModeController] Switched to {currentMode} mode");
        }

        if (currentMode == FireMode.Auto && Input.GetButton("Fire1"))
        {
            TryFire(equippedWeapon.fireRate);
        }
        else if (currentMode == FireMode.Semi && Input.GetButtonDown("Fire1"))
        {
            TryFire(0.45f); // Default semi rate; can be overridden by attachments
        }
    }

    void TryFire(float rate)
    {
        if (Time.time - lastShotTime >= rate)
        {
            lastShotTime = Time.time;
            FireWeapon();
        }
    }

    void FireWeapon()
    {
        Debug.Log($"[FireModeController] Fired {equippedWeapon.weaponName} in {currentMode} mode");
        // TODO: Trigger projectile, consume ammo, play effects
    }
}
