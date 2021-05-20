using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundBtnStop : MonoBehaviour
{
    public AudioSource Btn;
    public AudioSource Cash;
    public AudioSource Objdown;
    public AudioSource Lock;

  public void OnClickstop()
    {
        Btn.gameObject.SetActive(false);
        Cash.gameObject.SetActive(false);
        Objdown.gameObject.SetActive(false);
        Lock.gameObject.SetActive(false);
    }

}
