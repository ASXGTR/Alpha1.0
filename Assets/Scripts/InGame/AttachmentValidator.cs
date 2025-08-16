using System.Collections.Generic;
using UnityEngine;

public static class AttachmentValidator
{
    /// <summary>
    /// Checks if the source item can be attached to the target item.
    /// </summary>
    public static bool CanAttach(CookingItemData sourceItem, CookingItemData targetItem)
    {
        if (targetItem.attachmentPoints == null || sourceItem.itemID == null)
            return false;

        foreach (var point in targetItem.attachmentPoints)
        {
            if (point.compatibleItems == null) continue;

            foreach (var compatibleID in point.compatibleItems)
            {
                if (compatibleID == sourceItem.itemID)
                    return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Returns a list of valid attachment points on the target for the source item.
    /// </summary>
    public static List<AttachmentPoint> GetValidAttachmentPoints(CookingItemData sourceItem, CookingItemData targetItem)
    {
        var validPoints = new List<AttachmentPoint>();

        if (targetItem.attachmentPoints == null || sourceItem.itemID == null)
            return validPoints;

        foreach (var point in targetItem.attachmentPoints)
        {
            if (point.compatibleItems == null) continue;

            foreach (var compatibleID in point.compatibleItems)
            {
                if (compatibleID == sourceItem.itemID)
                {
                    validPoints.Add(point);
                    break;
                }
            }
        }

        return validPoints;
    }

    /// <summary>
    /// Checks if the target item is missing required attachments.
    /// </summary>
    public static bool IsMissingRequiredAttachments(CookingItemData targetItem)
    {
        if (targetItem.attachmentPoints == null)
            return false;

        foreach (var point in targetItem.attachmentPoints)
        {
            if (point.required)
            {
                // You can expand this to check runtime flags or actual attached items
                return true;
            }
        }

        return false;
    }
}
