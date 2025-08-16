using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CookingItemData
{
    public string itemID;                         // Unique ID for backend reference
    public string itemName;                       // Internal name
    public string displayName;                    // UI name
    public GameObject modelPrefab;                // Visual prefab reference

    public CookingCategory category;              // e.g., Pot, Pan, Grill
    public CookingItemType itemType;              // Enum: Pot, Pan, GrillFrame, etc.
    public HeatSourceType heatSourceType;         // e.g., Gas, Wood, Electric

    public int condition;
    public bool canBeRepaired;
    public List<RepairMethod> repairOptions;

    public List<CookingFunction> functions;

    // 🔥 Cooking-specific properties
    public int liquidCapacityML;                  // Max liquid volume
    public int slotCapacity;                      // Max solid ingredient slots
    public float liquidVolumeLimit;               // Optional override for liquid gating

    public bool supportsBoiling;
    public bool supportsRoasting;
    public bool supportsBaking;

    public float heatRetention;                   // How long it stays hot
    public float cookSpeedMultiplier;             // Speed modifier

    public bool isOpenTop;                        // Lidless or not
    public bool isFireSafe;                       // Can be placed on flame

    public List<string> compatibleHeatSources;    // e.g., Campfire, StoveTop
    public List<CookingMethod> exclusiveMethods;  // Optional method gating

    public bool isLid;                            // Marks item as a lid
    public string compatibleWithItemName;         // Name of the pot/pan it fits
    public bool hasLidAttached;                   // Runtime flag for cookware
    public string attachedLidItemName;            // Runtime reference to lid

    public List<string> craftingRecipe;
    public List<string> itemTags;
    public List<string> loreTags;

    public string brand;
    public string survivorNotes;

    public SlotOccupancy slotOccupancy;            // Physical footprint
    public List<AttachmentPoint> attachmentPoints; // Fuel, lid, etc.
    public HazardProfile hazardProfile;            // Fire risk, flare-ups, etc.

    // 🧱 Inventory logic
    public int inventorySlotSize;                  // How much space it takes in inventory
    public int weight;                             // Weight for encumbrance logic

    // 🆕 Attachment dependency
    public bool requiresAttachmentToFunction;      // If true, item is unusable unless attached
}

// 🔧 Supporting Types

public enum CookingItemType
{
    Pot,
    Pan,
    GrillFrame,
    Steamer,
    Utensil,
    SupportFrame,
    RitualItem,
    Lid,        // 🆕 Added for lid entries
    Insert,     // 🆕 Added for steam racks, ceramic inserts
    Bakeware    // 🆕 Added for baking dishes
}

public enum CookingCategory
{
    Pot,
    Pan,
    Grill,
    Oven,
    Steamer,
    SupportFrame,
    Misc,
}

public enum HeatSourceType
{
    None,
    Wood,
    Gas,
    Electric,
    Charcoal
}

public class CookingFunction
{
    public string functionName;
}

[System.Serializable]
public class SlotOccupancy
{
    public int widthSlots;
    public int depthSlots;
    public int heightClearance;
}

[System.Serializable]
public class AttachmentPoint
{
    public CookingItemAttachmentType type;
    public bool required;
    public string[] compatibleItems;
}

public enum CookingItemAttachmentType
{
    Lid,
    FuelCanister,
    GasCanister,
    Insertable,
    SupportFrame
}

[System.Serializable]
public class HazardProfile
{
    public float ignitionRisk;
    public float flareUpChance;
    public bool requiresVentilation;
}
