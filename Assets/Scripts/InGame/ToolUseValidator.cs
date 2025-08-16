using System.Collections.Generic;

public static class ToolUsageValidator
{
    // ✅ Define which tools are valid for opening sealed items
    private static readonly HashSet<string> ValidOpeningTools = new()
    {
        "CanOpener",
        "SharpKnife",
        "ClawHammer",
        "Crowbar",
        "Sledgehammer"
    };

    // ✅ Optional: Tools that increase disease risk
    private static readonly HashSet<string> UnsanitaryTools = new()
    {
        "Crowbar",
        "Sledgehammer",
        "Teeth"
    };

    public static bool IsToolValidForOpening(string toolName)
    {
        return ValidOpeningTools.Contains(toolName);
    }

    public static bool IsToolUnsanitary(string toolName)
    {
        return UnsanitaryTools.Contains(toolName);
    }

    public static void ApplyToolEffects(ItemData item, string toolUsed)
    {
        if (!IsToolValidForOpening(toolUsed))
        {
            // Block action or log warning
#if UNITY_EDITOR
            UnityEngine.Debug.LogWarning($"Tool '{toolUsed}' is not valid for opening sealed items.");
#endif
            return;
        }

        // Apply condition loss
        item.ApplyOpeningDamage(toolUsed);

        // Optional: Apply disease risk if tool is unsanitary
        if (IsToolUnsanitary(toolUsed))
        {
            item.diseaseProfile.foodPoisoningChance += 5f;
#if UNITY_EDITOR
            UnityEngine.Debug.Log($"Unsanitary tool '{toolUsed}' used. Increased food poisoning risk.");
#endif
        }
    }
}
