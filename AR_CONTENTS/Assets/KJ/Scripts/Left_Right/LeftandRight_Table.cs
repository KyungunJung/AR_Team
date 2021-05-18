using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftandRight_Table : MonoBehaviour
{
    public GameObject Chair;
    public GameObject Cabinet;
    public GameObject me;
    // Start is called before the first frame update

    public void OnClickLeft()
    {
        Chair.SetActive(true);
        me.SetActive(false);
    }
    public void OnClickRight()
    {
        Cabinet.SetActive(true);
        me.SetActive(false);
    }
}
