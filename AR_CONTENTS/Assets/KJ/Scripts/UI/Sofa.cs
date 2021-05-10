using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sofa : MonoBehaviour
{  public GameObject Target;
    public GameObject grid;

    private void OnTriggerEnter(Collider other)
    {
        if (Target.transform.tag == "Grid")
        {
            Target.SetActive(true);
            print("ตส");
        }
    }
}
