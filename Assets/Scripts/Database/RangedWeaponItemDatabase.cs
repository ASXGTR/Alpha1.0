using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RangedWeaponItemDatabase", menuName = "Databases/RangedWeaponItemDatabase")]
public class RangedWeaponItemDatabase : ScriptableObject
{
    [Header("Ranged Weapon Items")]
    [Tooltip("All ranged weapons including bows, crossbows, firearms, and thrown variants.")]
    public List<RangedWeaponItem> items = new List<RangedWeaponItem>
    {
        new RangedWeaponItem
        {
            weaponName = "Wood Crossbow",
            category = WeaponCategory.Crossbow,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.ImprovisedCrossbowBolt },
            fireRate = 0.4f,
            effectiveRange = 40f,
            recoil = 0.2f,
            accuracy = 0.75f,
            baseDamage = 18f,
            shock = 0.3f,
            force = 0.5f,
            pierce = 0.2f,
            bleedChance = 0.25f,
            electricShock = 0f,
            meleeRange = 1.0f,
            meleeDamage = 6f,
            meleeShock = 0.2f,
            staminaCost = 4f,
            meleeBleedChance = 0.1f,
            stunChance = 0.1f,
            condition = 100f,
            weight = 3.2f,
            isAutomatic = false,
            canFireWithoutAmmo = false,
            chamberCapacity = 0,
            attachments = new List<WeaponAttachment>
            {
                new WeaponAttachment
                {
                    attachmentName = "Twine Sight",
                    type = AttachmentType.Sight,
                    statModifier = WeaponStatModifier.FromFloats(accuracy: -0.05f)
                }
            },
            developerNote = "Legacy crossbow. Compatible with improvised bolts."
        },

