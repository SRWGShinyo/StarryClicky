using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolInteracc : IInteractable
{
    public InventObject fishy;

    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Wanna splash in ? You can't, we're in space."
            });
    }

    public override void Observe()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Starry : it's a...pool ?",
                "Starry : There seems to be a fish swimming here..."
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Starry : I won't be able to catch the fish like that."
            });
    }

    public override void TalkTo()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : The pool wouldn't speak."
            });
    }

    public override void Use()
    {
        if (PointNClickManager.pnClick.object1 == "Rod")
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                    "Starry : Comme to me little fish !",
                    "Starry : Oh...I think I accidentaly killed it...",
                    "Starry : So sorry fishy..."
                });

            GameManager.activeGC.AddToInventory(fishy, GameManager.activeGC.inventory.FindIndex(x => x.objectName == "Rod"));
        }

        else
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Narrator : That wouldn't work and Starry knew it.",
                "Starry : I know it !"
                });
        }
    }
}
