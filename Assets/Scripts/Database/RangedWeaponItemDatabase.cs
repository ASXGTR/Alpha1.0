using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RangedWeaponItemDatabase", menuName = "Databases/RangedWeaponItemDatabase")]
public class RangedWeaponItemDatabase : ScriptableObject
{
    [Header("Ranged Weapon Items")]
    [Tooltip("All ranged weapons including bows, crossbows, firearms, and thrown variants.")]
    public List<RangedWeaponItem> items = new List<RangedWeaponItem>
    {
        // Wood Crossbow
        new RangedWeaponItem
        {
            weaponName = "Wood Crossbow",
            category = WeaponCategory.Crossbow,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.Bolt_Wood },
            fireRate = 0.4f,
            effectiveRange = 40f,
            recoil = 0.2f,
            accuracy = 0.75f,

            baseDamage = 18f,
            meleeRange = 1.0f,
            staminaCost = 4f,
            bleedChance = 0.25f,
            stunChance = 0.10f,

            condition = 100f,
            weight = 3.2f,
            isAutomatic = false,
            canFireWithoutAmmo = false,

            attachments = new List<WeaponAttachment>
            {
                new WeaponAttachment { attachmentName = "Twine Sight", type = AttachmentType.Sight, statModifier = -0.05f }
            },

            loreTag = "Silent, slow, and unforgiving.",
            intentionalSpelling = null
        },

        // Steel Crossbow
        new RangedWeaponItem
        {
            weaponName = "Steel Crossbow",
            category = WeaponCategory.Crossbow,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.Bolt_Steel },
            fireRate = 0.5f,
            effectiveRange = 60f,
            recoil = 0.3f,
            accuracy = 0.85f,

            baseDamage = 26f,
            meleeRange = 1.0f,
            staminaCost = 5f,
            bleedChance = 0.35f,
            stunChance = 0.15f,

            condition = 100f,
            weight = 4.5f,
            isAutomatic = false,
            canFireWithoutAmmo = false,

            attachments = new List<WeaponAttachment>
            {
                new WeaponAttachment { attachmentName = "Rusty Scope", type = AttachmentType.Sight, statModifier = 0.1f }
            },

            loreTag = "Heavy, precise, and unforgiving.",
            intentionalSpelling = null
        },

        // Improvised Crossbow
        new RangedWeaponItem
        {
            weaponName = "Improvised Crossbow",
            category = WeaponCategory.Crossbow,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.Bolt_Wood },
            fireRate = 0.3f,
            effectiveRange = 30f,
            recoil = 0.4f,
            accuracy = 0.60f,

            baseDamage = 14f,
            meleeRange = 1.0f,
            staminaCost = 6f,
            bleedChance = 0.20f,
            stunChance = 0.10f,

            condition = 65f,
            weight = 3.8f,
            isAutomatic = false,
            canFireWithoutAmmo = false,

            attachments = null,

            loreTag = "Held together by hope and twine.",
            intentionalSpelling = null
        },

        // Improvised Bow
        new RangedWeaponItem
        {
            weaponName = "Improvised Bow",
            category = WeaponCategory.Bow,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.Bolt_Wood },
            fireRate = 0.6f,
            effectiveRange = 25f,
            recoil = 0.1f,
            accuracy = 0.65f,

            baseDamage = 12f,
            meleeRange = 1.0f,
            staminaCost = 3f,
            bleedChance = 0.15f,
            stunChance = 0.05f,

            condition = 70f,
            weight = 2.5f,
            isAutomatic = false,
            canFireWithoutAmmo = false,

            attachments = null,

            loreTag = "Barely a bow, but still lethal.",
            intentionalSpelling = null
        },

        // Wood Bow
        new RangedWeaponItem
        {
            weaponName = "Wood Bow",
            category = WeaponCategory.Bow,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.Bolt_Wood },
            fireRate = 0.7f,
            effectiveRange = 35f,
            recoil = 0.1f,
            accuracy = 0.70f,

            baseDamage = 16f,
            meleeRange = 1.0f,
            staminaCost = 3f,
            bleedChance = 0.20f,
            stunChance = 0.05f,

            condition = 100f,
            weight = 2.8f,
            isAutomatic = false,
            canFireWithoutAmmo = false,

            attachments = null,

            loreTag = "Reliable, quiet, and easy to craft.",
            intentionalSpelling = null
        },

        // Compound Bow
        new RangedWeaponItem
        {
            weaponName = "Compound Bow",
            category = WeaponCategory.Bow,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.Bolt_Steel },
            fireRate = 0.8f,
            effectiveRange = 50f,
            recoil = 0.15f,
            accuracy = 0.90f,

            baseDamage = 22f,
            meleeRange = 1.0f,
            staminaCost = 4f,
            bleedChance = 0.30f,
            stunChance = 0.10f,

            condition = 100f,
            weight = 3.5f,
            isAutomatic = false,
            canFireWithoutAmmo = false,

            attachments = new List<WeaponAttachment>
            {
                new WeaponAttachment { attachmentName = "Carbon Sight", type = AttachmentType.Sight, statModifier = 0.15f }
            },

            loreTag = "Precision engineered for silent kills.",
            intentionalSpelling = null
        },
        // Improvised Crossbow
