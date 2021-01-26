using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextDisplayer : MonoBehaviour
{
    public List<string> textsToDisplay;
    public TextMeshProUGUI tmpro;

    void Start()
    {
        StartCoroutine(DisplayText());
    }

    private IEnumerator DisplayText()
    {
        foreach (string s in textsToDisplay)
        {
            tmpro.text = s;
            yield return new WaitForSeconds(4f);
        }

        SceneManager.LoadScene(0);
    }
}
