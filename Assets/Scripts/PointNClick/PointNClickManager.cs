using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class PointNClickManager : MonoBehaviour
{
    public TextMeshProUGUI tmproLocation;
    public GameObject pnClickPanel;
    public GameObject discussionPanel;

    public List<string> discussion;

    private bool isTalking;

    public enum CLICKERSTATE
    {
        IDLE,
        OBSERVE,
        USE,
        PICKUP,
        TALK,
        TALKING,
        MOVE,
        MENU
    }

    public CLICKERSTATE state = CLICKERSTATE.IDLE;

    public void GoIdle()
    {
        state = CLICKERSTATE.IDLE;
    }

    public void ClickObserve()
    {
        state = CLICKERSTATE.OBSERVE;
    }

    public void ClickUse()
    {
        state = CLICKERSTATE.USE;
    }

    public void ClickMenu()
    {
        state = CLICKERSTATE.MENU;
    }

    public void ClickMove()
    {
        state = CLICKERSTATE.MOVE;
    }

    public void ClickTalk()
    {
        state = CLICKERSTATE.TALK;
    }

    public void ClickPickUp()
    {
        state = CLICKERSTATE.PICKUP;
    }

    public void GetIntoTalking(List<string> papot)
    {
        state = CLICKERSTATE.TALKING;
        discussion = new List<string>(papot);
        string stringToPlay = discussion[0];
        StartCoroutine(Discuss(stringToPlay));

        pnClickPanel.transform.DOScale(new Vector3(0f, 0f, 0f), 0.5f);
        discussionPanel.transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    public void GetOutoTalking()
    {
        state = CLICKERSTATE.IDLE;
        discussionPanel.transform.DOScale(new Vector3(0f, 0f, 0f), 0.5f);
        pnClickPanel.transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    public void HandleClickWhenTalking()
    {
        if (state != CLICKERSTATE.TALKING)
        {
            Debug.Log("No need to advance, not talking.");
            return;
        }

        else if (discussion.Count == 0)
        {
            StopCoroutine("Discuss");
            GetOutoTalking();
        }

        else
        {
            if (isTalking)
            {
                isTalking = false;
                StopCoroutine("Discuss");
                TextMeshProUGUI tmpDiscuss = discussionPanel.GetComponentInChildren<TextMeshProUGUI>();
                tmpDiscuss.text = discussion[0];
                Debug.Log("WasTalking");
            }

            else
            {
                discussion.RemoveAt(0);
                string stringToPlay = discussion[0];
                StartCoroutine(Discuss(stringToPlay));
            }
        }
    }

    private IEnumerator Discuss(string toDiscuss)
    {
        TextMeshProUGUI tmpDiscuss = discussionPanel.GetComponentInChildren<TextMeshProUGUI>();
        tmpDiscuss.text = "";
        isTalking = true;
        foreach (char c in toDiscuss)
        {
            if (!isTalking)
                break;
            tmpDiscuss.text += c;
            yield return new WaitForSeconds(0.02f);
        }
        isTalking = false;
    }


}
