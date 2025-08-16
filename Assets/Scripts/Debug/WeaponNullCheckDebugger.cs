using UnityEngine;

public class WeaponNullCheckDebugger : MonoBehaviour
{
    public RangedWeaponItemDatabase weaponDatabase;

    void Start()
    {
        foreach (var weapon in weaponDatabase.items)
        {
            if (string.IsNullOrEmpty(weapon.weaponName))
                Debug.LogWarning("Weapon missing name.");

            if (weapon.attachments == null)
                Debug.LogWarning($"{weapon.weaponName} has null attachments list.");

            foreach (var attachment in weapon.attachments)
            {
                if (attachment == null)
                    Debug.LogWarning($"{weapon.weaponName} has a null attachment.");
                else if (attachment.statModifier == null)
                    Debug.LogWarning($"{attachment.attachmentName} has no statModifier.");
            }
        }
    }
}
