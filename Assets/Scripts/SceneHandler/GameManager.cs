using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager activeGC;
    public Texture2D cursorText;

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

    private void Start()
    {
        Cursor.SetCursor(cursorText, Vector2.zero, CursorMode.Auto);
    }


    public bool hasIntroPlayed = false;
}
