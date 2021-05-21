using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howtofalse : MonoBehaviour
{
    public GameObject howto;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void onClickgoTitle()
    {
        howto.SetActive(true);
        gameObject.SetActive(false);
    }
}
