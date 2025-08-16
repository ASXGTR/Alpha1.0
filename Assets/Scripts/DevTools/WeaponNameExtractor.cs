#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public static class WeaponNameExtractor
{
    // Toggle these to true/false depending on what you want to extract
    private static bool includeRangedWeapons = true;
    private static bool includeMeleeWeapons = true;

    [MenuItem("DevTools/Extract Weapon Names")]
    public static void ExtractWeaponNames()
    {
        string rangedPath = Path.Combine(Application.dataPath, "Scripts/Database/RangedWeaponItemDatabase.cs");
        string meleePath = Path.Combine(Application.dataPath, "Scripts/Database/MeleeWeaponItemDatabase.cs");

        Regex rangedRegex = new Regex(@"\bweaponName\s*=\s*""([^""]+)""", RegexOptions.Compiled);
        Regex meleeRegex = new Regex(@"\bitemName\s*=\s*""([^""]+)""", RegexOptions.Compiled);

        HashSet<string> rangedWeaponNames = new HashSet<string>();
        HashSet<string> meleeWeaponNames = new HashSet<string>();

        if (includeRangedWeapons && File.Exists(rangedPath))
        {
            string rangedContent = File.ReadAllText(rangedPath);
            foreach (Match match in rangedRegex.Matches(rangedContent))
                rangedWeaponNames.Add(match.Groups[1].Value);
        }

        if (includeMeleeWeapons && File.Exists(meleePath))
        {
            string meleeContent = File.ReadAllText(meleePath);
            foreach (Match match in meleeRegex.Matches(meleeContent))
                meleeWeaponNames.Add(match.Groups[1].Value);
        }

        if (includeRangedWeapons)
        {
            Debug.Log("---- Ranged Weapons ----");
            foreach (var name in rangedWeaponNames)
                Debug.Log(name);
            Debug.Log($"Total ranged weapons: {rangedWeaponNames.Count}\n");
        }

        if (includeMeleeWeapons)
        {
            Debug.Log("---- Melee Weapons ----");
            foreach (var name in meleeWeaponNames)
                Debug.Log(name);
            Debug.Log($"Total melee weapons: {meleeWeaponNames.Count}\n");
        }

        Debug.Log("Weapon name extraction complete.");
    }
}
#endif
