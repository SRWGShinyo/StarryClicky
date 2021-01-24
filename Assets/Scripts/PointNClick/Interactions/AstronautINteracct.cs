using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautINteracct : IInteractable
{

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
                "Astro : But I'm so hungry...I need to eat..."
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
        throw new System.NotImplementedException();
    }
}
