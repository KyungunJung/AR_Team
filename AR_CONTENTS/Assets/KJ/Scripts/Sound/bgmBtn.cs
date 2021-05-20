using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmBtn : MonoBehaviour
{
    public AudioSource BGM;
    

    // Update is called once per frame

    public void OnClickBGMStop()
    {
        BGM.Stop();
    }


    public void OnClickBGMPlay()
    {
        BGM.Play();
    }
}
