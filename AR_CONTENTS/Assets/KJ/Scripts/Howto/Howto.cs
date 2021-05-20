using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Howto : MonoBehaviour
{
    public GameObject page2;

    private void Start()
    {
        
    }
    public void OnClickHowto()
    {
        page2.SetActive(true);
        gameObject.SetActive(false);
    }
}
