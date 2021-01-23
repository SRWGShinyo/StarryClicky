using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointNClickManager : MonoBehaviour
{
    public enum CLICKERSTATE
    {
        IDLE,
        OBSERVE,
        USE,
        PICKUP,
        TALK,
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
}
