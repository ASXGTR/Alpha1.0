using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MiscFoodItemDatabase", menuName = "Databases/Misc Food Item Database")]
public class MiscFoodItemDatabase : ScriptableObject
{
    [System.Serializable]
    public class MiscFoodItemEntry
    {
        [Header("Identity")]
        public string itemID;
        public string displayName;
        public Sprite icon;
        public GameObject prefab;

        [Header("Stats")]
        public int hungerChange;
        public int hydrationChange;
        public float weight;
        public int maxStackSize;

        [Header("Disease Profile")]
        public float foodPoisoningChance;
        public float salmonellaChance;
        public float parasiteChance;
        public float zombiePathogenChance;

        [Header("Cooking & Prep")]
        public bool isCooked;
        public bool isPackaged;
        public bool canBeToasted;
        public bool canBeMicrowaved;
        public bool canBeRehydrated;
        public bool canBeFermented;

        [Header("Yield & Breakdown")]
        public bool canBeSplit;
        public int minPortions;
        public int maxPortions;
        public string secondaryItemID; // e.g. wrapper, crumbs, bait
        public int minSecondaryYield;
        public int maxSecondaryYield;

        [Header("Tags")]
        public List<string> tags = new();
    }

    public List<MiscFoodItemEntry> miscFoodItems = new()
    {
        new MiscFoodItemEntry
        {
            itemID = "worm_edible_bait",
            displayName = "Worm",
            icon = null, // Assign in inspector
            prefab = null, // Assign in inspector

            hungerChange = 2,
            hydrationChange = -1,
            weight = 0.05f,
            maxStackSize = 50,

            foodPoisoningChance = 0.15f,
            salmonellaChance = 0.10f,
            parasiteChance = 0.25f,
            zombiePathogenChance = 0.02f,

            isCooked = false,
            isPackaged = false,
            canBeToasted = false,
            canBeMicrowaved = false,
            canBeRehydrated = false,
            canBeFermented = false,

            canBeSplit = false,
            minPortions = 0,
            maxPortions = 0,
            secondaryItemID = "",
            minSecondaryYield = 0,
            maxSecondaryYield = 0,

            tags = new List<string>
            {
                "edible",
                "bait",
                "protein",
                "lowMorale",
                "foraged",
                "grossSnack"
            }
        },
        new MiscFoodItemEntry
{
    itemID = "maggot_edible_bait",
    displayName = "Maggots",
    icon = null, // Assign in inspector
    prefab = null, // Assign in inspector

    hungerChange = 1,
    hydrationChange = -1,
    weight = 0.03f,
    maxStackSize = 100,

    foodPoisoningChance = 0.20f,
    salmonellaChance = 0.12f,
    parasiteChance = 0.30f,
    zombiePathogenChance = 0.01f,

    isCooked = false,
    isPackaged = false,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = false,
    minPortions = 0,
    maxPortions = 0,
    secondaryItemID = "",
    minSecondaryYield = 0,
    maxSecondaryYield = 0,

    tags = new List<string>
    {
        "edible",
        "bait",
        "protein",
        "lowMorale",
        "foraged",
        "grossSnack"
    }
},new MiscFoodItemEntry
{
    itemID = "finger_loops_snack",
    displayName = "Finger Loops",
    icon = null, // Assign in inspector
    prefab = null, // Assign in inspector

    hungerChange = 8,
    hydrationChange = -3,
    weight = 0.1f,
    maxStackSize = 20,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 5,
    maxPortions = 10,
    secondaryItemID = "empty_packet",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "snack",
        "packaged",
        "crisps",
        "moraleBoost",
        "salty",
        "processed"
    }
},
        new MiscFoodItemEntry
{
    itemID = "finger_fries_snack",
    displayName = "Finger Fries",
    icon = null, // Assign in inspector
    prefab = null, // Assign in inspector

    hungerChange = 9,
    hydrationChange = -4,
    weight = 0.12f,
    maxStackSize = 20,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 6,
    maxPortions = 12,
    secondaryItemID = "empty_packet",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "snack",
        "packaged",
        "crisps",
        "moraleBoost",
        "salty",
        "processed",
        "potatoAdjacent"
    }
},
        new MiscFoodItemEntry
{
    itemID = "runners_saltvinegar",
    displayName = "Runners - Salt 'n' Vinegar",
    icon = null, // Assign in inspector
    prefab = null, // Assign in inspector

    hungerChange = 7,
    hydrationChange = -5,
    weight = 0.1f,
    maxStackSize = 20,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 5,
    maxPortions = 10,
    secondaryItemID = "empty_packet",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "snack",
        "packaged",
        "crisps",
        "moraleBoost",
        "salty",
        "acidic",
        "processed",
        "flavour_saltvinegar"
    }
},
        new MiscFoodItemEntry
{
    itemID = "runners_cheeseonion",
    displayName = "Runners - Cheese 'n' Onion",
    icon = null, // Assign in inspector
    prefab = null, // Assign in inspector

    hungerChange = 8,
    hydrationChange = -4,
    weight = 0.1f,
    maxStackSize = 20,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 5,
    maxPortions = 10,
    secondaryItemID = "empty_packet",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "snack",
        "packaged",
        "crisps",
        "moraleBoost",
        "savory",
        "processed",
        "flavour_cheeseonion"
    }
},
        new MiscFoodItemEntry
{
    itemID = "choco_fingers_snack",
    displayName = "Choco Fingers",
    icon = null, // Assign in inspector
    prefab = null, // Assign in inspector

    hungerChange = 10,
    hydrationChange = -2,
    weight = 0.12f,
    maxStackSize = 20,

    foodPoisoningChance = 0.02f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 6,
    maxPortions = 12,
    secondaryItemID = "empty_packet",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "snack",
        "packaged",
        "biscuit",
        "chocolate",
        "processed",
        "moraleBoost",
        "fingerFood",
        "survivorTreat"
    }
},
        new MiscFoodItemEntry
{
    itemID = "jammy_wheels_snack",
    displayName = "Jammy Wheels",
    icon = null, // Assign in inspector
    prefab = null, // Assign in inspector

    hungerChange = 14,
    hydrationChange = -3,
    weight = 0.18f,
    maxStackSize = 12,

    foodPoisoningChance = 0.03f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 2,
    maxPortions = 4,
    secondaryItemID = "sticky_wrapper",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "snack",
        "packaged",
        "biscuit",
        "chocolate",
        "jam",
        "processed",
        "moraleBoost",
        "fingerFood",
        "survivorTreat"
    }
},
        new MiscFoodItemEntry
{
    itemID = "pluto_bar_snack",
    displayName = "Pluto Bar",
    icon = null, // Assign in inspector
    prefab = null, // Assign in inspector

    hungerChange = 16,
    hydrationChange = -4,
    weight = 0.15f,
    maxStackSize = 16,

    foodPoisoningChance = 0.02f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 2,
    maxPortions = 3,
    secondaryItemID = "empty_wrapper",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "snack",
        "packaged",
        "chocolate",
        "nougat",
        "processed",
        "moraleBoost",
        "energyBar",
        "survivorTreat",
        "fakeBrand"
    }
},
        new MiscFoodItemEntry
{
    itemID = "blitz_crackers",
    displayName = "Blitz Crackers",
    icon = null, // Assign in inspector
    prefab = null, // Assign in inspector

    hungerChange = 8,
    hydrationChange = -6,
    weight = 0.12f,
    maxStackSize = 24,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = true,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 4,
    maxPortions = 6,
    secondaryItemID = "empty_sleeve",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "snack",
        "packaged",
        "cracker",
        "dry",
        "salty",
        "spreadCompatible",
        "moraleNeutral",
        "fakeBrand"
    }
},
        new MiscFoodItemEntry
{
    itemID = "shredders_cereal",
    displayName = "Shredders",
    icon = null, // Assign in inspector
    prefab = null, // Assign in inspector

    hungerChange = 12,
    hydrationChange = -10,
    weight = 0.25f,
    maxStackSize = 12,

    foodPoisoningChance = 0.00f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = false,
    isPackaged = true,
    canBeToasted = true,
    canBeMicrowaved = true,
    canBeRehydrated = true,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 3,
    maxPortions = 5,
    secondaryItemID = "empty_box",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "breakfast",
        "cereal",
        "dry",
        "fiber",
        "packaged",
        "moraleDrainer",
        "milkCompatible",
        "fakeBrand"
    }
},
        new MiscFoodItemEntry
{
    itemID = "dusty_loops_cereal",
    displayName = "Dusty Loops",
    icon = null, // Assign in inspector
    prefab = null, // Assign in inspector

    hungerChange = 10,
    hydrationChange = -5,
    weight = 0.22f,
    maxStackSize = 10,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = false,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = true,
    canBeRehydrated = true,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 2,
    maxPortions = 4,
    secondaryItemID = "empty_box",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "breakfast",
        "cereal",
        "sugary",
        "packaged",
        "moraleBoost",
        "milkCompatible",
        "fakeBrand",
        "barterItem"
    }
},
        new MiscFoodItemEntry
{
    itemID = "salted_peanuts",
    displayName = "Salted Peanuts",
    icon = null,
    prefab = null,

    hungerChange = 10,
    hydrationChange = -8,
    weight = 0.18f,
    maxStackSize = 20,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 2,
    maxPortions = 4,
    secondaryItemID = "empty_packet",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "snack",
        "nuts",
        "salty",
        "packaged",
        "moraleNeutral",
        "barterItem",
        "fakeBrand"
    }
},
        new MiscFoodItemEntry
{
    itemID = "honey_cashews",
    displayName = "Honey Cashews",
    icon = null,
    prefab = null,

    hungerChange = 12,
    hydrationChange = -6,
    weight = 0.16f,
    maxStackSize = 16,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 2,
    maxPortions = 3,
    secondaryItemID = "empty_packet",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "snack",
        "nuts",
        "sweet",
        "packaged",
        "moraleBoost",
        "barterItem",
        "fakeBrand"
    }
},
        new MiscFoodItemEntry
{
    itemID = "trail_mix",
    displayName = "Trail Mix",
    icon = null,
    prefab = null,

    hungerChange = 14,
    hydrationChange = -7,
    weight = 0.22f,
    maxStackSize = 12,

    foodPoisoningChance = 0.02f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 3,
    maxPortions = 5,
    secondaryItemID = "empty_packet",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "snack",
        "nuts",
        "driedFruit",
        "packaged",
        "moraleBoost",
        "energyBoost",
        "barterItem",
        "fakeBrand"
    }
},
        new MiscFoodItemEntry
{
    itemID = "white_sliced_bread",
    displayName = "White Sliced Bread",
    icon = null,
    prefab = null,

    hungerChange = 10,
    hydrationChange = -6,
    weight = 0.30f,
    maxStackSize = 8,

    foodPoisoningChance = 0.02f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = true,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 4,
    maxPortions = 6,
    secondaryItemID = "empty_bread_bag",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "bread",
        "carb",
        "packaged",
        "toastable",
        "sandwichBase",
        "moraleNeutral",
        "fakeBrand"
    }
},new MiscFoodItemEntry
{
    itemID = "brown_sliced_bread",
    displayName = "Brown Sliced Bread",
    icon = null,
    prefab = null,

    hungerChange = 11,
    hydrationChange = -5,
    weight = 0.32f,
    maxStackSize = 8,

    foodPoisoningChance = 0.02f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = true,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 4,
    maxPortions = 6,
    secondaryItemID = "empty_bread_bag",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "bread",
        "carb",
        "packaged",
        "toastable",
        "sandwichBase",
        "moraleNeutral",
        "fakeBrand"
    }
},
        new MiscFoodItemEntry
{
    itemID = "cheesy_angles",
    displayName = "Cheesy Angles",
    icon = null,
    prefab = null,

    hungerChange = 9,
    hydrationChange = -4,
    weight = 0.10f,
    maxStackSize = 20,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = true,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 3,
    maxPortions = 5,
    secondaryItemID = "empty_wrapper",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "spread",
        "cheese",
        "packaged",
        "sandwichCompatible",
        "toastCompatible",
        "moraleBoost",
        "fakeBrand",
        "barterItem"
    }
},new MiscFoodItemEntry
{
    itemID = "suspicious_meat_paste",
    displayName = "Suspicious Meat Paste",
    icon = null,
    prefab = null,

    hungerChange = 11,
    hydrationChange = -5,
    weight = 0.14f,
    maxStackSize = 12,

    foodPoisoningChance = 0.12f,
    salmonellaChance = 0.04f,
    parasiteChance = 0.02f,
    zombiePathogenChance = 0.01f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 2,
    maxPortions = 4,
    secondaryItemID = "empty_tin",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "spread",
        "meat",
        "packaged",
        "highRisk",
        "moraleNeutral",
        "barterItem",
        "fakeBrand",
        "labelDegraded"
    }
},
        new MiscFoodItemEntry
{
    itemID = "jar_of_jam",
    displayName = "Jar of Jam",
    icon = null,
    prefab = null,

    hungerChange = 6,
    hydrationChange = -2,
    weight = 0.30f,
    maxStackSize = 6,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = true,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 4,
    maxPortions = 8,
    secondaryItemID = "empty_jar",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "spread",
        "sweet",
        "fruit",
        "packaged",
        "toastCompatible",
        "sandwichCompatible",
        "moraleBoost",
        "barterItem",
        "fakeBrand"
    }
},
        new MiscFoodItemEntry
{
    itemID = "jar_of_honey",
    displayName = "Jar of Honey",
    icon = null,
    prefab = null,

    hungerChange = 5,
    hydrationChange = -1,
    weight = 0.32f,
    maxStackSize = 6,

    foodPoisoningChance = 0.00f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = true,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 4,
    maxPortions = 8,
    secondaryItemID = "empty_jar",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "spread",
        "sweet",
        "natural",
        "packaged",
        "toastCompatible",
        "sandwichCompatible",
        "moraleBoost",
        "barterItem",
        "fakeBrand"
    }
},new MiscFoodItemEntry
{
    itemID = "jar_of_marmalade",
    displayName = "Jar of Marmalade",
    icon = null,
    prefab = null,

    hungerChange = 6,
    hydrationChange = -2,
    weight = 0.30f,
    maxStackSize = 6,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = true,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 4,
    maxPortions = 8,
    secondaryItemID = "empty_jar",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "spread",
        "sweet",
        "citrus",
        "packaged",
        "toastCompatible",
        "sandwichCompatible",
        "moraleBoost",
        "barterItem",
        "fakeBrand"
    }
},new MiscFoodItemEntry
{
    itemID = "duck_egg",
    displayName = "Duck Egg",
    icon = null,
    prefab = null,

    hungerChange = 8,
    hydrationChange = -3,
    weight = 0.12f,
    maxStackSize = 12,

    foodPoisoningChance = 0.06f,
    salmonellaChance = 0.04f,
    parasiteChance = 0.01f,
    zombiePathogenChance = 0.00f,

    isCooked = false,
    isPackaged = false,
    canBeToasted = false,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = false,
    secondaryItemID = "eggshell_fragments",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,

    tags = new List<string>
    {
        "egg",
        "raw",
        "cookable",
        "animalProduct",
        "moraleNeutral",
        "fakeBrand"
    }
},new MiscFoodItemEntry
{
    itemID = "chicken_egg",
    displayName = "Chicken Egg",
    icon = null,
    prefab = null,

    hungerChange = 7,
    hydrationChange = -2,
    weight = 0.10f,
    maxStackSize = 12,

    foodPoisoningChance = 0.05f,
    salmonellaChance = 0.03f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = false,
    isPackaged = false,
    canBeToasted = false,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = false,
    secondaryItemID = "eggshell_fragments",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,

    tags = new List<string>
    {
        "egg",
        "raw",
        "cookable",
        "animalProduct",
        "moraleNeutral",
        "fakeBrand"
    }
},new MiscFoodItemEntry
{
    itemID = "alligator_egg",
    displayName = "Alligator Egg",
    icon = null,
    prefab = null,

    hungerChange = 12,
    hydrationChange = -4,
    weight = 0.20f,
    maxStackSize = 6,

    foodPoisoningChance = 0.10f,
    salmonellaChance = 0.06f,
    parasiteChance = 0.02f,
    zombiePathogenChance = 0.01f,

    isCooked = false,
    isPackaged = false,
    canBeToasted = false,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = false,
    secondaryItemID = "eggshell_fragments",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string>
    {
        "egg",
        "raw",
        "cookable",
        "animalProduct",
        "highRisk",
        "moraleBoost",
        "fakeBrand"
    }
},new MiscFoodItemEntry
{
    itemID = "pheasant_egg",
    displayName = "Pheasant Egg",
    icon = null,
    prefab = null,

    hungerChange = 6,
    hydrationChange = -2,
    weight = 0.09f,
    maxStackSize = 10,

    foodPoisoningChance = 0.04f,
    salmonellaChance = 0.02f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = false,
    isPackaged = false,
    canBeToasted = false,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = false,
    secondaryItemID = "eggshell_fragments",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,

    tags = new List<string>
    {
        "egg",
        "raw",
        "cookable",
        "animalProduct",
        "moraleBoost",
        "fakeBrand"
    }
},
        new MiscFoodItemEntry
{
    itemID = "turkey_egg",
    displayName = "Turkey Egg",
    icon = null,
    prefab = null,

    hungerChange = 9,
    hydrationChange = -3,
    weight = 0.14f,
    maxStackSize = 10,

    foodPoisoningChance = 0.06f,
    salmonellaChance = 0.03f,
    parasiteChance = 0.01f,
    zombiePathogenChance = 0.00f,

    isCooked = false,
    isPackaged = false,
    canBeToasted = false,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = false,
    secondaryItemID = "eggshell_fragments",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,

    tags = new List<string>
    {
        "egg",
        "raw",
        "cookable",
        "animalProduct",
        "moraleNeutral",
        "fakeBrand"
    }
},
// Boiled Duck Egg
new MiscFoodItemEntry
{
    itemID = "boiled_duck_egg",
    displayName = "Boiled Duck Egg",
    icon = null,
    prefab = null,
    hungerChange = 9,
    hydrationChange = 0,
    weight = 0.12f,
    maxStackSize = 12,
    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,
    isCooked = true,
    isPackaged = false,
    canBeSplit = false,
    secondaryItemID = "eggshell_fragments",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,
    tags = new List<string> { "egg", "boiled", "animalProduct", "moraleBoost", "fakeBrand" }
},

