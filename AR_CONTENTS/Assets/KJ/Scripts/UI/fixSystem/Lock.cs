using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lock : MonoBehaviour
{
    Select Script;
    public GameObject UnlockBtn;
    // Start is called before the first frame update
    void Start()
    {
        Script = gameObject.GetComponentInParent<Select>();
    }



    public void OnClicklock()
    {

        Script.GetComponentInParent<Select>().SetRock();

        UnlockBtn.SetActive(true);
        gameObject.SetActive(false);
        print("∞Ì¡§");

    }
}