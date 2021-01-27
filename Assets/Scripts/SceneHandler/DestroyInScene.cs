using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyInScene : MonoBehaviour
{
    public string sceneNameToDestroy;

    public static DestroyInScene dd;

    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == sceneNameToDestroy)
        {
            dd = null;
            Destroy(gameObject);
        }

        else
        {
            if (dd == null)
            {
                dd = this;
                DontDestroyOnLoad(gameObject);
            }

            else
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnLevelWasLoaded(int level)
    {
        if (SceneManager.GetActiveScene().name == sceneNameToDestroy)
            Destroy(gameObject);
    }
}
