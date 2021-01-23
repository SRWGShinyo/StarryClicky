using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarryInteract : IInteractable
{
    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : This made no sense.",
                "Narrator : Starry was a bit tired, it seems."
            });
    }

    public override void Observe()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : This is starry, our little adventurer.",
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Starry would have a lot of trouble picking up itself.",
                "Narrator : It decided not to try."
            });    
    }

    public override void TalkTo()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : As lonely as it could be, starry wouldn't speak ot itself.",
            });
    }

    public override void Use()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Congratulations starry, you used yourself.",
            });
    }
}
