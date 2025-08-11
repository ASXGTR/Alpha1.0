// Assets/Scripts/DevTools/TagAuditTool.cs
using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class TagAuditTool : EditorWindow
{
    [MenuItem("DevTools/Print All Unique Tags")]
    public static void PrintAllTags()
    {
        HashSet<string> allTags = new();

        // 🧠 From MasterItemDatabaseManager
        foreach (var item in MasterItemDatabaseManager.allItems)
        {
            if (item.tags != null)
            {
                foreach (var tag in item.tags)
                {
                    allTags.Add(tag);
                }
            }
        }

        // 🍏 From FruitItemDatabase
        var fruitDB = LoadDatabaseAsset<FruitItemDatabase>("FruitItemDatabase");
        if (fruitDB != null)
        {
            foreach (var fruit in fruitDB.fruitItems)
            {
                foreach (var tag in fruit.tags)
                {
                    allTags.Add(tag);
                }
            }
        }

        // 🌱 From SeedItemDatabase
        var seedDB = LoadDatabaseAsset<SeedItemDatabase>("SeedItemDatabase");
        if (seedDB != null)
        {
            foreach (var seed in seedDB.seedItems)
            {
                foreach (var tag in seed.tags)
                {
                    allTags.Add(tag);
                }
            }
        }

        // 🥕 From VegetableItemDatabase
        var vegDB = LoadDatabaseAsset<VegetableItemDatabase>("VegetableItemDatabase");
        if (vegDB != null)
        {
            foreach (var veg in vegDB.items)
            {
                foreach (var tag in veg.tags)
                {
                    allTags.Add(tag);
                }
            }
        }

        // 🥫 From TinnedItemDatabase
        var tinDB = LoadDatabaseAsset<TinnedItemDatabase>("TinnedItemDatabase");
        if (tinDB != null)
        {
            foreach (var tin in tinDB.items)
            {
                foreach (var tag in tin.tags)
                {
                    allTags.Add(tag);
                }
            }
        }

        Debug.Log($"🏷️ Unique Tags Used: {allTags.Count}");
        foreach (var tag in allTags.OrderBy(t => t))
        {
            Debug.Log($"• {tag}");
        }
    }

    private static T LoadDatabaseAsset<T>(string assetName) where T : ScriptableObject
    {
        string[] guids = AssetDatabase.FindAssets(assetName + " t:" + typeof(T).Name);
        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            if (Path.GetFileNameWithoutExtension(path) == assetName)
            {
                return AssetDatabase.LoadAssetAtPath<T>(path);
            }
        }
        Debug.LogWarning($"⚠️ Could not find asset named '{assetName}' of type {typeof(T).Name}");
        return null;
    }
}
