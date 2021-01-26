using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject menu;

    void Update()
    {
        if (PointNClickManager.pnClick.state != PointNClickManager.CLICKERSTATE.MENU)
            menu.SetActive(false);
        else
            menu.SetActive(true);
    }

    public void Continue()
    {
        EventSystem.current.SetSelectedGameObject(null);
        PointNClickManager.pnClick.state = PointNClickManager.CLICKERSTATE.IDLE;
    }

    public void Quit()
    {
        EventSystem.current.SetSelectedGameObject(null);
        SceneManager.LoadScene(0);
    }
}
