using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyInteracc : IInteractable
{
    public InventObject papillion;

    private void Start()
    {
        if (GameManager.activeGC.taken["Butterfly"])
            Destroy(gameObject);
    }

    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Does it look like an arrow ?...wait...it kinda does..."
            });
    }

    public override void Observe()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : A bright and shiny pink butterfly was flying around...",
                "Narrator : However that may be possible in space..."
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
               "Starry : I need something to catch it..."
            });
    }

    public override void TalkTo()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : It won't speak ! How rude !"
            });
    }

    public override void Use()
    {
        if (PointNClickManager.pnClick.object1 == "Butterfly Net")
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                    "Starry : And a purple shining butterfly for me ! Whoop !"
                });

            GameManager.activeGC.AddToInventory(papillion, GameManager.activeGC.inventory.FindIndex(x => x.objectName == "Butterfly Net"));
            gameObject.SetActive(false);
        }

        else
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                    "Narrator : That...doesn't seem right."
                });
        }
    }
}
