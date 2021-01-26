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
        PointNClickManager.pnClick.gameObject.GetComponent<PNClickableDetector>().savedLocation = "";
        PointNClickManager.pnClick.savedState = PointNClickManager.CLICKERSTATE.IDLE;
        PointNClickManager.pnClick.state = PointNClickManager.CLICKERSTATE.IDLE;
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
            PointNClickManager.pnClick.savedState = PointNClickManager.CLICKERSTATE.IDLE;
            PointNClickManager.pnClick.state = PointNClickManager.CLICKERSTATE.IDLE;
            SceneManager.LoadScene(6);
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
                PointNClickManager.pnClick.savedState = PointNClickManager.CLICKERSTATE.IDLE;
                PointNClickManager.pnClick.state = PointNClickManager.CLICKERSTATE.IDLE;
                SceneManager.LoadScene(8);
            }

            else
            {
                PointNClickManager.pnClick.savedState = PointNClickManager.CLICKERSTATE.IDLE;
                PointNClickManager.pnClick.state = PointNClickManager.CLICKERSTATE.IDLE;
                SceneManager.LoadScene(6);
            }
        }
    }
}
