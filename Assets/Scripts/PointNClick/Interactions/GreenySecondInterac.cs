using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenySecondInterac : IInteractable
{
    void Start()
    {
        if (!GameManager.activeGC.hasGivenGreenEssence)
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
                "Narrator : Greeny was here, turning slowly.",
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
                "Starry : Hello Greeny !",
                "Greeny : Hey Starry !",
                "Starry : How are you feeling ?",
                "Greeny : Perfect ! This galaxy is very cool !",
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
