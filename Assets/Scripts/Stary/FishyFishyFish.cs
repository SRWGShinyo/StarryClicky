using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishyFishyFish : MonoBehaviour
{
    public List<Transform> positions;
    Transform target;

    private void Start()
    {
        if (GameManager.activeGC.taken["Fish"])
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.activeGC.taken["Fish"])
        {
            Destroy(gameObject);
        }

        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, 0.5f * Time.deltaTime);
        }

        if (target == null || Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            int index = Random.Range(0, positions.Count);
            while (positions[index] == target)
            {
                index = Random.Range(0, positions.Count);
            }

            target = positions[index];

            transform.LookAt(target);
        }
    }
}
