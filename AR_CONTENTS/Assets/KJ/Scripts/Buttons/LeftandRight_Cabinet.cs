using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftandRight_Cabinet : MonoBehaviour
{
    public GameObject Table;
    public GameObject Light;
    public GameObject me;
    // Start is called before the first frame update

    public void OnClickLeft()
    {
        Table.SetActive(true);
        me.SetActive(false);
    }
    public void OnClickRight()
    {
        Light.SetActive(true);
        me.SetActive(false);
    }
}
