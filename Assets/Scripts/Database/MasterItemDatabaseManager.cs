using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public static class MasterItemDatabaseManager
{
    public static List<ItemData> allItems = new();

    static MasterItemDatabaseManager()
    {
        // 🍏 Fruits
        var fruitDB = LoadDatabaseAsset<FruitItemDatabase>("FruitItemDatabase");
        if (fruitDB != null)
        {
            allItems.AddRange(fruitDB.fruitItems.Select(f => ConvertFruitToItemData(f)));
        }

        // 🥫 Tinned Items
        var tinnedDB = LoadDatabaseAsset<TinnedItemDatabase>("TinnedItemDatabase");
        if (tinnedDB != null)
        {
            allItems.AddRange(tinnedDB.items);
        }

        // 🛠️ Future Databases
        // var vegDB = LoadDatabaseAsset<VegetableItemDatabase>("VegetableItemDatabase");
        // if (vegDB != null) allItems.AddRange(vegDB.items);
    }

    private static T LoadDatabaseAsset<T>(string assetName) where T : ScriptableObject
    {
        string[] guids = AssetDatabase.FindAssets(assetName + " t:" + typeof(T).Name);
        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            if (System.IO.Path.GetFileNameWithoutExtension(path) == assetName)
            {
                return AssetDatabase.LoadAssetAtPath<T>(path);
            }
        }
        Debug.LogWarning($"⚠️ Could not find asset named '{assetName}' of type {typeof(T).Name}");
        return null;
    }

    public static ItemData ConvertFruitToItemData(FruitItemDatabase.FruitItemEntry fruit)
    {
        return new ItemData
        {
            itemID = fruit.itemID,
            displayName = fruit.displayName,
            hungerChange = fruit.hungerChange,
            hydrationChange = fruit.hydrationChange,
            isCooked = fruit.isCooked,
            tags = fruit.tags,
            canBeBoiled = fruit.canBeBoiled,
            canBeGrilled = fruit.canBeGrilled,
            canBeRoasted = fruit.canBeRoasted,
            canBeSteamed = fruit.canBeSteamed,
            canBeFried = fruit.canBeFried,
            canBeSliced = fruit.canBeSliced,
            minSlices = fruit.minSlices,
            maxSlices = fruit.maxSlices,
            secondaryItemID = fruit.secondaryItemID,
            minSecondaryYield = fruit.minSecondaryYield,
            maxSecondaryYield = fruit.maxSecondaryYield,
            isStackable = true,
            maxStackSize = fruit.maxStackSize,
            weight = fruit.weight,
            condition = 100,
            diseaseProfile = new FoodDiseaseProfile
            {
                foodPoisoningChance = fruit.foodPoisoningChance
            }
        };
    }

    public static ItemData GetItemByID(string id)
    {
        return allItems.FirstOrDefault(item => item.itemID == id);
    }

    public static List<ItemData> GetItemsByCategory(ItemCategory category)
    {
        return allItems.Where(item => item.categories != null && item.categories.Contains(category)).ToList();
    }

    public static List<ItemData> GetItemsByTag(string tag)
    {
        return allItems.Where(item => item.tags != null && item.tags.Contains(tag)).ToList();
    }
}
