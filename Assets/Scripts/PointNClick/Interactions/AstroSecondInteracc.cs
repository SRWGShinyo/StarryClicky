using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroSecondInteracc : IInteractable
{
    // Start is called before the first frame update
    void Start()
    {
        if (!GameManager.activeGC.hasGivenAstroTheFish)
            Destroy(gameObject);
    }

    public override void Move()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator :  What do you hope to achieve with this ?"
            });
    }

    public override void Observe()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : Astro is looking through his telescope. He seems happy.",
            });
    }

    public override void PickUp()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Narrator : .... No."
            });
    }

    public override void TalkTo()
    {
        if (!GameManager.activeGC.hasTheCode)
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Astro :  Hey Starry ! Thanks again for the meal !",
                "Starry : No problem Astro !",
                "Astro : So, I was looking through my telescope and...I saw something.",
                "Astro : It's written 'Code 2560' in the stars ! Strange uh ?"
            });

            GameManager.activeGC.hasTheCode = true;
        }

        else
        {
            FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>() {
                "Astro :  Code 2560. For what could it be a code ?",
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
