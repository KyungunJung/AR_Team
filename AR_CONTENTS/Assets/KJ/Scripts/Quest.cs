using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Quest : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(NextScene());
    }
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("FirstScene");

    }
}
