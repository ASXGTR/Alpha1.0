using System.Collections.Generic;
using UnityEngine;

public class FarmingManager : MonoBehaviour
{
    [Header("Seed Registry")]
    public SeedItemDatabase seedDatabase;

    [Header("Planting Settings")]
    public Transform plantingArea; // Where crops spawn
    public GameObject fertilizerPrefab; // Optional visual feedback
    public GameObject wateringEffectPrefab;

    private Dictionary<string, PlantedCrop> activeCrops = new();

    [System.Serializable]
    public class PlantedCrop
    {
        public string seedID;
        public GameObject cropInstance;
        public float plantedTime;
        public bool isWatered;
        public bool isFertilized;
    }

    public bool TryPlantSeed(string seedID)
    {
        var seedEntry = seedDatabase.seedItems.Find(s => s.itemID == seedID);
        if (seedEntry == null)
        {
            Debug.LogWarning($"Seed '{seedID}' not found in SeedItemDatabase.");
            return false;
        }

        // Check fertilizer and watering requirements
        if (seedEntry.requiresFertilizer && !HasFertilizer())
        {
            Debug.Log("Fertilizer required before planting.");
            return false;
        }

        if (seedEntry.requiresWatering && !HasWatering())
        {
            Debug.Log("Watering required before planting.");
            return false;
        }

        // Spawn crop prefab
        GameObject crop = Instantiate(seedEntry.cropPrefab, plantingArea.position, Quaternion.identity);
        activeCrops[seedID] = new PlantedCrop
        {
            seedID = seedID,
            cropInstance = crop,
            plantedTime = Time.time,
            isWatered = true,
            isFertilized = true
        };

        Debug.Log($"Planted '{seedEntry.displayName}' successfully.");
        return true;
    }

    private bool HasFertilizer()
    {
        // TODO: Replace with actual inventory or soil check
        return true;
    }

    private bool HasWatering()
    {
        // TODO: Replace with actual watering system
        return true;
    }

    private void Update()
    {
        foreach (var crop in activeCrops.Values)
        {
            var seedEntry = seedDatabase.seedItems.Find(s => s.itemID == crop.seedID);
            if (seedEntry == null || crop.cropInstance == null) continue;

            float elapsedDays = (Time.time - crop.plantedTime) / 86400f; // Convert seconds to days
            if (elapsedDays >= seedEntry.growthTimeDays)
            {
                HarvestCrop(crop);
            }
        }
    }

    private void HarvestCrop(PlantedCrop crop)
    {
        Debug.Log($"Harvested crop from seed '{crop.seedID}' with yield.");
        Destroy(crop.cropInstance);
        activeCrops.Remove(crop.seedID);
        // TODO: Add yield to inventory
    }
}
