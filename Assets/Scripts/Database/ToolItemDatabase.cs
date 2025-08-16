using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ToolItemData
{
    public string itemName;
    public int condition;
    public bool canBeRepaired;
    public List<RepairMethod> repairOptions = new List<RepairMethod>();

    public List<ToolFunction> functions;

    public bool supportsVehicleUse;
    public bool canGatherResources;
    public bool hasMeleeSetup;
    public MeleeType meleeType;
    public MeleeSubclass subclass;

    public float baseDamage;
    public float armorPierce;
    public float critChance;
    public float staminaCost;
    public float bleedChance;
    public float stunChance;

    public float shockMultiplier;
    public float forceMultiplier;
    public float bluntForceBonus;
    public float swingSpeed;

    public bool isThrowable;

    public List<string> craftingRecipe;
    public List<string> itemTags;

    public string brand;
    public string survivorNotes;
}

public static class ToolItems
{
    public static ToolItemData WrenchBonekey => new ToolItemData
    {
        itemName = "Wrench",
        condition = 90,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit },
        functions = new List<ToolFunction>
        {
            ToolFunction.Vehicle_SparkPlugAccess,
            ToolFunction.Generator_SparkPlugAccess,
            ToolFunction.RitualUse
        },
        supportsVehicleUse = true,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 28f,
        armorPierce = 8f,
        critChance = 6f,
        staminaCost = 12f,
        bleedChance = 0f,
        stunChance = 20f,

        shockMultiplier = 1.1f,
        forceMultiplier = 1.4f,
        bluntForceBonus = 1.25f,
        swingSpeed = 1.0f,

        isThrowable = false,

        craftingRecipe = new List<string> { "Steel Shaft", "Grip Tape" },
        itemTags = new List<string> { "Tool", "Melee", "Utility", "Vehicle", "Generator" },

