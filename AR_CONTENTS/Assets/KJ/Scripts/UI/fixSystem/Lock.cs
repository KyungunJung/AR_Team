using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Lock : MonoBehaviour
{
    Select Script;
    public GameObject UnlockBtn;
    GridManager clear;

    // Start is called before the first frame update
    void Start()
    {
        Script = gameObject.GetComponentInParent<Select>();
        clear = GameObject.Find("Grid").GetComponent<GridManager>();
    }



    public void OnClicklock()
    {
        clear.Check();
            Script.GetComponentInParent<Select>().SetRock();

            UnlockBtn.SetActive(true);
            gameObject.SetActive(false);
            print("∞Ì¡§");
        
        

    }
}