using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseFunction : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject focusedPanel;

    public void Close()
    {
        mainPanel.SetActive(true);
        focusedPanel.SetActive(false);
    }
}