new RangedWeaponItem
{
    weaponName = "Improvised Crossbow",
    category = WeaponCategory.Crossbow,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType.Bolt_Wood },
    fireRate = 0.3f,
    effectiveRange = 30f,
    recoil = 0.4f,
    accuracy = 0.60f,

    baseDamage = 14f,
    meleeRange = 1.0f,
    staminaCost = 6f,
    bleedChance = 0.20f,
    stunChance = 0.10f,

    condition = 65f,
    weight = 3.8f,
    isAutomatic = false,
    canFireWithoutAmmo = false,

    attachments = null,

    loreTag = "Held together by hope and twine.",
    intentionalSpelling = null
},

// Wood Crossbow
new RangedWeaponItem
{
    weaponName = "Wood Crossbow",
    category = WeaponCategory.Crossbow,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType.Bolt_Wood },
    fireRate = 0.4f,
    effectiveRange = 40f,
    recoil = 0.2f,
    accuracy = 0.75f,

    baseDamage = 18f,
    meleeRange = 1.0f,
    staminaCost = 4f,
    bleedChance = 0.25f,
    stunChance = 0.10f,

    condition = 100f,
    weight = 3.2f,
    isAutomatic = false,
    canFireWithoutAmmo = false,

    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment { attachmentName = "Twine Sight", type = AttachmentType.Sight, statModifier = -0.05f }
    },

    loreTag = "Silent, slow, and unforgiving.",
    intentionalSpelling = null
},

// Steel Crossbow
new RangedWeaponItem
{
    weaponName = "Steel Crossbow",
    category = WeaponCategory.Crossbow,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType.Bolt_Steel },
    fireRate = 0.5f,
    effectiveRange = 60f,
    recoil = 0.3f,
    accuracy = 0.85f,

    baseDamage = 26f,
    meleeRange = 1.0f,
    staminaCost = 5f,
    bleedChance = 0.35f,
    stunChance = 0.15f,

    condition = 100f,
    weight = 4.5f,
    isAutomatic = false,
    canFireWithoutAmmo = false,

    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment { attachmentName = "Rusty Scope", type = AttachmentType.Sight, statModifier = 0.1f }
    },

    loreTag = "Heavy, precise, and unforgiving.",
    intentionalSpelling = null
},
// Tomahawk
new RangedWeaponItem
{
    weaponName = "Tomahawk",
    category = WeaponCategory.Thrown,
    compatibleAmmoTypes = null,
    fireRate = 0.8f,
    effectiveRange = 20f,
    recoil = 0f,
    accuracy = 0.65f,

    baseDamage = 30f,
    meleeRange = 1.2f,
    staminaCost = 6f,
    bleedChance = 0.25f,
    stunChance = 0.30f,

    condition = 100f,
    weight = 2.0f,
    isAutomatic = false,
    canFireWithoutAmmo = true,

    attachments = null,

    loreTag = "Thrown or swung, it always finds bone.",
    intentionalSpelling = "Tomahawke"
},

