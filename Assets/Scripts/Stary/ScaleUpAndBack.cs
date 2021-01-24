using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScaleUpAndBack : MonoBehaviour
{
    bool ScaleUp = false;
    bool scaling = false;


    // Update is called once per frame
    void Update()
    {
        if (!scaling)
            StartCoroutine(Scale());
    }

    private IEnumerator Scale()
    {
        scaling = true;
        if (!ScaleUp)
            transform.DOScale(new Vector3(0.22f, 0.22f, 0.22f), 3f);
        else
            transform.DOScale(new Vector3(0.25f, 0.25f, 0.25f), 3f);

        yield return new WaitForSeconds(3f);
        scaling = false;
        ScaleUp = !ScaleUp;
    }
}
