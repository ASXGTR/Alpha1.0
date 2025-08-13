using System;
using System.Collections.Generic;

[Serializable]
public class RangedWeaponItem
{
    public string weaponName;
    public WeaponCategory category; // Gun, Bow, Crossbow, Thrown
    public List<AmmoType> compatibleAmmoTypes;

    // Ranged combat stats
    public float fireRate;
    public float effectiveRange;
    public float recoil;
    public float accuracy;

    // Expanded ranged impact values
    public float baseDamage;         // Primary ranged damage
    public float shock;              // Physical shock (stagger, knockback)
    public float force;              // Velocity-based impact
    public float pierce;             // Armor penetration
    public float bleedChance;        // Chance to cause bleeding
    public float electricShock;      // Only used by taser-type weapons

    // Fallback melee stats (used when out of ammo or forced into melee)
    public float meleeRange;
    public float meleeDamage;
    public float meleeShock;         // Physical impact from buttstock/pistol whip
    public float staminaCost;
    public float meleeBleedChance;
    public float stunChance;         // Can be triggered by melee or taser dry stun

    // General properties
    public float condition;
    public float weight;
    public bool isAutomatic;
    public bool canFireWithoutAmmo;

    // Attachments
    public List<WeaponAttachment> attachments;

    // Lore & dev diary
    public string loreTag;
    public string intentionalSpelling;
}
