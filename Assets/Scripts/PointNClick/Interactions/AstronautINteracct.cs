using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautINteracct : IInteractable
{

    private void Start()
    {
        if (GameManager.activeGC.hasGivenAstroTheFish)
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
                "Narrator : An astronaut was standing here, floating.",
                "Narrator : He seemed flustered."
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : .... No."
            });
    }

    public override void TalkTo()
    {
        if (!GameManager.activeGC.hasTalkedToAstronaut)
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : Hello ! Are you lost ?",
                "Astro : I'm not...I was looking at the galaxies with my telescope...",
                "Astro : But I'm so hungry...I need to eat...so I searched for something to eat...",
                "Astro : Nothing..."
                });
        }

        else
        {

            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Astro : So hungry...",
                "Starry : I should find him something to eat."
                });
        }

    }

    public override void Use()
    {
        if (PointNClickManager.pnClick.object1 == "Fish")
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : Hey hmm...still hungry ?",
                "Astro : Yeah...",
                "Starry : Here is a fish for ya !",
                "Astro : Oh ! Oh Thanks !! Now I can go back to my telescope !",
                "Starry : Go go !"
                });

            GameManager.activeGC.hasGivenAstroTheFish = true;
            GameManager.activeGC.inventory.RemoveAt(GameManager.activeGC.inventory.FindIndex(x => x.objectName == "Fish"));
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
