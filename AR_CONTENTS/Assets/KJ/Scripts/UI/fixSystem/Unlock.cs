using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Unlock : MonoBehaviour
{
  
    Select Script;

    public GameObject LockBtn;
    // Start is called before the first frame update
    void Start()
    {
        Script = gameObject.GetComponentInParent<Select>();
    }

  

    public void OnClickUnlock()
    {
     
        Script.GetComponentInParent<Select>().enabled = true;

        LockBtn.SetActive(true);
        gameObject.SetActive(false);
        print("고정해제");

    }
}
