using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public void ApplyImpact(GameObject target, DamageProfile impact)
    {
        // Apply base damage (placeholder)
        // Replace with actual health system when ready
        Debug.Log($"[CombatManager] {impact.sourceWeaponName} hit {target.name} with {impact.sourceAmmoName} for {impact.baseDamage} damage.");

        // Apply shock/force (placeholder)
        Rigidbody rb = target.GetComponent<Rigidbody>();
        if (rb != null && impact.force > 0f)
        {
            Vector3 knockbackDir = (target.transform.position - transform.position).normalized;
            rb.AddForce(knockbackDir * impact.force, ForceMode.Impulse);
        }

        // Placeholder for bleed/stun/effects
        if (impact.bleedChance > 0f)
        {
            Debug.Log($"[CombatManager] Bleed chance triggered: {impact.bleedChance}");
        }

        if (impact.stunChance > 0f)
        {
            Debug.Log($"[CombatManager] Stun chance triggered: {impact.stunChance}");
        }

        if (impact.electricShock > 0f)
        {
            Debug.Log($"[CombatManager] Electric shock applied: {impact.electricShock}");
        }

        // Optional: log lore tag
        if (!string.IsNullOrEmpty(impact.loreTag))
        {
            Debug.Log($"[CombatManager] Lore tag: {impact.loreTag}");
        }
    }
}
