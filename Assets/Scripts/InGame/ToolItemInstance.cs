using System.Collections.Generic;
using UnityEngine;

public class ToolItemInstance
{
    public ToolItemData sourceData;

    // Runtime condition tracking
    public int currentCondition;
    public bool isBroken => currentCondition <= 0;

    // Constructor
    public ToolItemInstance(ToolItemData data)
    {
        sourceData = data;
        currentCondition = data.condition;
    }

    // 🔧 Can this tool be repaired?
    public bool CanBeRepaired()
    {
        return sourceData.canBeRepaired &&
               sourceData.repairOptions != null &&
               sourceData.repairOptions.Count > 0;
    }

    // 🛠️ Can this tool repair other items?
    public bool CanRepairOtherItems()
    {
        return HasFunction(ToolFunction.Repair);
    }

    // 🧠 Does this tool require screws to repair other items?
    public bool RequiresScrewsForRepair(List<string> targetItemTags)
    {
        return CanRepairOtherItems() && targetItemTags.Contains("RequiresScrews");
    }

    // 🚗 Can this tool be used for vehicle ignition tampering?
    public bool CanIgniteVehicle()
    {
        return sourceData.supportsVehicleUse &&
               HasFunction(ToolFunction.Vehicle_SparkPlugAccess);
    }

    // 🧪 Function checker
    public bool HasFunction(ToolFunction function)
    {
        return sourceData.functions != null &&
               sourceData.functions.Contains(function);
    }

    // 🧱 Get combat stats
    public float GetDamage() => sourceData.baseDamage;
    public float GetArmorPierce() => sourceData.armorPierce;
    public float GetCritChance() => sourceData.critChance;

    // 🧠 Lore Access
    public string GetSurvivorNotes() => sourceData.survivorNotes;
    public string GetBrand() => sourceData.brand;

    // 🧰 Crafting Access
    public List<string> GetCraftingRecipe() => sourceData.craftingRecipe;
    public List<string> GetItemTags() => sourceData.itemTags;

    // 🧪 Apply wear and tear
    public void ApplyWear(int amount)
    {
        currentCondition -= amount;
        if (currentCondition < 0) currentCondition = 0;
    }

    // 🛠️ Attempt to repair this tool
    public bool TryRepair(RepairMethod method)
    {
        if (!CanBeRepaired()) return false;
        if (!sourceData.repairOptions.Contains(method)) return false;

        currentCondition = Mathf.Clamp(currentCondition + GetRepairAmount(method), 0, 100);
        return true;
    }

    // 🔧 Repair amount logic
    private int GetRepairAmount(RepairMethod method)
    {
        switch (method)
        {
            case RepairMethod.ToolRepairKit: return 25;
            case RepairMethod.Ducktape: return 15;
            case RepairMethod.Glue: return 10;
            case RepairMethod.CableTies: return 5;
            case RepairMethod.Welding: return 30;
            default: return 0;
        }
    }

    // 🧙 Optional: Trigger ritual effect
    public bool TriggerRitual()
    {
        if (!HasFunction(ToolFunction.RitualUse)) return false;

        Debug.Log($"Ritual triggered using {sourceData.itemName}. Survivor notes: {sourceData.survivorNotes}");
        return true;
    }
}
