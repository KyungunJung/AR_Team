using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{

    public GameObject target;
    public GameObject chair;
    

    Vector3 truePos;
    public float gridSize;
    public GameObject tile;

    private void Start()
    {
        chair.transform.position = new Vector3(0, 0, 0); 
    }


    void Update()
    {

        

        truePos.x = Mathf.Floor(target.transform.position.x / gridSize) * gridSize;
        truePos.y = Mathf.Floor(target.transform.position.y / gridSize) * gridSize;
        truePos.z = Mathf.Floor(target.transform.position.z / gridSize) * gridSize;

        chair.transform.position = truePos;
        
        
    }

}


