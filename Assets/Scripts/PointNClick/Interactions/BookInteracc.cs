using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookInteracc : IInteractable
{
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
                    "Starry : Oh, it's a book !",
                    "Starry : What's written in here ?",
                    "Starry : UP LEFT UP RIGHT",
                    "Starry : I wonder what it means..."
            });
    }

    public override void PickUp()
    {

        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                    "Narrator : Let's let the book in here."
            });
    }

    public override void TalkTo()
    {

        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                    "Narrator : I know story can be talkative but...a book won't."
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
