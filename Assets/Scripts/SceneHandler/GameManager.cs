using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager activeGC;

    private void Awake()
    {
        if (!activeGC)
        {
            activeGC = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }


    public bool hasIntroPlayed = false;
}
