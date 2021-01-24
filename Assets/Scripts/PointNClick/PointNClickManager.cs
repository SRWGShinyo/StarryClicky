using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.EventSystems;
using System;

public class PointNClickManager : MonoBehaviour
{
    public TextMeshProUGUI tmproLocation;
    public TextMeshProUGUI speaker;
    public TextMeshProUGUI discussionField;

    public GameObject pnClickPanel;
    public GameObject discussionPanel;

    public List<string> discussion;
    public List<GameObject> inventoryTons;

    private bool isTalking;

    public string object1;
    public string object2;

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
    private CLICKERSTATE savedState = CLICKERSTATE.IDLE;

    string toPlay = "";

    public void UpdateInventory()
    {
        for (int i = 0; i < GameManager.activeGC.inventory.Count; i++)
        {
            inventoryTons[i].GetComponent<Image>().sprite = GameManager.activeGC.inventory[i].image;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1) && (state != CLICKERSTATE.TALKING))
            GoIdle();
    }

    public void GoIdle()
    {
        EventSystem.current.SetSelectedGameObject(null);
        tmproLocation.text = FindObjectOfType<SceneHandlerClass>().sceneLocationName;
        state = CLICKERSTATE.IDLE;
    }

    public void ClickObserve()
    {
        tmproLocation.text = "Observe ";
        EventSystem.current.SetSelectedGameObject(null);
        state = CLICKERSTATE.OBSERVE;
    }

    public void ClickUse()
    {
        tmproLocation.text = "Use ";
        EventSystem.current.SetSelectedGameObject(null);
        state = CLICKERSTATE.USE;
    }

    public void ClickMenu()
    {
        EventSystem.current.SetSelectedGameObject(null);
        state = CLICKERSTATE.MENU;
    }

    public void ClickMove()
    {
        tmproLocation.text = "Move ";
        EventSystem.current.SetSelectedGameObject(null);
        state = CLICKERSTATE.MOVE;
    }

    public void ClickTalk()
    {
        tmproLocation.text = "Talk with ";
        EventSystem.current.SetSelectedGameObject(null);
        state = CLICKERSTATE.TALK;
    }

    public void ClickPickUp()
    {
        tmproLocation.text = "Pick up ";
        EventSystem.current.SetSelectedGameObject(null);
        state = CLICKERSTATE.PICKUP;
    }

    public void GetIntoTalking(List<string> papot)
    {
        toPlay = "";
        savedState = state;
        state = CLICKERSTATE.TALKING;
        discussion = new List<string>(papot);
        toPlay = discussion[0];
        StartCoroutine(Discuss(toPlay));

        pnClickPanel.transform.DOScale(new Vector3(0f, 0f, 0f), 0.5f);
        discussionPanel.transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    public void GetOutoTalking()
    {
        state = savedState;
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
                if (toPlay == "")
                    toPlay = discussion[0];

                isTalking = false;
                StopCoroutine("Discuss");
                TextMeshProUGUI tmpDiscuss = discussionPanel.GetComponentInChildren<TextMeshProUGUI>();
                discussionField.text = toPlay.Split(':')[1].TrimStart(' ');
            }

            else
            {
                discussion.RemoveAt(0);
                if (discussion.Count == 0)
                {
                    StopCoroutine("Discuss");
                    GetOutoTalking();
                }
                try
                {
                    toPlay = discussion[0];
                    StartCoroutine(Discuss(toPlay));
                }
                catch (ArgumentOutOfRangeException)
                {
                    StopCoroutine("Discuss");
                    GetOutoTalking();
                }

            }
        }
    }

    private IEnumerator Discuss(string toDiscuss)
    {
        discussionField.text = "";
        isTalking = true;
        speaker.text = toDiscuss.Split(':')[0].TrimEnd(' ');

        foreach (char c in toDiscuss.Split(':')[1].TrimStart(' '))
        {
            if (!isTalking)
                break;
            discussionField.text += c;
            yield return new WaitForSeconds(0.02f);
        }
        isTalking = false;
    }


}