// Fried Duck Egg
new MiscFoodItemEntry
{
    itemID = "fried_duck_egg",
    displayName = "Fried Duck Egg",
    icon = null,
    prefab = null,
    hungerChange = 10,
    hydrationChange = -1,
    weight = 0.13f,
    maxStackSize = 12,
    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,
    isCooked = true,
    isPackaged = false,
    canBeSplit = false,
    secondaryItemID = "eggshell_fragments",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,
    tags = new List<string> { "egg", "fried", "animalProduct", "moraleBoost", "sandwichCompatible", "fakeBrand" }
},

// Boiled Chicken Egg
new MiscFoodItemEntry
{
    itemID = "boiled_chicken_egg",
    displayName = "Boiled Chicken Egg",
    icon = null,
    prefab = null,
    hungerChange = 8,
    hydrationChange = 0,
    weight = 0.10f,
    maxStackSize = 12,
    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,
    isCooked = true,
    isPackaged = false,
    canBeSplit = false,
    secondaryItemID = "eggshell_fragments",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,
    tags = new List<string> { "egg", "boiled", "animalProduct", "moraleBoost", "fakeBrand" }
},

// Fried Chicken Egg
new MiscFoodItemEntry
{
    itemID = "fried_chicken_egg",
    displayName = "Fried Chicken Egg",
    icon = null,
    prefab = null,
    hungerChange = 9,
    hydrationChange = -1,
    weight = 0.11f,
    maxStackSize = 12,
    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,
    isCooked = true,
    isPackaged = false,
    canBeSplit = false,
    secondaryItemID = "eggshell_fragments",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,
    tags = new List<string> { "egg", "fried", "animalProduct", "moraleBoost", "sandwichCompatible", "fakeBrand" }
},

