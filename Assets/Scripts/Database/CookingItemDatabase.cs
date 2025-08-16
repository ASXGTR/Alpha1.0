using System.Collections.Generic;
using UnityEngine;

public static class CookingItemDatabase
{
    public static CookingItemData SmallSteelPot = new CookingItemData
    {
        itemName = "Small Steel Pot",
        itemType = CookingItemType.Pot,
        liquidCapacityML = 1200,
        slotCapacity = 6,

        supportsBoiling = true,
        supportsRoasting = true,
        supportsBaking = false,
        isOpenTop = true,
        isFireSafe = true,

        heatRetention = 1,
        cookSpeedMultiplier = 1,

        compatibleHeatSources = new List<string> { "Campfire", "StoveTop", "Grill" },
        itemTags = new List<string> { "Cookware", "Steel", "Lidless" },

        brand = "ForgeLine",
        survivorNotes = "Good for boiling berries or roasting roots. Loses heat fast—don’t wander off.",

        isLid = false,
        compatibleWithItemName = null,
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 2,
        condition = 100,
        inventorySlotSize = 2
    };

    public static CookingItemData MediumSteelPot = new CookingItemData
    {
        itemName = "Medium Steel Pot",
        itemType = CookingItemType.Pot,
        liquidCapacityML = 2400,
        slotCapacity = 10,

        supportsBoiling = true,
        supportsRoasting = true,
        supportsBaking = false,
        isOpenTop = true,
        isFireSafe = true,

        heatRetention = 1,
        cookSpeedMultiplier = 1,

        compatibleHeatSources = new List<string> { "Campfire", "StoveTop", "Grill" },
        itemTags = new List<string> { "Cookware", "Steel", "Lidless" },

        brand = "ForgeLine",
        survivorNotes = "Big enough for stew batches. Don’t forget to stir or it’ll crust up.",

        isLid = false,
        compatibleWithItemName = null,
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 3,
        condition = 100,
        inventorySlotSize = 3
    };

    public static CookingItemData LargeSteelPot = new CookingItemData
    {
        itemName = "Large Steel Pot",
        itemType = CookingItemType.Pot,
        liquidCapacityML = 3600,
        slotCapacity = 16,

        supportsBoiling = true,
        supportsRoasting = true,
        supportsBaking = false,
        isOpenTop = true,
        isFireSafe = true,

        heatRetention = 1,
        cookSpeedMultiplier = 1,

        compatibleHeatSources = new List<string> { "Campfire", "StoveTop", "Grill" },
        itemTags = new List<string> { "Cookware", "Steel", "Lidless" },

        brand = "ForgeLine",
        survivorNotes = "Feeds a crew. Heavy, loud, and prone to soot scars. Still a classic.",

        isLid = false,
        compatibleWithItemName = null,
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 4,
        condition = 100,
        inventorySlotSize = 4
    };
    public static CookingItemData SteelPotLid = new CookingItemData
    {
        itemName = "Steel Pot Lid",
        itemType = CookingItemType.Lid,
        liquidCapacityML = 0,
        slotCapacity = 1,

        supportsBoiling = false,
        supportsRoasting = false,
        supportsBaking = false,
        isOpenTop = false,
        isFireSafe = true,

        heatRetention = 2,
        cookSpeedMultiplier = 1,

        compatibleHeatSources = new List<string> { "Campfire", "StoveTop" },
        itemTags = new List<string> { "Lid", "Steel" },

        brand = "ForgeLine",
        survivorNotes = "Fits most steel pots. Traps heat, blocks ash, and muffles boil noise.",

        isLid = true,
        compatibleWithItemName = "Small Steel Pot",
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 1,
        condition = 100,
        inventorySlotSize = 1
    };

