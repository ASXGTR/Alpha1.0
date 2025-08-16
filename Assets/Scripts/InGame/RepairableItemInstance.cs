using System.Collections.Generic;
using UnityEngine;

public class RepairableItemInstance
{
    public string itemName;
    public int currentCondition;
    public int maxCondition;
    public List<string> itemTags;

    public bool isBroken => currentCondition <= 0;
    public bool requiresScrews => itemTags.Contains("RequiresScrews");

    public RepairableItemInstance(string name, int condition, int max, List<string> tags)
    {
        itemName = name;
        currentCondition = condition;
        maxCondition = max;
        itemTags = tags;
    }

    // ?? Can this item be repaired by the given tool?
    public bool CanBeRepairedBy(ToolItemInstance tool)
    {
        if (!tool.CanRepairOtherItems()) return false;
        if (requiresScrews && !tool.RequiresScrewsForRepair(itemTags)) return false;

        return true;
    }

    // ??? Attempt to repair this item
    public bool TryRepair(ToolItemInstance tool, RepairMethod method)
    {
        if (!CanBeRepairedBy(tool)) return false;
        if (!tool.sourceData.repairOptions.Contains(method)) return false;

        currentCondition = Mathf.Clamp(currentCondition + GetRepairAmount(method), 0, maxCondition);
        return true;
    }

    // ?? Repair amount logic
    private int GetRepairAmount(RepairMethod method)
    {
        switch (method)
        {
            case RepairMethod.ToolRepairKit: return 20;
            case RepairMethod.Ducktape: return 10;
            case RepairMethod.Glue: return 5;
            case RepairMethod.CableTies: return 3;
            case RepairMethod.Welding: return 25;
            default: return 0;
        }
    }
}