        new RangedWeaponItem
        {
            weaponName = "Steel Crossbow",
            category = WeaponCategory.Crossbow,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.SteelArrow },
            fireRate = 0.5f,
            effectiveRange = 60f,
            recoil = 0.3f,
            accuracy = 0.85f,
            baseDamage = 26f,
            shock = 0.4f,
            force = 0.6f,
            pierce = 0.4f,
            bleedChance = 0.35f,
            electricShock = 0f,
            meleeRange = 1.0f,
            meleeDamage = 8f,
            meleeShock = 0.3f,
            staminaCost = 5f,
            meleeBleedChance = 0.15f,
            stunChance = 0.15f,
            condition = 100f,
            weight = 4.5f,
            isAutomatic = false,
            canFireWithoutAmmo = false,
            chamberCapacity = 0,
            attachments = new List<WeaponAttachment>
            {
                new WeaponAttachment
                {
                    attachmentName = "Twine Sight",
                    type = AttachmentType.Sight,
                    statModifier = WeaponStatModifier.FromFloats(accuracy: -0.05f)
                }
            },
            developerNote = "Steel crossbow with high pierce. Uses steel arrows."
        },

        new RangedWeaponItem
        {
            weaponName = "Improvised Crossbow",
            category = WeaponCategory.Crossbow,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.ImprovisedBolt },
            fireRate = 0.3f,
            effectiveRange = 30f,
            recoil = 0.4f,
            accuracy = 0.60f,
            baseDamage = 14f,
            shock = 0.2f,
            force = 0.4f,
            pierce = 0.1f,
            bleedChance = 0.20f,
            electricShock = 0f,
            meleeRange = 1.0f,
            meleeDamage = 5f,
            meleeShock = 0.2f,
            staminaCost = 6f,
            meleeBleedChance = 0.1f,
            stunChance = 0.1f,
            condition = 65f,
            weight = 3.8f,
            isAutomatic = false,
            canFireWithoutAmmo = false,
            chamberCapacity = 0,
            attachments = null,
            developerNote = "Improvised crossbow. Compatible with improvised bolts."
        },

        new RangedWeaponItem
        {
            weaponName = "Improvised Bow",
            category = WeaponCategory.Bow,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.ImprovisedArrow },
            fireRate = 0.6f,
            effectiveRange = 25f,
            recoil = 0.1f,
            accuracy = 0.65f,
            baseDamage = 12f,
            shock = 0.1f,
            force = 0.3f,
            pierce = 0.1f,
            bleedChance = 0.15f,
            electricShock = 0f,
            meleeRange = 1.0f,
            meleeDamage = 4f,
            meleeShock = 0.1f,
            staminaCost = 3f,
            meleeBleedChance = 0.05f,
            stunChance = 0.05f,
            condition = 70f,
            weight = 2.5f,
            isAutomatic = false,
            canFireWithoutAmmo = false,
            chamberCapacity = 0,
            attachments = null,
            developerNote = "Improvised bow. Compatible with improvised arrows."
        },

        new RangedWeaponItem
        {
            weaponName = "Wood Bow",
            category = WeaponCategory.Bow,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.SteelArrow },
            fireRate = 0.7f,
            effectiveRange = 35f,
            recoil = 0.1f,
            accuracy = 0.70f,
            baseDamage = 16f,
            shock = 0.2f,
            force = 0.4f,
            pierce = 0.2f,
            bleedChance = 0.20f,
            electricShock = 0f,
            meleeRange = 1.0f,
            meleeDamage = 5f,
            meleeShock = 0.2f,
            staminaCost = 3f,
            meleeBleedChance = 0.1f,
            stunChance = 0.05f,
            condition = 100f,
            weight = 2.8f,
            isAutomatic = false,
            canFireWithoutAmmo = false,
            chamberCapacity = 0,
            attachments = null,
            developerNote = "Wooden bow. Uses steel arrows."
        },

        new RangedWeaponItem
        {
            weaponName = "Compound Bow",
            category = WeaponCategory.Bow,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.BroadheadArrow },
            fireRate = 0.8f,
            effectiveRange = 50f,
            recoil = 0.15f,
            accuracy = 0.90f,
            baseDamage = 22f,
            shock = 0.3f,
            force = 0.5f,
            pierce = 0.3f,
            bleedChance = 0.30f,
            electricShock = 0f,
            meleeRange = 1.0f,
            meleeDamage = 6f,
            meleeShock = 0.2f,
            staminaCost = 4f,
            meleeBleedChance = 0.15f,
            stunChance = 0.10f,
            condition = 100f,
            weight = 3.5f,
            isAutomatic = false,
            canFireWithoutAmmo = false,
            chamberCapacity = 0,
            attachments = new List<WeaponAttachment>
            {
                new WeaponAttachment
                {
                    attachmentName = "Carbon Sight",
                    type = AttachmentType.Sight,
                    statModifier = WeaponStatModifier.FromFloats(accuracy: 0.15f)
                }
            },
            developerNote = "Compound bow. Uses broadhead arrows."
        },

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
            shock = 0.4f,
            force = 0.6f,
            pierce = 0.3f,
            bleedChance = 0.25f,
            electricShock = 0f,
            meleeRange = 1.2f,
            meleeDamage = 10f,
            meleeShock = 0.3f,
            staminaCost = 6f,
            meleeBleedChance = 0.2f,
            stunChance = 0.3f,
            condition = 100f,
            weight = 2.0f,
            isAutomatic = false,
            canFireWithoutAmmo = true,
            chamberCapacity = 0,
            attachments = null,
            developerNote = "Thrown or swung. High bleed and stun."
        },

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
            shock = 0.1f,
            force = 0.2f,
            pierce = 0.2f,
            bleedChance = 0.10f,
            electricShock = 0f,
            meleeRange = 0.8f,
            meleeDamage = 3f,
            meleeShock = 0.1f,
            staminaCost = 2f,
            meleeBleedChance = 0.05f,
            stunChance = 0.05f,
            condition = 100f,
            weight = 0.5f,
            isAutomatic = false,
            canFireWithoutAmmo = true,
            chamberCapacity = 0,
            attachments = null,
            developerNote = "Silent and disposable. Low impact."
        },

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
            shock = 0.1f,
            force = 0.2f,
            pierce = 0.15f,
            bleedChance = 0.15f,
            electricShock = 0f,
            meleeRange = 0.6f,
            meleeDamage = 2f,
            meleeShock = 0.1f,
            staminaCost = 1f,
            meleeBleedChance = 0.05f,
            stunChance = 0.05f,
            condition = 100f,
            weight = 0.3f,
            isAutomatic = false,
            canFireWithoutAmmo = true,
            chamberCapacity = 0,
            attachments = null,
            developerNote = "Fast throw rate. Minimal melee fallback."
        },

        new RangedWeaponItem
        {
            weaponName = "Javelin",
            category = WeaponCategory.Thrown,
            compatibleAmmoTypes = null,
            fireRate = 0.5f,
            effectiveRange = 18f,
            recoil = 0f,
            accuracy = 0.80f,
            baseDamage = 24f,
            shock = 0.3f,
            force = 0.5f,
            pierce = 0.25f,
            bleedChance = 0.10f,
            electricShock = 0f,
            meleeRange = 1.2f,
            meleeDamage = 8f,
            meleeShock = 0.3f,
            staminaCost = 5f,
            meleeBleedChance = 0.1f,
            stunChance = 0.15f,
            condition = 100f,
            weight = 2.8f,
            isAutomatic = false,
            canFireWithoutAmmo = true,
            chamberCapacity = 0,
            attachments = null,
            developerNote = "Dual-purpose throw/melee weapon."
        },

        new RangedWeaponItem
        {
            weaponName = "Improvised Catapult",
            category = WeaponCategory.Thrown,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.Marble, AmmoType.Stone },
            fireRate = 0.3f,
            effectiveRange = 14f,
            recoil = 0.2f,
            accuracy = 0.45f,
            baseDamage = 18f,
            shock = 0.2f,
            force = 0.4f,
            pierce = 0.1f,
            bleedChance = 0.05f,
            electricShock = 0f,
            meleeRange = 0.4f,
            meleeDamage = 4f,
            meleeShock = 0.2f,
            staminaCost = 6f,
            meleeBleedChance = 0.05f,
            stunChance = 0.25f,
            condition = 100f,
            weight = 3.5f,
            isAutomatic = false,
            canFireWithoutAmmo = false,
            chamberCapacity = 0,
            attachments = null,
            developerNote = "Fires marbles and stones. Low tech, high charm."
        },

        new RangedWeaponItem
        {
            weaponName = "Steel Catapult",
            category = WeaponCategory.Thrown,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.Marble, AmmoType.Stone },
            fireRate = 0.6f,
            effectiveRange = 20f,
            recoil = 0.4f,
            accuracy = 0.70f,
            baseDamage = 28f,
            shock = 0.3f,
            force = 0.6f,
            pierce = 0.2f,
            bleedChance = 0.10f,
            electricShock = 0f,
            meleeRange = 0.5f,
            meleeDamage = 6f,
            meleeShock = 0.3f,
            staminaCost = 8f,
            meleeBleedChance = 0.1f,
            stunChance = 0.35f,
            condition = 100f,
            weight = 6.2f,
            isAutomatic = false,
            canFireWithoutAmmo = false,
            chamberCapacity = 0
        },

        new RangedWeaponItem
        {
            weaponName = "Rebetta 9M",
            category = WeaponCategory.Handgun,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType._9mm },
            fireRate = 0.25f,
            effectiveRange = 35f,
            recoil = 0.2f,
            accuracy = 0.85f,
            baseDamage = 22f,
            shock = 18f,
            force = 12f,
            pierce = 0.1f,
            bleedChance = 0.05f,
            electricShock = 0f,
            meleeRange = 1.2f,
            meleeDamage = 6f,
            meleeShock = 4f,
            staminaCost = 8f,
            meleeBleedChance = 0.02f,
            stunChance = 0.1f,
            condition = 100f,
            weight = 1.1f,
            isAutomatic = false,
            canFireWithoutAmmo = false,
            chamberCapacity = 1,
            attachments = new List<WeaponAttachment>
            {
                new WeaponAttachment
                {
                    attachmentName = "Rebetta Suppressor",
                    type = AttachmentType.Muzzle,
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0.1f,
                        recoil = -0.1f,
                        weight = 0.2f,
                        ammoCapacity = 0,
                        zoom = 1f
                    },
                    description = "Suppressor for the Rebetta 9M. Reduces noise and recoil at the cost of slight damage drop.",
                    loreTag = "Whispers louder than shouts."
                },
                new WeaponAttachment
                {
                    attachmentName = "Rebetta Reflex Sight",
                    type = AttachmentType.Optic,
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0.15f,
                        recoil = 0f,
                        weight = 0.1f,
                        ammoCapacity = 0,
                        zoom = 1.5f
                    },
                    description = "Compact reflex sight with a red dot reticle. Improves target acquisition.",
                    loreTag = "See before you're seen."
                },
                new WeaponAttachment
                {
                    attachmentName = "9mm Rebetta StandardMag_15Rnd",
                    type = AttachmentType.Magazine,
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0f,
                        recoil = 0f,
                        weight = 0.2f,
                        ammoCapacity = 15,
                        zoom = 1f
                    },
                    compatibleAmmoType = AmmoType._9mm,
                    description = "Standard 15-round detachable magazine for the Rebetta 9M. Polymer casing, visible round count, and a satisfying click when seated.",
                    loreTag = "More bullets, less breathing room."
                }
            },
            developerNote = "The Rebetta 9M is the survivor’s handshake—quiet, quick, and just enough to make someone reconsider. It can chamber a single round even without a magazine—an old trick known to desperate scavengers and last-stand romantics. The magazine itself is modular, swappable, and often found half-loaded in glove compartments."
        },

        new RangedWeaponItem
        {
            weaponName = "Wesmith & Smesson - PM9",
            category = WeaponCategory.Handgun,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType._9mm },
            fireRate = 0.25f,
            effectiveRange = 28f,
            recoil = 0.35f,
            accuracy = 0.82f,
            baseDamage = 24f,
            shock = 16f,
            force = 10f,
            pierce = 0.1f,
            bleedChance = 0.05f,
            electricShock = 0f,
            meleeRange = 1.0f,
            meleeDamage = 6f,
            meleeShock = 4f,
            staminaCost = 9f,
            meleeBleedChance = 0.02f,
            stunChance = 0.15f,
            condition = 100f,
            weight = 1.4f,
            isAutomatic = false,
            canFireWithoutAmmo = true,
            chamberCapacity = 1,
            attachments = new List<WeaponAttachment>
            {
                new WeaponAttachment
                {
                    attachmentName = "ReflexSight_MK1",
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0.10f,
                        recoil = 0f,
                        weight = 0.1f,
                        ammoCapacity = 0,
                        zoom = 1.1f
                    }
                },
                new WeaponAttachment
                {
                    attachmentName = "Suppressor_9mm_Lite",
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0f,
                        recoil = -0.10f,
                        weight = 0.2f,
                        ammoCapacity = 0,
                        zoom = 1.0f
                    }
                },
                new WeaponAttachment
                {
                    attachmentName = "Wesmith & Smesson - PM9 ExtendedMag_13Rnd",
                    compatibleAmmoType = AmmoType._9mm,
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0f,
                        recoil = 0f,
                        weight = 0.15f,
                        ammoCapacity = 13,
                        zoom = 1.0f
                    }
                },
                new WeaponAttachment
                {
                    attachmentName = "Wesmith & Smesson - PM9 StandardMag_10Rnd",
                    compatibleAmmoType = AmmoType._9mm,
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0f,
                        recoil = 0f,
                        weight = 0.15f,
                        ammoCapacity = 10,
                        zoom = 1.0f
                    }
                }
            }
        },

        new RangedWeaponItem
        {
            weaponName = "Gic S365",
            category = WeaponCategory.Handgun,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType._9mm },
            fireRate = 0.22f,
            effectiveRange = 26f,
            recoil = 0.38f,
            accuracy = 0.78f,
            baseDamage = 22f,
            shock = 15f,
            force = 9f,
            pierce = 0.08f,
            bleedChance = 0.04f,
            electricShock = 0f,
            meleeRange = 1.0f,
            meleeDamage = 5f,
            meleeShock = 3f,
            staminaCost = 8f,
            meleeBleedChance = 0.02f,
            stunChance = 0.12f,
            condition = 100f,
            weight = 1.3f,
            isAutomatic = false,
            canFireWithoutAmmo = true,
            chamberCapacity = 1,
            attachments = new List<WeaponAttachment>
            {
                new WeaponAttachment
                {
                    attachmentName = "ReflexSight_MK1",
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0.10f,
                        recoil = 0f,
                        weight = 0.1f,
                        ammoCapacity = 0,
                        zoom = 1.1f
                    }
                },
                new WeaponAttachment
                {
                    attachmentName = "Suppressor_9mm_Lite",
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0f,
                        recoil = -0.10f,
                        weight = 0.2f,
                        ammoCapacity = 0,
                        zoom = 1.0f
                    }
                },
                new WeaponAttachment
                {
                    attachmentName = "Gic S365 ExtendedMag_15Rnd",
                    compatibleAmmoType = AmmoType._9mm,
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0f,
                        recoil = 0f,
                        weight = 0.15f,
                        ammoCapacity = 15,
                        zoom = 1.0f
                    }
                },
                new WeaponAttachment
                {
                    attachmentName = "Gic S365 StandardMag_10Rnd",
                    compatibleAmmoType = AmmoType._9mm,
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0f,
                        recoil = 0f,
                        weight = 0.15f,
                        ammoCapacity = 10,
                        zoom = 1.0f
                    }
                }
            }
        },

        new RangedWeaponItem
        {
            weaponName = "Klock G 43",
            category = WeaponCategory.Handgun,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType._9mm },
            fireRate = 0.24f,
            effectiveRange = 25f,
            recoil = 0.40f,
            accuracy = 0.76f,
            baseDamage = 23f,
            shock = 15f,
            force = 9f,
            pierce = 0.09f,
            bleedChance = 0.04f,
            electricShock = 0f,
            meleeRange = 1.0f,
            meleeDamage = 5f,
            meleeShock = 3f,
            staminaCost = 8f,
            meleeBleedChance = 0.02f,
            stunChance = 0.10f,
            condition = 100f,
            weight = 1.2f,
            isAutomatic = false,
            canFireWithoutAmmo = true,
            chamberCapacity = 1,
            attachments = new List<WeaponAttachment>
            {
                new WeaponAttachment
                {
                    attachmentName = "ReflexSight_MK1",
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0.10f,
                        recoil = 0f,
                        weight = 0.1f,
                        ammoCapacity = 0,
                        zoom = 1.1f
                    }
                },
                new WeaponAttachment
                {
                    attachmentName = "Suppressor_9mm_Lite",
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0f,
                        recoil = -0.10f,
                        weight = 0.2f,
                        ammoCapacity = 0,
                        zoom = 1.0f
                    }
                },
                new WeaponAttachment
                {
                    attachmentName = "Klock G 43 StandardMag_6Rnd",
                    compatibleAmmoType = AmmoType._9mm,
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0f,
                        recoil = 0f,
                        weight = 0.1f,
                        ammoCapacity = 6,
                        zoom = 1.0f
                    }
                }
            }
        },

        new RangedWeaponItem
{
    weaponName = "Wemith & Smisson 29M",
    category = WeaponCategory.AirPistol,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType.Pellet_177_Lead },
    fireRate = 0.26f,
    effectiveRange = 18f,
    recoil = 0.28f,
    accuracy = 0.76f,
    baseDamage = 14f,
    shock = 9f,
    force = 4f,
    pierce = 0.04f,
    bleedChance = 0.015f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 5f,
    meleeShock = 2f,
    staminaCost = 6f,
    meleeBleedChance = 0.015f,
    stunChance = 0.07f,
    condition = 100f,
    weight = 1.2f,
    isAutomatic = false,
    canFireWithoutAmmo = true,
    chamberCapacity = 6,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "RevolverDot_177_MK1",
            compatibleAmmoType = AmmoType.Pellet_177_Lead,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.08f,
                recoil = 0f,
                weight = 0.07f,
                ammoCapacity = 0,
                zoom = 1.1f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "RevolverSuppressor_177_MicroLite",
            compatibleAmmoType = AmmoType.Pellet_177_Lead,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = -0.06f,
                weight = 0.14f,
                ammoCapacity = 0,
                zoom = 1.0f
            }
        }
    }
},

        new RangedWeaponItem
{
    weaponName = "Klock P71",
    category = WeaponCategory.AirPistol,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType.Pellet_22_Lead },
    fireRate = 0.20f,
    effectiveRange = 22f,
    recoil = 0.24f,
    accuracy = 0.80f,
    baseDamage = 14f,
    shock = 9f,
    force = 4f,
    pierce = 0.04f,
    bleedChance = 0.015f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 4f,
    meleeShock = 2f,
    staminaCost = 6f,
    meleeBleedChance = 0.01f,
    stunChance = 0.06f,
    condition = 100f,
    weight = 1.0f,
    isAutomatic = false,
    canFireWithoutAmmo = true,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "MicroDot_22_MK1",
            compatibleAmmoType = AmmoType.Pellet_22_Lead,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.10f,
                recoil = 0f,
                weight = 0.08f,
                ammoCapacity = 0,
                zoom = 1.15f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "Suppressor_22_StealthLite",
            compatibleAmmoType = AmmoType.Pellet_22_Lead,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = -0.08f,
                weight = 0.14f,
                ammoCapacity = 0,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "Klock P71 StandardMag_12Rnd",
            compatibleAmmoType = AmmoType.Pellet_22_Lead,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.12f,
                ammoCapacity = 12,
                zoom = 1.0f
            }
        }
    }
},

        new RangedWeaponItem
{
    weaponName = "Rebetta MFS 93 Tactical",
    category = WeaponCategory.AirPistol,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType.Pellet_22_Lead },
    fireRate = 0.22f,
    effectiveRange = 25f,
    recoil = 0.26f,
    accuracy = 0.78f,
    baseDamage = 16f,
    shock = 10f,
    force = 5f,
    pierce = 0.05f,
    bleedChance = 0.02f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 5f,
    meleeShock = 2f,
    staminaCost = 7f,
    meleeBleedChance = 0.02f,
    stunChance = 0.08f,
    condition = 100f,
    weight = 1.1f,
    isAutomatic = false,
    canFireWithoutAmmo = true,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "MicroDot_22_MK2",
            compatibleAmmoType = AmmoType.Pellet_22_Lead,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.10f,
                recoil = 0f,
                weight = 0.09f,
                ammoCapacity = 0,
                zoom = 1.2f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "Suppressor_22_TacticalLite",
            compatibleAmmoType = AmmoType.Pellet_22_Lead,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = -0.1f,
                weight = 0.18f,
                ammoCapacity = 0,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "Rebetta MFS 93 ExtendedMag_12Rnd",
            compatibleAmmoType = AmmoType.Pellet_22_Lead,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.12f,
                ammoCapacity = 12,
                zoom = 1.0f
            }
        }
    }
},

        new RangedWeaponItem
{
    weaponName = "Chinwester 54R",
    category = WeaponCategory.AirRifle,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType.Pellet_22_Lead },
    fireRate = 0.80f,
    effectiveRange = 38f,
    recoil = 0.18f,
    accuracy = 0.92f,
    baseDamage = 18f,
    shock = 12f,
    force = 5f,
    pierce = 0.06f,
    bleedChance = 0.02f,
    electricShock = 0f,
    meleeRange = 1.2f,
    meleeDamage = 5f,
    meleeShock = 3f,
    staminaCost = 7f,
    meleeBleedChance = 0.015f,
    stunChance = 0.08f,
    condition = 100f,
    weight = 2.4f,
    isAutomatic = false,
    canFireWithoutAmmo = true,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "54R PrecisionScope_MK2",
            compatibleAmmoType = AmmoType.Pellet_22_Lead,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.12f,
                recoil = 0f,
                weight = 0.22f,
                ammoCapacity = 0,
                zoom = 1.35f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "54R BarrelSilencer_Lite",
            compatibleAmmoType = AmmoType.Pellet_22_Lead,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = -0.06f,
                weight = 0.18f,
                ammoCapacity = 0,
                zoom = 1.0f
            }
        }
    }
},

        new RangedWeaponItem
{
    weaponName = "Rat Hunter 2002",
    category = WeaponCategory.AirRifle,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType.Pellet_22_Lead },
    fireRate = 0.75f,
    effectiveRange = 35f,
    recoil = 0.16f,
    accuracy = 0.88f,
    baseDamage = 16f,
    shock = 11f,
    force = 4f,
    pierce = 0.05f,
    bleedChance = 0.018f,
    electricShock = 0f,
    meleeRange = 1.1f,
    meleeDamage = 4f,
    meleeShock = 2f,
    staminaCost = 6f,
    meleeBleedChance = 0.012f,
    stunChance = 0.07f,
    condition = 100f,
    weight = 2.1f,
    isAutomatic = false,
    canFireWithoutAmmo = true,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "RatHunter ReflexDot_MK1",
            compatibleAmmoType = AmmoType.Pellet_22_Lead,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.08f,
                recoil = 0f,
                weight = 0.10f,
                ammoCapacity = 0,
                zoom = 1.2f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "RatHunter BarrelWrap_Suppressor",
            compatibleAmmoType = AmmoType.Pellet_22_Lead,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = -0.05f,
                weight = 0.16f,
                ammoCapacity = 0,
                zoom = 1.0f
            }
        }
    }
},

        new RangedWeaponItem
{
    weaponName = "Oxrus RT22",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._22LR },
    fireRate = 0.18f,
    effectiveRange = 28f,
    recoil = 0.22f,
    accuracy = 0.85f,
    baseDamage = 17f,
    shock = 10f,
    force = 5f,
    pierce = 0.07f,
    bleedChance = 0.025f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 4f,
    meleeShock = 2f,
    staminaCost = 6f,
    meleeBleedChance = 0.01f,
    stunChance = 0.06f,
    condition = 100f,
    weight = 1.2f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "RT22 StandardMag_16Rnd",
            compatibleAmmoType = AmmoType._22LR,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.10f,
                ammoCapacity = 16,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "RT22 ExtendedMag_22Rnd",
            compatibleAmmoType = AmmoType._22LR,
            statModifier = new WeaponStatModifier
            {
                accuracy = -0.02f,
                recoil = 0.02f,
                weight = 0.16f,
                ammoCapacity = 22,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "RT22 ReflexSight_MK1",
            compatibleAmmoType = AmmoType._22LR,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.10f,
                recoil = 0f,
                weight = 0.08f,
                ammoCapacity = 0,
                zoom = 1.25f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "Browners BMP XRU",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._22LR },
    fireRate = 0.16f,
    effectiveRange = 26f,
    recoil = 0.20f,
    accuracy = 0.83f,
    baseDamage = 16f,
    shock = 9f,
    force = 4f,
    pierce = 0.06f,
    bleedChance = 0.022f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 3f,
    meleeShock = 2f,
    staminaCost = 5f,
    meleeBleedChance = 0.01f,
    stunChance = 0.05f,
    condition = 100f,
    weight = 1.1f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "BMP StandardMag_10Rnd",
            compatibleAmmoType = AmmoType._22LR,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.09f,
                ammoCapacity = 10,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "BMP ReflexSight_MK1",
            compatibleAmmoType = AmmoType._22LR,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.09f,
                recoil = 0f,
                weight = 0.07f,
                ammoCapacity = 0,
                zoom = 1.2f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "BMP BarrelSuppressor_Lite",
            compatibleAmmoType = AmmoType._22LR,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = -0.04f,
                weight = 0.13f,
                ammoCapacity = 0,
                zoom = 1.0f
            }
        }
    }
},




        new RangedWeaponItem
        {
            weaponName = "Rebetta MFS 92",
            category = WeaponCategory.AirPistol,
            compatibleAmmoTypes = new List<AmmoType> { AmmoType.Pellet_177_Lead },
            fireRate = 0.18f,
            effectiveRange = 20f,
            recoil = 0.22f,
            accuracy = 0.82f,
            baseDamage = 12f,
            shock = 8f,
            force = 4f,
            pierce = 0.03f,
            bleedChance = 0.01f,
            electricShock = 0f,
            meleeRange = 1.0f,
            meleeDamage = 4f,
            meleeShock = 2f,
            staminaCost = 6f,
            meleeBleedChance = 0.01f,
            stunChance = 0.06f,
            condition = 100f,
            weight = 0.9f,
            isAutomatic = false,
            canFireWithoutAmmo = true,
            chamberCapacity = 1,
            attachments = new List<WeaponAttachment>
            {
                new WeaponAttachment
                {
                    attachmentName = "MicroDot_177_MK1",
                    compatibleAmmoType = AmmoType.Pellet_177_Lead,
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0.12f,
                        recoil = 0f,
                        weight = 0.08f,
                        ammoCapacity = 0,
                        zoom = 1.15f
                    }
                },
                new WeaponAttachment
                {
                    attachmentName = "Suppressor_177_StealthLite",
                    compatibleAmmoType = AmmoType.Pellet_177_Lead,
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0f,
                        recoil = -0.08f,
                        weight = 0.15f,
                        ammoCapacity = 0,
                        zoom = 1.0f
                    }
                },
                                new WeaponAttachment
                {
                    attachmentName = "Rebetta MFS 92 StandardMag_8Rnd",
                    compatibleAmmoType = AmmoType.Pellet_177_Lead,
                    statModifier = new WeaponStatModifier
                    {
                        accuracy = 0f,
                        recoil = 0f,
                        weight = 0.1f,
                        ammoCapacity = 8,
                        zoom = 1.0f
                    }
                }
            }
        },
        new RangedWeaponItem
{
    weaponName = "Gic P320 Comp",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._10mm },
    fireRate = 0.14f,
    effectiveRange = 32f,
    recoil = 0.30f,
    accuracy = 0.82f,
    baseDamage = 24f,
    shock = 15f,
    force = 7f,
    pierce = 0.10f,
    bleedChance = 0.035f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 5f,
    meleeShock = 3f,
    staminaCost = 7f,
    meleeBleedChance = 0.015f,
    stunChance = 0.08f,
    condition = 100f,
    weight = 1.4f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "P320 StandardMag_15Rnd",
            compatibleAmmoType = AmmoType._10mm,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.12f,
                ammoCapacity = 15,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "P320 ExtendedMag_18Rnd",
            compatibleAmmoType = AmmoType._10mm,
            statModifier = new WeaponStatModifier
            {
                accuracy = -0.02f,
                recoil = 0.03f,
                weight = 0.18f,
                ammoCapacity = 18,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "P320 Compensator_XRU",
            compatibleAmmoType = AmmoType._10mm,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.06f,
                recoil = -0.05f,
                weight = 0.14f,
                ammoCapacity = 0,
                zoom = 1.0f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "Wemith & Smisson M610",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._10mm },
    fireRate = 0.20f,
    effectiveRange = 30f,
    recoil = 0.34f,
    accuracy = 0.80f,
    baseDamage = 26f,
    shock = 16f,
    force = 8f,
    pierce = 0.12f,
    bleedChance = 0.04f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 5f,
    meleeShock = 3f,
    staminaCost = 7f,
    meleeBleedChance = 0.015f,
    stunChance = 0.09f,
    condition = 100f,
    weight = 1.6f,
    isAutomatic = false,
    canFireWithoutAmmo = true,
    chamberCapacity = 6,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "M610 ReflexDot_MK1",
            compatibleAmmoType = AmmoType._10mm,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.08f,
                recoil = 0f,
                weight = 0.10f,
                ammoCapacity = 0,
                zoom = 1.2f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "M610 BarrelSuppressor_Heavy",
            compatibleAmmoType = AmmoType._10mm,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = -0.06f,
                weight = 0.20f,
                ammoCapacity = 0,
                zoom = 1.0f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "Springrass DXM",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._10mm },
    fireRate = 0.16f,
    effectiveRange = 35f,
    recoil = 0.28f,
    accuracy = 0.85f,
    baseDamage = 24f,
    shock = 14f,
    force = 7f,
    pierce = 0.10f,
    bleedChance = 0.03f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 4f,
    meleeShock = 2f,
    staminaCost = 6f,
    meleeBleedChance = 0.01f,
    stunChance = 0.07f,
    condition = 100f,
    weight = 1.4f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "DXM StandardMag_12Rnd",
            compatibleAmmoType = AmmoType._10mm,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.12f,
                ammoCapacity = 12,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "DXM SlideCompensator_MK2",
            compatibleAmmoType = AmmoType._10mm,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.06f,
                recoil = -0.04f,
                weight = 0.15f,
                ammoCapacity = 0,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "DXM TacticalLaser_Redline",
            compatibleAmmoType = AmmoType._10mm,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.10f,
                recoil = 0f,
                weight = 0.05f,
                ammoCapacity = 0,
                zoom = 1.0f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "Klock 82G",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._380ACP },
    fireRate = 0.18f,
    effectiveRange = 28f,
    recoil = 0.22f,
    accuracy = 0.82f,
    baseDamage = 20f,
    shock = 12f,
    force = 6f,
    pierce = 0.08f,
    bleedChance = 0.025f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 3f,
    meleeShock = 1f,
    staminaCost = 5f,
    meleeBleedChance = 0.01f,
    stunChance = 0.05f,
    condition = 100f,
    weight = 1.2f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "K82G StandardMag_8Rnd",
            compatibleAmmoType = AmmoType._380ACP,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.10f,
                ammoCapacity = 8,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "K82G ExtendedMag_11Rnd",
            compatibleAmmoType = AmmoType._380ACP,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.14f,
                ammoCapacity = 11,
                zoom = 1.0f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "Springrass 911",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._380ACP },
    fireRate = 0.14f,
    effectiveRange = 25f,
    recoil = 0.20f,
    accuracy = 0.78f,
    baseDamage = 18f,
    shock = 10f,
    force = 5f,
    pierce = 0.07f,
    bleedChance = 0.02f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 3f,
    meleeShock = 1f,
    staminaCost = 5f,
    meleeBleedChance = 0.01f,
    stunChance = 0.04f,
    condition = 100f,
    weight = 1.1f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "S911 StandardMag_6Rnd",
            compatibleAmmoType = AmmoType._380ACP,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.08f,
                ammoCapacity = 6,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "S911 ExtendedMag_8Rnd",
            compatibleAmmoType = AmmoType._380ACP,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.11f,
                ammoCapacity = 8,
                zoom = 1.0f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "Arachnida ZV61",
    category = WeaponCategory.SMG,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._380ACP },
    fireRate = 0.08f,
    effectiveRange = 40f,
    recoil = 0.30f,
    accuracy = 0.76f,
    baseDamage = 19f,
    shock = 11f,
    force = 6f,
    pierce = 0.09f,
    bleedChance = 0.025f,
    electricShock = 0f,
    meleeRange = 1.2f,
    meleeDamage = 4f,
    meleeShock = 2f,
    staminaCost = 6f,
    meleeBleedChance = 0.01f,
    stunChance = 0.06f,
    condition = 100f,
    weight = 2.3f,
    isAutomatic = true,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "ZV61 StandardMag_20Rnd",
            compatibleAmmoType = AmmoType._380ACP,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.18f,
                ammoCapacity = 20,
                zoom = 1.0f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "CM LOK Dissed Mk4",
    category = WeaponCategory.SMG,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._9mm },
    fireRate = 0.07f,
    effectiveRange = 45f,
    recoil = 0.32f,
    accuracy = 0.74f,
    baseDamage = 21f,
    shock = 13f,
    force = 6f,
    pierce = 0.10f,
    bleedChance = 0.03f,
    electricShock = 0f,
    meleeRange = 1.2f,
    meleeDamage = 4f,
    meleeShock = 2f,
    staminaCost = 6f,
    meleeBleedChance = 0.01f,
    stunChance = 0.06f,
    condition = 100f,
    weight = 2.6f,
    isAutomatic = true,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "DissedMk4 StandardMag_30Rnd",
            compatibleAmmoType = AmmoType._9mm,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.22f,
                ammoCapacity = 30,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "DissedMk4 ExtendedMag_38Rnd",
            compatibleAmmoType = AmmoType._9mm,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.28f,
                ammoCapacity = 38,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "DissedMk4 TacticalCompensator_MK1",
            compatibleAmmoType = AmmoType._9mm,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.08f,
                recoil = -0.05f,
                weight = 0.16f,
                ammoCapacity = 0,
                zoom = 1.0f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "KnH 5MP",
    category = WeaponCategory.SMG,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._10mm },
    fireRate = 0.065f,
    effectiveRange = 40f,
    recoil = 0.38f,
    accuracy = 0.70f,
    baseDamage = 26f,
    shock = 15f,
    force = 7f,
    pierce = 0.12f,
    bleedChance = 0.06f,
    electricShock = 0f,
    meleeRange = 1.1f,
    meleeDamage = 5f,
    meleeShock = 2f,
    staminaCost = 7f,
    meleeBleedChance = 0.02f,
    stunChance = 0.07f,
    condition = 100f,
    weight = 2.9f,
    isAutomatic = true,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "KnH5MP Mag_25Rnd",
            compatibleAmmoType = AmmoType._10mm,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.26f,
                ammoCapacity = 25,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "KnH5MP MuzzleBrake_MK2",
            compatibleAmmoType = AmmoType._10mm,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.06f,
                recoil = -0.04f,
                weight = 0.18f,
                ammoCapacity = 0,
                zoom = 1.0f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "Gic XCM Rattlesnake",
    category = WeaponCategory.SMG,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._300_AAC_Blackout },
    fireRate = 0.075f,
    effectiveRange = 55f,
    recoil = 0.42f,
    accuracy = 0.72f,
    baseDamage = 29f,
    shock = 17f,
    force = 8f,
    pierce = 0.14f,
    bleedChance = 0.07f,
    electricShock = 0f,
    meleeRange = 1.2f,
    meleeDamage = 6f,
    meleeShock = 3f,
    staminaCost = 8f,
    meleeBleedChance = 0.03f,
    stunChance = 0.08f,
    condition = 100f,
    weight = 3.2f,
    isAutomatic = true,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "Rattlesnake Mag_30Rnd",
            compatibleAmmoType = AmmoType._300_AAC_Blackout,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.30f,
                ammoCapacity = 30,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "Rattlesnake Suppressor_XCM",
            compatibleAmmoType = AmmoType._300_AAC_Blackout,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.05f,
                recoil = -0.06f,
                weight = 0.22f,
                ammoCapacity = 0,
                zoom = 1.0f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "Spingreen Priest",
    category = WeaponCategory.AR_Pistol,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._300_AAC_Blackout },
    fireRate = 0.08f,
    effectiveRange = 60f,
    recoil = 0.45f,
    accuracy = 0.75f,
    baseDamage = 31f,
    shock = 18f,
    force = 9f,
    pierce = 0.15f,
    bleedChance = 0.08f,
    electricShock = 0f,
    meleeRange = 1.3f,
    meleeDamage = 6f,
    meleeShock = 3f,
    staminaCost = 9f,
    meleeBleedChance = 0.03f,
    stunChance = 0.09f,
    condition = 100f,
    weight = 3.4f,
    isAutomatic = true,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "Priest Mag_30Rnd",
            compatibleAmmoType = AmmoType._300_AAC_Blackout,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.32f,
                ammoCapacity = 30,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "Priest TacticalFlashlight_MK1",
            compatibleAmmoType = AmmoType._300_AAC_Blackout,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0.02f,
                recoil = 0f,
                weight = 0.14f,
                ammoCapacity = 0,
                zoom = 1.0f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "KnH KH45v1",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._45_ACP },
    fireRate = 0.18f,
    effectiveRange = 35f,
    recoil = 0.52f,
    accuracy = 0.68f,
    baseDamage = 34f,
    shock = 20f,
    force = 10f,
    pierce = 0.10f,
    bleedChance = 0.05f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 5f,
    meleeShock = 2f,
    staminaCost = 7f,
    meleeBleedChance = 0.02f,
    stunChance = 0.07f,
    condition = 100f,
    weight = 2.2f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "KH45v1 Mag_10Rnd",
            compatibleAmmoType = AmmoType._45_ACP,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.18f,
                ammoCapacity = 10,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "KH45v1 Mag_15Rnd_Extended",
            compatibleAmmoType = AmmoType._45_ACP,
            statModifier = new WeaponStatModifier
            {
                accuracy = -0.01f,
                recoil = 0.02f,
                weight = 0.24f,
                ammoCapacity = 15,
                zoom = 1.0f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "Rimbek ORK211",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._45_ACP },
    fireRate = 0.16f,
    effectiveRange = 38f,
    recoil = 0.50f,
    accuracy = 0.70f,
    baseDamage = 33f,
    shock = 19f,
    force = 9f,
    pierce = 0.11f,
    bleedChance = 0.06f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 5f,
    meleeShock = 2f,
    staminaCost = 7f,
    meleeBleedChance = 0.02f,
    stunChance = 0.08f,
    condition = 100f,
    weight = 2.3f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "ORK211 Mag_13Rnd",
            compatibleAmmoType = AmmoType._45_ACP,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.20f,
                ammoCapacity = 13,
                zoom = 1.0f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "Klock CG21 Gen 3",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._45_ACP },
    fireRate = 0.17f,
    effectiveRange = 37f,
    recoil = 0.48f,
    accuracy = 0.72f,
    baseDamage = 32f,
    shock = 18f,
    force = 9f,
    pierce = 0.11f,
    bleedChance = 0.05f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 5f,
    meleeShock = 2f,
    staminaCost = 7f,
    meleeBleedChance = 0.02f,
    stunChance = 0.07f,
    condition = 100f,
    weight = 2.1f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "CG21 Mag_13Rnd",
            compatibleAmmoType = AmmoType._45_ACP,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.19f,
                ammoCapacity = 13,
                zoom = 1.0f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "Klock 33G3",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._357 },
    fireRate = 0.15f,
    effectiveRange = 40f,
    recoil = 0.55f,
    accuracy = 0.74f,
    baseDamage = 36f,
    shock = 21f,
    force = 10f,
    pierce = 0.13f,
    bleedChance = 0.06f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 5f,
    meleeShock = 2f,
    staminaCost = 7f,
    meleeBleedChance = 0.02f,
    stunChance = 0.08f,
    condition = 100f,
    weight = 2.4f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "K33G3 Mag_9Rnd",
            compatibleAmmoType = AmmoType._357,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.20f,
                ammoCapacity = 9,
                zoom = 1.0f
            }
        },
        new WeaponAttachment
        {
            attachmentName = "K33G3 Mag_12Rnd_Extended",
            compatibleAmmoType = AmmoType._357,
            statModifier = new WeaponStatModifier
            {
                accuracy = -0.01f,
                recoil = 0.02f,
                weight = 0.26f,
                ammoCapacity = 12,
                zoom = 1.0f
            }
        }
    }
},
        new RangedWeaponItem
{
    weaponName = "Gic 19BD11",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._357 },
    fireRate = 0.18f,
    effectiveRange = 35f,
    recoil = 0.60f,
    accuracy = 0.70f,
    baseDamage = 34f,
    shock = 20f,
    force = 9f,
    pierce = 0.11f,
    bleedChance = 0.05f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 4f,
    meleeShock = 1f,
    staminaCost = 6f,
    meleeBleedChance = 0.01f,
    stunChance = 0.07f,
    condition = 100f,
    weight = 2.2f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "G19BD11 Mag_9Rnd",
            compatibleAmmoType = AmmoType._357,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.22f,
                ammoCapacity = 9,
                zoom = 1.0f
            }
        }
    }
},
new RangedWeaponItem
{
    weaponName = "Oxrus 69",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._357 },
    fireRate = 0.22f,
    effectiveRange = 45f,
    recoil = 0.68f,
    accuracy = 0.76f,
    baseDamage = 38f,
    shock = 23f,
    force = 11f,
    pierce = 0.15f,
    bleedChance = 0.07f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 6f,
    meleeShock = 2f,
    staminaCost = 8f,
    meleeBleedChance = 0.03f,
    stunChance = 0.09f,
    condition = 100f,
    weight = 2.6f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 6,
    attachments = new List<WeaponAttachment>() // Revolver: no magazine attachments
},
new RangedWeaponItem
{
    weaponName = "Oxrus 44M",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._44 },
    fireRate = 0.25f,
    effectiveRange = 50f,
    recoil = 0.72f,
    accuracy = 0.78f,
    baseDamage = 42f,
    shock = 26f,
    force = 12f,
    pierce = 0.18f,
    bleedChance = 0.08f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 7f,
    meleeShock = 3f,
    staminaCost = 9f,
    meleeBleedChance = 0.04f,
    stunChance = 0.10f,
    condition = 100f,
    weight = 2.9f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 6,
    attachments = new List<WeaponAttachment>() // No attachments
},
new RangedWeaponItem
{
    weaponName = "Wemith & Smisson 629 Invisible",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._44 },
    fireRate = 0.28f,
    effectiveRange = 48f,
    recoil = 0.70f,
    accuracy = 0.80f,
    baseDamage = 40f,
    shock = 24f,
    force = 11f,
    pierce = 0.16f,
    bleedChance = 0.07f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 6f,
    meleeShock = 2f,
    staminaCost = 8f,
    meleeBleedChance = 0.03f,
    stunChance = 0.09f,
    condition = 100f,
    weight = 2.7f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 5,
    attachments = new List<WeaponAttachment>() // No magazine attachments
},
new RangedWeaponItem
{
    weaponName = "MR DHawk XIX",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._50_AE },
    fireRate = 0.26f,
    effectiveRange = 60f,
    recoil = 0.88f,
    accuracy = 0.70f,
    baseDamage = 50f,
    shock = 28f,
    force = 14f,
    pierce = 0.20f,
    bleedChance = 0.09f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 7f,
    meleeShock = 3f,
    staminaCost = 10f,
    meleeBleedChance = 0.04f,
    stunChance = 0.11f,
    condition = 100f,
    weight = 3.1f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "DHawkXIX Mag_7Rnd",
            compatibleAmmoType = AmmoType._50_AE,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.28f,
                ammoCapacity = 7,
                zoom = 1.0f
            }
        }
    }
},
new RangedWeaponItem
{
    weaponName = "MR XFalcon L5",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._357 },
    fireRate = 0.22f,
    effectiveRange = 55f,
    recoil = 0.72f,
    accuracy = 0.76f,
    baseDamage = 42f,
    shock = 24f,
    force = 11f,
    pierce = 0.18f,
    bleedChance = 0.07f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 6f,
    meleeShock = 2f,
    staminaCost = 9f,
    meleeBleedChance = 0.03f,
    stunChance = 0.09f,
    condition = 100f,
    weight = 2.6f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "XFalconL5 Mag_7Rnd",
            compatibleAmmoType = AmmoType._357,
            statModifier = new WeaponStatModifier
            {
                accuracy = 0f,
                recoil = 0f,
                weight = 0.24f,
                ammoCapacity = 7,
                zoom = 1.0f
            }
        }
    }
},
new RangedWeaponItem
{
    weaponName = "Chinwester M37 Short",
    category = WeaponCategory.Rifle,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._357 },
    fireRate = 0.38f,
    effectiveRange = 90f,
    recoil = 0.58f,
    accuracy = 0.74f,
    baseDamage = 46f,
    shock = 26f,
    force = 12f,
    pierce = 0.22f,
    bleedChance = 0.08f,
    electricShock = 0f,
    meleeRange = 1.2f,
    meleeDamage = 8f,
    meleeShock = 3f,
    staminaCost = 11f,
    meleeBleedChance = 0.04f,
    stunChance = 0.12f,
    condition = 100f,
    weight = 3.9f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 10,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "M37 Quickloader",
            compatibleAmmoType = AmmoType._357,
            statModifier = new WeaponStatModifier
            {
                reloadModifier = 0.85f, // 15% faster reload
                weight = 0.18f,
                accuracy = 0f,
                recoil = 0f,
                zoom = 1.0f,
                ammoCapacity = 0
            },
            type = AttachmentType.Magazine,
            description = "Speeds up reload cycles for internal tube-fed rifles.",
            loreTag = "Riverfolk mod"
        }
    }
},
new RangedWeaponItem
{
    weaponName = "Chinwester 1873 DS",
    category = WeaponCategory.Rifle,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._357 },
    fireRate = 0.36f,
    effectiveRange = 95f,
    recoil = 0.56f,
    accuracy = 0.72f,
    baseDamage = 44f,
    shock = 25f,
    force = 11f,
    pierce = 0.20f,
    bleedChance = 0.07f,
    electricShock = 0f,
    meleeRange = 1.2f,
    meleeDamage = 8f,
    meleeShock = 3f,
    staminaCost = 11f,
    meleeBleedChance = 0.04f,
    stunChance = 0.11f,
    condition = 100f,
    weight = 4.1f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 14,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "1873 Quickloader",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._357,
            statModifier = new WeaponStatModifier
            {
                reloadModifier = 0.80f, // 20% faster reload
                weight = 0.20f,
                accuracy = 0f,
                recoil = 0f,
                zoom = 1.0f,
                ammoCapacity = 0
            },
            description = "Speeds up reload cycles for tube-fed lever rifles.",
            loreTag = "Frontier mod"
        }
    },
    developerNote = "Internal tube-fed lever rifle. No external mags. Quickloader boosts reload speed."
},
new RangedWeaponItem
{
    weaponName = "Chinwester PRX 300",
    category = WeaponCategory.Rifle,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._Win_300 },
    fireRate = 0.90f,
    effectiveRange = 150f,
    recoil = 0.66f,
    accuracy = 0.90f,
    baseDamage = 68f,
    shock = 36f,
    force = 19f,
    pierce = 0.34f,
    bleedChance = 0.13f,
    electricShock = 0f,
    meleeRange = 1.2f,
    meleeDamage = 9f,
    meleeShock = 3f,
    staminaCost = 12f,
    meleeBleedChance = 0.05f,
    stunChance = 0.14f,
    condition = 100f,
    weight = 4.4f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "PRX300 Clip_3Rnd",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._Win_300,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 3,
                weight: 0.30f
            ),
            description = "Standard 3-round hunting clip.",
            loreTag = "Field issue"
        },
        new WeaponAttachment
        {
            attachmentName = "PRX300 Clip_6Rnd_Extended",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._Win_300,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 6,
                weight: 0.42f,
                recoil: 0.02f,
                accuracy: -0.01f
            ),
            description = "Extended 6-round clip for sustained hunting.",
            loreTag = "Ridgewalker mod"
        },
        new WeaponAttachment
        {
            attachmentName = "PRX300 Silencer",
            type = AttachmentType.Muzzle,
            statModifier = WeaponStatModifier.FromFloats(
                recoil: -0.05f,
                accuracy: 0.03f,
                weight: 0.26f
            ),
            description = "Suppresses muzzle flash and sound signature.",
            loreTag = "Quiet kill"
        },
        new WeaponAttachment
        {
            attachmentName = "PRX300 Scope_Hunting",
            type = AttachmentType.Optic,
            statModifier = WeaponStatModifier.FromFloats(
                zoom: 2.5f,
                accuracy: 0.06f,
                recoil: -0.03f,
                weight: 0.38f
            ),
            description = "Precision hunting scope with 2.5x zoom.",
            loreTag = "Longshot"
        }
    },
    developerNote = "Bolt-action hunting rifle with modular clip, optic, and muzzle support. Built for stealth and precision."
},
new RangedWeaponItem
{
    weaponName = "Gic Plus 300",
    category = WeaponCategory.Rifle,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._Win_300 },
    fireRate = 0.85f,
    effectiveRange = 160f,
    recoil = 0.62f,
    accuracy = 0.92f,
    baseDamage = 72f,
    shock = 38f,
    force = 20f,
    pierce = 0.36f,
    bleedChance = 0.14f,
    electricShock = 0f,
    meleeRange = 1.2f,
    meleeDamage = 10f,
    meleeShock = 3f,
    staminaCost = 13f,
    meleeBleedChance = 0.06f,
    stunChance = 0.15f,
    condition = 100f,
    weight = 4.6f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "Gic300 Clip_6Rnd",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._Win_300,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 6,
                weight: 0.35f
            ),
            description = "Standard 6-round clip for field use.",
            loreTag = "Gic factory issue"
        },
        new WeaponAttachment
        {
            attachmentName = "Gic300 Clip_8Rnd_Extended",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._Win_300,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 8,
                weight: 0.48f,
                recoil: 0.03f,
                accuracy: -0.02f
            ),
            description = "Extended clip for prolonged engagements.",
            loreTag = "Overwatch mod"
        },
        new WeaponAttachment
        {
            attachmentName = "Gic300 Silencer",
            type = AttachmentType.Muzzle,
            statModifier = WeaponStatModifier.FromFloats(
                recoil: -0.06f,
                accuracy: 0.04f,
                weight: 0.28f
            ),
            description = "Suppresses muzzle flash and dampens sound.",
            loreTag = "Ghostline"
        },
        new WeaponAttachment
        {
            attachmentName = "Gic300 Scope_S-Scope_6x24",
            type = AttachmentType.Optic,
            statModifier = WeaponStatModifier.FromFloats(
                zoom: 6.0f,
                accuracy: 0.08f,
                recoil: -0.04f,
                weight: 0.42f
            ),
            description = "High-magnification scope for long-range targeting.",
            loreTag = "Sniper’s eye"
        },
        new WeaponAttachment
        {
            attachmentName = "Gic300 Scope_Hunting",
            type = AttachmentType.Optic,
            statModifier = WeaponStatModifier.FromFloats(
                zoom: 2.5f,
                accuracy: 0.06f,
                recoil: -0.03f,
                weight: 0.38f
            ),
            description = "Mid-range hunting scope for tracking game.",
            loreTag = "Trailwatch"
        }
    },
    developerNote = "Precision bolt-action rifle with modular optics and clip options. Built for overwatch and stealth takedowns."
},
new RangedWeaponItem
{
    weaponName = "Browners X-Bolt",
    category = WeaponCategory.Rifle,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._Win_300 },
    fireRate = 0.80f,
    effectiveRange = 140f,
    recoil = 0.58f,
    accuracy = 0.88f,
    baseDamage = 66f,
    shock = 34f,
    force = 18f,
    pierce = 0.32f,
    bleedChance = 0.12f,
    electricShock = 0f,
    meleeRange = 1.1f,
    meleeDamage = 8f,
    meleeShock = 2f,
    staminaCost = 11f,
    meleeBleedChance = 0.04f,
    stunChance = 0.12f,
    condition = 100f,
    weight = 4.0f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 3,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "XBolt Silencer",
            type = AttachmentType.Muzzle,
            statModifier = WeaponStatModifier.FromFloats(
                recoil: -0.05f,
                accuracy: 0.03f,
                weight: 0.24f
            ),
            description = "Low-profile silencer for stealth operations.",
            loreTag = "Whisperline"
        }
    },
    developerNote = "No mags, no drama. Internal 3-round chamber keeps it clean. Built for quiet precision."
},
new RangedWeaponItem
{
    weaponName = "CM Endor Mk3",
    category = WeaponCategory.AssaultRifle,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._308 },
    fireRate = 0.12f, // Full-auto rate
    effectiveRange = 110f,
    recoil = 0.72f,
    accuracy = 0.84f,
    baseDamage = 54f,
    shock = 28f,
    force = 16f,
    pierce = 0.28f,
    bleedChance = 0.10f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 7f,
    meleeShock = 2f,
    staminaCost = 10f,
    meleeBleedChance = 0.03f,
    stunChance = 0.10f,
    condition = 100f,
    weight = 4.8f,
    isAutomatic = true,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "EndorMk3 Clip_20Rnd",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._308,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 20,
                weight: 0.40f
            ),
            description = "Standard 20-round clip for sustained fire.",
            loreTag = "CM issue"
        },
        new WeaponAttachment
        {
            attachmentName = "EndorMk3 Silencer",
            type = AttachmentType.Muzzle,
            compatibleAmmoType = AmmoType._308,
            statModifier = WeaponStatModifier.FromFloats(
                recoil: -0.04f,
                accuracy: 0.02f,
                weight: 0.25f
            ),
            description = "Suppresses muzzle flash and dampens sound.",
            loreTag = "Urban ghost"
        },
        new WeaponAttachment
        {
            attachmentName = "EndorMk3 Scope_Recon",
            type = AttachmentType.Optic,
            compatibleAmmoType = AmmoType._308,
            statModifier = WeaponStatModifier.FromFloats(
                zoom: 3.0f,
                accuracy: 0.05f,
                recoil: -0.02f,
                weight: 0.36f
            ),
            description = "Mid-range recon scope for tactical awareness.",
            loreTag = "Scoutline"
        },
        new WeaponAttachment
        {
            attachmentName = "EndorMk3 Scope_RedDot",
            type = AttachmentType.Optic,
            compatibleAmmoType = AmmoType._308,
            statModifier = WeaponStatModifier.FromFloats(
                zoom: 1.0f,
                accuracy: 0.03f,
                recoil: -0.01f,
                weight: 0.22f
            ),
            description = "Reflex sight for close-quarters precision.",
            loreTag = "Quickdraw"
        }
    },
    developerNote = "Modular AR with dual fire modes and flexible optics. Built for recon, suppression, and stealth."
},
new RangedWeaponItem
{
    weaponName = "Gemfront 15BD",
    category = WeaponCategory.AssaultRifle,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._5_56_Nato },
    fireRate = 0.10f, // Full-auto rate
    effectiveRange = 120f,
    recoil = 0.68f,
    accuracy = 0.86f,
    baseDamage = 52f,
    shock = 26f,
    force = 15f,
    pierce = 0.26f,
    bleedChance = 0.09f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 7f,
    meleeShock = 2f,
    staminaCost = 10f,
    meleeBleedChance = 0.03f,
    stunChance = 0.10f,
    condition = 100f,
    weight = 4.5f,
    isAutomatic = true,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "Gemfront Mag_30Rnd",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._5_56_Nato,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 30,
                weight: 0.38f
            ),
            description = "Standard 30-round mag for balanced combat.",
            loreTag = "Gemfront issue"
        },
        new WeaponAttachment
        {
            attachmentName = "Gemfront Mag_40Rnd_Extended",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._5_56_Nato,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 40,
                weight: 0.52f
            ),
            description = "Extended mag for prolonged engagements.",
            loreTag = "Gemfront mod"
        },
        new WeaponAttachment
        {
            attachmentName = "Gemfront Grip_Tactical",
            type = AttachmentType.Grip,
            statModifier = WeaponStatModifier.FromFloats(
                recoil: -0.05f,
                accuracy: 0.04f,
                weight: 0.28f
            ),
            description = "Tactical grip for improved handling.",
            loreTag = "Quickhold"
        },
        new WeaponAttachment
        {
            attachmentName = "Gemfront Suppressor_Stealth",
            type = AttachmentType.Muzzle,
            statModifier = WeaponStatModifier.FromFloats(
                recoil: -0.04f,
                accuracy: 0.03f,
                weight: 0.26f
            ),
            description = "Suppressor for stealth and reduced recoil.",
            loreTag = "Silentline"
        },
        new WeaponAttachment
        {
            attachmentName = "Gemfront Flashlight_Mk1",
            type = AttachmentType.Utility,
            statModifier = WeaponStatModifier.FromFloats(
                weight: 0.20f
            ),
            description = "Compact flashlight for low-light ops.",
            loreTag = "Brightpath"
        }
    },
    developerNote = "Gemfront’s flagship AR. Modular, reliable, and built for tactical flexibility. Standard issue for urban patrols and recon squads."
},
new RangedWeaponItem
{
    weaponName = "Lowpoint Yeti TS45K",
    category = WeaponCategory.Rifle,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._45_ACP },
    fireRate = 0.55f,
    effectiveRange = 90f,
    recoil = 0.74f,
    accuracy = 0.82f,
    baseDamage = 48f,
    shock = 24f,
    force = 14f,
    pierce = 0.22f,
    bleedChance = 0.08f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 6f,
    meleeShock = 2f,
    staminaCost = 9f,
    meleeBleedChance = 0.02f,
    stunChance = 0.08f,
    condition = 100f,
    weight = 4.2f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "Yeti Mag_9Rnd",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._45_ACP,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 9,
                weight: 0.34f
            ),
            description = "Standard 9-round mag for compact engagements.",
            loreTag = "Lowpoint issue"
        },
        new WeaponAttachment
        {
            attachmentName = "Yeti Mag_13Rnd_Extended",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._45_ACP,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 13,
                weight: 0.46f
            ),
            description = "Extended mag for increased capacity.",
            loreTag = "Lowpoint mod"
        },
        new WeaponAttachment
        {
            attachmentName = "Yeti Rail_Mount",
            type = AttachmentType.Utility,
            statModifier = WeaponStatModifier.FromFloats(
                weight: 0.18f
            ),
            description = "Universal rail mount for optics and accessories.",
            loreTag = "Mountline"
        },
        new WeaponAttachment
        {
            attachmentName = "Yeti Flashlight_Mk2",
            type = AttachmentType.Utility,
            statModifier = WeaponStatModifier.FromFloats(
                weight: 0.22f
            ),
            description = "High-lumen flashlight for tactical visibility.",
            loreTag = "Brightpath"
        }
    },
    developerNote = "Compact .45 ACP rifle with modular rail and mag options. Built for low-light patrols and tight corridors."
},
new RangedWeaponItem
{
    weaponName = "Ashniko KC-74",
    category = WeaponCategory.AssaultRifle,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._5_45 },
    fireRate = 0.11f, // Full-auto rate
    effectiveRange = 115f,
    recoil = 0.70f,
    accuracy = 0.85f,
    baseDamage = 50f,
    shock = 25f,
    force = 14f,
    pierce = 0.25f,
    bleedChance = 0.09f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 7f,
    meleeShock = 2f,
    staminaCost = 10f,
    meleeBleedChance = 0.03f,
    stunChance = 0.10f,
    condition = 100f,
    weight = 4.6f,
    isAutomatic = true,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "KC74 Mag_30Rnd",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._5_45,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 30,
                weight: 0.36f
            ),
            description = "Standard 30-round mag for balanced firepower.",
            loreTag = "Ashniko issue"
        },
        new WeaponAttachment
        {
            attachmentName = "KC74 Mag_45Rnd_Extended",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._5_45,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 45,
                weight: 0.50f
            ),
            description = "Extended mag for longer engagements.",
            loreTag = "Ashniko mod"
        },
        new WeaponAttachment
        {
            attachmentName = "KC74 Mag_70Rnd_Drum",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._5_45,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 70,
                weight: 0.72f
            ),
            description = "Drum mag for sustained suppressive fire.",
            loreTag = "Ashniko heavy"
        },
        new WeaponAttachment
        {
            attachmentName = "KC74 Muzzle_Break",
            type = AttachmentType.Muzzle,
            statModifier = WeaponStatModifier.FromFloats(
                recoil: -0.06f,
                accuracy: 0.02f,
                weight: 0.24f
            ),
            description = "Muzzle break to reduce vertical recoil.",
            loreTag = "Kickstop"
        },
        new WeaponAttachment
        {
            attachmentName = "KC74 Stock_Tactical",
            type = AttachmentType.Stock,
            statModifier = WeaponStatModifier.FromFloats(
                recoil: -0.04f,
                accuracy: 0.03f,
                weight: 0.30f
            ),
            description = "Tactical stock for improved stability.",
            loreTag = "Backline"
        }
    },
    developerNote = "Ashniko’s modular AR built around sustained fire and recoil control. Drum-ready, rail-stable, and tuned for tactical dominance."
},
new RangedWeaponItem
{
    weaponName = "Ashniko KC103",
    category = WeaponCategory.AssaultRifle,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._7_62 },
    fireRate = 0.10f, // Full-auto rate
    effectiveRange = 125f,
    recoil = 0.76f,
    accuracy = 0.83f,
    baseDamage = 56f,
    shock = 30f,
    force = 17f,
    pierce = 0.27f,
    bleedChance = 0.10f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 7f,
    meleeShock = 2f,
    staminaCost = 10f,
    meleeBleedChance = 0.03f,
    stunChance = 0.10f,
    condition = 100f,
    weight = 4.9f,
    isAutomatic = true,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "KC103 Mag_20Rnd",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._7_62,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 20,
                weight: 0.34f
            ),
            description = "Compact 20-round mag for controlled bursts.",
            loreTag = "Ashniko issue"
        },
        new WeaponAttachment
        {
            attachmentName = "KC103 Mag_30Rnd_Extended",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._7_62,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 30,
                weight: 0.48f
            ),
            description = "Extended mag for longer engagements.",
            loreTag = "Ashniko mod"
        },
        new WeaponAttachment
        {
            attachmentName = "KC103 Mag_75Rnd_Drum",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._7_62,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 75,
                weight: 0.76f
            ),
            description = "Drum mag for sustained suppressive fire.",
            loreTag = "Ashniko heavy"
        },
        new WeaponAttachment
        {
            attachmentName = "KC103 Muzzle_Break",
            type = AttachmentType.Muzzle,
            statModifier = WeaponStatModifier.FromFloats(
                recoil: -0.07f,
                accuracy: 0.02f,
                weight: 0.25f
            ),
            description = "Aggressive muzzle break for recoil control.",
            loreTag = "Kickstop"
        },
        new WeaponAttachment
        {
            attachmentName = "KC103 Stock_Tactical",
            type = AttachmentType.Stock,
            statModifier = WeaponStatModifier.FromFloats(
                recoil: -0.05f,
                accuracy: 0.03f,
                weight: 0.32f
            ),
            description = "Tactical stock for improved stability.",
            loreTag = "Backline"
        }
    },
    developerNote = "Ashniko’s battle-tuned AR chambered in 7.62. Built for recoil control and sustained fire. Drum-ready, kick-stabilized, and field-tested."
},
new RangedWeaponItem
{
    weaponName = "KnH 344 VR",
    category = WeaponCategory.AssaultRifle,
    compatibleAmmoTypes = new List<AmmoType> { AmmoType._5_56_Nato },
    fireRate = 0.09f, // Full-auto rate
    effectiveRange = 118f,
    recoil = 0.69f,
    accuracy = 0.84f,
    baseDamage = 51f,
    shock = 27f,
    force = 15f,
    pierce = 0.26f,
    bleedChance = 0.09f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 7f,
    meleeShock = 2f,
    staminaCost = 10f,
    meleeBleedChance = 0.03f,
    stunChance = 0.10f,
    condition = 100f,
    weight = 4.4f,
    isAutomatic = true,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "KnH Mag_20Rnd",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._5_56_Nato,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 20,
                weight: 0.32f
            ),
            description = "Standard 20-round mag for compact loadouts.",
            loreTag = "KnH issue"
        },
        new WeaponAttachment
        {
            attachmentName = "KnH Mag_30Rnd_Extended",
            type = AttachmentType.Magazine,
            compatibleAmmoType = AmmoType._5_56_Nato,
            statModifier = WeaponStatModifier.FromFloats(
                ammoCapacity: 30,
                weight: 0.44f
            ),
            description = "Extended mag for prolonged engagements.",
            loreTag = "KnH mod"
        },
        new WeaponAttachment
        {
            attachmentName = "KnH Grip_Tactical",
            type = AttachmentType.Grip,
            statModifier = WeaponStatModifier.FromFloats(
                recoil: -0.05f,
                accuracy: 0.04f,
                weight: 0.26f
            ),
            description = "Tactical grip for improved control.",
            loreTag = "Quickhold"
        },
        new WeaponAttachment
        {
            attachmentName = "KnH Rail_Mount",
            type = AttachmentType.Utility,
            statModifier = WeaponStatModifier.FromFloats(
                weight: 0.18f
            ),
            description = "Universal rail mount for optics and accessories.",
            loreTag = "Mountline"
        },
        new WeaponAttachment
        {
            attachmentName = "KnH Flashlight_Mk1",
            type = AttachmentType.Utility,
            statModifier = WeaponStatModifier.FromFloats(
                weight: 0.20f
            ),
            description = "Compact flashlight for low-light ops.",
            loreTag = "Brightpath"
        },
        new WeaponAttachment
        {
            attachmentName = "KnH LaserSight_Redline",
            type = AttachmentType.Utility,
            statModifier = WeaponStatModifier.FromFloats(
                accuracy: 0.03f,
                weight: 0.22f
            ),
            description = "Red laser sight for enhanced target acquisition.",
            loreTag = "Redline"
        }
    },
    developerNote = "KnH’s precision AR tuned for tactical ops. Lightweight, rail-ready, and built for visibility and control."
},
new RangedWeaponItem
{
    weaponName = "Terpon Trapper 12 Gauge",
    category = WeaponCategory.Shotgun,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.ShotgunShell_12Gauge_Buckshot,
        AmmoType.ShotgunShell_12Gauge_Slug,
        AmmoType.ShotgunShell_12Gauge_Birdshot,
        AmmoType.ShotgunShell_12Gauge_Rubberslug
    },
    fireRate = 0.85f,
    effectiveRange = 40f,
    recoil = 0.92f,
    accuracy = 0.72f,
    baseDamage = 78f,
    shock = 42f,
    force = 26f,
    pierce = 0.18f,
    bleedChance = 0.16f,
    electricShock = 0f,
    meleeRange = 1.1f,
    meleeDamage = 8f,
    meleeShock = 2f,
    staminaCost = 10f,
    meleeBleedChance = 0.04f,
    stunChance = 0.10f,
    condition = 100f,
    weight = 4.8f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "Trapper Flashlight_Mk1",
            type = AttachmentType.Utility,
            statModifier = WeaponStatModifier.FromFloats(
                weight: 0.22f
            ),
            description = "Compact flashlight for low-light ops.",
            loreTag = "Brightpath"
        }
    },
    developerNote = "Single-shot survival shotgun. No frills, no feed system—just one shell and a prayer. Built for reliability in the worst conditions. Flashlight-ready for night patrols and bunker sweeps."
},
new RangedWeaponItem
{
    weaponName = "Terpon Trapper Sawn-Off 12 Gauge",
    category = WeaponCategory.Shotgun,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.ShotgunShell_12Gauge_Buckshot,
        AmmoType.ShotgunShell_12Gauge_Slug,
        AmmoType.ShotgunShell_12Gauge_Birdshot,
        AmmoType.ShotgunShell_12Gauge_Rubberslug
    },
    fireRate = 0.65f,
    effectiveRange = 25f,
    recoil = 1.05f,
    accuracy = 0.58f,
    baseDamage = 84f,
    shock = 46f,
    force = 30f,
    pierce = 0.12f,
    bleedChance = 0.18f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 7f,
    meleeShock = 2f,
    staminaCost = 9f,
    meleeBleedChance = 0.03f,
    stunChance = 0.08f,
    condition = 85f,
    weight = 3.2f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>(), // No attachments
    developerNote = "Sawn-off variant of the Terpon Trapper. Reduced range and accuracy, but packs brutal close-quarters punch. No flashlight, no frills—just one shell and a short fuse."
},
new RangedWeaponItem
{
    weaponName = "Terpon Yuth 20 Gauge",
    category = WeaponCategory.Shotgun,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.ShotgunShell_20Gauge_Buckshot,
        AmmoType.ShotgunShell_20Gauge_Slug,
        AmmoType.ShotgunShell_20Gauge_Birdshot,
        AmmoType.ShotgunShell_20Gauge_Rubberslug,
        AmmoType.ShotgunShell_20Gauge_Beanbag
    },
    fireRate = 0.90f,
    effectiveRange = 35f,
    recoil = 0.68f,
    accuracy = 0.74f,
    baseDamage = 62f,
    shock = 34f,
    force = 18f,
    pierce = 0.10f,
    bleedChance = 0.12f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 6f,
    meleeShock = 2f,
    staminaCost = 8f,
    meleeBleedChance = 0.02f,
    stunChance = 0.10f,
    condition = 100f,
    weight = 3.6f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "Yuth Flashlight_Mk1",
            type = AttachmentType.Utility,
            statModifier = WeaponStatModifier.FromFloats(
                weight: 0.18f
            ),
            description = "Compact flashlight for rookie patrols and bunker sweeps.",
            loreTag = "Brightpath"
        }
    },
    developerNote = "Lightweight single-shot 20-gauge shotgun. Designed for training, scavenging, and non-lethal ops. Supports beanbag and rubber slug rounds. Flashlight-ready for low-light engagements."
},
new RangedWeaponItem
{
    weaponName = "Terpon Yuth 20 Gauge",
    category = WeaponCategory.Shotgun,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.ShotgunShell_20Gauge_Buckshot,
        AmmoType.ShotgunShell_20Gauge_Slug,
        AmmoType.ShotgunShell_20Gauge_Birdshot,
        AmmoType.ShotgunShell_20Gauge_Rubberslug,
        AmmoType.ShotgunShell_20Gauge_Beanbag
    },
    fireRate = 0.90f,
    effectiveRange = 35f,
    recoil = 0.68f,
    accuracy = 0.74f,
    baseDamage = 62f,
    shock = 34f,
    force = 18f,
    pierce = 0.10f,
    bleedChance = 0.12f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 6f,
    meleeShock = 2f,
    staminaCost = 8f,
    meleeBleedChance = 0.02f,
    stunChance = 0.10f,
    condition = 100f,
    weight = 3.6f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "Yuth Flashlight_Mk1",
            type = AttachmentType.Utility,
            statModifier = WeaponStatModifier.FromFloats(
                weight: 0.18f
            ),
            description = "Compact flashlight for rookie patrols and bunker sweeps.",
            loreTag = "Brightpath"
        }
    },
    developerNote = "Lightweight single-shot 20-gauge shotgun. Designed for training, scavenging, and non-lethal ops. Supports beanbag and rubber slug rounds. Flashlight-ready for low-light engagements."
},
new RangedWeaponItem
{
    weaponName = "Gossmerg Marvel 88 12 Gauge",
    category = WeaponCategory.Shotgun,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.ShotgunShell_12Gauge_Buckshot,
        AmmoType.ShotgunShell_12Gauge_Slug,
        AmmoType.ShotgunShell_12Gauge_Birdshot,
        AmmoType.ShotgunShell_12Gauge_Rubberslug,
        AmmoType.ShotgunShell_12Gauge_Beanbag
    },
    fireRate = 0.50f,
    effectiveRange = 45f,
    recoil = 0.80f,
    accuracy = 0.70f,
    baseDamage = 76f,
    shock = 40f,
    force = 24f,
    pierce = 0.16f,
    bleedChance = 0.15f,
    electricShock = 0f,
    meleeRange = 1.2f,
    meleeDamage = 9f,
    meleeShock = 3f,
    staminaCost = 11f,
    meleeBleedChance = 0.05f,
    stunChance = 0.12f,
    condition = 100f,
    weight = 5.6f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    internalAmmoCapacity = 8, // Pump-action tube holds 8 shells
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "Marvel LaserSight_Mk2",
            type = AttachmentType.Utility,
            statModifier = WeaponStatModifier.FromFloats(
                accuracy: 0.06f,
                weight: 0.20f
            ),
            description = "Precision laser sight for tighter spread control.",
            loreTag = "Redline"
        },
        new WeaponAttachment
        {
            attachmentName = "Marvel Flashlight_Mk1",
            type = AttachmentType.Utility,
            statModifier = WeaponStatModifier.FromFloats(
                weight: 0.22f
            ),
            description = "Tactical flashlight for bunker sweeps and breach ops.",
            loreTag = "Brightpath"
        },
        new WeaponAttachment
        {
            attachmentName = "Marvel MuzzleBrake_X",
            type = AttachmentType.Muzzle,
            statModifier = WeaponStatModifier.FromFloats(
                recoil: -0.08f,
                weight: 0.30f
            ),
            description = "Reduces kickback for faster follow-up shots.",
            loreTag = "Kickstop"
        },
        new WeaponAttachment
        {
            attachmentName = "Marvel Suppressor_Improvised",
            type = AttachmentType.Muzzle,
            statModifier = WeaponStatModifier.FromFloats(
                accuracy: -0.04f,
                weight: 0.40f
            ),
            description = "Makeshift suppressor—lowers noise, but affects spread.",
            loreTag = "Patchwork"
        }
    },
    developerNote = "Pump-action 12-gauge with internal tube capacity. No detachable mag—just rack, fire, repeat. Supports tactical attachments for breach, riot, and stealth roles. Built for modular chaos."
},
new RangedWeaponItem
{
    weaponName = "Gossmerg Marvel 88 Sawn-Off 12 Gauge",
    category = WeaponCategory.Shotgun,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.ShotgunShell_12Gauge_Buckshot,
        AmmoType.ShotgunShell_12Gauge_Slug,
        AmmoType.ShotgunShell_12Gauge_Birdshot,
        AmmoType.ShotgunShell_12Gauge_Rubberslug,
        AmmoType.ShotgunShell_12Gauge_Beanbag
    },
    fireRate = 0.55f,
    effectiveRange = 30f,
    recoil = 1.10f,
    accuracy = 0.50f,
    baseDamage = 82f,
    shock = 48f,
    force = 32f,
    pierce = 0.14f,
    bleedChance = 0.20f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 10f,
    meleeShock = 3f,
    staminaCost = 12f,
    meleeBleedChance = 0.06f,
    stunChance = 0.14f,
    condition = 90f,
    weight = 4.4f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    internalAmmoCapacity = 8, // Pump-action tube holds 8 shells
    attachments = new List<WeaponAttachment>(), // No attachments
    developerNote = "Sawn-off pump-action variant of the Marvel 88. Shortened barrel for tight spaces and fast handling. No muzzle mods, no flashlight—just raw firepower and eight chances to make your point."
},
new RangedWeaponItem
{
    weaponName = "Gossmerg 950Z 20 Gauge",
    category = WeaponCategory.Shotgun,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.ShotgunShell_20Gauge_Buckshot,
        AmmoType.ShotgunShell_20Gauge_Slug,
        AmmoType.ShotgunShell_20Gauge_Birdshot,
        AmmoType.ShotgunShell_20Gauge_Rubberslug,
        AmmoType.ShotgunShell_20Gauge_Beanbag
    },
    fireRate = 0.60f,
    effectiveRange = 40f,
    recoil = 0.68f,
    accuracy = 0.76f,
    baseDamage = 64f,
    shock = 36f,
    force = 20f,
    pierce = 0.12f,
    bleedChance = 0.14f,
    electricShock = 0f,
    meleeRange = 1.1f,
    meleeDamage = 7f,
    meleeShock = 2f,
    staminaCost = 10f,
    meleeBleedChance = 0.04f,
    stunChance = 0.10f,
    condition = 100f,
    weight = 4.8f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    internalAmmoCapacity = 8,
    attachments = new List<WeaponAttachment>
    {
        new WeaponAttachment
        {
            attachmentName = "950Z LaserSight_Mk2",
            type = AttachmentType.Utility,
            statModifier = WeaponStatModifier.FromFloats(
                accuracy: 0.06f,
                weight: 0.18f
            ),
            description = "Precision laser sight for tighter spread control.",
            loreTag = "Redline"
        },
        new WeaponAttachment
        {
            attachmentName = "950Z Flashlight_Mk1",
            type = AttachmentType.Utility,
            statModifier = WeaponStatModifier.FromFloats(
                weight: 0.20f
            ),
            description = "Tactical flashlight for bunker sweeps and breach ops.",
            loreTag = "Brightpath"
        },
        new WeaponAttachment
        {
            attachmentName = "950Z MuzzleBrake_X",
            type = AttachmentType.Muzzle,
            statModifier = WeaponStatModifier.FromFloats(
                recoil: -0.08f,
                weight: 0.28f
            ),
            description = "Reduces kickback for faster follow-up shots.",
            loreTag = "Kickstop"
        },
        new WeaponAttachment
        {
            attachmentName = "950Z Suppressor_Improvised",
            type = AttachmentType.Muzzle,
            statModifier = WeaponStatModifier.FromFloats(
                accuracy: -0.04f,
                weight: 0.36f
            ),
            description = "Makeshift suppressor—lowers noise, but affects spread.",
            loreTag = "Patchwork"
        }
    },
    developerNote = "Pump-action 20-gauge with internal tube capacity. Lightweight, modular, and built for tactical flexibility. Supports full attachment suite for breach, riot, and stealth roles."
},
new RangedWeaponItem
{
    weaponName = "Gossmerg 950Z Sawn-Off 20 Gauge",
    category = WeaponCategory.Shotgun,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.ShotgunShell_20Gauge_Buckshot,
        AmmoType.ShotgunShell_20Gauge_Slug,
        AmmoType.ShotgunShell_20Gauge_Birdshot,
        AmmoType.ShotgunShell_20Gauge_Rubberslug,
        AmmoType.ShotgunShell_20Gauge_Beanbag
    },
    fireRate = 0.65f,
    effectiveRange = 25f,
    recoil = 0.82f,
    accuracy = 0.52f,
    baseDamage = 70f,
    shock = 40f,
    force = 26f,
    pierce = 0.10f,
    bleedChance = 0.16f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 7f,
    meleeShock = 2f,
    staminaCost = 9f,
    meleeBleedChance = 0.03f,
    stunChance = 0.10f,
    condition = 90f,
    weight = 3.8f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    internalAmmoCapacity = 8,
    attachments = new List<WeaponAttachment>(), // No attachments
    developerNote = "Sawn-off pump-action variant of the 950Z. Shortened barrel for tight spaces and fast handling. No muzzle mods, no flashlight—just raw firepower and eight chances to make your point."
},
new RangedWeaponItem
{
    weaponName = "Vexmoore Whisperlock Musket Pistol",
    category = WeaponCategory.Handgun,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.Blackpowder_MusketBall,
        AmmoType.Blackpowder_Slug,
        AmmoType.Blackpowder_Scattershot,
        AmmoType.Blackpowder_Incendiary,
    },
    fireRate = 1.80f,
    effectiveRange = 35f,
    recoil = 1.20f,
    accuracy = 0.60f,
    baseDamage = 90f,
    shock = 50f,
    force = 28f,
    pierce = 0.22f,
    bleedChance = 0.20f,
    electricShock = 0f,
    meleeRange = 0.9f,
    meleeDamage = 6f,
    meleeShock = 2f,
    staminaCost = 10f,
    meleeBleedChance = 0.03f,
    stunChance = 0.08f,
    condition = 70f,
    weight = 2.2f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>(), // Optional: Ramrod, Flask, Sight
    developerNote = "Single-shot black powder pistol crafted by Vexmoore Patternworks. Loud, slow, and devastating. A scavenger’s dueling piece and historian’s relic. Each barrel is engraved with the name of its first wielder—if you can still read it through the soot."
},
new RangedWeaponItem
{
    weaponName = "Liberator Musket",
    category = WeaponCategory.Rifle,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.Blackpowder_MusketBall,
        AmmoType.Blackpowder_Slug,
        AmmoType.Blackpowder_Scattershot,
        AmmoType.Blackpowder_Incendiary
    },
    fireRate = 2.40f,
    effectiveRange = 90f,
    recoil = 1.40f,
    accuracy = 0.68f,
    baseDamage = 110f,
    shock = 60f,
    force = 34f,
    pierce = 0.30f,
    bleedChance = 0.24f,
    electricShock = 0f,
    meleeRange = 1.3f,
    meleeDamage = 10f,
    meleeShock = 3f,
    staminaCost = 12f,
    meleeBleedChance = 0.04f,
    stunChance = 0.10f,
    condition = 65f,
    weight = 5.2f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>(), // No attachments
    developerNote = "The Liberator Musket was carried by insurgents during the Hollowgate Rebellion. Each barrel was hand-forged and engraved with the names of fallen kin. Survivors say it doesn’t fire bullets—it fires oaths. Heavy, slow, and sacred."
},
new RangedWeaponItem
{
    weaponName = "Raxlab Speargun RX458",
    category = WeaponCategory.Special,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.ImprovisedSpear,
        AmmoType.FishingSpear
    },
    fireRate = 1.80f,
    effectiveRange = 35f,
    recoil = 0.90f,
    accuracy = 0.52f,
    baseDamage = 85f,
    shock = 40f,
    force = 28f,
    pierce = 0.45f,
    bleedChance = 0.32f,
    electricShock = 0f,
    meleeRange = 1.2f,
    meleeDamage = 8f,
    meleeShock = 2f,
    staminaCost = 10f,
    meleeBleedChance = 0.06f,
    stunChance = 0.08f,
    condition = 70f,
    weight = 4.6f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>(), // No magazine, no attachments
    developerNote = "The RX458 is a single-shot speargun built by Raxlab Salvage Systems. Fires scavenged spears with brutal force. Popular among shoreline scavengers and reefwalkers. No magazine—each reload is a ritual. Rust-resistant, pressure-tested, and deadly in close quarters."
},
new RangedWeaponItem
{
    weaponName = "Pyrecore Flamethrower Mk.IV",
    category = WeaponCategory.Special,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.Fuel_Crude,
        AmmoType.Fuel_Refined,
        AmmoType.Fuel_Napalm,
        AmmoType.Fuel_Alcohol,
        AmmoType.Fuel_MysteryMix,
        AmmoType.Fuel
    },
    fireRate = 0.25f, // Continuous stream
    effectiveRange = 12f,
    recoil = 0.20f,
    accuracy = 0.30f,
    baseDamage = 18f, // Per tick
    shock = 12f,
    force = 6f,
    pierce = 0f,
    bleedChance = 0f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 4f,
    meleeShock = 1f,
    staminaCost = 14f,
    meleeBleedChance = 0f,
    stunChance = 0.04f,
    condition = 60f,
    weight = 7.8f,
    isAutomatic = true,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>(), // No magazine, no attachments
    developerNote = "The Mk.IV Pyrecore is a single-chamber flamethrower designed for siege ops and ritual purges. Accepts nearly any flammable liquid, from crude oil to mystery cocktails. Survivors call it 'The Choir'—because when it sings, everything burns."
},
new RangedWeaponItem
{
    weaponName = "Thundermount GLX-6",
    category = WeaponCategory.Special,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.SmokeGrenade_Red,
        AmmoType.SmokeGrenade_Green,
        AmmoType.SmokeGrenade_Blue,
        AmmoType.SmokeGrenade_Yellow,
        AmmoType.SmokeGrenade_Purple,
        AmmoType.LauncherRound_HE,
        AmmoType.LauncherRound_EMP,
        AmmoType.LauncherRound_Incendiary
    },
    fireRate = 1.20f,
    effectiveRange = 45f,
    recoil = 1.60f,
    accuracy = 0.40f,
    baseDamage = 95f, // Applies to HE and Incendiary
    shock = 50f,
    force = 42f,
    pierce = 0.25f,
    bleedChance = 0.18f,
    electricShock = 60f, // Applies to EMP
    meleeRange = 1.1f,
    meleeDamage = 6f,
    meleeShock = 2f,
    staminaCost = 11f,
    meleeBleedChance = 0.02f,
    stunChance = 0.12f,
    condition = 68f,
    weight = 6.4f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>(), // No magazine, no attachments
    developerNote = "The GLX-6 is a single-shot grenade launcher designed by Thundermount Tactical. Fires both smoke and explosive rounds. Survivors use it for cover, chaos, and crowd control. Each shell is a gamble—color-coded confusion or high-impact devastation. EMP rounds are rare and revered."
},
new RangedWeaponItem
{
    weaponName = "Gravemarch Cyclone GL5",
    category = WeaponCategory.Special,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.SmokeGrenade_Red,
        AmmoType.SmokeGrenade_Green,
        AmmoType.SmokeGrenade_Blue,
        AmmoType.SmokeGrenade_Yellow,
        AmmoType.SmokeGrenade_Purple,
        AmmoType.LauncherRound_HE,
        AmmoType.LauncherRound_EMP,
        AmmoType.LauncherRound_Incendiary
    },
    fireRate = 0.35f, // Full auto
    effectiveRange = 40f,
    recoil = 2.10f,
    accuracy = 0.36f,
    baseDamage = 85f, // Applies to HE and Incendiary
    shock = 45f,
    force = 38f,
    pierce = 0.22f,
    bleedChance = 0.16f,
    electricShock = 55f, // Applies to EMP
    meleeRange = 1.0f,
    meleeDamage = 5f,
    meleeShock = 2f,
    staminaCost = 13f,
    meleeBleedChance = 0.02f,
    stunChance = 0.10f,
    condition = 62f,
    weight = 7.2f,
    isAutomatic = true,
    canFireWithoutAmmo = false,
    chamberCapacity = 5, // Revolver-style cylinder
    attachments = new List<WeaponAttachment>(), // No magazine, no attachments
    developerNote = "The Cyclone GL5 is a full-auto rotary grenade launcher forged by Gravemarch Arsenal. Fires five rounds from a revolver-style cylinder. Survivors call it 'The Sermon Drum'—because once it starts, it doesn’t stop until the last shell sings. Used in the breach at Ashdrift and banned by three factions for 'excessive enthusiasm.'"
},
new RangedWeaponItem
{
    weaponName = "Solflare Signalgun M1",
    category = WeaponCategory.Special,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.Flare
    },
    fireRate = 1.60f,
    effectiveRange = 25f,
    recoil = 0.50f,
    accuracy = 0.42f,
    baseDamage = 35f, // If used offensively
    shock = 20f,
    force = 12f,
    pierce = 0.05f,
    bleedChance = 0.10f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 4f,
    meleeShock = 1f,
    staminaCost = 8f,
    meleeBleedChance = 0.01f,
    stunChance = 0.06f,
    condition = 75f,
    weight = 2.4f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>(), // No attachments
    developerNote = "The Solflare M1 is a single-shot flaregun used for signaling, distraction, and improvised combat. Fires standard flare rounds that illuminate the battlefield or ignite dry brush. Survivors use it to mark safe zones—or lure enemies into traps. Not recommended for close-range diplomacy."
},
new RangedWeaponItem
{
    weaponName = "Needler Dartgun Mk.II",
    category = WeaponCategory.Special,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.ImprovisedDart,
        AmmoType.TranquilizerDart,
        AmmoType.TrackingDart
    },
    fireRate = 1.50f,
    effectiveRange = 30f,
    recoil = 0.40f,
    accuracy = 0.58f,
    baseDamage = 25f, // Improvised only
    shock = 15f,
    force = 8f,
    pierce = 0.12f,
    bleedChance = 0.08f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 3f,
    meleeShock = 1f,
    staminaCost = 7f,
    meleeBleedChance = 0.01f,
    stunChance = 0.05f,
    condition = 72f,
    weight = 2.9f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>(), // No magazine, no attachments
    developerNote = "The Mk.II Needler is a single-shot dartgun used for stealth ops, creature control, and bounty marking. Fires improvised darts, tranquilizers, and tracking payloads. Survivors call it 'The Whisper Stick'—because when it hits, things go quiet or start blinking."
},
new RangedWeaponItem
{
    weaponName = "Splattertech PBX-9",
    category = WeaponCategory.Special,
    compatibleAmmoTypes = new List<AmmoType>
    {
        AmmoType.Paintball
    },
    fireRate = 0.25f,
    effectiveRange = 20f,
    recoil = 0.30f,
    accuracy = 0.70f,
    baseDamage = 5f,
    shock = 2f,
    force = 1f,
    pierce = 0f,
    bleedChance = 0f,
    electricShock = 0f,
    meleeRange = 1.0f,
    meleeDamage = 2f,
    meleeShock = 0f,
    staminaCost = 4f,
    meleeBleedChance = 0f,
    stunChance = 0.02f,
    condition = 80f,
    weight = 3.1f,
    isAutomatic = false,
    canFireWithoutAmmo = false,
    chamberCapacity = 1,
    attachments = new List<WeaponAttachment>(), // Optional: barrel mods, hopper upgrades
    developerNote = "The PBX-9 is a semi-automatic paintball gun used for training, sport, and distraction tactics. Fires color-coded capsules that mark targets or terrain. Survivors use it to signal, confuse, or settle disputes without bloodshed. Popular in arena games and riot drills."
},




    };

    /// <summary>
    /// Returns the combined weapon stat modifiers for the given weapon's attachments.
    /// </summary>
    public WeaponStatModifier GetFinalModifiersForWeapon(string weaponName)
    {
        var weapon = items.Find(w => w.weaponName == weaponName);
        if (weapon == null)
        {
            Debug.LogWarning($"Weapon not found: {weaponName}");
            return WeaponStatModifier.FromFloats();
        }

        return AttachmentSystem.GetCombinedModifiers(weapon.attachments);
    }
}
