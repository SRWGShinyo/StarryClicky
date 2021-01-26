﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager activeGC;
    public Texture2D cursorText;

    public bool hasTalkedToAstronaut;
    public bool hasTalkedToSun;
    public bool hasTalkedToBluey;
    public bool hasTalkedToPinky;
    public bool hasTalekdToGreeny;
    public bool hasTheCode;

    public Dictionary<string, bool> taken = new Dictionary<string, bool>();
    public List<InventObject> inventory = new List<InventObject>();

    public bool hasGivenPinkEssence = false;
    public bool hasGivenGreenEssence = false;
    public bool hasGivenBlueEssence = false;
    public bool hasGivenRedEssenece = false;

    List<string> pickItems = new List<string>(){ "Butterfly Net", "Butterfly", "Purple Essence", "Fish", "Rod", "Green Essence", "Blue Essence" };

    public List<ArrowScripts.Destinations> toGoToGo = new List<ArrowScripts.Destinations>()
    {
        ArrowScripts.Destinations.UP,
        ArrowScripts.Destinations.LEFT,
        ArrowScripts.Destinations.UP,
        ArrowScripts.Destinations.RIGHT
    };

    private void Awake()
    {
        if (!activeGC)
        {
            activeGC = this;
            foreach (string s in pickItems)
                taken.Add(s, false);
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Cursor.SetCursor(cursorText, Vector2.zero, CursorMode.Auto);
    }

    public void AddToInventory(InventObject inObj, int where = -1)
    {
        if (where != -1)
            inventory[where] = inObj;
        else
            inventory.Add(inObj);
        taken[inObj.objectName] = true;
        FindObjectOfType<PointNClickManager>().UpdateInventory();
    }

    public bool hasIntroPlayed = false;
}
