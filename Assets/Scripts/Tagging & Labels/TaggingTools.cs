using UnityEditor;
using UnityEngine;

public class TaggingTools : EditorWindow
{
    [MenuItem("Tools/Tagging/Run All Taggers")]
    public static void RunTaggers() => TaggingManager.RunAllTaggers();

    [MenuItem("Tools/Tagging/Save Tagged Database")]
    public static void SaveTags() => TaggingManager.SaveTaggedDatabase();

    [MenuItem("Tools/Tagging/Reset to Default")]
    public static void ResetTags() => TaggingManager.ResetToDefault();
}