// Boiled Alligator Egg
new MiscFoodItemEntry
{
    itemID = "boiled_alligator_egg",
    displayName = "Boiled Alligator Egg",
    icon = null,
    prefab = null,
    hungerChange = 13,
    hydrationChange = 0,
    weight = 0.20f,
    maxStackSize = 6,
    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,
    isCooked = true,
    isPackaged = false,
    canBeSplit = false,
    secondaryItemID = "eggshell_fragments",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,
    tags = new List<string> { "egg", "boiled", "animalProduct", "moraleBoost", "fakeBrand" }
},

// Fried Alligator Egg
new MiscFoodItemEntry
{
    itemID = "fried_alligator_egg",
    displayName = "Fried Alligator Egg",
    icon = null,
    prefab = null,
    hungerChange = 14,
    hydrationChange = -2,
    weight = 0.21f,
    maxStackSize = 6,
    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,
    isCooked = true,
    isPackaged = false,
    canBeSplit = false,
    secondaryItemID = "eggshell_fragments",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,
    tags = new List<string> { "egg", "fried", "animalProduct", "moraleBoost", "sandwichCompatible", "fakeBrand" }
},

// Boiled Pheasant Egg
new MiscFoodItemEntry
{
    itemID = "boiled_pheasant_egg",
    displayName = "Boiled Pheasant Egg",
    icon = null,
    prefab = null,
    hungerChange = 7,
    hydrationChange = 0,
    weight = 0.09f,
    maxStackSize = 10,
    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,
    isCooked = true,
    isPackaged = false,
    canBeSplit = false,
    secondaryItemID = "eggshell_fragments",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,
    tags = new List<string> { "egg", "boiled", "animalProduct", "moraleBoost", "fakeBrand" }
},

