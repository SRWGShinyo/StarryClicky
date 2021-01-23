using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerMotherClass : MonoBehaviour
{
    Outliner myOutline;

    void Start()
    {
        myOutline = GetComponentInChildren<Outliner>();   
    }

    void Update()
    {
        
    }
}
