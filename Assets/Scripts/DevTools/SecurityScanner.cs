using System;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;

namespace DevTools
{
    public class SecurityScanner : MonoBehaviour
    {
        private string[] riskyExtensions = { ".exe", ".dll", ".pdb", ".DS_Store", ".log" };
        private string[] sensitivePatterns = {
            @"AIza[0-9A-Za-z-_]{35}",           // Google API Key
            @"sk_live_[0-9a-zA-Z]{24}",         // Stripe Live Key
            @"ghp_[0-9a-zA-Z]{36}",             // GitHub Personal Token
            @"[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+", // Email
            @"\b\d{1,3}(\.\d{1,3}){3}\b"        // IP Address
        };

        void Start()
        {
            string projectRoot = Directory.GetParent(Application.dataPath).FullName;

            CheckFileExists(projectRoot, ".gitignore");
            CheckFileExists(projectRoot, ".gitattributes");
            CheckFileExists(projectRoot, "LICENSE");

            ScanForRiskyFiles(projectRoot);
            ScanForSensitiveData(projectRoot);
        }

        void CheckFileExists(string root, string filename)
        {
            string path = Path.Combine(root, filename);
            if (!File.Exists(path))
                Debug.LogWarning($"[SecurityScanner] Missing: {filename}");
        }

        void ScanForRiskyFiles(string root)
        {
            foreach (string file in Directory.GetFiles(root, "*.*", SearchOption.AllDirectories))
            {
                foreach (string ext in riskyExtensions)
                {
                    if (file.EndsWith(ext))
                        Debug.LogWarning($"[SecurityScanner] Risky file detected: {file}");
                }
            }
        }

        void ScanForSensitiveData(string root)
        {
            foreach (string file in Directory.GetFiles(root, "*.*", SearchOption.AllDirectories))
            {
                if (file.EndsWith(".cs") || file.EndsWith(".txt") || file.EndsWith(".json"))
                {
                    string content = File.ReadAllText(file);
                    foreach (string pattern in sensitivePatterns)
                    {
                        MatchCollection matches = Regex.Matches(content, pattern);
                        foreach (Match match in matches)
                        {
                            Debug.LogWarning($"[SecurityScanner] Possible sensitive data in {file}: {match.Value}");
                        }
                    }
                }
            }
        }
    }
}