// Fried Pheasant Egg
new MiscFoodItemEntry
{
    itemID = "fried_pheasant_egg",
    displayName = "Fried Pheasant Egg",
    icon = null,
    prefab = null,
    hungerChange = 8,
    hydrationChange = -1,
    weight = 0.10f,
    maxStackSize = 10,
    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,
    isCooked = true,
    isPackaged = false,
    canBeSplit = false,
    secondaryItemID = "eggshell_fragments",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,
    tags = new List<string> { "egg", "fried", "animalProduct", "moraleBoost", "sandwichCompatible", "fakeBrand" }
},

// Boiled Turkey Egg
new MiscFoodItemEntry
{
    itemID = "boiled_turkey_egg",
    displayName = "Boiled Turkey Egg",
    icon = null,
    prefab = null,
    hungerChange = 10,
    hydrationChange = 0,
    weight = 0.14f,
    maxStackSize = 10,
    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,
    isCooked = true,
    isPackaged = false,
    canBeSplit = false,
    secondaryItemID = "eggshell_fragments",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,
    tags = new List<string> { "egg", "boiled", "animalProduct", "moraleBoost", "fakeBrand" }
},

// Fried Turkey Egg
new MiscFoodItemEntry
{
    itemID = "fried_turkey_egg",
    displayName = "Fried Turkey Egg",
    icon = null,
    prefab = null,
    hungerChange = 11,
    hydrationChange = -1,
    weight = 0.15f,
    maxStackSize = 10,
    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,
    isCooked = true,
    isPackaged = false,
    canBeSplit = false
    },

