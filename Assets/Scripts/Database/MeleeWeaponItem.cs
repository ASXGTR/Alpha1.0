using System.Collections.Generic;
using UnityEngine;

// 🧠 Combat Taxonomy
public enum MeleeType
{
    Blunt,      // Hammers, bats, wrenches
    Sharp,      // Knives, axes, cleavers
    Thrown,      // Melee weapons with ranged fallback
    Piercing,   // Spears, bayonets, sharp tools
    None,       // No melee capabilities
}

public enum MeleeSubclass
{
    Tool,       // Hatchets, wrenches, utility blades
    Misc,       // Oddities, lore-bound junk
    Crafted,    // Player-made hybrids
    Kitchen,    // Cleavers, knives, culinary horror
    Military,   // Bayonets, trench clubs
    Ritual,     // Ceremonial blades, improvised relics
    Improvised, // Anything held together by hope and twine
    Utility,    // Utility items with melee capabilities
    Surgical,   // Surgical tools with melee capabilities
}
public enum RepairMethod
{
    Ducktape,
    ToolKit,
    ToolRepairKit,
    Glue,
    CableTies,
    Welding,
    None,
    WeaponRepairKit,
    ScrapMetal,
    ElectricalRepairKit,
    Rope,
}

// 🪓 Modular Melee Artifact
[CreateAssetMenu(fileName = "NewMeleeWeapon", menuName = "Items/MeleeWeapon")]
public class MeleeWeaponItem : ScriptableObject
{
    [Header("Core Identity")]
    public string itemName;
    public MeleeType meleeType;
    public MeleeSubclass subclass;
    public int condition;

    [Header("Repair & Handling")]
    public List<RepairMethod> repairOptions;
    public int slotSize;
    public bool isTwoHanded;
    public float weight;

    [Header("Melee Combat Stats")]
    public float baseDamage;
    public float armorPierce;
    public float critChance;
    public float staminaCost;
    public float bleedChance;
    public float stunChance;

    [Header("Impact Modifiers")]
    [Tooltip("Multiplier for shock calculation based on weight")]
    public float shockMultiplier = 1f;

    [Tooltip("Multiplier for force calculation based on weight and swing speed")]
    public float forceMultiplier = 1f;

    [Tooltip("Bonus force multiplier for blunt weapons to compensate for lack of bleed")]
    public float bluntForceBonus = 1.25f;

    [Tooltip("Swing speed used in force calculation")]
    public float swingSpeed = 1f;

    [Header("Crafting & Lore")]
    public List<string> craftingRecipe;
    public List<string> itemTags;

    [Header("Throwable Capability")]
    public bool isThrowable;
    public float throwRange;
    public float throwAccuracy;
    public float throwDamage;
    public float throwStunChance;
}
