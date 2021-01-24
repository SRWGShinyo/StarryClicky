using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowInteracc : IInteractable
{
    public override void Move()
    {
        SceneManager.LoadScene(GetComponent<ArrowMOVE>().SceneToLoad);
    }

    public override void Observe()
    {
        throw new System.NotImplementedException();
    }

    public override void PickUp()
    {
        throw new System.NotImplementedException();
    }

    public override void TalkTo()
    {
        throw new System.NotImplementedException();
    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}
