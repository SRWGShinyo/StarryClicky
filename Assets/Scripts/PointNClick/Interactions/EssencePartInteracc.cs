using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssencePartInteracc : IInteractable
{
    public InventObject essencePart;
    public InventObject redEssence;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.activeGC.taken[essencePart.objectName])
            Destroy(gameObject);
    }

    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                    "Narrator : That action makes no sense."
            });
    }

    public override void Observe()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                    "Narrator : A little, red, shiny sphere was standing here."
            });
    }

    public override void PickUp()
    {
        GameManager.activeGC.AddToInventory(essencePart);
        if (GameManager.activeGC.inventory.FindAll(x => x.objectName.Contains("Essence Part")).Count == 3)
        {
            Debug.Log("All essence parts found.");
            GameManager.activeGC.inventory.RemoveAt(GameManager.activeGC.inventory.FindIndex(x => x.objectName == "Red Essence Part 1"));
            GameManager.activeGC.inventory.RemoveAt(GameManager.activeGC.inventory.FindIndex(x => x.objectName == "Red Essence Part 2"));
            GameManager.activeGC.inventory.RemoveAt(GameManager.activeGC.inventory.FindIndex(x => x.objectName == "Red Essence Part 3"));

            GameManager.activeGC.AddToInventory(redEssence);
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                    "Starry : Okay I found all parts ! And they fused to become the big one !",
                    "Starry : What a shiny, red essence here !"
                });
        }

        else
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                    "Starry : Oh a red essence part ! That's great !",
            });
        }
        gameObject.SetActive(false);
    }

    public override void TalkTo()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                    "Narrator : ... Nope."
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
