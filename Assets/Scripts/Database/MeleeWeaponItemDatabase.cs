using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

[CreateAssetMenu(fileName = "MeleeWeaponItemDatabase", menuName = "Databases/MeleeWeaponItemDatabase")]
public class MeleeWeaponItemDatabase : ScriptableObject
{
    [Header("Melee Weapon Items")]
    [Tooltip("All melee weapons including tools, misc, and crafted variants.")]
    public List<MeleeWeaponItem> items = new List<MeleeWeaponItem>
    {
        // Butter Knife
        new MeleeWeaponItem
        {
            itemName = "Butter Knife",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Misc,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.Ducktape, RepairMethod.Glue },
            slotSize = 1,
            isTwoHanded = false,
            weight = 0.3f,
            baseDamage = 4f,
            armorPierce = 0f,
            critChance = 0.01f,
            staminaCost = 2f,
            bleedChance = 0.02f,
            stunChance = 0.01f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Tool", "Cooking" }
        },

        // Kitchen Knife
        new MeleeWeaponItem
        {
            itemName = "Kitchen Knife",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Tool,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.Ducktape },
            slotSize = 1,
            isTwoHanded = false,
            weight = 0.6f,
            baseDamage = 18f,
            armorPierce = 5f,
            critChance = 0.10f,
            staminaCost = 4f,
            bleedChance = 0.25f,
            stunChance = 0.05f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Tool", "Cooking" }
        },

        // Utility Knife
        new MeleeWeaponItem
        {
            itemName = "Utility Knife",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Tool,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.Ducktape, RepairMethod.Glue },
            slotSize = 1,
            isTwoHanded = false,
            weight = 0.5f,
            baseDamage = 15f,
            armorPierce = 8f,
            critChance = 0.12f,
            staminaCost = 3f,
            bleedChance = 0.30f,
            stunChance = 0.03f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Tool", "Crafting" }
        },

        // Bread Knife
        new MeleeWeaponItem
        {
            itemName = "Bread Knife",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Tool,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.Ducktape },
            slotSize = 1,
            isTwoHanded = false,
            weight = 0.7f,
            baseDamage = 12f,
            armorPierce = 3f,
            critChance = 0.08f,
            staminaCost = 4f,
            bleedChance = 0.20f,
            stunChance = 0.02f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Tool", "Cooking" }
        },

        // Combat Knife
        new MeleeWeaponItem
        {
            itemName = "Combat Knife",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Crafted,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.Ducktape, RepairMethod.CableTies },
            slotSize = 1,
            isTwoHanded = false,
            weight = 0.9f,
            baseDamage = 30f,
            armorPierce = 12f,
            critChance = 0.20f,
            staminaCost = 6f,
            bleedChance = 0.40f,
            stunChance = 0.05f,
            craftingRecipe = new List<string> { "Utility Knife", "Ducktape", "Metal Shard" },
            itemTags = new List<string> { "Weapon", "Crafting", "Survival" }
        },

                // Fruit Knife
        new MeleeWeaponItem
        {
            itemName = "Fruit Knife",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Tool,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.Glue, RepairMethod.Ducktape },
            slotSize = 1,
            isTwoHanded = false,
            weight = 0.4f,
            baseDamage = 6f,
            armorPierce = 1f,
            critChance = 0.05f,
            staminaCost = 2f,
            bleedChance = 0.10f,
            stunChance = 0.01f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Tool", "Cooking", "Foraging" }
        },

        // Hunting Knife
        new MeleeWeaponItem
        {
            itemName = "Hunting Knife",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Crafted,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.CableTies },
            slotSize = 1,
            isTwoHanded = false,
            weight = 0.8f,
            baseDamage = 24f,
            armorPierce = 10f,
            critChance = 0.15f,
            staminaCost = 5f,
            bleedChance = 0.35f,
            stunChance = 0.04f,
            craftingRecipe = new List<string> { "Utility Knife", "Leather Grip", "Metal Shard" },
            itemTags = new List<string> { "Weapon", "Survival", "Crafting", "Hunting" }
        },

        // Bone Knife
        new MeleeWeaponItem
        {
            itemName = "Bone Knife",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Crafted,
            condition = 80,
            repairOptions = new List<RepairMethod> { RepairMethod.Glue, RepairMethod.Ducktape },
            slotSize = 1,
            isTwoHanded = false,
            weight = 0.5f,
            baseDamage = 14f,
            armorPierce = 4f,
            critChance = 0.08f,
            staminaCost = 3f,
            bleedChance = 0.20f,
            stunChance = 0.02f,
            craftingRecipe = new List<string> { "Bone Shard", "Ducktape", "Twine" },
            itemTags = new List<string> { "Weapon", "Crafting", "Primitive", "Survival" }
        },

        // Stone Knife
        new MeleeWeaponItem
        {
            itemName = "Stone Knife",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Crafted,
            condition = 70,
            repairOptions = new List<RepairMethod> { RepairMethod.Glue },
            slotSize = 1,
            isTwoHanded = false,
            weight = 0.6f,
            baseDamage = 10f,
            armorPierce = 2f,
            critChance = 0.06f,
            staminaCost = 3f,
            bleedChance = 0.15f,
            stunChance = 0.01f,
            craftingRecipe = new List<string> { "Stone Shard", "Twine", "Stick" },
            itemTags = new List<string> { "Weapon", "Crafting", "Primitive", "Tool" }
        },
                // Dagger
        new MeleeWeaponItem
        {
            itemName = "Dagger",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Crafted,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.Glue },
            slotSize = 1,
            isTwoHanded = false,
            weight = 0.4f,
            baseDamage = 16f,
            armorPierce = 6f,
            critChance = 0.25f,
            staminaCost = 2f,
            bleedChance = 0.30f,
            stunChance = 0.02f,
            craftingRecipe = new List<string> { "Metal Shard", "Leather Grip", "Glue" },
            itemTags = new List<string> { "Weapon", "Stealth", "Crafting", "Survival" }
        },

        // Katana
        new MeleeWeaponItem
        {
            itemName = "Katana",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Misc,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.CableTies },
            slotSize = 2,
            isTwoHanded = true,
            weight = 1.5f,
            baseDamage = 40f,
            armorPierce = 15f,
            critChance = 0.30f,
            staminaCost = 8f,
            bleedChance = 0.50f,
            stunChance = 0.05f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Exotic", "Survival", "Combat" }
        },

        // Short Sword
        new MeleeWeaponItem
        {
            itemName = "Short Sword",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Crafted,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.Ducktape },
            slotSize = 1,
            isTwoHanded = false,
            weight = 1.0f,
            baseDamage = 28f,
            armorPierce = 10f,
            critChance = 0.18f,
            staminaCost = 5f,
            bleedChance = 0.35f,
            stunChance = 0.03f,
            craftingRecipe = new List<string> { "Metal Shard", "Wood Handle", "Ducktape" },
            itemTags = new List<string> { "Weapon", "Crafting", "Combat", "Survival" }
        },

        // Long Sword
        new MeleeWeaponItem
        {
            itemName = "Long Sword",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Misc,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.CableTies },
            slotSize = 2,
            isTwoHanded = true,
            weight = 2.2f,
            baseDamage = 50f,
            armorPierce = 20f,
            critChance = 0.22f,
            staminaCost = 10f,
            bleedChance = 0.45f,
            stunChance = 0.07f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Combat", "Survival", "Heavy" }
        },

        // Rapier
        new MeleeWeaponItem
        {
            itemName = "Rapier",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Misc,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit },
            slotSize = 1,
            isTwoHanded = false,
            weight = 0.9f,
            baseDamage = 22f,
            armorPierce = 18f,
            critChance = 0.35f,
            staminaCost = 4f,
            bleedChance = 0.25f,
            stunChance = 0.01f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Combat", "Precision", "Survival" }
        },
                // Bayonet
        new MeleeWeaponItem
        {
            itemName = "Bayonet",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Crafted,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.CableTies },
            slotSize = 1,
            isTwoHanded = false,
            weight = 0.8f,
            baseDamage = 26f,
            armorPierce = 14f,
            critChance = 0.22f,
            staminaCost = 5f,
            bleedChance = 0.30f,
            stunChance = 0.04f,
            craftingRecipe = new List<string> { "Combat Knife", "Rifle Mount", "CableTies" },
            itemTags = new List<string> { "Weapon", "Crafting", "Survival", "Attachment", "Military" }
        },
                // Wood Axe
        new MeleeWeaponItem
        {
            itemName = "Wood Axe",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Tool,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.Ducktape },
            slotSize = 2,
            isTwoHanded = true,
            weight = 2.5f,
            baseDamage = 35f,
            armorPierce = 10f,
            critChance = 0.15f,
            staminaCost = 8f,
            bleedChance = 0.25f,
            stunChance = 0.10f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Tool", "Survival", "Woodcutting" }
        },

 // Hatchet (Enhanced with throwable capability)
