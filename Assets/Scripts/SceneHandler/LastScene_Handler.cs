using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastScene_Handler : SceneHandlerClass
{
    public Light ligt;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.activeGC.hasSeenTheEnd = true;
        if (GameManager.activeGC.hasGivenTheEssencesToSun)
            LaunchLastTextSun();
        else
            LaunchLastTextStars();
    }

    public void LaunchLastTextSun()
    {
        ligt.intensity = 10;
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
            new List<string>()
            {
                "Narrator : And so, Starry chose to give up the essences.",
                "Narrator : The power of the sun gave it more and more light.",
                "Starry : I'm shining ! A lot ! That's awesome !",
                "Starry : But...I feel rather alone...and I can't light all the galaxy...",
                "Starry : Did I...really do the best choice ?",
                "Starry : Well, at least I'm bright ! And that's nice !"
            });
    }

    public void LaunchLastTextStars()
    {
        FindObjectOfType<PointNClickManager>().GetIntoTalking(
         new List<string>()
         {
                "Narrator : And so, Starry chose to give the essences to all the stars.",
                "Narrator : It wasn't alone anymore, although, it didn't shine more either.",
                "Starry : I'm glad I'm not alone anymore...",
                "Pinky : Well, you don't look that happy !",
                "Starry : I...really wanted to shine more y'know ? I feel like I can't light the galaxy...",
                "Bluey : Not alone you can't...",
                "Redy : But with all of us here...",
                "Greeny : ...we shine better than everything else !",
                "Narrator : And so, Starry learnt a very valuable lesson.",
                "Narrator : In order to shine more, it needed to shine less.",
                "Narrator : As the light of multiple individuals combined could easily be more intense that the one of someone alone."
         });


    }
}
