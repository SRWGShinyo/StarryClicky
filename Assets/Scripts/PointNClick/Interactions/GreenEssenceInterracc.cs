using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenEssenceInterracc : IInteractable
{
    public InventObject greenEssence;

    private void Start()
    {
        if (GameManager.activeGC.taken[greenEssence.objectName])
            Destroy(gameObject);
    }
    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator :  What do you hope to achieve with this ?"
            });
    }

    public override void Observe()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator :  A bright, shining green sphere was standing here."
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Starry :  Oh ! It looks like a green essence !",
                "Starry : It's so shiny !"
            });

        GameManager.activeGC.AddToInventory(greenEssence);
        gameObject.SetActive(false);
    }

    public override void TalkTo()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
             new List<string>() {
                "Narrator :  Uh...no."
             });
    }

    public override void Use()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
             new List<string>() {
                "Narrator :  Nothing to use there."
             });
    }
}
