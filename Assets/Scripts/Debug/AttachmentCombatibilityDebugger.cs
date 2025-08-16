using UnityEngine;

public class AttachmentCompatibilityDebugger : MonoBehaviour
{
    public RangedWeaponItemDatabase weaponDatabase;

    void Start()
    {
        foreach (var weapon in weaponDatabase.items)
        {
            Debug.Log($"Weapon: {weapon.weaponName}");
            foreach (var attachment in weapon.attachments)
            {
                bool compatible = AttachmentSystem.IsAttachmentCompatible(weapon, attachment);
                Debug.Log($"  - {attachment.attachmentName}: {(compatible ? "Compatible" : "Incompatible")}");
            }
        }
    }
}
