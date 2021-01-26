using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineInteracc : IInteractable
{
    public InventObject purpleEssence;

    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Better not go in there..."
            });
    }

    public override void Observe()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Starry : According to the inscription there...",
                "Starry : It is a 'essence taking machine'"
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Starry : I can't move it..."
            });
    }

    public override void TalkTo()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : The blend...hm...'essence taking machine' won't talk."
            });
    }

    public override void Use()
    {
        if (PointNClickManager.pnClick.object1 == "Butterfly")
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                    "Starry : Well it's written 'essence extracting machine'...",
                    "Starry : I hope it didn't hurt it..."
                });

            GameManager.activeGC.AddToInventory(purpleEssence, GameManager.activeGC.inventory.FindIndex(x => x.objectName == "Butterfly"));
            PointNClickManager.pnClick.Rest();

        }

        else
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                    "Starry : Noo that will not work..."
                });
        }
    }
}
