// Assets/Scripts/DevTools/FullItemList.cs
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class FullItemList : EditorWindow
{
    private static ItemCategory? filterCategory = null;
    private static bool? filterCooked = null;
    private static string filterTag = "";

    [MenuItem("DevTools/Print Full Item List")]
    public static void PrintFullItemList()
    {
        List<ItemData> all = new();

        // 🧠 From MasterItemDatabaseManager
        all.AddRange(MasterItemDatabaseManager.allItems);

        // 🍏 Fruit
        var fruitDB = LoadDatabaseAsset<FruitItemDatabase>("FruitItemDatabase");
        if (fruitDB != null)
        {
            all.AddRange(fruitDB.fruitItems.Select(f => MasterItemDatabaseManager.ConvertFruitToItemData(f)));
        }

        // 🌱 Seed
        var seedDB = LoadDatabaseAsset<SeedItemDatabase>("SeedItemDatabase");
        if (seedDB != null)
        {
            all.AddRange(seedDB.seedItems);
        }

        // 🥕 Vegetable
        var vegDB = LoadDatabaseAsset<VegetableItemDatabase>("VegetableItemDatabase");
        if (vegDB != null)
        {
            all.AddRange(vegDB.items);
        }

        // 🥫 Tinned
        var tinDB = LoadDatabaseAsset<TinnedItemDatabase>("TinnedItemDatabase");
        if (tinDB != null)
        {
            all.AddRange(tinDB.items);
        }

        // 🧪 Apply filters
        var filtered = all.Where(item =>
            (filterCategory == null || (item.categories != null && item.categories.Contains(filterCategory.Value))) &&
            (filterCooked == null || item.isCooked == filterCooked.Value) &&
            (string.IsNullOrEmpty(filterTag) || (item.tags != null && item.tags.Contains(filterTag)))
        ).ToList();

        Debug.Log($"🧾 Filtered items: {filtered.Count}");
        foreach (var item in filtered)
        {
            Debug.Log(FormatItem(item.itemID, item.displayName, item.tags, item.isCooked));
        }
    }

    [MenuItem("DevTools/Set Item Filter")]
    public static void SetFilterWindow()
    {
        FullItemList window = GetWindow<FullItemList>("Item Filter");
        window.Show();
    }

    private void OnGUI()
    {
        GUILayout.Label("Item Filter", EditorStyles.boldLabel);

        // Category filter
        filterCategory = (ItemCategory?)EditorGUILayout.EnumPopup("Category", filterCategory ?? ItemCategory.Food);

        // Cooked filter
        string[] cookedOptions = { "Any", "Raw", "Cooked" };
        int cookedIndex = filterCooked == null ? 0 : (filterCooked.Value ? 2 : 1);
        cookedIndex = EditorGUILayout.Popup("Cooked Status", cookedIndex, cookedOptions);
        filterCooked = cookedIndex == 0 ? null : (cookedIndex == 2);

        // Tag filter
        filterTag = EditorGUILayout.TextField("Tag Contains", filterTag);

        if (GUILayout.Button("Print Filtered List"))
        {
            PrintFullItemList();
        }

        if (GUILayout.Button("Clear Filters"))
        {
            filterCategory = null;
            filterCooked = null;
            filterTag = "";
        }
    }

    private static string FormatItem(string id, string name, List<string> tags, bool isCooked)
    {
        string tagString = tags != null && tags.Count > 0 ? string.Join(", ", tags) : "none";
        string cookedStatus = isCooked ? "Cooked" : "Raw";
        return $"{name} (ID: {id}) — {cookedStatus} — Tags: [{tagString}]";
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
