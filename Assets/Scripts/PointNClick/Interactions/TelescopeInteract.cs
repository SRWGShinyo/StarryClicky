using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelescopeInteract : IInteractable
{
    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Let's not try to go in a telescope yet."
            });
    }

    public override void Observe()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Here, standing, was a telescope.",
                "Narrator : It seemed to be pointed at something.",
                "Narrator : But starry could not use it...it would need an other pair of eyes."
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Let's let that here. Please.",
            });
    }

    public override void TalkTo()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Talking to a telescope seems...complicated.",
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
