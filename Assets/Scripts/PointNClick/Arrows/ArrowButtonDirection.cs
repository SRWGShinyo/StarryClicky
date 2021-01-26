using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using TMPro;


public class ArrowButtonDirection : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string locationTo;
    public int sceneToLoad;
    public TextMeshProUGUI tmproLocation;

    private void Start()
    {
        tmproLocation = GameObject.FindGameObjectWithTag("Location").GetComponent<TextMeshProUGUI>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tmproLocation.text += "to " + locationTo;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tmproLocation.text = "Move ";
    }

}
