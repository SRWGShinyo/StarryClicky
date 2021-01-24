using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInventory : MonoBehaviour
{
    public int index;

    public void SelectUsableItem()
    {
        Debug.Log(index);
        Debug.Log(GameManager.activeGC.inventory.Count);
        PointNClickManager pnclM = FindObjectOfType<PointNClickManager>();
        if (pnclM.state != PointNClickManager.CLICKERSTATE.USE)
            return;
        if ((index + 1) > GameManager.activeGC.inventory.Count)
            return;

        pnclM.SelectItemToUse(GameManager.activeGC.inventory[index].objectName);
    }
}
