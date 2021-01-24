using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Invento", menuName = "Inventory/Element", order = 1)]
public class InventObject : ScriptableObject
{
    public Sprite image;
    public string objectName;
}
