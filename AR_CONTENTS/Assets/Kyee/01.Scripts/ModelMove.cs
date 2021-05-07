using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelMove : MonoBehaviour
{

    RaycastHit hit;
    Vector3 movePoint;
    public GameObject chair;

    void Start()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 50000.0f, (1<<8)))
        {

            transform.position = hit.point;
        }
            

    }

    
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 50000.0f, (1 << 8)))
        {

            transform.position = hit.point;
        }
        if(Input.GetMouseButtonDown(0))
        {
            chair.transform.position = hit.point;
        }

    }
}
