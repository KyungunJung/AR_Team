using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmStopBtnManager : MonoBehaviour
{
    public AudioSource BGM;
    void Start()
    {
        BGM = gameObject.AddComponent<AudioSource>();
    }

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
