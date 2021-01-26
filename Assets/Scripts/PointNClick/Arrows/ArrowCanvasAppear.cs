using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowCanvasAppear : MonoBehaviour
{
    Image btonImage;
    Button btonBton;
    // Start is called before the first frame update
    void Start()
    {
        btonImage = GetComponent<Image>();
        btonBton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PointNClickManager.pnClick.state == PointNClickManager.CLICKERSTATE.MOVE)
        {
            btonBton.enabled = true;
            btonImage.enabled = true;
        }

        else
        {
            btonBton.enabled = false;
            btonImage.enabled = false;
        }
    }
}
