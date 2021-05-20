using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBtn : MonoBehaviour
{
    public GameObject dialog;
 public void OnClickMenu()
    {
        dialog.gameObject.SetActive(true);
    }
}
