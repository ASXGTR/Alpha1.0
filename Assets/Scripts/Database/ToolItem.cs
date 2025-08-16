using System.Collections.Generic;
using UnityEditor.Playables;
using UnityEngine;

// 🧱 Core Tool Artifact
[CreateAssetMenu(fileName = "NewToolItem", menuName = "Items/Tool")]
public class ToolItem : ScriptableObject
{
    [Header("Core Identity")]
    public string itemName;
    public Sprite icon;
    public string description;
    public string brand;
    public string survivorNotes;

    [Header("Condition & Handling")]
    [Range(0, 100)]
    public int condition;
    public bool canBeRepaired;
    public List<ToolRepairMethod> repairOptions;
    public float weight;
    public int slotSize;
    public bool isTwoHanded;

    [Header("Functionality")]
    public ToolFunction[] functions;
    public bool supportsVehicleUse;
    public bool canGatherResources;
    public ResourceType[] gatherableTypes;

    [Header("Combat Setup")]
    public bool hasMeleeSetup;
    public ToolMeleeType meleeType;
    public ToolMeleeSubclass subclass;

    [Header("Melee Combat Stats")]
    public float baseDamage;
    public float armorPierce;
    public float critChance;
    public float staminaCost;
    public float bleedChance;
    public float stunChance;

    [Header("Impact Modifiers")]
    public float shockMultiplier = 1f;
    public float forceMultiplier = 1f;
    public float bluntForceBonus = 1.25f;
    public float swingSpeed = 1f;

    [Header("Throwable Capability")]
    public bool isThrowable;
    public float throwRange;
    public float throwAccuracy;
    public float throwDamage;
    public float throwStunChance;

    [Header("Ranged Combat Stats")]
    public bool hasRangedSetup;
    public float projectileSpeed;
    public float projectileDropRate;
    public float reloadTime;
    public float maxRange;
    public float impactRadius;
    public float rangedCritChance;
    public float rangedArmorPierce;
    public float rangedDamage;

    [Header("Crafting & Lore")]
    public List<string> craftingRecipe;
    public List<string> itemTags;
}

// 🧠 Function Taxonomy
public enum ToolFunction
{
    Repair,
    OpenSealedItems,
    Farming,
    Building,
    Digging,
    Gathering,
    VehicleMaintenance,
    RitualUse,
    Vehicle_SparkPlugAccess,
    Generator_SparkPlugAccess,
    Demolition,
    ElectricalWork,
    MedicalUse,
    Cooking,
    ChemicalUse,
    Vehicle_Repair,
    Vehicle_TireChange,
    Vehicle_FuelAccess,
    Vehicle_BatteryAccess,
    Vehicle_EngineAccess,
    Generator_Repair,
    Generator_FuelAccess,
    Generator_BatteryAccess,
    Generator_EngineAccess,
    WireCutting,
    LockPicking,
    LockCutting,
    LockSmithing,
    Utility,
    Sabotage,
    ClimbingAid,
    Fishing,
    Skinning,
    Butchering,
    Woodcutting,
    MetalWorking,
    StoneWorking,
    Sealing,
    Welding,
    Crafting,
    ImprovisedWeapon,
    ImprovisedTool,
    Sharpening,
    Crying,
    None, // No specific function
}

public enum ResourceType
{
    Wood,
    Metal,
    Organic,
    Stone,
    Fuel
}

public enum ToolMeleeType
{
    Blunt,
    Sharp,
    Thrown,
    Piercing,
    None, // No melee capabilities
}

public enum ToolMeleeSubclass
{
    Tool,
    Misc,
    Crafted,
    Kitchen,
    Military,
    Ritual,
    Improvised,
    Utility,
    Surgical,
}

public enum ToolRepairMethod
{
    ToolRepairKit,
    Ducktape,
    Glue,
    CableTies,
    Welding,
    None,
    Scrapmetal,
    ElectricalRepairKit,
    Rope,
}
