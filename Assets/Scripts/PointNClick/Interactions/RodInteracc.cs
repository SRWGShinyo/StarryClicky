using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodInteracc : IInteractable
{
    public InventObject rod;

    private void Start()
    {
        if (GameManager.activeGC.taken["Rod"])
            Destroy(gameObject);
    }

    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : ...Moving on."
            });
    }

    public override void Observe()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : A fishing rod was standing right here",
                "Narrator : As to catch space fishes"
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Starry : What is this rod doing here ?",
                "Starry : I might as well just take it."
            });

        GameManager.activeGC.AddToInventory(rod);
        gameObject.SetActive(false);
    }

    public override void TalkTo()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Seems like the rod isn't in a talkative mood.",
                "Narrator : ...can't believe I just said that."
            });
    }

    public override void Use()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Nothing to use with this rod"
            });
    }
}
