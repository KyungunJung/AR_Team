using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cash : MonoBehaviour
{
   public AudioSource audioSource;
  
    public void OnClick()
    {
        audioSource.Play();
       
    }
}