new MiscFoodItemEntry
{
    itemID = "barrybo_jellies",
    displayName = "Barrybo Jellies",
    icon = null,
    prefab = null,

    hungerChange = 4,
    hydrationChange = 0,
    weight = 0.10f,
    maxStackSize = 24,

    foodPoisoningChance = 0.00f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 6,
    maxPortions = 12,
    secondaryItemID = "empty_packet",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "snack",
        "sweet",
        "gummy",
        "packaged",
        "moraleBoost",
        "barterItem",
        "fakeBrand"
    }
},
new MiscFoodItemEntry
{
    itemID = "salt_sachet",
    displayName = "Salt Sachet",
    icon = null,
    prefab = null,

    hungerChange = 0,
    hydrationChange = 0,
    weight = 0.01f,
    maxStackSize = 64,

    foodPoisoningChance = 0.00f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = false,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = false,
    secondaryItemID = "empty_sachet",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "seasoning",
        "salt",
        "modifier",
        "packaged",
        "fakeBrand"
    }
},
new MiscFoodItemEntry
{
    itemID = "pepper_sachet",
    displayName = "Pepper Sachet",
    icon = null,
    prefab = null,

    hungerChange = 0,
    hydrationChange = 0,
    weight = 0.01f,
    maxStackSize = 64,

    foodPoisoningChance = 0.00f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = false,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = false,
    secondaryItemID = "empty_sachet",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "seasoning",
        "pepper",
        "modifier",
        "packaged",
        "fakeBrand"
    }
},
new MiscFoodItemEntry
{
    itemID = "sugar_sachet",
    displayName = "Sugar Sachet",
    icon = null,
    prefab = null,

    hungerChange = 0,
    hydrationChange = 0,
    weight = 0.01f,
    maxStackSize = 64,

    foodPoisoningChance = 0.00f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = false,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = false,
    secondaryItemID = "empty_sachet",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "sweetener",
        "sugar",
        "modifier",
        "packaged",
        "fakeBrand"
    }
},
new MiscFoodItemEntry
{
    itemID = "bag_of_rice",
    displayName = "Bag of Rice",
    icon = null,
    prefab = null,

    hungerChange = 0,
    hydrationChange = 0,
    weight = 0.50f,
    maxStackSize = 6,

    foodPoisoningChance = 0.00f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = false,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = false,
    canBeRehydrated = true,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 4,
    maxPortions = 8,
    secondaryItemID = "empty_bag",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "ingredient",
        "rice",
        "raw",
        "packaged",
        "craftingBase",
        "fakeBrand"
    }
},
new MiscFoodItemEntry
{
    itemID = "steamed_rice",
    displayName = "Steamed Rice",
    icon = null,
    prefab = null,

    hungerChange = 10,
    hydrationChange = 2,
    weight = 0.25f,
    maxStackSize = 10,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = false,
    canBeToasted = false,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 2,
    maxPortions = 4,
    secondaryItemID = "empty_container",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "rice",
        "steamed",
        "carb",
        "moraleNeutral",
        "cookable",
        "fakeBrand"
    }
},
new MiscFoodItemEntry
{
    itemID = "boiled_rice",
    displayName = "Boiled Rice",
    icon = null,
    prefab = null,

    hungerChange = 9,
    hydrationChange = 3,
    weight = 0.26f,
    maxStackSize = 10,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = false,
    canBeToasted = false,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 2,
    maxPortions = 4,
    secondaryItemID = "empty_container",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "rice",
        "boiled",
        "carb",
        "hydrationBoost",
        "cookable",
        "fakeBrand"
    }
},
new MiscFoodItemEntry
{
    itemID = "fried_rice",
    displayName = "Fried Rice",
    icon = null,
    prefab = null,

    hungerChange = 12,
    hydrationChange = -2,
    weight = 0.28f,
    maxStackSize = 10,

    foodPoisoningChance = 0.02f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = false,
    canBeToasted = false,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 2,
    maxPortions = 4,
    secondaryItemID = "empty_container",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "rice",
        "fried",
        "carb",
        "moraleBoost",
        "cookable",
        "fakeBrand"
    }
},
new MiscFoodItemEntry
{
    itemID = "winkies_snack",
    displayName = "Winkies",
    icon = null,
    prefab = null,

    hungerChange = 14,
    hydrationChange = -3,
    weight = 0.18f,
    maxStackSize = 16,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = false,
    canBeMicrowaved = true,
    canBeRehydrated = false,
    canBeFermented = false,

    canBeSplit = true,
    minPortions = 2,
    maxPortions = 3,
    secondaryItemID = "empty_wrapper",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "snack",
        "cake",
        "packaged",
        "moraleBoost",
        "legendaryItem",
        "fakeBrand",
        "barterItem"
    }
},new MiscFoodItemEntry
{
    itemID = "jar_of_peanut_butter",
    displayName = "Jar of Peanut Butter",
    icon = null,
    prefab = null,

    hungerChange = 10,
    hydrationChange = -4,
    weight = 0.35f,
    maxStackSize = 6,

    foodPoisoningChance = 0.01f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = true,
    canBeMicrowaved = true,

    canBeSplit = true,
    minPortions = 4,
    maxPortions = 8,
    secondaryItemID = "empty_jar",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "spread",
        "nut",
        "packaged",
        "sandwichCompatible",
        "moraleBoost",
        "barterItem",
        "fakeBrand"
    }
},new MiscFoodItemEntry
{
    itemID = "bag_of_flour",
    displayName = "Bag of Flour",
    icon = null,
    prefab = null,

    hungerChange = 0,
    hydrationChange = 0,
    weight = 0.50f,
    maxStackSize = 6,

    foodPoisoningChance = 0.00f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = false,
    isPackaged = true,
    canBeRehydrated = true,

    canBeSplit = true,
    minPortions = 4,
    maxPortions = 8,
    secondaryItemID = "empty_bag",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "ingredient",
        "flour",
        "craftingBase",
        "packaged",
        "fakeBrand"
    }
},
new MiscFoodItemEntry
{
    itemID = "meaty_tofu",
    displayName = "Meaty Tofu",
    icon = null,
    prefab = null,

    hungerChange = 11,
    hydrationChange = -2,
    weight = 0.22f,
    maxStackSize = 10,

    foodPoisoningChance = 0.02f,
    salmonellaChance = 0.00f,
    parasiteChance = 0.00f,
    zombiePathogenChance = 0.00f,

    isCooked = true,
    isPackaged = true,
    canBeToasted = true,
    canBeMicrowaved = true,

    canBeSplit = true,
    minPortions = 2,
    maxPortions = 4,
    secondaryItemID = "empty_wrapper",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string>
    {
        "protein",
        "tofu",
        "meatSubstitute",
        "packaged",
        "moraleNeutral",
        "barterItem",
        "fakeBrand"
    }
},



};
}
