using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftandRight_Chair : MonoBehaviour
{
    public GameObject Sofa;
    public GameObject Table;
    public GameObject me;
    // Start is called before the first frame update

    public void OnClickLeft()
    {
        Sofa.SetActive(true);
        me.SetActive(false);
    }
    public void OnClickRight()
    {
        Table.SetActive(true);
        me.SetActive(false);
    }
}
