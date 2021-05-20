using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundBtnPlay : MonoBehaviour
{
    public AudioSource Btn;
    public AudioSource Cash;
    public AudioSource Objdown;
    public AudioSource Lock;

    public void OnClickplay()
    {
        Btn.gameObject.SetActive(true);
        Cash.gameObject.SetActive(true);
        Objdown.gameObject.SetActive(true);
        Lock.gameObject.SetActive(true);
    }

}
