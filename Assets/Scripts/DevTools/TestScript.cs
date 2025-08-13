using UnityEngine;

public class TestScript
{
    // This script exists solely to trigger Unity's compiler.
    // It does not interact with any GameObject or runtime system.

    private static readonly string _compilePing = "Alpha1.0_CompileNudge";

    public static void Ping()
    {
        // Intentional no-op to ensure Unity sees a change
        _ = _compilePing + "_Pinged";
    }
}
