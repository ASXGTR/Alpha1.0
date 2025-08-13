using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SeedItemDatabase", menuName = "Databases/Seed Item Database")]
public class SeedItemDatabase : ScriptableObject
{
    [System.Serializable]
    public class SeedItemEntry
    {
        [Header("Seed Identity")]
        public string itemID;
        public string displayName;
        public Sprite icon;
        public GameObject cropPrefab;

        [Header("Growth Settings")]
        public float growthTimeDays = 3f;
        public int maxYield = 1;
        public bool regrowsAfterHarvest = false;

        [Header("Requirements")]
        public bool requiresFertilizer = true;
        public bool requiresWatering = true;

        [Header("Inventory Settings")]
        public int maxStackSize = 99;
        public float weight = 0.05f;
        public List<string> tags = new();

        [Header("Edible Taxonomy")]
        public float hungerChange = 0f;
        public float hydrationChange = 0f;

        [Header("Cooking Flags")]
        public bool isCooked = false;
        public bool canBeBoiled = false;
        public bool canBeGrilled = false;
        public bool canBeRoasted = false;
        public bool canBeSteamed = false;
        public bool canBeFried = false;

        [Header("Slicing")]
        public bool canBeSliced = false;
        public int minSlices = 0;
        public int maxSlices = 0;

        [Header("Secondary Yield")]
        public string secondaryItemID;
        public int minSecondaryYield = 0;
        public int maxSecondaryYield = 0;

        [Header("Disease Profile")]
        public float parasiteChance = 0f;
        public float foodPoisoningChance = 0f;
        public float salmonellaChance = 0f;
        public float zombiePathogenChance = 0f;
    }

    [Header("Seed Items")]
    public List<SeedItemEntry> seedItems = new()
    {
        new SeedItemEntry {
            itemID = "apple_green_seeds",
            displayName = "Green Apple Seeds",
            icon = null,
            cropPrefab = null,
            growthTimeDays = 3.5f,
            maxYield = 3,
            regrowsAfterHarvest = false,
            requiresFertilizer = true,
            requiresWatering = true,
            maxStackSize = 99,
            weight = 0.05f,
            tags = new() { "item", "seed", "farming", "growable", "apple" }
        },
        new SeedItemEntry {
            itemID = "apple_red_seeds",
            displayName = "Red Apple Seeds",
            icon = null,
            cropPrefab = null,
            growthTimeDays = 3.5f,
            maxYield = 3,
            regrowsAfterHarvest = false,
            requiresFertilizer = true,
            requiresWatering = true,
            maxStackSize = 99,
            weight = 0.05f,
            tags = new() { "item", "seed", "farming", "growable", "apple", "red" }
        },
        new SeedItemEntry {
            itemID = "pear_seeds",
            displayName = "Pear Seeds",
            icon = null,
            cropPrefab = null,
            growthTimeDays = 7f,
            maxYield = 1,
            regrowsAfterHarvest = false,
            requiresFertilizer = true,
            requiresWatering = true,
            maxStackSize = 99,
            weight = 0.05f,
            tags = new() { "item", "seed", "farming", "growable", "pear", "fruit-derived", "organic", "non-edible" }
        },
        new SeedItemEntry {
            itemID = "orange_seeds",
            displayName = "Orange Seeds",
            icon = null,
            cropPrefab = null,
            growthTimeDays = 6f,
            maxYield = 2,
            regrowsAfterHarvest = false,
            requiresFertilizer = true,
            requiresWatering = true,
            maxStackSize = 99,
            weight = 0.05f,
            tags = new() { "item", "seed", "farming", "growable", "orange", "fruit-derived", "organic", "non-edible" }
        },
        new SeedItemEntry {
            itemID = "tomato_seeds",
            displayName = "Tomato Seeds",
            icon = null,
            cropPrefab = null,
            growthTimeDays = 4f,
            maxYield = 3,
            regrowsAfterHarvest = false,
            requiresFertilizer = true,
            requiresWatering = true,
            maxStackSize = 99,
            weight = 0.02f,
            tags = new() { "item", "seed", "farming", "growable", "tomato", "fruit-derived", "organic", "non-edible" }
        },
        new SeedItemEntry {
            itemID = "peach_seed",
            displayName = "Peach Seed",
            icon = null,
            cropPrefab = null,
            growthTimeDays = 5f,
            maxYield = 2,
            regrowsAfterHarvest = false,
            requiresFertilizer = true,
            requiresWatering = true,
            maxStackSize = 99,
            weight = 0.03f,
            tags = new() { "item", "seed", "farming", "growable", "peach", "fruit-derived", "stone-fruit", "organic", "non-edible" }
        },
        new SeedItemEntry {
            itemID = "pumpkin_seeds",
            displayName = "Pumpkin Seeds",
            icon = null,
            cropPrefab = null,
            growthTimeDays = 6f,
            maxYield = 2,
            regrowsAfterHarvest = false,
            requiresFertilizer = true,
            requiresWatering = true,
            maxStackSize = 99,
            weight = 0.04f,
            tags = new() { "item", "seed", "farming", "growable", "pumpkin", "fruit-derived", "organic", "non-edible" }
        },
        new SeedItemEntry {
            itemID = "cherry_seed",
            displayName = "Cherry Seed",
            icon = null,
            cropPrefab = null,
            growthTimeDays = 5f,
            maxYield = 2,
            regrowsAfterHarvest = false,
            requiresFertilizer = true,
            requiresWatering = true,
            maxStackSize = 99,
            weight = 0.02f,
            tags = new() { "item", "seed", "farming", "growable", "cherry", "fruit-derived", "stone-fruit", "organic", "non-edible" }
        },
        new SeedItemEntry {
            itemID = "melon_yellow_seeds",
            displayName = "Yellow Melon Seeds",
            icon = null,
            cropPrefab = null,
            growthTimeDays = 5f,
            maxYield = 2,
            regrowsAfterHarvest = false,
            requiresFertilizer = true,
            requiresWatering = true,
            maxStackSize = 99,
            weight = 0.03f,
            tags = new() { "item", "seed", "farming", "growable", "melon", "yellow", "fruit-derived", "organic", "non-edible" }
        },
        new SeedItemEntry {
            itemID = "melon_water_seeds",
            displayName = "Watermelon Seeds",
            icon = null,
            cropPrefab = null,
            growthTimeDays = 6f,
            maxYield = 2,
            regrowsAfterHarvest = false,
            requiresFertilizer = true,
            requiresWatering = true,
            maxStackSize = 99,
            weight = 0.03f,
            tags = new() { "item", "seed", "farming", "growable", "melon", "watermelon", "fruit-derived", "organic", "non-edible" }
        },
        new SeedItemEntry {
            itemID = "sweetcorn_seed",
            displayName = "Sweetcorn Seed",
            icon = null,
            cropPrefab = null,
            growthTimeDays = 5f,
            maxYield = 3,
            regrowsAfterHarvest = false,
            requiresFertilizer = true,
            requiresWatering = true,
            maxStackSize = 99,
            weight = 0.03f,
            tags = new() { "item", "seed", "farming", "growable", "sweetcorn", "vegetable-derived", "organic", "non-edible" }
        }
    };
}
