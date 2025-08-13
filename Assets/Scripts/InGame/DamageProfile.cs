using System;

[Serializable]
public class DamageProfile
{
    public float baseDamage;
    public float shock;
    public float force;
    public float pierce;
    public float bleedChance;
    public float electricShock;

    public float stunChance = 0f;
    public float burnChance = 0f;
    public float freezeChance = 0f;
    public float poisonChance = 0f;

    public float fireDamage = 0f;
    public float iceDamage = 0f;
    public float toxicDamage = 0f;

    public string sourceWeaponName;
    public string sourceAmmoName;
    public string loreTag;
}
