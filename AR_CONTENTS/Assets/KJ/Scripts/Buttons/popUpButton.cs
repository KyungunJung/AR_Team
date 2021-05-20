using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUpButton : MonoBehaviour

 {
    public GameObject exitmenu;
    public GameObject Card;
    public void OnClickPopup()
    {
        Card.gameObject.SetActive(true);
        exitmenu.SetActive(true);
        gameObject.SetActive(false);
    }
}

