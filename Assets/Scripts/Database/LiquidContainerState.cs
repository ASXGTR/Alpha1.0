using UnityEngine;

[System.Serializable]
public class LiquidContainerState
{
    public string containerID;
    public string displayName;

    public float maxVolume;
    public float currentVolume;

    public bool isReusable;
    public bool isFillable;

    public LiquidType liquidType = LiquidType.None;
    public LiquidOriginType originType = LiquidOriginType.Unknown;

    public bool isBoiled;
    public bool isCooledAfterBoil;

    public FoodDiseaseProfile diseaseProfile = new();
    public string hydrationLoreTag;

    public bool IsEmpty => currentVolume <= 0f;
    public bool IsFull => currentVolume >= maxVolume;
    public bool IsPurified => isBoiled && isCooledAfterBoil;

    public float GetEffectiveHydration() => currentVolume * (IsPurified ? 1f : 0.7f);
}
