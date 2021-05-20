using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitPopup : MonoBehaviour
{
    public GameObject Funiture;
    public GameObject PopUpBtn;
    // Start is called before the first frame update
    public void OnClickExitMenu()
    {
        Funiture.SetActive(false);
        PopUpBtn.SetActive(true);
    }
}
