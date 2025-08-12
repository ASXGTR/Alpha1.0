using System.Collections.Generic;
using UnityEngine;

// 🧃 Unified Liquid Entry (Items + Environmental Sources)
[System.Serializable]
public class LiquidEntry
{
    public string liquidID;
    public string displayName;
    public LiquidType type;
    public LiquidOriginType originType;

    public bool isCollectible;
    public bool canBeBoiled;
    public bool usedInCooking;
    public bool usedForCleaning;
    public bool usedAsFuel;

    public float hydrationValue;
    public float temperatureChange;

    public FoodDiseaseProfile diseaseProfile = new();
}

// 🧃 Liquid Source Database (ScriptableObject)
[CreateAssetMenu(fileName = "LiquidSourceDatabase", menuName = "GameData/LiquidSourceDatabase")]
public class LiquidSourceDatabase : ScriptableObject
{
    public List<LiquidEntry> liquids = new()
    {
        new LiquidEntry
        {
            liquidID = "LakeWater",
            displayName = "Lake Water",
            type = LiquidType.UncleanWater,
            originType = LiquidOriginType.EnvironmentalSource,

            isCollectible = true,
            canBeBoiled = true,
            usedInCooking = true,
            usedForCleaning = true,
            usedAsFuel = false,

            hydrationValue = 25f,
            temperatureChange = -2f,

            diseaseProfile = new FoodDiseaseProfile
            {
                foodPoisoningChance = 0.3f,
                parasiteChance = 0.4f,
                waterborneVirusChance = 0.2f
            }
        },
        new LiquidEntry
        {
            liquidID = "PondWater",
            displayName = "Pond Water",
            type = LiquidType.UncleanWater,
            originType = LiquidOriginType.EnvironmentalSource,

            isCollectible = true,
            canBeBoiled = true,
            usedInCooking = false,
            usedForCleaning = true,
            usedAsFuel = false,

            hydrationValue = 20f,
            temperatureChange = -1f,

            diseaseProfile = new FoodDiseaseProfile
            {
                foodPoisoningChance = 0.4f,
                parasiteChance = 0.5f,
                zombiePathogenChance = 0.1f
            }
        },
        new LiquidEntry
        {
            liquidID = "RiverWater",
            displayName = "River Water",
            type = LiquidType.UncleanWater,
            originType = LiquidOriginType.EnvironmentalSource,

            isCollectible = true,
            canBeBoiled = true,
            usedInCooking = true,
            usedForCleaning = true,
            usedAsFuel = false,

            hydrationValue = 30f,
            temperatureChange = -3f,

            diseaseProfile = new FoodDiseaseProfile
            {
                foodPoisoningChance = 0.2f,
                parasiteChance = 0.3f,
                waterborneVirusChance = 0.15f
            }
        },
        new LiquidEntry
        {
            liquidID = "SwampWater",
            displayName = "Swamp Water",
            type = LiquidType.UncleanWater,
            originType = LiquidOriginType.EnvironmentalSource,

            isCollectible = true,
            canBeBoiled = true,
            usedInCooking = false,
            usedForCleaning = false,
            usedAsFuel = false,

            hydrationValue = 15f,
            temperatureChange = -1f,

            diseaseProfile = new FoodDiseaseProfile
            {
                foodPoisoningChance = 0.6f,
                parasiteChance = 0.7f,
                zombiePathogenChance = 0.3f,
                madCowChance = 0.1f
            }
        },
        new LiquidEntry
        {
            liquidID = "PuddleWater",
            displayName = "Puddle Water",
            type = LiquidType.UncleanWater,
            originType = LiquidOriginType.EnvironmentalSource,

            isCollectible = true,
            canBeBoiled = true,
            usedInCooking = false,
            usedForCleaning = false,
            usedAsFuel = false,

            hydrationValue = 10f,
            temperatureChange = -1f,

            diseaseProfile = new FoodDiseaseProfile
            {
                foodPoisoningChance = 0.5f,
                parasiteChance = 0.6f,
                zombiePathogenChance = 0.2f
            }
        },
        new LiquidEntry
        {
            liquidID = "RainWater",
            displayName = "Rain Water",
            type = LiquidType.CleanWater,
            originType = LiquidOriginType.EnvironmentalSource,

            isCollectible = true,
            canBeBoiled = false,
            usedInCooking = true,
            usedForCleaning = true,
            usedAsFuel = false,

            hydrationValue = 35f,
            temperatureChange = -1f,

            diseaseProfile = new FoodDiseaseProfile
            {
                foodPoisoningChance = 0.05f,
                parasiteChance = 0.1f
            }
        },
        new LiquidEntry
        {
            liquidID = "SeaWater",
            displayName = "Sea Water",
            type = LiquidType.SaltWater,
            originType = LiquidOriginType.EnvironmentalSource,

            isCollectible = true,
            canBeBoiled = false,
            usedInCooking = false,
            usedForCleaning = false,
            usedAsFuel = false,

            hydrationValue = -10f,
            temperatureChange = -2f,

            diseaseProfile = new FoodDiseaseProfile
            {
                foodPoisoningChance = 0.2f,
                parasiteChance = 0.3f,
                saltOverdoseChance = 0.5f
            }
        },
        new LiquidEntry
        {
            liquidID = "WellWater",
            displayName = "Well Water",
            type = LiquidType.CleanWater,
            originType = LiquidOriginType.EnvironmentalSource,

            isCollectible = true,
            canBeBoiled = true,
            usedInCooking = true,
            usedForCleaning = true,
            usedAsFuel = false,

            hydrationValue = 40f,
            temperatureChange = -1f,

            diseaseProfile = new FoodDiseaseProfile
            {
                foodPoisoningChance = 0.1f,
                parasiteChance = 0.1f
            }
        },

        new LiquidEntry
{
    liquidID = "ReservoirWater",
    displayName = "Reservoir Water",
    type = LiquidType.UncleanWater,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 30f,
    temperatureChange = -2f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.2f,
        parasiteChance = 0.3f,
        waterborneVirusChance = 0.1f
    }
},
new LiquidEntry
{
    liquidID = "WaterTank",
    displayName = "Water Tank",
    type = LiquidType.CleanWater,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 40f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.05f,
        parasiteChance = 0.05f
    }
},
new LiquidEntry
{
    liquidID = "WaterBarrel",
    displayName = "Water Barrel",
    type = LiquidType.UncleanWater,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 25f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.15f,
        parasiteChance = 0.2f
    }
},
new LiquidEntry
{
    liquidID = "RainBarrel",
    displayName = "Rain Barrel",
    type = LiquidType.CleanWater,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 35f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.05f,
        parasiteChance = 0.1f
    }
},
new LiquidEntry
{
    liquidID = "WaterTrough",
    displayName = "Water Trough",
    type = LiquidType.UncleanWater,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 20f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.3f,
        parasiteChance = 0.4f,
        madCowChance = 0.1f
    }
},
new LiquidEntry
{
    liquidID = "StreamWater",
    displayName = "Stream Water",
    type = LiquidType.UncleanWater,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 28f,
    temperatureChange = -2f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.2f,
        parasiteChance = 0.3f,
        waterborneVirusChance = 0.1f
    }
},
new LiquidEntry
{
    liquidID = "ToiletWater",
    displayName = "Toilet Water",
    type = LiquidType.UncleanWater,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 5f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.8f,
        parasiteChance = 0.6f,
        zombiePathogenChance = 0.4f,
        madCowChance = 0.2f
    }
},
new LiquidEntry
{
    liquidID = "RadiatorFluid",
    displayName = "Car Radiator Fluid",
    type = LiquidType.Coolant,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = -50f,
    temperatureChange = 5f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 1f,
        parasiteChance = 0.2f,
        madCowChance = 0.3f
    }
},
new LiquidEntry
{
    liquidID = "DogBowlWater",
    displayName = "Dog Bowl Water",
    type = LiquidType.UncleanWater,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 15f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.3f,
        parasiteChance = 0.2f
    }
},
new LiquidEntry
{
    liquidID = "FountainWater",
    displayName = "Fountain Water",
    type = LiquidType.UncleanWater,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = false,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 20f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.2f,
        parasiteChance = 0.3f
    }
},
new LiquidEntry
{
    liquidID = "WaterBucket",
    displayName = "Water Bucket",
    type = LiquidType.UncleanWater,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 30f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.1f,
        parasiteChance = 0.2f
    }
},
new LiquidEntry
{
    liquidID = "FuelPump",
    displayName = "Fuel Pump",
    type = LiquidType.Fuel,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = -100f,
    temperatureChange = 10f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.9f,
        parasiteChance = 0.1f
    }
},
new LiquidEntry
{
    liquidID = "FuelBarrel",
    displayName = "Fuel Barrel",
    type = LiquidType.Fuel,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = -100f,
    temperatureChange = 8f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.95f,
        parasiteChance = 0.05f
    }
},
new LiquidEntry
{
    liquidID = "CoolantBarrel",
    displayName = "Coolant Barrel",
    type = LiquidType.Coolant,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = -50f,
    temperatureChange = -10f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.8f,
        parasiteChance = 0.2f
    }
},
new LiquidEntry
{
    liquidID = "CoolantPump",
    displayName = "Coolant Pump",
    type = LiquidType.Coolant,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = -50f,
    temperatureChange = -12f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.85f,
        parasiteChance = 0.15f
    }
}, new LiquidEntry
{
    liquidID = "CarFuelTank",
    displayName = "Car Fuel Tank",
    type = LiquidType.Fuel,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = -100f,
    temperatureChange = 9f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.95f,
        parasiteChance = 0.05f
    }
},
new LiquidEntry
{
    liquidID = "MotorbikeFuelTank",
    displayName = "Motorbike Fuel Tank",
    type = LiquidType.Fuel,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = -100f,
    temperatureChange = 7f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.9f,
        parasiteChance = 0.1f
    }
},
new LiquidEntry
{
    liquidID = "OilBarrel",
    displayName = "Oil Barrel",
    type = LiquidType.Oil,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = -100f,
    temperatureChange = 12f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.95f,
        parasiteChance = 0.05f
    }
},
new LiquidEntry
{
    liquidID = "WineBarrel",
    displayName = "Wine Barrel",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.EnvironmentalSource,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 10f,
    temperatureChange = 2f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.1f,
        parasiteChance = 0.05f
    }
},
new LiquidEntry
{
    liquidID = "WaterBottle_S",
    displayName = "Water Bottle (500ml)",
    type = LiquidType.CleanWater,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 25f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "WaterBottle_M",
    displayName = "Water Bottle (2000ml)",
    type = LiquidType.CleanWater,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 100f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "WaterBottle_L",
    displayName = "Water Bottle (5000ml)",
    type = LiquidType.CleanWater,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 250f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "Canteen_1000ml",
    displayName = "Canteen (1000ml)",
    type = LiquidType.CleanWater,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 50f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.01f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "HotwaterFlask_750ml",
    displayName = "Hotwater Flask (750ml)",
    type = LiquidType.CleanWater,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 40f,
    temperatureChange = 5f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "SodaCan_Poke",
    displayName = "Poke (330ml)",
    type = LiquidType.FizzyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 15f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.01f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "SodaCan_Sipsi",
    displayName = "Sipsi (330ml)",
    type = LiquidType.FizzyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 15f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.01f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "SodaCan_SurgeonPep",
    displayName = "Surgeon Pep (330ml)",
    type = LiquidType.FizzyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 15f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.01f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "SodaCan_Right",
    displayName = "Right (330ml)",
    type = LiquidType.FizzyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 15f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.01f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "SodaCan_SevenDown",
    displayName = "7 Down (330ml)",
    type = LiquidType.FizzyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 14f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.01f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "SodaCan_ZeroCola",
    displayName = "Zero Cola (330ml)",
    type = LiquidType.FizzyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 12f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.005f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "SodaCan_MountainMist",
    displayName = "Mountain Mist (330ml)",
    type = LiquidType.FizzyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 16f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.01f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "SodaCan_SteelBrew",
    displayName = "Steel Brew (330ml)",
    type = LiquidType.FizzyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 13f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.02f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "SodaCan_Banta",
    displayName = "Banta (330ml)",
    type = LiquidType.FizzyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 14f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.015f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "SodaCan_DietAll",
    displayName = "Diet All (330ml)",
    type = LiquidType.FizzyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 11f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.005f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "SodaCan_MaxZero",
    displayName = "Max Zero (330ml)",
    type = LiquidType.FizzyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 10f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.005f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "EnergyCan_Gremlin",
    displayName = "Gremlin (500ml)",
    type = LiquidType.EnergyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 8f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.02f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "EnergyCan_GremlinZero",
    displayName = "Gremlin Zero (500ml)",
    type = LiquidType.EnergyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 7f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.015f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "EnergyCan_GremlinLangoMoco",
    displayName = "Gremlin Lango Moco (500ml)",
    type = LiquidType.EnergyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 9f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.025f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "ProteinCan_BedRull",
    displayName = "Bed Rull (500ml)",
    type = LiquidType.ProteinDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 10f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.03f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "ProteinCan_BedRullZero",
    displayName = "Bed Rull Zero (500ml)",
    type = LiquidType.ProteinDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 9f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.025f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "EnergyCan_GremlinNightshift",
    displayName = "Gremlin Nightshift (500ml)",
    type = LiquidType.EnergyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 7f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.03f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "EnergyCan_GremlinXP",
    displayName = "Gremlin XP (500ml)",
    type = LiquidType.EnergyDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 8f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.035f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "ProteinCan_BedRullBulkPlus",
    displayName = "Bed Rull Bulk+ (500ml)",
    type = LiquidType.ProteinDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 11f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.04f,
        parasiteChance = 0.02f
    }
},new LiquidEntry
{
    liquidID = "ProteinCan_ChocoBulk",
    displayName = "Bed Rull Choco Bulk (500ml)",
    type = LiquidType.ProteinDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 12f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.03f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "ProteinCan_StrawbBulk",
    displayName = "Bed Rull Strawb Bulk (500ml)",
    type = LiquidType.ProteinDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 12f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.03f,
        parasiteChance = 0.015f
    }
},
new LiquidEntry
{
    liquidID = "ProteinCan_BananaBulk",
    displayName = "Bed Rull Banana Bulk (500ml)",
    type = LiquidType.ProteinDrink,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 12f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.035f,
        parasiteChance = 0.02f
    }
},
new LiquidEntry
{
    liquidID = "Carton_SpoiledMilk",
    displayName = "Spoiled Milk Carton (1000ml)",
    type = LiquidType.Milk,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 18f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.45f,
        parasiteChance = 0.05f
    }
},
new LiquidEntry
{
    liquidID = "Carton_AppleJuice",
    displayName = "Apple Juice Carton (1000ml)",
    type = LiquidType.Juice,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 25f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.02f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "Carton_CranberryJuice",
    displayName = "Cranberry Juice Carton (1000ml)",
    type = LiquidType.Juice,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 24f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.025f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "Carton_OrangeJuice",
    displayName = "Orange Juice Carton (1000ml)",
    type = LiquidType.Juice,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 26f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.02f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "Carton_PineappleJuice",
    displayName = "Pineapple Juice Carton (1000ml)",
    type = LiquidType.Juice,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 24f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.025f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "Carton_CarrotJuice",
    displayName = "Carrot Juice Carton (1000ml)",
    type = LiquidType.Juice,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 23f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.03f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_SummerFruitWater1500",
    displayName = "Summer Fruit Water (1500ml)",
    type = LiquidType.FlavoredWater,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 40f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.005f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_StrawberryWater1500",
    displayName = "Strawberry Water (1500ml)",
    type = LiquidType.FlavoredWater,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 40f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.005f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_LemonLimeWater1500",
    displayName = "Lemon & Lime Water (1500ml)",
    type = LiquidType.FlavoredWater,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 40f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.005f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_BlackberryWater1500",
    displayName = "Blackberry Water (1500ml)",
    type = LiquidType.FlavoredWater,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = 40f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.005f,
        parasiteChance = 0f
    }
},
new LiquidEntry
{
    liquidID = "Can_DubLite440",
    displayName = "Dub Lite (440ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = 4f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.015f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Can_Dub440",
    displayName = "Dub (440ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = 3f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.02f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Can_FellaArtWar440",
    displayName = "Fella Art War (440ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = 2f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.04f,
        parasiteChance = 0.015f
    }
},
new LiquidEntry
{
    liquidID = "Can_AppleCider440",
    displayName = "Apple Cider (440ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = 5f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.02f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Can_BerryCider440",
    displayName = "Berry Cider (440ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = 5f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.02f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Can_Fecks440",
    displayName = "Fecks (440ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = 3f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.025f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Can_NotANuker440",
    displayName = "Not a Nuker (440ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = 2f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.035f,
        parasiteChance = 0.015f
    }
},
new LiquidEntry
{
    liquidID = "Can_Festers440",
    displayName = "Festers (440ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = 2f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.04f,
        parasiteChance = 0.02f
    }
},
new LiquidEntry
{
    liquidID = "Can_Flurona440",
    displayName = "Flurona (440ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = 3f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.03f,
        parasiteChance = 0.015f
    }
},
new LiquidEntry
{
    liquidID = "Can_KarlIngz440",
    displayName = "Karl Ingz (440ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = 3f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.025f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Can_KarlZbergz440",
    displayName = "Karl Zbergz (440ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = 3f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.03f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Can_Steinholmez440",
    displayName = "Steinholmez (440ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = 4f,
    temperatureChange = -1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.02f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_SmirkonVodka700",
    displayName = "Smirkon Vodka (700ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = true,

    hydrationValue = 1f,
    temperatureChange = -2f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.04f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_JanielDacksWhiskey700",
    displayName = "JanielDacks Whiskey (700ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = true,

    hydrationValue = 1f,
    temperatureChange = -2f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.035f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_LebbsWhiskey700",
    displayName = "Lebbs Whiskey (700ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = true,

    hydrationValue = 1f,
    temperatureChange = -2f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.04f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_ReiersaTequila700",
    displayName = "Reiersa Tequila (700ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = true,

    hydrationValue = 1f,
    temperatureChange = -2f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.045f,
        parasiteChance = 0.015f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_DorgonsGin700",
    displayName = "Dorgons Gin (700ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = true,

    hydrationValue = 1f,
    temperatureChange = -2f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.04f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_LiquidFertilizer1000",
    displayName = "Liquid Fertilizer (1000ml)",
    type = LiquidType.FertilizerLiquid, // or LiquidType.Fertilizer if subclassed
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 0f,
    temperatureChange = 0f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.9f,
        parasiteChance = 0.2f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_TomatoFeed1000",
    displayName = "Tomato Feed (1000ml)",
    type = LiquidType.FertilizerLiquid, // or LiquidType.Fertilizer
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = 0f,
    temperatureChange = 0f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.85f,
        parasiteChance = 0.15f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_Bleach1000",
    displayName = "Bleach (1000ml)",
    type = LiquidType.Chemical,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = -5f,
    temperatureChange = 0f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 1f,
        parasiteChance = 0.3f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_AlcoholPure350",
    displayName = "Alcohol (Pure, 350ml)",
    type = LiquidType.Alcohol,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = true,
    usedForCleaning = true,
    usedAsFuel = true,

    hydrationValue = -2f,
    temperatureChange = -3f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.2f,
        parasiteChance = 0.05f
    }
},
new LiquidEntry
{
    liquidID = "Spray_Bleach400",
    displayName = "Bleach (Spray Bottle, 400ml)",
    type = LiquidType.Chemical,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = true,
    usedAsFuel = false,

    hydrationValue = -3f,
    temperatureChange = 0f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 1f,
        parasiteChance = 0.25f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_CookingOil1000",
    displayName = "Cooking Oil (1000ml)",
    type = LiquidType.FoodOil,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = -1f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.02f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_VegetableOil1000",
    displayName = "Vegetable Oil (1000ml)",
    type = LiquidType.FoodOil,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = -1f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.015f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_SunflowerOil1000",
    displayName = "Sunflower Oil (1000ml)",
    type = LiquidType.FoodOil,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = -1f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.015f,
        parasiteChance = 0.01f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_EngineOilL5000",
    displayName = "Engine Oil L (5000ml)",
    type = LiquidType.Chemical, // or LiquidType.EngineFluid
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = -10f,
    temperatureChange = 0f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 1f,
        parasiteChance = 0.4f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_EngineOil1500",
    displayName = "Engine Oil (1500ml)",
    type = LiquidType.Chemical,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = -5f,
    temperatureChange = 0f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 1f,
        parasiteChance = 0.3f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_Coolant2500",
    displayName = "Coolant (2500ml)",
    type = LiquidType.Chemical,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = false,
    usedInCooking = false,
    usedForCleaning = false,
    usedAsFuel = false,

    hydrationValue = -8f,
    temperatureChange = -5f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 1f,
        parasiteChance = 0.35f
    }
},
new LiquidEntry
{
    liquidID = "Bottle_OliveOil500",
    displayName = "Olive Oil (500ml)",
    type = LiquidType.FoodOil,
    originType = LiquidOriginType.InventoryItem,

    isCollectible = true,
    canBeBoiled = true,
    usedInCooking = true,
    usedForCleaning = false,
    usedAsFuel = true,

    hydrationValue = -1f,
    temperatureChange = 1f,

    diseaseProfile = new FoodDiseaseProfile
    {
        foodPoisoningChance = 0.01f,
        parasiteChance = 0.005f
    }
}


    };
}

// 🌍 Liquid Origin Type
public enum LiquidOriginType
{
    InventoryItem,
    EnvironmentalSource,
    NPCStash,
    Unknown
}
