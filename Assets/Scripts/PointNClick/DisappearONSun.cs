using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearONSun : MonoBehaviour
{
    void Start()
    {
        if (GameManager.activeGC.hasGivenTheEssencesToSun)
            Destroy(gameObject);
    }
}
