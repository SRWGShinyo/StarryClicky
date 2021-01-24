using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueInteract : IInteractable
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
                "Narrator : A little, non-shining blue star was standing right here."
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Basically...this would be kidnapping. Don't do that."
            });
    }

    public override void TalkTo()
    {
        if (!GameManager.activeGC.hasTalkedToBluey)
        {
            GameManager.activeGC.hasTalkedToBluey = true;
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : Hello ! You seem sad...",
                "Bluey : Hello...I am Bluey...I lost my essence...",
                "Starry : That's awful ! So you don't shine anymore ?",
                "Bluey : I don't...Could you find my essence for me ?....",
                "Starry : I will do my best !"
                });
        }

        else if (false)
        {

            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : Hi there ! I'm still searching for your essence ! ",
                "Bluey : Thanks...",
                });
        }

        else
        {

            FindObjectOfType<PointNClickManager>().GetIntoTalking(
                new List<string>() {
                "Starry : I have his essence with me...should I give it to him ?...",
                "Starry : It shines a lot...",
                });
        }

    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }

}
