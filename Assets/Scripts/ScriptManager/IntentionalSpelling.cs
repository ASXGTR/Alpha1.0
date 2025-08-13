using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace ScriptManager
{
    [System.Serializable]
    public class SpellingEntry
    {
        public string term;
        public string reason;
        public string contextTag;
        public bool isEasterEgg;
    }

    [CreateAssetMenu(fileName = "IntentionalSpellings", menuName = "ScriptManager/IntentionalSpellings")]
    public class IntentionalSpellings : ScriptableObject
    {
        public List<SpellingEntry> intentionalWords = new List<SpellingEntry>();

        public void LoadFromJson(TextAsset jsonFile)
        {
            intentionalWords = JsonUtility.FromJson<Wrapper>(jsonFile.text).entries;
        }

        [System.Serializable]
        private class Wrapper
        {
            public List<SpellingEntry> entries;
        }

        public bool IsIntentional(string term)
        {
            return intentionalWords.Exists(entry => entry.term == term);
        }

        public SpellingEntry GetEntry(string term)
        {
            return intentionalWords.Find(entry => entry.term == term);
        }
    }
}
