using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public static Manager instance;

    public GameObject loading;
    public Image loadingBg;
    

    void Update()
    {
        if(loading.activeSelf == true)
        {
            Color bgColor = loadingBg.color;
            bgColor.a += Time.deltaTime*0.5f;
            loadingBg.color = bgColor;
            if(bgColor.a <= 0)
            {
                loading.SetActive(false);
            }
        }
    }
}
