using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMenuBtn : MonoBehaviour
{
    public GameObject dialog;
    public GameObject soundui;
    // Start is called before the first frame update
    public void OnClickExitMenu()
    {
        dialog.SetActive(false);
        soundui.SetActive(false);
    }
}