    public static CookingItemData SteamRackInsert = new CookingItemData
    {
        itemName = "Steam Rack Insert",
        itemType = CookingItemType.Insert,
        liquidCapacityML = 0,
        slotCapacity = 2,

        supportsBoiling = false,
        supportsRoasting = false,
        supportsBaking = true,
        isOpenTop = true,
        isFireSafe = true,

        heatRetention = 1,
        cookSpeedMultiplier = 1,

        compatibleHeatSources = new List<string> { "StoveTop", "Campfire" },
        itemTags = new List<string> { "Insert", "Steam", "Rack" },

        brand = "ForgeLine",
        survivorNotes = "Elevates food above boiling water. Great for dumplings, risky for eggs.",

        isLid = false,
        compatibleWithItemName = "Medium Steel Pot",
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 1,
        condition = 100,
        inventorySlotSize = 1
    };
    public static CookingItemData OilSafePan = new CookingItemData
    {
        itemName = "Oil-Safe Pan",
        itemType = CookingItemType.Pan,
        liquidCapacityML = 800,
        slotCapacity = 4,

        supportsBoiling = false,
        supportsRoasting = true,
        supportsBaking = false,
        isOpenTop = true,
        isFireSafe = true,

        heatRetention = 1,
        cookSpeedMultiplier = 2,

        compatibleHeatSources = new List<string> { "StoveTop", "Grill" },
        itemTags = new List<string> { "Pan", "OilSafe", "Steel" },

        brand = "Ashguard",
        survivorNotes = "Built for high-temp oil work. Don’t use on open flame unless you like fireworks.",

        isLid = false,
        compatibleWithItemName = null,
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 2,
        condition = 100,
        inventorySlotSize = 2
    };

    public static CookingItemData FuelHazardPot = new CookingItemData
    {
        itemName = "Fuel-Hazard Pot",
        itemType = CookingItemType.Pot,
        liquidCapacityML = 1800,
        slotCapacity = 8,

        supportsBoiling = true,
        supportsRoasting = false,
        supportsBaking = false,
        isOpenTop = true,
        isFireSafe = false,

        heatRetention = 1,
        cookSpeedMultiplier = 1,

        compatibleHeatSources = new List<string> { "StoveTop" },
        itemTags = new List<string> { "Pot", "FuelHazard", "Aluminum" },

        brand = "ThermaLite",
        survivorNotes = "Lightweight but risky. Melts under direct flame. Use with caution.",

        isLid = false,
        compatibleWithItemName = null,
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 1,
        condition = 100,
        inventorySlotSize = 2
    };
    public static CookingItemData ClayBakingDish = new CookingItemData
    {
        itemName = "Clay Baking Dish",
        itemType = CookingItemType.Bakeware,
        liquidCapacityML = 600,
        slotCapacity = 3,

        supportsBoiling = false,
        supportsRoasting = false,
        supportsBaking = true,
        isOpenTop = true,
        isFireSafe = true,

        heatRetention = 2,
        cookSpeedMultiplier = 1,

        compatibleHeatSources = new List<string> { "Oven", "Campfire" },
        itemTags = new List<string> { "Bakeware", "Clay", "Baking" },

        brand = "Earthfire",
        survivorNotes = "Holds heat like a grudge. Perfect for root bakes and ash pies.",

        isLid = false,
        compatibleWithItemName = null,
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 2,
        condition = 100,
        inventorySlotSize = 2
    };

    public static CookingItemData HybridCookPot = new CookingItemData
    {
        itemName = "Hybrid Cook Pot",
        itemType = CookingItemType.Pot,
        liquidCapacityML = 2000,
        slotCapacity = 9,

        supportsBoiling = true,
        supportsRoasting = true,
        supportsBaking = true,
        isOpenTop = true,
        isFireSafe = true,

        heatRetention = 2,
        cookSpeedMultiplier = 2,

        compatibleHeatSources = new List<string> { "Campfire", "StoveTop", "Oven" },
        itemTags = new List<string> { "Cookware", "Hybrid", "AllPurpose" },

        brand = "VersaHeat",
        survivorNotes = "Does everything but sing lullabies. Overkill for solo meals, ideal for rituals.",

        isLid = false,
        compatibleWithItemName = null,
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 3,
        condition = 100,
        inventorySlotSize = 3
    }; public static CookingItemData RustedPan = new CookingItemData
    {
        itemName = "Rusted Pan",
        itemType = CookingItemType.Pan,
        liquidCapacityML = 500,
        slotCapacity = 2,

        supportsBoiling = false,
        supportsRoasting = true,
        supportsBaking = false,
        isOpenTop = true,
        isFireSafe = false,

        heatRetention = 0,
        cookSpeedMultiplier = 0,

        compatibleHeatSources = new List<string> { "Grill" },
        itemTags = new List<string> { "Pan", "Rusted", "Scrap" },

        brand = "Unknown",
        survivorNotes = "Found in a ditch. Might poison you. Might make the best meal of your life.",

        isLid = false,
        compatibleWithItemName = null,
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 1,
        condition = 45,
        inventorySlotSize = 1
    };

