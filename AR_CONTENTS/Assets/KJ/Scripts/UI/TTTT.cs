using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTTT : MonoBehaviour
{
    bool isMove;
    RectTransform rt;
    Transform pa;
    public RectTransform canvas;
    
    void Start()
    {
        rt = GetComponent<RectTransform>();
        pa = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        if(isMove)
        {
            Vector2 pos = Input.mousePosition;
            pos.x -= 1920 * 0.5f;
            pos.y -= 1080 * 0.5f;
            rt.anchoredPosition = pos;
        }

        if(Input.GetMouseButtonDown(0))
        {
            print(Input.mousePosition.x + ", " + Input.mousePosition.y);
        }
    }

    public void Pick()
    {
        isMove = true;
        transform.parent = canvas;
        
    }
    public void Drop()
    {
        isMove = false;
        transform.parent = pa;
        rt.anchoredPosition = Vector2.zero;
    }
}
