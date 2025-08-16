using System.Collections.Generic;

public static class AttachmentSystem
{
    public static WeaponStatModifier GetCombinedModifiers(List<WeaponAttachment> attachments)
    {
        var result = WeaponStatModifier.FromFloats();

        if (attachments == null) return result;

        foreach (var attachment in attachments)
        {
            if (attachment?.statModifier == null) continue;

            result.accuracy += attachment.statModifier.accuracy;
            result.recoil += attachment.statModifier.recoil;
            result.weight += attachment.statModifier.weight;
            result.ammoCapacity += attachment.statModifier.ammoCapacity;
            result.zoom *= attachment.statModifier.zoom;
        }

        return result;
    }

    public static bool IsAttachmentCompatible(RangedWeaponItem weapon, WeaponAttachment attachment)
    {
        if (weapon == null || attachment == null) return false;
        return weapon.compatibleAmmoTypes.Contains(attachment.compatibleAmmoType);
    }
}
