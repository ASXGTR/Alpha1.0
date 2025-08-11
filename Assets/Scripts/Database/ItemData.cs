// Assets/Scripts/Database/ItemData.cs
using System.Collections.Generic;
using UnityEngine;

public class ItemData
{
    public string itemID;
    public string displayName;
    public List<ItemCategory> categories;
    public int slotSize;
    public bool isEquipable;

    public float healthChange;
    public float hungerChange;
    public float hydrationChange;
    public float temperatureChange;

    // ✅ Cooking Flags
    public bool canBeBoiled;
    public bool canBeGrilled;
    public bool canBeRoasted;
    public bool canBeSteamed;
    public bool canBeFried; // ✅ Added

    public List<string> tags;
    public bool usedInCrafting;
    public bool usedInCooking;
    public bool isCooked;

    public string prefabPath;
    public object icon;

    // 🆕 Stackability & Weight
    public bool isStackable;
    public int maxStackSize;
    public float weight;

    // 🆕 Slicing Logic
    public bool canBeSliced;
    public int minSlices;
    public int maxSlices;

    // 🆕 Secondary Yield (e.g. seeds)
    public string secondaryItemID;
    public int minSecondaryYield;
    public int maxSecondaryYield;

    // 🆕 Universal Condition System (0–100)
    public int condition = 100;

    // 🧪 Disease Profile (Food-Related)
    public FoodDiseaseProfile diseaseProfile = new();

    // 🧪 Food Effectiveness Based on Condition
    public float GetEffectiveHunger() => hungerChange * (condition / 100f);
    public float GetEffectiveHydration() => hydrationChange * (condition / 100f);
    public float GetEffectiveHealth() => healthChange * (condition / 100f);
    public float GetEffectiveTemperature() => temperatureChange * (condition / 100f);

    // 🧪 Disease Risk Based on Condition
    public float GetEffectiveFoodPoisoningChance() => diseaseProfile.foodPoisoningChance * (condition / 100f);
    public float GetEffectiveSalmonellaChance() => diseaseProfile.salmonellaChance * (condition / 100f);
    public float GetEffectiveParasiteChance() => diseaseProfile.parasiteChance * (condition / 100f);
    public float GetEffectiveZombiePathogenChance() => diseaseProfile.zombiePathogenChance * (condition / 100f);

    // 🛠️ Condition Adjustment (e.g. opening tins)
    public void AdjustCondition(int amount)
    {
        condition = Mathf.Clamp(condition - amount, 0, 100);
    }
}

// 🧪 Modular Disease Profile for Food Items
public class FoodDiseaseProfile
{
    public float foodPoisoningChance = 0f;
    public float salmonellaChance = 0f;
    public float parasiteChance = 0f;
    public float zombiePathogenChance = 0f;
}
