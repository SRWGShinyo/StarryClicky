using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickDiscussDispatch : MonoBehaviour
{
    public void OnClickDispatch()
    {
        FindObjectOfType<PointNClickManager>().HandleClickWhenTalking();
    }
}
