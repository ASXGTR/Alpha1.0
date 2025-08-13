using System;

public static class WeaponImpactResolver
{
    // 🔫 Ranged weapon impact resolution
    public static DamageProfile ResolveImpact(RangedWeaponItem weapon, AmmoModifiers ammo)
    {
        return new DamageProfile
        {
            baseDamage = weapon.baseDamage + ammo.damageModifier,
            shock = weapon.shock + ammo.shockModifier,
            force = weapon.force + ammo.forceModifier,
            pierce = weapon.pierce + ammo.pierceModifier,
            bleedChance = weapon.bleedChance + ammo.bleedChanceModifier,
            electricShock = weapon.electricShock + ammo.electricShockModifier,

            stunChance = weapon.stunChance,
            sourceWeaponName = weapon.weaponName,
            sourceAmmoName = ammo.displayName,
            loreTag = ammo.loreTag
        };
    }

    // 🪓 Melee weapon impact resolution
    public static DamageProfile ResolveImpact(MeleeWeaponItem weapon)
    {
        // Calculate shock based on weight and multiplier
        float shock = weapon.weight * weapon.shockMultiplier;

        // Calculate force with swing speed and multiplier
        float force = weapon.weight * weapon.swingSpeed * weapon.forceMultiplier;

        // Apply blunt force bonus if applicable
        if (weapon.meleeType == MeleeType.Blunt)
        {
            force *= weapon.bluntForceBonus;
        }

        return new DamageProfile
        {
            baseDamage = weapon.baseDamage,
            shock = shock,
            force = force,
            pierce = weapon.armorPierce,
            bleedChance = weapon.bleedChance,
            electricShock = 0f,

            stunChance = weapon.stunChance,
            sourceWeaponName = weapon.itemName,
            sourceAmmoName = "None",
            loreTag = string.Join(", ", weapon.itemTags)
        };
    }
}
