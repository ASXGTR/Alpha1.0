using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TinnedItemDatabase", menuName = "Databases/Tinned Item Database")]
public class TinnedItemDatabase : ScriptableObject
{
    public List<ItemData> items = new(); // ✅ Empty by default

#if UNITY_EDITOR
    [ContextMenu("Auto-Populate Tinned Items")]
    public void AutoPopulate()
    {
        items.Clear();
        items.AddRange(CreateTinnedItemSet("beans", 15, 5, 0.6f, true));
        items.AddRange(CreateTinnedItemSet("peas", 10, 4, 0.5f));
        items.AddRange(CreateTinnedItemSet("carrots", 12, 3, 0.5f));
        items.AddRange(CreateTinnedItemSet("peaches", 8, 6, 0.6f));
        items.AddRange(CreateTinnedItemSet("sardines", 20, 0, 0.4f, true));
        items.AddRange(CreateTinnedItemSet("tuna", 18, 0, 0.5f, true));
        items.AddRange(CreateTinnedItemSet("beef_stew", 25, 5, 0.8f, true));
        items.AddRange(CreateTinnedItemSet("ham", 22, 0, 0.7f, true));
        items.AddRange(CreateTinnedItemSet("plums", 10, 5, 0.6f));
        items.AddRange(CreateTinnedItemSet("spaghetti", 20, 4, 0.7f, true));
        items.AddRange(CreateTinnedItemSet("boiled_potatoes", 15, 3, 0.6f, true));
        items.AddRange(CreateTinnedItemSet("soup_tomato", 12, 6, 0.6f));
        items.AddRange(CreateTinnedItemSet("soup_oxtail", 18, 4, 0.7f));
        items.AddRange(CreateTinnedItemSet("soup_minestrone", 16, 5, 0.7f));
        items.AddRange(CreateTinnedItemSet("pie_chicken", 22, 2, 0.9f));
        items.AddRange(CreateTinnedItemSet("pie_meat_potato", 24, 3, 1.0f));
        items.AddRange(CreateTinnedItemSet("pineapple_slices", 6, 7, 0.5f));
        items.AddRange(CreateTinnedItemSet("cherries", 5, 6, 0.4f));
    }
#endif

    private List<ItemData> CreateTinnedItemSet(string name, int hunger, int hydration, float weight, bool canFry = false)
    {
        string sealedID = $"tinned_{name}_sealed";
        string openedID = $"tinned_{name}_opened";
        string cookedID = $"tinned_{name}_cooked";

        List<string> baseTags = new() { "item", "food", "tinned", name };

        ItemData sealedItem = new ItemData
        {
            itemID = sealedID,
            displayName = $"Tinned {FormatName(name)} (Sealed)",
            categories = new() { ItemCategory.Food },
            slotSize = 1,
            isEquipable = false,
            hungerChange = hunger,
            hydrationChange = hydration,
            temperatureChange = 0,
            diseaseProfile = new FoodDiseaseProfile { foodPoisoningChance = 2f },
            canBeBoiled = true,
            canBeGrilled = false,
            canBeRoasted = false,
            canBeSteamed = true,
            canBeFried = canFry,
            tags = new(baseTags) { "sealed" },
            usedInCrafting = false,
            usedInCooking = true,
            isCooked = false,
            prefabPath = "",
            icon = null,
            isStackable = false,
            maxStackSize = 1,
            weight = weight,
            canBeSliced = false,
            condition = 100
        };

        ItemData openedItem = new ItemData
        {
            itemID = openedID,
            displayName = $"Tinned {FormatName(name)} (Opened)",
            categories = new() { ItemCategory.Food },
            slotSize = 1,
            isEquipable = false,
            hungerChange = hunger,
            hydrationChange = hydration,
            temperatureChange = 0,
            diseaseProfile = new FoodDiseaseProfile { foodPoisoningChance = 8f },
            canBeBoiled = true,
            canBeGrilled = false,
            canBeRoasted = false,
            canBeSteamed = true,
            canBeFried = canFry,
            tags = new(baseTags) { "opened" },
            usedInCrafting = false,
            usedInCooking = true,
            isCooked = false,
            prefabPath = "",
            icon = null,
            isStackable = false,
            maxStackSize = 1,
            weight = weight,
            canBeSliced = false,
            condition = 85
        };

        ItemData cookedItem = new ItemData
        {
            itemID = cookedID,
            displayName = $"Tinned {FormatName(name)} (Cooked)",
            categories = new() { ItemCategory.Food },
            slotSize = 1,
            isEquipable = false,
            hungerChange = hunger + 5,
            hydrationChange = hydration,
            temperatureChange = 10,
            diseaseProfile = new FoodDiseaseProfile { foodPoisoningChance = 1f },
            canBeBoiled = false,
            canBeGrilled = false,
            canBeRoasted = false,
            canBeSteamed = false,
            canBeFried = false,
            tags = new(baseTags) { "cooked" },
            usedInCrafting = false,
            usedInCooking = false,
            isCooked = true,
            prefabPath = "",
            icon = null,
            isStackable = false,
            maxStackSize = 1,
            weight = weight,
            canBeSliced = false,
            condition = 100
        };

        return new List<ItemData> { sealedItem, openedItem, cookedItem };
    }

    private string FormatName(string raw)
    {
        return raw.Replace("_", " ")
                  .Replace("soup ", "Soup: ")
                  .Replace("pie ", "Pie: ");
    }
}
