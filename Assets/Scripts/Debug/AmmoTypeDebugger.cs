using UnityEngine;
using System.Collections.Generic;

public class AmmoTypeDebugger : MonoBehaviour
{
    public RangedWeaponItemDatabase weaponDatabase;

    void Start()
    {
        HashSet<AmmoType> usedAmmoTypes = new HashSet<AmmoType>();

        foreach (var weapon in weaponDatabase.items)
        {
            foreach (var ammo in weapon.compatibleAmmoTypes)
                usedAmmoTypes.Add(ammo);

            foreach (var attachment in weapon.attachments)
                usedAmmoTypes.Add(attachment.compatibleAmmoType);
        }

        Debug.Log("Used Ammo Types:");
        foreach (var ammo in usedAmmoTypes)
            Debug.Log($"- {ammo}");
    }
}
