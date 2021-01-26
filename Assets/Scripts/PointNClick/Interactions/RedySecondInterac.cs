using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedySecondInterac : IInteractable
{
    // Start is called before the first frame update
    void Start()
    {
        if (!GameManager.activeGC.hasGivenRedEssenece)
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
                "Narrator : Redy was here, gently floating in Starry's galaxy.",
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
                "Starry : Hello Redy !",
                "Redy : Hey Starry ! Thanks again for my essence !",
                "Starry : No problem ! Do you like it here ?",
                "Redy : I looove it ! Really !",
                "Starry : Nice !"
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
