using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goToEnding : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(NextScene());
    }
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("EndingScene");

    }

}
