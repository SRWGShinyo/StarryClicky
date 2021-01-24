using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Hover : MonoBehaviour
{
    float startY;
    bool goUp = false;
    bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (!moving)
            StartCoroutine(HoverC());
    }

    private IEnumerator HoverC()
    {
        moving = true;
        if (!goUp)
        {
            transform.DOMove(new Vector3(transform.position.x, startY - 1f, transform.position.z), 2f);
            transform.DOScale(new Vector3(0.8f, 0.8f, 0.8f), 2f);
        }
        else
        {
            transform.DOMove(new Vector3(transform.position.x, startY + 0.5f, transform.position.z), 2f);
            transform.DOScale(new Vector3(1f, 1f, 1f), 2f);
        }

        yield return new WaitForSeconds(2f);
        goUp = !goUp;
        moving = false;
    }
}
