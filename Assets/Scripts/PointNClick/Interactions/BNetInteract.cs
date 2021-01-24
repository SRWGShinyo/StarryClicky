using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BNetInteract : IInteractable
{
    public InventObject toGive;

    private void Start()
    {
        if (GameManager.activeGC.taken[toGive.objectName])
            Destroy(gameObject);
    }

    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : As far as the object seemed to be, Starry didn't need to move."
            });
    }

    public override void Observe()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Starry : It's a bit far but...It looks like a butterfly net...",
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Starry : A butterfly net ! It might come in handy.",
                "Starry : I'll take it !"
            });

        GameManager.activeGC.AddToInventory(toGive);
        gameObject.SetActive(false);
    }

    public override void TalkTo()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : What is with that wish to speak with inanimated object ?"
            });
    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}
