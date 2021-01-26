using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueInteract : IInteractable
{
    public MeshRenderer render;
    public Material blueOn;

    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Move is only to move...not to use on friendly stars."
            });
    }

    public override void Observe()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : A little, non-shining blue star was standing right here."
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Basically...this would be kidnapping. Don't do that."
            });
    }

    public override void TalkTo()
    {
        if (!GameManager.activeGC.hasTalkedToBluey)
        {
            GameManager.activeGC.hasTalkedToBluey = true;
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : Hello ! You seem sad...",
                "Bluey : Hello...I am Bluey...I lost my essence...",
                "Starry : That's awful ! So you don't shine anymore ?",
                "Bluey : I don't...Could you find my essence for me ?....",
                "Starry : I will do my best !"
                });
        }

        else if (false)
        {

            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : I have his essence with me...should I give it to him ?...",
                "Starry : It shines a lot...",
                });

        }

        else
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : Hi there ! I'm still searching for your essence ! ",
                "Bluey : Thanks...",
                });
        }

    }

    public override void Use()
    {
        if (PointNClickManager.pnClick.object1 == "Blue Essence")
        {
            render.material = blueOn;
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Starry : Here, your essence !",
                "Bluey : Thanks so much...",
                "Starry : Hey...you really look lonely...want to come into my galaxy ?",
                "Bluey : Oh...thanks for proposing...Yeah, with pleasure...",
                "Starry : Then see you there !"
            });

            GameManager.activeGC.hasGivenBlueEssence = true;
            GameManager.activeGC.inventory.RemoveAt(GameManager.activeGC.inventory.FindIndex(x => x.objectName == "Blue Essence"));
            PointNClickManager.pnClick.UpdateInventory();
            PointNClickManager.pnClick.Rest();
            gameObject.SetActive(false);
            return;
        }

        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                    "Narrator : Nothing to use here."
            });
    }

}
