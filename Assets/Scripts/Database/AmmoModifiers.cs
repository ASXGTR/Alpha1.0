using System;

[Serializable]
public class AmmoModifiers
{
    public AmmoType ammoType;
    public string displayName;

    // 🔫 Impact modifiers (used during hit resolution)
    public float damageModifier;
    public float shockModifier;
    public float forceModifier;
    public float pierceModifier;
    public float bleedChanceModifier;
    public float electricShockModifier;

    // 🎯 Weapon stat modifiers (used during aiming/firing)
    public float accuracyModifier;

    // 🧠 Metadata
    public bool isNonLethal;
    public bool isExplosive;
    public bool isSatirical;
    public string loreTag;

    // 🛠️ Convert to WeaponStatModifier for handling logic
    public WeaponStatModifier ToWeaponStatModifier()
    {
        return WeaponStatModifier.FromFloats(
            accuracy: accuracyModifier
        // Add recoil, weight, etc. here if ammo affects them
        );
    }

    // 🧪 Optional: Convert to ImpactStatModifier if you split impact logic
    // public ImpactStatModifier ToImpactStatModifier() { ... }
}