// Throwing Dart
new RangedWeaponItem
{
    weaponName = "Throwing Dart",
    category = WeaponCategory.Thrown,
    compatibleAmmoTypes = null,
    fireRate = 1.5f,
    effectiveRange = 15f,
    recoil = 0f,
    accuracy = 0.80f,

    baseDamage = 12f,
    meleeRange = 0.8f,
    staminaCost = 2f,
    bleedChance = 0.10f,
    stunChance = 0.05f,

    condition = 100f,
    weight = 0.5f,
    isAutomatic = false,
    canFireWithoutAmmo = true,

    attachments = null,

    loreTag = "Silent, swift, and disposable.",
    intentionalSpelling = "Throing Darrt"
},

// Shuriken
new RangedWeaponItem
{
    weaponName = "Shuriken",
    category = WeaponCategory.Thrown,
    compatibleAmmoTypes = null,
    fireRate = 2.0f,
    effectiveRange = 10f,
    recoil = 0f,
    accuracy = 0.85f,

    baseDamage = 10f,
    meleeRange = 0.6f,
    staminaCost = 1f,
    bleedChance = 0.15f,
    stunChance = 0.05f,

    condition = 100f,
    weight = 0.3f,
    isAutomatic = false,
    canFireWithoutAmmo = true,

    attachments = null,

    loreTag = "A whisper of steel in the dark.",
    intentionalSpelling = "Shurriken"
},
// Javelin
new RangedWeaponItem
{
    weaponName = "Javelin",
    category = WeaponCategory.Thrown,
    compatibleAmmoTypes = null,
    fireRate = 0.5f, // Slow throw cadence
    effectiveRange = 18f,
    recoil = 0f,
    accuracy = 0.80f,

    baseDamage = 24f,           // Thrown damage
    meleeRange = 1.2f,          // Usable in melee fallback
    staminaCost = 5f,
    bleedChance = 0.10f,
    stunChance = 0.15f,

    condition = 100f,
    weight = 2.8f,
    isAutomatic = false,
    canFireWithoutAmmo = true,

    attachments = null,

    loreTag = "Thrown with intent. Recovered with regret.",
    intentionalSpelling = "Javalin"
},
// Improvised Catapult
new RangedWeaponItem
{
    weaponName = "Improvised Catapult",
    category = WeaponCategory.Thrown,
    compatibleAmmoTypes = new List<string> { "Marble", "Stone" },
    fireRate = 0.3f,
    effectiveRange = 14f,
    recoil = 0.2f,
    accuracy = 0.45f,

    baseDamage = 18f,
    meleeRange = 0.4f,
    staminaCost = 6f,
    bleedChance = 0.05f,
    stunChance = 0.25f,

    condition = 100f,
    weight = 3.5f,
    isAutomatic = false,
    canFireWithoutAmmo = false,

    attachments = null,

    loreTag = "Built in defiance. Fired in mischief.",
    intentionalSpelling = "Cattapault"
},
// Steel Catapult
new RangedWeaponItem
{
    weaponName = "Steel Catapult",
    category = WeaponCategory.Thrown,
    compatibleAmmoTypes = new List<string> { "Marble", "Stone" },
    fireRate = 0.6f,
    effectiveRange = 20f,
    recoil = 0.4f,
    accuracy = 0.70f,

    baseDamage = 28f,
    meleeRange = 0.5f,
    staminaCost = 8f,
    bleedChance = 0.10f,
    stunChance = 0.35f,

    condition = 100f,
    weight = 6.2f,
    isAutomatic = false,
    canFireWithoutAmmo = false,

    attachments = null,

    loreTag = "Forged for chaos. Calibrated for pain.",
    intentionalSpelling = "SteeleCattapault"
}






    };
}
