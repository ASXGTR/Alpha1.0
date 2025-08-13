using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

public static class TaggingManager
{
    private const string DatabasePath = "Databases/LiquidSourceDatabase";

    public static void RunAllTaggers()
    {
        var sourceDB = Resources.Load<LiquidSourceDatabase>(DatabasePath);
        if (sourceDB == null)
        {
            Debug.LogWarning("LiquidSourceDatabase not found.");
            return;
        }

        LiquidContainerTagger.TagReusableContainers(sourceDB.liquidSources);
        Debug.Log("Tagging complete.");
    }

    public static void SaveTaggedDatabase()
    {
#if UNITY_EDITOR
        var sourceDB = Resources.Load<LiquidSourceDatabase>(DatabasePath);
        if (sourceDB == null)
        {
            Debug.LogWarning("LiquidSourceDatabase not found.");
            return;
        }

        EditorUtility.SetDirty(sourceDB);
        AssetDatabase.SaveAssets();
        Debug.Log("Tagged database saved.");
#endif
    }

    public static void ResetToDefault()
    {
        var sourceDB = Resources.Load<LiquidSourceDatabase>(DatabasePath);
        if (sourceDB == null)
        {
            Debug.LogWarning("LiquidSourceDatabase not found.");
            return;
        }

        foreach (var item in sourceDB.liquidSources)
        {
            item.tags = new List<string>();
        }

        Debug.Log("Database reset to default (no tags).");
    }
}
