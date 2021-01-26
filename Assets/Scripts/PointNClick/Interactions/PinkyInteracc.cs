using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkyInteracc : IInteractable
{
    public MeshRenderer render;

    public Material lightupPurple;

    private void Start()
    {
        if (GameManager.activeGC.hasGivenPinkEssence)
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
                "Narrator : A purple, non-shining star, was standing here."
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : We won't do that."
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
                "Pinky : Oh, hello... I never saw you here !",
                "Starry : Yeah, I'm travelling !",
                "Pinky : That sure seems great...",
                "Starry : is something wrong ?",
                "Pinky : That butterfly stole my essence ! And I can't capture it !",
                "Starry : Oh...",
                "Starry : I'll try to do something about that !"
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
                "Pinky : Thank you for your help, that butterfly annoys me.",
             });
        }
    }

    public override void Use()
    {
        if (PointNClickManager.pnClick.object1 == "Butterfly")
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : I'll got the butterfly !",
                "Pinky : Great ! Well done ! But...",
                "Starry : Yeah, I need to find a way to retrieve your essence now...",
                "Pinky : Yap"
             });
            return;
        }

        else if (PointNClickManager.pnClick.object1 == "Purple Essence")
        {
            render.material = lightupPurple;
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : Here, your essence !",
                "Pinky : Oooh thanks you so much ! You're the best !",
                "Starry : Well, I'm happy I helped !",
                "Pinky : Y'know...I feel like we could become good friend. Mind if I join you in your galaxy ?",
                "Starry : Oh not at all ! Let's meet there !"
                });

            GameManager.activeGC.hasGivenPinkEssence = true;
            GameManager.activeGC.inventory.RemoveAt(GameManager.activeGC.inventory.FindIndex(x => x.objectName == "Purple Essence"));
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
