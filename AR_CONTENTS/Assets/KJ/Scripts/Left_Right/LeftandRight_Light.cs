using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftandRight_Light : MonoBehaviour
{
    public GameObject Cabinet;
    public GameObject Sofa;
    public GameObject me;
    // Start is called before the first frame update
    
    public void OnClickLeft()
    {
        Cabinet.SetActive(true);
        me.SetActive(false);
    }
    public void OnClickRight()
    {
        Sofa.SetActive(true);
        me.SetActive(false);
    }
}
