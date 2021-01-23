using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1_Handler : MonoBehaviour
{
    public List<string> intro;

    void Start()
    {
        if (!GameManager.activeGC.hasIntroPlayed)
            PlayIntro();
    }

    private void PlayIntro()
    {
        GameManager.activeGC.hasIntroPlayed = true;
        FindObjectOfType<PointNClickManager>().GetIntoTalking(intro);
    }
}
