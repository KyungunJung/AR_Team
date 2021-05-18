using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objdown : MonoBehaviour
{
  public AudioSource objdown;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            objdown.Play();
        }
    }
}