    public static CookingItemData CeramicSteamer = new CookingItemData
    {
        itemName = "Ceramic Steamer",
        itemType = CookingItemType.Insert,
        liquidCapacityML = 0,
        slotCapacity = 3,

        supportsBoiling = false,
        supportsRoasting = false,
        supportsBaking = true,
        isOpenTop = true,
        isFireSafe = true,

        heatRetention = 2,
        cookSpeedMultiplier = 1,

        compatibleHeatSources = new List<string> { "StoveTop", "Oven" },
        itemTags = new List<string> { "Insert", "Ceramic", "Steamer" },

        brand = "SteamCraft",
        survivorNotes = "Gentle on dumplings, brutal on brittle nerves. Cracks if dropped.",

        isLid = false,
        compatibleWithItemName = "Hybrid Cook Pot",
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 2,
        condition = 100,
        inventorySlotSize = 2
    };

    public static CookingItemData CeramicCookingPot = new CookingItemData
    {
        itemName = "Ceramic Cooking Pot",
        itemType = CookingItemType.Bakeware,
        liquidCapacityML = 1600,
        slotCapacity = 6,

        supportsBoiling = false,
        supportsRoasting = false,
        supportsBaking = true,
        isOpenTop = true,
        isFireSafe = true,

        heatRetention = 2,
        cookSpeedMultiplier = 1,

        compatibleHeatSources = new List<string> { "Oven", "Campfire" },
        itemTags = new List<string> { "Bakeware", "Ceramic", "Pot" },

        brand = "ClayCrest",
        survivorNotes = "Gentle heat, fragile soul. Best for slow bakes and herbal infusions.",

        isLid = false,
        compatibleWithItemName = null,
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 2,
        condition = 100,
        inventorySlotSize = 2
    };

    public static CookingItemData CeramicCookingPotLid = new CookingItemData
    {
        itemName = "Ceramic Pot Lid",
        itemType = CookingItemType.Lid,
        liquidCapacityML = 0,
        slotCapacity = 1,

        supportsBoiling = false,
        supportsRoasting = false,
        supportsBaking = false,
        isOpenTop = false,
        isFireSafe = true,

        heatRetention = 2,
        cookSpeedMultiplier = 0,

        compatibleHeatSources = new List<string> { "Oven" },
        itemTags = new List<string> { "Lid", "Ceramic" },

        brand = "ClayCrest",
        survivorNotes = "Seals in steam, cracks under pressure. Handle with reverence.",

        isLid = true,
        compatibleWithItemName = "Ceramic Cooking Pot",
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 1,
        condition = 100,
        inventorySlotSize = 1
    };

    public static CookingItemData CeramicCookingPotLarge = new CookingItemData
    {
        itemName = "Ceramic Cooking Pot Large",
        itemType = CookingItemType.Bakeware,
        liquidCapacityML = 2800,
        slotCapacity = 10,

        supportsBoiling = false,
        supportsRoasting = false,
        supportsBaking = true,
        isOpenTop = true,
        isFireSafe = true,

        heatRetention = 3,
        cookSpeedMultiplier = 1,

        compatibleHeatSources = new List<string> { "Oven", "Campfire" },
        itemTags = new List<string> { "Bakeware", "Ceramic", "Pot" },

        brand = "ClayCrest",
        survivorNotes = "Feeds a family, fears the flame. Bake slow, lift slow, pray often.",

        isLid = false,
        compatibleWithItemName = null,
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 3,
        condition = 100,
        inventorySlotSize = 3
    };

