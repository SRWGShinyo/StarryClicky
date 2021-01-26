using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkySecondInterac : IInteractable
{
    void Start()
    {
        if (!GameManager.activeGC.hasGivenPinkEssence)
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
                "Narrator : Pinky was here, lighting the sky.",
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
                "Starry : Hello Pinky !",
                "Pinky : Hey there Starry ! Thanks again for my essence !",
                "Starry : Well no problem ! I hope you like it here !",
                "Pinky : It's great ! No butterfly, no essence stealer, that's cool.",
                "Starry : No butterfly here !"
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
