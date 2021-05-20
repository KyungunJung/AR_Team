using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Howto2 : MonoBehaviour
{
    public GameObject pageL;
    public GameObject pageR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnClickNextPage()
    {
        pageR.SetActive(true);
        gameObject.SetActive(false);
    }

    public void OnClickpastPage()
    {
        pageL.SetActive(true);
        gameObject.SetActive(false);
    }
}
