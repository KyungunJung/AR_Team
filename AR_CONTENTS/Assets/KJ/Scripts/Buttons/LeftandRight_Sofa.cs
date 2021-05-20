using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftandRight_Sofa : MonoBehaviour
{
    public GameObject Chair;
    public GameObject Light;
    public GameObject me;
    // Start is called before the first frame update

    public void OnClickLeft()
    {
        Light.SetActive(true);
        me.SetActive(false);
    }
    public void OnClickRight()
    {
        Chair.SetActive(true);
        me.SetActive(false);
    }
}
