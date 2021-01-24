using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkyInteracc : IInteractable
{
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

        else if (false)
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
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                    "Narrator : Nothing to use here."
            });
    }
}
