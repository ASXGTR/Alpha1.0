using System.Collections.Generic;
using UnityEngine;

public class LiquidContainerManager
{
    private readonly Dictionary<string, LiquidContainerState> containerStates = new();
    private readonly Dictionary<string, LiquidEntry> liquidSources;

    public LiquidContainerManager(List<LiquidEntry> sourceEntries, List<ItemData> itemEntries)
    {
        liquidSources = new();
        foreach (var entry in sourceEntries)
            liquidSources[entry.liquidID] = entry;

        foreach (var item in itemEntries)
        {
            if (item.liquidType != LiquidType.None)
            {
                containerStates[item.itemID] = new LiquidContainerState
                {
                    containerID = item.itemID,
                    displayName = item.displayName,
                    maxVolume = item.hydrationChange,
                    currentVolume = item.hydrationChange,
                    isReusable = !item.isStackable,
                    isFillable = item.canBeBoiledForPurification || item.usedForCleaning,
                    liquidType = item.liquidType,
                    isBoiled = item.isBoiled,
                    isCooledAfterBoil = item.isCooledAfterBoil,
                    diseaseProfile = item.diseaseProfile,
                    hydrationLoreTag = item.hydrationLoreTag
                };
            }
        }
    }

    public bool TryFillContainer(string containerID, string sourceID)
    {
        if (!containerStates.ContainsKey(containerID) || !liquidSources.ContainsKey(sourceID))
            return false;

        var container = containerStates[containerID];
        var source = liquidSources[sourceID];

        if (!source.isCollectible || !container.isFillable || container.IsFull)
            return false;

        container.liquidType = source.type;
        container.originType = source.originType;
        container.currentVolume = Mathf.Min(container.maxVolume, source.hydrationValue);
        container.isBoiled = false;
        container.isCooledAfterBoil = false;
        container.diseaseProfile = source.diseaseProfile;
        container.hydrationLoreTag = $"Filled from {source.displayName}";

        return true;
    }

    public bool TryBoilContainer(string containerID)
    {
        if (!containerStates.ContainsKey(containerID))
            return false;

        var container = containerStates[containerID];
        if (!container.isFillable || container.IsEmpty)
            return false;

        container.isBoiled = true;
        container.isCooledAfterBoil = true;
        container.hydrationLoreTag += " → Boiled";

        return true;
    }

    public LiquidContainerState GetContainerState(string containerID)
    {
        return containerStates.ContainsKey(containerID) ? containerStates[containerID] : null;
    }

    public string GetHydrationNarrative(string containerID)
    {
        var state = GetContainerState(containerID);
        if (state == null) return "Unknown container.";

        if (state.IsEmpty) return $"{state.displayName} is dry. Like your optimism.";
        if (!state.IsPurified) return $"{state.displayName} holds {state.liquidType}—unboiled, unrepentant.";
        return $"{state.displayName} contains purified {state.liquidType}. Hope in a bottle.";
    }
}
