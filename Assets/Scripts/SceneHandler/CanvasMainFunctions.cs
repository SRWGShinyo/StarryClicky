using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasMainFunctions : MonoBehaviour
{
    public GameObject mainpanel;
    public GameObject creditPanel;
    public GameObject InstructionsPanel;

    private void Start()
    {
        GameManager gm = FindObjectOfType<GameManager>();
        if (gm)
        {
            GameManager.activeGC = null;
            Destroy(gm.gameObject);
        }

        PointNClickManager pnm = FindObjectOfType<PointNClickManager>();
        if (pnm)
        {
            PointNClickManager.pnClick = null;
            Destroy(pnm.gameObject);
        }
    }

    public void OpenCredit()
    {
        mainpanel.SetActive(false);
        creditPanel.SetActive(true);
    }

    public void OpenInstruction()
    {
        mainpanel.SetActive(false);
        InstructionsPanel.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