new MeleeWeaponItem
{
    itemName = "Hatchet",
    meleeType = MeleeType.Sharp,
    subclass = MeleeSubclass.Tool,
    condition = 100,
    repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.Glue },
    slotSize = 1,
    isTwoHanded = false,
    weight = 1.2f,
    baseDamage = 22f,
    armorPierce = 6f,
    critChance = 0.12f,
    staminaCost = 5f,
    bleedChance = 0.20f,
    stunChance = 0.05f,
    craftingRecipe = null,
    itemTags = new List<string> { "Weapon", "Tool", "Survival", "Woodcutting", "Throwable" },

    isThrowable = true,
    throwRange = 18f,
    throwAccuracy = 0.70f,
    throwDamage = 20f,
    throwStunChance = 0.25f
},

// Cleaver
new MeleeWeaponItem
{
    itemName = "Cleaver",
    meleeType = MeleeType.Sharp,
    subclass = MeleeSubclass.Kitchen,
    condition = 100,
    repairOptions = new List<RepairMethod> { RepairMethod.Glue },
    slotSize = 1,
    isTwoHanded = false,
    weight = 1.5f,
    baseDamage = 28f,
    armorPierce = 5f,
    critChance = 0.15f,
    staminaCost = 6f,
    bleedChance = 0.30f,
    stunChance = 0.10f,
    craftingRecipe = null,
    itemTags = new List<string> { "Weapon", "Kitchen", "Improvised", "Throwable" },

    isThrowable = true,
    throwRange = 15f,
    throwAccuracy = 0.65f,
    throwDamage = 24f,
    throwStunChance = 0.20f
},

