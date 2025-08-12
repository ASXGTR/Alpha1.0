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

        // 🐟 Fish (includes crab, mussel, alligator)
        var fishDB = LoadDatabaseAsset<FishItemDatabase>("FishItemDatabase");
        if (fishDB != null)
        {
            allItems.AddRange(fishDB.fishItems.Select(f => ConvertFishToItemData(f)));
        }


        // 🥫 Tinned Items
        var tinnedDB = LoadDatabaseAsset<TinnedItemDatabase>("TinnedItemDatabase");
        if (tinnedDB != null)
        {
            allItems.AddRange(tinnedDB.items);
        }

        // 🥦 Vegetables
        var vegDB = LoadDatabaseAsset<VegetableItemDatabase>("VegetableItemDatabase");
        if (vegDB != null)
        {
            allItems.AddRange(vegDB.items.Select(v => ConvertVegetableToItemData(v)));
        }


        // 🥩 Meat (future activation)
        // var meatDB = LoadDatabaseAsset<MeatItemDatabase>("MeatItemDatabase");
        // if (meatDB != null)
        // {
        //     allItems.AddRange(meatDB.meatItems.Select(m => ConvertMeatToItemData(m)));
        // }
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
            healthChange = 0f,
            temperatureChange = 0f,
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
                foodPoisoningChance = fruit.foodPoisoningChance,
                salmonellaChance = fruit.salmonellaChance,
                parasiteChance = fruit.parasiteChance,
                zombiePathogenChance = fruit.zombiePathogenChance
                // 🧠 No madCow, avianFlu, or cannibalDisease for fruit
            }
        };
    }

    public static ItemData ConvertVegetableToItemData(VegetableItemEntry veg)
    {
        return new ItemData
        {
            itemID = veg.itemID,
            displayName = veg.displayName,
            hungerChange = veg.hungerChange,
            hydrationChange = veg.hydrationChange,
            healthChange = 0f,
            temperatureChange = 0f,
            isCooked = veg.isCooked,
            tags = veg.tags,
            canBeBoiled = veg.canBeBoiled,
            canBeGrilled = veg.canBeGrilled,
            canBeRoasted = veg.canBeRoasted,
            canBeSteamed = veg.canBeSteamed,
            canBeFried = veg.canBeFried,
            canBeSliced = veg.canBeSliced,
            minSlices = veg.minSlices,
            maxSlices = veg.maxSlices,
            secondaryItemID = veg.secondaryItemID,
            minSecondaryYield = veg.minSecondaryYield,
            maxSecondaryYield = veg.maxSecondaryYield,
            isStackable = true,
            maxStackSize = veg.maxStackSize,
            weight = veg.weight,
            condition = 100,
            diseaseProfile = new FoodDiseaseProfile
            {
                foodPoisoningChance = veg.foodPoisoningChance,
                salmonellaChance = veg.salmonellaChance,
                parasiteChance = veg.parasiteChance,
                zombiePathogenChance = veg.zombiePathogenChance
                // 🧠 No madCow, avianFlu, or cannibalDisease for vegetables
            }
        };
    }

    // 🥩 Future meat converter (to be added when MeatItemDatabase is ready)
    // public static ItemData ConvertMeatToItemData(MeatItemEntry meat)
    // {
    //     return new ItemData
    //     {
    //         itemID = meat.itemID,
    //         displayName = meat.displayName,
    //         hungerChange = meat.hungerChange,
    //         hydrationChange = meat.hydrationChange,
    //         healthChange = 0f,
    //         temperatureChange = 0f,
    //         isCooked = meat.isCooked,
    //         tags = meat.tags,
    //         canBeBoiled = meat.canBeBoiled,
    //         canBeGrilled = meat.canBeGrilled,
    //         canBeRoasted = meat.canBeRoasted,
    //         canBeSteamed = meat.canBeSteamed,
    //         canBeFried = meat.canBeFried,
    //         canBeSliced = meat.canBeSliced,
    //         minSlices = meat.minSlices,
    //         maxSlices = meat.maxSlices,
    //         secondaryItemID = meat.secondaryItemID,
    //         minSecondaryYield = meat.minSecondaryYield,
    //         maxSecondaryYield = meat.maxSecondaryYield,
    //         isStackable = true,
    //         maxStackSize = meat.maxStackSize,
    //         weight = meat.weight,
    //         condition = 100,
    //         diseaseProfile = new FoodDiseaseProfile
    //         {
    //             foodPoisoningChance = meat.foodPoisoningChance,
    //             salmonellaChance = meat.salmonellaChance,
    //             parasiteChance = meat.parasiteChance,
    //             zombiePathogenChance = meat.zombiePathogenChance,
    //             madCowChance = meat.madCowChance,
    //             avianFluChance = meat.avianFluChance,
    //             cannibalDiseaseChance = meat.cannibalDiseaseChance
    //         }
    //     };
    // }

    public static ItemData ConvertFishToItemData(FishItemEntry fish)
    {
        return new ItemData
        {
            itemID = fish.itemID,
            displayName = fish.displayName,
            hungerChange = fish.hungerChange,
            hydrationChange = fish.hydrationChange,
            healthChange = 0f,
            temperatureChange = 0f,
            isCooked = fish.isCooked,
            tags = fish.tags,
            canBeBoiled = fish.canBeBoiled,
            canBeGrilled = fish.canBeGrilled,
            canBeRoasted = fish.canBeRoasted,
            canBeSteamed = fish.canBeSteamed,
            canBeFried = fish.canBeFried,
            canBeSliced = fish.canBeSliced,
            minSlices = fish.minSlices,
            maxSlices = fish.maxSlices,
            secondaryItemID = fish.secondaryItemID,
            minSecondaryYield = fish.minSecondaryYield,
            maxSecondaryYield = fish.maxSecondaryYield,
            isStackable = true,
            maxStackSize = fish.maxStackSize,
            weight = fish.weight,
            condition = 100,
            diseaseProfile = new FoodDiseaseProfile
            {
                foodPoisoningChance = fish.foodPoisoningChance,
                salmonellaChance = fish.salmonellaChance,
                parasiteChance = fish.parasiteChance,
                zombiePathogenChance = fish.zombiePathogenChance,
                mercuryPoisoningChance = fish.mercuryPoisoningChance,
                waterborneVirusChance = fish.waterborneVirusChance
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
