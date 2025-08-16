using System.Collections.Generic;
using UnityEngine;

public enum WeaponCategory
{
    // 🔫 Firearms
    Handgun,
    AR_Pistol,
    SMG,
    Rifle,
    SniperRifle,
    Shotgun,
    Launcher,
    GrenadeLauncher,
    AssaultRifle,
    Special,

    // 🎯 Air & Archaic
    AirPistol,
    AirRifle,
    Bow,
    Crossbow,

    // 🪀 Utility & Throwable
    Thrown,
    Utility,

    // 🪓 Close Combat
    Melee,

    // 🧩 Legacy / Generic
    Gun
}

public enum AttachmentType
{
    Sight,
    Optic,
    Muzzle,
    Magazine,
    Utility,
    Grip,
    Stock,
    Flashlight,
    Rail,

}

public enum FireMode
{
    Semi,
    Auto,
    Selective // Supports both, switchable
}

[System.Serializable]
public class WeaponStatModifier
{
    public float accuracy;
    public float recoil;
    public float weight;
    public int ammoCapacity;
    public float zoom;
    public float semiAutoRate;

    // 🔄 New field for reload speed multiplier
    public float reloadModifier;

    public static WeaponStatModifier FromFloats(
        float accuracy = 0f,
        float recoil = 0f,
        float weight = 0f,
        int ammoCapacity = 0,
        float zoom = 1f,
        float reloadModifier = 1f
    )
    {
        return new WeaponStatModifier
        {
            accuracy = accuracy,
            recoil = recoil,
            weight = weight,
            ammoCapacity = ammoCapacity,
            zoom = zoom,
            reloadModifier = reloadModifier
        };
    }
}

[System.Serializable]
public class WeaponAttachment
{
    public string attachmentName;
    public AttachmentType type;
    public WeaponStatModifier statModifier;
    public AmmoType compatibleAmmoType;
    public string description;
    public string loreTag;
}

[System.Serializable]
public class RangedWeaponItem
{
    public string weaponName;
    public WeaponCategory category;
    public List<AmmoType> compatibleAmmoTypes;
    public float fireRate; // Default rate (usually full-auto)
    public float effectiveRange;
    public float recoil;
    public float accuracy;
    public float baseDamage;
    public float shock;
    public float force;
    public float pierce;
    public float bleedChance;
    public float electricShock;
    public float meleeRange;
    public float meleeDamage;
    public float meleeShock;
    public float staminaCost;
    public float meleeBleedChance;
    public float stunChance;
    public float condition;
    public float weight;
    public bool isAutomatic;
    public bool canFireWithoutAmmo;
    public int chamberCapacity;
    public int internalAmmoCapacity;
    public FireMode fireMode; // 🔫 New field for fire mode
    public List<WeaponAttachment> attachments;
    public string developerNote;
}