// Wrench
new MeleeWeaponItem
{
    itemName = "Wrench",
    meleeType = MeleeType.Blunt,
    subclass = MeleeSubclass.Tool,
    condition = 100,
    repairOptions = new List<RepairMethod> { RepairMethod.ToolKit },
    slotSize = 1,
    isTwoHanded = false,
    weight = 2.0f,
    baseDamage = 25f,
    armorPierce = 4f,
    critChance = 0.10f,
    staminaCost = 7f,
    bleedChance = 0.10f,
    stunChance = 0.30f,
    craftingRecipe = null,
    itemTags = new List<string> { "Weapon", "Tool", "Improvised", "Throwable" },

    isThrowable = true,
    throwRange = 12f,
    throwAccuracy = 0.60f,
    throwDamage = 22f,
    throwStunChance = 0.35f
},

        // Fire Axe
        new MeleeWeaponItem
        {
            itemName = "Fire Axe",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Misc,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.CableTies },
            slotSize = 2,
            isTwoHanded = true,
            weight = 3.0f,
            baseDamage = 45f,
            armorPierce = 15f,
            critChance = 0.18f,
            staminaCost = 10f,
            bleedChance = 0.30f,
            stunChance = 0.12f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Tool", "Emergency", "Survival" }
        },

        // Double Axe
        new MeleeWeaponItem
        {
            itemName = "Double Axe",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Crafted,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.Ducktape },
            slotSize = 2,
            isTwoHanded = true,
            weight = 3.5f,
            baseDamage = 55f,
            armorPierce = 18f,
            critChance = 0.20f,
            staminaCost = 12f,
            bleedChance = 0.35f,
            stunChance = 0.15f,
            craftingRecipe = new List<string> { "Wood Axe", "Metal Shard", "CableTies" },
            itemTags = new List<string> { "Weapon", "Crafting", "Survival", "Heavy" }
        },

            // Steel Knuckles
        new MeleeWeaponItem
        {
            itemName = "Steel Knuckles",
            meleeType = MeleeType.Blunt,
            subclass = MeleeSubclass.Crafted,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit },
            slotSize = 1,
            isTwoHanded = false,
            weight = 0.6f,
            baseDamage = 18f,
            armorPierce = 6f,
            critChance = 0.20f,
            staminaCost = 3f,
            bleedChance = 0.10f,
            stunChance = 0.15f,
            craftingRecipe = new List<string> { "Metal Shard", "Leather Wrap" },
            itemTags = new List<string> { "Weapon", "Crafting", "Survival", "CloseCombat" }
        },

        // Brass Knuckles
        new MeleeWeaponItem
        {
            itemName = "Brass Knuckles",
            meleeType = MeleeType.Blunt,
            subclass = MeleeSubclass.Misc,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit },
            slotSize = 1,
            isTwoHanded = false,
            weight = 0.5f,
            baseDamage = 16f,
            armorPierce = 5f,
            critChance = 0.18f,
            staminaCost = 3f,
            bleedChance = 0.08f,
            stunChance = 0.12f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Survival", "CloseCombat" }
        },

        // Baseball Bat
        new MeleeWeaponItem
        {
            itemName = "Baseball Bat",
            meleeType = MeleeType.Blunt,
            subclass = MeleeSubclass.Misc,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.Ducktape },
            slotSize = 2,
            isTwoHanded = true,
            weight = 2.0f,
            baseDamage = 32f,
            armorPierce = 4f,
            critChance = 0.10f,
            staminaCost = 6f,
            bleedChance = 0.05f,
            stunChance = 0.25f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Survival", "Improvised", "Sport" }
        },

        // Cricket Bat
        new MeleeWeaponItem
        {
            itemName = "Cricket Bat",
            meleeType = MeleeType.Blunt,
            subclass = MeleeSubclass.Misc,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.Ducktape },
            slotSize = 2,
            isTwoHanded = true,
            weight = 2.2f,
            baseDamage = 30f,
            armorPierce = 3f,
            critChance = 0.08f,
            staminaCost = 6f,
            bleedChance = 0.04f,
            stunChance = 0.22f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Survival", "Improvised", "Sport" }
        },

        // Hockey Stick
        new MeleeWeaponItem
        {
            itemName = "Hockey Stick",
            meleeType = MeleeType.Blunt,
            subclass = MeleeSubclass.Misc,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.Ducktape },
            slotSize = 2,
            isTwoHanded = true,
            weight = 2.4f,
            baseDamage = 28f,
            armorPierce = 2f,
            critChance = 0.07f,
            staminaCost = 7f,
            bleedChance = 0.03f,
            stunChance = 0.20f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Survival", "Improvised", "Sport" }
        },

        // Truncheon
        new MeleeWeaponItem
        {
            itemName = "Truncheon",
            meleeType = MeleeType.Blunt,
            subclass = MeleeSubclass.Tool,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit },
            slotSize = 1,
            isTwoHanded = false,
            weight = 1.0f,
            baseDamage = 20f,
            armorPierce = 5f,
            critChance = 0.12f,
            staminaCost = 4f,
            bleedChance = 0.05f,
            stunChance = 0.30f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Survival", "LawEnforcement" }
        },
                // Nailed Baseball Bat
        new MeleeWeaponItem
        {
            itemName = "Nailed Baseball Bat",
            meleeType = MeleeType.Blunt,
            subclass = MeleeSubclass.Crafted,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.Ducktape },
            slotSize = 2,
            isTwoHanded = true,
            weight = 2.2f,
            baseDamage = 38f,
            armorPierce = 8f,
            critChance = 0.14f,
            staminaCost = 7f,
            bleedChance = 0.20f,
            stunChance = 0.30f,
            craftingRecipe = new List<string> { "Baseball Bat", "Nails", "Ducktape" },
            itemTags = new List<string> { "Weapon", "Crafting", "Improvised", "Survival" }
        },

        // Nailed Cricket Bat
        new MeleeWeaponItem
        {
            itemName = "Nailed Cricket Bat",
            meleeType = MeleeType.Blunt,
            subclass = MeleeSubclass.Crafted,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.Ducktape },
            slotSize = 2,
            isTwoHanded = true,
            weight = 2.4f,
            baseDamage = 36f,
            armorPierce = 7f,
            critChance = 0.12f,
            staminaCost = 7f,
            bleedChance = 0.18f,
            stunChance = 0.28f,
            craftingRecipe = new List<string> { "Cricket Bat", "Nails", "Ducktape" },
            itemTags = new List<string> { "Weapon", "Crafting", "Improvised", "Survival" }
        },

        // Kukri
        new MeleeWeaponItem
        {
            itemName = "Kukri",
            meleeType = MeleeType.Sharp,
            subclass = MeleeSubclass.Misc,
            condition = 100,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolKit, RepairMethod.CableTies },
            slotSize = 1,
            isTwoHanded = false,
            weight = 1.0f,
            baseDamage = 28f,
            armorPierce = 10f,
            critChance = 0.20f,
            staminaCost = 5f,
            bleedChance = 0.35f,
            stunChance = 0.05f,
            craftingRecipe = null,
            itemTags = new List<string> { "Weapon", "Survival", "Combat", "Exotic" }

},
new MeleeWeaponItem
{
    itemName = "Wooden Spear",
    meleeType = MeleeType.Sharp, // Closest valid type for piercing
    subclass = MeleeSubclass.Improvised,
    condition = 85,

    repairOptions = new List<RepairMethod>
    {
        RepairMethod.Ducktape,
        RepairMethod.Glue,
        RepairMethod.CableTies
    },

    slotSize = 2,
    isTwoHanded = true,
    weight = 2.0f,

    baseDamage = 14f,
    armorPierce = 2f,
    critChance = 0.10f,
    staminaCost = 6f,
    bleedChance = 0.15f,
    stunChance = 0.05f,

    craftingRecipe = new List<string>
    {
        "Wooden Pole",
        "Sharpened Tip"
    },

    itemTags = new List<string>
    {
        "Weapon", "Melee", "Spear", "Wooden", "Improvised", "Throwable"
    },

    isThrowable = true,
    throwRange = 12f,
    throwAccuracy = 0.65f,
    throwDamage = 12f,
    throwStunChance = 0.10f
},
new MeleeWeaponItem
{
    itemName = "Steel-Tipped Spear",
    meleeType = MeleeType.Sharp,
    subclass = MeleeSubclass.Military,
    condition = 100,

    repairOptions = new List<RepairMethod>
    {
        RepairMethod.Welding,
        RepairMethod.ToolKit
    },

    slotSize = 2,
    isTwoHanded = true,
    weight = 3.2f,

    baseDamage = 22f,
    armorPierce = 6f,
    critChance = 0.20f,
    staminaCost = 8f,
    bleedChance = 0.25f,
    stunChance = 0.10f,

    craftingRecipe = new List<string>
    {
        "Steel Tip",
        "Reinforced Shaft"
    },

    itemTags = new List<string>
    {
        "Weapon", "Melee", "Spear", "Steel", "Military", "Throwable"
    },

    isThrowable = true,
    throwRange = 10f,
    throwAccuracy = 0.75f,
    throwDamage = 20f,
    throwStunChance = 0.15f
}


// eeWeaponItem entries below, comma-separated
};

    // Removed stray brace here

    public MeleeWeaponItem GetByName(string name)
    {
        foreach (var item in items)
        {
            if (item.itemName == name)
                return item;
        }
        return null;
    }

    public List<MeleeWeaponItem> GetByType(MeleeType type)
    {
        return items.FindAll(i => i.meleeType == type);
    }

    public List<MeleeWeaponItem> GetByTag(string tag)
    {
        return items.FindAll(i => i.itemTags.Contains(tag));
    }

    public List<MeleeWeaponItem> GetBleedingWeapons(float minBleedChance = 0.01f)
    {
        return items.FindAll(i => i.bleedChance >= minBleedChance);
    }

    public List<MeleeWeaponItem> GetStunningWeapons(float minStunChance = 0.01f)
    {
        return items.FindAll(i => i.stunChance >= minStunChance);
    }

    public List<MeleeWeaponItem> GetCraftableWeapons()
    {
        return items.FindAll(i => i.craftingRecipe != null && i.craftingRecipe.Count > 0);
    }

    public List<MeleeWeaponItem> GetRepairableWith(RepairMethod method)
    {
        return items.FindAll(i => i.repairOptions.Contains(method));
    }
}
