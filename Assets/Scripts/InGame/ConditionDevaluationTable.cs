using System.Collections.Generic;

public static class ConditionDevaluationTable
{
    public static readonly Dictionary<string, float> ToolConditionLoss = new()
    {
        { "CanOpener", 0f },
        { "SharpKnife", 0.15f },
        { "ClawHammer", 0.5f },
        { "Sledgehammer", 0.8f },
        { "Crowbar", 0.65f },
        { "Teeth", 1f }
    };

    public static float GetLossForTool(string toolName)
    {
        return ToolConditionLoss.TryGetValue(toolName, out var loss) ? loss : 0.5f;
    }
}
