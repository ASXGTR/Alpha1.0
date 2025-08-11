using System.IO;
using UnityEngine;

namespace DevTools
{
    public class LicenseDisplay : MonoBehaviour
    {
        void Start()
        {
            string projectRoot = Directory.GetParent(Application.dataPath).FullName;
            string licensePath = Path.Combine(projectRoot, "LICENSE");

            if (File.Exists(licensePath))
            {
                string licenseText = File.ReadAllText(licensePath);
                Debug.Log($"[LicenseDisplay] License Loaded:\n{licenseText.Substring(0, Mathf.Min(500, licenseText.Length))}...");
            }
            else
            {
                Debug.LogWarning("[LicenseDisplay] LICENSE file not found.");
            }
        }
    }
}
