using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesetroyReliquat : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GameManager gm = FindObjectOfType<GameManager>();
        if (gm)
        {
            GameManager.activeGC = null;
            Destroy(gm.gameObject);
        }

        PointNClickManager pnm = FindObjectOfType<PointNClickManager>();
        if (pnm)
        {
            PointNClickManager.pnClick = null;
            Destroy(pnm.gameObject);
        }
    }

}