    public static CookingItemData CeramicPotLidLarge = new CookingItemData
    {
        itemName = "Ceramic Pot Lid Large",
        itemType = CookingItemType.Lid,
        liquidCapacityML = 0,
        slotCapacity = 1,

        supportsBoiling = false,
        supportsRoasting = false,
        supportsBaking = false,
        isOpenTop = false,
        isFireSafe = true,

        heatRetention = 3,
        cookSpeedMultiplier = 0,

        compatibleHeatSources = new List<string> { "Oven" },
        itemTags = new List<string> { "Lid", "Ceramic", "Large" },

        brand = "ClayCrest",
        survivorNotes = "Heavy, brittle, sacred. Don’t drop it unless you’re ready to mourn.",

        isLid = true,
        compatibleWithItemName = "Ceramic Cooking Pot Large",
        hasLidAttached = false,
        attachedLidItemName = null,

        weight = 2,
        condition = 100,
        inventorySlotSize = 2
    };
    public static CookingItemData GrillRack = new CookingItemData
    {
        itemID = "grillrack_001",
        itemName = "Grill Rack",
        displayName = "Grill Rack",
        modelPrefab = null,

        category = CookingCategory.SupportFrame,
        itemType = CookingItemType.SupportFrame,
        heatSourceType = HeatSourceType.None,

        condition = 100,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod>(),
        functions = new List<CookingFunction>(),

        liquidCapacityML = 0,
        slotCapacity = 6,
        liquidVolumeLimit = 0f,

        supportsBoiling = false,
        supportsRoasting = true,
        supportsBaking = false,
        isOpenTop = true,
        isFireSafe = true,

        heatRetention = 0f,
        cookSpeedMultiplier = 1f,

        compatibleHeatSources = new List<string> { "Campfire", "OpenFlame" },
        exclusiveMethods = new List<CookingMethod>(),

        isLid = false,
        compatibleWithItemName = null,
        hasLidAttached = false,
        attachedLidItemName = null,

        craftingRecipe = new List<string>(),
        itemTags = new List<string> { "Grill", "Rack", "AttachmentOnly", "TripodDependent" },
        loreTags = new List<string>(),

        brand = "IronRoot",
        survivorNotes = "Requires tripod or chain to suspend. Without one, it’s just scrap metal.",

        slotOccupancy = new SlotOccupancy
        {
            widthSlots = 3,
            depthSlots = 2,
            heightClearance = 1
        },

        attachmentPoints = new List<AttachmentPoint>
        {
            new AttachmentPoint
            {
                type = CookingItemAttachmentType.SupportFrame,
                required = true,
                compatibleItems = new string[] { "Tripod", "Improvised Tripod", "Tripod Chain" }
            }
        },

        hazardProfile = new HazardProfile
        {
            ignitionRisk = 0.1f,
            flareUpChance = 0.3f,
            requiresVentilation = true
        },

        inventorySlotSize = 2,
        weight = 3,
        requiresAttachmentToFunction = true
    },
        public static ToolItemData MortarPestle => new ToolItemData
        {
            itemName = "Mortar & Pestle",
            condition = 100,
            canBeRepaired = true,
            repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Glue },
            functions = new List<ToolFunction>
    {
        ToolFunction.Cooking,
        ToolFunction.Crafting,
        ToolFunction.ChemicalUse
    },
            supportsVehicleUse = false,
            canGatherResources = false,
            hasMeleeSetup = false,
            meleeType = MeleeType.None,
            subclass = MeleeSubclass.Kitchen,

            baseDamage = 0f,
            armorPierce = 0f,
            critChance = 0f,
            staminaCost = 0f,
            bleedChance = 0f,
            stunChance = 0f,

            shockMultiplier = 1f,
            forceMultiplier = 1f,
            bluntForceBonus = 1f,
            swingSpeed = 1f,

            isThrowable = false,

            craftingRecipe = new List<string> { "Stone Bowl", "Grinding Handle" },
            itemTags = new List<string> { "Tool", "Cooking", "Crafting", "Chemical" },

