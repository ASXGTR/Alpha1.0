using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public static class LiquidContainerTagger
{
    // Keywords that imply reusable container status
    private static readonly string[] AutoTagKeywords =
        { "Bottle", "Canteen", "Flask", "Canister" };

    /// <summary>
    /// Auto-tags LiquidEntry items as reusable containers based on displayName keywords.
    /// Skips entries that are already manually tagged.
    /// </summary>
    public static void TagReusableContainers(List<LiquidEntry> entries)
    {
        if (entries == null || entries.Count == 0)
        {
            Debug.LogWarning("[LiquidContainerTagger] No entries provided for tagging.");
            return;
        }

        foreach (var entry in entries)
        {
            if (entry == null || string.IsNullOrEmpty(entry.displayName))
                continue;

            // Skip if manually tagged
            if (entry.isReusableContainer)
                continue;

            // Check for keyword match
            bool matchesKeyword = AutoTagKeywords.Any(keyword =>
                entry.displayName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0);

            if (matchesKeyword)
            {
                entry.isReusableContainer = true;
                entry.isFillable = true;

                if (string.IsNullOrEmpty(entry.hydrationLoreTag))
                {
                    entry.hydrationLoreTag = "Auto-tagged as reusable container. Refillable.";
                }

                Debug.Log($"[LiquidContainerTagger] Tagged '{entry.displayName}' as reusable container.");
            }
        }
    }
}