        brand = "Gravemarch Industrial",
        survivorNotes = "Required for spark plug rites—vehicles and generators alike. No plug turns without it."
    };

    public static ToolItemData ClawHammerNailfather => new ToolItemData
    {
        itemName = "Claw Hammer",
        condition = 85,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit },
        functions = new List<ToolFunction>
        {
            ToolFunction.Repair,
            ToolFunction.Building,
            ToolFunction.OpenSealedItems,
            ToolFunction.RitualUse
        },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 32f,
        armorPierce = 6f,
        critChance = 4f,
        staminaCost = 10f,
        bleedChance = 0f,
        stunChance = 25f,

        shockMultiplier = 1.2f,
        forceMultiplier = 1.5f,
        bluntForceBonus = 1.3f,
        swingSpeed = 0.95f,

        isThrowable = false,

        craftingRecipe = new List<string> { "Forged Head", "Wooden Handle" },
        itemTags = new List<string> { "Tool", "Melee", "Construction", "Utility" },

        brand = "Redmark Forge",
        survivorNotes = "Pulls nails, breaks bones, and seals pacts. The Nailfather never misses."
    };

    public static ToolItemData RubberMallet => new ToolItemData
    {
        itemName = "Rubber Mallet",
        condition = 80,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Glue },
        functions = new List<ToolFunction>
        {
            ToolFunction.Repair,
            ToolFunction.Building,
            ToolFunction.RitualUse
        },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 20f,
        armorPierce = 4f,
        critChance = 3f,
        staminaCost = 6f,
        bleedChance = 0f,
        stunChance = 15f,

        shockMultiplier = 1.05f,
        forceMultiplier = 1.2f,
        bluntForceBonus = 1.1f,
        swingSpeed = 1.2f,

        isThrowable = false,

        craftingRecipe = new List<string> { "Rubber Head", "Short Grip", "Binding Cord" },
        itemTags = new List<string> { "Tool", "Melee", "Construction", "Utility", "Ritual" },

        brand = "Softstrike Assembly",
        survivorNotes = "Gentle enough for seals, firm enough for fate. Used in quiet rites and stubborn builds."
    };

    public static ToolItemData LumpHammer => new ToolItemData
    {
        itemName = "Lump Hammer",
        condition = 78,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit },

        functions = new List<ToolFunction>
    {
        ToolFunction.Demolition,
        ToolFunction.Building,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 36f,
        armorPierce = 10f,
        critChance = 2f,
        staminaCost = 14f,
        bleedChance = 0f,
        stunChance = 30f,

        shockMultiplier = 1.3f,
        forceMultiplier = 1.6f,
        bluntForceBonus = 1.4f,
        swingSpeed = 0.85f,

        isThrowable = false,

        craftingRecipe = new List<string> { "Forged Head", "Short Handle", "Binding Wrap" },
        itemTags = new List<string> { "Tool", "Melee", "Demolition", "Construction", "Ritual" },

        brand = "Redmark Forge",
        survivorNotes = "Built for breaking walls and breaking wills. Used in collapse rites and stubborn demolitions."
    };
    public static ToolItemData RubberMalletLarge => new ToolItemData
    {
        itemName = "Rubber Mallet (Large)",
        condition = 82,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Glue },

        functions = new List<ToolFunction>
    {
        ToolFunction.Building,
        ToolFunction.Demolition,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 42f,
        armorPierce = 6f,
        critChance = 2f,
        staminaCost = 16f,
        bleedChance = 0f,
        stunChance = 35f,

        shockMultiplier = 1.4f,
        forceMultiplier = 1.7f,
        bluntForceBonus = 1.5f,
        swingSpeed = 0.75f,

        isThrowable = false,

        craftingRecipe = new List<string> { "Rubber Head (Large)", "Long Grip", "Binding Cord" },
        itemTags = new List<string> { "Tool", "Melee", "Construction", "Demolition", "Ritual" },

        brand = "Softstrike Assembly",
        survivorNotes = "Too heavy for finesse, perfect for finality. Used in sealing rites and stubborn breaks."
    };
    public static ToolItemData BoltCutters => new ToolItemData
    {
        itemName = "Bolt Cutters",
        condition = 80,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit },

        functions = new List<ToolFunction>
    {
        ToolFunction.LockCutting,
        ToolFunction.WireCutting,
        ToolFunction.OpenSealedItems,
        ToolFunction.Repair,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = true,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Piercing,
        subclass = MeleeSubclass.Tool,

        baseDamage = 24f,
        armorPierce = 16f,
        critChance = 10f,
        staminaCost = 12f,
        bleedChance = 0.2f,
        stunChance = 10f,

        shockMultiplier = 1.0f,
        forceMultiplier = 1.3f,
        bluntForceBonus = 0.6f,
        swingSpeed = 0.9f,

        isThrowable = false,

        craftingRecipe = new List<string> { "Forged Jaws", "Long Handles", "Tension Spring" },
        itemTags = new List<string> { "Tool", "Melee","Breach", "Vehicle", "Ritual" },

        brand = "Gravemarch Industrial",
        survivorNotes = "Built to sever chains, breach gates, and silence alarms. Used in breach rites and quiet exits."
    };
    public static ToolItemData Lockpick => new ToolItemData
    {
        itemName = "Lockpick",
        condition = 88,
        canBeRepaired = false,
        repairOptions = new List<RepairMethod>(),

        functions = new List<ToolFunction>
    {
        ToolFunction.OpenSealedItems,
        ToolFunction.Sabotage,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = false,

        craftingRecipe = new List<string> { "Steel Pin", "Grip Ring", "Tension Wire" },
        itemTags = new List<string> { "Tool", "Sabotage", "Utility", "Ritual" },

        brand = "Hexline Precision",
        survivorNotes = "Used to bypass locks, seals, and fate itself. Breaks silence more often than steel."
    };
    public static ToolItemData Crowbar => new ToolItemData
    {
        itemName = "Crowbar",
        condition = 82,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Ducktape },

        functions = new List<ToolFunction>
    {
        ToolFunction.OpenSealedItems,
        ToolFunction.Demolition,
        ToolFunction.RitualUse,
        ToolFunction.Utility
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Utility,

        baseDamage = 34f,
        armorPierce = 9f,
        critChance = 3f,
        staminaCost = 13f,
        bleedChance = 0.05f,
        stunChance = 28f,

        shockMultiplier = 1.25f,
        forceMultiplier = 1.5f,
        bluntForceBonus = 1.35f,
        swingSpeed = 0.9f,

        craftingRecipe = new List<string> { "Forged Hook", "Steel Shaft", "Grip Tape" },
        itemTags = new List<string> { "Tool", "Melee", "Demolition", "Utility", "Ritual" },

        brand = "Gravemarch Industrial",
        survivorNotes = "Used to pry open the sealed, breach the buried, and silence the stubborn. A rite of entry."
    };
    public static ToolItemData IcePick => new ToolItemData
    {
        itemName = "Ice Pick",
        condition = 67,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.ClimbingAid,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Piercing,
        subclass = MeleeSubclass.Surgical,

        baseDamage = 22f,
        armorPierce = 18f,
        critChance = 12f,
        staminaCost = 9f,
        bleedChance = 0.35f,
        stunChance = 6f,

        shockMultiplier = 0.85f,
        forceMultiplier = 0.6f,
        bluntForceBonus = 0f,
        swingSpeed = 1.4f,

        craftingRecipe = new List<string> { "Hardened Spike", "Grip Handle", "Binding Wire" },
        itemTags = new List<string> { "Tool", "Melee", "Climbing", "Piercing", "Ritual" },

        brand = "CryoCore Expeditions",
        survivorNotes = "Not just for ice. Punches through bone, rust, and silence. A climber’s last word."
    };
    public static ToolItemData HandAxe => new ToolItemData
{
    itemName = "Hand Axe",
    condition = 74,
    canBeRepaired = true,
    repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

    functions = new List<ToolFunction>
    {
        ToolFunction.Woodcutting,
        ToolFunction.Demolition,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
    supportsVehicleUse = false,
    canGatherResources = true,
    hasMeleeSetup = true,
    meleeType = MeleeType.Sharp,
    subclass = MeleeSubclass.Tool,

    baseDamage = 28f,
    armorPierce = 11f,
    critChance = 7f,
    staminaCost = 11f,
    bleedChance = 0.42f,
    stunChance = 14f,

    shockMultiplier = 1.1f,
    forceMultiplier = 1.2f,
    bluntForceBonus = 0.25f,
    swingSpeed = 1.1f,

    craftingRecipe = new List<string> { "Forged Head", "Wooden Grip", "Binding Cord" },
    itemTags = new List<string> { "Tool", "Melee", "Woodcutting", "Cleaver", "Ritual" },

    brand = "Redmark Timberworks",
    survivorNotes = "Cuts wood, bone, and silence. Favored by those who split paths and seal fates."
};
    public static ToolItemData MeatCleaver => new ToolItemData
    {
        itemName = "Meat Cleaver",
        condition = 61,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Ducktape },

        functions = new List<ToolFunction>
    {
        ToolFunction.Butchering,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Kitchen,

        baseDamage = 31f,
        armorPierce = 7f,
        critChance = 5f,
        staminaCost = 10f,
        bleedChance = 0.48f,
        stunChance = 12f,

        shockMultiplier = 1.0f,
        forceMultiplier = 1.15f,
        bluntForceBonus = 0.1f,
        swingSpeed = 1.2f,

        craftingRecipe = new List<string> { "Forged Cleaver Head", "Wooden Grip", "Binding Cord" },
        itemTags = new List<string> { "Tool", "Melee", "Kitchen", "Sharp", "Ritual" },

        brand = "Grimshaw Culinary",
        survivorNotes = "Once used for meat. Now used for memory. Cuts deep, leaves louder echoes."
    };
    public static ToolItemData SplittingAxe => new ToolItemData
    {
        itemName = "Splitting Axe",
        condition = 79,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.Woodcutting,
        ToolFunction.Demolition,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Tool,

        baseDamage = 38f,
        armorPierce = 14f,
        critChance = 6f,
        staminaCost = 16f,
        bleedChance = 0.52f,
        stunChance = 18f,

        shockMultiplier = 1.3f,
        forceMultiplier = 1.6f,
        bluntForceBonus = 0.35f,
        swingSpeed = 0.85f,

        craftingRecipe = new List<string> { "Heavy Axe Head", "Reinforced Shaft", "Grip Wrap" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Woodcutting", "Ritual" },

        brand = "Ironvale Forestry",
        survivorNotes = "Splits more than wood. Used in rites of division, exile, and finality. Heavy, honest, unforgiving."
    };
    public static ToolItemData TireWrench => new ToolItemData
    {
        itemName = "Tire Wrench",
        condition = 68,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.Vehicle_TireChange,
        ToolFunction.VehicleMaintenance,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = true,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 26f,
        armorPierce = 6f,
        critChance = 4f,
        staminaCost = 10f,
        bleedChance = 0.12f,
        stunChance = 24f,

        shockMultiplier = 1.15f,
        forceMultiplier = 1.4f,
        bluntForceBonus = 1.2f,
        swingSpeed = 1.0f,

        craftingRecipe = new List<string> { "Forged Wrench Head", "Grip Wrap", "Bolt Collar" },
        itemTags = new List<string> { "Tool", "Melee", "Blunt", "Vehicle", "Ritual" },

        brand = "Axleborn Recovery",
        survivorNotes = "Loosens bolts, tightens fate. A roadside relic for torque and testimony."
    };
    public static ToolItemData PipeWrench => new ToolItemData
    {
        itemName = "Pipe Wrench",
        condition = 72,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.VehicleMaintenance,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = true,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 24f,
        armorPierce = 5f,
        critChance = 3f,
        staminaCost = 9f,
        bleedChance = 0.08f,
        stunChance = 30f,

        shockMultiplier = 1.2f,
        forceMultiplier = 1.5f,
        bluntForceBonus = 1.3f,
        swingSpeed = 1.05f,

        craftingRecipe = new List<string> { "Forged Wrench Head", "Grip Sleeve", "Bolt Collar" },
        itemTags = new List<string> { "Tool", "Melee", "Blunt", "Vehicle", "Ritual" },

        brand = "Gravemarch Industrial",
        survivorNotes = "Used to twist pipes and fate alike. Heavy, reliable, and always within reach."
    };
    public static ToolItemData Trowel => new ToolItemData
    {
        itemName = "Trowel",
        condition = 59,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Ducktape },

        functions = new List<ToolFunction>
    {
        ToolFunction.Digging,
        ToolFunction.Farming,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Tool,

        baseDamage = 16f,
        armorPierce = 4f,
        critChance = 6f,
        staminaCost = 7f,
        bleedChance = 0.22f,
        stunChance = 8f,

        shockMultiplier = 0.9f,
        forceMultiplier = 0.75f,
        bluntForceBonus = 0.05f,
        swingSpeed = 1.35f,

        craftingRecipe = new List<string> { "Forged Blade", "Wooden Grip", "Binding Cord" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Digging", "Farming", "Ritual" },

        brand = "Grimshaw Soilworks",
        survivorNotes = "Used to plant, bury, and mark. A quiet blade for quiet rites. Cuts shallow, speaks deep."
    };
    public static ToolItemData Spade => new ToolItemData
    {
        itemName = "Spade",
        condition = 76,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.Digging,
        ToolFunction.Farming,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 28f,
        armorPierce = 6f,
        critChance = 4f,
        staminaCost = 13f,
        bleedChance = 0.18f,
        stunChance = 22f,

        shockMultiplier = 1.25f,
        forceMultiplier = 1.5f,
        bluntForceBonus = 1.1f,
        swingSpeed = 0.9f,

        craftingRecipe = new List<string> { "Forged Spade Head", "Wooden Shaft", "Grip Wrap" },
        itemTags = new List<string> { "Tool", "Melee", "Blunt", "Digging", "Farming", "Ritual" },

        brand = "Gravemarch Soilworks",
        survivorNotes = "Blunt enough to bury, heavy enough to silence. A grave-maker’s verdict."
    };
    public static ToolItemData Shovel => new ToolItemData
    {
        itemName = "Shovel",
        condition = 73,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Ducktape },

        functions = new List<ToolFunction>
    {
        ToolFunction.Digging,
        ToolFunction.Farming,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Tool,

        baseDamage = 26f,
        armorPierce = 10f,
        critChance = 6f,
        staminaCost = 12f,
        bleedChance = 0.32f,
        stunChance = 14f,

        shockMultiplier = 1.1f,
        forceMultiplier = 1.3f,
        bluntForceBonus = 0.2f,
        swingSpeed = 1.0f,

        craftingRecipe = new List<string> { "Shovel Head", "Wooden Shaft", "Grip Tape" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Digging", "Farming", "Ritual" },

        brand = "Redmark Soilworks",
        survivorNotes = "Cuts through earth, roots, and memory. A blade for planting and parting."
    };
    public static ToolItemData GardenFork => new ToolItemData
    {
        itemName = "Garden Fork",
        condition = 70,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.Digging,
        ToolFunction.Farming,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = true,
        meleeType = MeleeType.Piercing,
        subclass = MeleeSubclass.Tool,

        baseDamage = 27f,
        armorPierce = 15f,
        critChance = 8f,
        staminaCost = 12f,
        bleedChance = 0.26f,
        stunChance = 10f,

        shockMultiplier = 1.0f,
        forceMultiplier = 1.2f,
        bluntForceBonus = 0.1f,
        swingSpeed = 1.0f,

        craftingRecipe = new List<string> { "Forged Tines", "Wooden Shaft", "Grip Wrap" },
        itemTags = new List<string> { "Tool", "Melee", "Piercing", "Digging", "Farming", "Ritual" },

        brand = "Redmark Soilworks",
        survivorNotes = "Turns soil, pierces rot, and settles debts. A farmer’s blade with grave intentions."
    };
    public static ToolItemData GardenHoe => new ToolItemData
    {
        itemName = "Garden Hoe",
        condition = 66,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Ducktape },

        functions = new List<ToolFunction>
    {
        ToolFunction.Farming,
        ToolFunction.Digging,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Tool,

        baseDamage = 25f,
        armorPierce = 10f,
        critChance = 6f,
        staminaCost = 11f,
        bleedChance = 0.3f,
        stunChance = 12f,

        shockMultiplier = 1.05f,
        forceMultiplier = 1.3f,
        bluntForceBonus = 0.15f,
        swingSpeed = 1.05f,

        craftingRecipe = new List<string> { "Hoe Blade", "Wooden Shaft", "Binding Cord" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Farming", "Digging", "Ritual" },

        brand = "Gravemarch Soilworks",
        survivorNotes = "Used to carve rows and rites. A blade for planting, parting, and quiet violence."
    };
    public static ToolItemData WoodSaw => new ToolItemData
    {
        itemName = "Wood Saw",
        condition = 64,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Ducktape },

        functions = new List<ToolFunction>
    {
        ToolFunction.Woodcutting,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Tool,

        baseDamage = 20f,
        armorPierce = 8f,
        critChance = 5f,
        staminaCost = 9f,
        bleedChance = 0.38f,
        stunChance = 10f,

        shockMultiplier = 0.95f,
        forceMultiplier = 1.1f,
        bluntForceBonus = 0.1f,
        swingSpeed = 1.2f,

        craftingRecipe = new List<string> { "Saw Blade", "Wooden Grip", "Binding Cord" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Woodcutting", "Ritual" },

        brand = "Redmark Timberworks",
        survivorNotes = "Cuts slow, but deep. Used for timber, bone, and quiet division. A blade for patience and precision."
    };
    public static ToolItemData HackSaw => new ToolItemData
    {
        itemName = "Hack Saw",
        condition = 62,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Ducktape },

        functions = new List<ToolFunction>
    {
        ToolFunction.Demolition,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Tool,

        baseDamage = 19f,
        armorPierce = 9f,
        critChance = 6f,
        staminaCost = 8f,
        bleedChance = 0.34f,
        stunChance = 9f,

        shockMultiplier = 0.95f,
        forceMultiplier = 1.1f,
        bluntForceBonus = 0.05f,
        swingSpeed = 1.3f,

        craftingRecipe = new List<string> { "Saw Blade", "Metal Frame", "Grip Tape" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Demolition", "Ritual" },

        brand = "Gravemarch Industrial",
        survivorNotes = "Used to cut through steel, silence, and stubborn memory. A blade for endings that require effort."
    };
    public static ToolItemData BowSaw => new ToolItemData
    {
        itemName = "Bow Saw",
        condition = 71,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.Woodcutting,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Tool,

        baseDamage = 23f,
        armorPierce = 10f,
        critChance = 5f,
        staminaCost = 11f,
        bleedChance = 0.36f,
        stunChance = 12f,

        shockMultiplier = 1.0f,
        forceMultiplier = 1.3f,
        bluntForceBonus = 0.15f,
        swingSpeed = 1.1f,

        craftingRecipe = new List<string> { "Bow Frame", "Saw Blade", "Grip Wrap" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Woodcutting", "Ritual" },

        brand = "Redmark Timberworks",
        survivorNotes = "Used to clear timber and memory. A blade for slow division and loud silence."
    };
    public static ToolItemData BoneSaw => new ToolItemData
    {
        itemName = "Bone Saw",
        condition = 58,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Ducktape },

        functions = new List<ToolFunction>
    {
        ToolFunction.MedicalUse,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Surgical,

        baseDamage = 18f,
        armorPierce = 12f,
        critChance = 7f,
        staminaCost = 8f,
        bleedChance = 0.42f,
        stunChance = 6f,

        shockMultiplier = 0.9f,
        forceMultiplier = 1.0f,
        bluntForceBonus = 0.05f,
        swingSpeed = 1.3f,

        craftingRecipe = new List<string> { "Surgical Saw Blade", "Grip Frame", "Binding Cord" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Medical", "Ritual" },

        brand = "Gravemarch Surgical",
        survivorNotes = "Used to separate what no longer belongs. A blade for precision, pain, and passage."
    };
    public static ToolItemData ElectricDrill => new ToolItemData
    {
        itemName = "Electric Drill",
        condition = 69,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.Building,
        ToolFunction.ElectricalWork,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 22f,
        armorPierce = 8f,
        critChance = 4f,
        staminaCost = 10f,
        bleedChance = 0.16f,
        stunChance = 22f,

        shockMultiplier = 1.2f,
        forceMultiplier = 1.4f,
        bluntForceBonus = 1.1f,
        swingSpeed = 1.1f,

        craftingRecipe = new List<string> { "Drill Motor", "Bit Assembly", "Battery Pack" },
        itemTags = new List<string> { "Tool", "Melee", "Blunt", "Building", "Electrical", "Ritual" },

        brand = "Gravemarch Industrial",
        survivorNotes = "Powered by silence and sparks. Used to bore through steel, stubbornness, and memory."
    };
    public static ToolItemData HandDrillKit => new ToolItemData
    {
        itemName = "Hand Drill Kit",
        condition = 54,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Ducktape },

        functions = new List<ToolFunction>
    {
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Tool,

        baseDamage = 15f,
        armorPierce = 6f,
        critChance = 5f,
        staminaCost = 7f,
        bleedChance = 0.24f,
        stunChance = 6f,

        shockMultiplier = 0.85f,
        forceMultiplier = 1.0f,
        bluntForceBonus = 0.05f,
        swingSpeed = 1.4f,

        craftingRecipe = new List<string> { "Wooden Shaft", "Drill Bit", "Cord Spool" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Utility", "Ritual" },

        brand = "Redmark Survival",
        survivorNotes = "Used to start fires, bore holes, and mark ritual sites. A whispering blade for quiet ignition."
    };
    public static ToolItemData Prybar => new ToolItemData
    {
        itemName = "Prybar",
        condition = 78,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.OpenSealedItems,
        ToolFunction.Demolition,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 32f,
        armorPierce = 10f,
        critChance = 4f,
        staminaCost = 14f,
        bleedChance = 0.18f,
        stunChance = 26f,

        shockMultiplier = 1.3f,
        forceMultiplier = 1.6f,
        bluntForceBonus = 1.25f,
        swingSpeed = 0.95f,

        craftingRecipe = new List<string> { "Forged Hook", "Steel Shaft", "Grip Tape" },
        itemTags = new List<string> { "Tool", "Melee", "Blunt", "Demolition", "Utility", "Ritual" },

        brand = "Gravemarch Industrial",
        survivorNotes = "Used to breach, bend, and bury. A rite of entry. A lever against fate."
    };
    public static ToolItemData TorqueWrench => new ToolItemData
    {
        itemName = "Torque Wrench",
        condition = 85,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.VehicleMaintenance,
        ToolFunction.Utility,
        ToolFunction.Demolition,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = true,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 28f,
        armorPierce = 8f,
        critChance = 3f,
        staminaCost = 12f,
        bleedChance = 0.12f,
        stunChance = 22f,

        shockMultiplier = 1.2f,
        forceMultiplier = 1.4f,
        bluntForceBonus = 1.1f,
        swingSpeed = 1.05f,

        craftingRecipe = new List<string> { "Torque Head", "Steel Handle", "Grip Tape" },
        itemTags = new List<string> { "Tool", "Melee", "Blunt", "Vehicle", "Utility", "Ritual" },

        brand = "Axion Mechanics",
        survivorNotes = "Used to tighten bolts and break bones. Precision meets desperation. A wrench that remembers torque and trauma."
    };
    public static ToolItemData GlueGun => new ToolItemData
    {
        itemName = "Glue Gun",
        condition = 88,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ElectricalRepairKit },

        functions = new List<ToolFunction>
    {
        ToolFunction.Crafting,
        ToolFunction.Repair,
        ToolFunction.Sealing,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = false,
        meleeType = MeleeType.None,


        craftingRecipe = new List<string> { "Heating Coil", "Plastic Casing", "Glue Stick" },
        itemTags = new List<string> { "Tool", "Utility", "Crafting", "Repair", "Sealing", "Ritual" },

        brand = "Bindwell Systems",
        survivorNotes = "Used to mend what’s broken and seal what must not open. A quiet tool. A sticky promise."
    };
    public static ToolItemData Pliers => new ToolItemData
    {
        itemName = "Pliers",
        condition = 90,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.WireCutting,
        ToolFunction.Crafting,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = false,
        meleeType = MeleeType.None,
        

        craftingRecipe = new List<string> { "Steel Jaws", "Pivot Joint", "Rubber Grip" },
        itemTags = new List<string> { "Tool", "Utility", "Crafting", "Wire", "Ritual" },

        brand = "Gripforge Tools",
        survivorNotes = "Used to sever wires, pull teeth, and end connections. A quiet tool. A final gesture."
    };
    public static ToolItemData MoleGrips => new ToolItemData
    {
        itemName = "Mole Grips",
        condition = 87,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.Utility,
        ToolFunction.RitualUse,
        ToolFunction.Vehicle_SparkPlugAccess,
        ToolFunction.Generator_SparkPlugAccess,
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 24f,
        armorPierce = 6f,
        critChance = 2f,
        staminaCost = 10f,
        bleedChance = 0.08f,
        stunChance = 18f,

        shockMultiplier = 1.1f,
        forceMultiplier = 1.3f,
        bluntForceBonus = 1.05f,
        swingSpeed = 1.1f,

        craftingRecipe = new List<string> { "Locking Jaw", "Steel Frame", "Adjustment Screw" },
        itemTags = new List<string> { "Tool", "Melee", "Blunt", "Clamp", "Utility", "Ritual" },

        brand = "Vicehold Engineering",
        survivorNotes = "Used to grip and not let go. A tool of stubborn resolve. When hands fail, these jaws remain."
    };
    public static ToolItemData Pickaxe => new ToolItemData
    {
        itemName = "Pickaxe",
        condition = 80,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.Digging,
        ToolFunction.Gathering,
        ToolFunction.StoneWorking,
        ToolFunction.MetalWorking,
        ToolFunction.Demolition,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 36f,
        armorPierce = 12f,
        critChance = 5f,
        staminaCost = 16f,
        bleedChance = 0.22f,
        stunChance = 30f,

        shockMultiplier = 1.4f,
        forceMultiplier = 1.7f,
        bluntForceBonus = 1.3f,
        swingSpeed = 0.9f,

        craftingRecipe = new List<string> { "Forged Head", "Reinforced Shaft", "Grip Tape" },
        itemTags = new List<string> { "Tool", "Melee", "Blunt", "Digging", "Demolition", "StoneWorking", "MetalWorking", "Ritual" },

        brand = "Gravemarch Industrial",
        survivorNotes = "Used to break stone, breach metal, and dig graves. A tool of force and finality."
    };
    public static ToolItemData Scalpel => new ToolItemData
    {
        itemName = "Scalpel",
        condition = 95,
        canBeRepaired = false,
        repairOptions = new List<RepairMethod>(),

        functions = new List<ToolFunction>
    {
        ToolFunction.MedicalUse,
        ToolFunction.Skinning,
        ToolFunction.Butchering,
        ToolFunction.Crafting,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Tool,

        baseDamage = 12f,
        armorPierce = 18f,
        critChance = 14f,
        staminaCost = 6f,
        bleedChance = 0.42f,
        stunChance = 4f,

        shockMultiplier = 0.8f,
        forceMultiplier = 0.6f,
        bluntForceBonus = 0f,
        swingSpeed = 1.4f,

        craftingRecipe = new List<string> { "Surgical Blade", "Sterile Handle" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Medical", "Skinning", "Butchering", "Crafting", "Ritual" },

        brand = "Sanctum Instruments",
        survivorNotes = "Used to part flesh and fate. A tool of precision, mercy, and ritual incision."
    };
    public static ToolItemData NailGun => new ToolItemData
    {
        itemName = "Nail Gun",
        condition = 82,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.Building,
        ToolFunction.Sealing,
        ToolFunction.Crafting,
        ToolFunction.Demolition,
        ToolFunction.ImprovisedWeapon,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Tool,

        baseDamage = 26f,
        armorPierce = 14f,
        critChance = 6f,
        staminaCost = 10f,
        bleedChance = 0.28f,
        stunChance = 12f,

        shockMultiplier = 1.0f,
        forceMultiplier = 1.2f,
        bluntForceBonus = 0.4f,
        swingSpeed = 1.2f,

        craftingRecipe = new List<string> { "Compressor Core", "Steel Barrel", "Nail Cartridge" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Building", "Crafting", "Sealing", "Demolition", "Ritual", "ImprovisedWeapon" },

        brand = "Bindwell Systems",
        survivorNotes = "Used to build shelters and seal coffins. Fires nails and fate. A tool that doesn’t ask permission."
    };
    public static ToolItemData Broom => new ToolItemData
    {
        itemName = "Broom",
        condition = 78,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Glue },

        functions = new List<ToolFunction>
    {
        ToolFunction.Utility,
        ToolFunction.Crafting,
        ToolFunction.RitualUse,
        ToolFunction.ImprovisedWeapon
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 16f,
        armorPierce = 2f,
        critChance = 1f,
        staminaCost = 8f,
        bleedChance = 0.04f,
        stunChance = 10f,

        shockMultiplier = 0.9f,
        forceMultiplier = 1.0f,
        bluntForceBonus = 0.8f,
        swingSpeed = 1.3f,

        craftingRecipe = new List<string> { "Wooden Shaft", "Bristle Head", "Binding Cord" },
        itemTags = new List<string> { "Tool", "Melee", "Blunt", "Utility", "Crafting", "Ritual", "ImprovisedWeapon" },

        brand = "Sanctum Domestic",
        survivorNotes = "Used to clear debris and bad omens. A tool of peace, turned staff when needed. Sweeps paths and sins alike."
    };
    public static ToolItemData ImprovisedHammer => new ToolItemData
    {
        itemName = "Improvised Hammer",
        condition = 54,
        canBeRepaired = false,
        repairOptions = new List<RepairMethod>(),

        functions = new List<ToolFunction>
    {
        ToolFunction.Building,
        ToolFunction.Demolition,
        ToolFunction.ImprovisedWeapon,
        ToolFunction.ImprovisedTool,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,
        subclass = MeleeSubclass.Tool,

        baseDamage = 22f,
        armorPierce = 6f,
        critChance = 2f,
        staminaCost = 10f,
        bleedChance = 0.08f,
        stunChance = 16f,

        shockMultiplier = 1.1f,
        forceMultiplier = 1.3f,
        bluntForceBonus = 1.0f,
        swingSpeed = 1.2f,

        craftingRecipe = new List<string> { "Rock", "Cloth Wrap", "Broken Handle" },
        itemTags = new List<string> { "Tool", "Melee", "Blunt", "Improvised", "Building", "Demolition", "Ritual" },

        brand = "Unbranded",
        survivorNotes = "Used when nothing else remains. A rock tied to hope. A tool of last rites and first strikes."
    };
    public static ToolItemData ImprovisedAxe => new ToolItemData
    {
        itemName = "Improvised Axe",
        condition = 48,
        canBeRepaired = false,
        repairOptions = new List<RepairMethod>(),

        functions = new List<ToolFunction>
    {
        ToolFunction.Woodcutting,
        ToolFunction.Demolition,
        ToolFunction.ImprovisedWeapon,
        ToolFunction.ImprovisedTool,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Tool,

        baseDamage = 30f,
        armorPierce = 10f,
        critChance = 4f,
        staminaCost = 14f,
        bleedChance = 0.26f,
        stunChance = 18f,

        shockMultiplier = 1.2f,
        forceMultiplier = 1.5f,
        bluntForceBonus = 0.6f,
        swingSpeed = 1.0f,

        craftingRecipe = new List<string> { "Rusty Blade", "Wooden Shaft", "Binding Cord" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Improvised", "Woodcutting", "Demolition", "Ritual" },

        brand = "Unbranded",
        survivorNotes = "Used to split wood and fate. A blade lashed to memory. A tool of survival and sacrifice."
    };
    public static ToolItemData ImprovisedFishingPole => new ToolItemData
    {
        itemName = "Improvised Fishing Pole",
        condition = 42,
        canBeRepaired = false,
        repairOptions = new List<RepairMethod>(),

        functions = new List<ToolFunction>
    {
        ToolFunction.Fishing,
        ToolFunction.Gathering,
        ToolFunction.ImprovisedTool,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = false,
        meleeType = MeleeType.None,

        craftingRecipe = new List<string> { "Flexible Branch", "Twine", "Bent Nail" },
        itemTags = new List<string> { "Tool", "Utility", "Fishing", "Gathering", "Improvised", "Ritual" },

        brand = "Unbranded",
        survivorNotes = "Used to pull life from water. A pole of hope and hunger. Casts prayers more than bait."
    };
    public static ToolItemData FishingNet => new ToolItemData
    {
        itemName = "Fishing Net",
        condition = 76,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.CableTies, RepairMethod.Rope },

        functions = new List<ToolFunction>
    {
        ToolFunction.Fishing,
        ToolFunction.Gathering,
        ToolFunction.Crafting,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = false,
        meleeType = MeleeType.None,

        craftingRecipe = new List<string> { "Woven Mesh", "Anchor Weights", "Binding Cord" },
        itemTags = new List<string> { "Tool", "Utility", "Fishing", "Gathering", "Crafting", "Ritual" },

        brand = "Bindwell Marine",
        survivorNotes = "Used to trap life in silence. A tool of quiet harvest. Cast wide, pull slow, hope deep."
    };
    public static ToolItemData ImprovisedFishingNet => new ToolItemData
    {
        itemName = "Improvised Fishing Net",
        condition = 38,
        canBeRepaired = false,
        repairOptions = new List<RepairMethod>(),

        functions = new List<ToolFunction>
    {
        ToolFunction.Fishing,
        ToolFunction.Gathering,
        ToolFunction.ImprovisedTool,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = false,
        meleeType = MeleeType.None,

        craftingRecipe = new List<string> { "Torn Fabric", "Twine", "Rusty Weights" },
        itemTags = new List<string> { "Tool", "Utility", "Fishing", "Gathering", "Improvised", "Ritual" },

        brand = "Unbranded",
        survivorNotes = "Used to trap hope in shallow waters. A net of knots and prayers. Cast wide, mend often, believe always."
    };
    public static ToolItemData FishingRod => new ToolItemData
    {
        itemName = "Fishing Rod",
        condition = 88,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Ducktape },

        functions = new List<ToolFunction>
    {
        ToolFunction.Fishing,
        ToolFunction.Gathering,
        ToolFunction.Crafting,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = false,
        meleeType = MeleeType.None,

        craftingRecipe = new List<string> { "Flexible Shaft", "Fishing Line", "Reel Assembly" },
        itemTags = new List<string> { "Tool", "Utility", "Fishing", "Gathering", "Crafting", "Ritual" },

        brand = "Sanctum Outdoors",
        survivorNotes = "Used to cast prayers into water. A tool of patience, silence, and sustenance."
    };
    public static ToolItemData MiniCarJack => new ToolItemData
    {
        itemName = "Mini Car Jack",
        condition = 84,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.Vehicle_TireChange,
        ToolFunction.Vehicle_SparkPlugAccess,
        ToolFunction.Vehicle_EngineAccess,
        ToolFunction.VehicleMaintenance,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = true,
        canGatherResources = false,
        hasMeleeSetup = false,
        meleeType = MeleeType.None,

        craftingRecipe = new List<string> { "Compact Frame", "Threaded Rod", "Lift Plate" },
        itemTags = new List<string> { "Tool", "Utility", "Vehicle", "Maintenance", "Ritual" },

        brand = "Axion Mechanics",
        survivorNotes = "Used to lift burdens quietly. A tool of leverage and access. Small enough to hide, strong enough to raise fate."
    };
    public static ToolItemData Chainsaw => new ToolItemData
    {
        itemName = "Chainsaw",
        condition = 74,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, },

        functions = new List<ToolFunction>
    {
        ToolFunction.Woodcutting,
        ToolFunction.Demolition,
        ToolFunction.Crafting,
        ToolFunction.ImprovisedWeapon,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Tool,

        baseDamage = 42f,
        armorPierce = 16f,
        critChance = 6f,
        staminaCost = 18f,
        bleedChance = 0.38f,
        stunChance = 24f,

        shockMultiplier = 1.5f,
        forceMultiplier = 1.8f,
        bluntForceBonus = 0.3f,
        swingSpeed = 0.85f,

        craftingRecipe = new List<string> { "Motor Assembly", "Chain Blade", "Fuel Cell" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Woodcutting", "Demolition", "Crafting", "Ritual", "ImprovisedWeapon" },

        brand = "Gravemarch Forestry",
        survivorNotes = "Used to fell trees and silence threats. A tool of noise and finality. Screams louder than its wielder."
    };
    public static ToolItemData WeldingTorch => new ToolItemData
    {
        itemName = "Welding Torch",
        condition = 72,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, },

        functions = new List<ToolFunction>
    {
        ToolFunction.Welding,
        ToolFunction.Demolition,
        ToolFunction.Crafting,
        ToolFunction.ImprovisedWeapon,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Tool,

        baseDamage = 34f,
        armorPierce = 14f,
        critChance = 5f,
        staminaCost = 16f,
        bleedChance = 0.26f,
        stunChance = 20f,

        shockMultiplier = 1.3f,
        forceMultiplier = 1.6f,
        bluntForceBonus = 0.2f,
        swingSpeed = 0.95f,

        craftingRecipe = new List<string> { "Torch Head", "Fuel Cell", "Ignition Coil" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Welding", "Crafting", "Demolition", "Ritual", "ImprovisedWeapon" },

        brand = "Gravemarch Industrial",
        survivorNotes = "Used to fuse metal and fate. A flame that binds, burns, and buries. Loud enough to silence doubt."
    };
    public static ToolItemData TinOpener => new ToolItemData
    {
        itemName = "Tin Opener",
        condition = 89,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Ducktape },

        functions = new List<ToolFunction>
    {
        ToolFunction.Cooking,
        ToolFunction.Utility,
        ToolFunction.Crafting,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = false,
        meleeType = MeleeType.None,

        craftingRecipe = new List<string> { "Steel Blade", "Rotating Arm", "Grip Handle" },
        itemTags = new List<string> { "Tool", "Utility", "Cooking", "Crafting", "Ritual" },

        brand = "Sanctum Domestic",
        survivorNotes = "Used to open meals and memories. A blade for hunger and hope. Small, but sacred."
    };
    public static ToolItemData WoodChisel => new ToolItemData
    {
        itemName = "Wood Chisel",
        condition = 83,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.Woodcutting,
        ToolFunction.Crafting,
        ToolFunction.Demolition,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Tool,

        baseDamage = 18f,
        armorPierce = 10f,
        critChance = 6f,
        staminaCost = 9f,
        bleedChance = 0.22f,
        stunChance = 8f,

        shockMultiplier = 0.95f,
        forceMultiplier = 1.1f,
        bluntForceBonus = 0.2f,
        swingSpeed = 1.3f,

        craftingRecipe = new List<string> { "Chisel Blade", "Wooden Grip", "Binding Cord" },
        itemTags = new List<string> { "Tool", "Melee", "Sharp", "Woodcutting", "Crafting", "Demolition", "Ritual" },

        brand = "Redmark Carpentry",
        survivorNotes = "Used to carve wood and fate. A blade for shaping, splitting, and silent expression."
    };
    public static ToolItemData GardenRake => new ToolItemData
    {
        itemName = "Garden Rake",
        condition = 76,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Ducktape },

        functions = new List<ToolFunction>
    {
        ToolFunction.Gathering,
        ToolFunction.Farming,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,

        baseDamage = 22f,
        armorPierce = 4f,
        critChance = 3f,
        staminaCost = 12f,
        bleedChance = 0.05f,
        stunChance = 14f,

        shockMultiplier = 1.2f,
        forceMultiplier = 1.3f,
        bluntForceBonus = 0.4f,
        swingSpeed = 0.85f,

        craftingRecipe = new List<string> { "Rake Head", "Wooden Shaft", "Binding Cord" },
        itemTags = new List<string> { "Tool", "Blunt", "Farming", "Gathering", "Utility", "Ritual" },

        brand = "Grimsoil Implements",
        survivorNotes = "Used to gather leaves and regrets. A wide sweep for clearing paths and punishing missteps."
    };
    public static ToolItemData Secateurs => new ToolItemData
    {
        itemName = "Secateurs",
        condition = 91,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.CableTies },

        functions = new List<ToolFunction>
    {
        ToolFunction.WireCutting,
        ToolFunction.Crafting,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,

        baseDamage = 14f,
        armorPierce = 6f,
        critChance = 8f,
        staminaCost = 6f,
        bleedChance = 0.35f,
        stunChance = 4f,

        shockMultiplier = 0.8f,
        forceMultiplier = 0.9f,
        bluntForceBonus = 0.1f,
        swingSpeed = 1.6f,

        craftingRecipe = new List<string> { "Blade Pair", "Spring Coil", "Grip Handle" },
        itemTags = new List<string> { "Tool", "Sharp", "Gardening", "Crafting", "Utility", "Ritual" },

        brand = "Greenbite Precision",
        survivorNotes = "Used to prune growth and silence. A whispering blade for delicate cuts and quiet rituals."
    };
    public static ToolItemData AngleGrinder => new ToolItemData
    {
        itemName = "Angle Grinder",
        condition = 68,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit,},

        functions = new List<ToolFunction>
    {
        ToolFunction.MetalWorking,
        ToolFunction.Demolition,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = true,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,

        baseDamage = 34f,
        armorPierce = 18f,
        critChance = 5f,
        staminaCost = 20f,
        bleedChance = 0.15f,
        stunChance = 22f,

        shockMultiplier = 1.5f,
        forceMultiplier = 1.6f,
        bluntForceBonus = 0.6f,
        swingSpeed = 0.7f,

        craftingRecipe = new List<string> { "Motor Core", "Cutting Disc", "Power Handle", "Wiring Kit" },
        itemTags = new List<string> { "Tool", "Powered", "Metalcutting", "Demolition", "Utility", "Ritual" },

        brand = "Forgehowl Industrial",
        survivorNotes = "Used to slice steel and scream defiance. A roaring edge for demolition and declarations."
    };
    public static ToolItemData MetalFile => new ToolItemData
    {
        itemName = "Metal File",
        condition = 88,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, },

        functions = new List<ToolFunction>
    {
        ToolFunction.MetalWorking,
        ToolFunction.Sharpening,
        ToolFunction.Crafting,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Blunt,

        baseDamage = 10f,
        armorPierce = 2f,
        critChance = 2f,
        staminaCost = 4f,
        bleedChance = 0.05f,
        stunChance = 3f,

        shockMultiplier = 0.6f,
        forceMultiplier = 0.7f,
        bluntForceBonus = 0.1f,
        swingSpeed = 1.8f,

        craftingRecipe = new List<string> { "File Blade", "Grip Handle", "Binding Cord" },
        itemTags = new List<string> { "Tool", "Metalworking", "Sharpening", "Crafting", "Utility", "Ritual" },

        brand = "Edgecraft Precision",
        survivorNotes = "Used to refine blades and intentions. A rasp for shaping steel and sharpening resolve."
    };
    public static ToolItemData StoneChisel => new ToolItemData
    {
        itemName = "Stone Chisel",
        condition = 79,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.ScrapMetal },

        functions = new List<ToolFunction>
    {
        ToolFunction.StoneWorking,
        ToolFunction.Crafting,
        ToolFunction.Demolition,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = true,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,

        baseDamage = 20f,
        armorPierce = 12f,
        critChance = 4f,
        staminaCost = 10f,
        bleedChance = 0.18f,
        stunChance = 10f,

        shockMultiplier = 1.1f,
        forceMultiplier = 1.2f,
        bluntForceBonus = 0.3f,
        swingSpeed = 1.2f,

        craftingRecipe = new List<string> { "Chisel Head", "Stone Grip", "Binding Cord" },
        itemTags = new List<string> { "Tool", "Sharp", "Stonecutting", "Crafting", "Demolition", "Ritual" },

        brand = "Gravemark Tools",
        survivorNotes = "Used to shape stone and memory. A tool for monuments, tombs, and the quiet violence of creation."
    };
    public static ToolItemData HoningSteel => new ToolItemData
    {
        itemName = "Honing Steel",
        condition = 87,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.None,},

        functions = new List<ToolFunction>
    {
        ToolFunction.Sharpening,
        ToolFunction.Utility,
        ToolFunction.RitualUse
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = false,
        meleeType = MeleeType.None,

        craftingRecipe = new List<string> { "Steel Rod", "Grip Handle", "Guard Ring" },
        itemTags = new List<string> { "Tool", "Sharpening", "Kitchen", "Utility", "Ritual" },

        brand = "Sanctum Culinary",
        survivorNotes = "Used to realign blades and focus. A rod for edge memory and kitchen rites."
    };



    // 🧱 Add more entries below, comma-safe
    // public static ToolItemData RitualSpade => new ToolItemData { ... };
    // public static ToolItemData SocketWrenchOfTheAncients => new ToolItemData { ... };
}
