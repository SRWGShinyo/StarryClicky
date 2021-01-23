using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IInteractable : MonoBehaviour
{
    public string nameInteractor;
    Outliner outline;

    private void Start()
    {
        outline = GetComponent<Outliner>();
        if (!outline)
            outline = GetComponentInChildren<Outliner>();
    }

    public void Desoutline()
    {
        outline.enabled = false;
    }

    public void Outline()
    {
        outline.enabled = true;
    }

    public abstract void TalkTo();
    public abstract void PickUp();
    public abstract void Observe();
    public abstract void Move();

    public abstract void Use();
}
