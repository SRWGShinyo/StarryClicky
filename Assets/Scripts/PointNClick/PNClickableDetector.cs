using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PNClickableDetector : MonoBehaviour
{
    public TextMeshProUGUI locationText;

    IInteractable hoverInteract;
    string savedLocation = "";

    void Update()
    {
        DetectMouseOnInteractable();
        if (Input.GetMouseButtonDown(0) &&
            FindObjectOfType<PointNClickManager>().state != PointNClickManager.CLICKERSTATE.TALKING &&
            hoverInteract != null)
        {
            DispatchOrder();
        }
    }

    private void DispatchOrder()
    {
        PointNClickManager.CLICKERSTATE state = FindObjectOfType<PointNClickManager>().state;
        switch (state)
        {
            case PointNClickManager.CLICKERSTATE.MOVE:
                hoverInteract.Move();
                break;
            case PointNClickManager.CLICKERSTATE.PICKUP:
                hoverInteract.PickUp();
                break;
            case PointNClickManager.CLICKERSTATE.TALK:
                hoverInteract.TalkTo();
                break;
            case PointNClickManager.CLICKERSTATE.USE:
                hoverInteract.Use();
                break;
            case PointNClickManager.CLICKERSTATE.OBSERVE:
                hoverInteract.Observe();
                break;
            default:
                return;
        }
    }

    private void DetectMouseOnInteractable()
    {
        if (FindObjectOfType<PointNClickManager>().state == PointNClickManager.CLICKERSTATE.TALKING)
            return;

        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            if (hit.transform.gameObject != null && hit.transform.gameObject.GetComponent<IInteractable>() != null)
            {
                IInteractable nw = hit.transform.gameObject.GetComponent<IInteractable>();

                if (hoverInteract == nw)
                    return;

                if (hoverInteract != null)
                {
                    hoverInteract.Desoutline();
                    hoverInteract = null;
                }

                savedLocation = locationText.text;
                if (FindObjectOfType<PointNClickManager>().state == PointNClickManager.CLICKERSTATE.IDLE)
                    locationText.text = nw.nameInteractor;
                else
                    locationText.text += nw.nameInteractor;

                nw.Outline();
                hoverInteract = nw;
            }

            else
            {
                if (hoverInteract != null)
                {
                    locationText.text = savedLocation;
                    hoverInteract.Desoutline();
                    hoverInteract = null;
                }
            }
        }

        else
        {
            if (hoverInteract != null)
            {
                locationText.text = savedLocation;
                hoverInteract.Desoutline();
                hoverInteract = null;
            }
        }
    }
}
