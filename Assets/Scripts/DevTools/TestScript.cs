using UnityEngine;

public class TestScript
{
    // This script exists solely to trigger Unity's compiler.
    // It does not interact with any GameObject or runtime system.

    private static readonly string _compilePing = "Alpha1.0_CompileNudge";

    public static void Ping()
    {
        // No-op method to ensure Unity sees a change
        string ignored = _compilePing + "_Pinged";
    }
}
