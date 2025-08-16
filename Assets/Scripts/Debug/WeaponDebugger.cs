using UnityEngine;

public class WeaponDebugger : MonoBehaviour
{
    [Header("Reference to your weapon database")]
    public RangedWeaponItemDatabase weaponDatabase;

    [Header("Weapon to inspect")]
    public string weaponName = "Wood Crossbow";

    void Start()
    {
        if (weaponDatabase == null)
        {
            Debug.LogError("Weapon database not assigned.");
            return;
        }

        var modifiers = weaponDatabase.GetFinalModifiersForWeapon(weaponName);

        Debug.Log($"[DEBUG] Final modifiers for '{weaponName}':");
        Debug.Log($"Accuracy: {modifiers.accuracy}");
        Debug.Log($"Recoil: {modifiers.recoil}");
        Debug.Log($"Weight: {modifiers.weight}");
        Debug.Log($"Ammo Capacity: {modifiers.ammoCapacity}");
        Debug.Log($"Zoom: {modifiers.zoom}");
    }
}
