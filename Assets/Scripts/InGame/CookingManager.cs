using System;
using UnityEngine;

public class CookingManager : MonoBehaviour
{
    public CookingContainerState container;

    void Start()
    {
        // Placeholder setup
        container = new CookingContainerState();
        container.maxLiquidVolumeML = 1000f;
    }

    public void TryStartCooking()
    {
        if (container == null)
        {
            Debug.LogWarning("No container assigned.");
            return;
        }

        if (container.IsCookingHazard())
        {
            TriggerFireHazard();
            return;
        }

        CookingMethod method = container.GetAvailableCookingMethod();

        if (method == CookingMethod.None)
        {
            Debug.Log("No valid cooking method available.");
            return;
        }

        Debug.Log($"Cooking started using method: {method}");
        // TODO: Implement actual cooking logic here
    }

    private void TriggerFireHazard()
    {
        Debug.LogWarning("🔥 Fire hazard triggered! Container ignited.");
        // TODO: Apply burn damage to player
        // TODO: Trigger fire animation or container destruction
        // TODO: Log dev diary entry
    }

    public void AddLiquid(CookingLiquid liquidType, float volumeML)
    {
        bool success = container.TryAddCookingLiquid(liquidType, volumeML);
        if (!success)
        {
            Debug.LogWarning($"Cannot mix {liquidType} with existing liquid: {container.cookingLiquidType}");
        }
        else
        {
            Debug.Log($"{volumeML}ml of {liquidType} added to container.");
        }
    }

    public void InsertSteamRack()
    {
        container.hasSteamRack = true;
        Debug.Log("Steam rack inserted.");
    }

    public void RemoveSteamRack()
    {
        container.hasSteamRack = false;
        Debug.Log("Steam rack removed.");
    }
}
