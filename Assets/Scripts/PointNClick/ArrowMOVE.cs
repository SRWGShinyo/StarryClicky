using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMOVE : MonoBehaviour
{
    public int SceneToLoad;
    public BoxCollider bb;
    public MeshRenderer render;

    private void Update()
    {
        if (PointNClickManager.pnClick.state == PointNClickManager.CLICKERSTATE.MOVE)
        {
            bb.enabled = true;
            render.enabled = true;
        }

        else
        {
            bb.enabled = false;
            render.enabled = false;
        }
    }
}
