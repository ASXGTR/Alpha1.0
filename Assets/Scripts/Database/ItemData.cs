using System.Collections.Generic;
using UnityEngine;

// 🧃 Liquid Type Enumeration
public enum LiquidType
{
    None,
    CleanWater,
    UncleanWater,
    SeaWater,
    SaltWater,
    Alcohol,
    FizzyDrink,
    Juice,
    CookingOil,
    CleaningLiquid,
    Fuel,
    Coolant,
    Oil,
    EnergyDrink,
    ProteinDrink,
    Milk,
    FlavoredWater,
    FertilizerLiquid,
    Chemical,
    FoodOil
}

// 🧪 Modular Disease Profile for Food Items
public class FoodDiseaseProfile
{
    public float foodPoisoningChance = 0f;
    public float salmonellaChance = 0f;
    public float parasiteChance = 0f;
    public float zombiePathogenChance = 0f;
    public float madCowChance = 0f;
    public float avianFluChance = 0f;
    public float cannibalDiseaseChance = 0f;

    // 🐟 Aquatic-specific
    public float mercuryPoisoningChance = 0f;
    public float saltOverdoseChance = 0f;
    public float waterborneVirusChance = 0f;
}

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
    public bool canBeFried;

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

    // 🆕 Secondary Yield (e.g. bones)
    public string secondaryItemID;
    public int minSecondaryYield;
    public int maxSecondaryYield;

    // 🆕 Universal Condition System (0–100)
    public int condition = 100;

    // 🧪 Disease Profile (Food-Related)
    public FoodDiseaseProfile diseaseProfile = new();

    // 🧃 Liquid Classification
    public LiquidType liquidType = LiquidType.None;
    public bool canBeBoiledForPurification;
    public bool isBoiled;
    public bool isCooledAfterBoil;

    public bool usedForCleaning;
    public bool usedAsFuel;
    public bool usedInCookingLiquid;

    // 🧠 Satirical Metadata
    public string hydrationLoreTag;

    // 🧃 Container-Specific Flags
    public bool isReusable; // Can be reused after emptying
    public bool isFillable; // Can be filled from external sources

    public float maxVolume; // Max liquid capacity
    public float currentVolume; // Current liquid amount

    public LiquidOriginType originType = LiquidOriginType.InventoryItem; // Referenced from shared enum

    // 🧃 Container State Helpers
    public bool IsEmpty => currentVolume <= 0f;
    public bool IsFull => currentVolume >= maxVolume;

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
    public float GetEffectiveMadCowChance() => diseaseProfile.madCowChance * (condition / 100f);
    public float GetEffectiveAvianFluChance() => diseaseProfile.avianFluChance * (condition / 100f);
    public float GetEffectiveCannibalDiseaseChance() => diseaseProfile.cannibalDiseaseChance * (condition / 100f);
    public float GetEffectiveMercuryPoisoningChance() => diseaseProfile.mercuryPoisoningChance * (condition / 100f);
    public float GetEffectiveWaterborneVirusChance() => diseaseProfile.waterborneVirusChance * (condition / 100f);

    // 🧪 Unified Disease Risk Dictionary (for UI or analytics)
    public Dictionary<string, float> GetAllEffectiveDiseaseRisks()
    {
        return new Dictionary<string, float>
        {
            { "FoodPoisoning", GetEffectiveFoodPoisoningChance() },
            { "Salmonella", GetEffectiveSalmonellaChance() },
            { "Parasite", GetEffectiveParasiteChance() },
            { "ZombiePathogen", GetEffectiveZombiePathogenChance() },
            { "MadCow", GetEffectiveMadCowChance() },
            { "AvianFlu", GetEffectiveAvianFluChance() },
            { "CannibalDisease", GetEffectiveCannibalDiseaseChance() },
            { "MercuryPoisoning", GetEffectiveMercuryPoisoningChance() },
            { "WaterborneVirus", GetEffectiveWaterborneVirusChance() }
        };
    }

    // 🛠️ Condition Adjustment (e.g. opening tins)
    public void AdjustCondition(int amount)
    {
        condition = Mathf.Clamp(condition - amount, 0, 100);
    }

    // 🧃 Hydration Logic Helper
    public bool IsDrinkable()
    {
        return liquidType == LiquidType.CleanWater ||
               (liquidType == LiquidType.UncleanWater && isBoiled && isCooledAfterBoil) ||
               liquidType == LiquidType.FizzyDrink ||
               liquidType == LiquidType.Juice ||
               liquidType == LiquidType.Alcohol;
    }

    // 🧃 Liquid Purification Logic
    public bool CanBePurified()
    {
        return liquidType == LiquidType.UncleanWater && canBeBoiledForPurification;
    }

    public bool IsPurified()
    {
        return isBoiled && isCooledAfterBoil;
    }

    // 🧃 Liquid Usage Logic
    public bool IsUsableForCleaning()
    {
        return usedForCleaning && IsPurified();
    }

    public bool IsUsableForCookingLiquid()
    {
        return usedInCookingLiquid && IsPurified();
    }
}
