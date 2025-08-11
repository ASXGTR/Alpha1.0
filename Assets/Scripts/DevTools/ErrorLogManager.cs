using System;
using System.IO;
using UnityEngine;

namespace DevTools
{
    public class ErrorLogManager : MonoBehaviour
    {
        private static string errorLogPath;
        private static string warningLogPath;

        void Awake()
        {
            string projectRoot = Directory.GetParent(Application.dataPath).FullName;
            string logsFolder = Path.Combine(projectRoot, "Logs");
            Directory.CreateDirectory(logsFolder);

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            errorLogPath = Path.Combine(logsFolder, $"ErrorLog_{timestamp}.txt");
            warningLogPath = Path.Combine(logsFolder, $"WarningLog_{timestamp}.txt");

            Application.logMessageReceived += HandleLog;
        }

        void OnDestroy()
        {
            Application.logMessageReceived -= HandleLog;
        }

        private void HandleLog(string logString, string stackTrace, LogType type)
        {
            string entry = $"[{DateTime.Now:HH:mm:ss}] {type}: {logString}\n{stackTrace}\n";

            switch (type)
            {
                case LogType.Error:
                case LogType.Exception:
                    File.AppendAllText(errorLogPath, entry);
                    break;
                case LogType.Warning:
                    File.AppendAllText(warningLogPath, entry);
                    break;
                default:
                    break; // Ignore LogType.Log unless you want a third stream
            }
        }
    }
}
