using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunInterract : IInteractable
{
    public InventObject redEssence;
    public InventObject greenEssence;
    public InventObject blueEssence;
    public InventObject pinkEssence;

    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : No, Starry wouldn't do that.",
                "Narrator : It would be a bit...hot."
            });
    }

    public override void Observe()
    {
        if (!GameManager.activeGC.hasTalkedToSun)
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : A huge star was here, enlighting the dark cold space.",
                "Narrator : It gave out a very soft and warm light. A big one."
            });
        }

        else
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : The Sun stood here, unmoving.",
                "Narrator : Waiting for Starry to finish its quest."
            });
        }
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
        new List<string>() {
                "Narrator : That wouldn't fit in Starry's inventory.",
                "Narrator : Wherever that was."
        });
    }

    public override void TalkTo()
    {
        if (!GameManager.activeGC.hasTalkedToSun)
        {
            GameManager.activeGC.hasTalkedToSun = true;
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Starry : Uh...Hello ?",
                "Sun : Hello, little star. I never saw you around here.",
                "Starry : I am Starry ! I am an explorer.",
                "Sun : And what are you looking for, Starry ?",
                "Starry : I want to shine brighter, and to light my galaxy.",
                "Starry : You shine a lot ! How do you do it ?",
                "Sun : I try to be the best star I can.",
                "Starry : The best star...",
                "Sun : Bring to me four star essences. If you do, I'll help you shine brighter.",
                "Starry : Five star essences ? How will I recognize them ?",
                "Sun : They will shine a lot, there are what gives a star its light.",
                "Starry : But how will I find them ?",
                "Sun : You will. I know it."
            });
        }

        else if (GameManager.activeGC.inventory.Contains(pinkEssence) && GameManager.activeGC.inventory.Contains(blueEssence)
            && GameManager.activeGC.inventory.Contains(greenEssence) && GameManager.activeGC.inventory.Contains(redEssence))
        {
            GameManager.activeGC.hasGivenTheEssencesToSun = true;
            GameManager.activeGC.inventory.Clear();
            PointNClickManager.pnClick.UpdateInventory();

            FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Starry : I've got all the essences ! You can take them !",
                "Sun : Perfect. Thank you. I'll make you bright. Brighter than you ever were.",
                "Starry : Yaaay !!"
            });
        }

        else if (GameManager.activeGC.hasGivenGreenEssence || GameManager.activeGC.hasGivenPinkEssence 
                || GameManager.activeGC.hasGivenBlueEssence || GameManager.activeGC.hasGivenRedEssenece)
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Sun : Do you have the essences yet ?",
                "Starry : Yeah...I'm searching.",
                "Starry : I already gave up one of the essences...",
                "Starry : I hope it won't be a problem...",
            });
        }

        else
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Sun : Do you have the essences yet ?",
                "Starry : I'm searching for them !",
                "Sun : Fine. I need four."
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
