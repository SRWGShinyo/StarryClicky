using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowScripts : MonoBehaviour
{
    public 
        int indexSceneToLoad;

    public enum Destinations
    {
        LEFT,
        UP,
        RIGHT
    }
    public Destinations dest;
    
    public void Move()
    {
        SceneManager.LoadScene(indexSceneToLoad);
    }

    public void MoveLabyrinth()
    {
        if (dest != GameManager.activeGC.toGoToGo[0])
        {
            GameManager.activeGC.toGoToGo = new List<Destinations>()
            {
                Destinations.UP,
                Destinations.LEFT,
                Destinations.UP,
                Destinations.RIGHT
            };

            SceneManager.LoadScene(2);
        }

        else
        {
            GameManager.activeGC.toGoToGo.RemoveAt(0);
            if (GameManager.activeGC.toGoToGo.Count == 0)
            {
                GameManager.activeGC.toGoToGo = new List<Destinations>()
                {
                    Destinations.UP,
                    Destinations.LEFT,
                    Destinations.UP,
                    Destinations.RIGHT
                };

                SceneManager.LoadScene(10);
            }

            else
            {
                SceneManager.LoadScene(5);
            }
        }
    }
}
