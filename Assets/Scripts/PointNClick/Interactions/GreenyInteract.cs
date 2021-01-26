using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenyInteract : IInteractable
{
    public MeshRenderer render;
    public Material greenOn;

    private void Start()
    {
        if (GameManager.activeGC.hasGivenGreenEssence)
            Destroy(gameObject);
    }

    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                    "Narrator : Wouldn't work."
            });
    }

    public override void Observe()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                    "Narrator : A green, non shining star was standing here. Rotating."
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                    "Narrator : Starry wanted to shine more, but not to resort to kidnapping."
            });
    }

    public override void TalkTo()
    {
        if (!GameManager.activeGC.hasTalekdToGreeny)
        {
            GameManager.activeGC.hasTalekdToGreeny = true;
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : Hello !",
                "Greeny : Oh Hello there ! Are you lost ?",
                "Starry : No, I'm an explorer !",
                "Greeny : An explorer ! You didn't stumble across a green essence during your journeys ?",
                "Starry : Nope...sorry...",
                "Greeny : Too bad...",
                "Starry : If I do, I'll tell you !",
                });
        }

        else if (GameManager.activeGC.inventory.FindLast(x => x.objectName == "Green Essence"))
        {

            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : I have its essence with me...should I give it to him ?...",
                "Starry : It shines a lot...",
                });

        }

        else
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : Hi there ! I'm still searching for your essence ! ",
                "Greeny : I wish I could help you more !",
                });
        }
    }

    public override void Use()
    {
        if (PointNClickManager.pnClick.object1 == "Green Essence")
        {
            render.material = greenOn;
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Starry : Here, your essence !",
                "Greeny : You found it ! Thanks !",
                "Starry : That was no problem !",
                "Greeny : I like you ! Meet me in your galaxy !",
                "Starry : Great then, see you !"
            });

            GameManager.activeGC.hasGivenGreenEssence = true;
            GameManager.activeGC.inventory.RemoveAt(GameManager.activeGC.inventory.FindIndex(x => x.objectName == "Green Essence"));
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
