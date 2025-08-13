using System;

[Serializable]
public class AmmoModifiers
{
    public AmmoType ammoType;
    public string displayName;

    // Stat modifiers applied to weapon impact
    public float damageModifier;
    public float shockModifier;
    public float forceModifier;
    public float pierceModifier;
    public float bleedChanceModifier;
    public float accuracyModifier;
    public float electricShockModifier;

    // Metadata
    public bool isNonLethal;
    public bool isExplosive;
    public bool isSatirical;
    public string loreTag;
}