            brand = "Dustroot Ceramics",
            survivorNotes = "Used to grind herbs, seeds, and regrets into powder. Essential for spice rites and chemical prep."
        };

    public static ToolItemData SteakKnife => new ToolItemData
    {
        itemName = "Steak Knife",
        condition = 90,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Welding },
        functions = new List<ToolFunction>
    {
        ToolFunction.Cooking,
        ToolFunction.Skinning,
        ToolFunction.Butchering,
        ToolFunction.ImprovisedWeapon
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Sharp,
        subclass = MeleeSubclass.Kitchen,

        baseDamage = 22f,
        armorPierce = 10f,
        critChance = 14f,
        staminaCost = 8f,
        bleedChance = 25f,
        stunChance = 10f,

        shockMultiplier = 1f,
        forceMultiplier = 1.2f,
        bluntForceBonus = 1f,
        swingSpeed = 1.3f,


        craftingRecipe = new List<string> { "Steel Blade", "Grip Wrap" },
        itemTags = new List<string> { "Tool", "Cooking", "Melee", "Sharp", "Skinning", "Butchering" },

        brand = "Edgewell Cutlery",
        survivorNotes = "Cuts meat, skin, and silence. A kitchen essential turned survival staple."
    };

    public static ToolItemData SteelFork => new ToolItemData
    {
        itemName = "Steel Fork",
        condition = 85,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.Ducktape, RepairMethod.ToolRepairKit },
        functions = new List<ToolFunction>
    {
        ToolFunction.Cooking,
        ToolFunction.Utility,
        ToolFunction.ImprovisedWeapon
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Piercing,
        subclass = MeleeSubclass.Kitchen,

        baseDamage = 12f,
        armorPierce = 6f,
        critChance = 10f,
        staminaCost = 6f,
        bleedChance = 15f,
        stunChance = 5f,

        shockMultiplier = 1f,
        forceMultiplier = 1f,
        bluntForceBonus = 1f,
        swingSpeed = 1.2f,


        craftingRecipe = new List<string> { "Steel Prongs", "Handle Wrap" },
        itemTags = new List<string> { "Tool", "Cooking", "Melee", "Piercing", "Improvised" },

        brand = "Forksmith & Sons",
        survivorNotes = "Not just for meat—can be used to jab, pry, or settle disputes over rations."
    };
    public static ToolItemData BBQFork => new ToolItemData
    {
        itemName = "BBQ Fork",
        condition = 95,
        canBeRepaired = true,
        repairOptions = new List<RepairMethod> { RepairMethod.ToolRepairKit, RepairMethod.Ducktape },
        functions = new List<ToolFunction>
    {
        ToolFunction.Cooking,
        ToolFunction.RitualUse,
        ToolFunction.ImprovisedWeapon
    },
        supportsVehicleUse = false,
        canGatherResources = false,
        hasMeleeSetup = true,
        meleeType = MeleeType.Piercing,
        subclass = MeleeSubclass.Kitchen,

        baseDamage = 18f,
        armorPierce = 9f,
        critChance = 12f,
        staminaCost = 7f,
        bleedChance = 20f,
        stunChance = 8f,

        shockMultiplier = 1f,
        forceMultiplier = 1.1f,
        bluntForceBonus = 1f,
        swingSpeed = 1.2f,

        craftingRecipe = new List<string> { "Steel Tines", "Heatproof Handle" },
        itemTags = new List<string> { "Tool", "Cooking", "Roasting", "OpenFlame", "Melee", "Piercing" },

        brand = "Ashbrand Grilling Co.",
        survivorNotes = "Used to roast meat and vegetables directly over flame. Can double as a deterrent when dinner gets interrupted."
    };

    public static ToolItemData SharpenedLongStick => new ToolItemData
    {
        itemName = "Sharpened Long Stick",
        condition = 70,
        canBeRepaired = false,
        repairOptions = new List<RepairMethod> { RepairMethod.None },
        functions = new List<ToolFunction>
    {
        ToolFunction.Cooking,
        ToolFunction.RitualUse,
        ToolFunction.ImprovisedWeapon,
    },
        supportsVehicleUse = false,
        canGatherResources = true,

        hasMeleeSetup = true,
        meleeType = MeleeType.Piercing,
        subclass = MeleeSubclass.Improvised,

        baseDamage = 14f,
        armorPierce = 5f,
        critChance = 8f,
        staminaCost = 6f,
        bleedChance = 10f,
        stunChance = 5f,

        shockMultiplier = 1f,
        forceMultiplier = 1f,
        bluntForceBonus = 1f,
        swingSpeed = 1.1f,

        craftingRecipe = new List<string> { "Long Stick", "Sharpening Stone" },
        itemTags = new List<string> { "Tool", "Cooking", "Primitive", "Roasting", "Improvised", "Piercing" },

        brand = "None",
        survivorNotes = "Used to roast meat and vegetables over open flame. No metal, no polish—just fire and instinct."
    };





