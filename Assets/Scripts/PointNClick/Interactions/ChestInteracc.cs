using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteracc : IInteractable
{
    public InventObject blueEssence;

    private void Start()
    {
        if (GameManager.activeGC.hasGivenBlueEssence || GameManager.activeGC.inventory.Find(x => x.objectName == "Blue Essence"))
            Destroy(gameObject);
    }

    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : The chest is tightly locked and Starry couldn't move in it."
            });
    }

    public override void Observe()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : A tightly locked chest was floating here, in space.",
                "Narrator : In spite of the obvious key lock, it seemed like Starry needed a code to open it."
            });
    }

    public override void PickUp()
    {
        if (GameManager.activeGC.hasTheCode)
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                    "Starry : Let's try the code...it opened !",
                    "Starry : Is that a blue star essence ? Great !"
                });
            GameManager.activeGC.AddToInventory(blueEssence);
            gameObject.SetActive(false);
        }

        else
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                    "Starry : Without the code, I won't open it...",
                });
        }
    }

    public override void TalkTo()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                    "Narrator : Surprisingly enough, the planks won't talk."
            });
    }

    public override void Use()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                    "Narrator : Nothing to use here."
            });
    }
}
