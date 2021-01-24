using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveToRandomPosition : MonoBehaviour
{
    public List<Transform> positions;
    int positionSelected = 0;
    bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving)
            StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        isMoving = true;
        int index = Random.Range(0, positions.Count);
        while (index == positionSelected)
            index = Random.Range(0, positions.Count);
        positionSelected = index;
        transform.DOMove(positions[positionSelected].position, 5f);
        yield return new WaitForSeconds(5f);
        isMoving = false;
    }
}
