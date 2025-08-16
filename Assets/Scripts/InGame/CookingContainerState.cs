public enum CookingLiquid
{
    None,
    Water,
    Oil,
    Fuel
}

public enum CookingMethod
{
    None,
    Boil,
    Steam,
    Fry,
    Roast,
    Grill,
    Smoke
}

public class CookingContainerState
{
    public CookingLiquid cookingLiquidType = CookingLiquid.None;
    public float currentLiquidVolumeML = 0f;
    public float maxLiquidVolumeML = 1000f;

    public bool hasSteamRack = false;

    // Enforce single liquid type
    public bool IsLiquidCompatible(CookingLiquid newLiquid)
    {
        return cookingLiquidType == CookingLiquid.None || cookingLiquidType == newLiquid;
    }

    public bool TryAddCookingLiquid(CookingLiquid newLiquid, float volumeML)
    {
        if (!IsLiquidCompatible(newLiquid)) return false;

        cookingLiquidType = newLiquid;
        currentLiquidVolumeML += volumeML;
        return true;
    }

    // Steam logic: only with water, rack present, and <70% volume
    public bool CanBeSteamed()
    {
        if (cookingLiquidType != CookingLiquid.Water) return false;
        if (!hasSteamRack) return false;

        float liquidRatio = currentLiquidVolumeML / maxLiquidVolumeML;
        return liquidRatio < 0.7f;
    }

    // Fry logic: only with oil and between 15–50% volume
    public bool CanBeFried()
    {
        if (cookingLiquidType != CookingLiquid.Oil) return false;

        float oilRatio = currentLiquidVolumeML / maxLiquidVolumeML;
        return oilRatio >= 0.15f && oilRatio <= 0.5f;
    }

    public bool CanBeBoiled() => cookingLiquidType == CookingLiquid.Water;
    public bool CanBeRoasted() => cookingLiquidType == CookingLiquid.None;
    public bool CanBeGrilled() => cookingLiquidType == CookingLiquid.None;
    public bool CanBeSmoked() => cookingLiquidType == CookingLiquid.None;

    // 🔥 Fire hazard triggers
    public bool IsCookingHazard()
    {
        if (cookingLiquidType == CookingLiquid.Fuel) return true;

        if (cookingLiquidType == CookingLiquid.Oil)
        {
            float oilRatio = currentLiquidVolumeML / maxLiquidVolumeML;
            if (oilRatio > 0.5f) return true;
        }

        return false;
    }

    // Auto cooking method resolver
    public CookingMethod GetAvailableCookingMethod()
    {
        if (IsCookingHazard()) return CookingMethod.None;
        if (CanBeSteamed()) return CookingMethod.Steam;
        if (CanBeFried()) return CookingMethod.Fry;
        if (CanBeBoiled()) return CookingMethod.Boil;
        if (CanBeRoasted()) return CookingMethod.Roast;
        if (CanBeGrilled()) return CookingMethod.Grill;
        if (CanBeSmoked()) return CookingMethod.Smoke;

        return CookingMethod.None;
    }
}
