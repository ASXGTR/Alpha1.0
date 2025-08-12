using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FishItemEntry
{
    public string itemID;
    public string displayName;
    public Sprite icon;
    public GameObject prefab;

    public float hungerChange;
    public float hydrationChange;
    public float weight;
    public int maxStackSize;

    public float foodPoisoningChance;
    public float salmonellaChance;
    public float parasiteChance;
    public float zombiePathogenChance;
    public float mercuryPoisoningChance;
    public float waterborneVirusChance;

    public bool isCooked;

    public bool canBeSliced;
    public int minSlices;
    public int maxSlices;

    public bool canBeBoiled;
    public bool canBeSteamed;
    public bool canBeFried;
    public bool canBeRoasted;
    public bool canBeGrilled;
    public bool canBeSmoked;

    public string secondaryItemID;
    public int minSecondaryYield;
    public int maxSecondaryYield;

    public List<string> tags;
}

[CreateAssetMenu(fileName = "FishItemDatabase", menuName = "Databases/Fish Item Database")]
public class FishItemDatabase : ScriptableObject
{
    public List<FishItemEntry> fishItems = new()
    {
        new FishItemEntry
        {
            itemID = "anchovy_raw",
            displayName = "Anchovy (Raw)",
            icon = null,
            prefab = null,
            hungerChange = 2,
            hydrationChange = 1,
            weight = 0.05f,
            maxStackSize = 50,

            foodPoisoningChance = 0.02f,
            salmonellaChance = 0.01f,
            parasiteChance = 0.015f,
            zombiePathogenChance = 0.0001f,
            mercuryPoisoningChance = 0.001f,
            waterborneVirusChance = 0.005f,

            isCooked = false,
            canBeSliced = false,
            minSlices = 0,
            maxSlices = 0,
            canBeBoiled = false,
            canBeSteamed = false,
            canBeFried = true,
            canBeRoasted = false,
            canBeGrilled = true,
            canBeSmoked = true,

            secondaryItemID = "anchovy_bones",
            minSecondaryYield = 1,
            maxSecondaryYield = 2,

            tags = new List<string> { "item", "food", "fish", "anchovy", "raw", "fryable", "grillable", "smokeable", "small_fish" }
        },

        new FishItemEntry
        {
            itemID = "anchovy_fried",
            displayName = "Anchovy (Fried)",
            icon = null,
            prefab = null,
            hungerChange = 4,
            hydrationChange = 0,
            weight = 0.05f,
            maxStackSize = 50,

            foodPoisoningChance = 0.005f,
            salmonellaChance = 0.002f,
            parasiteChance = 0.001f,
            zombiePathogenChance = 0.00005f,
            mercuryPoisoningChance = 0.001f,
            waterborneVirusChance = 0.001f,

            isCooked = true,
            canBeSliced = false,
            minSlices = 0,
            maxSlices = 0,
            canBeBoiled = false,
            canBeSteamed = false,
            canBeFried = false,
            canBeRoasted = false,
            canBeGrilled = false,
            canBeSmoked = false,

            secondaryItemID = "anchovy_bones",
            minSecondaryYield = 1,
            maxSecondaryYield = 2,

            tags = new List<string> { "item", "food", "fish", "anchovy", "fried", "cooked", "small_fish" }
        },

        new FishItemEntry
        {
            itemID = "anchovy_grilled",
            displayName = "Anchovy (Grilled)",
            icon = null,
            prefab = null,
            hungerChange = 3,
            hydrationChange = 0,
            weight = 0.05f,
            maxStackSize = 50,

            foodPoisoningChance = 0.006f,
            salmonellaChance = 0.002f,
            parasiteChance = 0.001f,
            zombiePathogenChance = 0.00005f,
            mercuryPoisoningChance = 0.001f,
            waterborneVirusChance = 0.001f,

            isCooked = true,
            canBeSliced = false,
            minSlices = 0,
            maxSlices = 0,
            canBeBoiled = false,
            canBeSteamed = false,
            canBeFried = false,
            canBeRoasted = false,
            canBeGrilled = false,
            canBeSmoked = false,

            secondaryItemID = "anchovy_bones",
            minSecondaryYield = 1,
            maxSecondaryYield = 2,

            tags = new List<string> { "item", "food", "fish", "anchovy", "grilled", "cooked", "small_fish" }
        },

        new FishItemEntry
        {
            itemID = "anchovy_smoked",
            displayName = "Anchovy (Smoked)",
            icon = null,
            prefab = null,
            hungerChange = 3,
            hydrationChange = 0,
            weight = 0.05f,
            maxStackSize = 50,

            foodPoisoningChance = 0.004f,
            salmonellaChance = 0.001f,
            parasiteChance = 0.001f,
            zombiePathogenChance = 0.00005f,
            mercuryPoisoningChance = 0.001f,
            waterborneVirusChance = 0.001f,

            isCooked = true,
            canBeSliced = false,
            minSlices = 0,
            maxSlices = 0,
            canBeBoiled = false,
            canBeSteamed = false,
            canBeFried = false,
            canBeRoasted = false,
            canBeGrilled = false,
            canBeSmoked = false,

            secondaryItemID = "anchovy_bones",
            minSecondaryYield = 1,
            maxSecondaryYield = 2,

            tags = new List<string> { "item", "food", "fish", "anchovy", "smoked", "preserved", "cooked", "small_fish" }
        },
        new FishItemEntry
{
    itemID = "salmon_raw",
    displayName = "Salmon (Raw)",
    icon = null,
    prefab = null,
    hungerChange = 6,
    hydrationChange = 2,
    weight = 0.4f,
    maxStackSize = 20,

    foodPoisoningChance = 0.015f,
    salmonellaChance = 0.008f,
    parasiteChance = 0.01f,
    zombiePathogenChance = 0.0002f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.004f,

    isCooked = false,
    canBeSliced = true,
    minSlices = 4,
    maxSlices = 8,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = true,
    canBeRoasted = true,
    canBeGrilled = true,
    canBeSmoked = true,

    secondaryItemID = "salmon_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 4,

    tags = new List<string> { "item", "food", "fish", "salmon", "raw", "sliceable", "fryable", "roastable", "grillable", "smokeable" }
},

new FishItemEntry
{
    itemID = "salmon_smoked",
    displayName = "Salmon (Smoked)",
    icon = null,
    prefab = null,
    hungerChange = 8,
    hydrationChange = 1,
    weight = 0.4f,
    maxStackSize = 20,

    foodPoisoningChance = 0.003f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 4,
    maxSlices = 8,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "salmon_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 4,

    tags = new List<string> { "item", "food", "fish", "salmon", "smoked", "sliceable", "preserved", "cooked" }
},

new FishItemEntry
{
    itemID = "salmon_grilled",
    displayName = "Salmon (Grilled)",
    icon = null,
    prefab = null,
    hungerChange = 7,
    hydrationChange = 1,
    weight = 0.4f,
    maxStackSize = 20,

    foodPoisoningChance = 0.004f,
    salmonellaChance = 0.002f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 4,
    maxSlices = 8,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "salmon_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 4,

    tags = new List<string> { "item", "food", "fish", "salmon", "grilled", "sliceable", "cooked" }
},

new FishItemEntry
{
    itemID = "salmon_fried",
    displayName = "Salmon (Fried)",
    icon = null,
    prefab = null,
    hungerChange = 9,
    hydrationChange = 0,
    weight = 0.4f,
    maxStackSize = 20,

    foodPoisoningChance = 0.002f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 4,
    maxSlices = 8,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "salmon_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 4,

    tags = new List<string> { "item", "food", "fish", "salmon", "fried", "sliceable", "cooked" }
},

new FishItemEntry
{
    itemID = "salmon_roasted",
    displayName = "Salmon (Roasted)",
    icon = null,
    prefab = null,
    hungerChange = 7,
    hydrationChange = 1,
    weight = 0.4f,
    maxStackSize = 20,

    foodPoisoningChance = 0.003f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 4,
    maxSlices = 8,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "salmon_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 4,

    tags = new List<string> { "item", "food", "fish", "salmon", "roasted", "sliceable", "cooked" }
},

new FishItemEntry
{
    itemID = "salmon_steamed",
    displayName = "Salmon (Steamed)",
    icon = null,
    prefab = null,
    hungerChange = 6,
    hydrationChange = 2,
    weight = 0.4f,
    maxStackSize = 20,

    foodPoisoningChance = 0.004f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 4,
    maxSlices = 8,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "salmon_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 4,

    tags = new List<string> { "item", "food", "fish", "salmon", "steamed", "sliceable", "cooked" }
},
new FishItemEntry
{
    itemID = "trout_raw",
    displayName = "Trout (Raw)",
    icon = null,
    prefab = null,
    hungerChange = 5,
    hydrationChange = 2,
    weight = 0.35f,
    maxStackSize = 20,

    foodPoisoningChance = 0.014f,
    salmonellaChance = 0.007f,
    parasiteChance = 0.009f,
    zombiePathogenChance = 0.0002f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.003f,

    isCooked = false,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = true,
    canBeRoasted = true,
    canBeGrilled = true,
    canBeSmoked = true,

    secondaryItemID = "trout_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "trout", "raw", "sliceable", "fryable", "roastable", "grillable", "smokeable" }
},

new FishItemEntry
{
    itemID = "trout_smoked",
    displayName = "Trout (Smoked)",
    icon = null,
    prefab = null,
    hungerChange = 7,
    hydrationChange = 1,
    weight = 0.35f,
    maxStackSize = 20,

    foodPoisoningChance = 0.003f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "trout_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "trout", "smoked", "sliceable", "preserved", "cooked" }
},

new FishItemEntry
{
    itemID = "trout_grilled",
    displayName = "Trout (Grilled)",
    icon = null,
    prefab = null,
    hungerChange = 6,
    hydrationChange = 1,
    weight = 0.35f,
    maxStackSize = 20,

    foodPoisoningChance = 0.004f,
    salmonellaChance = 0.002f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "trout_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "trout", "grilled", "sliceable", "cooked" }
},

new FishItemEntry
{
    itemID = "trout_fried",
    displayName = "Trout (Fried)",
    icon = null,
    prefab = null,
    hungerChange = 8,
    hydrationChange = 0,
    weight = 0.35f,
    maxStackSize = 20,

    foodPoisoningChance = 0.002f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "trout_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "trout", "fried", "sliceable", "cooked" }
},

new FishItemEntry
{
    itemID = "trout_roasted",
    displayName = "Trout (Roasted)",
    icon = null,
    prefab = null,
    hungerChange = 6,
    hydrationChange = 1,
    weight = 0.35f,
    maxStackSize = 20,

    foodPoisoningChance = 0.003f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "trout_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "trout", "roasted", "sliceable", "cooked" }
},

new FishItemEntry
{
    itemID = "trout_steamed",
    displayName = "Trout (Steamed)",
    icon = null,
    prefab = null,
    hungerChange = 5,
    hydrationChange = 2,
    weight = 0.35f,
    maxStackSize = 20,

    foodPoisoningChance = 0.004f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "trout_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "trout", "steamed", "sliceable", "cooked" }
},
new FishItemEntry
{
    itemID = "mackerel_raw",
    displayName = "Mackerel (Raw)",
    icon = null,
    prefab = null,
    hungerChange = 4,
    hydrationChange = 1,
    weight = 0.3f,
    maxStackSize = 25,

    foodPoisoningChance = 0.018f,
    salmonellaChance = 0.009f,
    parasiteChance = 0.012f,
    zombiePathogenChance = 0.0002f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.004f,

    isCooked = false,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = true,
    canBeRoasted = false,
    canBeGrilled = true,
    canBeSmoked = true,

    secondaryItemID = "mackerel_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "mackerel", "raw", "sliceable", "fryable", "grillable", "smokeable", "oily_fish" }
},

new FishItemEntry
{
    itemID = "mackerel_fried",
    displayName = "Mackerel (Fried)",
    icon = null,
    prefab = null,
    hungerChange = 6,
    hydrationChange = 0,
    weight = 0.3f,
    maxStackSize = 25,

    foodPoisoningChance = 0.004f,
    salmonellaChance = 0.002f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "mackerel_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "mackerel", "fried", "sliceable", "cooked", "oily_fish" }
},

new FishItemEntry
{
    itemID = "mackerel_grilled",
    displayName = "Mackerel (Grilled)",
    icon = null,
    prefab = null,
    hungerChange = 5,
    hydrationChange = 0,
    weight = 0.3f,
    maxStackSize = 25,

    foodPoisoningChance = 0.005f,
    salmonellaChance = 0.002f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "mackerel_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "mackerel", "grilled", "sliceable", "cooked", "oily_fish" }
},

new FishItemEntry
{
    itemID = "mackerel_smoked",
    displayName = "Mackerel (Smoked)",
    icon = null,
    prefab = null,
    hungerChange = 5,
    hydrationChange = 0,
    weight = 0.3f,
    maxStackSize = 25,

    foodPoisoningChance = 0.003f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "mackerel_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "mackerel", "smoked", "sliceable", "preserved", "cooked", "oily_fish" }
},
new FishItemEntry
{
    itemID = "sardine_raw",
    displayName = "Sardine (Raw)",
    icon = null,
    prefab = null,
    hungerChange = 2,
    hydrationChange = 1,
    weight = 0.06f,
    maxStackSize = 50,

    foodPoisoningChance = 0.018f,
    salmonellaChance = 0.009f,
    parasiteChance = 0.014f,
    zombiePathogenChance = 0.0001f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.004f,

    isCooked = false,
    canBeSliced = false,
    minSlices = 0,
    maxSlices = 0,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = true,
    canBeRoasted = false,
    canBeGrilled = true,
    canBeSmoked = true,

    secondaryItemID = "sardine_bones",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,

    tags = new List<string> { "item", "food", "fish", "sardine", "raw", "fryable", "grillable", "smokeable", "small_fish" }
},

new FishItemEntry
{
    itemID = "sardine_fried",
    displayName = "Sardine (Fried)",
    icon = null,
    prefab = null,
    hungerChange = 4,
    hydrationChange = 0,
    weight = 0.06f,
    maxStackSize = 50,

    foodPoisoningChance = 0.004f,
    salmonellaChance = 0.002f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = false,
    minSlices = 0,
    maxSlices = 0,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "sardine_bones",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,

    tags = new List<string> { "item", "food", "fish", "sardine", "fried", "cooked", "small_fish" }
},

new FishItemEntry
{
    itemID = "sardine_grilled",
    displayName = "Sardine (Grilled)",
    icon = null,
    prefab = null,
    hungerChange = 3,
    hydrationChange = 0,
    weight = 0.06f,
    maxStackSize = 50,

    foodPoisoningChance = 0.005f,
    salmonellaChance = 0.002f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = false,
    minSlices = 0,
    maxSlices = 0,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "sardine_bones",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,

    tags = new List<string> { "item", "food", "fish", "sardine", "grilled", "cooked", "small_fish" }
},

new FishItemEntry
{
    itemID = "sardine_smoked",
    displayName = "Sardine (Smoked)",
    icon = null,
    prefab = null,
    hungerChange = 3,
    hydrationChange = 0,
    weight = 0.06f,
    maxStackSize = 50,

    foodPoisoningChance = 0.003f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = false,
    minSlices = 0,
    maxSlices = 0,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "sardine_bones",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,

    tags = new List<string> { "item", "food", "fish", "sardine", "smoked", "preserved", "cooked", "small_fish" }
},
new FishItemEntry
{
    itemID = "cod_raw",
    displayName = "Cod (Raw)",
    icon = null,
    prefab = null,
    hungerChange = 5,
    hydrationChange = 2,
    weight = 0.35f,
    maxStackSize = 20,

    foodPoisoningChance = 0.012f,
    salmonellaChance = 0.006f,
    parasiteChance = 0.008f,
    zombiePathogenChance = 0.0001f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.003f,

    isCooked = false,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = true,
    canBeSteamed = true,
    canBeFried = true,
    canBeRoasted = true,
    canBeGrilled = true,
    canBeSmoked = true,

    secondaryItemID = "cod_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "cod", "raw", "sliceable", "boilable", "steammable", "fryable", "roastable", "grillable", "smokeable" }
},

new FishItemEntry
{
    itemID = "cod_fried",
    displayName = "Cod (Fried)",
    icon = null,
    prefab = null,
    hungerChange = 8,
    hydrationChange = 0,
    weight = 0.35f,
    maxStackSize = 20,

    foodPoisoningChance = 0.002f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "cod_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "cod", "fried", "sliceable", "cooked" }
},

new FishItemEntry
{
    itemID = "cod_grilled",
    displayName = "Cod (Grilled)",
    icon = null,
    prefab = null,
    hungerChange = 7,
    hydrationChange = 1,
    weight = 0.35f,
    maxStackSize = 20,

    foodPoisoningChance = 0.003f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "cod_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "cod", "grilled", "sliceable", "cooked" }
},

new FishItemEntry
{
    itemID = "cod_roasted",
    displayName = "Cod (Roasted)",
    icon = null,
    prefab = null,
    hungerChange = 7,
    hydrationChange = 1,
    weight = 0.35f,
    maxStackSize = 20,

    foodPoisoningChance = 0.003f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "cod_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "cod", "roasted", "sliceable", "cooked" }
},

new FishItemEntry
{
    itemID = "cod_steamed",
    displayName = "Cod (Steamed)",
    icon = null,
    prefab = null,
    hungerChange = 6,
    hydrationChange = 2,
    weight = 0.35f,
    maxStackSize = 20,

    foodPoisoningChance = 0.004f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "cod_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "cod", "steamed", "sliceable", "cooked" }
},

new FishItemEntry
{
    itemID = "cod_smoked",
    displayName = "Cod (Smoked)",
    icon = null,
    prefab = null,
    hungerChange = 6,
    hydrationChange = 1,
    weight = 0.35f,
    maxStackSize = 20,

    foodPoisoningChance = 0.003f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "cod_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "cod", "smoked", "sliceable", "preserved", "cooked" }
},
new FishItemEntry
{
    itemID = "cod_boiled",
    displayName = "Cod (Boiled)",
    icon = null,
    prefab = null,
    hungerChange = 6,
    hydrationChange = 2,
    weight = 0.35f,
    maxStackSize = 20,

    foodPoisoningChance = 0.004f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "cod_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "cod", "boiled", "sliceable", "cooked" }
},
new FishItemEntry
{
    itemID = "eel_raw",
    displayName = "Eel (Raw)",
    icon = null,
    prefab = null,
    hungerChange = 4,
    hydrationChange = 1,
    weight = 0.3f,
    maxStackSize = 20,

    foodPoisoningChance = 0.02f,
    salmonellaChance = 0.01f,
    parasiteChance = 0.015f,
    zombiePathogenChance = 0.0002f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.005f,

    isCooked = false,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = true,
    canBeSteamed = false,
    canBeFried = true,
    canBeRoasted = false,
    canBeGrilled = true,
    canBeSmoked = true,

    secondaryItemID = "eel_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "eel", "raw", "sliceable", "fryable", "boilable", "grillable", "smokeable", "oily_fish" }
},

new FishItemEntry
{
    itemID = "eel_smoked",
    displayName = "Eel (Smoked)",
    icon = null,
    prefab = null,
    hungerChange = 6,
    hydrationChange = 0,
    weight = 0.3f,
    maxStackSize = 20,

    foodPoisoningChance = 0.004f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "eel_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "eel", "smoked", "sliceable", "preserved", "cooked", "oily_fish" }
},

new FishItemEntry
{
    itemID = "eel_fried",
    displayName = "Eel (Fried)",
    icon = null,
    prefab = null,
    hungerChange = 7,
    hydrationChange = 0,
    weight = 0.3f,
    maxStackSize = 20,

    foodPoisoningChance = 0.003f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "eel_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "eel", "fried", "sliceable", "cooked", "oily_fish" }
},

new FishItemEntry
{
    itemID = "eel_boiled",
    displayName = "Eel (Boiled)",
    icon = null,
    prefab = null,
    hungerChange = 5,
    hydrationChange = 2,
    weight = 0.3f,
    maxStackSize = 20,

    foodPoisoningChance = 0.005f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "eel_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "eel", "boiled", "sliceable", "cooked", "oily_fish" }
},

new FishItemEntry
{
    itemID = "eel_grilled",
    displayName = "Eel (Grilled)",
    icon = null,
    prefab = null,
    hungerChange = 6,
    hydrationChange = 1,
    weight = 0.3f,
    maxStackSize = 20,

    foodPoisoningChance = 0.004f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "eel_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 3,

    tags = new List<string> { "item", "food", "fish", "eel", "grilled", "sliceable", "cooked", "oily_fish" }
},
new FishItemEntry
{
    itemID = "catfish_raw",
    displayName = "Catfish (Raw)",
    icon = null,
    prefab = null,
    hungerChange = 5,
    hydrationChange = 2,
    weight = 0.4f,
    maxStackSize = 20,

    foodPoisoningChance = 0.02f,
    salmonellaChance = 0.01f,
    parasiteChance = 0.015f,
    zombiePathogenChance = 0.0002f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.005f,

    isCooked = false,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = true,
    canBeSteamed = false,
    canBeFried = true,
    canBeRoasted = false,
    canBeGrilled = true,
    canBeSmoked = false,

    secondaryItemID = "catfish_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 4,

    tags = new List<string> { "item", "food", "fish", "catfish", "raw", "sliceable", "fryable", "boilable", "grillable", "bottom_feeder" }
},

new FishItemEntry
{
    itemID = "catfish_fried",
    displayName = "Catfish (Fried)",
    icon = null,
    prefab = null,
    hungerChange = 8,
    hydrationChange = 0,
    weight = 0.4f,
    maxStackSize = 20,

    foodPoisoningChance = 0.003f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "catfish_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 4,

    tags = new List<string> { "item", "food", "fish", "catfish", "fried", "sliceable", "cooked", "bottom_feeder" }
},

new FishItemEntry
{
    itemID = "catfish_grilled",
    displayName = "Catfish (Grilled)",
    icon = null,
    prefab = null,
    hungerChange = 7,
    hydrationChange = 1,
    weight = 0.4f,
    maxStackSize = 20,

    foodPoisoningChance = 0.004f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "catfish_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 4,

    tags = new List<string> { "item", "food", "fish", "catfish", "grilled", "sliceable", "cooked", "bottom_feeder" }
},

new FishItemEntry
{
    itemID = "catfish_boiled",
    displayName = "Catfish (Boiled)",
    icon = null,
    prefab = null,
    hungerChange = 6,
    hydrationChange = 2,
    weight = 0.4f,
    maxStackSize = 20,

    foodPoisoningChance = 0.005f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 3,
    maxSlices = 6,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "catfish_bones",
    minSecondaryYield = 2,
    maxSecondaryYield = 4,

    tags = new List<string> { "item", "food", "fish", "catfish", "boiled", "sliceable", "cooked", "bottom_feeder" }
},
new FishItemEntry
{
    itemID = "alligator_raw",
    displayName = "Alligator (Raw)",
    icon = null,
    prefab = null,
    hungerChange = 7,
    hydrationChange = 1,
    weight = 0.5f,
    maxStackSize = 10,

    foodPoisoningChance = 0.03f,
    salmonellaChance = 0.015f,
    parasiteChance = 0.02f,
    zombiePathogenChance = 0.0003f,
    mercuryPoisoningChance = 0.003f,
    waterborneVirusChance = 0.006f,

    isCooked = false,
    canBeSliced = true,
    minSlices = 4,
    maxSlices = 8,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = true,
    canBeRoasted = true,
    canBeGrilled = true,
    canBeSmoked = false,

    secondaryItemID = "alligator_bones",
    minSecondaryYield = 3,
    maxSecondaryYield = 5,

    tags = new List<string> { "item", "food", "fish", "alligator", "raw", "sliceable", "fryable", "roastable", "grillable", "predator", "high_risk" }
},

new FishItemEntry
{
    itemID = "alligator_grilled",
    displayName = "Alligator (Grilled)",
    icon = null,
    prefab = null,
    hungerChange = 10,
    hydrationChange = 0,
    weight = 0.5f,
    maxStackSize = 10,

    foodPoisoningChance = 0.005f,
    salmonellaChance = 0.002f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.003f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 4,
    maxSlices = 8,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "alligator_bones",
    minSecondaryYield = 3,
    maxSecondaryYield = 5,

    tags = new List<string> { "item", "food", "fish", "alligator", "grilled", "sliceable", "cooked", "predator", "high_reward" }
},

new FishItemEntry
{
    itemID = "alligator_fried",
    displayName = "Alligator (Fried)",
    icon = null,
    prefab = null,
    hungerChange = 11,
    hydrationChange = 0,
    weight = 0.5f,
    maxStackSize = 10,

    foodPoisoningChance = 0.004f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.003f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 4,
    maxSlices = 8,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "alligator_bones",
    minSecondaryYield = 3,
    maxSecondaryYield = 5,

    tags = new List<string> { "item", "food", "fish", "alligator", "fried", "sliceable", "cooked", "predator", "high_reward" }
},

new FishItemEntry
{
    itemID = "alligator_roasted",
    displayName = "Alligator (Roasted)",
    icon = null,
    prefab = null,
    hungerChange = 9,
    hydrationChange = 1,
    weight = 0.5f,
    maxStackSize = 10,

    foodPoisoningChance = 0.006f,
    salmonellaChance = 0.002f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.003f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = true,
    minSlices = 4,
    maxSlices = 8,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "alligator_bones",
    minSecondaryYield = 3,
    maxSecondaryYield = 5,

    tags = new List<string> { "item", "food", "fish", "alligator", "roasted", "sliceable", "cooked", "predator", "high_reward" }
},
new FishItemEntry
{
    itemID = "crab_raw",
    displayName = "Crab (Raw)",
    icon = null,
    prefab = null,
    hungerChange = 4,
    hydrationChange = 1,
    weight = 0.25f,
    maxStackSize = 20,

    foodPoisoningChance = 0.025f,
    salmonellaChance = 0.012f,
    parasiteChance = 0.018f,
    zombiePathogenChance = 0.0002f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.005f,

    isCooked = false,
    canBeSliced = false,
    minSlices = 0,
    maxSlices = 0,
    canBeBoiled = true,
    canBeSteamed = false,
    canBeFried = true,
    canBeRoasted = false,
    canBeGrilled = true,
    canBeSmoked = false,

    secondaryItemID = "crab_shell",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,

    tags = new List<string> { "item", "food", "fish", "crab", "raw", "boilable", "fryable", "grillable", "not_a_fish", "shellfish" }
},

new FishItemEntry
{
    itemID = "crab_boiled",
    displayName = "Crab (Boiled)",
    icon = null,
    prefab = null,
    hungerChange = 6,
    hydrationChange = 1,
    weight = 0.25f,
    maxStackSize = 20,

    foodPoisoningChance = 0.004f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = false,
    minSlices = 0,
    maxSlices = 0,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "crab_shell",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,

    tags = new List<string> { "item", "food", "fish", "crab", "boiled", "cooked", "not_a_fish", "shellfish" }
},

new FishItemEntry
{
    itemID = "crab_grilled",
    displayName = "Crab (Grilled)",
    icon = null,
    prefab = null,
    hungerChange = 5,
    hydrationChange = 0,
    weight = 0.25f,
    maxStackSize = 20,

    foodPoisoningChance = 0.005f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = false,
    minSlices = 0,
    maxSlices = 0,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "crab_shell",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,

    tags = new List<string> { "item", "food", "fish", "crab", "grilled", "cooked", "not_a_fish", "shellfish" }
},

new FishItemEntry
{
    itemID = "crab_fried",
    displayName = "Crab (Fried)",
    icon = null,
    prefab = null,
    hungerChange = 7,
    hydrationChange = 0,
    weight = 0.25f,
    maxStackSize = 20,

    foodPoisoningChance = 0.003f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.001f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.001f,

    isCooked = true,
    canBeSliced = false,
    minSlices = 0,
    maxSlices = 0,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "crab_shell",
    minSecondaryYield = 1,
    maxSecondaryYield = 2,

    tags = new List<string> { "item", "food", "fish", "crab", "fried", "cooked", "not_a_fish", "shellfish" }
},
new FishItemEntry
{
    itemID = "mussel_raw",
    displayName = "Mussel (Raw)",
    icon = null,
    prefab = null,
    hungerChange = 2,
    hydrationChange = 1,
    weight = 0.05f,
    maxStackSize = 50,

    foodPoisoningChance = 0.04f,
    salmonellaChance = 0.02f,
    parasiteChance = 0.03f,
    zombiePathogenChance = 0.0003f,
    mercuryPoisoningChance = 0.002f,
    waterborneVirusChance = 0.01f,

    isCooked = false,
    canBeSliced = false,
    minSlices = 0,
    maxSlices = 0,
    canBeBoiled = true,
    canBeSteamed = true,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "mussel_shell",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string> { "item", "food", "fish", "mussel", "raw", "boilable", "steamable", "not_a_fish", "shellfish", "lake_creature", "river_creature" }
},

new FishItemEntry
{
    itemID = "mussel_boiled",
    displayName = "Mussel (Boiled)",
    icon = null,
    prefab = null,
    hungerChange = 3,
    hydrationChange = 1,
    weight = 0.05f,
    maxStackSize = 50,

    foodPoisoningChance = 0.005f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.002f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.002f,

    isCooked = true,
    canBeSliced = false,
    minSlices = 0,
    maxSlices = 0,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "mussel_shell",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string> { "item", "food", "fish", "mussel", "boiled", "cooked", "not_a_fish", "shellfish", "lake_creature", "river_creature" }
},

new FishItemEntry
{
    itemID = "mussel_steamed",
    displayName = "Mussel (Steamed)",
    icon = null,
    prefab = null,
    hungerChange = 3,
    hydrationChange = 2,
    weight = 0.05f,
    maxStackSize = 50,

    foodPoisoningChance = 0.004f,
    salmonellaChance = 0.001f,
    parasiteChance = 0.002f,
    zombiePathogenChance = 0.00005f,
    mercuryPoisoningChance = 0.001f,
    waterborneVirusChance = 0.002f,

    isCooked = true,
    canBeSliced = false,
    minSlices = 0,
    maxSlices = 0,
    canBeBoiled = false,
    canBeSteamed = false,
    canBeFried = false,
    canBeRoasted = false,
    canBeGrilled = false,
    canBeSmoked = false,

    secondaryItemID = "mussel_shell",
    minSecondaryYield = 1,
    maxSecondaryYield = 1,

    tags = new List<string> { "item", "food", "fish", "mussel", "steamed", "cooked", "not_a_fish", "shellfish", "lake_creature", "river_creature" }
}









    };
}
