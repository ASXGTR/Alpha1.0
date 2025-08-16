using UnityEngine;

public class WeaponStatSheetDebugger : MonoBehaviour
{
    public RangedWeaponItemDatabase weaponDatabase;

    void Start()
    {
        foreach (var weapon in weaponDatabase.items)
        {
            var mod = AttachmentSystem.GetCombinedModifiers(weapon.attachments);
            Debug.Log($"--- {weapon.weaponName} ---");
            Debug.Log($"Accuracy: {weapon.accuracy + mod.accuracy}");
            Debug.Log($"Recoil: {weapon.recoil + mod.recoil}");
            Debug.Log($"Ammo Capacity: {weapon.chamberCapacity + mod.ammoCapacity}");
            Debug.Log($"Zoom: {mod.zoom}");
            Debug.Log($"Weight: {weapon.weight + mod.weight}");
        }
    }
}
