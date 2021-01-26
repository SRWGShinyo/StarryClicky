using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueySecondInteraction : IInteractable
{
    void Start()
    {
        if (!GameManager.activeGC.hasGivenBlueEssence)
            Destroy(gameObject);
    }
    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : How did you do that ?",
            });
    }

    public override void Observe()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Bluey was here, shining calmly.",
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Still not."
            });
    }

    public override void TalkTo()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Starry : Hello Bluey !",
                "Bluey : Hi...",
                "Starry : Do you like my galaxy ?",
                "Bluey : Yes...It's very quiet...I love it...",
                "Starry : Well uh...great !"
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
