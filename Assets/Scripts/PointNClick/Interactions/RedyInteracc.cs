using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedyInteracc : IInteractable
{
    public MeshRenderer render;
    public Material redOn;

    private void Start()
    {
        if (GameManager.activeGC.hasGivenRedEssenece)
            Destroy(gameObject);
    }
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
                "Narrator : An non-shining red star was standing here, turning.",
                "Narrator : It seemed flustered."
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator :Don't kidnap stars !"
            });
    }

    public override void TalkTo()
    {
        if (!GameManager.activeGC.hasTalkedToPinky)
        {
            GameManager.activeGC.hasTalkedToPinky = true;
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : Hello !",
                "Redy : Hello there ! How are you ?",
                "Starry : Fine ! You ?",
                "Redy : Well...I'm not shining.",
                "Starry : I see that...what happened ?",
                "Redy : It seems like my essence was split and scattered all over the universe !",
                "Starry : Oh no ! Well, I'm an explorer so...if I find your essence, I'll bring it to you !",
                "Redy : Thanks a lot buddy !"
                });
        }

        else if (GameManager.activeGC.inventory.FindLast(x => x.objectName == "Purple Essence"))
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                 new List<string>() {
                "Starry : I have the essence...but should I give it up ?... ",
                 });
        }

        else
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : I'll find your essence !",
                "Redy : Thank you for your help !",
             });
        }
    }

    public override void Use()
    {
        if (PointNClickManager.pnClick.object1 == "Essence Part")
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : No, I need to give him the full essence...",
                "Starry : finding all the parts should do the trick !",
             });
            return;
        }

        else if (PointNClickManager.pnClick.object1 == "Red Essence")
        {
            render.material = redOn;
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : Here, your essence !",
                "Redy : Thank you so much !",
                "Starry : Well, I'm happy I helped !",
                "Redy : I would love to see your galaxy, see the galaxy of my saviour !",
                "Starry : I'll show you the way, let's meet there !"
                });

            GameManager.activeGC.hasGivenRedEssenece = true;
            GameManager.activeGC.inventory.RemoveAt(GameManager.activeGC.inventory.FindIndex(x => x.objectName == "Red Essence"));
            PointNClickManager.pnClick.UpdateInventory();
            gameObject.SetActive(false);
            return;
        }

        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                    "Narrator : Nothing to use here."
            });
    }


}
