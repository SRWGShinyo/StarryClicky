using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using TMPro;


public class ArrowButtonDirection : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string locationTo;


    public void OnPointerEnter(PointerEventData eventData)
    {
        PointNClickManager.pnClick.UpdateTMLocation("to " + locationTo);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        PointNClickManager.pnClick.UpdateTMLocation("Move ", true);
    }

}
